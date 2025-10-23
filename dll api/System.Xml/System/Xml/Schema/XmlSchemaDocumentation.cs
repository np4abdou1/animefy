using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="documentation" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class specifies information to be read or used by humans within an <see langword="annotation" />.</summary>
	// Token: 0x020002E8 RID: 744
	public class XmlSchemaDocumentation : XmlSchemaObject
	{
		/// <summary>Gets or sets the Uniform Resource Identifier (URI) source of the information.</summary>
		/// <returns>A URI reference. The default is <see langword="String.Empty" />.Optional.</returns>
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00097678 File Offset: 0x00095878
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00097680 File Offset: 0x00095880
		[XmlAttribute("source", DataType = "anyURI")]
		public string Source
		{
			get
			{
				return this.source;
			}
			set
			{
				this.source = value;
			}
		}

		/// <summary>Gets or sets the <see langword="xml:lang" /> attribute. This serves as an indicator of the language used in the contents.</summary>
		/// <returns>The <see langword="xml:lang" /> attribute.Optional.</returns>
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00097689 File Offset: 0x00095889
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00097691 File Offset: 0x00095891
		[XmlAttribute("xml:lang")]
		public string Language
		{
			get
			{
				return this.language;
			}
			set
			{
				this.language = (string)XmlSchemaDocumentation.languageType.Datatype.ParseValue(value, null, null);
			}
		}

		/// <summary>Gets or sets an array of <see langword="XmlNodes" /> that represents the documentation child nodes.</summary>
		/// <returns>The array that represents the documentation child nodes.</returns>
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000976B0 File Offset: 0x000958B0
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x000976B8 File Offset: 0x000958B8
		[XmlText]
		[XmlAnyElement]
		public XmlNode[] Markup
		{
			get
			{
				return this.markup;
			}
			set
			{
				this.markup = value;
			}
		}

		// Token: 0x0400108C RID: 4236
		private string source;

		// Token: 0x0400108D RID: 4237
		private string language;

		// Token: 0x0400108E RID: 4238
		private XmlNode[] markup;

		// Token: 0x0400108F RID: 4239
		private static XmlSchemaSimpleType languageType = DatatypeImplementation.GetSimpleTypeFromXsdType(new XmlQualifiedName("language", "http://www.w3.org/2001/XMLSchema"));
	}
}
