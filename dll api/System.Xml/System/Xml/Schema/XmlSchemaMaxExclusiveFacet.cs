using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="maxExclusive" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the maximum value of a <see langword="simpleType" /> element. The element value must be less than the value of the <see langword="maxExclusive" /> element.</summary>
	// Token: 0x020002F6 RID: 758
	public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaMaxExclusiveFacet" /> class.</summary>
		// Token: 0x0600195D RID: 6493 RVA: 0x00097E4B File Offset: 0x0009604B
		public XmlSchemaMaxExclusiveFacet()
		{
			base.FacetType = FacetType.MaxExclusive;
		}
	}
}
