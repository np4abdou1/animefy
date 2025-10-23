using System;

namespace System
{
	// Token: 0x020000AE RID: 174
	[Flags]
	internal enum ParseFlags
	{
		// Token: 0x04000299 RID: 665
		HaveYear = 1,
		// Token: 0x0400029A RID: 666
		HaveMonth = 2,
		// Token: 0x0400029B RID: 667
		HaveDay = 4,
		// Token: 0x0400029C RID: 668
		HaveHour = 8,
		// Token: 0x0400029D RID: 669
		HaveMinute = 16,
		// Token: 0x0400029E RID: 670
		HaveSecond = 32,
		// Token: 0x0400029F RID: 671
		HaveTime = 64,
		// Token: 0x040002A0 RID: 672
		HaveDate = 128,
		// Token: 0x040002A1 RID: 673
		TimeZoneUsed = 256,
		// Token: 0x040002A2 RID: 674
		TimeZoneUtc = 512,
		// Token: 0x040002A3 RID: 675
		ParsedMonthName = 1024,
		// Token: 0x040002A4 RID: 676
		CaptureOffset = 2048,
		// Token: 0x040002A5 RID: 677
		YearDefault = 4096,
		// Token: 0x040002A6 RID: 678
		Rfc1123Pattern = 8192,
		// Token: 0x040002A7 RID: 679
		UtcSortPattern = 16384
	}
}
