using System;

namespace System
{
	// Token: 0x020000AC RID: 172
	internal struct DateTimeRawInfo
	{
		// Token: 0x060005E5 RID: 1509 RVA: 0x0001A4A2 File Offset: 0x000186A2
		internal unsafe void Init(int* numberBuffer)
		{
			this.month = -1;
			this.year = -1;
			this.dayOfWeek = -1;
			this.era = -1;
			this.timeMark = DateTimeParse.TM.NotSet;
			this.fraction = -1.0;
			this.num = numberBuffer;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001A4E0 File Offset: 0x000186E0
		internal unsafe void AddNumber(int value)
		{
			ref int ptr = ref *this.num;
			int num = this.numCount;
			this.numCount = num + 1;
			*(ref ptr + (IntPtr)num * 4) = value;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001A50A File Offset: 0x0001870A
		internal unsafe int GetNumber(int index)
		{
			return this.num[index];
		}

		// Token: 0x04000286 RID: 646
		private unsafe int* num;

		// Token: 0x04000287 RID: 647
		internal int numCount;

		// Token: 0x04000288 RID: 648
		internal int month;

		// Token: 0x04000289 RID: 649
		internal int year;

		// Token: 0x0400028A RID: 650
		internal int dayOfWeek;

		// Token: 0x0400028B RID: 651
		internal int era;

		// Token: 0x0400028C RID: 652
		internal DateTimeParse.TM timeMark;

		// Token: 0x0400028D RID: 653
		internal double fraction;

		// Token: 0x0400028E RID: 654
		internal bool hasSameDateAndTimeSeparators;
	}
}
