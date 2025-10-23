using System;

namespace System.Reflection
{
	/// <summary>Specifies the attributes for a manifest resource.</summary>
	// Token: 0x020004B7 RID: 1207
	[Flags]
	public enum ResourceAttributes
	{
		/// <summary>A mask used to retrieve public manifest resources.</summary>
		// Token: 0x0400105F RID: 4191
		Public = 1,
		/// <summary>A mask used to retrieve private manifest resources.</summary>
		// Token: 0x04001060 RID: 4192
		Private = 2
	}
}
