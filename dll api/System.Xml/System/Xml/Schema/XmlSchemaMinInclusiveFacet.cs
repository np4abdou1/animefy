using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="minInclusive" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the minimum value of a simpleType element. The element value must be greater than or equal to the value of the <see langword="minInclusive" /> element.</summary>
	// Token: 0x020002F5 RID: 757
	public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaMinInclusiveFacet" /> class.</summary>
		// Token: 0x0600195C RID: 6492 RVA: 0x00097E3C File Offset: 0x0009603C
		public XmlSchemaMinInclusiveFacet()
		{
			base.FacetType = FacetType.MinInclusive;
		}
	}
}
