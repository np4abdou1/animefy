using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the validity of an XML item validated by the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> class.</summary>
	// Token: 0x02000329 RID: 809
	public enum XmlSchemaValidity
	{
		/// <summary>The validity of the XML item is not known.</summary>
		// Token: 0x0400118B RID: 4491
		NotKnown,
		/// <summary>The XML item is valid.</summary>
		// Token: 0x0400118C RID: 4492
		Valid,
		/// <summary>The XML item is invalid.</summary>
		// Token: 0x0400118D RID: 4493
		Invalid
	}
}
