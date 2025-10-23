using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="pattern" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the value entered for a <see langword="simpleType" /> element.</summary>
	// Token: 0x020002F2 RID: 754
	public class XmlSchemaPatternFacet : XmlSchemaFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaPatternFacet" /> class.</summary>
		// Token: 0x06001959 RID: 6489 RVA: 0x00097E0F File Offset: 0x0009600F
		public XmlSchemaPatternFacet()
		{
			base.FacetType = FacetType.Pattern;
		}
	}
}
