using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000220 RID: 544
	[Flags]
	internal enum InternalTaskOptions
	{
		// Token: 0x040007A8 RID: 1960
		None = 0,
		// Token: 0x040007A9 RID: 1961
		InternalOptionsMask = 65280,
		// Token: 0x040007AA RID: 1962
		ContinuationTask = 512,
		// Token: 0x040007AB RID: 1963
		PromiseTask = 1024,
		// Token: 0x040007AC RID: 1964
		LazyCancellation = 4096,
		// Token: 0x040007AD RID: 1965
		QueuedByRuntime = 8192,
		// Token: 0x040007AE RID: 1966
		DoNotDispose = 16384
	}
}
