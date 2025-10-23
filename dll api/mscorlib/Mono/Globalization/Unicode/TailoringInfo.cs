using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000034 RID: 52
	internal class TailoringInfo
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00003A1C File Offset: 0x00001C1C
		public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
		{
			this.LCID = lcid;
			this.TailoringIndex = tailoringIndex;
			this.TailoringCount = tailoringCount;
			this.FrenchSort = frenchSort;
		}

		// Token: 0x040000DA RID: 218
		public readonly int LCID;

		// Token: 0x040000DB RID: 219
		public readonly int TailoringIndex;

		// Token: 0x040000DC RID: 220
		public readonly int TailoringCount;

		// Token: 0x040000DD RID: 221
		public readonly bool FrenchSort;
	}
}
