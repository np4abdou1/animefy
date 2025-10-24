using System;

namespace System
{
	// Token: 0x020000AD RID: 173
	internal enum ParseFailureKind
	{
		// Token: 0x04000290 RID: 656
		None,
		// Token: 0x04000291 RID: 657
		ArgumentNull,
		// Token: 0x04000292 RID: 658
		Format,
		// Token: 0x04000293 RID: 659
		FormatWithParameter,
		// Token: 0x04000294 RID: 660
		FormatWithOriginalDateTime,
		// Token: 0x04000295 RID: 661
		FormatWithFormatSpecifier,
		// Token: 0x04000296 RID: 662
		FormatWithOriginalDateTimeAndParameter,
		// Token: 0x04000297 RID: 663
		FormatBadDateTimeCalendar
	}
}
