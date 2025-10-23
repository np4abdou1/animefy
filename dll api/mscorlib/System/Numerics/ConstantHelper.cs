using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x0200051B RID: 1307
	internal class ConstantHelper
	{
		// Token: 0x060026A0 RID: 9888 RVA: 0x000970A8 File Offset: 0x000952A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static byte GetByteWithAllBitsSet()
		{
			byte result = 0;
			*(&result) = byte.MaxValue;
			return result;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000970C4 File Offset: 0x000952C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static sbyte GetSByteWithAllBitsSet()
		{
			sbyte result = 0;
			*(&result) = -1;
			return result;
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000970DC File Offset: 0x000952DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ushort GetUInt16WithAllBitsSet()
		{
			ushort result = 0;
			*(&result) = ushort.MaxValue;
			return result;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000970F8 File Offset: 0x000952F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static short GetInt16WithAllBitsSet()
		{
			short result = 0;
			*(&result) = -1;
			return result;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00097110 File Offset: 0x00095310
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static uint GetUInt32WithAllBitsSet()
		{
			uint result = 0U;
			*(&result) = uint.MaxValue;
			return result;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00097128 File Offset: 0x00095328
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int GetInt32WithAllBitsSet()
		{
			int result = 0;
			*(&result) = -1;
			return result;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00097140 File Offset: 0x00095340
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ulong GetUInt64WithAllBitsSet()
		{
			ulong result = 0UL;
			*(&result) = ulong.MaxValue;
			return result;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00097158 File Offset: 0x00095358
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static long GetInt64WithAllBitsSet()
		{
			long result = 0L;
			*(&result) = -1L;
			return result;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00097170 File Offset: 0x00095370
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float GetSingleWithAllBitsSet()
		{
			float result = 0f;
			*(int*)(&result) = -1;
			return result;
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0009718C File Offset: 0x0009538C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static double GetDoubleWithAllBitsSet()
		{
			double result = 0.0;
			*(long*)(&result) = -1L;
			return result;
		}
	}
}
