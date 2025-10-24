using System;

namespace System.Xml.Schema
{
	// Token: 0x0200024C RID: 588
	[Flags]
	internal enum RestrictionFlags
	{
		// Token: 0x04000CD0 RID: 3280
		Length = 1,
		// Token: 0x04000CD1 RID: 3281
		MinLength = 2,
		// Token: 0x04000CD2 RID: 3282
		MaxLength = 4,
		// Token: 0x04000CD3 RID: 3283
		Pattern = 8,
		// Token: 0x04000CD4 RID: 3284
		Enumeration = 16,
		// Token: 0x04000CD5 RID: 3285
		WhiteSpace = 32,
		// Token: 0x04000CD6 RID: 3286
		MaxInclusive = 64,
		// Token: 0x04000CD7 RID: 3287
		MaxExclusive = 128,
		// Token: 0x04000CD8 RID: 3288
		MinInclusive = 256,
		// Token: 0x04000CD9 RID: 3289
		MinExclusive = 512,
		// Token: 0x04000CDA RID: 3290
		TotalDigits = 1024,
		// Token: 0x04000CDB RID: 3291
		FractionDigits = 2048
	}
}
