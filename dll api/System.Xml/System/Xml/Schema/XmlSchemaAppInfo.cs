using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="appinfo" /> element.</summary>
	// Token: 0x020002D5 RID: 725
	public class XmlSchemaAppInfo : XmlSchemaObject
	{
		/// <summary>Gets or sets the source of the application information.</summary>
		/// <returns>A Uniform Resource Identifier (URI) reference. The default is <see langword="String.Empty" />.Optional.</returns>
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00096199 File Offset: 0x00094399
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x000961A1 File Offset: 0x000943A1
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

		/// <summary>Gets or sets an array of <see cref="T:System.Xml.XmlNode" /> objects that represents the <see langword="appinfo" /> child nodes.</summary>
		/// <returns>An array of <see cref="T:System.Xml.XmlNode" /> objects that represents the <see langword="appinfo" /> child nodes.</returns>
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x000961AA File Offset: 0x000943AA
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x000961B2 File Offset: 0x000943B2
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

		// Token: 0x0400103C RID: 4156
		private string source;

		// Token: 0x0400103D RID: 4157
		private XmlNode[] markup;
	}
}
