using System;
using System.Collections;
using System.Text;

namespace System.Xml.Schema
{
	// Token: 0x02000228 RID: 552
	internal class BaseValidator
	{
		// Token: 0x06001235 RID: 4661 RVA: 0x000706B8 File Offset: 0x0006E8B8
		public BaseValidator(BaseValidator other)
		{
			this.reader = other.reader;
			this.schemaCollection = other.schemaCollection;
			this.eventHandling = other.eventHandling;
			this.nameTable = other.nameTable;
			this.schemaNames = other.schemaNames;
			this.positionInfo = other.positionInfo;
			this.xmlResolver = other.xmlResolver;
			this.baseUri = other.baseUri;
			this.elementName = other.elementName;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00070737 File Offset: 0x0006E937
		public BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
		{
			this.reader = reader;
			this.schemaCollection = schemaCollection;
			this.eventHandling = eventHandling;
			this.nameTable = reader.NameTable;
			this.positionInfo = PositionInfo.GetPositionInfo(reader);
			this.elementName = new XmlQualifiedName();
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00070777 File Offset: 0x0006E977
		public XmlValidatingReaderImpl Reader
		{
			get
			{
				return this.reader;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x0007077F File Offset: 0x0006E97F
		public XmlSchemaCollection SchemaCollection
		{
			get
			{
				return this.schemaCollection;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00070787 File Offset: 0x0006E987
		public XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00070790 File Offset: 0x0006E990
		public SchemaNames SchemaNames
		{
			get
			{
				if (this.schemaNames != null)
				{
					return this.schemaNames;
				}
				if (this.schemaCollection != null)
				{
					this.schemaNames = this.schemaCollection.GetSchemaNames(this.nameTable);
				}
				else
				{
					this.schemaNames = new SchemaNames(this.nameTable);
				}
				return this.schemaNames;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000707E4 File Offset: 0x0006E9E4
		public PositionInfo PositionInfo
		{
			get
			{
				return this.positionInfo;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000707EC File Offset: 0x0006E9EC
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x000707F4 File Offset: 0x0006E9F4
		public XmlResolver XmlResolver
		{
			get
			{
				return this.xmlResolver;
			}
			set
			{
				this.xmlResolver = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x000707FD File Offset: 0x0006E9FD
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00070805 File Offset: 0x0006EA05
		public Uri BaseUri
		{
			get
			{
				return this.baseUri;
			}
			set
			{
				this.baseUri = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0007080E File Offset: 0x0006EA0E
		public ValidationEventHandler EventHandler
		{
			get
			{
				return (ValidationEventHandler)this.eventHandling.EventHandler;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00070820 File Offset: 0x0006EA20
		public SchemaInfo SchemaInfo
		{
			get
			{
				return this.schemaInfo;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00070828 File Offset: 0x0006EA28
		public IDtdInfo DtdInfo
		{
			set
			{
				SchemaInfo schemaInfo = value as SchemaInfo;
				if (schemaInfo == null)
				{
					throw new XmlException("An internal error has occurred.", string.Empty);
				}
				this.schemaInfo = schemaInfo;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool PreserveWhitespace
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00008574 File Offset: 0x00006774
		public virtual void Validate()
		{
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00008574 File Offset: 0x00006774
		public virtual void CompleteValidation()
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual object FindId(string name)
		{
			return null;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00070858 File Offset: 0x0006EA58
		public void ValidateText()
		{
			if (this.context.NeedValidateChildren)
			{
				if (this.context.IsNill)
				{
					this.SendValidationEvent("Element '{0}' must have no character or element children.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
					return;
				}
				ContentValidator contentValidator = this.context.ElementDecl.ContentValidator;
				XmlSchemaContentType contentType = contentValidator.ContentType;
				if (contentType == XmlSchemaContentType.ElementOnly)
				{
					ArrayList arrayList = contentValidator.ExpectedElements(this.context, false);
					if (arrayList == null)
					{
						this.SendValidationEvent("The element {0} cannot contain text.", XmlSchemaValidator.BuildElementName(this.context.LocalName, this.context.Namespace));
					}
					else
					{
						this.SendValidationEvent("The element {0} cannot contain text. List of possible elements expected: {1}.", new string[]
						{
							XmlSchemaValidator.BuildElementName(this.context.LocalName, this.context.Namespace),
							XmlSchemaValidator.PrintExpectedElements(arrayList, false)
						});
					}
				}
				else if (contentType == XmlSchemaContentType.Empty)
				{
					this.SendValidationEvent("The element cannot contain text. Content model is empty.", string.Empty);
				}
				if (this.checkDatatype)
				{
					this.SaveTextValue(this.reader.Value);
				}
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00070968 File Offset: 0x0006EB68
		public void ValidateWhitespace()
		{
			if (this.context.NeedValidateChildren)
			{
				int contentType = (int)this.context.ElementDecl.ContentValidator.ContentType;
				if (this.context.IsNill)
				{
					this.SendValidationEvent("Element '{0}' must have no character or element children.", XmlSchemaValidator.QNameString(this.context.LocalName, this.context.Namespace));
				}
				if (contentType == 1)
				{
					this.SendValidationEvent("The element cannot contain white space. Content model is empty.", string.Empty);
				}
				if (this.checkDatatype)
				{
					this.SaveTextValue(this.reader.Value);
				}
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000709F8 File Offset: 0x0006EBF8
		private void SaveTextValue(string value)
		{
			if (this.textString.Length == 0)
			{
				this.textString = value;
				return;
			}
			if (!this.hasSibling)
			{
				this.textValue.Append(this.textString);
				this.hasSibling = true;
			}
			this.textValue.Append(value);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00070A48 File Offset: 0x0006EC48
		protected void SendValidationEvent(string code)
		{
			this.SendValidationEvent(code, string.Empty);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00070A56 File Offset: 0x0006EC56
		protected void SendValidationEvent(string code, string[] args)
		{
			this.SendValidationEvent(new XmlSchemaException(code, args, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00070A86 File Offset: 0x0006EC86
		protected void SendValidationEvent(string code, string arg)
		{
			this.SendValidationEvent(new XmlSchemaException(code, arg, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition));
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00070AB6 File Offset: 0x0006ECB6
		protected void SendValidationEvent(XmlSchemaException e)
		{
			this.SendValidationEvent(e, XmlSeverityType.Error);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00070AC0 File Offset: 0x0006ECC0
		protected void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
			this.SendValidationEvent(new XmlSchemaException(code, msg, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition), severity);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00070AF1 File Offset: 0x0006ECF1
		protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity)
		{
			this.SendValidationEvent(new XmlSchemaException(code, args, this.reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition), severity);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00070B22 File Offset: 0x0006ED22
		protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			if (this.eventHandling != null)
			{
				this.eventHandling.SendEvent(e, severity);
				return;
			}
			if (severity == XmlSeverityType.Error)
			{
				throw e;
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00070B40 File Offset: 0x0006ED40
		protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition)
		{
			XmlSchemaException ex = null;
			SchemaEntity schemaEntity;
			if (!sinfo.GeneralEntities.TryGetValue(new XmlQualifiedName(name), out schemaEntity))
			{
				ex = new XmlSchemaException("Reference to an undeclared entity, '{0}'.", name, baseUri, lineNumber, linePosition);
			}
			else if (schemaEntity.NData.IsEmpty)
			{
				ex = new XmlSchemaException("Reference to an unparsed entity, '{0}'.", name, baseUri, lineNumber, linePosition);
			}
			if (ex == null)
			{
				return;
			}
			if (eventhandler != null)
			{
				eventhandler(sender, new ValidationEventArgs(ex));
				return;
			}
			throw ex;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00070BB0 File Offset: 0x0006EDB0
		protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition)
		{
			string text = null;
			SchemaEntity schemaEntity;
			if (!sinfo.GeneralEntities.TryGetValue(new XmlQualifiedName(name), out schemaEntity))
			{
				text = "Reference to an undeclared entity, '{0}'.";
			}
			else if (schemaEntity.NData.IsEmpty)
			{
				text = "Reference to an unparsed entity, '{0}'.";
			}
			if (text == null)
			{
				return;
			}
			XmlSchemaException ex = new XmlSchemaException(text, name, baseUriStr, lineNumber, linePosition);
			if (eventHandling != null)
			{
				eventHandling.SendEvent(ex, XmlSeverityType.Error);
				return;
			}
			throw ex;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00070C10 File Offset: 0x0006EE10
		public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints)
		{
			switch (valType)
			{
			case ValidationType.None:
				return new BaseValidator(reader, schemaCollection, eventHandling);
			case ValidationType.Auto:
				return new AutoValidator(reader, schemaCollection, eventHandling);
			case ValidationType.DTD:
				return new DtdValidator(reader, eventHandling, processIdentityConstraints);
			case ValidationType.XDR:
				return new XdrValidator(reader, schemaCollection, eventHandling);
			case ValidationType.Schema:
				return new XsdValidator(reader, schemaCollection, eventHandling);
			default:
				return null;
			}
		}

		// Token: 0x04000C54 RID: 3156
		private XmlSchemaCollection schemaCollection;

		// Token: 0x04000C55 RID: 3157
		private IValidationEventHandling eventHandling;

		// Token: 0x04000C56 RID: 3158
		private XmlNameTable nameTable;

		// Token: 0x04000C57 RID: 3159
		private SchemaNames schemaNames;

		// Token: 0x04000C58 RID: 3160
		private PositionInfo positionInfo;

		// Token: 0x04000C59 RID: 3161
		private XmlResolver xmlResolver;

		// Token: 0x04000C5A RID: 3162
		private Uri baseUri;

		// Token: 0x04000C5B RID: 3163
		protected SchemaInfo schemaInfo;

		// Token: 0x04000C5C RID: 3164
		protected XmlValidatingReaderImpl reader;

		// Token: 0x04000C5D RID: 3165
		protected XmlQualifiedName elementName;

		// Token: 0x04000C5E RID: 3166
		protected ValidationState context;

		// Token: 0x04000C5F RID: 3167
		protected StringBuilder textValue;

		// Token: 0x04000C60 RID: 3168
		protected string textString;

		// Token: 0x04000C61 RID: 3169
		protected bool hasSibling;

		// Token: 0x04000C62 RID: 3170
		protected bool checkDatatype;
	}
}
