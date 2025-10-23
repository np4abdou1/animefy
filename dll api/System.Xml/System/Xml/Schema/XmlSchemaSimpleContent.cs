using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="simpleContent" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is for simple and complex types with simple content model.</summary>
	// Token: 0x02000317 RID: 791
	public class XmlSchemaSimpleContent : XmlSchemaContentModel
	{
		/// <summary>Gets one of the <see cref="T:System.Xml.Schema.XmlSchemaSimpleContentRestriction" /> or <see cref="T:System.Xml.Schema.XmlSchemaSimpleContentExtension" />.</summary>
		/// <returns>The content contained within the <see langword="XmlSchemaSimpleContentRestriction" /> or <see langword="XmlSchemaSimpleContentExtension" /> class.</returns>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0009A9ED File Offset: 0x00098BED
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0009A9F5 File Offset: 0x00098BF5
		[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
		[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
		public override XmlSchemaContent Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		// Token: 0x0400111F RID: 4383
		private XmlSchemaContent content;
	}
}
