using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000035 RID: 53
	internal class Contraction
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00003A41 File Offset: 0x00001C41
		public Contraction(int index, char[] source, string replacement, byte[] sortkey)
		{
			this.Index = index;
			this.Source = source;
			this.Replacement = replacement;
			this.SortKey = sortkey;
		}

		// Token: 0x040000DE RID: 222
		public int Index;

		// Token: 0x040000DF RID: 223
		public readonly char[] Source;

		// Token: 0x040000E0 RID: 224
		public readonly string Replacement;

		// Token: 0x040000E1 RID: 225
		public readonly byte[] SortKey;
	}
}
