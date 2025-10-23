using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020002D3 RID: 723
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x0600136C RID: 4972 RVA: 0x0005B4A9 File Offset: 0x000596A9
		public ValueListBuilder(Span<T> initialSpan)
		{
			this._span = initialSpan;
			this._arrayFromPool = null;
			this._pos = 0;
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0005B4C0 File Offset: 0x000596C0
		public int Length
		{
			get
			{
				return this._pos;
			}
		}

		// Token: 0x170003EF RID: 1007
		public T this[int index]
		{
			get
			{
				return this._span[index];
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0005B4D8 File Offset: 0x000596D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(T item)
		{
			int pos = this._pos;
			if (pos >= this._span.Length)
			{
				this.Grow();
			}
			*this._span[pos] = item;
			this._pos = pos + 1;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0005B51B File Offset: 0x0005971B
		public ReadOnlySpan<T> AsSpan()
		{
			return this._span.Slice(0, this._pos);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0005B534 File Offset: 0x00059734
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			if (this._arrayFromPool != null)
			{
				ArrayPool<T>.Shared.Return(this._arrayFromPool, false);
				this._arrayFromPool = null;
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0005B558 File Offset: 0x00059758
		private void Grow()
		{
			T[] array = ArrayPool<T>.Shared.Rent(this._span.Length * 2);
			this._span.TryCopyTo(array);
			T[] arrayFromPool = this._arrayFromPool;
			this._span = (this._arrayFromPool = array);
			if (arrayFromPool != null)
			{
				ArrayPool<T>.Shared.Return(arrayFromPool, false);
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0005B5BA File Offset: 0x000597BA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe T Pop()
		{
			this._pos--;
			return *this._span[this._pos];
		}

		// Token: 0x04000D53 RID: 3411
		private Span<T> _span;

		// Token: 0x04000D54 RID: 3412
		private T[] _arrayFromPool;

		// Token: 0x04000D55 RID: 3413
		private int _pos;
	}
}
