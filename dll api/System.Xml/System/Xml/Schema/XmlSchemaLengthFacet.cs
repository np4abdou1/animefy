using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="length" /> facet from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the length of a <see langword="simpleType" /> element on the data type.</summary>
	// Token: 0x020002EF RID: 751
	public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaLengthFacet" /> class.</summary>
		// Token: 0x06001956 RID: 6486 RVA: 0x00097DE2 File Offset: 0x00095FE2
		public XmlSchemaLengthFacet()
		{
			base.FacetType = FacetType.Length;
		}
	}
}
