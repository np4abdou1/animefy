using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="selector" /> element.</summary>
	// Token: 0x02000300 RID: 768
	public class XmlSchemaXPath : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the attribute for the XPath expression.</summary>
		/// <returns>The string attribute value for the XPath expression.</returns>
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0009804A File Offset: 0x0009624A
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00098052 File Offset: 0x00096252
		[XmlAttribute("xpath")]
		[DefaultValue("")]
		public string XPath
		{
			get
			{
				return this.xpath;
			}
			set
			{
				this.xpath = value;
			}
		}

		// Token: 0x040010D5 RID: 4309
		private string xpath;
	}
}
