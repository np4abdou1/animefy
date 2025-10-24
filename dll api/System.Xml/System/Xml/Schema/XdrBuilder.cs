using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml.XmlConfiguration;

namespace System.Xml.Schema
{
	// Token: 0x020002C0 RID: 704
	internal sealed class XdrBuilder : SchemaBuilder
	{
		// Token: 0x06001718 RID: 5912 RVA: 0x000915C0 File Offset: 0x0008F7C0
		internal XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
		{
			this._SchemaInfo = sinfo;
			this._TargetNamespace = targetNamspace;
			this._reader = reader;
			this._CurNsMgr = curmgr;
			this.validationEventHandler = eventhandler;
			this._StateHistory = new HWStack(10);
			this._ElementDef = new XdrBuilder.ElementContent();
			this._AttributeDef = new XdrBuilder.AttributeContent();
			this._GroupStack = new HWStack(10);
			this._GroupDef = new XdrBuilder.GroupContent();
			this._NameTable = nameTable;
			this._SchemaNames = schemaNames;
			this._CurState = XdrBuilder.S_SchemaEntries[0];
			this.positionInfo = PositionInfo.GetPositionInfo(this._reader);
			this.xmlResolver = XmlReaderSection.CreateDefaultResolver();
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00091678 File Offset: 0x0008F878
		internal override bool ProcessElement(string prefix, string name, string ns)
		{
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(name, XmlSchemaDatatype.XdrCanonizeUri(ns, this._NameTable, this._SchemaNames));
			if (this.GetNextState(xmlQualifiedName))
			{
				this.Push();
				if (this._CurState._InitFunc != null)
				{
					this._CurState._InitFunc(this, xmlQualifiedName);
				}
				return true;
			}
			if (!this.IsSkipableElement(xmlQualifiedName))
			{
				this.SendValidationEvent("The '{0}' element is not supported in this context.", XmlQualifiedName.ToString(name, prefix));
			}
			return false;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000916EC File Offset: 0x0008F8EC
		internal override void ProcessAttribute(string prefix, string name, string ns, string value)
		{
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(name, XmlSchemaDatatype.XdrCanonizeUri(ns, this._NameTable, this._SchemaNames));
			int i = 0;
			while (i < this._CurState._Attributes.Length)
			{
				XdrBuilder.XdrAttributeEntry xdrAttributeEntry = this._CurState._Attributes[i];
				if (this._SchemaNames.TokenToQName[(int)xdrAttributeEntry._Attribute].Equals(xmlQualifiedName))
				{
					XdrBuilder.XdrBuildFunction buildFunc = xdrAttributeEntry._BuildFunc;
					if (xdrAttributeEntry._Datatype.TokenizedType == XmlTokenizedType.QName)
					{
						string text;
						XmlQualifiedName xmlQualifiedName2 = XmlQualifiedName.Parse(value, this._CurNsMgr, out text);
						xmlQualifiedName2.Atomize(this._NameTable);
						if (text.Length != 0)
						{
							if (xdrAttributeEntry._Attribute != SchemaNames.Token.SchemaType)
							{
								throw new XmlException("This is an unexpected token. The expected token is '{0}'.", "NAME");
							}
						}
						else if (this.IsGlobal(xdrAttributeEntry._SchemaFlags))
						{
							xmlQualifiedName2 = new XmlQualifiedName(xmlQualifiedName2.Name, this._TargetNamespace);
						}
						else
						{
							xmlQualifiedName2 = new XmlQualifiedName(xmlQualifiedName2.Name);
						}
						buildFunc(this, xmlQualifiedName2, text);
						return;
					}
					buildFunc(this, xdrAttributeEntry._Datatype.ParseValue(value, this._NameTable, this._CurNsMgr), string.Empty);
					return;
				}
				else
				{
					i++;
				}
			}
			if (ns == this._SchemaNames.NsXmlNs && XdrBuilder.IsXdrSchema(value))
			{
				this.LoadSchema(value);
				return;
			}
			if (!this.IsSkipableAttribute(xmlQualifiedName))
			{
				this.SendValidationEvent("The '{0}' attribute is not supported in this context.", XmlQualifiedName.ToString(xmlQualifiedName.Name, prefix));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x00091856 File Offset: 0x0008FA56
		internal XmlResolver XmlResolver
		{
			set
			{
				this.xmlResolver = value;
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00091860 File Offset: 0x0008FA60
		private bool LoadSchema(string uri)
		{
			if (this.xmlResolver == null)
			{
				return false;
			}
			uri = this._NameTable.Add(uri);
			if (this._SchemaInfo.TargetNamespaces.ContainsKey(uri))
			{
				return false;
			}
			SchemaInfo schemaInfo = null;
			Uri baseUri = this.xmlResolver.ResolveUri(null, this._reader.BaseURI);
			XmlReader xmlReader = null;
			try
			{
				Uri uri2 = this.xmlResolver.ResolveUri(baseUri, uri.Substring("x-schema:".Length));
				Stream input = (Stream)this.xmlResolver.GetEntity(uri2, null, null);
				xmlReader = new XmlTextReader(uri2.ToString(), input, this._NameTable);
				schemaInfo = new SchemaInfo();
				Parser parser = new Parser(SchemaType.XDR, this._NameTable, this._SchemaNames, this.validationEventHandler);
				parser.XmlResolver = this.xmlResolver;
				parser.Parse(xmlReader, uri);
				schemaInfo = parser.XdrSchema;
			}
			catch (XmlException ex)
			{
				this.SendValidationEvent("Cannot load the schema for the namespace '{0}' - {1}", new string[]
				{
					uri,
					ex.Message
				}, XmlSeverityType.Warning);
				schemaInfo = null;
			}
			finally
			{
				if (xmlReader != null)
				{
					xmlReader.Close();
				}
			}
			if (schemaInfo != null && schemaInfo.ErrorCount == 0)
			{
				this._SchemaInfo.Add(schemaInfo, this.validationEventHandler);
				return true;
			}
			return false;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000919A4 File Offset: 0x0008FBA4
		internal static bool IsXdrSchema(string uri)
		{
			return uri.Length >= "x-schema:".Length && string.Compare(uri, 0, "x-schema:", 0, "x-schema:".Length, StringComparison.Ordinal) == 0 && !uri.StartsWith("x-schema:#", StringComparison.Ordinal);
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContentParsed()
		{
			return true;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00008B54 File Offset: 0x00006D54
		internal override void ProcessMarkup(XmlNode[] markup)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000919E3 File Offset: 0x0008FBE3
		internal override void ProcessCData(string value)
		{
			if (this._CurState._AllowText)
			{
				this._Text = value;
				return;
			}
			this.SendValidationEvent("The following text is not allowed in this context: '{0}'.", value);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00091A06 File Offset: 0x0008FC06
		internal override void StartChildren()
		{
			if (this._CurState._BeginChildFunc != null)
			{
				this._CurState._BeginChildFunc(this);
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00091A26 File Offset: 0x0008FC26
		internal override void EndChildren()
		{
			if (this._CurState._EndChildFunc != null)
			{
				this._CurState._EndChildFunc(this);
			}
			this.Pop();
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00091A4C File Offset: 0x0008FC4C
		private void Push()
		{
			this._StateHistory.Push();
			this._StateHistory[this._StateHistory.Length - 1] = this._CurState;
			this._CurState = this._NextState;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00091A84 File Offset: 0x0008FC84
		private void Pop()
		{
			this._CurState = (XdrBuilder.XdrEntry)this._StateHistory.Pop();
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00091A9C File Offset: 0x0008FC9C
		private void PushGroupInfo()
		{
			this._GroupStack.Push();
			this._GroupStack[this._GroupStack.Length - 1] = XdrBuilder.GroupContent.Copy(this._GroupDef);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00091ACD File Offset: 0x0008FCCD
		private void PopGroupInfo()
		{
			this._GroupDef = (XdrBuilder.GroupContent)this._GroupStack.Pop();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00091AE5 File Offset: 0x0008FCE5
		private static void XDR_InitRoot(XdrBuilder builder, object obj)
		{
			builder._SchemaInfo.SchemaType = SchemaType.XDR;
			builder._ElementDef._ElementDecl = null;
			builder._ElementDef._AttDefList = null;
			builder._AttributeDef._AttDef = null;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00091B17 File Offset: 0x0008FD17
		private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix)
		{
			builder._XdrName = (string)obj;
			builder._XdrPrefix = prefix;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00008574 File Offset: 0x00006774
		private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix)
		{
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00091B2C File Offset: 0x0008FD2C
		private static void XDR_BeginRoot(XdrBuilder builder)
		{
			if (builder._TargetNamespace == null)
			{
				if (builder._XdrName != null)
				{
					builder._TargetNamespace = builder._NameTable.Add("x-schema:#" + builder._XdrName);
				}
				else
				{
					builder._TargetNamespace = string.Empty;
				}
			}
			builder._SchemaInfo.TargetNamespaces.Add(builder._TargetNamespace, true);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00091B90 File Offset: 0x0008FD90
		private static void XDR_EndRoot(XdrBuilder builder)
		{
			while (builder._UndefinedAttributeTypes != null)
			{
				XmlQualifiedName xmlQualifiedName = builder._UndefinedAttributeTypes._TypeName;
				if (xmlQualifiedName.Namespace.Length == 0)
				{
					xmlQualifiedName = new XmlQualifiedName(xmlQualifiedName.Name, builder._TargetNamespace);
				}
				SchemaAttDef schemaAttDef;
				if (builder._SchemaInfo.AttributeDecls.TryGetValue(xmlQualifiedName, out schemaAttDef))
				{
					builder._UndefinedAttributeTypes._Attdef = schemaAttDef.Clone();
					builder._UndefinedAttributeTypes._Attdef.Name = xmlQualifiedName;
					builder.XDR_CheckAttributeDefault(builder._UndefinedAttributeTypes, builder._UndefinedAttributeTypes._Attdef);
				}
				else
				{
					builder.SendValidationEvent("The '{0}' attribute is not declared.", xmlQualifiedName.Name);
				}
				builder._UndefinedAttributeTypes = builder._UndefinedAttributeTypes._Next;
			}
			foreach (object obj in builder._UndeclaredElements.Values)
			{
				SchemaElementDecl schemaElementDecl = (SchemaElementDecl)obj;
				builder.SendValidationEvent("The '{0}' element is not declared.", XmlQualifiedName.ToString(schemaElementDecl.Name.Name, schemaElementDecl.Prefix));
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00091CB8 File Offset: 0x0008FEB8
		private static void XDR_InitElementType(XdrBuilder builder, object obj)
		{
			builder._ElementDef._ElementDecl = new SchemaElementDecl();
			builder._contentValidator = new ParticleContentValidator(XmlSchemaContentType.Mixed);
			builder._contentValidator.IsOpen = true;
			builder._ElementDef._ContentAttr = 0;
			builder._ElementDef._OrderAttr = 0;
			builder._ElementDef._MasterGroupRequired = false;
			builder._ElementDef._ExistTerminal = false;
			builder._ElementDef._AllowDataType = true;
			builder._ElementDef._HasDataType = false;
			builder._ElementDef._EnumerationRequired = false;
			builder._ElementDef._AttDefList = new Hashtable();
			builder._ElementDef._MaxLength = uint.MaxValue;
			builder._ElementDef._MinLength = uint.MaxValue;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00091D6C File Offset: 0x0008FF6C
		private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix)
		{
			XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
			if (builder._SchemaInfo.ElementDecls.ContainsKey(xmlQualifiedName))
			{
				builder.SendValidationEvent("The '{0}' element has already been declared.", XmlQualifiedName.ToString(xmlQualifiedName.Name, prefix));
			}
			builder._ElementDef._ElementDecl.Name = xmlQualifiedName;
			builder._ElementDef._ElementDecl.Prefix = prefix;
			builder._SchemaInfo.ElementDecls.Add(xmlQualifiedName, builder._ElementDef._ElementDecl);
			if (builder._UndeclaredElements[xmlQualifiedName] != null)
			{
				builder._UndeclaredElements.Remove(xmlQualifiedName);
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00091E02 File Offset: 0x00090002
		private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix)
		{
			builder._ElementDef._ContentAttr = builder.GetContent((XmlQualifiedName)obj);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00091E1B File Offset: 0x0009001B
		private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix)
		{
			builder._contentValidator.IsOpen = builder.GetModel((XmlQualifiedName)obj);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00091E34 File Offset: 0x00090034
		private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix)
		{
			builder._ElementDef._OrderAttr = (builder._GroupDef._Order = builder.GetOrder((XmlQualifiedName)obj));
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00091E68 File Offset: 0x00090068
		private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix)
		{
			builder._ElementDef._HasDataType = true;
			string text = ((string)obj).Trim();
			if (text.Length == 0)
			{
				builder.SendValidationEvent("The DataType value cannot be empty.");
				return;
			}
			XmlSchemaDatatype xmlSchemaDatatype = XmlSchemaDatatype.FromXdrName(text);
			if (xmlSchemaDatatype == null)
			{
				builder.SendValidationEvent("Reference to an unknown data type, '{0}'.", text);
			}
			builder._ElementDef._ElementDecl.Datatype = xmlSchemaDatatype;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00091EC8 File Offset: 0x000900C8
		private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix)
		{
			builder._ElementDef._EnumerationRequired = true;
			builder._ElementDef._ElementDecl.Values = new List<string>((string[])obj);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00091EF1 File Offset: 0x000900F1
		private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix)
		{
			XdrBuilder.ParseDtMaxLength(ref builder._ElementDef._MaxLength, obj, builder);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00091F05 File Offset: 0x00090105
		private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix)
		{
			XdrBuilder.ParseDtMinLength(ref builder._ElementDef._MinLength, obj, builder);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00091F1C File Offset: 0x0009011C
		private static void XDR_BeginElementType(XdrBuilder builder)
		{
			string text = null;
			string msg = null;
			if (builder._ElementDef._ElementDecl.Name.IsEmpty)
			{
				text = "The '{0}' attribute is either invalid or missing.";
				msg = "name";
			}
			else
			{
				if (builder._ElementDef._HasDataType)
				{
					if (!builder._ElementDef._AllowDataType)
					{
						text = "Content must be \"textOnly\" when using DataType on an ElementType.";
						goto IL_1F4;
					}
					builder._ElementDef._ContentAttr = 2;
				}
				else if (builder._ElementDef._ContentAttr == 0)
				{
					switch (builder._ElementDef._OrderAttr)
					{
					case 0:
						builder._ElementDef._ContentAttr = 3;
						builder._ElementDef._OrderAttr = 1;
						break;
					case 1:
						builder._ElementDef._ContentAttr = 3;
						break;
					case 2:
						builder._ElementDef._ContentAttr = 4;
						break;
					case 3:
						builder._ElementDef._ContentAttr = 4;
						break;
					}
				}
				bool isOpen = builder._contentValidator.IsOpen;
				XdrBuilder.ElementContent elementDef = builder._ElementDef;
				switch (builder._ElementDef._ContentAttr)
				{
				case 1:
					builder._ElementDef._ElementDecl.ContentValidator = ContentValidator.Empty;
					builder._contentValidator = null;
					break;
				case 2:
					builder._ElementDef._ElementDecl.ContentValidator = ContentValidator.TextOnly;
					builder._GroupDef._Order = 1;
					builder._contentValidator = null;
					break;
				case 3:
					if (elementDef._OrderAttr != 0 && elementDef._OrderAttr != 1)
					{
						text = "The order must be many when content is mixed.";
						goto IL_1F4;
					}
					builder._GroupDef._Order = 1;
					elementDef._MasterGroupRequired = true;
					builder._contentValidator.IsOpen = isOpen;
					break;
				case 4:
					builder._contentValidator = new ParticleContentValidator(XmlSchemaContentType.ElementOnly);
					if (elementDef._OrderAttr == 0)
					{
						builder._GroupDef._Order = 2;
					}
					elementDef._MasterGroupRequired = true;
					builder._contentValidator.IsOpen = isOpen;
					break;
				}
				if (elementDef._ContentAttr == 3 || elementDef._ContentAttr == 4)
				{
					builder._contentValidator.Start();
					builder._contentValidator.OpenGroup();
				}
			}
			IL_1F4:
			if (text != null)
			{
				builder.SendValidationEvent(text, msg);
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00092128 File Offset: 0x00090328
		private static void XDR_EndElementType(XdrBuilder builder)
		{
			SchemaElementDecl elementDecl = builder._ElementDef._ElementDecl;
			if (builder._UndefinedAttributeTypes != null && builder._ElementDef._AttDefList != null)
			{
				XdrBuilder.DeclBaseInfo declBaseInfo = builder._UndefinedAttributeTypes;
				XdrBuilder.DeclBaseInfo declBaseInfo2 = declBaseInfo;
				while (declBaseInfo != null)
				{
					SchemaAttDef schemaAttDef = null;
					if (declBaseInfo._ElementDecl == elementDecl)
					{
						XmlQualifiedName typeName = declBaseInfo._TypeName;
						schemaAttDef = (SchemaAttDef)builder._ElementDef._AttDefList[typeName];
						if (schemaAttDef != null)
						{
							declBaseInfo._Attdef = schemaAttDef.Clone();
							declBaseInfo._Attdef.Name = typeName;
							builder.XDR_CheckAttributeDefault(declBaseInfo, schemaAttDef);
							if (declBaseInfo == builder._UndefinedAttributeTypes)
							{
								declBaseInfo = (builder._UndefinedAttributeTypes = declBaseInfo._Next);
								declBaseInfo2 = declBaseInfo;
							}
							else
							{
								declBaseInfo2._Next = declBaseInfo._Next;
								declBaseInfo = declBaseInfo2._Next;
							}
						}
					}
					if (schemaAttDef == null)
					{
						if (declBaseInfo != builder._UndefinedAttributeTypes)
						{
							declBaseInfo2 = declBaseInfo2._Next;
						}
						declBaseInfo = declBaseInfo._Next;
					}
				}
			}
			if (builder._ElementDef._MasterGroupRequired)
			{
				builder._contentValidator.CloseGroup();
				if (!builder._ElementDef._ExistTerminal)
				{
					if (builder._contentValidator.IsOpen)
					{
						builder._ElementDef._ElementDecl.ContentValidator = ContentValidator.Any;
						builder._contentValidator = null;
					}
					else if (builder._ElementDef._ContentAttr != 3)
					{
						builder.SendValidationEvent("There is a missing element.");
					}
				}
				else if (builder._GroupDef._Order == 1)
				{
					builder._contentValidator.AddStar();
				}
			}
			if (elementDecl.Datatype != null)
			{
				XmlTokenizedType tokenizedType = elementDecl.Datatype.TokenizedType;
				if (tokenizedType == XmlTokenizedType.ENUMERATION && !builder._ElementDef._EnumerationRequired)
				{
					builder.SendValidationEvent("The dt:values attribute is missing.");
				}
				if (tokenizedType != XmlTokenizedType.ENUMERATION && builder._ElementDef._EnumerationRequired)
				{
					builder.SendValidationEvent("Data type should be enumeration when the values attribute is present.");
				}
			}
			XdrBuilder.CompareMinMaxLength(builder._ElementDef._MinLength, builder._ElementDef._MaxLength, builder);
			elementDecl.MaxLength = (long)((ulong)builder._ElementDef._MaxLength);
			elementDecl.MinLength = (long)((ulong)builder._ElementDef._MinLength);
			if (builder._contentValidator != null)
			{
				builder._ElementDef._ElementDecl.ContentValidator = builder._contentValidator.Finish(true);
				builder._contentValidator = null;
			}
			builder._ElementDef._ElementDecl = null;
			builder._ElementDef._AttDefList = null;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00092360 File Offset: 0x00090560
		private static void XDR_InitAttributeType(XdrBuilder builder, object obj)
		{
			XdrBuilder.AttributeContent attributeDef = builder._AttributeDef;
			attributeDef._AttDef = new SchemaAttDef(XmlQualifiedName.Empty, null);
			attributeDef._Required = false;
			attributeDef._Prefix = null;
			attributeDef._Default = null;
			attributeDef._MinVal = 0U;
			attributeDef._MaxVal = 1U;
			attributeDef._EnumerationRequired = false;
			attributeDef._HasDataType = false;
			attributeDef._Global = (builder._StateHistory.Length == 2);
			attributeDef._MaxLength = uint.MaxValue;
			attributeDef._MinLength = uint.MaxValue;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000923D8 File Offset: 0x000905D8
		private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix)
		{
			XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
			builder._AttributeDef._Name = xmlQualifiedName;
			builder._AttributeDef._Prefix = prefix;
			builder._AttributeDef._AttDef.Name = xmlQualifiedName;
			if (builder._ElementDef._ElementDecl != null)
			{
				if (builder._ElementDef._AttDefList[xmlQualifiedName] == null)
				{
					builder._ElementDef._AttDefList.Add(xmlQualifiedName, builder._AttributeDef._AttDef);
					return;
				}
				builder.SendValidationEvent("The '{0}' attribute has already been declared for this ElementType.", XmlQualifiedName.ToString(xmlQualifiedName.Name, prefix));
				return;
			}
			else
			{
				xmlQualifiedName = new XmlQualifiedName(xmlQualifiedName.Name, builder._TargetNamespace);
				builder._AttributeDef._AttDef.Name = xmlQualifiedName;
				if (!builder._SchemaInfo.AttributeDecls.ContainsKey(xmlQualifiedName))
				{
					builder._SchemaInfo.AttributeDecls.Add(xmlQualifiedName, builder._AttributeDef._AttDef);
					return;
				}
				builder.SendValidationEvent("The '{0}' attribute has already been declared for this ElementType.", XmlQualifiedName.ToString(xmlQualifiedName.Name, prefix));
				return;
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000924D4 File Offset: 0x000906D4
		private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix)
		{
			builder._AttributeDef._Required = XdrBuilder.IsYes(obj, builder);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000924E8 File Offset: 0x000906E8
		private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix)
		{
			builder._AttributeDef._Default = obj;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000924F8 File Offset: 0x000906F8
		private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix)
		{
			XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
			builder._AttributeDef._HasDataType = true;
			builder._AttributeDef._AttDef.Datatype = builder.CheckDatatype(xmlQualifiedName.Name);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00092534 File Offset: 0x00090734
		private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix)
		{
			builder._AttributeDef._EnumerationRequired = true;
			builder._AttributeDef._AttDef.Values = new List<string>((string[])obj);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0009255D File Offset: 0x0009075D
		private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix)
		{
			XdrBuilder.ParseDtMaxLength(ref builder._AttributeDef._MaxLength, obj, builder);
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00092571 File Offset: 0x00090771
		private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix)
		{
			XdrBuilder.ParseDtMinLength(ref builder._AttributeDef._MinLength, obj, builder);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00092585 File Offset: 0x00090785
		private static void XDR_BeginAttributeType(XdrBuilder builder)
		{
			if (builder._AttributeDef._Name.IsEmpty)
			{
				builder.SendValidationEvent("The '{0}' attribute is either invalid or missing.");
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x000925A4 File Offset: 0x000907A4
		private static void XDR_EndAttributeType(XdrBuilder builder)
		{
			string text = null;
			if (builder._AttributeDef._HasDataType && builder._AttributeDef._AttDef.Datatype != null)
			{
				XmlTokenizedType tokenizedType = builder._AttributeDef._AttDef.Datatype.TokenizedType;
				if (tokenizedType == XmlTokenizedType.ENUMERATION && !builder._AttributeDef._EnumerationRequired)
				{
					text = "The dt:values attribute is missing.";
					goto IL_164;
				}
				if (tokenizedType != XmlTokenizedType.ENUMERATION && builder._AttributeDef._EnumerationRequired)
				{
					text = "Data type should be enumeration when the values attribute is present.";
					goto IL_164;
				}
				if (builder._AttributeDef._Default != null && tokenizedType == XmlTokenizedType.ID)
				{
					text = "An attribute or element of type xs:ID or derived from xs:ID, should not have a value constraint.";
					goto IL_164;
				}
			}
			else
			{
				builder._AttributeDef._AttDef.Datatype = XmlSchemaDatatype.FromXmlTokenizedType(XmlTokenizedType.CDATA);
			}
			XdrBuilder.CompareMinMaxLength(builder._AttributeDef._MinLength, builder._AttributeDef._MaxLength, builder);
			builder._AttributeDef._AttDef.MaxLength = (long)((ulong)builder._AttributeDef._MaxLength);
			builder._AttributeDef._AttDef.MinLength = (long)((ulong)builder._AttributeDef._MinLength);
			if (builder._AttributeDef._Default != null)
			{
				builder._AttributeDef._AttDef.DefaultValueRaw = (builder._AttributeDef._AttDef.DefaultValueExpanded = (string)builder._AttributeDef._Default);
				builder.CheckDefaultAttValue(builder._AttributeDef._AttDef);
			}
			builder.SetAttributePresence(builder._AttributeDef._AttDef, builder._AttributeDef._Required);
			IL_164:
			if (text != null)
			{
				builder.SendValidationEvent(text);
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00092720 File Offset: 0x00090920
		private static void XDR_InitElement(XdrBuilder builder, object obj)
		{
			if (builder._ElementDef._HasDataType || builder._ElementDef._ContentAttr == 1 || builder._ElementDef._ContentAttr == 2)
			{
				builder.SendValidationEvent("Element is not allowed when the content is empty or textOnly.");
			}
			builder._ElementDef._AllowDataType = false;
			builder._ElementDef._HasType = false;
			builder._ElementDef._MinVal = 1U;
			builder._ElementDef._MaxVal = 1U;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00092794 File Offset: 0x00090994
		private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix)
		{
			XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
			if (!builder._SchemaInfo.ElementDecls.ContainsKey(xmlQualifiedName) && (SchemaElementDecl)builder._UndeclaredElements[xmlQualifiedName] == null)
			{
				SchemaElementDecl value = new SchemaElementDecl(xmlQualifiedName, prefix);
				builder._UndeclaredElements.Add(xmlQualifiedName, value);
			}
			builder._ElementDef._HasType = true;
			if (builder._ElementDef._ExistTerminal)
			{
				builder.AddOrder();
			}
			else
			{
				builder._ElementDef._ExistTerminal = true;
			}
			builder._contentValidator.AddName(xmlQualifiedName, null);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0009281F File Offset: 0x00090A1F
		private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix)
		{
			builder._ElementDef._MinVal = XdrBuilder.ParseMinOccurs(obj, builder);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00092833 File Offset: 0x00090A33
		private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix)
		{
			builder._ElementDef._MaxVal = XdrBuilder.ParseMaxOccurs(obj, builder);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00092847 File Offset: 0x00090A47
		private static void XDR_EndElement(XdrBuilder builder)
		{
			if (builder._ElementDef._HasType)
			{
				XdrBuilder.HandleMinMax(builder._contentValidator, builder._ElementDef._MinVal, builder._ElementDef._MaxVal);
				return;
			}
			builder.SendValidationEvent("The '{0}' attribute is either invalid or missing.");
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00092883 File Offset: 0x00090A83
		private static void XDR_InitAttribute(XdrBuilder builder, object obj)
		{
			if (builder._BaseDecl == null)
			{
				builder._BaseDecl = new XdrBuilder.DeclBaseInfo();
			}
			builder._BaseDecl._MinOccurs = 0U;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000928A4 File Offset: 0x00090AA4
		private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix)
		{
			builder._BaseDecl._TypeName = (XmlQualifiedName)obj;
			builder._BaseDecl._Prefix = prefix;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000928C3 File Offset: 0x00090AC3
		private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix)
		{
			if (XdrBuilder.IsYes(obj, builder))
			{
				builder._BaseDecl._MinOccurs = 1U;
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000928DA File Offset: 0x00090ADA
		private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix)
		{
			builder._BaseDecl._Default = obj;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000928E8 File Offset: 0x00090AE8
		private static void XDR_BeginAttribute(XdrBuilder builder)
		{
			if (builder._BaseDecl._TypeName.IsEmpty)
			{
				builder.SendValidationEvent("The '{0}' attribute is either invalid or missing.");
			}
			SchemaAttDef schemaAttDef = null;
			XmlQualifiedName typeName = builder._BaseDecl._TypeName;
			string prefix = builder._BaseDecl._Prefix;
			if (builder._ElementDef._AttDefList != null)
			{
				schemaAttDef = (SchemaAttDef)builder._ElementDef._AttDefList[typeName];
			}
			if (schemaAttDef == null)
			{
				XmlQualifiedName key = typeName;
				if (prefix.Length == 0)
				{
					key = new XmlQualifiedName(typeName.Name, builder._TargetNamespace);
				}
				SchemaAttDef schemaAttDef2;
				if (builder._SchemaInfo.AttributeDecls.TryGetValue(key, out schemaAttDef2))
				{
					schemaAttDef = schemaAttDef2.Clone();
					schemaAttDef.Name = typeName;
				}
				else if (prefix.Length != 0)
				{
					builder.SendValidationEvent("The '{0}' attribute is not declared.", XmlQualifiedName.ToString(typeName.Name, prefix));
				}
			}
			if (schemaAttDef != null)
			{
				builder.XDR_CheckAttributeDefault(builder._BaseDecl, schemaAttDef);
			}
			else
			{
				schemaAttDef = new SchemaAttDef(typeName, prefix);
				builder._UndefinedAttributeTypes = new XdrBuilder.DeclBaseInfo
				{
					_Checking = true,
					_Attdef = schemaAttDef,
					_TypeName = builder._BaseDecl._TypeName,
					_ElementDecl = builder._ElementDef._ElementDecl,
					_MinOccurs = builder._BaseDecl._MinOccurs,
					_Default = builder._BaseDecl._Default,
					_Next = builder._UndefinedAttributeTypes
				};
			}
			builder._ElementDef._ElementDecl.AddAttDef(schemaAttDef);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00092A53 File Offset: 0x00090C53
		private static void XDR_EndAttribute(XdrBuilder builder)
		{
			builder._BaseDecl.Reset();
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00092A60 File Offset: 0x00090C60
		private static void XDR_InitGroup(XdrBuilder builder, object obj)
		{
			if (builder._ElementDef._ContentAttr == 1 || builder._ElementDef._ContentAttr == 2)
			{
				builder.SendValidationEvent("The group is not allowed when ElementType has empty or textOnly content.");
			}
			builder.PushGroupInfo();
			builder._GroupDef._MinVal = 1U;
			builder._GroupDef._MaxVal = 1U;
			builder._GroupDef._HasMaxAttr = false;
			builder._GroupDef._HasMinAttr = false;
			if (builder._ElementDef._ExistTerminal)
			{
				builder.AddOrder();
			}
			builder._ElementDef._ExistTerminal = false;
			builder._contentValidator.OpenGroup();
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00092AF4 File Offset: 0x00090CF4
		private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix)
		{
			builder._GroupDef._Order = builder.GetOrder((XmlQualifiedName)obj);
			if (builder._ElementDef._ContentAttr == 3 && builder._GroupDef._Order != 1)
			{
				builder.SendValidationEvent("The order must be many when content is mixed.");
			}
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00092B34 File Offset: 0x00090D34
		private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix)
		{
			builder._GroupDef._MinVal = XdrBuilder.ParseMinOccurs(obj, builder);
			builder._GroupDef._HasMinAttr = true;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00092B54 File Offset: 0x00090D54
		private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix)
		{
			builder._GroupDef._MaxVal = XdrBuilder.ParseMaxOccurs(obj, builder);
			builder._GroupDef._HasMaxAttr = true;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00092B74 File Offset: 0x00090D74
		private static void XDR_EndGroup(XdrBuilder builder)
		{
			if (!builder._ElementDef._ExistTerminal)
			{
				builder.SendValidationEvent("There is a missing element.");
			}
			builder._contentValidator.CloseGroup();
			if (builder._GroupDef._Order == 1)
			{
				builder._contentValidator.AddStar();
			}
			if (1 == builder._GroupDef._Order && builder._GroupDef._HasMaxAttr && builder._GroupDef._MaxVal != 4294967295U)
			{
				builder.SendValidationEvent("When the order is many, the maxOccurs attribute must have a value of '*'.");
			}
			XdrBuilder.HandleMinMax(builder._contentValidator, builder._GroupDef._MinVal, builder._GroupDef._MaxVal);
			builder.PopGroupInfo();
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00092C18 File Offset: 0x00090E18
		private static void XDR_InitElementDtType(XdrBuilder builder, object obj)
		{
			if (builder._ElementDef._HasDataType)
			{
				builder.SendValidationEvent("Data type has already been declared.");
			}
			if (!builder._ElementDef._AllowDataType)
			{
				builder.SendValidationEvent("Content must be \"textOnly\" when using DataType on an ElementType.");
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00092C4C File Offset: 0x00090E4C
		private static void XDR_EndElementDtType(XdrBuilder builder)
		{
			if (!builder._ElementDef._HasDataType)
			{
				builder.SendValidationEvent("The '{0}' attribute is either invalid or missing.");
			}
			builder._ElementDef._ElementDecl.ContentValidator = ContentValidator.TextOnly;
			builder._ElementDef._ContentAttr = 2;
			builder._ElementDef._MasterGroupRequired = false;
			builder._contentValidator = null;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00092CA5 File Offset: 0x00090EA5
		private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj)
		{
			if (builder._AttributeDef._HasDataType)
			{
				builder.SendValidationEvent("Data type has already been declared.");
			}
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00092CC0 File Offset: 0x00090EC0
		private static void XDR_EndAttributeDtType(XdrBuilder builder)
		{
			string text = null;
			if (!builder._AttributeDef._HasDataType)
			{
				text = "The '{0}' attribute is either invalid or missing.";
			}
			else if (builder._AttributeDef._AttDef.Datatype != null)
			{
				XmlTokenizedType tokenizedType = builder._AttributeDef._AttDef.Datatype.TokenizedType;
				if (tokenizedType == XmlTokenizedType.ENUMERATION && !builder._AttributeDef._EnumerationRequired)
				{
					text = "The dt:values attribute is missing.";
				}
				else if (tokenizedType != XmlTokenizedType.ENUMERATION && builder._AttributeDef._EnumerationRequired)
				{
					text = "Data type should be enumeration when the values attribute is present.";
				}
			}
			if (text != null)
			{
				builder.SendValidationEvent(text);
			}
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00092D48 File Offset: 0x00090F48
		private bool GetNextState(XmlQualifiedName qname)
		{
			if (this._CurState._NextStates != null)
			{
				for (int i = 0; i < this._CurState._NextStates.Length; i++)
				{
					if (this._SchemaNames.TokenToQName[(int)XdrBuilder.S_SchemaEntries[this._CurState._NextStates[i]]._Name].Equals(qname))
					{
						this._NextState = XdrBuilder.S_SchemaEntries[this._CurState._NextStates[i]];
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00092DC4 File Offset: 0x00090FC4
		private bool IsSkipableElement(XmlQualifiedName qname)
		{
			string @namespace = qname.Namespace;
			return (@namespace != null && !Ref.Equal(@namespace, this._SchemaNames.NsXdr)) || (this._SchemaNames.TokenToQName[38].Equals(qname) || this._SchemaNames.TokenToQName[39].Equals(qname));
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00092E20 File Offset: 0x00091020
		private bool IsSkipableAttribute(XmlQualifiedName qname)
		{
			string @namespace = qname.Namespace;
			return (@namespace.Length != 0 && !Ref.Equal(@namespace, this._SchemaNames.NsXdr) && !Ref.Equal(@namespace, this._SchemaNames.NsDataType)) || (Ref.Equal(@namespace, this._SchemaNames.NsDataType) && this._CurState._Name == SchemaNames.Token.XdrDatatype && (this._SchemaNames.QnDtMax.Equals(qname) || this._SchemaNames.QnDtMin.Equals(qname) || this._SchemaNames.QnDtMaxExclusive.Equals(qname) || this._SchemaNames.QnDtMinExclusive.Equals(qname)));
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00092ED8 File Offset: 0x000910D8
		private int GetOrder(XmlQualifiedName qname)
		{
			int result = 0;
			if (this._SchemaNames.TokenToQName[15].Equals(qname))
			{
				result = 2;
			}
			else if (this._SchemaNames.TokenToQName[16].Equals(qname))
			{
				result = 3;
			}
			else if (this._SchemaNames.TokenToQName[17].Equals(qname))
			{
				result = 1;
			}
			else
			{
				this.SendValidationEvent("The order attribute must have a value of 'seq', 'one', or 'many', not '{0}'.", qname.Name);
			}
			return result;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00092F48 File Offset: 0x00091148
		private void AddOrder()
		{
			switch (this._GroupDef._Order)
			{
			case 1:
			case 3:
				this._contentValidator.AddChoice();
				return;
			case 2:
				this._contentValidator.AddSequence();
				return;
			}
			throw new XmlException("This is an unexpected token. The expected token is '{0}'.", "NAME");
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00092FA4 File Offset: 0x000911A4
		private static bool IsYes(object obj, XdrBuilder builder)
		{
			XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
			bool result = false;
			if (xmlQualifiedName.Name == "yes")
			{
				result = true;
			}
			else if (xmlQualifiedName.Name != "no")
			{
				builder.SendValidationEvent("The required attribute must have a value of yes or no.");
			}
			return result;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00092FF0 File Offset: 0x000911F0
		private static uint ParseMinOccurs(object obj, XdrBuilder builder)
		{
			uint num = 1U;
			if (!XdrBuilder.ParseInteger((string)obj, ref num) || (num != 0U && num != 1U))
			{
				builder.SendValidationEvent("The minOccurs attribute must have a value of 0 or 1.");
			}
			return num;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00093024 File Offset: 0x00091224
		private static uint ParseMaxOccurs(object obj, XdrBuilder builder)
		{
			uint maxValue = uint.MaxValue;
			string text = (string)obj;
			if (!text.Equals("*") && (!XdrBuilder.ParseInteger(text, ref maxValue) || (maxValue != 4294967295U && maxValue != 1U)))
			{
				builder.SendValidationEvent("The maxOccurs attribute must have a value of 1 or *.");
			}
			return maxValue;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00093065 File Offset: 0x00091265
		private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax)
		{
			if (pContent != null)
			{
				if (cMax == 4294967295U)
				{
					if (cMin == 0U)
					{
						pContent.AddStar();
						return;
					}
					pContent.AddPlus();
					return;
				}
				else if (cMin == 0U)
				{
					pContent.AddQMark();
				}
			}
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00093088 File Offset: 0x00091288
		private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder)
		{
			if (4294967295U != cVal)
			{
				builder.SendValidationEvent("The value of maxLength has already been declared.");
			}
			if (!XdrBuilder.ParseInteger((string)obj, ref cVal) || cVal < 0U)
			{
				builder.SendValidationEvent("The value '{0}' is invalid for dt:maxLength.", obj.ToString());
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000930BE File Offset: 0x000912BE
		private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder)
		{
			if (4294967295U != cVal)
			{
				builder.SendValidationEvent("The value of minLength has already been declared.");
			}
			if (!XdrBuilder.ParseInteger((string)obj, ref cVal) || cVal < 0U)
			{
				builder.SendValidationEvent("The value '{0}' is invalid for dt:minLength.", obj.ToString());
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000930F4 File Offset: 0x000912F4
		private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder)
		{
			if (cMin != 4294967295U && cMax != 4294967295U && cMin > cMax)
			{
				builder.SendValidationEvent("The maxLength value must be equal to or greater than the minLength value.");
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0009310D File Offset: 0x0009130D
		private static bool ParseInteger(string str, ref uint n)
		{
			return uint.TryParse(str, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out n);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0009311C File Offset: 0x0009131C
		private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef)
		{
			if ((decl._Default != null || pAttdef.DefaultValueTyped != null) && decl._Default != null)
			{
				pAttdef.DefaultValueRaw = (pAttdef.DefaultValueExpanded = (string)decl._Default);
				this.CheckDefaultAttValue(pAttdef);
			}
			this.SetAttributePresence(pAttdef, 1U == decl._MinOccurs);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00093174 File Offset: 0x00091374
		private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired)
		{
			if (SchemaDeclBase.Use.Fixed != pAttdef.Presence)
			{
				if (fRequired || SchemaDeclBase.Use.Required == pAttdef.Presence)
				{
					if (pAttdef.DefaultValueTyped != null)
					{
						pAttdef.Presence = SchemaDeclBase.Use.Fixed;
						return;
					}
					pAttdef.Presence = SchemaDeclBase.Use.Required;
					return;
				}
				else
				{
					if (pAttdef.DefaultValueTyped != null)
					{
						pAttdef.Presence = SchemaDeclBase.Use.Default;
						return;
					}
					pAttdef.Presence = SchemaDeclBase.Use.Implied;
				}
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000931C8 File Offset: 0x000913C8
		private int GetContent(XmlQualifiedName qname)
		{
			int result = 0;
			if (this._SchemaNames.TokenToQName[11].Equals(qname))
			{
				result = 1;
				this._ElementDef._AllowDataType = false;
			}
			else if (this._SchemaNames.TokenToQName[12].Equals(qname))
			{
				result = 4;
				this._ElementDef._AllowDataType = false;
			}
			else if (this._SchemaNames.TokenToQName[10].Equals(qname))
			{
				result = 3;
				this._ElementDef._AllowDataType = false;
			}
			else if (this._SchemaNames.TokenToQName[13].Equals(qname))
			{
				result = 2;
			}
			else
			{
				this.SendValidationEvent("The content attribute must have a value of 'textOnly', 'eltOnly', 'mixed', or 'empty', not '{0}'.", qname.Name);
			}
			return result;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00093278 File Offset: 0x00091478
		private bool GetModel(XmlQualifiedName qname)
		{
			bool result = false;
			if (this._SchemaNames.TokenToQName[7].Equals(qname))
			{
				result = true;
			}
			else if (this._SchemaNames.TokenToQName[8].Equals(qname))
			{
				result = false;
			}
			else
			{
				this.SendValidationEvent("The model attribute must have a value of open or closed, not '{0}'.", qname.Name);
			}
			return result;
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000932CC File Offset: 0x000914CC
		private XmlSchemaDatatype CheckDatatype(string str)
		{
			XmlSchemaDatatype xmlSchemaDatatype = XmlSchemaDatatype.FromXdrName(str);
			if (xmlSchemaDatatype == null)
			{
				this.SendValidationEvent("Reference to an unknown data type, '{0}'.", str);
			}
			else if (xmlSchemaDatatype.TokenizedType == XmlTokenizedType.ID && !this._AttributeDef._Global)
			{
				if (this._ElementDef._ElementDecl.IsIdDeclared)
				{
					this.SendValidationEvent("The attribute of type ID is already declared on the '{0}' element.", XmlQualifiedName.ToString(this._ElementDef._ElementDecl.Name.Name, this._ElementDef._ElementDecl.Prefix));
				}
				this._ElementDef._ElementDecl.IsIdDeclared = true;
			}
			return xmlSchemaDatatype;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00093360 File Offset: 0x00091560
		private void CheckDefaultAttValue(SchemaAttDef attDef)
		{
			XdrValidator.CheckDefaultValue(attDef.DefaultValueRaw.Trim(), attDef, this._SchemaInfo, this._CurNsMgr, this._NameTable, null, this.validationEventHandler, this._reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000933B8 File Offset: 0x000915B8
		private bool IsGlobal(int flags)
		{
			return flags == 256;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000933C2 File Offset: 0x000915C2
		private void SendValidationEvent(string code, string[] args, XmlSeverityType severity)
		{
			this.SendValidationEvent(new XmlSchemaException(code, args, this._reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition), severity);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000933F3 File Offset: 0x000915F3
		private void SendValidationEvent(string code)
		{
			this.SendValidationEvent(code, string.Empty);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00093401 File Offset: 0x00091601
		private void SendValidationEvent(string code, string msg)
		{
			this.SendValidationEvent(new XmlSchemaException(code, msg, this._reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition), XmlSeverityType.Error);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00093434 File Offset: 0x00091634
		private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			SchemaInfo schemaInfo = this._SchemaInfo;
			int errorCount = schemaInfo.ErrorCount;
			schemaInfo.ErrorCount = errorCount + 1;
			if (this.validationEventHandler != null)
			{
				this.validationEventHandler(this, new ValidationEventArgs(e, severity));
				return;
			}
			if (severity == XmlSeverityType.Error)
			{
				throw e;
			}
		}

		// Token: 0x04000F9F RID: 3999
		private static readonly int[] S_XDR_Root_Element = new int[]
		{
			1
		};

		// Token: 0x04000FA0 RID: 4000
		private static readonly int[] S_XDR_Root_SubElements = new int[]
		{
			2,
			3
		};

		// Token: 0x04000FA1 RID: 4001
		private static readonly int[] S_XDR_ElementType_SubElements = new int[]
		{
			4,
			6,
			3,
			5,
			7
		};

		// Token: 0x04000FA2 RID: 4002
		private static readonly int[] S_XDR_AttributeType_SubElements = new int[]
		{
			8
		};

		// Token: 0x04000FA3 RID: 4003
		private static readonly int[] S_XDR_Group_SubElements = new int[]
		{
			4,
			6
		};

		// Token: 0x04000FA4 RID: 4004
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaName, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildRoot_Name)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaId, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildRoot_ID))
		};

		// Token: 0x04000FA5 RID: 4005
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaName, XmlTokenizedType.QName, 256, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_Name)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaContent, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_Content)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaModel, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_Model)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaOrder, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_Order)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtType, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtType)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtValues, XmlTokenizedType.NMTOKENS, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtValues)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMaxLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtMaxLength)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMinLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtMinLength))
		};

		// Token: 0x04000FA6 RID: 4006
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaName, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_Name)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaRequired, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_Required)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDefault, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_Default)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtType, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtType)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtValues, XmlTokenizedType.NMTOKENS, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtValues)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMaxLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtMaxLength)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMinLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtMinLength))
		};

		// Token: 0x04000FA7 RID: 4007
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaType, XmlTokenizedType.QName, 256, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElement_Type)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaMinOccurs, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElement_MinOccurs)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaMaxOccurs, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElement_MaxOccurs))
		};

		// Token: 0x04000FA8 RID: 4008
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaType, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttribute_Type)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaRequired, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttribute_Required)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDefault, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttribute_Default))
		};

		// Token: 0x04000FA9 RID: 4009
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaOrder, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildGroup_Order)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaMinOccurs, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildGroup_MinOccurs)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaMaxOccurs, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildGroup_MaxOccurs))
		};

		// Token: 0x04000FAA RID: 4010
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtType, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtType)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtValues, XmlTokenizedType.NMTOKENS, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtValues)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMaxLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtMaxLength)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMinLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildElementType_DtMinLength))
		};

		// Token: 0x04000FAB RID: 4011
		private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes = new XdrBuilder.XdrAttributeEntry[]
		{
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtType, XmlTokenizedType.QName, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtType)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtValues, XmlTokenizedType.NMTOKENS, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtValues)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMaxLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtMaxLength)),
			new XdrBuilder.XdrAttributeEntry(SchemaNames.Token.SchemaDtMinLength, XmlTokenizedType.CDATA, new XdrBuilder.XdrBuildFunction(XdrBuilder.XDR_BuildAttributeType_DtMinLength))
		};

		// Token: 0x04000FAC RID: 4012
		private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries = new XdrBuilder.XdrEntry[]
		{
			new XdrBuilder.XdrEntry(SchemaNames.Token.Empty, XdrBuilder.S_XDR_Root_Element, null, null, null, null, false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrRoot, XdrBuilder.S_XDR_Root_SubElements, XdrBuilder.S_XDR_Root_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitRoot), new XdrBuilder.XdrBeginChildFunction(XdrBuilder.XDR_BeginRoot), new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndRoot), false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrElementType, XdrBuilder.S_XDR_ElementType_SubElements, XdrBuilder.S_XDR_ElementType_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitElementType), new XdrBuilder.XdrBeginChildFunction(XdrBuilder.XDR_BeginElementType), new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndElementType), false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrAttributeType, XdrBuilder.S_XDR_AttributeType_SubElements, XdrBuilder.S_XDR_AttributeType_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitAttributeType), new XdrBuilder.XdrBeginChildFunction(XdrBuilder.XDR_BeginAttributeType), new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndAttributeType), false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrElement, null, XdrBuilder.S_XDR_Element_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitElement), null, new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndElement), false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrAttribute, null, XdrBuilder.S_XDR_Attribute_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitAttribute), new XdrBuilder.XdrBeginChildFunction(XdrBuilder.XDR_BeginAttribute), new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndAttribute), false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrGroup, XdrBuilder.S_XDR_Group_SubElements, XdrBuilder.S_XDR_Group_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitGroup), null, new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndGroup), false),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrDatatype, null, XdrBuilder.S_XDR_ElementDataType_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitElementDtType), null, new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndElementDtType), true),
			new XdrBuilder.XdrEntry(SchemaNames.Token.XdrDatatype, null, XdrBuilder.S_XDR_AttributeDataType_Attributes, new XdrBuilder.XdrInitFunction(XdrBuilder.XDR_InitAttributeDtType), null, new XdrBuilder.XdrEndChildFunction(XdrBuilder.XDR_EndAttributeDtType), true)
		};

		// Token: 0x04000FAD RID: 4013
		private SchemaInfo _SchemaInfo;

		// Token: 0x04000FAE RID: 4014
		private string _TargetNamespace;

		// Token: 0x04000FAF RID: 4015
		private XmlReader _reader;

		// Token: 0x04000FB0 RID: 4016
		private PositionInfo positionInfo;

		// Token: 0x04000FB1 RID: 4017
		private ParticleContentValidator _contentValidator;

		// Token: 0x04000FB2 RID: 4018
		private XdrBuilder.XdrEntry _CurState;

		// Token: 0x04000FB3 RID: 4019
		private XdrBuilder.XdrEntry _NextState;

		// Token: 0x04000FB4 RID: 4020
		private HWStack _StateHistory;

		// Token: 0x04000FB5 RID: 4021
		private HWStack _GroupStack;

		// Token: 0x04000FB6 RID: 4022
		private string _XdrName;

		// Token: 0x04000FB7 RID: 4023
		private string _XdrPrefix;

		// Token: 0x04000FB8 RID: 4024
		private XdrBuilder.ElementContent _ElementDef;

		// Token: 0x04000FB9 RID: 4025
		private XdrBuilder.GroupContent _GroupDef;

		// Token: 0x04000FBA RID: 4026
		private XdrBuilder.AttributeContent _AttributeDef;

		// Token: 0x04000FBB RID: 4027
		private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes;

		// Token: 0x04000FBC RID: 4028
		private XdrBuilder.DeclBaseInfo _BaseDecl;

		// Token: 0x04000FBD RID: 4029
		private XmlNameTable _NameTable;

		// Token: 0x04000FBE RID: 4030
		private SchemaNames _SchemaNames;

		// Token: 0x04000FBF RID: 4031
		private XmlNamespaceManager _CurNsMgr;

		// Token: 0x04000FC0 RID: 4032
		private string _Text;

		// Token: 0x04000FC1 RID: 4033
		private ValidationEventHandler validationEventHandler;

		// Token: 0x04000FC2 RID: 4034
		private Hashtable _UndeclaredElements = new Hashtable();

		// Token: 0x04000FC3 RID: 4035
		private XmlResolver xmlResolver;

		// Token: 0x020002C1 RID: 705
		private sealed class DeclBaseInfo
		{
			// Token: 0x0600176E RID: 5998 RVA: 0x000939FD File Offset: 0x00091BFD
			internal DeclBaseInfo()
			{
				this.Reset();
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x00093A0C File Offset: 0x00091C0C
			internal void Reset()
			{
				this._Name = XmlQualifiedName.Empty;
				this._Prefix = null;
				this._TypeName = XmlQualifiedName.Empty;
				this._TypePrefix = null;
				this._Default = null;
				this._Revises = null;
				this._MaxOccurs = 1U;
				this._MinOccurs = 1U;
				this._Checking = false;
				this._ElementDecl = null;
				this._Next = null;
				this._Attdef = null;
			}

			// Token: 0x04000FC4 RID: 4036
			internal XmlQualifiedName _Name;

			// Token: 0x04000FC5 RID: 4037
			internal string _Prefix;

			// Token: 0x04000FC6 RID: 4038
			internal XmlQualifiedName _TypeName;

			// Token: 0x04000FC7 RID: 4039
			internal string _TypePrefix;

			// Token: 0x04000FC8 RID: 4040
			internal object _Default;

			// Token: 0x04000FC9 RID: 4041
			internal object _Revises;

			// Token: 0x04000FCA RID: 4042
			internal uint _MaxOccurs;

			// Token: 0x04000FCB RID: 4043
			internal uint _MinOccurs;

			// Token: 0x04000FCC RID: 4044
			internal bool _Checking;

			// Token: 0x04000FCD RID: 4045
			internal SchemaElementDecl _ElementDecl;

			// Token: 0x04000FCE RID: 4046
			internal SchemaAttDef _Attdef;

			// Token: 0x04000FCF RID: 4047
			internal XdrBuilder.DeclBaseInfo _Next;
		}

		// Token: 0x020002C2 RID: 706
		private sealed class GroupContent
		{
			// Token: 0x06001770 RID: 6000 RVA: 0x00093A75 File Offset: 0x00091C75
			internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to)
			{
				to._MinVal = from._MinVal;
				to._MaxVal = from._MaxVal;
				to._Order = from._Order;
			}

			// Token: 0x06001771 RID: 6001 RVA: 0x00093A9C File Offset: 0x00091C9C
			internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other)
			{
				XdrBuilder.GroupContent groupContent = new XdrBuilder.GroupContent();
				XdrBuilder.GroupContent.Copy(other, groupContent);
				return groupContent;
			}

			// Token: 0x04000FD0 RID: 4048
			internal uint _MinVal;

			// Token: 0x04000FD1 RID: 4049
			internal uint _MaxVal;

			// Token: 0x04000FD2 RID: 4050
			internal bool _HasMaxAttr;

			// Token: 0x04000FD3 RID: 4051
			internal bool _HasMinAttr;

			// Token: 0x04000FD4 RID: 4052
			internal int _Order;
		}

		// Token: 0x020002C3 RID: 707
		private sealed class ElementContent
		{
			// Token: 0x04000FD5 RID: 4053
			internal SchemaElementDecl _ElementDecl;

			// Token: 0x04000FD6 RID: 4054
			internal int _ContentAttr;

			// Token: 0x04000FD7 RID: 4055
			internal int _OrderAttr;

			// Token: 0x04000FD8 RID: 4056
			internal bool _MasterGroupRequired;

			// Token: 0x04000FD9 RID: 4057
			internal bool _ExistTerminal;

			// Token: 0x04000FDA RID: 4058
			internal bool _AllowDataType;

			// Token: 0x04000FDB RID: 4059
			internal bool _HasDataType;

			// Token: 0x04000FDC RID: 4060
			internal bool _HasType;

			// Token: 0x04000FDD RID: 4061
			internal bool _EnumerationRequired;

			// Token: 0x04000FDE RID: 4062
			internal uint _MinVal;

			// Token: 0x04000FDF RID: 4063
			internal uint _MaxVal;

			// Token: 0x04000FE0 RID: 4064
			internal uint _MaxLength;

			// Token: 0x04000FE1 RID: 4065
			internal uint _MinLength;

			// Token: 0x04000FE2 RID: 4066
			internal Hashtable _AttDefList;
		}

		// Token: 0x020002C4 RID: 708
		private sealed class AttributeContent
		{
			// Token: 0x04000FE3 RID: 4067
			internal SchemaAttDef _AttDef;

			// Token: 0x04000FE4 RID: 4068
			internal XmlQualifiedName _Name;

			// Token: 0x04000FE5 RID: 4069
			internal string _Prefix;

			// Token: 0x04000FE6 RID: 4070
			internal bool _Required;

			// Token: 0x04000FE7 RID: 4071
			internal uint _MinVal;

			// Token: 0x04000FE8 RID: 4072
			internal uint _MaxVal;

			// Token: 0x04000FE9 RID: 4073
			internal uint _MaxLength;

			// Token: 0x04000FEA RID: 4074
			internal uint _MinLength;

			// Token: 0x04000FEB RID: 4075
			internal bool _EnumerationRequired;

			// Token: 0x04000FEC RID: 4076
			internal bool _HasDataType;

			// Token: 0x04000FED RID: 4077
			internal bool _Global;

			// Token: 0x04000FEE RID: 4078
			internal object _Default;
		}

		// Token: 0x020002C5 RID: 709
		// (Invoke) Token: 0x06001776 RID: 6006
		private delegate void XdrBuildFunction(XdrBuilder builder, object obj, string prefix);

		// Token: 0x020002C6 RID: 710
		// (Invoke) Token: 0x0600177A RID: 6010
		private delegate void XdrInitFunction(XdrBuilder builder, object obj);

		// Token: 0x020002C7 RID: 711
		// (Invoke) Token: 0x0600177E RID: 6014
		private delegate void XdrBeginChildFunction(XdrBuilder builder);

		// Token: 0x020002C8 RID: 712
		// (Invoke) Token: 0x06001782 RID: 6018
		private delegate void XdrEndChildFunction(XdrBuilder builder);

		// Token: 0x020002C9 RID: 713
		private sealed class XdrAttributeEntry
		{
			// Token: 0x06001785 RID: 6021 RVA: 0x00093AB7 File Offset: 0x00091CB7
			internal XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build)
			{
				this._Attribute = a;
				this._Datatype = XmlSchemaDatatype.FromXmlTokenizedType(ttype);
				this._SchemaFlags = 0;
				this._BuildFunc = build;
			}

			// Token: 0x06001786 RID: 6022 RVA: 0x00093AE0 File Offset: 0x00091CE0
			internal XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build)
			{
				this._Attribute = a;
				this._Datatype = XmlSchemaDatatype.FromXmlTokenizedType(ttype);
				this._SchemaFlags = schemaFlags;
				this._BuildFunc = build;
			}

			// Token: 0x04000FEF RID: 4079
			internal SchemaNames.Token _Attribute;

			// Token: 0x04000FF0 RID: 4080
			internal int _SchemaFlags;

			// Token: 0x04000FF1 RID: 4081
			internal XmlSchemaDatatype _Datatype;

			// Token: 0x04000FF2 RID: 4082
			internal XdrBuilder.XdrBuildFunction _BuildFunc;
		}

		// Token: 0x020002CA RID: 714
		private sealed class XdrEntry
		{
			// Token: 0x06001787 RID: 6023 RVA: 0x00093B0A File Offset: 0x00091D0A
			internal XdrEntry(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText)
			{
				this._Name = n;
				this._NextStates = states;
				this._Attributes = attributes;
				this._InitFunc = init;
				this._BeginChildFunc = begin;
				this._EndChildFunc = end;
				this._AllowText = fText;
			}

			// Token: 0x04000FF3 RID: 4083
			internal SchemaNames.Token _Name;

			// Token: 0x04000FF4 RID: 4084
			internal int[] _NextStates;

			// Token: 0x04000FF5 RID: 4085
			internal XdrBuilder.XdrAttributeEntry[] _Attributes;

			// Token: 0x04000FF6 RID: 4086
			internal XdrBuilder.XdrInitFunction _InitFunc;

			// Token: 0x04000FF7 RID: 4087
			internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc;

			// Token: 0x04000FF8 RID: 4088
			internal XdrBuilder.XdrEndChildFunction _EndChildFunc;

			// Token: 0x04000FF9 RID: 4089
			internal bool _AllowText;
		}
	}
}
