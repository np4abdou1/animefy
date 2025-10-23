using System;

namespace System.Xml.Schema
{
	// Token: 0x02000341 RID: 833
	[Flags]
	internal enum XsdDateTimeFlags
	{
		// Token: 0x040012A0 RID: 4768
		DateTime = 1,
		// Token: 0x040012A1 RID: 4769
		Time = 2,
		// Token: 0x040012A2 RID: 4770
		Date = 4,
		// Token: 0x040012A3 RID: 4771
		GYearMonth = 8,
		// Token: 0x040012A4 RID: 4772
		GYear = 16,
		// Token: 0x040012A5 RID: 4773
		GMonthDay = 32,
		// Token: 0x040012A6 RID: 4774
		GDay = 64,
		// Token: 0x040012A7 RID: 4775
		GMonth = 128,
		// Token: 0x040012A8 RID: 4776
		XdrDateTimeNoTz = 256,
		// Token: 0x040012A9 RID: 4777
		XdrDateTime = 512,
		// Token: 0x040012AA RID: 4778
		XdrTimeNoTz = 1024,
		// Token: 0x040012AB RID: 4779
		AllXsd = 255
	}
}
