using System;

namespace System.Globalization
{
	// Token: 0x0200057C RID: 1404
	[Flags]
	internal enum DateTimeFormatFlags
	{
		// Token: 0x040015E5 RID: 5605
		None = 0,
		// Token: 0x040015E6 RID: 5606
		UseGenitiveMonth = 1,
		// Token: 0x040015E7 RID: 5607
		UseLeapYearMonth = 2,
		// Token: 0x040015E8 RID: 5608
		UseSpacesInMonthNames = 4,
		// Token: 0x040015E9 RID: 5609
		UseHebrewRule = 8,
		// Token: 0x040015EA RID: 5610
		UseSpacesInDayNames = 16,
		// Token: 0x040015EB RID: 5611
		UseDigitPrefixInTokens = 32,
		// Token: 0x040015EC RID: 5612
		NotInitialized = -1
	}
}
