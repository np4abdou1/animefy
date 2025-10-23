using System;

namespace System.Xml
{
	/// <summary>Specifies how white space is handled.</summary>
	// Token: 0x02000047 RID: 71
	public enum WhitespaceHandling
	{
		/// <summary>Return <see langword="Whitespace" /> and <see langword="SignificantWhitespace" /> nodes. This is the default.</summary>
		// Token: 0x04000171 RID: 369
		All,
		/// <summary>Return <see langword="SignificantWhitespace" /> nodes only.</summary>
		// Token: 0x04000172 RID: 370
		Significant,
		/// <summary>Return no <see langword="Whitespace" /> and no <see langword="SignificantWhitespace" /> nodes.</summary>
		// Token: 0x04000173 RID: 371
		None
	}
}
