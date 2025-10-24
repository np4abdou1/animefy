using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020000F4 RID: 244
	[NonVersionable]
	[DebuggerTypeProxy(typeof(SpanDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	public readonly ref struct Span<T>
	{
		// Token: 0x06000844 RID: 2116 RVA: 0x000245F8 File Offset: 0x000227F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span(T[] array)
		{
			if (array == null)
			{
				this = default(Span<T>);
				return;
			}
			if (default(T) == null && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			this._pointer = new ByReference<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()));
			this._length = array.Length;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0002465C File Offset: 0x0002285C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span(T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(Span<T>);
				return;
			}
			if (default(T) == null && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			if (start > array.Length || length > array.Length - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._pointer = new ByReference<T>(Unsafe.Add<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()), start));
			this._length = length;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000246E1 File Offset: 0x000228E1
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe Span(void* pointer, int length)
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if (length < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._pointer = new ByReference<T>(Unsafe.As<byte, T>(ref *(byte*)pointer));
			this._length = length;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0002471A File Offset: 0x0002291A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Span(ref T ptr, int length)
		{
			this._pointer = new ByReference<T>(ref ptr);
			this._length = length;
		}

		// Token: 0x1700008C RID: 140
		public T this[int index]
		{
			[Intrinsic]
			[NonVersionable]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (index >= this._length)
				{
					ThrowHelper.ThrowIndexOutOfRangeException();
				}
				return Unsafe.Add<T>(this._pointer.Value, index);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00024760 File Offset: 0x00022960
		public ref T GetPinnableReference()
		{
			if (this._length == 0)
			{
				return Unsafe.AsRef<T>(null);
			}
			return this._pointer.Value;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0002478C File Offset: 0x0002298C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				SpanHelpers.ClearWithReferences(Unsafe.As<T, IntPtr>(this._pointer.Value), (ulong)((long)this._length * (long)(Unsafe.SizeOf<T>() / IntPtr.Size)));
				return;
			}
			SpanHelpers.ClearWithoutReferences(Unsafe.As<T, byte>(this._pointer.Value), (ulong)((long)this._length * (long)Unsafe.SizeOf<T>()));
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000247F4 File Offset: 0x000229F4
		public unsafe void Fill(T value)
		{
			if (Unsafe.SizeOf<T>() == 1)
			{
				uint length = (uint)this._length;
				if (length == 0U)
				{
					return;
				}
				T t = value;
				Unsafe.InitBlockUnaligned(Unsafe.As<T, byte>(this._pointer.Value), *Unsafe.As<T, byte>(ref t), length);
				return;
			}
			else
			{
				ulong num = (ulong)this._length;
				if (num == 0UL)
				{
					return;
				}
				ref T value2 = ref this._pointer.Value;
				ulong num2 = (ulong)Unsafe.SizeOf<T>();
				ulong num3;
				for (num3 = 0UL; num3 < (num & 18446744073709551608UL); num3 += 8UL)
				{
					*Unsafe.AddByteOffset<T>(ref value2, num3 * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 1UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 2UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 3UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 4UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 5UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 6UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 7UL) * num2) = value;
				}
				if (num3 < (num & 18446744073709551612UL))
				{
					*Unsafe.AddByteOffset<T>(ref value2, num3 * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 1UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 2UL) * num2) = value;
					*Unsafe.AddByteOffset<T>(ref value2, (num3 + 3UL) * num2) = value;
					num3 += 4UL;
				}
				while (num3 < num)
				{
					*Unsafe.AddByteOffset<T>(ref value2, num3 * num2) = value;
					num3 += 1UL;
				}
				return;
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000249A0 File Offset: 0x00022BA0
		public void CopyTo(Span<T> destination)
		{
			if (this._length <= destination.Length)
			{
				Buffer.Memmove<T>(destination._pointer.Value, this._pointer.Value, (ulong)((long)this._length));
				return;
			}
			ThrowHelper.ThrowArgumentException_DestinationTooShort();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000249EC File Offset: 0x00022BEC
		public bool TryCopyTo(Span<T> destination)
		{
			bool result = false;
			if (this._length <= destination.Length)
			{
				Buffer.Memmove<T>(destination._pointer.Value, this._pointer.Value, (ulong)((long)this._length));
				result = true;
			}
			return result;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00024A38 File Offset: 0x00022C38
		public static implicit operator ReadOnlySpan<T>(Span<T> span)
		{
			return new ReadOnlySpan<T>(span._pointer.Value, span._length);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00024A60 File Offset: 0x00022C60
		public unsafe override string ToString()
		{
			if (typeof(T) == typeof(char))
			{
				fixed (char* ptr = Unsafe.As<T, char>(this._pointer.Value))
				{
					return new string(ptr, 0, this._length);
				}
			}
			return string.Format("System.Span<{0}>[{1}]", typeof(T).Name, this._length);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00024AD0 File Offset: 0x00022CD0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<T> Slice(int start)
		{
			if (start > this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Span<T>(Unsafe.Add<T>(this._pointer.Value, start), this._length - start);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00024B0C File Offset: 0x00022D0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<T> Slice(int start, int length)
		{
			if (start > this._length || length > this._length - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Span<T>(Unsafe.Add<T>(this._pointer.Value, start), length);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00024B4C File Offset: 0x00022D4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T[] ToArray()
		{
			if (this._length == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[this._length];
			Buffer.Memmove<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()), this._pointer.Value, (ulong)((long)this._length));
			return array;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00024B97 File Offset: 0x00022D97
		public int Length
		{
			[NonVersionable]
			get
			{
				return this._length;
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00023F92 File Offset: 0x00022192
		public override bool Equals(object obj)
		{
			throw new NotSupportedException("Equals() on Span and ReadOnlySpan is not supported. Use operator== instead.");
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00023F9E File Offset: 0x0002219E
		public override int GetHashCode()
		{
			throw new NotSupportedException("GetHashCode() on Span and ReadOnlySpan is not supported.");
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00024B9F File Offset: 0x00022D9F
		public static implicit operator Span<T>(T[] array)
		{
			return new Span<T>(array);
		}

		// Token: 0x0400035E RID: 862
		internal readonly ByReference<T> _pointer;

		// Token: 0x0400035F RID: 863
		private readonly int _length;
	}
}
