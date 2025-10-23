using System;

namespace System.Xml
{
	// Token: 0x0200001D RID: 29
	internal static class Bits
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0000816C File Offset: 0x0000636C
		public static int Count(uint num)
		{
			num = (num & Bits.MASK_0101010101010101) + (num >> 1 & Bits.MASK_0101010101010101);
			num = (num & Bits.MASK_0011001100110011) + (num >> 2 & Bits.MASK_0011001100110011);
			num = (num & Bits.MASK_0000111100001111) + (num >> 4 & Bits.MASK_0000111100001111);
			num = (num & Bits.MASK_0000000011111111) + (num >> 8 & Bits.MASK_0000000011111111);
			num = (num & Bits.MASK_1111111111111111) + (num >> 16);
			return (int)num;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000081D4 File Offset: 0x000063D4
		public static int LeastPosition(uint num)
		{
			if (num == 0U)
			{
				return 0;
			}
			return Bits.Count(num ^ num - 1U);
		}

		// Token: 0x040000EB RID: 235
		private static readonly uint MASK_0101010101010101 = 1431655765U;

		// Token: 0x040000EC RID: 236
		private static readonly uint MASK_0011001100110011 = 858993459U;

		// Token: 0x040000ED RID: 237
		private static readonly uint MASK_0000111100001111 = 252645135U;

		// Token: 0x040000EE RID: 238
		private static readonly uint MASK_0000000011111111 = 16711935U;

		// Token: 0x040000EF RID: 239
		private static readonly uint MASK_1111111111111111 = 65535U;
	}
}
