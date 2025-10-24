using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000B0 RID: 176
	internal struct ParsingInfo
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x0001A5F3 File Offset: 0x000187F3
		internal void Init()
		{
			this.dayOfWeek = -1;
			this.timeMark = DateTimeParse.TM.NotSet;
		}

		// Token: 0x040002BA RID: 698
		internal Calendar calendar;

		// Token: 0x040002BB RID: 699
		internal int dayOfWeek;

		// Token: 0x040002BC RID: 700
		internal DateTimeParse.TM timeMark;

		// Token: 0x040002BD RID: 701
		internal bool fUseHour12;

		// Token: 0x040002BE RID: 702
		internal bool fUseTwoDigitYear;

		// Token: 0x040002BF RID: 703
		internal bool fAllowInnerWhite;

		// Token: 0x040002C0 RID: 704
		internal bool fAllowTrailingWhite;

		// Token: 0x040002C1 RID: 705
		internal bool fCustomNumberParser;

		// Token: 0x040002C2 RID: 706
		internal DateTimeParse.MatchNumberDelegate parseNumberDelegate;
	}
}
