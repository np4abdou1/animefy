using System;

namespace System
{
	// Token: 0x02000084 RID: 132
	[Flags]
	internal enum UnescapeMode
	{
		// Token: 0x04000235 RID: 565
		CopyOnly = 0,
		// Token: 0x04000236 RID: 566
		Escape = 1,
		// Token: 0x04000237 RID: 567
		Unescape = 2,
		// Token: 0x04000238 RID: 568
		EscapeUnescape = 3,
		// Token: 0x04000239 RID: 569
		V1ToStringFlag = 4,
		// Token: 0x0400023A RID: 570
		UnescapeAll = 8,
		// Token: 0x0400023B RID: 571
		UnescapeAllOrThrow = 24
	}
}
