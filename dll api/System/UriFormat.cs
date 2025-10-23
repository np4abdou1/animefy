using System;

namespace System
{
	/// <summary>Controls how URI information is escaped.</summary>
	// Token: 0x02000081 RID: 129
	public enum UriFormat
	{
		/// <summary>Escaping is performed according to the rules in RFC 2396.</summary>
		// Token: 0x0400021E RID: 542
		UriEscaped = 1,
		/// <summary>No escaping is performed.</summary>
		// Token: 0x0400021F RID: 543
		Unescaped,
		/// <summary>Characters that have a reserved meaning in the requested URI components remain escaped. All others are not escaped. See Remarks.</summary>
		// Token: 0x04000220 RID: 544
		SafeUnescaped
	}
}
