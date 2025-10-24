using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x02000637 RID: 1591
	[DebuggerDisplay("Count = {Count}")]
	internal class LowLevelList<T>
	{
		// Token: 0x06003049 RID: 12361 RVA: 0x000C3107 File Offset: 0x000C1307
		public LowLevelList()
		{
			this._items = LowLevelList<T>.s_emptyArray;
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000C311A File Offset: 0x000C131A
		public LowLevelList(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			if (capacity == 0)
			{
				this._items = LowLevelList<T>.s_emptyArray;
				return;
			}
			this._items = new T[capacity];
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x000C314C File Offset: 0x000C134C
		// (set) Token: 0x0600304C RID: 12364 RVA: 0x000C3158 File Offset: 0x000C1358
		public int Capacity
		{
			get
			{
				return this._items.Length;
			}
			set
			{
				if (value < this._size)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						T[] array = new T[value];
						Array.Copy(this._items, 0, array, 0, this._size);
						this._items = array;
						return;
					}
					this._items = LowLevelList<T>.s_emptyArray;
				}
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x000C31B6 File Offset: 0x000C13B6
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170007D9 RID: 2009
		public T this[int index]
		{
			get
			{
				if (index >= this._size)
				{
					throw new ArgumentOutOfRangeException();
				}
				return this._items[index];
			}
			set
			{
				if (index >= this._size)
				{
					throw new ArgumentOutOfRangeException();
				}
				this._items[index] = value;
				this._version++;
			}
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000C3208 File Offset: 0x000C1408
		public void Add(T item)
		{
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			T[] items = this._items;
			int size = this._size;
			this._size = size + 1;
			items[size] = item;
			this._version++;
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000C3260 File Offset: 0x000C1460
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = (this._items.Length == 0) ? 4 : (this._items.Length * 2);
				if (num < min)
				{
					num = min;
				}
				this.Capacity = num;
			}
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000C329C File Offset: 0x000C149C
		public void AddRange(IEnumerable<T> collection)
		{
			this.InsertRange(this._size, collection);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x000C32AB File Offset: 0x000C14AB
		public void Clear()
		{
			if (this._size > 0)
			{
				Array.Clear(this._items, 0, this._size);
				this._size = 0;
			}
			this._version++;
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x000C32E0 File Offset: 0x000C14E0
		public bool Contains(T item)
		{
			if (item == null)
			{
				for (int i = 0; i < this._size; i++)
				{
					if (this._items[i] == null)
					{
						return true;
					}
				}
				return false;
			}
			return this.IndexOf(item) >= 0;
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x000C332A File Offset: 0x000C152A
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x000C3340 File Offset: 0x000C1540
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._items, item, 0, this._size);
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x000C3358 File Offset: 0x000C1558
		public void Insert(int index, T item)
		{
			if (index > this._size)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = item;
			this._size++;
			this._version++;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x000C33E8 File Offset: 0x000C15E8
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			if (index > this._size)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > 0)
				{
					this.EnsureCapacity(this._size + count);
					if (index < this._size)
					{
						Array.Copy(this._items, index, this._items, index + count, this._size - index);
					}
					if (this == collection2)
					{
						Array.Copy(this._items, 0, this._items, index, index);
						Array.Copy(this._items, index + count, this._items, index * 2, this._size - index);
					}
					else
					{
						T[] array = new T[count];
						collection2.CopyTo(array, 0);
						Array.Copy(array, 0, this._items, index, count);
					}
					this._size += count;
				}
			}
			else
			{
				foreach (T item in collection)
				{
					this.Insert(index++, item);
				}
			}
			this._version++;
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x000C351C File Offset: 0x000C171C
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x000C3540 File Offset: 0x000C1740
		public int RemoveAll(Predicate<T> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			int num = 0;
			while (num < this._size && !match(this._items[num]))
			{
				num++;
			}
			if (num >= this._size)
			{
				return 0;
			}
			int i = num + 1;
			while (i < this._size)
			{
				while (i < this._size && match(this._items[i]))
				{
					i++;
				}
				if (i < this._size)
				{
					this._items[num++] = this._items[i++];
				}
			}
			Array.Clear(this._items, num, this._size - num);
			int result = this._size - num;
			this._size = num;
			this._version++;
			return result;
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000C3618 File Offset: 0x000C1818
		public void RemoveAt(int index)
		{
			if (index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			this._items[this._size] = default(T);
			this._version++;
		}

		// Token: 0x0400193E RID: 6462
		protected T[] _items;

		// Token: 0x0400193F RID: 6463
		protected int _size;

		// Token: 0x04001940 RID: 6464
		protected int _version;

		// Token: 0x04001941 RID: 6465
		private static readonly T[] s_emptyArray = new T[0];
	}
}
