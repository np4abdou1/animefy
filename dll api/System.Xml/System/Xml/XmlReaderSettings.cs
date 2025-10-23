using System;
using System.IO;
using System.Xml.Schema;
using System.Xml.XmlConfiguration;

namespace System.Xml
{
	/// <summary>Specifies a set of features to support on the <see cref="T:System.Xml.XmlReader" /> object created by the <see cref="Overload:System.Xml.XmlReader.Create" /> method. </summary>
	// Token: 0x02000077 RID: 119
	public sealed class XmlReaderSettings
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlReaderSettings" /> class.</summary>
		// Token: 0x0600045B RID: 1115 RVA: 0x00015B96 File Offset: 0x00013D96
		public XmlReaderSettings()
		{
			this.Initialize();
		}

		/// <summary>Gets or sets whether asynchronous <see cref="T:System.Xml.XmlReader" /> methods can be used on a particular <see cref="T:System.Xml.XmlReader" /> instance.</summary>
		/// <returns>
		///     <see langword="true" /> if asynchronous methods can be used; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00015BA4 File Offset: 0x00013DA4
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00015BAC File Offset: 0x00013DAC
		public bool Async
		{
			get
			{
				return this.useAsync;
			}
			set
			{
				this.CheckReadOnly("Async");
				this.useAsync = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.XmlNameTable" /> used for atomized string comparisons.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNameTable" /> that stores all the atomized strings used by all <see cref="T:System.Xml.XmlReader" /> instances created using this <see cref="T:System.Xml.XmlReaderSettings" /> object.The default is <see langword="null" />. The created <see cref="T:System.Xml.XmlReader" /> instance will use a new empty <see cref="T:System.Xml.NameTable" /> if this value is <see langword="null" />.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00015BC0 File Offset: 0x00013DC0
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00015BC8 File Offset: 0x00013DC8
		public XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
			set
			{
				this.CheckReadOnly("NameTable");
				this.nameTable = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00015BDC File Offset: 0x00013DDC
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00015BE4 File Offset: 0x00013DE4
		internal bool IsXmlResolverSet { get; set; }

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> used to access external documents.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlResolver" /> used to access external documents. If set to <see langword="null" />, an <see cref="T:System.Xml.XmlException" /> is thrown when the <see cref="T:System.Xml.XmlReader" /> tries to access an external resource. The default is a new <see cref="T:System.Xml.XmlUrlResolver" /> with no credentials.  Starting with the .NET Framework 4.5.2, this setting has a default value of <see langword="null" />.</returns>
		// Token: 0x170000AA RID: 170
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00015BED File Offset: 0x00013DED
		public XmlResolver XmlResolver
		{
			set
			{
				this.CheckReadOnly("XmlResolver");
				this.xmlResolver = value;
				this.IsXmlResolverSet = true;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00015C08 File Offset: 0x00013E08
		internal XmlResolver GetXmlResolver()
		{
			return this.xmlResolver;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00015C10 File Offset: 0x00013E10
		internal XmlResolver GetXmlResolver_CheckConfig()
		{
			if (XmlReaderSection.ProhibitDefaultUrlResolver && !this.IsXmlResolverSet)
			{
				return null;
			}
			return this.xmlResolver;
		}

		/// <summary>Gets or sets line number offset of the <see cref="T:System.Xml.XmlReader" /> object.</summary>
		/// <returns>The line number offset. The default is 0.</returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00015C29 File Offset: 0x00013E29
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00015C31 File Offset: 0x00013E31
		public int LineNumberOffset
		{
			get
			{
				return this.lineNumberOffset;
			}
			set
			{
				this.CheckReadOnly("LineNumberOffset");
				this.lineNumberOffset = value;
			}
		}

		/// <summary>Gets or sets line position offset of the <see cref="T:System.Xml.XmlReader" /> object.</summary>
		/// <returns>The line position offset. The default is 0.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00015C45 File Offset: 0x00013E45
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00015C4D File Offset: 0x00013E4D
		public int LinePositionOffset
		{
			get
			{
				return this.linePositionOffset;
			}
			set
			{
				this.CheckReadOnly("LinePositionOffset");
				this.linePositionOffset = value;
			}
		}

		/// <summary>Gets or sets the level of conformance which the <see cref="T:System.Xml.XmlReader" /> will comply.</summary>
		/// <returns>One of the enumeration values that specifies the level of conformance that the XML reader will enforce. The default is <see cref="F:System.Xml.ConformanceLevel.Document" />.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00015C61 File Offset: 0x00013E61
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00015C69 File Offset: 0x00013E69
		public ConformanceLevel ConformanceLevel
		{
			get
			{
				return this.conformanceLevel;
			}
			set
			{
				this.CheckReadOnly("ConformanceLevel");
				if (value > ConformanceLevel.Document)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.conformanceLevel = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to do character checking.</summary>
		/// <returns>
		///     <see langword="true" /> to do character checking; otherwise <see langword="false" />. The default is <see langword="true" />.If the <see cref="T:System.Xml.XmlReader" /> is processing text data, it always checks that the XML names and text content are valid, regardless of the property setting. Setting <see cref="P:System.Xml.XmlReaderSettings.CheckCharacters" /> to <see langword="false" /> turns off character checking for character entity references.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00015C8C File Offset: 0x00013E8C
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00015C94 File Offset: 0x00013E94
		public bool CheckCharacters
		{
			get
			{
				return this.checkCharacters;
			}
			set
			{
				this.CheckReadOnly("CheckCharacters");
				this.checkCharacters = value;
			}
		}

		/// <summary>Gets or sets a value indicating the maximum allowable number of characters in an XML document. A zero (0) value means no limits on the size of the XML document. A non-zero value specifies the maximum size, in characters.</summary>
		/// <returns>The maximum allowable number of characters in an XML document. The default is 0.</returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00015CA8 File Offset: 0x00013EA8
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00015CB0 File Offset: 0x00013EB0
		public long MaxCharactersInDocument
		{
			get
			{
				return this.maxCharactersInDocument;
			}
			set
			{
				this.CheckReadOnly("MaxCharactersInDocument");
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.maxCharactersInDocument = value;
			}
		}

		/// <summary>Gets or sets a value indicating the maximum allowable number of characters in a document that result from expanding entities.</summary>
		/// <returns>The maximum allowable number of characters from expanded entities. The default is 0.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00015CD4 File Offset: 0x00013ED4
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00015CDC File Offset: 0x00013EDC
		public long MaxCharactersFromEntities
		{
			get
			{
				return this.maxCharactersFromEntities;
			}
			set
			{
				this.CheckReadOnly("MaxCharactersFromEntities");
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.maxCharactersFromEntities = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to ignore insignificant white space.</summary>
		/// <returns>
		///     <see langword="true" /> to ignore white space; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00015D00 File Offset: 0x00013F00
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00015D08 File Offset: 0x00013F08
		public bool IgnoreWhitespace
		{
			get
			{
				return this.ignoreWhitespace;
			}
			set
			{
				this.CheckReadOnly("IgnoreWhitespace");
				this.ignoreWhitespace = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to ignore processing instructions.</summary>
		/// <returns>
		///     <see langword="true" /> to ignore processing instructions; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00015D1C File Offset: 0x00013F1C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00015D24 File Offset: 0x00013F24
		public bool IgnoreProcessingInstructions
		{
			get
			{
				return this.ignorePIs;
			}
			set
			{
				this.CheckReadOnly("IgnoreProcessingInstructions");
				this.ignorePIs = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to ignore comments.</summary>
		/// <returns>
		///     <see langword="true" /> to ignore comments; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00015D38 File Offset: 0x00013F38
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00015D40 File Offset: 0x00013F40
		public bool IgnoreComments
		{
			get
			{
				return this.ignoreComments;
			}
			set
			{
				this.CheckReadOnly("IgnoreComments");
				this.ignoreComments = value;
			}
		}

		/// <summary>Gets or sets a value that determines the processing of DTDs.</summary>
		/// <returns>One of the enumeration values that determines the processing of DTDs. The default is <see cref="F:System.Xml.DtdProcessing.Prohibit" />.</returns>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00015D54 File Offset: 0x00013F54
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00015D5C File Offset: 0x00013F5C
		public DtdProcessing DtdProcessing
		{
			get
			{
				return this.dtdProcessing;
			}
			set
			{
				this.CheckReadOnly("DtdProcessing");
				if (value > DtdProcessing.Parse)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.dtdProcessing = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the underlying stream or <see cref="T:System.IO.TextReader" /> should be closed when the reader is closed.</summary>
		/// <returns>
		///     <see langword="true" /> to close the underlying stream or <see cref="T:System.IO.TextReader" /> when the reader is closed; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00015D7F File Offset: 0x00013F7F
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00015D87 File Offset: 0x00013F87
		public bool CloseInput
		{
			get
			{
				return this.closeInput;
			}
			set
			{
				this.CheckReadOnly("CloseInput");
				this.closeInput = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Xml.XmlReader" /> will perform validation or type assignment when reading.</summary>
		/// <returns>One of the <see cref="T:System.Xml.ValidationType" /> values that indicates whether XmlReader will perform validation or type assignment when reading. The default is <see langword="ValidationType.None" />.</returns>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00015D9B File Offset: 0x00013F9B
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00015DA3 File Offset: 0x00013FA3
		public ValidationType ValidationType
		{
			get
			{
				return this.validationType;
			}
			set
			{
				this.CheckReadOnly("ValidationType");
				if (value > ValidationType.Schema)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.validationType = value;
			}
		}

		/// <summary>Gets or sets a value indicating the schema validation settings. This setting applies to <see cref="T:System.Xml.XmlReader" /> objects that validate schemas (<see cref="P:System.Xml.XmlReaderSettings.ValidationType" /> property set to <see langword="ValidationType.Schema" />).</summary>
		/// <returns>A bitwise combination of enumeration values that specify validation options. <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ProcessIdentityConstraints" /> and <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.AllowXmlAttributes" /> are enabled by default. <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ProcessInlineSchema" />, <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ProcessSchemaLocation" />, and <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings" /> are disabled by default.</returns>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00015DC6 File Offset: 0x00013FC6
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00015DCE File Offset: 0x00013FCE
		public XmlSchemaValidationFlags ValidationFlags
		{
			get
			{
				return this.validationFlags;
			}
			set
			{
				this.CheckReadOnly("ValidationFlags");
				if (value > (XmlSchemaValidationFlags.ProcessInlineSchema | XmlSchemaValidationFlags.ProcessSchemaLocation | XmlSchemaValidationFlags.ReportValidationWarnings | XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.AllowXmlAttributes))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.validationFlags = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to use when performing schema validation.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to use when performing schema validation. The default is an empty <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object.</returns>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00015DF2 File Offset: 0x00013FF2
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00015E0D File Offset: 0x0001400D
		public XmlSchemaSet Schemas
		{
			get
			{
				if (this.schemas == null)
				{
					this.schemas = new XmlSchemaSet();
				}
				return this.schemas;
			}
			set
			{
				this.CheckReadOnly("Schemas");
				this.schemas = value;
			}
		}

		/// <summary>Creates a copy of the <see cref="T:System.Xml.XmlReaderSettings" /> instance.</summary>
		/// <returns>The cloned <see cref="T:System.Xml.XmlReaderSettings" /> object.</returns>
		// Token: 0x06000481 RID: 1153 RVA: 0x00015E21 File Offset: 0x00014021
		public XmlReaderSettings Clone()
		{
			XmlReaderSettings xmlReaderSettings = base.MemberwiseClone() as XmlReaderSettings;
			xmlReaderSettings.ReadOnly = false;
			return xmlReaderSettings;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00015E35 File Offset: 0x00014035
		internal ValidationEventHandler GetEventHandler()
		{
			return this.valEventHandler;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00015E40 File Offset: 0x00014040
		internal XmlReader CreateReader(string inputUri, XmlParserContext inputContext)
		{
			if (inputUri == null)
			{
				throw new ArgumentNullException("inputUri");
			}
			if (inputUri.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The string was not recognized as a valid Uri."), "inputUri");
			}
			XmlResolver xmlResolver = this.GetXmlResolver();
			if (xmlResolver == null)
			{
				xmlResolver = XmlReaderSettings.CreateDefaultResolver();
			}
			XmlReader xmlReader = new XmlTextReaderImpl(inputUri, this, inputContext, xmlResolver);
			if (this.ValidationType != ValidationType.None)
			{
				xmlReader = this.AddValidation(xmlReader);
			}
			if (this.useAsync)
			{
				xmlReader = XmlAsyncCheckReader.CreateAsyncCheckWrapper(xmlReader);
			}
			return xmlReader;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00015EB4 File Offset: 0x000140B4
		internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (baseUriString == null)
			{
				if (baseUri == null)
				{
					baseUriString = string.Empty;
				}
				else
				{
					baseUriString = baseUri.ToString();
				}
			}
			XmlReader xmlReader = new XmlTextReaderImpl(input, null, 0, this, baseUri, baseUriString, inputContext, this.closeInput);
			if (this.ValidationType != ValidationType.None)
			{
				xmlReader = this.AddValidation(xmlReader);
			}
			if (this.useAsync)
			{
				xmlReader = XmlAsyncCheckReader.CreateAsyncCheckWrapper(xmlReader);
			}
			return xmlReader;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00015F20 File Offset: 0x00014120
		internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (baseUriString == null)
			{
				baseUriString = string.Empty;
			}
			XmlReader xmlReader = new XmlTextReaderImpl(input, this, baseUriString, inputContext);
			if (this.ValidationType != ValidationType.None)
			{
				xmlReader = this.AddValidation(xmlReader);
			}
			if (this.useAsync)
			{
				xmlReader = XmlAsyncCheckReader.CreateAsyncCheckWrapper(xmlReader);
			}
			return xmlReader;
		}

		// Token: 0x170000B9 RID: 185
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00015F6F File Offset: 0x0001416F
		internal bool ReadOnly
		{
			set
			{
				this.isReadOnly = value;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00015F78 File Offset: 0x00014178
		private void CheckReadOnly(string propertyName)
		{
			if (this.isReadOnly)
			{
				throw new XmlException("The '{0}' property is read only and cannot be set.", base.GetType().Name + "." + propertyName);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00015FA3 File Offset: 0x000141A3
		private void Initialize()
		{
			this.Initialize(null);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00015FAC File Offset: 0x000141AC
		private void Initialize(XmlResolver resolver)
		{
			this.nameTable = null;
			this.xmlResolver = ((resolver == null) ? XmlReaderSettings.CreateDefaultResolver() : resolver);
			this.maxCharactersFromEntities = 0L;
			this.lineNumberOffset = 0;
			this.linePositionOffset = 0;
			this.checkCharacters = true;
			this.conformanceLevel = ConformanceLevel.Document;
			this.ignoreWhitespace = false;
			this.ignorePIs = false;
			this.ignoreComments = false;
			this.dtdProcessing = DtdProcessing.Prohibit;
			this.closeInput = false;
			this.maxCharactersInDocument = 0L;
			this.schemas = null;
			this.validationType = ValidationType.None;
			this.validationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints;
			this.validationFlags |= XmlSchemaValidationFlags.AllowXmlAttributes;
			this.useAsync = false;
			this.isReadOnly = false;
			this.IsXmlResolverSet = false;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00016059 File Offset: 0x00014259
		private static XmlResolver CreateDefaultResolver()
		{
			return new XmlUrlResolver();
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00016060 File Offset: 0x00014260
		internal XmlReader AddValidation(XmlReader reader)
		{
			if (this.validationType == ValidationType.Schema)
			{
				XmlResolver xmlResolver = this.GetXmlResolver_CheckConfig();
				if (xmlResolver == null && !this.IsXmlResolverSet && !XmlReaderSettings.EnableLegacyXmlSettings())
				{
					xmlResolver = new XmlUrlResolver();
				}
				reader = new XsdValidatingReader(reader, xmlResolver, this);
			}
			else if (this.validationType == ValidationType.DTD)
			{
				reader = this.CreateDtdValidatingReader(reader);
			}
			return reader;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000160B4 File Offset: 0x000142B4
		private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader)
		{
			return new XmlValidatingReaderImpl(baseReader, this.GetEventHandler(), (this.ValidationFlags & XmlSchemaValidationFlags.ProcessIdentityConstraints) > XmlSchemaValidationFlags.None);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000160D0 File Offset: 0x000142D0
		internal static bool EnableLegacyXmlSettings()
		{
			if (XmlReaderSettings.s_enableLegacyXmlSettings != null)
			{
				return XmlReaderSettings.s_enableLegacyXmlSettings.Value;
			}
			if (!BinaryCompatibility.TargetsAtLeast_Desktop_V4_5_2)
			{
				XmlReaderSettings.s_enableLegacyXmlSettings = new bool?(true);
				return XmlReaderSettings.s_enableLegacyXmlSettings.Value;
			}
			XmlReaderSettings.s_enableLegacyXmlSettings = new bool?(false);
			return XmlReaderSettings.s_enableLegacyXmlSettings.Value;
		}

		// Token: 0x040002BA RID: 698
		private bool useAsync;

		// Token: 0x040002BB RID: 699
		private XmlNameTable nameTable;

		// Token: 0x040002BC RID: 700
		private XmlResolver xmlResolver;

		// Token: 0x040002BD RID: 701
		private int lineNumberOffset;

		// Token: 0x040002BE RID: 702
		private int linePositionOffset;

		// Token: 0x040002BF RID: 703
		private ConformanceLevel conformanceLevel;

		// Token: 0x040002C0 RID: 704
		private bool checkCharacters;

		// Token: 0x040002C1 RID: 705
		private long maxCharactersInDocument;

		// Token: 0x040002C2 RID: 706
		private long maxCharactersFromEntities;

		// Token: 0x040002C3 RID: 707
		private bool ignoreWhitespace;

		// Token: 0x040002C4 RID: 708
		private bool ignorePIs;

		// Token: 0x040002C5 RID: 709
		private bool ignoreComments;

		// Token: 0x040002C6 RID: 710
		private DtdProcessing dtdProcessing;

		// Token: 0x040002C7 RID: 711
		private ValidationType validationType;

		// Token: 0x040002C8 RID: 712
		private XmlSchemaValidationFlags validationFlags;

		// Token: 0x040002C9 RID: 713
		private XmlSchemaSet schemas;

		// Token: 0x040002CA RID: 714
		private ValidationEventHandler valEventHandler;

		// Token: 0x040002CB RID: 715
		private bool closeInput;

		// Token: 0x040002CC RID: 716
		private bool isReadOnly;

		// Token: 0x040002CE RID: 718
		private static bool? s_enableLegacyXmlSettings;
	}
}
