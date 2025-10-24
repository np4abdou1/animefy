using System;
using System.Runtime.CompilerServices;

namespace System.Buffers.Text
{
	// Token: 0x0200065B RID: 1627
	internal static class FormattingHelpers
	{
		// Token: 0x0600310E RID: 12558 RVA: 0x000C5944 File Offset: 0x000C3B44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountDigits(ulong value)
		{
			int num = 1;
			uint num2;
			if (value >= 10000000UL)
			{
				if (value >= 100000000000000UL)
				{
					num2 = (uint)(value / 100000000000000UL);
					num += 14;
				}
				else
				{
					num2 = (uint)(value / 10000000UL);
					num += 7;
				}
			}
			else
			{
				num2 = (uint)value;
			}
			if (num2 >= 10U)
			{
				if (num2 < 100U)
				{
					num++;
				}
				else if (num2 < 1000U)
				{
					num += 2;
				}
				else if (num2 < 10000U)
				{
					num += 3;
				}
				else if (num2 < 100000U)
				{
					num += 4;
				}
				else if (num2 < 1000000U)
				{
					num += 5;
				}
				else
				{
					num += 6;
				}
			}
			return num;
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000C59DC File Offset: 0x000C3BDC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountDigits(uint value)
		{
			int num = 1;
			if (value >= 100000U)
			{
				value /= 100000U;
				num += 5;
			}
			if (value >= 10U)
			{
				if (value < 100U)
				{
					num++;
				}
				else if (value < 1000U)
				{
					num += 2;
				}
				else if (value < 10000U)
				{
					num += 3;
				}
				else
				{
					num += 4;
				}
			}
			return num;
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x000C5A34 File Offset: 0x000C3C34
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountHexDigits(ulong value)
		{
			int num = 1;
			if (value > (ulong)-1)
			{
				num += 8;
				value >>= 32;
			}
			if (value > 65535UL)
			{
				num += 4;
				value >>= 16;
			}
			if (value > 255UL)
			{
				num += 2;
				value >>= 8;
			}
			if (value > 15UL)
			{
				num++;
			}
			return num;
		}
	}
}
