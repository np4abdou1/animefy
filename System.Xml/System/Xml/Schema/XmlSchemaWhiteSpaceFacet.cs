using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="whiteSpace" /> facet.</summary>
	// Token: 0x020002FA RID: 762
	public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaWhiteSpaceFacet" /> class.</summary>
		// Token: 0x06001961 RID: 6497 RVA: 0x00097E8B File Offset: 0x0009608B
		public XmlSchemaWhiteSpaceFacet()
		{
			base.FacetType = FacetType.Whitespace;
		}
	}
}
