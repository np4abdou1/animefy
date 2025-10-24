using System;

namespace System.Xml
{
	/// <summary>Specifies the method used to serialize the <see cref="T:System.Xml.XmlWriter" /> output. </summary>
	// Token: 0x02000123 RID: 291
	public enum XmlOutputMethod
	{
		/// <summary>Serialize according to the XML 1.0 rules.</summary>
		// Token: 0x040007CD RID: 1997
		Xml,
		/// <summary>Serialize according to the HTML rules specified by XSLT.</summary>
		// Token: 0x040007CE RID: 1998
		Html,
		/// <summary>Serialize text blocks only.</summary>
		// Token: 0x040007CF RID: 1999
		Text,
		/// <summary>Use the XSLT rules to choose between the <see cref="F:System.Xml.XmlOutputMethod.Xml" /> and <see cref="F:System.Xml.XmlOutputMethod.Html" /> output methods at runtime.</summary>
		// Token: 0x040007D0 RID: 2000
		AutoDetect
	}
}
