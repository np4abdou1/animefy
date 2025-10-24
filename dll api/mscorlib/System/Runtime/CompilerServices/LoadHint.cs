using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Specifies the preferred default binding for a dependent assembly.</summary>
	// Token: 0x0200046B RID: 1131
	[Serializable]
	public enum LoadHint
	{
		/// <summary>No preference specified.</summary>
		// Token: 0x04000F72 RID: 3954
		Default,
		/// <summary>The dependency is always loaded.</summary>
		// Token: 0x04000F73 RID: 3955
		Always,
		/// <summary>The dependency is sometimes loaded.</summary>
		// Token: 0x04000F74 RID: 3956
		Sometimes
	}
}
