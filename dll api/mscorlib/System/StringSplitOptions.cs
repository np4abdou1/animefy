using System;

namespace System
{
	/// <summary>Specifies whether applicable <see cref="Overload:System.String.Split" /> method overloads include or omit empty substrings from the return value.</summary>
	// Token: 0x02000101 RID: 257
	[Flags]
	public enum StringSplitOptions
	{
		/// <summary>The return value includes array elements that contain an empty string</summary>
		// Token: 0x0400037A RID: 890
		None = 0,
		/// <summary>The return value does not include array elements that contain an empty string</summary>
		// Token: 0x0400037B RID: 891
		RemoveEmptyEntries = 1
	}
}
