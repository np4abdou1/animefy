using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000ED RID: 237
	[DebuggerTypeProxy(typeof(MemoryDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	public readonly struct ReadOnlyMemory<T> : IEquatable<ReadOnlyMemory<T>>
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x000239E5 File Offset: 0x00021BE5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlyMemory(T[] array)
		{
			if (array == null)
			{
				this = default(ReadOnlyMemory<T>);
				return;
			}
			this._object = array;
			this._index = 0;
			this._length = array.Length;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00023A09 File Offset: 0x00021C09
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlyMemory(T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(ReadOnlyMemory<T>);
				return;
			}
			if (start > array.Length || length > array.Length - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._object = array;
			this._index = start;
			this._length = length;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00023A49 File Offset: 0x00021C49
		public int Length
		{
			get
			{
				return this._length & int.MaxValue;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00023A58 File Offset: 0x00021C58
		public override string ToString()
		{
			if (!(typeof(T) == typeof(char)))
			{
				return string.Format("System.ReadOnlyMemory<{0}>[{1}]", typeof(T).Name, this._length & int.MaxValue);
			}
			string text = this._object as string;
			if (text == null)
			{
				return this.Span.ToString();
			}
			return text.Substring(this._index, this._length & int.MaxValue);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00023AE8 File Offset: 0x00021CE8
		public ReadOnlySpan<T> Span
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
						return new ReadOnlySpan<T>(Unsafe.As<char, T>(text.GetRawStringData()), text.Length).Slice(this._index, this._length);
					}
				}
				if (this._object != null)
				{
					return new ReadOnlySpan<T>((T[])this._object, this._index, this._length & int.MaxValue);
				}
				return default(ReadOnlySpan<T>);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00023BB8 File Offset: 0x00021DB8
		public override bool Equals(object obj)
		{
			if (obj is ReadOnlyMemory<T>)
			{
				ReadOnlyMemory<T> other = (ReadOnlyMemory<T>)obj;
				return this.Equals(other);
			}
			if (obj is Memory<T>)
			{
				Memory<T> memory = (Memory<T>)obj;
				return this.Equals(memory);
			}
			return false;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00023BF9 File Offset: 0x00021DF9
		public bool Equals(ReadOnlyMemory<T> other)
		{
			return this._object == other._object && this._index == other._index && this._length == other._length;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00023C27 File Offset: 0x00021E27
		public override int GetHashCode()
		{
			if (this._object == null)
			{
				return 0;
			}
			return ReadOnlyMemory<T>.CombineHashCodes(this._object.GetHashCode(), this._index.GetHashCode(), this._length.GetHashCode());
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0001D7A3 File Offset: 0x0001B9A3
		private static int CombineHashCodes(int left, int right)
		{
			return (left << 5) + left ^ right;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00023C59 File Offset: 0x00021E59
		private static int CombineHashCodes(int h1, int h2, int h3)
		{
			return ReadOnlyMemory<T>.CombineHashCodes(ReadOnlyMemory<T>.CombineHashCodes(h1, h2), h3);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00023C68 File Offset: 0x00021E68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal object GetObjectStartLength(out int start, out int length)
		{
			start = this._index;
			length = this._length;
			return this._object;
		}

		// Token: 0x04000355 RID: 853
		private readonly object _object;

		// Token: 0x04000356 RID: 854
		private readonly int _index;

		// Token: 0x04000357 RID: 855
		private readonly int _length;
	}
}
