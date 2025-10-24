using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200024E RID: 590
	internal class RestrictionFacets
	{
		// Token: 0x04000CE0 RID: 3296
		internal int Length;

		// Token: 0x04000CE1 RID: 3297
		internal int MinLength;

		// Token: 0x04000CE2 RID: 3298
		internal int MaxLength;

		// Token: 0x04000CE3 RID: 3299
		internal ArrayList Patterns;

		// Token: 0x04000CE4 RID: 3300
		internal ArrayList Enumeration;

		// Token: 0x04000CE5 RID: 3301
		internal XmlSchemaWhiteSpace WhiteSpace;

		// Token: 0x04000CE6 RID: 3302
		internal object MaxInclusive;

		// Token: 0x04000CE7 RID: 3303
		internal object MaxExclusive;

		// Token: 0x04000CE8 RID: 3304
		internal object MinInclusive;

		// Token: 0x04000CE9 RID: 3305
		internal object MinExclusive;

		// Token: 0x04000CEA RID: 3306
		internal int TotalDigits;

		// Token: 0x04000CEB RID: 3307
		internal int FractionDigits;

		// Token: 0x04000CEC RID: 3308
		internal RestrictionFlags Flags;

		// Token: 0x04000CED RID: 3309
		internal RestrictionFlags FixedFlags;
	}
}
