using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x0200012C RID: 300
	internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x00043C84 File Offset: 0x00041E84
		internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType)
		{
			this.coreReader = reader;
			this.coreReaderNSResolver = (reader as IXmlNamespaceResolver);
			this.lineInfo = (reader as IXmlLineInfo);
			this.coreReaderNameTable = this.coreReader.NameTable;
			if (this.coreReaderNSResolver == null)
			{
				this.nsManager = new XmlNamespaceManager(this.coreReaderNameTable);
				this.manageNamespaces = true;
			}
			this.thisNSResolver = this;
			this.xmlResolver = xmlResolver;
			this.processInlineSchema = ((readerSettings.ValidationFlags & XmlSchemaValidationFlags.ProcessInlineSchema) > XmlSchemaValidationFlags.None);
			this.Init();
			this.SetupValidator(readerSettings, reader, partialValidationType);
			this.validationEvent = readerSettings.GetEventHandler();
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00043D2D File Offset: 0x00041F2D
		internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) : this(reader, xmlResolver, readerSettings, null)
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00043D3C File Offset: 0x00041F3C
		private void Init()
		{
			this.validationState = XsdValidatingReader.ValidatingReaderState.Init;
			this.defaultAttributes = new ArrayList();
			this.currentAttrIndex = -1;
			this.attributePSVINodes = new AttributePSVIInfo[8];
			this.valueGetter = new XmlValueGetter(this.GetStringValue);
			XsdValidatingReader.TypeOfString = typeof(string);
			this.xmlSchemaInfo = new XmlSchemaInfo();
			this.NsXmlNs = this.coreReaderNameTable.Add("http://www.w3.org/2000/xmlns/");
			this.NsXs = this.coreReaderNameTable.Add("http://www.w3.org/2001/XMLSchema");
			this.NsXsi = this.coreReaderNameTable.Add("http://www.w3.org/2001/XMLSchema-instance");
			this.XsiType = this.coreReaderNameTable.Add("type");
			this.XsiNil = this.coreReaderNameTable.Add("nil");
			this.XsiSchemaLocation = this.coreReaderNameTable.Add("schemaLocation");
			this.XsiNoNamespaceSchemaLocation = this.coreReaderNameTable.Add("noNamespaceSchemaLocation");
			this.XsdSchema = this.coreReaderNameTable.Add("schema");
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00043E4C File Offset: 0x0004204C
		private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType)
		{
			this.validator = new XmlSchemaValidator(this.coreReaderNameTable, readerSettings.Schemas, this.thisNSResolver, readerSettings.ValidationFlags);
			this.validator.XmlResolver = this.xmlResolver;
			this.validator.SourceUri = XmlConvert.ToUri(reader.BaseURI);
			this.validator.ValidationEventSender = this;
			this.validator.ValidationEventHandler += readerSettings.GetEventHandler();
			this.validator.LineInfoProvider = this.lineInfo;
			if (this.validator.ProcessSchemaHints)
			{
				this.validator.SchemaSet.ReaderSettings.DtdProcessing = readerSettings.DtdProcessing;
			}
			this.validator.SetDtdSchemaInfo(reader.DtdInfo);
			if (partialValidationType != null)
			{
				this.validator.Initialize(partialValidationType);
				return;
			}
			this.validator.Initialize();
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00043F28 File Offset: 0x00042128
		public override XmlReaderSettings Settings
		{
			get
			{
				XmlReaderSettings xmlReaderSettings = this.coreReader.Settings;
				if (xmlReaderSettings != null)
				{
					xmlReaderSettings = xmlReaderSettings.Clone();
				}
				if (xmlReaderSettings == null)
				{
					xmlReaderSettings = new XmlReaderSettings();
				}
				xmlReaderSettings.Schemas = this.validator.SchemaSet;
				xmlReaderSettings.ValidationType = ValidationType.Schema;
				xmlReaderSettings.ValidationFlags = this.validator.ValidationFlags;
				xmlReaderSettings.ReadOnly = true;
				return xmlReaderSettings;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00043F88 File Offset: 0x00042188
		public override XmlNodeType NodeType
		{
			get
			{
				if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
				{
					return this.cachedNode.NodeType;
				}
				XmlNodeType nodeType = this.coreReader.NodeType;
				if (nodeType == XmlNodeType.Whitespace && (this.validator.CurrentContentType == XmlSchemaContentType.TextOnly || this.validator.CurrentContentType == XmlSchemaContentType.Mixed))
				{
					return XmlNodeType.SignificantWhitespace;
				}
				return nodeType;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00043FDC File Offset: 0x000421DC
		public override string Name
		{
			get
			{
				if (this.validationState != XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute)
				{
					return this.coreReader.Name;
				}
				string defaultAttributePrefix = this.validator.GetDefaultAttributePrefix(this.cachedNode.Namespace);
				if (defaultAttributePrefix != null && defaultAttributePrefix.Length != 0)
				{
					return string.Concat(new string[]
					{
						defaultAttributePrefix + ":" + this.cachedNode.LocalName
					});
				}
				return this.cachedNode.LocalName;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00044050 File Offset: 0x00042250
		public override string LocalName
		{
			get
			{
				if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
				{
					return this.cachedNode.LocalName;
				}
				return this.coreReader.LocalName;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00044072 File Offset: 0x00042272
		public override string NamespaceURI
		{
			get
			{
				if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
				{
					return this.cachedNode.Namespace;
				}
				return this.coreReader.NamespaceURI;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00044094 File Offset: 0x00042294
		public override string Prefix
		{
			get
			{
				if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
				{
					return this.cachedNode.Prefix;
				}
				return this.coreReader.Prefix;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000440B6 File Offset: 0x000422B6
		public override string Value
		{
			get
			{
				if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
				{
					return this.cachedNode.RawValue;
				}
				return this.coreReader.Value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000440D8 File Offset: 0x000422D8
		public override int Depth
		{
			get
			{
				if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
				{
					return this.cachedNode.Depth;
				}
				return this.coreReader.Depth;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000440FA File Offset: 0x000422FA
		public override string BaseURI
		{
			get
			{
				return this.coreReader.BaseURI;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00044107 File Offset: 0x00042307
		public override bool IsEmptyElement
		{
			get
			{
				return this.coreReader.IsEmptyElement;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00044114 File Offset: 0x00042314
		public override bool IsDefault
		{
			get
			{
				return this.validationState == XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute || this.coreReader.IsDefault;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0004412C File Offset: 0x0004232C
		public override char QuoteChar
		{
			get
			{
				return this.coreReader.QuoteChar;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00044139 File Offset: 0x00042339
		public override XmlSpace XmlSpace
		{
			get
			{
				return this.coreReader.XmlSpace;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00044146 File Offset: 0x00042346
		public override string XmlLang
		{
			get
			{
				return this.coreReader.XmlLang;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00044153 File Offset: 0x00042353
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00044158 File Offset: 0x00042358
		public override Type ValueType
		{
			get
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType != XmlNodeType.Element)
				{
					if (nodeType != XmlNodeType.Attribute)
					{
						if (nodeType != XmlNodeType.EndElement)
						{
							goto IL_62;
						}
					}
					else
					{
						if (this.attributePSVI != null && this.AttributeSchemaInfo.ContentType == XmlSchemaContentType.TextOnly)
						{
							return this.AttributeSchemaInfo.SchemaType.Datatype.ValueType;
						}
						goto IL_62;
					}
				}
				if (this.xmlSchemaInfo.ContentType == XmlSchemaContentType.TextOnly)
				{
					return this.xmlSchemaInfo.SchemaType.Datatype.ValueType;
				}
				IL_62:
				return XsdValidatingReader.TypeOfString;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000441CE File Offset: 0x000423CE
		public override int AttributeCount
		{
			get
			{
				return this.attributeCount;
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x000441D8 File Offset: 0x000423D8
		public override string GetAttribute(string name)
		{
			string text = this.coreReader.GetAttribute(name);
			if (text == null && this.attributeCount > 0)
			{
				ValidatingReaderNodeData defaultAttribute = this.GetDefaultAttribute(name, false);
				if (defaultAttribute != null)
				{
					text = defaultAttribute.RawValue;
				}
			}
			return text;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00044214 File Offset: 0x00042414
		public override string GetAttribute(string name, string namespaceURI)
		{
			string attribute = this.coreReader.GetAttribute(name, namespaceURI);
			if (attribute == null && this.attributeCount > 0)
			{
				namespaceURI = ((namespaceURI == null) ? string.Empty : this.coreReaderNameTable.Get(namespaceURI));
				name = this.coreReaderNameTable.Get(name);
				if (name == null || namespaceURI == null)
				{
					return null;
				}
				ValidatingReaderNodeData defaultAttribute = this.GetDefaultAttribute(name, namespaceURI, false);
				if (defaultAttribute != null)
				{
					return defaultAttribute.RawValue;
				}
			}
			return attribute;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00044280 File Offset: 0x00042480
		public override string GetAttribute(int i)
		{
			if (this.attributeCount == 0)
			{
				return null;
			}
			if (i < this.coreReaderAttributeCount)
			{
				return this.coreReader.GetAttribute(i);
			}
			int index = i - this.coreReaderAttributeCount;
			return ((ValidatingReaderNodeData)this.defaultAttributes[index]).RawValue;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000442CC File Offset: 0x000424CC
		public override bool MoveToAttribute(string name)
		{
			if (!this.coreReader.MoveToAttribute(name))
			{
				if (this.attributeCount > 0)
				{
					ValidatingReaderNodeData defaultAttribute = this.GetDefaultAttribute(name, true);
					if (defaultAttribute != null)
					{
						this.validationState = XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute;
						this.attributePSVI = defaultAttribute.AttInfo;
						this.cachedNode = defaultAttribute;
						goto IL_57;
					}
				}
				return false;
			}
			this.validationState = XsdValidatingReader.ValidatingReaderState.OnAttribute;
			this.attributePSVI = this.GetAttributePSVI(name);
			IL_57:
			if (this.validationState == XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent)
			{
				this.readBinaryHelper.Finish();
				this.validationState = this.savedState;
			}
			return true;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00044354 File Offset: 0x00042554
		public override void MoveToAttribute(int i)
		{
			if (i < 0 || i >= this.attributeCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			this.currentAttrIndex = i;
			if (i < this.coreReaderAttributeCount)
			{
				this.coreReader.MoveToAttribute(i);
				if (this.inlineSchemaParser == null)
				{
					this.attributePSVI = this.attributePSVINodes[i];
				}
				else
				{
					this.attributePSVI = null;
				}
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnAttribute;
			}
			else
			{
				int index = i - this.coreReaderAttributeCount;
				this.cachedNode = (ValidatingReaderNodeData)this.defaultAttributes[index];
				this.attributePSVI = this.cachedNode.AttInfo;
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute;
			}
			if (this.validationState == XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent)
			{
				this.readBinaryHelper.Finish();
				this.validationState = this.savedState;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00044418 File Offset: 0x00042618
		public override bool MoveToFirstAttribute()
		{
			if (this.coreReader.MoveToFirstAttribute())
			{
				this.currentAttrIndex = 0;
				if (this.inlineSchemaParser == null)
				{
					this.attributePSVI = this.attributePSVINodes[0];
				}
				else
				{
					this.attributePSVI = null;
				}
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnAttribute;
			}
			else
			{
				if (this.defaultAttributes.Count <= 0)
				{
					return false;
				}
				this.cachedNode = (ValidatingReaderNodeData)this.defaultAttributes[0];
				this.attributePSVI = this.cachedNode.AttInfo;
				this.currentAttrIndex = 0;
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute;
			}
			if (this.validationState == XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent)
			{
				this.readBinaryHelper.Finish();
				this.validationState = this.savedState;
			}
			return true;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000444CC File Offset: 0x000426CC
		public override bool MoveToNextAttribute()
		{
			if (this.currentAttrIndex + 1 < this.coreReaderAttributeCount)
			{
				this.coreReader.MoveToNextAttribute();
				this.currentAttrIndex++;
				if (this.inlineSchemaParser == null)
				{
					this.attributePSVI = this.attributePSVINodes[this.currentAttrIndex];
				}
				else
				{
					this.attributePSVI = null;
				}
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnAttribute;
			}
			else
			{
				if (this.currentAttrIndex + 1 >= this.attributeCount)
				{
					return false;
				}
				int num = this.currentAttrIndex + 1;
				this.currentAttrIndex = num;
				int index = num - this.coreReaderAttributeCount;
				this.cachedNode = (ValidatingReaderNodeData)this.defaultAttributes[index];
				this.attributePSVI = this.cachedNode.AttInfo;
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute;
			}
			if (this.validationState == XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent)
			{
				this.readBinaryHelper.Finish();
				this.validationState = this.savedState;
			}
			return true;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000445AD File Offset: 0x000427AD
		public override bool MoveToElement()
		{
			if (this.coreReader.MoveToElement() || this.validationState < XsdValidatingReader.ValidatingReaderState.None)
			{
				this.currentAttrIndex = -1;
				this.validationState = XsdValidatingReader.ValidatingReaderState.ClearAttributes;
				return true;
			}
			return false;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000445D8 File Offset: 0x000427D8
		public override bool Read()
		{
			switch (this.validationState)
			{
			case XsdValidatingReader.ValidatingReaderState.OnReadAttributeValue:
			case XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute:
			case XsdValidatingReader.ValidatingReaderState.OnAttribute:
			case XsdValidatingReader.ValidatingReaderState.ClearAttributes:
				this.ClearAttributesInfo();
				if (this.inlineSchemaParser != null)
				{
					this.validationState = XsdValidatingReader.ValidatingReaderState.ParseInlineSchema;
					goto IL_7C;
				}
				this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				break;
			case XsdValidatingReader.ValidatingReaderState.None:
				return false;
			case XsdValidatingReader.ValidatingReaderState.Init:
				this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				if (this.coreReader.ReadState == ReadState.Interactive)
				{
					this.ProcessReaderEvent();
					return true;
				}
				break;
			case XsdValidatingReader.ValidatingReaderState.Read:
				break;
			case XsdValidatingReader.ValidatingReaderState.ParseInlineSchema:
				goto IL_7C;
			case XsdValidatingReader.ValidatingReaderState.ReadAhead:
				this.ClearAttributesInfo();
				this.ProcessReaderEvent();
				this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				return true;
			case XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent:
				this.validationState = this.savedState;
				this.readBinaryHelper.Finish();
				return this.Read();
			case XsdValidatingReader.ValidatingReaderState.ReaderClosed:
			case XsdValidatingReader.ValidatingReaderState.EOF:
				return false;
			default:
				return false;
			}
			if (this.coreReader.Read())
			{
				this.ProcessReaderEvent();
				return true;
			}
			this.validator.EndValidation();
			if (this.coreReader.EOF)
			{
				this.validationState = XsdValidatingReader.ValidatingReaderState.EOF;
			}
			return false;
			IL_7C:
			this.ProcessInlineSchema();
			return true;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000446DF File Offset: 0x000428DF
		public override bool EOF
		{
			get
			{
				return this.coreReader.EOF;
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000446EC File Offset: 0x000428EC
		public override void Close()
		{
			this.coreReader.Close();
			this.validationState = XsdValidatingReader.ValidatingReaderState.ReaderClosed;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00044700 File Offset: 0x00042900
		public override ReadState ReadState
		{
			get
			{
				if (this.validationState != XsdValidatingReader.ValidatingReaderState.Init)
				{
					return this.coreReader.ReadState;
				}
				return ReadState.Initial;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00044718 File Offset: 0x00042918
		public override void Skip()
		{
			int depth = this.Depth;
			XmlNodeType nodeType = this.NodeType;
			if (nodeType != XmlNodeType.Element)
			{
				if (nodeType != XmlNodeType.Attribute)
				{
					goto IL_81;
				}
				this.MoveToElement();
			}
			if (!this.coreReader.IsEmptyElement)
			{
				bool flag = true;
				if ((this.xmlSchemaInfo.IsUnionType || this.xmlSchemaInfo.IsDefault) && this.coreReader is XsdCachingReader)
				{
					flag = false;
				}
				this.coreReader.Skip();
				this.validationState = XsdValidatingReader.ValidatingReaderState.ReadAhead;
				if (flag)
				{
					this.validator.SkipToEndElement(this.xmlSchemaInfo);
				}
			}
			IL_81:
			this.Read();
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000447AD File Offset: 0x000429AD
		public override XmlNameTable NameTable
		{
			get
			{
				return this.coreReaderNameTable;
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000447B5 File Offset: 0x000429B5
		public override string LookupNamespace(string prefix)
		{
			return this.thisNSResolver.LookupNamespace(prefix);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000434BD File Offset: 0x000416BD
		public override void ResolveEntity()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000447C4 File Offset: 0x000429C4
		public override bool ReadAttributeValue()
		{
			if (this.validationState == XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent)
			{
				this.readBinaryHelper.Finish();
				this.validationState = this.savedState;
			}
			if (this.NodeType != XmlNodeType.Attribute)
			{
				return false;
			}
			if (this.validationState == XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute)
			{
				this.cachedNode = this.CreateDummyTextNode(this.cachedNode.RawValue, this.cachedNode.Depth + 1);
				this.validationState = XsdValidatingReader.ValidatingReaderState.OnReadAttributeValue;
				return true;
			}
			return this.coreReader.ReadAttributeValue();
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00044840 File Offset: 0x00042A40
		bool IXmlSchemaInfo.IsDefault
		{
			get
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType != XmlNodeType.Element)
				{
					if (nodeType != XmlNodeType.Attribute)
					{
						if (nodeType == XmlNodeType.EndElement)
						{
							return this.xmlSchemaInfo.IsDefault;
						}
					}
					else if (this.attributePSVI != null)
					{
						return this.AttributeSchemaInfo.IsDefault;
					}
					return false;
				}
				if (!this.coreReader.IsEmptyElement)
				{
					this.GetIsDefault();
				}
				return this.xmlSchemaInfo.IsDefault;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000448A4 File Offset: 0x00042AA4
		bool IXmlSchemaInfo.IsNil
		{
			get
			{
				XmlNodeType nodeType = this.NodeType;
				return (nodeType == XmlNodeType.Element || nodeType == XmlNodeType.EndElement) && this.xmlSchemaInfo.IsNil;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000448D0 File Offset: 0x00042AD0
		XmlSchemaValidity IXmlSchemaInfo.Validity
		{
			get
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType != XmlNodeType.Element)
				{
					if (nodeType != XmlNodeType.Attribute)
					{
						if (nodeType == XmlNodeType.EndElement)
						{
							return this.xmlSchemaInfo.Validity;
						}
					}
					else if (this.attributePSVI != null)
					{
						return this.AttributeSchemaInfo.Validity;
					}
					return XmlSchemaValidity.NotKnown;
				}
				if (this.coreReader.IsEmptyElement)
				{
					return this.xmlSchemaInfo.Validity;
				}
				if (this.xmlSchemaInfo.Validity == XmlSchemaValidity.Valid)
				{
					return XmlSchemaValidity.NotKnown;
				}
				return this.xmlSchemaInfo.Validity;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0004494C File Offset: 0x00042B4C
		XmlSchemaSimpleType IXmlSchemaInfo.MemberType
		{
			get
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType == XmlNodeType.Element)
				{
					if (!this.coreReader.IsEmptyElement)
					{
						this.GetMemberType();
					}
					return this.xmlSchemaInfo.MemberType;
				}
				if (nodeType != XmlNodeType.Attribute)
				{
					if (nodeType != XmlNodeType.EndElement)
					{
						return null;
					}
					return this.xmlSchemaInfo.MemberType;
				}
				else
				{
					if (this.attributePSVI != null)
					{
						return this.AttributeSchemaInfo.MemberType;
					}
					return null;
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000449B4 File Offset: 0x00042BB4
		XmlSchemaType IXmlSchemaInfo.SchemaType
		{
			get
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType != XmlNodeType.Element)
				{
					if (nodeType != XmlNodeType.Attribute)
					{
						if (nodeType != XmlNodeType.EndElement)
						{
							return null;
						}
					}
					else
					{
						if (this.attributePSVI != null)
						{
							return this.AttributeSchemaInfo.SchemaType;
						}
						return null;
					}
				}
				return this.xmlSchemaInfo.SchemaType;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000449F8 File Offset: 0x00042BF8
		XmlSchemaElement IXmlSchemaInfo.SchemaElement
		{
			get
			{
				if (this.NodeType == XmlNodeType.Element || this.NodeType == XmlNodeType.EndElement)
				{
					return this.xmlSchemaInfo.SchemaElement;
				}
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00044A1A File Offset: 0x00042C1A
		XmlSchemaAttribute IXmlSchemaInfo.SchemaAttribute
		{
			get
			{
				if (this.NodeType == XmlNodeType.Attribute && this.attributePSVI != null)
				{
					return this.AttributeSchemaInfo.SchemaAttribute;
				}
				return null;
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public bool HasLineInfo()
		{
			return true;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00044A3A File Offset: 0x00042C3A
		public int LineNumber
		{
			get
			{
				if (this.lineInfo != null)
				{
					return this.lineInfo.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00044A51 File Offset: 0x00042C51
		public int LinePosition
		{
			get
			{
				if (this.lineInfo != null)
				{
					return this.lineInfo.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00044A68 File Offset: 0x00042C68
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			if (this.coreReaderNSResolver != null)
			{
				return this.coreReaderNSResolver.GetNamespacesInScope(scope);
			}
			return this.nsManager.GetNamespacesInScope(scope);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00044A8B File Offset: 0x00042C8B
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			if (this.coreReaderNSResolver != null)
			{
				return this.coreReaderNSResolver.LookupNamespace(prefix);
			}
			return this.nsManager.LookupNamespace(prefix);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00044AAE File Offset: 0x00042CAE
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			if (this.coreReaderNSResolver != null)
			{
				return this.coreReaderNSResolver.LookupPrefix(namespaceName);
			}
			return this.nsManager.LookupPrefix(namespaceName);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00044AD1 File Offset: 0x00042CD1
		private object GetStringValue()
		{
			return this.coreReader.Value;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00044ADE File Offset: 0x00042CDE
		private XmlSchemaInfo AttributeSchemaInfo
		{
			get
			{
				return this.attributePSVI.attributeSchemaInfo;
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00044AEC File Offset: 0x00042CEC
		private void ProcessReaderEvent()
		{
			if (this.replayCache)
			{
				return;
			}
			switch (this.coreReader.NodeType)
			{
			case XmlNodeType.Element:
				this.ProcessElementEvent();
				return;
			case XmlNodeType.Attribute:
			case XmlNodeType.Entity:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Comment:
			case XmlNodeType.Document:
			case XmlNodeType.DocumentFragment:
			case XmlNodeType.Notation:
				break;
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
				this.validator.ValidateText(new XmlValueGetter(this.GetStringValue));
				return;
			case XmlNodeType.EntityReference:
				throw new InvalidOperationException();
			case XmlNodeType.DocumentType:
				this.validator.SetDtdSchemaInfo(this.coreReader.DtdInfo);
				break;
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				this.validator.ValidateWhitespace(new XmlValueGetter(this.GetStringValue));
				return;
			case XmlNodeType.EndElement:
				this.ProcessEndElementEvent();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00044BB0 File Offset: 0x00042DB0
		private void ProcessElementEvent()
		{
			if (!this.processInlineSchema || !this.IsXSDRoot(this.coreReader.LocalName, this.coreReader.NamespaceURI) || this.coreReader.Depth <= 0)
			{
				this.atomicValue = null;
				this.originalAtomicValueString = null;
				this.xmlSchemaInfo.Clear();
				if (this.manageNamespaces)
				{
					this.nsManager.PushScope();
				}
				string xsiSchemaLocation = null;
				string xsiNoNamespaceSchemaLocation = null;
				string xsiNil = null;
				string xsiType = null;
				if (this.coreReader.MoveToFirstAttribute())
				{
					do
					{
						string namespaceURI = this.coreReader.NamespaceURI;
						string localName = this.coreReader.LocalName;
						if (Ref.Equal(namespaceURI, this.NsXsi))
						{
							if (Ref.Equal(localName, this.XsiSchemaLocation))
							{
								xsiSchemaLocation = this.coreReader.Value;
							}
							else if (Ref.Equal(localName, this.XsiNoNamespaceSchemaLocation))
							{
								xsiNoNamespaceSchemaLocation = this.coreReader.Value;
							}
							else if (Ref.Equal(localName, this.XsiType))
							{
								xsiType = this.coreReader.Value;
							}
							else if (Ref.Equal(localName, this.XsiNil))
							{
								xsiNil = this.coreReader.Value;
							}
						}
						if (this.manageNamespaces && Ref.Equal(this.coreReader.NamespaceURI, this.NsXmlNs))
						{
							this.nsManager.AddNamespace((this.coreReader.Prefix.Length == 0) ? string.Empty : this.coreReader.LocalName, this.coreReader.Value);
						}
					}
					while (this.coreReader.MoveToNextAttribute());
					this.coreReader.MoveToElement();
				}
				this.validator.ValidateElement(this.coreReader.LocalName, this.coreReader.NamespaceURI, this.xmlSchemaInfo, xsiType, xsiNil, xsiSchemaLocation, xsiNoNamespaceSchemaLocation);
				this.ValidateAttributes();
				this.validator.ValidateEndOfAttributes(this.xmlSchemaInfo);
				if (this.coreReader.IsEmptyElement)
				{
					this.ProcessEndElementEvent();
				}
				this.validationState = XsdValidatingReader.ValidatingReaderState.ClearAttributes;
				return;
			}
			this.xmlSchemaInfo.Clear();
			this.attributeCount = (this.coreReaderAttributeCount = this.coreReader.AttributeCount);
			if (!this.coreReader.IsEmptyElement)
			{
				this.inlineSchemaParser = new Parser(SchemaType.XSD, this.coreReaderNameTable, this.validator.SchemaSet.GetSchemaNames(this.coreReaderNameTable), this.validationEvent);
				this.inlineSchemaParser.StartParsing(this.coreReader, null);
				this.inlineSchemaParser.ParseReaderNode();
				this.validationState = XsdValidatingReader.ValidatingReaderState.ParseInlineSchema;
				return;
			}
			this.validationState = XsdValidatingReader.ValidatingReaderState.ClearAttributes;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00044E38 File Offset: 0x00043038
		private void ProcessEndElementEvent()
		{
			this.atomicValue = this.validator.ValidateEndElement(this.xmlSchemaInfo);
			this.originalAtomicValueString = this.GetOriginalAtomicValueStringOfElement();
			if (this.xmlSchemaInfo.IsDefault)
			{
				int depth = this.coreReader.Depth;
				this.coreReader = this.GetCachingReader();
				this.cachingReader.RecordTextNode(this.xmlSchemaInfo.XmlType.ValueConverter.ToString(this.atomicValue), this.originalAtomicValueString, depth + 1, 0, 0);
				this.cachingReader.RecordEndElementNode();
				this.cachingReader.SetToReplayMode();
				this.replayCache = true;
				return;
			}
			if (this.manageNamespaces)
			{
				this.nsManager.PopScope();
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00044EF4 File Offset: 0x000430F4
		private void ValidateAttributes()
		{
			this.attributeCount = (this.coreReaderAttributeCount = this.coreReader.AttributeCount);
			int num = 0;
			bool flag = false;
			if (this.coreReader.MoveToFirstAttribute())
			{
				do
				{
					string localName = this.coreReader.LocalName;
					string namespaceURI = this.coreReader.NamespaceURI;
					AttributePSVIInfo attributePSVIInfo = this.AddAttributePSVI(num);
					attributePSVIInfo.localName = localName;
					attributePSVIInfo.namespaceUri = namespaceURI;
					if (namespaceURI == this.NsXmlNs)
					{
						num++;
					}
					else
					{
						attributePSVIInfo.typedAttributeValue = this.validator.ValidateAttribute(localName, namespaceURI, this.valueGetter, attributePSVIInfo.attributeSchemaInfo);
						if (!flag)
						{
							flag = (attributePSVIInfo.attributeSchemaInfo.Validity == XmlSchemaValidity.Invalid);
						}
						num++;
					}
				}
				while (this.coreReader.MoveToNextAttribute());
			}
			this.coreReader.MoveToElement();
			if (flag)
			{
				this.xmlSchemaInfo.Validity = XmlSchemaValidity.Invalid;
			}
			this.validator.GetUnspecifiedDefaultAttributes(this.defaultAttributes, true);
			this.attributeCount += this.defaultAttributes.Count;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00044FFD File Offset: 0x000431FD
		private void ClearAttributesInfo()
		{
			this.attributeCount = 0;
			this.coreReaderAttributeCount = 0;
			this.currentAttrIndex = -1;
			this.defaultAttributes.Clear();
			this.attributePSVI = null;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00045028 File Offset: 0x00043228
		private AttributePSVIInfo GetAttributePSVI(string name)
		{
			if (this.inlineSchemaParser != null)
			{
				return null;
			}
			string text;
			string text2;
			ValidateNames.SplitQName(name, out text, out text2);
			text = this.coreReaderNameTable.Add(text);
			text2 = this.coreReaderNameTable.Add(text2);
			string ns;
			if (text.Length == 0)
			{
				ns = string.Empty;
			}
			else
			{
				ns = this.thisNSResolver.LookupNamespace(text);
			}
			return this.GetAttributePSVI(text2, ns);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00045088 File Offset: 0x00043288
		private AttributePSVIInfo GetAttributePSVI(string localName, string ns)
		{
			for (int i = 0; i < this.coreReaderAttributeCount; i++)
			{
				AttributePSVIInfo attributePSVIInfo = this.attributePSVINodes[i];
				if (attributePSVIInfo != null && Ref.Equal(localName, attributePSVIInfo.localName) && Ref.Equal(ns, attributePSVIInfo.namespaceUri))
				{
					this.currentAttrIndex = i;
					return attributePSVIInfo;
				}
			}
			return null;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000450DC File Offset: 0x000432DC
		private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition)
		{
			string text;
			string text2;
			ValidateNames.SplitQName(name, out text, out text2);
			text = this.coreReaderNameTable.Add(text);
			text2 = this.coreReaderNameTable.Add(text2);
			string ns;
			if (text.Length == 0)
			{
				ns = string.Empty;
			}
			else
			{
				ns = this.thisNSResolver.LookupNamespace(text);
			}
			return this.GetDefaultAttribute(text2, ns, updatePosition);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00045134 File Offset: 0x00043334
		private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition)
		{
			for (int i = 0; i < this.defaultAttributes.Count; i++)
			{
				ValidatingReaderNodeData validatingReaderNodeData = (ValidatingReaderNodeData)this.defaultAttributes[i];
				if (Ref.Equal(validatingReaderNodeData.LocalName, attrLocalName) && Ref.Equal(validatingReaderNodeData.Namespace, ns))
				{
					if (updatePosition)
					{
						this.currentAttrIndex = this.coreReader.AttributeCount + i;
					}
					return validatingReaderNodeData;
				}
			}
			return null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000451A0 File Offset: 0x000433A0
		private AttributePSVIInfo AddAttributePSVI(int attIndex)
		{
			AttributePSVIInfo attributePSVIInfo = this.attributePSVINodes[attIndex];
			if (attributePSVIInfo != null)
			{
				attributePSVIInfo.Reset();
				return attributePSVIInfo;
			}
			if (attIndex >= this.attributePSVINodes.Length - 1)
			{
				AttributePSVIInfo[] destinationArray = new AttributePSVIInfo[this.attributePSVINodes.Length * 2];
				Array.Copy(this.attributePSVINodes, 0, destinationArray, 0, this.attributePSVINodes.Length);
				this.attributePSVINodes = destinationArray;
			}
			attributePSVIInfo = this.attributePSVINodes[attIndex];
			if (attributePSVIInfo == null)
			{
				attributePSVIInfo = new AttributePSVIInfo();
				this.attributePSVINodes[attIndex] = attributePSVIInfo;
			}
			return attributePSVIInfo;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00045217 File Offset: 0x00043417
		private bool IsXSDRoot(string localName, string ns)
		{
			return Ref.Equal(ns, this.NsXs) && Ref.Equal(localName, this.XsdSchema);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00045238 File Offset: 0x00043438
		private void ProcessInlineSchema()
		{
			if (this.coreReader.Read())
			{
				if (this.coreReader.NodeType == XmlNodeType.Element)
				{
					this.attributeCount = (this.coreReaderAttributeCount = this.coreReader.AttributeCount);
				}
				else
				{
					this.ClearAttributesInfo();
				}
				if (!this.inlineSchemaParser.ParseReaderNode())
				{
					this.inlineSchemaParser.FinishParsing();
					XmlSchema xmlSchema = this.inlineSchemaParser.XmlSchema;
					this.validator.AddSchema(xmlSchema);
					this.inlineSchemaParser = null;
					this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				}
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000452C4 File Offset: 0x000434C4
		private void ReadAheadForMemberType()
		{
			while (this.coreReader.Read())
			{
				switch (this.coreReader.NodeType)
				{
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
					this.validator.ValidateText(new XmlValueGetter(this.GetStringValue));
					break;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					this.validator.ValidateWhitespace(new XmlValueGetter(this.GetStringValue));
					break;
				case XmlNodeType.EndElement:
					this.atomicValue = this.validator.ValidateEndElement(this.xmlSchemaInfo);
					this.originalAtomicValueString = this.GetOriginalAtomicValueStringOfElement();
					if (this.atomicValue == null)
					{
						this.atomicValue = this;
						return;
					}
					if (this.xmlSchemaInfo.IsDefault)
					{
						this.cachingReader.SwitchTextNodeAndEndElement(this.xmlSchemaInfo.XmlType.ValueConverter.ToString(this.atomicValue), this.originalAtomicValueString);
						return;
					}
					return;
				}
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000453E0 File Offset: 0x000435E0
		private void GetIsDefault()
		{
			if (!(this.coreReader is XsdCachingReader) && this.xmlSchemaInfo.HasDefaultValue)
			{
				this.coreReader = this.GetCachingReader();
				if (this.xmlSchemaInfo.IsUnionType && !this.xmlSchemaInfo.IsNil)
				{
					this.ReadAheadForMemberType();
				}
				else if (this.coreReader.Read())
				{
					switch (this.coreReader.NodeType)
					{
					case XmlNodeType.Text:
					case XmlNodeType.CDATA:
						this.validator.ValidateText(new XmlValueGetter(this.GetStringValue));
						break;
					case XmlNodeType.Whitespace:
					case XmlNodeType.SignificantWhitespace:
						this.validator.ValidateWhitespace(new XmlValueGetter(this.GetStringValue));
						break;
					case XmlNodeType.EndElement:
						this.atomicValue = this.validator.ValidateEndElement(this.xmlSchemaInfo);
						this.originalAtomicValueString = this.GetOriginalAtomicValueStringOfElement();
						if (this.xmlSchemaInfo.IsDefault)
						{
							this.cachingReader.SwitchTextNodeAndEndElement(this.xmlSchemaInfo.XmlType.ValueConverter.ToString(this.atomicValue), this.originalAtomicValueString);
						}
						break;
					}
				}
				this.cachingReader.SetToReplayMode();
				this.replayCache = true;
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00045544 File Offset: 0x00043744
		private void GetMemberType()
		{
			if (this.xmlSchemaInfo.MemberType != null || this.atomicValue == this)
			{
				return;
			}
			if (!(this.coreReader is XsdCachingReader) && this.xmlSchemaInfo.IsUnionType && !this.xmlSchemaInfo.IsNil)
			{
				this.coreReader = this.GetCachingReader();
				this.ReadAheadForMemberType();
				this.cachingReader.SetToReplayMode();
				this.replayCache = true;
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000455B4 File Offset: 0x000437B4
		private XsdCachingReader GetCachingReader()
		{
			if (this.cachingReader == null)
			{
				this.cachingReader = new XsdCachingReader(this.coreReader, this.lineInfo, new CachingEventHandler(this.CachingCallBack));
			}
			else
			{
				this.cachingReader.Reset(this.coreReader);
			}
			this.lineInfo = this.cachingReader;
			return this.cachingReader;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00045611 File Offset: 0x00043811
		internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
		{
			if (this.textNode == null)
			{
				this.textNode = new ValidatingReaderNodeData(XmlNodeType.Text);
			}
			this.textNode.Depth = depth;
			this.textNode.RawValue = attributeValue;
			return this.textNode;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00045645 File Offset: 0x00043845
		internal void CachingCallBack(XsdCachingReader cachingReader)
		{
			this.coreReader = cachingReader.GetCoreReader();
			this.lineInfo = cachingReader.GetLineInfo();
			this.replayCache = false;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00045668 File Offset: 0x00043868
		private string GetOriginalAtomicValueStringOfElement()
		{
			if (!this.xmlSchemaInfo.IsDefault)
			{
				return this.validator.GetConcatenatedValue();
			}
			XmlSchemaElement schemaElement = this.xmlSchemaInfo.SchemaElement;
			if (schemaElement == null)
			{
				return string.Empty;
			}
			if (schemaElement.DefaultValue == null)
			{
				return schemaElement.FixedValue;
			}
			return schemaElement.DefaultValue;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000456B8 File Offset: 0x000438B8
		public override Task<string> GetValueAsync()
		{
			if (this.validationState < XsdValidatingReader.ValidatingReaderState.None)
			{
				return Task.FromResult<string>(this.cachedNode.RawValue);
			}
			return this.coreReader.GetValueAsync();
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000456E0 File Offset: 0x000438E0
		private Task<bool> ReadAsync_Read(Task<bool> task)
		{
			if (!task.IsSuccess())
			{
				return this._ReadAsync_Read(task);
			}
			if (task.Result)
			{
				return this.ProcessReaderEventAsync().ReturnTaskBoolWhenFinish(true);
			}
			this.validator.EndValidation();
			if (this.coreReader.EOF)
			{
				this.validationState = XsdValidatingReader.ValidatingReaderState.EOF;
			}
			return AsyncHelper.DoneTaskFalse;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00045738 File Offset: 0x00043938
		private Task<bool> _ReadAsync_Read(Task<bool> task)
		{
			XsdValidatingReader.<_ReadAsync_Read>d__193 <_ReadAsync_Read>d__;
			<_ReadAsync_Read>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<_ReadAsync_Read>d__.<>4__this = this;
			<_ReadAsync_Read>d__.task = task;
			<_ReadAsync_Read>d__.<>1__state = -1;
			<_ReadAsync_Read>d__.<>t__builder.Start<XsdValidatingReader.<_ReadAsync_Read>d__193>(ref <_ReadAsync_Read>d__);
			return <_ReadAsync_Read>d__.<>t__builder.Task;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00045783 File Offset: 0x00043983
		private Task<bool> ReadAsync_ReadAhead(Task task)
		{
			if (task.IsSuccess())
			{
				this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				return AsyncHelper.DoneTaskTrue;
			}
			return this._ReadAsync_ReadAhead(task);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000457A4 File Offset: 0x000439A4
		private Task<bool> _ReadAsync_ReadAhead(Task task)
		{
			XsdValidatingReader.<_ReadAsync_ReadAhead>d__195 <_ReadAsync_ReadAhead>d__;
			<_ReadAsync_ReadAhead>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<_ReadAsync_ReadAhead>d__.<>4__this = this;
			<_ReadAsync_ReadAhead>d__.task = task;
			<_ReadAsync_ReadAhead>d__.<>1__state = -1;
			<_ReadAsync_ReadAhead>d__.<>t__builder.Start<XsdValidatingReader.<_ReadAsync_ReadAhead>d__195>(ref <_ReadAsync_ReadAhead>d__);
			return <_ReadAsync_ReadAhead>d__.<>t__builder.Task;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000457F0 File Offset: 0x000439F0
		public override Task<bool> ReadAsync()
		{
			switch (this.validationState)
			{
			case XsdValidatingReader.ValidatingReaderState.OnReadAttributeValue:
			case XsdValidatingReader.ValidatingReaderState.OnDefaultAttribute:
			case XsdValidatingReader.ValidatingReaderState.OnAttribute:
			case XsdValidatingReader.ValidatingReaderState.ClearAttributes:
				this.ClearAttributesInfo();
				if (this.inlineSchemaParser != null)
				{
					this.validationState = XsdValidatingReader.ValidatingReaderState.ParseInlineSchema;
					goto IL_59;
				}
				this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				break;
			case XsdValidatingReader.ValidatingReaderState.None:
				goto IL_F0;
			case XsdValidatingReader.ValidatingReaderState.Init:
				this.validationState = XsdValidatingReader.ValidatingReaderState.Read;
				if (this.coreReader.ReadState == ReadState.Interactive)
				{
					return this.ProcessReaderEventAsync().ReturnTaskBoolWhenFinish(true);
				}
				break;
			case XsdValidatingReader.ValidatingReaderState.Read:
				break;
			case XsdValidatingReader.ValidatingReaderState.ParseInlineSchema:
				goto IL_59;
			case XsdValidatingReader.ValidatingReaderState.ReadAhead:
			{
				this.ClearAttributesInfo();
				Task task = this.ProcessReaderEventAsync();
				return this.ReadAsync_ReadAhead(task);
			}
			case XsdValidatingReader.ValidatingReaderState.OnReadBinaryContent:
				this.validationState = this.savedState;
				return this.readBinaryHelper.FinishAsync().CallBoolTaskFuncWhenFinish(new Func<Task<bool>>(this.ReadAsync));
			case XsdValidatingReader.ValidatingReaderState.ReaderClosed:
			case XsdValidatingReader.ValidatingReaderState.EOF:
				return AsyncHelper.DoneTaskFalse;
			default:
				goto IL_F0;
			}
			Task<bool> task2 = this.coreReader.ReadAsync();
			return this.ReadAsync_Read(task2);
			IL_59:
			return this.ProcessInlineSchemaAsync().ReturnTaskBoolWhenFinish(true);
			IL_F0:
			return AsyncHelper.DoneTaskFalse;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000458F4 File Offset: 0x00043AF4
		private Task ProcessReaderEventAsync()
		{
			if (this.replayCache)
			{
				return AsyncHelper.DoneTask;
			}
			switch (this.coreReader.NodeType)
			{
			case XmlNodeType.Element:
				return this.ProcessElementEventAsync();
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
				this.validator.ValidateText(new XmlValueGetter(this.GetStringValue));
				break;
			case XmlNodeType.EntityReference:
				throw new InvalidOperationException();
			case XmlNodeType.DocumentType:
				this.validator.SetDtdSchemaInfo(this.coreReader.DtdInfo);
				break;
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				this.validator.ValidateWhitespace(new XmlValueGetter(this.GetStringValue));
				break;
			case XmlNodeType.EndElement:
				return this.ProcessEndElementEventAsync();
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000459C4 File Offset: 0x00043BC4
		private Task ProcessElementEventAsync()
		{
			XsdValidatingReader.<ProcessElementEventAsync>d__203 <ProcessElementEventAsync>d__;
			<ProcessElementEventAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProcessElementEventAsync>d__.<>4__this = this;
			<ProcessElementEventAsync>d__.<>1__state = -1;
			<ProcessElementEventAsync>d__.<>t__builder.Start<XsdValidatingReader.<ProcessElementEventAsync>d__203>(ref <ProcessElementEventAsync>d__);
			return <ProcessElementEventAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00045A08 File Offset: 0x00043C08
		private Task ProcessEndElementEventAsync()
		{
			XsdValidatingReader.<ProcessEndElementEventAsync>d__204 <ProcessEndElementEventAsync>d__;
			<ProcessEndElementEventAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProcessEndElementEventAsync>d__.<>4__this = this;
			<ProcessEndElementEventAsync>d__.<>1__state = -1;
			<ProcessEndElementEventAsync>d__.<>t__builder.Start<XsdValidatingReader.<ProcessEndElementEventAsync>d__204>(ref <ProcessEndElementEventAsync>d__);
			return <ProcessEndElementEventAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00045A4C File Offset: 0x00043C4C
		private Task ProcessInlineSchemaAsync()
		{
			XsdValidatingReader.<ProcessInlineSchemaAsync>d__205 <ProcessInlineSchemaAsync>d__;
			<ProcessInlineSchemaAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProcessInlineSchemaAsync>d__.<>4__this = this;
			<ProcessInlineSchemaAsync>d__.<>1__state = -1;
			<ProcessInlineSchemaAsync>d__.<>t__builder.Start<XsdValidatingReader.<ProcessInlineSchemaAsync>d__205>(ref <ProcessInlineSchemaAsync>d__);
			return <ProcessInlineSchemaAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000811 RID: 2065
		private XmlReader coreReader;

		// Token: 0x04000812 RID: 2066
		private IXmlNamespaceResolver coreReaderNSResolver;

		// Token: 0x04000813 RID: 2067
		private IXmlNamespaceResolver thisNSResolver;

		// Token: 0x04000814 RID: 2068
		private XmlSchemaValidator validator;

		// Token: 0x04000815 RID: 2069
		private XmlResolver xmlResolver;

		// Token: 0x04000816 RID: 2070
		private ValidationEventHandler validationEvent;

		// Token: 0x04000817 RID: 2071
		private XsdValidatingReader.ValidatingReaderState validationState;

		// Token: 0x04000818 RID: 2072
		private XmlValueGetter valueGetter;

		// Token: 0x04000819 RID: 2073
		private XmlNamespaceManager nsManager;

		// Token: 0x0400081A RID: 2074
		private bool manageNamespaces;

		// Token: 0x0400081B RID: 2075
		private bool processInlineSchema;

		// Token: 0x0400081C RID: 2076
		private bool replayCache;

		// Token: 0x0400081D RID: 2077
		private ValidatingReaderNodeData cachedNode;

		// Token: 0x0400081E RID: 2078
		private AttributePSVIInfo attributePSVI;

		// Token: 0x0400081F RID: 2079
		private int attributeCount;

		// Token: 0x04000820 RID: 2080
		private int coreReaderAttributeCount;

		// Token: 0x04000821 RID: 2081
		private int currentAttrIndex;

		// Token: 0x04000822 RID: 2082
		private AttributePSVIInfo[] attributePSVINodes;

		// Token: 0x04000823 RID: 2083
		private ArrayList defaultAttributes;

		// Token: 0x04000824 RID: 2084
		private Parser inlineSchemaParser;

		// Token: 0x04000825 RID: 2085
		private object atomicValue;

		// Token: 0x04000826 RID: 2086
		private XmlSchemaInfo xmlSchemaInfo;

		// Token: 0x04000827 RID: 2087
		private string originalAtomicValueString;

		// Token: 0x04000828 RID: 2088
		private XmlNameTable coreReaderNameTable;

		// Token: 0x04000829 RID: 2089
		private XsdCachingReader cachingReader;

		// Token: 0x0400082A RID: 2090
		private ValidatingReaderNodeData textNode;

		// Token: 0x0400082B RID: 2091
		private string NsXmlNs;

		// Token: 0x0400082C RID: 2092
		private string NsXs;

		// Token: 0x0400082D RID: 2093
		private string NsXsi;

		// Token: 0x0400082E RID: 2094
		private string XsiType;

		// Token: 0x0400082F RID: 2095
		private string XsiNil;

		// Token: 0x04000830 RID: 2096
		private string XsdSchema;

		// Token: 0x04000831 RID: 2097
		private string XsiSchemaLocation;

		// Token: 0x04000832 RID: 2098
		private string XsiNoNamespaceSchemaLocation;

		// Token: 0x04000833 RID: 2099
		private XmlCharType xmlCharType = XmlCharType.Instance;

		// Token: 0x04000834 RID: 2100
		private IXmlLineInfo lineInfo;

		// Token: 0x04000835 RID: 2101
		private ReadContentAsBinaryHelper readBinaryHelper;

		// Token: 0x04000836 RID: 2102
		private XsdValidatingReader.ValidatingReaderState savedState;

		// Token: 0x04000837 RID: 2103
		private static volatile Type TypeOfString;

		// Token: 0x0200012D RID: 301
		private enum ValidatingReaderState
		{
			// Token: 0x04000839 RID: 2105
			None,
			// Token: 0x0400083A RID: 2106
			Init,
			// Token: 0x0400083B RID: 2107
			Read,
			// Token: 0x0400083C RID: 2108
			OnDefaultAttribute = -1,
			// Token: 0x0400083D RID: 2109
			OnReadAttributeValue = -2,
			// Token: 0x0400083E RID: 2110
			OnAttribute = 3,
			// Token: 0x0400083F RID: 2111
			ClearAttributes,
			// Token: 0x04000840 RID: 2112
			ParseInlineSchema,
			// Token: 0x04000841 RID: 2113
			ReadAhead,
			// Token: 0x04000842 RID: 2114
			OnReadBinaryContent,
			// Token: 0x04000843 RID: 2115
			ReaderClosed,
			// Token: 0x04000844 RID: 2116
			EOF,
			// Token: 0x04000845 RID: 2117
			Error
		}
	}
}
