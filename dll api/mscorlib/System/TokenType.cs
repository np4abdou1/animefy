using System;

namespace System
{
	// Token: 0x020000B1 RID: 177
	internal enum TokenType
	{
		// Token: 0x040002C4 RID: 708
		NumberToken = 1,
		// Token: 0x040002C5 RID: 709
		YearNumberToken,
		// Token: 0x040002C6 RID: 710
		Am,
		// Token: 0x040002C7 RID: 711
		Pm,
		// Token: 0x040002C8 RID: 712
		MonthToken,
		// Token: 0x040002C9 RID: 713
		EndOfString,
		// Token: 0x040002CA RID: 714
		DayOfWeekToken,
		// Token: 0x040002CB RID: 715
		TimeZoneToken,
		// Token: 0x040002CC RID: 716
		EraToken,
		// Token: 0x040002CD RID: 717
		DateWordToken,
		// Token: 0x040002CE RID: 718
		UnknownToken,
		// Token: 0x040002CF RID: 719
		HebrewNumber,
		// Token: 0x040002D0 RID: 720
		JapaneseEraToken,
		// Token: 0x040002D1 RID: 721
		TEraToken,
		// Token: 0x040002D2 RID: 722
		IgnorableSymbol,
		// Token: 0x040002D3 RID: 723
		SEP_Unk = 256,
		// Token: 0x040002D4 RID: 724
		SEP_End = 512,
		// Token: 0x040002D5 RID: 725
		SEP_Space = 768,
		// Token: 0x040002D6 RID: 726
		SEP_Am = 1024,
		// Token: 0x040002D7 RID: 727
		SEP_Pm = 1280,
		// Token: 0x040002D8 RID: 728
		SEP_Date = 1536,
		// Token: 0x040002D9 RID: 729
		SEP_Time = 1792,
		// Token: 0x040002DA RID: 730
		SEP_YearSuff = 2048,
		// Token: 0x040002DB RID: 731
		SEP_MonthSuff = 2304,
		// Token: 0x040002DC RID: 732
		SEP_DaySuff = 2560,
		// Token: 0x040002DD RID: 733
		SEP_HourSuff = 2816,
		// Token: 0x040002DE RID: 734
		SEP_MinuteSuff = 3072,
		// Token: 0x040002DF RID: 735
		SEP_SecondSuff = 3328,
		// Token: 0x040002E0 RID: 736
		SEP_LocalTimeMark = 3584,
		// Token: 0x040002E1 RID: 737
		SEP_DateOrOffset = 3840,
		// Token: 0x040002E2 RID: 738
		RegularTokenMask = 255,
		// Token: 0x040002E3 RID: 739
		SeparatorTokenMask = 65280
	}
}
