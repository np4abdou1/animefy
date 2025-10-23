using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="minExclusive" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the minimum value of a <see langword="simpleType" /> element. The element value must be greater than the value of the <see langword="minExclusive" /> element.</summary>
	// Token: 0x020002F4 RID: 756
	public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaMinExclusiveFacet" /> class.</summary>
		// Token: 0x0600195B RID: 6491 RVA: 0x00097E2D File Offset: 0x0009602D
		public XmlSchemaMinExclusiveFacet()
		{
			base.FacetType = FacetType.MinExclusive;
		}
	}
}
