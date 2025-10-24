using System;

namespace System.Xml.Linq
{
	/// <summary>Specifies load options when parsing XML. </summary>
	// Token: 0x0200002D RID: 45
	[Flags]
	public enum LoadOptions
	{
		/// <summary>Does not preserve insignificant white space or load base URI and line information.</summary>
		// Token: 0x040000BD RID: 189
		None = 0,
		/// <summary>Preserves insignificant white space while parsing.</summary>
		// Token: 0x040000BE RID: 190
		PreserveWhitespace = 1,
		/// <summary>Requests the base URI information from the <see cref="T:System.Xml.XmlReader" />, and makes it available via the <see cref="P:System.Xml.Linq.XObject.BaseUri" /> property.</summary>
		// Token: 0x040000BF RID: 191
		SetBaseUri = 2,
		/// <summary>Requests the line information from the <see cref="T:System.Xml.XmlReader" /> and makes it available via properties on <see cref="T:System.Xml.Linq.XObject" />.</summary>
		// Token: 0x040000C0 RID: 192
		SetLineInfo = 4
	}
}
