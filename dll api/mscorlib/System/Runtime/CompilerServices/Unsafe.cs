using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200047A RID: 1146
	internal static class Unsafe
	{
		// Token: 0x060020AB RID: 8363 RVA: 0x0008993F File Offset: 0x00087B3F
		public static ref T Add<T>(ref T source, int elementOffset)
		{
			return ref source + (IntPtr)elementOffset * (IntPtr)sizeof(T);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0008994C File Offset: 0x00087B4C
		public static ref T Add<T>(ref T source, IntPtr elementOffset)
		{
			return ref source + elementOffset * (IntPtr)sizeof(T);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0008993F File Offset: 0x00087B3F
		public unsafe static void* Add<T>(void* source, int elementOffset)
		{
			return (void*)((byte*)source + (IntPtr)elementOffset * (IntPtr)sizeof(T));
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00089958 File Offset: 0x00087B58
		public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset)
		{
			return ref source + byteOffset;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0002B2FC File Offset: 0x000294FC
		public static bool AreSame<T>(ref T left, ref T right)
		{
			return ref left == ref right;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0000245A File Offset: 0x0000065A
		public static T As<T>(object o) where T : class
		{
			return o;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0000245A File Offset: 0x0000065A
		public static ref TTo As<TFrom, TTo>(ref TFrom source)
		{
			return ref source;
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0008995D File Offset: 0x00087B5D
		public unsafe static void* AsPointer<T>(ref T value)
		{
			return (void*)(&value);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0000245A File Offset: 0x0000065A
		public unsafe static ref T AsRef<T>(void* source)
		{
			return ref *(T*)source;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0000245A File Offset: 0x0000065A
		public static ref T AsRef<T>(in T source)
		{
			return ref source;
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00089961 File Offset: 0x00087B61
		public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
		{
			initblk(ref startAddress, value, byteCount);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x0008996B File Offset: 0x00087B6B
		public unsafe static T Read<T>(void* source)
		{
			return *(T*)source;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00089973 File Offset: 0x00087B73
		public static T ReadUnaligned<T>(ref byte source)
		{
			return source;
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0008997E File Offset: 0x00087B7E
		public static int SizeOf<T>()
		{
			return sizeof(T);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00089986 File Offset: 0x00087B86
		public static void WriteUnaligned<T>(ref byte destination, T value)
		{
			destination = value;
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00089992 File Offset: 0x00087B92
		public static bool IsAddressLessThan<T>(ref T left, ref T right)
		{
			return ref left < ref right;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00089998 File Offset: 0x00087B98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref T AddByteOffset<T>(ref T source, ulong byteOffset)
		{
			return Unsafe.AddByteOffset<T>(ref source, (IntPtr)byteOffset);
		}
	}
}
