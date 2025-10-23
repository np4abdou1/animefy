using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="enumeration" /> facet from XML Schema as specified by the World Wide Web Consortium (W3C). This class specifies a list of valid values for a simpleType element. Declaration is contained within a <see langword="restriction" /> declaration.</summary>
	// Token: 0x020002F3 RID: 755
	public class XmlSchemaEnumerationFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaEnumerationFacet" /> class.</summary>
		// Token: 0x0600195A RID: 6490 RVA: 0x00097E1E File Offset: 0x0009601E
		public XmlSchemaEnumerationFacet()
		{
			base.FacetType = FacetType.Enumeration;
		}
	}
}
