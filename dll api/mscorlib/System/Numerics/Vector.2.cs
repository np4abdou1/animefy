using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x0200051F RID: 1311
	[Intrinsic]
	public static class Vector
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x0009AD5A File Offset: 0x00098F5A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : struct
		{
			return Vector<T>.Equals(left, right);
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0009AD63 File Offset: 0x00098F63
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : struct
		{
			return (Vector<ulong>)value;
		}
	}
}
