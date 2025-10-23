using System;

namespace System.Globalization
{
	// Token: 0x02000585 RID: 1413
	internal enum HebrewNumberParsingState
	{
		// Token: 0x0400167B RID: 5755
		InvalidHebrewNumber,
		// Token: 0x0400167C RID: 5756
		NotHebrewDigit,
		// Token: 0x0400167D RID: 5757
		FoundEndOfHebrewNumber,
		// Token: 0x0400167E RID: 5758
		ContinueParsing
	}
}
