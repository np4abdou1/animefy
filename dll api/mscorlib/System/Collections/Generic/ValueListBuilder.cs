using System;
using System.Buffers;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000627 RID: 1575
	[DefaultMember("Item")]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x06002FF9 RID: 12281 RVA: 0x000C2067 File Offset: 0x000C0267
		public ValueListBuilder(Span<T> initialSpan)
		{
			this._span = initialSpan;
			this._arrayFromPool = null;
			this._pos = 0;
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000C207E File Offset: 0x000C027E
		public int Length
		{
			get
			{
				return this._pos;
			}
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x000C2088 File Offset: 0x000C0288
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

		// Token: 0x06002FFC RID: 12284 RVA: 0x000C20CB File Offset: 0x000C02CB
		public ReadOnlySpan<T> AsSpan()
		{
			return this._span.Slice(0, this._pos);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000C20E4 File Offset: 0x000C02E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			if (this._arrayFromPool != null)
			{
				ArrayPool<T>.Shared.Return(this._arrayFromPool, false);
				this._arrayFromPool = null;
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000C2108 File Offset: 0x000C0308
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

		// Token: 0x04001919 RID: 6425
		private Span<T> _span;

		// Token: 0x0400191A RID: 6426
		private T[] _arrayFromPool;

		// Token: 0x0400191B RID: 6427
		private int _pos;
	}
}
