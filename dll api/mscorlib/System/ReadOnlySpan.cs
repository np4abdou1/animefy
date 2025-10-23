using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020000EE RID: 238
	[NonVersionable]
	[DebuggerTypeProxy(typeof(SpanDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	public readonly ref struct ReadOnlySpan<T>
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x00023C80 File Offset: 0x00021E80
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan(T[] array)
		{
			if (array == null)
			{
				this = default(ReadOnlySpan<T>);
				return;
			}
			this._pointer = new ByReference<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()));
			this._length = array.Length;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00023CAC File Offset: 0x00021EAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan(T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(ReadOnlySpan<T>);
				return;
			}
			if (start > array.Length || length > array.Length - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._pointer = new ByReference<T>(Unsafe.Add<T>(Unsafe.As<byte, T>(array.GetRawSzArrayData()), start));
			this._length = length;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00023D05 File Offset: 0x00021F05
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ReadOnlySpan(void* pointer, int length)
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

		// Token: 0x060007EE RID: 2030 RVA: 0x00023D3E File Offset: 0x00021F3E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan(ref T ptr, int length)
		{
			this._pointer = new ByReference<T>(ref ptr);
			this._length = length;
		}

		// Token: 0x17000088 RID: 136
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

		// Token: 0x060007F0 RID: 2032 RVA: 0x00023D84 File Offset: 0x00021F84
		public ref readonly T GetPinnableReference()
		{
			if (this._length == 0)
			{
				return Unsafe.AsRef<T>(null);
			}
			return this._pointer.Value;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00023DB0 File Offset: 0x00021FB0
		public void CopyTo(Span<T> destination)
		{
			if (this._length <= destination.Length)
			{
				Buffer.Memmove<T>(destination._pointer.Value, this._pointer.Value, (ulong)((long)this._length));
				return;
			}
			ThrowHelper.ThrowArgumentException_DestinationTooShort();
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00023DFC File Offset: 0x00021FFC
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

		// Token: 0x060007F3 RID: 2035 RVA: 0x00023E48 File Offset: 0x00022048
		public unsafe override string ToString()
		{
			if (typeof(T) == typeof(char))
			{
				fixed (char* ptr = Unsafe.As<T, char>(this._pointer.Value))
				{
					return new string(ptr, 0, this._length);
				}
			}
			return string.Format("System.ReadOnlySpan<{0}>[{1}]", typeof(T).Name, this._length);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00023EB8 File Offset: 0x000220B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan<T> Slice(int start)
		{
			if (start > this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new ReadOnlySpan<T>(Unsafe.Add<T>(this._pointer.Value, start), this._length - start);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00023EF4 File Offset: 0x000220F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan<T> Slice(int start, int length)
		{
			if (start > this._length || length > this._length - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new ReadOnlySpan<T>(Unsafe.Add<T>(this._pointer.Value, start), length);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00023F34 File Offset: 0x00022134
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00023F7F File Offset: 0x0002217F
		public int Length
		{
			[NonVersionable]
			get
			{
				return this._length;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00023F87 File Offset: 0x00022187
		public bool IsEmpty
		{
			[NonVersionable]
			get
			{
				return this._length == 0;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00023F92 File Offset: 0x00022192
		public override bool Equals(object obj)
		{
			throw new NotSupportedException("Equals() on Span and ReadOnlySpan is not supported. Use operator== instead.");
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00023F9E File Offset: 0x0002219E
		public override int GetHashCode()
		{
			throw new NotSupportedException("GetHashCode() on Span and ReadOnlySpan is not supported.");
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00023FAA File Offset: 0x000221AA
		public static implicit operator ReadOnlySpan<T>(T[] array)
		{
			return new ReadOnlySpan<T>(array);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00023FB4 File Offset: 0x000221B4
		public static ReadOnlySpan<T> Empty
		{
			get
			{
				return default(ReadOnlySpan<T>);
			}
		}

		// Token: 0x04000358 RID: 856
		internal readonly ByReference<T> _pointer;

		// Token: 0x04000359 RID: 857
		private readonly int _length;
	}
}
