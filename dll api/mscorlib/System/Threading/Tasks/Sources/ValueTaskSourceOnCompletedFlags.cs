using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x0200023E RID: 574
	[Flags]
	public enum ValueTaskSourceOnCompletedFlags
	{
		// Token: 0x040007FB RID: 2043
		None = 0,
		// Token: 0x040007FC RID: 2044
		UseSchedulingContext = 1,
		// Token: 0x040007FD RID: 2045
		FlowExecutionContext = 2
	}
}
