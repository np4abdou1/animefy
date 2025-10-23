using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000D2 RID: 210
	[DebuggerTypeProxy(typeof(MemoryDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	public readonly struct Memory<T> : IEquatable<Memory<T>>
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x0001D338 File Offset: 0x0001B538
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Memory(T[] array)
		{
			if (array == null)
			{
				this = default(Memory<T>);
				return;
			}
			if (default(T) == null && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			this._object = array;
			this._index = 0;
			this._length = array.Length;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001D394 File Offset: 0x0001B594
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Memory(T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(Memory<T>);
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
			this._object = array;
			this._index = start;
			this._length = length;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001D40B File Offset: 0x0001B60B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Memory(object obj, int start, int length)
		{
			this._object = obj;
			this._index = start;
			this._length = length;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001D422 File Offset: 0x0001B622
		public static implicit operator Memory<T>(T[] array)
		{
			return new Memory<T>(array);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001D42A File Offset: 0x0001B62A
		public unsafe static implicit operator ReadOnlyMemory<T>(Memory<T> memory)
		{
			return *Unsafe.As<Memory<T>, ReadOnlyMemory<T>>(ref memory);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0001D438 File Offset: 0x0001B638
		public int Length
		{
			get
			{
				return this._length & int.MaxValue;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001D448 File Offset: 0x0001B648
		public override string ToString()
		{
			if (!(typeof(T) == typeof(char)))
			{
				return string.Format("System.Memory<{0}>[{1}]", typeof(T).Name, this._length & int.MaxValue);
			}
			string text = this._object as string;
			if (text == null)
			{
				return this.Span.ToString();
			}
			return text.Substring(this._index, this._length & int.MaxValue);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Memory<T> Slice(int start, int length)
		{
			int length2 = this._length;
			int num = length2 & int.MaxValue;
			if (start > num || length > num - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Memory<T>(this._object, this._index + start, length | (length2 & int.MinValue));
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0001D520 File Offset: 0x0001B720
		public Span<T> Span
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (this._index < 0)
				{
					return ((MemoryManager<T>)this._object).GetSpan().Slice(this._index & int.MaxValue, this._length);
				}
				if (typeof(T) == typeof(char))
				{
					string text = this._object as string;
					if (text != null)
					{
						return new Span<T>(Unsafe.As<char, T>(text.GetRawStringData()), text.Length).Slice(this._index, this._length);
					}
				}
				if (this._object != null)
				{
					return new Span<T>((T[])this._object, this._index, this._length & int.MaxValue);
				}
				return default(Span<T>);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		public MemoryHandle Pin()
		{
			if (this._index < 0)
			{
				return ((MemoryManager<T>)this._object).Pin(this._index & int.MaxValue);
			}
			if (typeof(T) == typeof(char))
			{
				string text = this._object as string;
				if (text != null)
				{
					GCHandle handle = GCHandle.Alloc(text, GCHandleType.Pinned);
					return new MemoryHandle(Unsafe.Add<T>(Unsafe.AsPointer<char>(text.GetRawStringData()), this._index), handle, null);
				}
			}
			T[] array = this._object as T[];
			if (array == null)
			{
				return default(MemoryHandle);
			}
			if (this._length < 0)
			{
				return new MemoryHandle(Unsafe.Add<T>(Unsafe.AsPointer<byte>(array.GetRawSzArrayData()), this._index), default(GCHandle), null);
			}
			GCHandle handle2 = GCHandle.Alloc(array, GCHandleType.Pinned);
			return new MemoryHandle(Unsafe.Add<T>(Unsafe.AsPointer<byte>(array.GetRawSzArrayData()), this._index), handle2, null);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		public T[] ToArray()
		{
			return this.Span.ToArray();
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001D6FC File Offset: 0x0001B8FC
		public override bool Equals(object obj)
		{
			if (obj is ReadOnlyMemory<T>)
			{
				return ((ReadOnlyMemory<T>)obj).Equals(this);
			}
			if (obj is Memory<T>)
			{
				Memory<T> other = (Memory<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001D743 File Offset: 0x0001B943
		public bool Equals(Memory<T> other)
		{
			return this._object == other._object && this._index == other._index && this._length == other._length;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001D771 File Offset: 0x0001B971
		public override int GetHashCode()
		{
			if (this._object == null)
			{
				return 0;
			}
			return Memory<T>.CombineHashCodes(this._object.GetHashCode(), this._index.GetHashCode(), this._length.GetHashCode());
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001D7A3 File Offset: 0x0001B9A3
		private static int CombineHashCodes(int left, int right)
		{
			return (left << 5) + left ^ right;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001D7AC File Offset: 0x0001B9AC
		private static int CombineHashCodes(int h1, int h2, int h3)
		{
			return Memory<T>.CombineHashCodes(Memory<T>.CombineHashCodes(h1, h2), h3);
		}

		// Token: 0x0400032D RID: 813
		private readonly object _object;

		// Token: 0x0400032E RID: 814
		private readonly int _index;

		// Token: 0x0400032F RID: 815
		private readonly int _length;
	}
}
