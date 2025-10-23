using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.XmlConfiguration;

namespace System.Xml.Schema
{
	// Token: 0x020002A5 RID: 677
	internal sealed class Parser
	{
		// Token: 0x06001562 RID: 5474 RVA: 0x0007E7A0 File Offset: 0x0007C9A0
		public Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
		{
			this.schemaType = schemaType;
			this.nameTable = nameTable;
			this.schemaNames = schemaNames;
			this.eventHandler = eventHandler;
			this.xmlResolver = XmlReaderSection.CreateDefaultResolver();
			this.processMarkup = true;
			this.dummyDocument = new XmlDocument();
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0007E7F8 File Offset: 0x0007C9F8
		public SchemaType Parse(XmlReader reader, string targetNamespace)
		{
			this.StartParsing(reader, targetNamespace);
			while (this.ParseReaderNode() && reader.Read())
			{
			}
			return this.FinishParsing();
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0007E818 File Offset: 0x0007CA18
		public void StartParsing(XmlReader reader, string targetNamespace)
		{
			this.reader = reader;
			this.positionInfo = PositionInfo.GetPositionInfo(reader);
			this.namespaceManager = reader.NamespaceManager;
			if (this.namespaceManager == null)
			{
				this.namespaceManager = new XmlNamespaceManager(this.nameTable);
				this.isProcessNamespaces = true;
			}
			else
			{
				this.isProcessNamespaces = false;
			}
			while (reader.NodeType != XmlNodeType.Element && reader.Read())
			{
			}
			this.markupDepth = int.MaxValue;
			this.schemaXmlDepth = reader.Depth;
			SchemaType rootType = this.schemaNames.SchemaTypeFromRoot(reader.LocalName, reader.NamespaceURI);
			string res;
			if (!this.CheckSchemaRoot(rootType, out res))
			{
				throw new XmlSchemaException(res, reader.BaseURI, this.positionInfo.LineNumber, this.positionInfo.LinePosition);
			}
			if (this.schemaType == SchemaType.XSD)
			{
				this.schema = new XmlSchema();
				this.schema.BaseUri = new Uri(reader.BaseURI, UriKind.RelativeOrAbsolute);
				this.builder = new XsdBuilder(reader, this.namespaceManager, this.schema, this.nameTable, this.schemaNames, this.eventHandler);
				return;
			}
			this.xdrSchema = new SchemaInfo();
			this.xdrSchema.SchemaType = SchemaType.XDR;
			this.builder = new XdrBuilder(reader, this.namespaceManager, this.xdrSchema, targetNamespace, this.nameTable, this.schemaNames, this.eventHandler);
			((XdrBuilder)this.builder).XmlResolver = this.xmlResolver;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0007E98C File Offset: 0x0007CB8C
		private bool CheckSchemaRoot(SchemaType rootType, out string code)
		{
			code = null;
			if (this.schemaType == SchemaType.None)
			{
				this.schemaType = rootType;
			}
			switch (rootType)
			{
			case SchemaType.None:
			case SchemaType.DTD:
				code = "Expected schema root. Make sure the root element is <schema> and the namespace is 'http://www.w3.org/2001/XMLSchema' for an XSD schema or 'urn:schemas-microsoft-com:xml-data' for an XDR schema.";
				if (this.schemaType == SchemaType.XSD)
				{
					code = "The root element of a W3C XML Schema should be <schema> and its namespace should be 'http://www.w3.org/2001/XMLSchema'.";
				}
				return false;
			case SchemaType.XDR:
				if (this.schemaType == SchemaType.XSD)
				{
					code = "'XmlSchemaSet' can load only W3C XML Schemas.";
					return false;
				}
				if (this.schemaType != SchemaType.XDR)
				{
					code = "Different schema types cannot be mixed.";
					return false;
				}
				break;
			case SchemaType.XSD:
				if (this.schemaType != SchemaType.XSD)
				{
					code = "Different schema types cannot be mixed.";
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0007EA13 File Offset: 0x0007CC13
		public SchemaType FinishParsing()
		{
			return this.schemaType;
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0007EA1B File Offset: 0x0007CC1B
		public XmlSchema XmlSchema
		{
			get
			{
				return this.schema;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x0007EA23 File Offset: 0x0007CC23
		internal XmlResolver XmlResolver
		{
			set
			{
				this.xmlResolver = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0007EA2C File Offset: 0x0007CC2C
		public SchemaInfo XdrSchema
		{
			get
			{
				return this.xdrSchema;
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0007EA34 File Offset: 0x0007CC34
		public bool ParseReaderNode()
		{
			if (this.reader.Depth > this.markupDepth)
			{
				if (this.processMarkup)
				{
					this.ProcessAppInfoDocMarkup(false);
				}
				return true;
			}
			if (this.reader.NodeType == XmlNodeType.Element)
			{
				if (this.builder.ProcessElement(this.reader.Prefix, this.reader.LocalName, this.reader.NamespaceURI))
				{
					this.namespaceManager.PushScope();
					if (this.reader.MoveToFirstAttribute())
					{
						do
						{
							this.builder.ProcessAttribute(this.reader.Prefix, this.reader.LocalName, this.reader.NamespaceURI, this.reader.Value);
							if (Ref.Equal(this.reader.NamespaceURI, this.schemaNames.NsXmlNs) && this.isProcessNamespaces)
							{
								this.namespaceManager.AddNamespace((this.reader.Prefix.Length == 0) ? string.Empty : this.reader.LocalName, this.reader.Value);
							}
						}
						while (this.reader.MoveToNextAttribute());
						this.reader.MoveToElement();
					}
					this.builder.StartChildren();
					if (this.reader.IsEmptyElement)
					{
						this.namespaceManager.PopScope();
						this.builder.EndChildren();
						if (this.reader.Depth == this.schemaXmlDepth)
						{
							return false;
						}
					}
					else if (!this.builder.IsContentParsed())
					{
						this.markupDepth = this.reader.Depth;
						this.processMarkup = true;
						if (this.annotationNSManager == null)
						{
							this.annotationNSManager = new XmlNamespaceManager(this.nameTable);
							this.xmlns = this.nameTable.Add("xmlns");
						}
						this.ProcessAppInfoDocMarkup(true);
					}
				}
				else if (!this.reader.IsEmptyElement)
				{
					this.markupDepth = this.reader.Depth;
					this.processMarkup = false;
				}
			}
			else if (this.reader.NodeType == XmlNodeType.Text)
			{
				if (!this.xmlCharType.IsOnlyWhitespace(this.reader.Value))
				{
					this.builder.ProcessCData(this.reader.Value);
				}
			}
			else if (this.reader.NodeType == XmlNodeType.EntityReference || this.reader.NodeType == XmlNodeType.SignificantWhitespace || this.reader.NodeType == XmlNodeType.CDATA)
			{
				this.builder.ProcessCData(this.reader.Value);
			}
			else if (this.reader.NodeType == XmlNodeType.EndElement)
			{
				if (this.reader.Depth == this.markupDepth)
				{
					if (this.processMarkup)
					{
						XmlNodeList childNodes = this.parentNode.ChildNodes;
						XmlNode[] array = new XmlNode[childNodes.Count];
						for (int i = 0; i < childNodes.Count; i++)
						{
							array[i] = childNodes[i];
						}
						this.builder.ProcessMarkup(array);
						this.namespaceManager.PopScope();
						this.builder.EndChildren();
					}
					this.markupDepth = int.MaxValue;
				}
				else
				{
					this.namespaceManager.PopScope();
					this.builder.EndChildren();
				}
				if (this.reader.Depth == this.schemaXmlDepth)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0007ED94 File Offset: 0x0007CF94
		private void ProcessAppInfoDocMarkup(bool root)
		{
			XmlNode newChild = null;
			switch (this.reader.NodeType)
			{
			case XmlNodeType.Element:
				this.annotationNSManager.PushScope();
				newChild = this.LoadElementNode(root);
				return;
			case XmlNodeType.Text:
				newChild = this.dummyDocument.CreateTextNode(this.reader.Value);
				break;
			case XmlNodeType.CDATA:
				newChild = this.dummyDocument.CreateCDataSection(this.reader.Value);
				break;
			case XmlNodeType.EntityReference:
				newChild = this.dummyDocument.CreateEntityReference(this.reader.Name);
				break;
			case XmlNodeType.ProcessingInstruction:
				newChild = this.dummyDocument.CreateProcessingInstruction(this.reader.Name, this.reader.Value);
				break;
			case XmlNodeType.Comment:
				newChild = this.dummyDocument.CreateComment(this.reader.Value);
				break;
			case XmlNodeType.Whitespace:
			case XmlNodeType.EndEntity:
				return;
			case XmlNodeType.SignificantWhitespace:
				newChild = this.dummyDocument.CreateSignificantWhitespace(this.reader.Value);
				break;
			case XmlNodeType.EndElement:
				this.annotationNSManager.PopScope();
				this.parentNode = this.parentNode.ParentNode;
				return;
			}
			this.parentNode.AppendChild(newChild);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0007EEE4 File Offset: 0x0007D0E4
		private XmlElement LoadElementNode(bool root)
		{
			XmlReader xmlReader = this.reader;
			bool isEmptyElement = xmlReader.IsEmptyElement;
			XmlElement xmlElement = this.dummyDocument.CreateElement(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
			xmlElement.IsEmpty = isEmptyElement;
			if (root)
			{
				this.parentNode = xmlElement;
			}
			else
			{
				XmlAttributeCollection attributes = xmlElement.Attributes;
				if (xmlReader.MoveToFirstAttribute())
				{
					do
					{
						if (Ref.Equal(xmlReader.NamespaceURI, this.schemaNames.NsXmlNs))
						{
							this.annotationNSManager.AddNamespace((xmlReader.Prefix.Length == 0) ? string.Empty : this.reader.LocalName, this.reader.Value);
						}
						XmlAttribute node = this.LoadAttributeNode();
						attributes.Append(node);
					}
					while (xmlReader.MoveToNextAttribute());
				}
				xmlReader.MoveToElement();
				string text = this.annotationNSManager.LookupNamespace(xmlReader.Prefix);
				if (text == null)
				{
					XmlAttribute node2 = this.CreateXmlNsAttribute(xmlReader.Prefix, this.namespaceManager.LookupNamespace(xmlReader.Prefix));
					attributes.Append(node2);
				}
				else if (text.Length == 0)
				{
					string text2 = this.namespaceManager.LookupNamespace(xmlReader.Prefix);
					if (text2 != string.Empty)
					{
						XmlAttribute node3 = this.CreateXmlNsAttribute(xmlReader.Prefix, text2);
						attributes.Append(node3);
					}
				}
				while (xmlReader.MoveToNextAttribute())
				{
					if (xmlReader.Prefix.Length != 0 && this.annotationNSManager.LookupNamespace(xmlReader.Prefix) == null)
					{
						XmlAttribute node4 = this.CreateXmlNsAttribute(xmlReader.Prefix, this.namespaceManager.LookupNamespace(xmlReader.Prefix));
						attributes.Append(node4);
					}
				}
				xmlReader.MoveToElement();
				this.parentNode.AppendChild(xmlElement);
				if (!xmlReader.IsEmptyElement)
				{
					this.parentNode = xmlElement;
				}
			}
			return xmlElement;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0007F0B0 File Offset: 0x0007D2B0
		private XmlAttribute CreateXmlNsAttribute(string prefix, string value)
		{
			XmlAttribute xmlAttribute;
			if (prefix.Length == 0)
			{
				xmlAttribute = this.dummyDocument.CreateAttribute(string.Empty, this.xmlns, "http://www.w3.org/2000/xmlns/");
			}
			else
			{
				xmlAttribute = this.dummyDocument.CreateAttribute(this.xmlns, prefix, "http://www.w3.org/2000/xmlns/");
			}
			xmlAttribute.AppendChild(this.dummyDocument.CreateTextNode(value));
			this.annotationNSManager.AddNamespace(prefix, value);
			return xmlAttribute;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0007F11C File Offset: 0x0007D31C
		private XmlAttribute LoadAttributeNode()
		{
			XmlReader xmlReader = this.reader;
			XmlAttribute xmlAttribute = this.dummyDocument.CreateAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
			while (xmlReader.ReadAttributeValue())
			{
				XmlNodeType nodeType = xmlReader.NodeType;
				if (nodeType != XmlNodeType.Text)
				{
					if (nodeType != XmlNodeType.EntityReference)
					{
						throw XmlLoader.UnexpectedNodeType(xmlReader.NodeType);
					}
					xmlAttribute.AppendChild(this.LoadEntityReferenceInAttribute());
				}
				else
				{
					xmlAttribute.AppendChild(this.dummyDocument.CreateTextNode(xmlReader.Value));
				}
			}
			return xmlAttribute;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0007F1A0 File Offset: 0x0007D3A0
		private XmlEntityReference LoadEntityReferenceInAttribute()
		{
			XmlEntityReference xmlEntityReference = this.dummyDocument.CreateEntityReference(this.reader.LocalName);
			if (!this.reader.CanResolveEntity)
			{
				return xmlEntityReference;
			}
			this.reader.ResolveEntity();
			while (this.reader.ReadAttributeValue())
			{
				XmlNodeType nodeType = this.reader.NodeType;
				if (nodeType != XmlNodeType.Text)
				{
					if (nodeType != XmlNodeType.EntityReference)
					{
						if (nodeType != XmlNodeType.EndEntity)
						{
							throw XmlLoader.UnexpectedNodeType(this.reader.NodeType);
						}
						if (xmlEntityReference.ChildNodes.Count == 0)
						{
							xmlEntityReference.AppendChild(this.dummyDocument.CreateTextNode(string.Empty));
						}
						return xmlEntityReference;
					}
					else
					{
						xmlEntityReference.AppendChild(this.LoadEntityReferenceInAttribute());
					}
				}
				else
				{
					xmlEntityReference.AppendChild(this.dummyDocument.CreateTextNode(this.reader.Value));
				}
			}
			return xmlEntityReference;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0007F274 File Offset: 0x0007D474
		public Task StartParsingAsync(XmlReader reader, string targetNamespace)
		{
			Parser.<StartParsingAsync>d__38 <StartParsingAsync>d__;
			<StartParsingAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<StartParsingAsync>d__.<>4__this = this;
			<StartParsingAsync>d__.reader = reader;
			<StartParsingAsync>d__.targetNamespace = targetNamespace;
			<StartParsingAsync>d__.<>1__state = -1;
			<StartParsingAsync>d__.<>t__builder.Start<Parser.<StartParsingAsync>d__38>(ref <StartParsingAsync>d__);
			return <StartParsingAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000DCE RID: 3534
		private SchemaType schemaType;

		// Token: 0x04000DCF RID: 3535
		private XmlNameTable nameTable;

		// Token: 0x04000DD0 RID: 3536
		private SchemaNames schemaNames;

		// Token: 0x04000DD1 RID: 3537
		private ValidationEventHandler eventHandler;

		// Token: 0x04000DD2 RID: 3538
		private XmlNamespaceManager namespaceManager;

		// Token: 0x04000DD3 RID: 3539
		private XmlReader reader;

		// Token: 0x04000DD4 RID: 3540
		private PositionInfo positionInfo;

		// Token: 0x04000DD5 RID: 3541
		private bool isProcessNamespaces;

		// Token: 0x04000DD6 RID: 3542
		private int schemaXmlDepth;

		// Token: 0x04000DD7 RID: 3543
		private int markupDepth;

		// Token: 0x04000DD8 RID: 3544
		private SchemaBuilder builder;

		// Token: 0x04000DD9 RID: 3545
		private XmlSchema schema;

		// Token: 0x04000DDA RID: 3546
		private SchemaInfo xdrSchema;

		// Token: 0x04000DDB RID: 3547
		private XmlResolver xmlResolver;

		// Token: 0x04000DDC RID: 3548
		private XmlDocument dummyDocument;

		// Token: 0x04000DDD RID: 3549
		private bool processMarkup;

		// Token: 0x04000DDE RID: 3550
		private XmlNode parentNode;

		// Token: 0x04000DDF RID: 3551
		private XmlNamespaceManager annotationNSManager;

		// Token: 0x04000DE0 RID: 3552
		private string xmlns;

		// Token: 0x04000DE1 RID: 3553
		private XmlCharType xmlCharType = XmlCharType.Instance;
	}
}
