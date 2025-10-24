using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="maxLength" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to specify a restriction on the maximum length of the data value of a <see langword="simpleType" /> element. The length must be less than the value of the <see langword="maxLength" /> element.</summary>
	// Token: 0x020002F1 RID: 753
	public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaMaxLengthFacet" /> class.</summary>
		// Token: 0x06001958 RID: 6488 RVA: 0x00097E00 File Offset: 0x00096000
		public XmlSchemaMaxLengthFacet()
		{
			base.FacetType = FacetType.MaxLength;
		}
	}
}
