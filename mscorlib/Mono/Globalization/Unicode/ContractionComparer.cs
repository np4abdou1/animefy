using System;
using System.Collections.Generic;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000036 RID: 54
	internal class ContractionComparer : IComparer<Contraction>
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00003A68 File Offset: 0x00001C68
		public int Compare(Contraction c1, Contraction c2)
		{
			char[] source = c1.Source;
			char[] source2 = c2.Source;
			int num = (source.Length > source2.Length) ? source2.Length : source.Length;
			for (int i = 0; i < num; i++)
			{
				if (source[i] != source2[i])
				{
					return (int)(source[i] - source2[i]);
				}
			}
			if (source.Length != source2.Length)
			{
				return source.Length - source2.Length;
			}
			return c1.Index - c2.Index;
		}

		// Token: 0x040000E2 RID: 226
		public static readonly ContractionComparer Instance = new ContractionComparer();
	}
}
