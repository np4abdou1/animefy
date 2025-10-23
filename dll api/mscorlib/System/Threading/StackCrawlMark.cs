using System;

namespace System.Threading
{
	// Token: 0x020001DE RID: 478
	[Serializable]
	internal enum StackCrawlMark
	{
		// Token: 0x040006C9 RID: 1737
		LookForMe,
		// Token: 0x040006CA RID: 1738
		LookForMyCaller,
		// Token: 0x040006CB RID: 1739
		LookForMyCallersCaller,
		// Token: 0x040006CC RID: 1740
		LookForThread
	}
}
