using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.Xml
{
	/// <summary>Specifies a set of features to support on the <see cref="T:System.Xml.XmlWriter" /> object created by the <see cref="Overload:System.Xml.XmlWriter.Create" /> method.</summary>
	// Token: 0x02000126 RID: 294
	public sealed class XmlWriterSettings
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlWriterSettings" /> class.</summary>
		// Token: 0x0600098C RID: 2444 RVA: 0x00042852 File Offset: 0x00040A52
		public XmlWriterSettings()
		{
			this.Initialize();
		}

		/// <summary>Gets or sets a value that indicates whether asynchronous <see cref="T:System.Xml.XmlWriter" /> methods can be used on a particular <see cref="T:System.Xml.XmlWriter" /> instance.</summary>
		/// <returns>
		///     <see langword="true" /> if asynchronous methods can be used; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0004286B File Offset: 0x00040A6B
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00042873 File Offset: 0x00040A73
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

		/// <summary>Gets or sets the type of text encoding to use.</summary>
		/// <returns>The text encoding to use. The default is <see langword="Encoding.UTF8" />.</returns>
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00042887 File Offset: 0x00040A87
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0004288F File Offset: 0x00040A8F
		public Encoding Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				this.CheckReadOnly("Encoding");
				this.encoding = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to omit an XML declaration.</summary>
		/// <returns>
		///     <see langword="true" /> to omit the XML declaration; otherwise, <see langword="false" />. The default is <see langword="false" />, an XML declaration is written.</returns>
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x000428A3 File Offset: 0x00040AA3
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x000428AB File Offset: 0x00040AAB
		public bool OmitXmlDeclaration
		{
			get
			{
				return this.omitXmlDecl;
			}
			set
			{
				this.CheckReadOnly("OmitXmlDeclaration");
				this.omitXmlDecl = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether to normalize line breaks in the output.</summary>
		/// <returns>One of the <see cref="T:System.Xml.NewLineHandling" /> values. The default is <see cref="F:System.Xml.NewLineHandling.Replace" />.</returns>
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x000428BF File Offset: 0x00040ABF
		public NewLineHandling NewLineHandling
		{
			get
			{
				return this.newLineHandling;
			}
		}

		/// <summary>Gets or sets the character string to use for line breaks.</summary>
		/// <returns>The character string to use for line breaks. This can be set to any string value. However, to ensure valid XML, you should specify only valid white space characters, such as space characters, tabs, carriage returns, or line feeds. The default is \r\n (carriage return, new line).</returns>
		/// <exception cref="T:System.ArgumentNullException">The value assigned to the <see cref="P:System.Xml.XmlWriterSettings.NewLineChars" /> is <see langword="null" />.</exception>
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x000428C7 File Offset: 0x00040AC7
		public string NewLineChars
		{
			get
			{
				return this.newLineChars;
			}
		}

		/// <summary>Gets or sets a value indicating whether to indent elements.</summary>
		/// <returns>
		///     <see langword="true" /> to write individual elements on new lines and indent; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000428CF File Offset: 0x00040ACF
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x000428DA File Offset: 0x00040ADA
		public bool Indent
		{
			get
			{
				return this.indent == TriState.True;
			}
			set
			{
				this.CheckReadOnly("Indent");
				this.indent = (value ? TriState.True : TriState.False);
			}
		}

		/// <summary>Gets or sets the character string to use when indenting. This setting is used when the <see cref="P:System.Xml.XmlWriterSettings.Indent" /> property is set to <see langword="true" />.</summary>
		/// <returns>The character string to use when indenting. This can be set to any string value. However, to ensure valid XML, you should specify only valid white space characters, such as space characters, tabs, carriage returns, or line feeds. The default is two spaces.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value assigned to the <see cref="P:System.Xml.XmlWriterSettings.IndentChars" /> is <see langword="null" />.</exception>
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000428F4 File Offset: 0x00040AF4
		public string IndentChars
		{
			get
			{
				return this.indentChars;
			}
		}

		/// <summary>Gets or sets a value indicating whether to write attributes on a new line.</summary>
		/// <returns>
		///     <see langword="true" /> to write attributes on individual lines; otherwise, <see langword="false" />. The default is <see langword="false" />.This setting has no effect when the <see cref="P:System.Xml.XmlWriterSettings.Indent" /> property value is <see langword="false" />.When <see cref="P:System.Xml.XmlWriterSettings.NewLineOnAttributes" /> is set to <see langword="true" />, each attribute is pre-pended with a new line and one extra level of indentation.</returns>
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000428FC File Offset: 0x00040AFC
		public bool NewLineOnAttributes
		{
			get
			{
				return this.newLineOnAttributes;
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Xml.XmlWriter" /> should also close the underlying stream or <see cref="T:System.IO.TextWriter" /> when the <see cref="M:System.Xml.XmlWriter.Close" /> method is called.</summary>
		/// <returns>
		///     <see langword="true" /> to also close the underlying stream or <see cref="T:System.IO.TextWriter" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00042904 File Offset: 0x00040B04
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0004290C File Offset: 0x00040B0C
		public bool CloseOutput
		{
			get
			{
				return this.closeOutput;
			}
			set
			{
				this.CheckReadOnly("CloseOutput");
				this.closeOutput = value;
			}
		}

		/// <summary>Gets or sets the level of conformance that the XML writer checks the XML output for.</summary>
		/// <returns>One of the enumeration values that specifies the level of conformance (document, fragment, or automatic detection). The default is <see cref="F:System.Xml.ConformanceLevel.Document" />.</returns>
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00042920 File Offset: 0x00040B20
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00042928 File Offset: 0x00040B28
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

		/// <summary>Gets or sets a value that indicates whether the XML writer should check to ensure that all characters in the document conform to the "2.2 Characters" section of the W3C XML 1.0 Recommendation.</summary>
		/// <returns>
		///     <see langword="true" /> to do character checking; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0004294B File Offset: 0x00040B4B
		public bool CheckCharacters
		{
			get
			{
				return this.checkCharacters;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.XmlWriter" /> should remove duplicate namespace declarations when writing XML content. The default behavior is for the writer to output all namespace declarations that are present in the writer's namespace resolver.</summary>
		/// <returns>The <see cref="T:System.Xml.NamespaceHandling" /> enumeration used to specify whether to remove duplicate namespace declarations in the <see cref="T:System.Xml.XmlWriter" />.</returns>
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00042953 File Offset: 0x00040B53
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0004295B File Offset: 0x00040B5B
		public NamespaceHandling NamespaceHandling
		{
			get
			{
				return this.namespaceHandling;
			}
			set
			{
				this.CheckReadOnly("NamespaceHandling");
				if (value > NamespaceHandling.OmitDuplicates)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.namespaceHandling = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.XmlWriter" /> will add closing tags to all unclosed element tags when the <see cref="M:System.Xml.XmlWriter.Close" /> method is called.</summary>
		/// <returns>
		///     <see langword="true" /> if all unclosed element tags will be closed out; otherwise, <see langword="false" />. The default value is <see langword="true" />. </returns>
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0004297E File Offset: 0x00040B7E
		public bool WriteEndDocumentOnClose
		{
			get
			{
				return this.writeEndDocumentOnClose;
			}
		}

		/// <summary>Gets the method used to serialize the <see cref="T:System.Xml.XmlWriter" /> output.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlOutputMethod" /> values. The default is <see cref="F:System.Xml.XmlOutputMethod.Xml" />.</returns>
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00042986 File Offset: 0x00040B86
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x0004298E File Offset: 0x00040B8E
		public XmlOutputMethod OutputMethod
		{
			get
			{
				return this.outputMethod;
			}
			internal set
			{
				this.outputMethod = value;
			}
		}

		/// <summary>Creates a copy of the <see cref="T:System.Xml.XmlWriterSettings" /> instance.</summary>
		/// <returns>The cloned <see cref="T:System.Xml.XmlWriterSettings" /> object.</returns>
		// Token: 0x060009A3 RID: 2467 RVA: 0x00042997 File Offset: 0x00040B97
		public XmlWriterSettings Clone()
		{
			XmlWriterSettings xmlWriterSettings = base.MemberwiseClone() as XmlWriterSettings;
			xmlWriterSettings.cdataSections = new List<XmlQualifiedName>(this.cdataSections);
			xmlWriterSettings.isReadOnly = false;
			return xmlWriterSettings;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000429BC File Offset: 0x00040BBC
		internal List<XmlQualifiedName> CDataSectionElements
		{
			get
			{
				return this.cdataSections;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.XmlWriter" /> does not escape URI attributes.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.XmlWriter" /> do not escape URI attributes; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000429C4 File Offset: 0x00040BC4
		public bool DoNotEscapeUriAttributes
		{
			get
			{
				return this.doNotEscapeUriAttributes;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000429CC File Offset: 0x00040BCC
		internal bool MergeCDataSections
		{
			get
			{
				return this.mergeCDataSections;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000429D4 File Offset: 0x00040BD4
		internal string MediaType
		{
			get
			{
				return this.mediaType;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000429DC File Offset: 0x00040BDC
		internal string DocTypeSystem
		{
			get
			{
				return this.docTypeSystem;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000429E4 File Offset: 0x00040BE4
		internal string DocTypePublic
		{
			get
			{
				return this.docTypePublic;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x000429EC File Offset: 0x00040BEC
		internal XmlStandalone Standalone
		{
			get
			{
				return this.standalone;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x000429F4 File Offset: 0x00040BF4
		internal bool AutoXmlDeclaration
		{
			get
			{
				return this.autoXmlDecl;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000429FC File Offset: 0x00040BFC
		internal TriState IndentInternal
		{
			get
			{
				return this.indent;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00042A04 File Offset: 0x00040C04
		internal bool IsQuerySpecific
		{
			get
			{
				return this.cdataSections.Count != 0 || this.docTypePublic != null || this.docTypeSystem != null || this.standalone == XmlStandalone.Yes;
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00042A30 File Offset: 0x00040C30
		internal XmlWriter CreateWriter(string outputFileName)
		{
			if (outputFileName == null)
			{
				throw new ArgumentNullException("outputFileName");
			}
			XmlWriterSettings xmlWriterSettings = this;
			if (!xmlWriterSettings.CloseOutput)
			{
				xmlWriterSettings = xmlWriterSettings.Clone();
				xmlWriterSettings.CloseOutput = true;
			}
			FileStream fileStream = null;
			XmlWriter result;
			try
			{
				fileStream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write, FileShare.Read, 4096, this.useAsync);
				result = xmlWriterSettings.CreateWriter(fileStream);
			}
			catch
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00042AA4 File Offset: 0x00040CA4
		internal XmlWriter CreateWriter(Stream output)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			XmlWriter xmlWriter;
			if (this.Encoding.WebName == "utf-8")
			{
				switch (this.OutputMethod)
				{
				case XmlOutputMethod.Xml:
					if (this.Indent)
					{
						xmlWriter = new XmlUtf8RawTextWriterIndent(output, this);
					}
					else
					{
						xmlWriter = new XmlUtf8RawTextWriter(output, this);
					}
					break;
				case XmlOutputMethod.Html:
					if (this.Indent)
					{
						xmlWriter = new HtmlUtf8RawTextWriterIndent(output, this);
					}
					else
					{
						xmlWriter = new HtmlUtf8RawTextWriter(output, this);
					}
					break;
				case XmlOutputMethod.Text:
					xmlWriter = new TextUtf8RawTextWriter(output, this);
					break;
				case XmlOutputMethod.AutoDetect:
					xmlWriter = new XmlAutoDetectWriter(output, this);
					break;
				default:
					return null;
				}
			}
			else
			{
				switch (this.OutputMethod)
				{
				case XmlOutputMethod.Xml:
					if (this.Indent)
					{
						xmlWriter = new XmlEncodedRawTextWriterIndent(output, this);
					}
					else
					{
						xmlWriter = new XmlEncodedRawTextWriter(output, this);
					}
					break;
				case XmlOutputMethod.Html:
					if (this.Indent)
					{
						xmlWriter = new HtmlEncodedRawTextWriterIndent(output, this);
					}
					else
					{
						xmlWriter = new HtmlEncodedRawTextWriter(output, this);
					}
					break;
				case XmlOutputMethod.Text:
					xmlWriter = new TextEncodedRawTextWriter(output, this);
					break;
				case XmlOutputMethod.AutoDetect:
					xmlWriter = new XmlAutoDetectWriter(output, this);
					break;
				default:
					return null;
				}
			}
			if (this.OutputMethod != XmlOutputMethod.AutoDetect && this.IsQuerySpecific)
			{
				xmlWriter = new QueryOutputWriter((XmlRawWriter)xmlWriter, this);
			}
			xmlWriter = new XmlWellFormedWriter(xmlWriter, this);
			if (this.useAsync)
			{
				xmlWriter = new XmlAsyncCheckWriter(xmlWriter);
			}
			return xmlWriter;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00042BF4 File Offset: 0x00040DF4
		internal XmlWriter CreateWriter(TextWriter output)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			XmlWriter xmlWriter;
			switch (this.OutputMethod)
			{
			case XmlOutputMethod.Xml:
				if (this.Indent)
				{
					xmlWriter = new XmlEncodedRawTextWriterIndent(output, this);
				}
				else
				{
					xmlWriter = new XmlEncodedRawTextWriter(output, this);
				}
				break;
			case XmlOutputMethod.Html:
				if (this.Indent)
				{
					xmlWriter = new HtmlEncodedRawTextWriterIndent(output, this);
				}
				else
				{
					xmlWriter = new HtmlEncodedRawTextWriter(output, this);
				}
				break;
			case XmlOutputMethod.Text:
				xmlWriter = new TextEncodedRawTextWriter(output, this);
				break;
			case XmlOutputMethod.AutoDetect:
				xmlWriter = new XmlAutoDetectWriter(output, this);
				break;
			default:
				return null;
			}
			if (this.OutputMethod != XmlOutputMethod.AutoDetect && this.IsQuerySpecific)
			{
				xmlWriter = new QueryOutputWriter((XmlRawWriter)xmlWriter, this);
			}
			xmlWriter = new XmlWellFormedWriter(xmlWriter, this);
			if (this.useAsync)
			{
				xmlWriter = new XmlAsyncCheckWriter(xmlWriter);
			}
			return xmlWriter;
		}

		// Token: 0x17000182 RID: 386
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00042CB2 File Offset: 0x00040EB2
		internal bool ReadOnly
		{
			set
			{
				this.isReadOnly = value;
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00042CBB File Offset: 0x00040EBB
		private void CheckReadOnly(string propertyName)
		{
			if (this.isReadOnly)
			{
				throw new XmlException("The '{0}' property is read only and cannot be set.", base.GetType().Name + "." + propertyName);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00042CE8 File Offset: 0x00040EE8
		private void Initialize()
		{
			this.encoding = Encoding.UTF8;
			this.omitXmlDecl = false;
			this.newLineHandling = NewLineHandling.Replace;
			this.newLineChars = Environment.NewLine;
			this.indent = TriState.Unknown;
			this.indentChars = "  ";
			this.newLineOnAttributes = false;
			this.closeOutput = false;
			this.namespaceHandling = NamespaceHandling.Default;
			this.conformanceLevel = ConformanceLevel.Document;
			this.checkCharacters = true;
			this.writeEndDocumentOnClose = true;
			this.outputMethod = XmlOutputMethod.Xml;
			this.cdataSections.Clear();
			this.mergeCDataSections = false;
			this.mediaType = null;
			this.docTypeSystem = null;
			this.docTypePublic = null;
			this.standalone = XmlStandalone.Omit;
			this.doNotEscapeUriAttributes = false;
			this.useAsync = false;
			this.isReadOnly = false;
		}

		// Token: 0x040007D9 RID: 2009
		private bool useAsync;

		// Token: 0x040007DA RID: 2010
		private Encoding encoding;

		// Token: 0x040007DB RID: 2011
		private bool omitXmlDecl;

		// Token: 0x040007DC RID: 2012
		private NewLineHandling newLineHandling;

		// Token: 0x040007DD RID: 2013
		private string newLineChars;

		// Token: 0x040007DE RID: 2014
		private TriState indent;

		// Token: 0x040007DF RID: 2015
		private string indentChars;

		// Token: 0x040007E0 RID: 2016
		private bool newLineOnAttributes;

		// Token: 0x040007E1 RID: 2017
		private bool closeOutput;

		// Token: 0x040007E2 RID: 2018
		private NamespaceHandling namespaceHandling;

		// Token: 0x040007E3 RID: 2019
		private ConformanceLevel conformanceLevel;

		// Token: 0x040007E4 RID: 2020
		private bool checkCharacters;

		// Token: 0x040007E5 RID: 2021
		private bool writeEndDocumentOnClose;

		// Token: 0x040007E6 RID: 2022
		private XmlOutputMethod outputMethod;

		// Token: 0x040007E7 RID: 2023
		private List<XmlQualifiedName> cdataSections = new List<XmlQualifiedName>();

		// Token: 0x040007E8 RID: 2024
		private bool doNotEscapeUriAttributes;

		// Token: 0x040007E9 RID: 2025
		private bool mergeCDataSections;

		// Token: 0x040007EA RID: 2026
		private string mediaType;

		// Token: 0x040007EB RID: 2027
		private string docTypeSystem;

		// Token: 0x040007EC RID: 2028
		private string docTypePublic;

		// Token: 0x040007ED RID: 2029
		private XmlStandalone standalone;

		// Token: 0x040007EE RID: 2030
		private bool autoXmlDecl;

		// Token: 0x040007EF RID: 2031
		private bool isReadOnly;
	}
}
