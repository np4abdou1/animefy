using System;

namespace System.Data
{
	// Token: 0x02000004 RID: 4
	internal enum AggregateType
	{
		// Token: 0x04000005 RID: 5
		None,
		// Token: 0x04000006 RID: 6
		Sum = 4,
		// Token: 0x04000007 RID: 7
		Mean,
		// Token: 0x04000008 RID: 8
		Min,
		// Token: 0x04000009 RID: 9
		Max,
		// Token: 0x0400000A RID: 10
		First,
		// Token: 0x0400000B RID: 11
		Count,
		// Token: 0x0400000C RID: 12
		Var,
		// Token: 0x0400000D RID: 13
		StDev
	}
}
