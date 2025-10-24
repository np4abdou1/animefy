﻿using System;

namespace System
{
	/// <summary>Specifies the culture, case, and sort rules to be used by certain overloads of the <see cref="M:System.String.Compare(System.String,System.String)" /> and <see cref="M:System.String.Equals(System.Object)" /> methods.</summary>
	// Token: 0x02000100 RID: 256
	public enum StringComparison
	{
		/// <summary>Compare strings using culture-sensitive sort rules and the current culture.</summary>
		// Token: 0x04000373 RID: 883
		CurrentCulture,
		/// <summary>Compare strings using culture-sensitive sort rules, the current culture, and ignoring the case of the strings being compared.</summary>
		// Token: 0x04000374 RID: 884
		CurrentCultureIgnoreCase,
		/// <summary>Compare strings using culture-sensitive sort rules and the invariant culture.</summary>
		// Token: 0x04000375 RID: 885
		InvariantCulture,
		/// <summary>Compare strings using culture-sensitive sort rules, the invariant culture, and ignoring the case of the strings being compared.</summary>
		// Token: 0x04000376 RID: 886
		InvariantCultureIgnoreCase,
		/// <summary>Compare strings using ordinal (binary) sort rules.</summary>
		// Token: 0x04000377 RID: 887
		Ordinal,
		/// <summary>Compare strings using ordinal (binary) sort rules and ignoring the case of the strings being compared.</summary>
		// Token: 0x04000378 RID: 888
		OrdinalIgnoreCase
	}
}
