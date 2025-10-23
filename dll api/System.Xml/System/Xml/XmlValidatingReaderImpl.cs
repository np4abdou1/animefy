using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x020000F4 RID: 244
	internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x00039908 File Offset: 0x00037B08
		internal XmlValidatingReaderImpl(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints)
		{
			XmlAsyncCheckReader xmlAsyncCheckReader = reader as XmlAsyncCheckReader;
			if (xmlAsyncCheckReader != null)
			{
				reader = xmlAsyncCheckReader.CoreReader;
			}
			this.outerReader = this;
			this.coreReader = reader;
			this.coreReaderImpl = (reader as XmlTextReaderImpl);
			if (this.coreReaderImpl == null)
			{
				XmlTextReader xmlTextReader = reader as XmlTextReader;
				if (xmlTextReader != null)
				{
					this.coreReaderImpl = xmlTextReader.Impl;
				}
			}
			if (this.coreReaderImpl == null)
			{
				throw new ArgumentException(Res.GetString("The XmlReader passed in to construct this XmlValidatingReaderImpl must be an instance of a System.Xml.XmlTextReader."), "reader");
			}
			this.coreReaderImpl.XmlValidatingReaderCompatibilityMode = true;
			this.coreReaderNSResolver = (reader as IXmlNamespaceResolver);
			this.processIdentityConstraints = processIdentityConstraints;
			this.schemaCollection = new XmlSchemaCollection(this.coreReader.NameTable);
			this.schemaCollection.XmlResolver = this.GetResolver();
			this.eventHandling = new XmlValidatingReaderImpl.ValidationEventHandling(this);
			if (settingsEventHandler != null)
			{
				this.eventHandling.AddHandler(settingsEventHandler);
			}
			this.coreReaderImpl.ValidationEventHandling = this.eventHandling;
			this.coreReaderImpl.OnDefaultAttributeUse = new XmlTextReaderImpl.OnDefaultAttributeUseDelegate(this.ValidateDefaultAttributeOnUse);
			this.validationType = ValidationType.DTD;
			this.SetupValidation(ValidationType.DTD);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00039A20 File Offset: 0x00037C20
		public override XmlReaderSettings Settings
		{
			get
			{
				XmlReaderSettings xmlReaderSettings;
				if (this.coreReaderImpl.V1Compat)
				{
					xmlReaderSettings = null;
				}
				else
				{
					xmlReaderSettings = this.coreReader.Settings;
				}
				if (xmlReaderSettings != null)
				{
					xmlReaderSettings = xmlReaderSettings.Clone();
				}
				else
				{
					xmlReaderSettings = new XmlReaderSettings();
				}
				xmlReaderSettings.ValidationType = ValidationType.DTD;
				if (!this.processIdentityConstraints)
				{
					xmlReaderSettings.ValidationFlags &= ~XmlSchemaValidationFlags.ProcessIdentityConstraints;
				}
				xmlReaderSettings.ReadOnly = true;
				return xmlReaderSettings;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00039A82 File Offset: 0x00037C82
		public override XmlNodeType NodeType
		{
			get
			{
				return this.coreReader.NodeType;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00039A8F File Offset: 0x00037C8F
		public override string Name
		{
			get
			{
				return this.coreReader.Name;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00039A9C File Offset: 0x00037C9C
		public override string LocalName
		{
			get
			{
				return this.coreReader.LocalName;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00039AA9 File Offset: 0x00037CA9
		public override string NamespaceURI
		{
			get
			{
				return this.coreReader.NamespaceURI;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00039AB6 File Offset: 0x00037CB6
		public override string Prefix
		{
			get
			{
				return this.coreReader.Prefix;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00039AC3 File Offset: 0x00037CC3
		public override string Value
		{
			get
			{
				return this.coreReader.Value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00039AD0 File Offset: 0x00037CD0
		public override int Depth
		{
			get
			{
				return this.coreReader.Depth;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00039ADD File Offset: 0x00037CDD
		public override string BaseURI
		{
			get
			{
				return this.coreReader.BaseURI;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00039AEA File Offset: 0x00037CEA
		public override bool IsEmptyElement
		{
			get
			{
				return this.coreReader.IsEmptyElement;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00039AF7 File Offset: 0x00037CF7
		public override bool IsDefault
		{
			get
			{
				return this.coreReader.IsDefault;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00039B04 File Offset: 0x00037D04
		public override char QuoteChar
		{
			get
			{
				return this.coreReader.QuoteChar;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00039B11 File Offset: 0x00037D11
		public override XmlSpace XmlSpace
		{
			get
			{
				return this.coreReader.XmlSpace;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00039B1E File Offset: 0x00037D1E
		public override string XmlLang
		{
			get
			{
				return this.coreReader.XmlLang;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00039B2B File Offset: 0x00037D2B
		public override ReadState ReadState
		{
			get
			{
				if (this.parsingFunction != XmlValidatingReaderImpl.ParsingFunction.Init)
				{
					return this.coreReader.ReadState;
				}
				return ReadState.Initial;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00039B43 File Offset: 0x00037D43
		public override bool EOF
		{
			get
			{
				return this.coreReader.EOF;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00039B50 File Offset: 0x00037D50
		public override XmlNameTable NameTable
		{
			get
			{
				return this.coreReader.NameTable;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00039B5D File Offset: 0x00037D5D
		public override int AttributeCount
		{
			get
			{
				return this.coreReader.AttributeCount;
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00039B6A File Offset: 0x00037D6A
		public override string GetAttribute(string name)
		{
			return this.coreReader.GetAttribute(name);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00039B78 File Offset: 0x00037D78
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return this.coreReader.GetAttribute(localName, namespaceURI);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00039B87 File Offset: 0x00037D87
		public override string GetAttribute(int i)
		{
			return this.coreReader.GetAttribute(i);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00039B95 File Offset: 0x00037D95
		public override bool MoveToAttribute(string name)
		{
			if (!this.coreReader.MoveToAttribute(name))
			{
				return false;
			}
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
			return true;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00039BAF File Offset: 0x00037DAF
		public override void MoveToAttribute(int i)
		{
			this.coreReader.MoveToAttribute(i);
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00039BC4 File Offset: 0x00037DC4
		public override bool MoveToFirstAttribute()
		{
			if (!this.coreReader.MoveToFirstAttribute())
			{
				return false;
			}
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
			return true;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00039BDD File Offset: 0x00037DDD
		public override bool MoveToNextAttribute()
		{
			if (!this.coreReader.MoveToNextAttribute())
			{
				return false;
			}
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
			return true;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00039BF6 File Offset: 0x00037DF6
		public override bool MoveToElement()
		{
			if (!this.coreReader.MoveToElement())
			{
				return false;
			}
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
			return true;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00039C10 File Offset: 0x00037E10
		public override bool Read()
		{
			switch (this.parsingFunction)
			{
			case XmlValidatingReaderImpl.ParsingFunction.Read:
				break;
			case XmlValidatingReaderImpl.ParsingFunction.Init:
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
				if (this.coreReader.ReadState == ReadState.Interactive)
				{
					this.ProcessCoreReaderEvent();
					return true;
				}
				break;
			case XmlValidatingReaderImpl.ParsingFunction.ParseDtdFromContext:
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
				this.ParseDtdFromParserContext();
				break;
			case XmlValidatingReaderImpl.ParsingFunction.ResolveEntityInternally:
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
				this.ResolveEntityInternally();
				break;
			case XmlValidatingReaderImpl.ParsingFunction.InReadBinaryContent:
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
				this.readBinaryHelper.Finish();
				break;
			case XmlValidatingReaderImpl.ParsingFunction.ReaderClosed:
			case XmlValidatingReaderImpl.ParsingFunction.Error:
				return false;
			default:
				return false;
			}
			if (this.coreReader.Read())
			{
				this.ProcessCoreReaderEvent();
				return true;
			}
			this.validator.CompleteValidation();
			return false;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00039CBC File Offset: 0x00037EBC
		public override void Close()
		{
			this.coreReader.Close();
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.ReaderClosed;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00039CD0 File Offset: 0x00037ED0
		public override string LookupNamespace(string prefix)
		{
			return this.coreReaderImpl.LookupNamespace(prefix);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00039CDE File Offset: 0x00037EDE
		public override bool ReadAttributeValue()
		{
			if (this.parsingFunction == XmlValidatingReaderImpl.ParsingFunction.InReadBinaryContent)
			{
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
				this.readBinaryHelper.Finish();
			}
			if (!this.coreReader.ReadAttributeValue())
			{
				return false;
			}
			this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
			return true;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool CanResolveEntity
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00039D12 File Offset: 0x00037F12
		public override void ResolveEntity()
		{
			if (this.parsingFunction == XmlValidatingReaderImpl.ParsingFunction.ResolveEntityInternally)
			{
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Read;
			}
			this.coreReader.ResolveEntity();
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00039D2F File Offset: 0x00037F2F
		internal void MoveOffEntityReference()
		{
			if (this.outerReader.NodeType == XmlNodeType.EntityReference && this.parsingFunction != XmlValidatingReaderImpl.ParsingFunction.ResolveEntityInternally && !this.outerReader.Read())
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00039D65 File Offset: 0x00037F65
		public override string ReadString()
		{
			this.MoveOffEntityReference();
			return base.ReadString();
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public bool HasLineInfo()
		{
			return true;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00039D73 File Offset: 0x00037F73
		public int LineNumber
		{
			get
			{
				return ((IXmlLineInfo)this.coreReader).LineNumber;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00039D85 File Offset: 0x00037F85
		public int LinePosition
		{
			get
			{
				return ((IXmlLineInfo)this.coreReader).LinePosition;
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00039D97 File Offset: 0x00037F97
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.GetNamespacesInScope(scope);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000187A7 File Offset: 0x000169A7
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return this.LookupNamespace(prefix);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00039DA0 File Offset: 0x00037FA0
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.LookupPrefix(namespaceName);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00039DA9 File Offset: 0x00037FA9
		internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.coreReaderNSResolver.GetNamespacesInScope(scope);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00039DB7 File Offset: 0x00037FB7
		internal string LookupPrefix(string namespaceName)
		{
			return this.coreReaderNSResolver.LookupPrefix(namespaceName);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00039DC5 File Offset: 0x00037FC5
		internal ValidationType ValidationType
		{
			get
			{
				return this.validationType;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00039DCD File Offset: 0x00037FCD
		internal XmlSchemaCollection Schemas
		{
			get
			{
				return this.schemaCollection;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00039DD5 File Offset: 0x00037FD5
		internal bool Namespaces
		{
			get
			{
				return this.coreReaderImpl.Namespaces;
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00039DE4 File Offset: 0x00037FE4
		private void ParseDtdFromParserContext()
		{
			if (this.parserContext.DocTypeName == null || this.parserContext.DocTypeName.Length == 0)
			{
				return;
			}
			IDtdParser dtdParser = DtdParser.Create();
			XmlTextReaderImpl.DtdParserProxy adapter = new XmlTextReaderImpl.DtdParserProxy(this.coreReaderImpl);
			IDtdInfo dtdInfo = dtdParser.ParseFreeFloatingDtd(this.parserContext.BaseURI, this.parserContext.DocTypeName, this.parserContext.PublicId, this.parserContext.SystemId, this.parserContext.InternalSubset, adapter);
			this.coreReaderImpl.SetDtdInfo(dtdInfo);
			this.ValidateDtd();
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00039E74 File Offset: 0x00038074
		private void ValidateDtd()
		{
			IDtdInfo dtdInfo = this.coreReaderImpl.DtdInfo;
			if (dtdInfo != null)
			{
				switch (this.validationType)
				{
				case ValidationType.None:
				case ValidationType.DTD:
					break;
				case ValidationType.Auto:
					this.SetupValidation(ValidationType.DTD);
					break;
				default:
					return;
				}
				this.validator.DtdInfo = dtdInfo;
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00039EC0 File Offset: 0x000380C0
		private void ResolveEntityInternally()
		{
			int depth = this.coreReader.Depth;
			this.outerReader.ResolveEntity();
			while (this.outerReader.Read() && this.coreReader.Depth > depth)
			{
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00039F00 File Offset: 0x00038100
		private void SetupValidation(ValidationType valType)
		{
			this.validator = BaseValidator.CreateInstance(valType, this, this.schemaCollection, this.eventHandling, this.processIdentityConstraints);
			XmlResolver resolver = this.GetResolver();
			this.validator.XmlResolver = resolver;
			if (this.outerReader.BaseURI.Length > 0)
			{
				this.validator.BaseUri = ((resolver == null) ? new Uri(this.outerReader.BaseURI, UriKind.RelativeOrAbsolute) : resolver.ResolveUri(null, this.outerReader.BaseURI));
			}
			this.coreReaderImpl.ValidationEventHandling = ((this.validationType == ValidationType.None) ? null : this.eventHandling);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00039FA4 File Offset: 0x000381A4
		private XmlResolver GetResolver()
		{
			XmlResolver resolver = this.coreReaderImpl.GetResolver();
			if (resolver == null && !this.coreReaderImpl.IsResolverSet && !XmlReaderSettings.EnableLegacyXmlSettings())
			{
				if (XmlValidatingReaderImpl.s_tempResolver == null)
				{
					XmlValidatingReaderImpl.s_tempResolver = new XmlUrlResolver();
				}
				return XmlValidatingReaderImpl.s_tempResolver;
			}
			return resolver;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00039FEC File Offset: 0x000381EC
		private void ProcessCoreReaderEvent()
		{
			XmlNodeType nodeType = this.coreReader.NodeType;
			if (nodeType != XmlNodeType.EntityReference)
			{
				if (nodeType == XmlNodeType.DocumentType)
				{
					this.ValidateDtd();
					return;
				}
				if (nodeType == XmlNodeType.Whitespace && (this.coreReader.Depth > 0 || this.coreReaderImpl.FragmentType != XmlNodeType.Document) && this.validator.PreserveWhitespace)
				{
					this.coreReaderImpl.ChangeCurrentNodeType(XmlNodeType.SignificantWhitespace);
				}
			}
			else
			{
				this.parsingFunction = XmlValidatingReaderImpl.ParsingFunction.ResolveEntityInternally;
			}
			this.coreReaderImpl.InternalSchemaType = null;
			this.coreReaderImpl.InternalTypedValue = null;
			this.validator.Validate();
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0003A07D File Offset: 0x0003827D
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0003A085 File Offset: 0x00038285
		internal BaseValidator Validator
		{
			get
			{
				return this.validator;
			}
			set
			{
				this.validator = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0003A08E File Offset: 0x0003828E
		internal override XmlNamespaceManager NamespaceManager
		{
			get
			{
				return this.coreReaderImpl.NamespaceManager;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0003A09B File Offset: 0x0003829B
		internal bool StandAlone
		{
			get
			{
				return this.coreReaderImpl.StandAlone;
			}
		}

		// Token: 0x1700015F RID: 351
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x0003A0A8 File Offset: 0x000382A8
		internal object SchemaTypeObject
		{
			set
			{
				this.coreReaderImpl.InternalSchemaType = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0003A0B6 File Offset: 0x000382B6
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x0003A0C3 File Offset: 0x000382C3
		internal object TypedValueObject
		{
			get
			{
				return this.coreReaderImpl.InternalTypedValue;
			}
			set
			{
				this.coreReaderImpl.InternalTypedValue = value;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0003A0D1 File Offset: 0x000382D1
		internal bool AddDefaultAttribute(SchemaAttDef attdef)
		{
			return this.coreReaderImpl.AddDefaultAttributeNonDtd(attdef);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0003A0DF File Offset: 0x000382DF
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.coreReaderImpl.DtdInfo;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0003A0EC File Offset: 0x000382EC
		internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
		{
			SchemaAttDef schemaAttDef = defaultAttribute as SchemaAttDef;
			if (schemaAttDef == null)
			{
				return;
			}
			if (!schemaAttDef.DefaultValueChecked)
			{
				SchemaInfo schemaInfo = coreReader.DtdInfo as SchemaInfo;
				if (schemaInfo == null)
				{
					return;
				}
				DtdValidator.CheckDefaultValue(schemaAttDef, schemaInfo, this.eventHandling, coreReader.BaseURI);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0003A12F File Offset: 0x0003832F
		public override Task<string> GetValueAsync()
		{
			return this.coreReader.GetValueAsync();
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0003A13C File Offset: 0x0003833C
		public override Task<bool> ReadAsync()
		{
			XmlValidatingReaderImpl.<ReadAsync>d__145 <ReadAsync>d__;
			<ReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ReadAsync>d__.<>4__this = this;
			<ReadAsync>d__.<>1__state = -1;
			<ReadAsync>d__.<>t__builder.Start<XmlValidatingReaderImpl.<ReadAsync>d__145>(ref <ReadAsync>d__);
			return <ReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0003A180 File Offset: 0x00038380
		private Task ParseDtdFromParserContextAsync()
		{
			XmlValidatingReaderImpl.<ParseDtdFromParserContextAsync>d__152 <ParseDtdFromParserContextAsync>d__;
			<ParseDtdFromParserContextAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ParseDtdFromParserContextAsync>d__.<>4__this = this;
			<ParseDtdFromParserContextAsync>d__.<>1__state = -1;
			<ParseDtdFromParserContextAsync>d__.<>t__builder.Start<XmlValidatingReaderImpl.<ParseDtdFromParserContextAsync>d__152>(ref <ParseDtdFromParserContextAsync>d__);
			return <ParseDtdFromParserContextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0003A1C4 File Offset: 0x000383C4
		private Task ResolveEntityInternallyAsync()
		{
			XmlValidatingReaderImpl.<ResolveEntityInternallyAsync>d__153 <ResolveEntityInternallyAsync>d__;
			<ResolveEntityInternallyAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ResolveEntityInternallyAsync>d__.<>4__this = this;
			<ResolveEntityInternallyAsync>d__.<>1__state = -1;
			<ResolveEntityInternallyAsync>d__.<>t__builder.Start<XmlValidatingReaderImpl.<ResolveEntityInternallyAsync>d__153>(ref <ResolveEntityInternallyAsync>d__);
			return <ResolveEntityInternallyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000683 RID: 1667
		private XmlReader coreReader;

		// Token: 0x04000684 RID: 1668
		private XmlTextReaderImpl coreReaderImpl;

		// Token: 0x04000685 RID: 1669
		private IXmlNamespaceResolver coreReaderNSResolver;

		// Token: 0x04000686 RID: 1670
		private ValidationType validationType;

		// Token: 0x04000687 RID: 1671
		private BaseValidator validator;

		// Token: 0x04000688 RID: 1672
		private XmlSchemaCollection schemaCollection;

		// Token: 0x04000689 RID: 1673
		private bool processIdentityConstraints;

		// Token: 0x0400068A RID: 1674
		private XmlValidatingReaderImpl.ParsingFunction parsingFunction = XmlValidatingReaderImpl.ParsingFunction.Init;

		// Token: 0x0400068B RID: 1675
		private XmlValidatingReaderImpl.ValidationEventHandling eventHandling;

		// Token: 0x0400068C RID: 1676
		private XmlParserContext parserContext;

		// Token: 0x0400068D RID: 1677
		private ReadContentAsBinaryHelper readBinaryHelper;

		// Token: 0x0400068E RID: 1678
		private XmlReader outerReader;

		// Token: 0x0400068F RID: 1679
		private static XmlResolver s_tempResolver;

		// Token: 0x020000F5 RID: 245
		private enum ParsingFunction
		{
			// Token: 0x04000691 RID: 1681
			Read,
			// Token: 0x04000692 RID: 1682
			Init,
			// Token: 0x04000693 RID: 1683
			ParseDtdFromContext,
			// Token: 0x04000694 RID: 1684
			ResolveEntityInternally,
			// Token: 0x04000695 RID: 1685
			InReadBinaryContent,
			// Token: 0x04000696 RID: 1686
			ReaderClosed,
			// Token: 0x04000697 RID: 1687
			Error,
			// Token: 0x04000698 RID: 1688
			None
		}

		// Token: 0x020000F6 RID: 246
		internal class ValidationEventHandling : IValidationEventHandling
		{
			// Token: 0x0600088B RID: 2187 RVA: 0x0003A207 File Offset: 0x00038407
			internal ValidationEventHandling(XmlValidatingReaderImpl reader)
			{
				this.reader = reader;
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x0003A216 File Offset: 0x00038416
			object IValidationEventHandling.EventHandler
			{
				get
				{
					return this.eventHandler;
				}
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x0003A21E File Offset: 0x0003841E
			void IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity)
			{
				if (this.eventHandler != null)
				{
					this.eventHandler(this.reader, new ValidationEventArgs((XmlSchemaException)exception, severity));
					return;
				}
				if (this.reader.ValidationType != ValidationType.None && severity == XmlSeverityType.Error)
				{
					throw exception;
				}
			}

			// Token: 0x0600088E RID: 2190 RVA: 0x0003A258 File Offset: 0x00038458
			internal void AddHandler(ValidationEventHandler handler)
			{
				this.eventHandler = (ValidationEventHandler)Delegate.Combine(this.eventHandler, handler);
			}

			// Token: 0x04000699 RID: 1689
			private XmlValidatingReaderImpl reader;

			// Token: 0x0400069A RID: 1690
			private ValidationEventHandler eventHandler;
		}
	}
}
