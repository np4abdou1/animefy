﻿using System;
using System.Collections;
using System.Text;

namespace System.Xml.Schema
{
	// Token: 0x0200028F RID: 655
	internal sealed class DtdValidator : BaseValidator
	{
		// Token: 0x060014AE RID: 5294 RVA: 0x00077125 File Offset: 0x00075325
		internal DtdValidator(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) : base(reader, null, eventHandling)
		{
			this.processIdentityConstraints = processIdentityConstraints;
			this.Init();
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00077148 File Offset: 0x00075348
		private void Init()
		{
			this.validationStack = new HWStack(10);
			this.textValue = new StringBuilder();
			this.name = XmlQualifiedName.Empty;
			this.attPresence = new Hashtable();
			this.schemaInfo = new SchemaInfo();
			this.checkDatatype = false;
			this.Push(this.name);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x000771A4 File Offset: 0x000753A4
		public override void Validate()
		{
			if (this.schemaInfo.SchemaType == SchemaType.DTD)
			{
				switch (this.reader.NodeType)
				{
				case XmlNodeType.Element:
					this.ValidateElement();
					if (!this.reader.IsEmptyElement)
					{
						return;
					}
					break;
				case XmlNodeType.Attribute:
				case XmlNodeType.Entity:
				case XmlNodeType.Document:
				case XmlNodeType.DocumentType:
				case XmlNodeType.DocumentFragment:
				case XmlNodeType.Notation:
					return;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
					base.ValidateText();
					return;
				case XmlNodeType.EntityReference:
					if (!this.GenEntity(new XmlQualifiedName(this.reader.LocalName, this.reader.Prefix)))
					{
						base.ValidateText();
						return;
					}
					return;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Comment:
					this.ValidatePIComment();
					return;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					if (this.MeetsStandAloneConstraint())
					{
						base.ValidateWhitespace();
						return;
					}
					return;
				case XmlNodeType.EndElement:
					break;
				default:
					return;
				}
				this.ValidateEndElement();
				return;
			}
			if (this.reader.Depth == 0 && this.reader.NodeType == XmlNodeType.Element)
			{
				base.SendValidationEvent("No DTD found.", this.name.ToString(), XmlSeverityType.Warning);
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000772AC File Offset: 0x000754AC
		private bool MeetsStandAloneConstraint()
		{
			if (this.reader.StandAlone && this.context.ElementDecl != null && this.context.ElementDecl.IsDeclaredInExternal && this.context.ElementDecl.ContentValidator.ContentType == XmlSchemaContentType.ElementOnly)
			{
				base.SendValidationEvent("The standalone document declaration must have a value of 'no'.");
				return false;
			}
			return true;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0007730B File Offset: 0x0007550B
		private void ValidatePIComment()
		{
			if (this.context.NeedValidateChildren && this.context.ElementDecl.ContentValidator == ContentValidator.Empty)
			{
				base.SendValidationEvent("The element cannot contain comment or processing instruction. Content model is empty.");
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0007733C File Offset: 0x0007553C
		private void ValidateElement()
		{
			this.elementName.Init(this.reader.LocalName, this.reader.Prefix);
			if (this.reader.Depth == 0 && !this.schemaInfo.DocTypeName.IsEmpty && !this.schemaInfo.DocTypeName.Equals(this.elementName))
			{
				base.SendValidationEvent("Root element name must match the DocType name.");
			}
			else
			{
				this.ValidateChildElement();
			}
			this.ProcessElement();
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000773BC File Offset: 0x000755BC
		private void ValidateChildElement()
		{
			if (this.context.NeedValidateChildren)
			{
				int num = 0;
				this.context.ElementDecl.ContentValidator.ValidateElement(this.elementName, this.context, out num);
				if (num < 0)
				{
					XmlSchemaValidator.ElementValidationError(this.elementName, this.context, base.EventHandler, this.reader, this.reader.BaseURI, base.PositionInfo.LineNumber, base.PositionInfo.LinePosition, null);
				}
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00077440 File Offset: 0x00075640
		private void ValidateStartElement()
		{
			if (this.context.ElementDecl != null)
			{
				base.Reader.SchemaTypeObject = this.context.ElementDecl.SchemaType;
				if (base.Reader.IsEmptyElement && this.context.ElementDecl.DefaultValueTyped != null)
				{
					base.Reader.TypedValueObject = this.context.ElementDecl.DefaultValueTyped;
					this.context.IsNill = true;
				}
				if (this.context.ElementDecl.HasRequiredAttribute)
				{
					this.attPresence.Clear();
				}
			}
			if (base.Reader.MoveToFirstAttribute())
			{
				do
				{
					try
					{
						this.reader.SchemaTypeObject = null;
						SchemaAttDef attDef = this.context.ElementDecl.GetAttDef(new XmlQualifiedName(this.reader.LocalName, this.reader.Prefix));
						if (attDef != null)
						{
							if (this.context.ElementDecl != null && this.context.ElementDecl.HasRequiredAttribute)
							{
								this.attPresence.Add(attDef.Name, attDef);
							}
							base.Reader.SchemaTypeObject = attDef.SchemaType;
							if (attDef.Datatype != null && !this.reader.IsDefault)
							{
								this.CheckValue(base.Reader.Value, attDef);
							}
						}
						else
						{
							base.SendValidationEvent("The '{0}' attribute is not declared.", this.reader.Name);
						}
					}
					catch (XmlSchemaException ex)
					{
						ex.SetSource(base.Reader.BaseURI, base.PositionInfo.LineNumber, base.PositionInfo.LinePosition);
						base.SendValidationEvent(ex);
					}
				}
				while (base.Reader.MoveToNextAttribute());
				base.Reader.MoveToElement();
			}
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00077604 File Offset: 0x00075804
		private void ValidateEndStartElement()
		{
			if (this.context.ElementDecl.HasRequiredAttribute)
			{
				try
				{
					this.context.ElementDecl.CheckAttributes(this.attPresence, base.Reader.StandAlone);
				}
				catch (XmlSchemaException ex)
				{
					ex.SetSource(base.Reader.BaseURI, base.PositionInfo.LineNumber, base.PositionInfo.LinePosition);
					base.SendValidationEvent(ex);
				}
			}
			if (this.context.ElementDecl.Datatype != null)
			{
				this.checkDatatype = true;
				this.hasSibling = false;
				this.textString = string.Empty;
				this.textValue.Length = 0;
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000776C0 File Offset: 0x000758C0
		private void ProcessElement()
		{
			SchemaElementDecl elementDecl = this.schemaInfo.GetElementDecl(this.elementName);
			this.Push(this.elementName);
			if (elementDecl != null)
			{
				this.context.ElementDecl = elementDecl;
				this.ValidateStartElement();
				this.ValidateEndStartElement();
				this.context.NeedValidateChildren = true;
				elementDecl.ContentValidator.InitValidation(this.context);
				return;
			}
			base.SendValidationEvent("The '{0}' element is not declared.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
			this.context.ElementDecl = null;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00077756 File Offset: 0x00075956
		public override void CompleteValidation()
		{
			if (this.schemaInfo.SchemaType == SchemaType.DTD)
			{
				do
				{
					this.ValidateEndElement();
				}
				while (this.Pop());
				this.CheckForwardRefs();
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0007777C File Offset: 0x0007597C
		private void ValidateEndElement()
		{
			if (this.context.ElementDecl != null)
			{
				if (this.context.NeedValidateChildren && !this.context.ElementDecl.ContentValidator.CompleteValidation(this.context))
				{
					XmlSchemaValidator.CompleteValidationError(this.context, base.EventHandler, this.reader, this.reader.BaseURI, base.PositionInfo.LineNumber, base.PositionInfo.LinePosition, null);
				}
				if (this.checkDatatype)
				{
					string value = (!this.hasSibling) ? this.textString : this.textValue.ToString();
					this.CheckValue(value, null);
					this.checkDatatype = false;
					this.textValue.Length = 0;
					this.textString = string.Empty;
				}
			}
			this.Pop();
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0007784D File Offset: 0x00075A4D
		public override bool PreserveWhitespace
		{
			get
			{
				return this.context.ElementDecl != null && this.context.ElementDecl.ContentValidator.PreserveWhitespace;
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00077874 File Offset: 0x00075A74
		private void ProcessTokenizedType(XmlTokenizedType ttype, string name)
		{
			switch (ttype)
			{
			case XmlTokenizedType.ID:
				if (this.processIdentityConstraints)
				{
					if (this.FindId(name) != null)
					{
						base.SendValidationEvent("'{0}' is already used as an ID.", name);
						return;
					}
					this.AddID(name, this.context.LocalName);
					return;
				}
				break;
			case XmlTokenizedType.IDREF:
				if (this.processIdentityConstraints && this.FindId(name) == null)
				{
					this.idRefListHead = new IdRefNode(this.idRefListHead, name, base.PositionInfo.LineNumber, base.PositionInfo.LinePosition);
					return;
				}
				break;
			case XmlTokenizedType.IDREFS:
				break;
			case XmlTokenizedType.ENTITY:
				BaseValidator.ProcessEntity(this.schemaInfo, name, this, base.EventHandler, base.Reader.BaseURI, base.PositionInfo.LineNumber, base.PositionInfo.LinePosition);
				break;
			default:
				return;
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0007793C File Offset: 0x00075B3C
		private void CheckValue(string value, SchemaAttDef attdef)
		{
			try
			{
				this.reader.TypedValueObject = null;
				bool flag = attdef != null;
				XmlSchemaDatatype xmlSchemaDatatype = flag ? attdef.Datatype : this.context.ElementDecl.Datatype;
				if (xmlSchemaDatatype != null)
				{
					if (xmlSchemaDatatype.TokenizedType != XmlTokenizedType.CDATA)
					{
						value = value.Trim();
					}
					object obj = xmlSchemaDatatype.ParseValue(value, base.NameTable, DtdValidator.namespaceManager);
					this.reader.TypedValueObject = obj;
					XmlTokenizedType tokenizedType = xmlSchemaDatatype.TokenizedType;
					if (tokenizedType == XmlTokenizedType.ENTITY || tokenizedType == XmlTokenizedType.ID || tokenizedType == XmlTokenizedType.IDREF)
					{
						if (xmlSchemaDatatype.Variety == XmlSchemaDatatypeVariety.List)
						{
							string[] array = (string[])obj;
							for (int i = 0; i < array.Length; i++)
							{
								this.ProcessTokenizedType(xmlSchemaDatatype.TokenizedType, array[i]);
							}
						}
						else
						{
							this.ProcessTokenizedType(xmlSchemaDatatype.TokenizedType, (string)obj);
						}
					}
					SchemaDeclBase schemaDeclBase = flag ? attdef : this.context.ElementDecl;
					if (schemaDeclBase.Values != null && !schemaDeclBase.CheckEnumeration(obj))
					{
						if (xmlSchemaDatatype.TokenizedType == XmlTokenizedType.NOTATION)
						{
							base.SendValidationEvent("'{0}' is not in the notation list.", obj.ToString());
						}
						else
						{
							base.SendValidationEvent("'{0}' is not in the enumeration list.", obj.ToString());
						}
					}
					if (!schemaDeclBase.CheckValue(obj))
					{
						if (flag)
						{
							base.SendValidationEvent("The value of the '{0}' attribute does not equal its fixed value.", attdef.Name.ToString());
						}
						else
						{
							base.SendValidationEvent("The value of the '{0}' element does not equal its fixed value.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
						}
					}
				}
			}
			catch (XmlSchemaException)
			{
				if (attdef != null)
				{
					base.SendValidationEvent("The '{0}' attribute has an invalid value according to its data type.", attdef.Name.ToString());
				}
				else
				{
					base.SendValidationEvent("The '{0}' element has an invalid value according to its data type.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
				}
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00077B0C File Offset: 0x00075D0C
		internal void AddID(string name, object node)
		{
			if (this.IDs == null)
			{
				this.IDs = new Hashtable();
			}
			this.IDs.Add(name, node);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00077B2E File Offset: 0x00075D2E
		public override object FindId(string name)
		{
			if (this.IDs != null)
			{
				return this.IDs[name];
			}
			return null;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00077B48 File Offset: 0x00075D48
		private bool GenEntity(XmlQualifiedName qname)
		{
			string text = qname.Name;
			if (text[0] == '#')
			{
				return false;
			}
			if (SchemaEntity.IsPredefinedEntity(text))
			{
				return false;
			}
			SchemaEntity entity = this.GetEntity(qname, false);
			if (entity == null)
			{
				throw new XmlException("Reference to undeclared entity '{0}'.", text);
			}
			if (!entity.NData.IsEmpty)
			{
				throw new XmlException("Reference to unparsed entity '{0}'.", text);
			}
			if (this.reader.StandAlone && entity.DeclaredInExternal)
			{
				base.SendValidationEvent("The standalone document declaration must have a value of 'no'.");
			}
			return true;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00077BC8 File Offset: 0x00075DC8
		private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity)
		{
			SchemaEntity result;
			if (fParameterEntity)
			{
				if (this.schemaInfo.ParameterEntities.TryGetValue(qname, out result))
				{
					return result;
				}
			}
			else if (this.schemaInfo.GeneralEntities.TryGetValue(qname, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00077C08 File Offset: 0x00075E08
		private void CheckForwardRefs()
		{
			IdRefNode next;
			for (IdRefNode idRefNode = this.idRefListHead; idRefNode != null; idRefNode = next)
			{
				if (this.FindId(idRefNode.Id) == null)
				{
					base.SendValidationEvent(new XmlSchemaException("Reference to undeclared ID is '{0}'.", idRefNode.Id, this.reader.BaseURI, idRefNode.LineNo, idRefNode.LinePos));
				}
				next = idRefNode.Next;
				idRefNode.Next = null;
			}
			this.idRefListHead = null;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00077C74 File Offset: 0x00075E74
		private void Push(XmlQualifiedName elementName)
		{
			this.context = (ValidationState)this.validationStack.Push();
			if (this.context == null)
			{
				this.context = new ValidationState();
				this.validationStack.AddToTop(this.context);
			}
			this.context.LocalName = elementName.Name;
			this.context.Namespace = elementName.Namespace;
			this.context.HasMatched = false;
			this.context.IsNill = false;
			this.context.NeedValidateChildren = false;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00077D01 File Offset: 0x00075F01
		private bool Pop()
		{
			if (this.validationStack.Length > 1)
			{
				this.validationStack.Pop();
				this.context = (ValidationState)this.validationStack.Peek();
				return true;
			}
			return false;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00077D38 File Offset: 0x00075F38
		public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
		{
			try
			{
				string text = attdef.DefaultValueExpanded;
				XmlSchemaDatatype datatype = attdef.Datatype;
				if (datatype != null)
				{
					if (datatype.TokenizedType != XmlTokenizedType.CDATA)
					{
						text = text.Trim();
					}
					attdef.DefaultValueTyped = datatype.ParseValue(text, readerAdapter.NameTable, readerAdapter.NamespaceResolver);
				}
			}
			catch (Exception)
			{
				IValidationEventHandling validationEventHandling = ((IDtdParserAdapterWithValidation)readerAdapter).ValidationEventHandling;
				if (validationEventHandling != null)
				{
					XmlSchemaException exception = new XmlSchemaException("The default value of '{0}' attribute is invalid according to its datatype.", attdef.Name.ToString());
					validationEventHandling.SendEvent(exception, XmlSeverityType.Error);
				}
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00077DC4 File Offset: 0x00075FC4
		public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr)
		{
			try
			{
				if (baseUriStr == null)
				{
					baseUriStr = string.Empty;
				}
				XmlSchemaDatatype datatype = attdef.Datatype;
				if (datatype != null)
				{
					object defaultValueTyped = attdef.DefaultValueTyped;
					XmlTokenizedType tokenizedType = datatype.TokenizedType;
					if (tokenizedType == XmlTokenizedType.ENTITY)
					{
						if (datatype.Variety == XmlSchemaDatatypeVariety.List)
						{
							string[] array = (string[])defaultValueTyped;
							for (int i = 0; i < array.Length; i++)
							{
								BaseValidator.ProcessEntity(sinfo, array[i], eventHandling, baseUriStr, attdef.ValueLineNumber, attdef.ValueLinePosition);
							}
						}
						else
						{
							BaseValidator.ProcessEntity(sinfo, (string)defaultValueTyped, eventHandling, baseUriStr, attdef.ValueLineNumber, attdef.ValueLinePosition);
						}
					}
					else if (tokenizedType == XmlTokenizedType.ENUMERATION && !attdef.CheckEnumeration(defaultValueTyped) && eventHandling != null)
					{
						XmlSchemaException exception = new XmlSchemaException("'{0}' is not in the enumeration list.", defaultValueTyped.ToString(), baseUriStr, attdef.ValueLineNumber, attdef.ValueLinePosition);
						eventHandling.SendEvent(exception, XmlSeverityType.Error);
					}
				}
			}
			catch (Exception)
			{
				if (eventHandling != null)
				{
					XmlSchemaException exception2 = new XmlSchemaException("The default value of '{0}' attribute is invalid according to its datatype.", attdef.Name.ToString());
					eventHandling.SendEvent(exception2, XmlSeverityType.Error);
				}
			}
		}

		// Token: 0x04000D8D RID: 3469
		private static DtdValidator.NamespaceManager namespaceManager = new DtdValidator.NamespaceManager();

		// Token: 0x04000D8E RID: 3470
		private HWStack validationStack;

		// Token: 0x04000D8F RID: 3471
		private Hashtable attPresence;

		// Token: 0x04000D90 RID: 3472
		private XmlQualifiedName name = XmlQualifiedName.Empty;

		// Token: 0x04000D91 RID: 3473
		private Hashtable IDs;

		// Token: 0x04000D92 RID: 3474
		private IdRefNode idRefListHead;

		// Token: 0x04000D93 RID: 3475
		private bool processIdentityConstraints;

		// Token: 0x02000290 RID: 656
		private class NamespaceManager : XmlNamespaceManager
		{
			// Token: 0x060014C7 RID: 5319 RVA: 0x00077ED4 File Offset: 0x000760D4
			public override string LookupNamespace(string prefix)
			{
				return prefix;
			}
		}
	}
}
