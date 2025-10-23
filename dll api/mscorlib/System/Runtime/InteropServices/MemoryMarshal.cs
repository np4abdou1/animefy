using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003FC RID: 1020
	public static class MemoryMarshal
	{
		// Token: 0x06001F25 RID: 7973 RVA: 0x000863FF File Offset: 0x000845FF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Span<byte> AsBytes<T>(Span<T> span) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			return new Span<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), checked(span.Length * Unsafe.SizeOf<T>()));
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00086434 File Offset: 0x00084634
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			return new ReadOnlySpan<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), checked(span.Length * Unsafe.SizeOf<T>()));
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00086469 File Offset: 0x00084669
		public unsafe static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory)
		{
			return *Unsafe.As<ReadOnlyMemory<T>, Memory<T>>(ref memory);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00086478 File Offset: 0x00084678
		public static ref T GetReference<T>(Span<T> span)
		{
			return span._pointer.Value;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00086494 File Offset: 0x00084694
		public static ref T GetReference<T>(ReadOnlySpan<T> span)
		{
			return span._pointer.Value;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000864B0 File Offset: 0x000846B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref T GetNonNullPinnableReference<T>(Span<T> span)
		{
			if (span.Length == 0)
			{
				return Unsafe.AsRef<T>(1);
			}
			return span._pointer.Value;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000864DC File Offset: 0x000846DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span)
		{
			if (span.Length == 0)
			{
				return Unsafe.AsRef<T>(1);
			}
			return span._pointer.Value;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00086508 File Offset: 0x00084708
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length)
		{
			return new ReadOnlySpan<T>(ref reference, length);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00086514 File Offset: 0x00084714
		public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment)
		{
			int num;
			int num2;
			object objectStartLength = memory.GetObjectStartLength(out num, out num2);
			if (num < 0)
			{
				ArraySegment<T> arraySegment;
				if (((MemoryManager<T>)objectStartLength).TryGetArray(out arraySegment))
				{
					segment = new ArraySegment<T>(arraySegment.Array, arraySegment.Offset + (num & int.MaxValue), num2);
					return true;
				}
			}
			else
			{
				T[] array = objectStartLength as T[];
				if (array != null)
				{
					segment = new ArraySegment<T>(array, num, num2 & int.MaxValue);
					return true;
				}
			}
			if ((num2 & 2147483647) == 0)
			{
				segment = ArraySegment<T>.Empty;
				return true;
			}
			segment = default(ArraySegment<T>);
			return false;
		}
	}
}
