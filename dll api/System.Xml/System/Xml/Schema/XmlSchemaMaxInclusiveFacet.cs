using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="maxInclusive" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the maximum value of a <see langword="simpleType" /> element. The element value must be less than or equal to the value of the <see langword="maxInclusive" /> element.</summary>
	// Token: 0x020002F7 RID: 759
	public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaMaxInclusiveFacet" /> class.</summary>
		// Token: 0x0600195E RID: 6494 RVA: 0x00097E5B File Offset: 0x0009605B
		public XmlSchemaMaxInclusiveFacet()
		{
			base.FacetType = FacetType.MaxInclusive;
		}
	}
}
