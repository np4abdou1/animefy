using System;

namespace System.Collections.Generic
{
	// Token: 0x02000638 RID: 1592
	internal sealed class LowLevelListWithIList<T> : LowLevelList<T>, IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x0600305D RID: 12381 RVA: 0x000C36A2 File Offset: 0x000C18A2
		public LowLevelListWithIList()
		{
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000C36AA File Offset: 0x000C18AA
		public LowLevelListWithIList(int capacity) : base(capacity)
		{
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000C36B3 File Offset: 0x000C18B3
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new LowLevelListWithIList<T>.Enumerator(this);
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x000C36B3 File Offset: 0x000C18B3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new LowLevelListWithIList<T>.Enumerator(this);
		}

		// Token: 0x02000639 RID: 1593
		private struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06003062 RID: 12386 RVA: 0x000C36C0 File Offset: 0x000C18C0
			internal Enumerator(LowLevelListWithIList<T> list)
			{
				this._list = list;
				this._index = 0;
				this._version = list._version;
				this._current = default(T);
			}

			// Token: 0x06003063 RID: 12387 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Dispose()
			{
			}

			// Token: 0x06003064 RID: 12388 RVA: 0x000C36E8 File Offset: 0x000C18E8
			public bool MoveNext()
			{
				LowLevelListWithIList<T> list = this._list;
				if (this._version == list._version && this._index < list._size)
				{
					this._current = list._items[this._index];
					this._index++;
					return true;
				}
				return this.MoveNextRare();
			}

			// Token: 0x06003065 RID: 12389 RVA: 0x000C3745 File Offset: 0x000C1945
			private bool MoveNextRare()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException();
				}
				this._index = this._list._size + 1;
				this._current = default(T);
				return false;
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06003066 RID: 12390 RVA: 0x000C3780 File Offset: 0x000C1980
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06003067 RID: 12391 RVA: 0x000C3788 File Offset: 0x000C1988
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._list._size + 1)
					{
						throw new InvalidOperationException();
					}
					return this.Current;
				}
			}

			// Token: 0x06003068 RID: 12392 RVA: 0x000C37B8 File Offset: 0x000C19B8
			void IEnumerator.Reset()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x04001942 RID: 6466
			private LowLevelListWithIList<T> _list;

			// Token: 0x04001943 RID: 6467
			private int _index;

			// Token: 0x04001944 RID: 6468
			private int _version;

			// Token: 0x04001945 RID: 6469
			private T _current;
		}
	}
}
