using System;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001E4 RID: 484
	internal static class ThreadPoolGlobals
	{
		// Token: 0x040006CD RID: 1741
		public static int processorCount = Environment.ProcessorCount;

		// Token: 0x040006CE RID: 1742
		public static volatile bool vmTpInitialized;

		// Token: 0x040006CF RID: 1743
		public static bool enableWorkerTracking;

		// Token: 0x040006D0 RID: 1744
		[SecurityCritical]
		public static readonly ThreadPoolWorkQueue workQueue = new ThreadPoolWorkQueue();
	}
}
