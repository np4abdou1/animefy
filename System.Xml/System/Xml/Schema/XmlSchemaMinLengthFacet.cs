using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="minLength" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the minimum length of the data value of a <see langword="simpleType" /> element. The length must be greater than the value of the <see langword="minLength" /> element.</summary>
	// Token: 0x020002F0 RID: 752
	public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaMinLengthFacet" /> class.</summary>
		// Token: 0x06001957 RID: 6487 RVA: 0x00097DF1 File Offset: 0x00095FF1
		public XmlSchemaMinLengthFacet()
		{
			base.FacetType = FacetType.MinLength;
		}
	}
}
