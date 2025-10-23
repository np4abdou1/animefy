using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
	/// <summary>The builder for read only collection.</summary>
	/// <typeparam name="T">The type of the collection element.</typeparam>
	// Token: 0x0200010A RID: 266
	[Serializable]
	public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IList, ICollection
	{
		/// <summary>Constructs a ReadOnlyCollectionBuilder.</summary>
		// Token: 0x060008C3 RID: 2243 RVA: 0x00022417 File Offset: 0x00020617
		public ReadOnlyCollectionBuilder()
		{
			this._items = Array.Empty<T>();
		}

		/// <summary>Constructs a ReadOnlyCollectionBuilder with a given initial capacity. The contents are empty but builder will have reserved room for the given number of elements before any reallocations are required.</summary>
		/// <param name="capacity">Initial capacity.</param>
		// Token: 0x060008C4 RID: 2244 RVA: 0x0002242A File Offset: 0x0002062A
		public ReadOnlyCollectionBuilder(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			this._items = new T[capacity];
		}

		/// <summary>Gets and sets the capacity of this ReadOnlyCollectionBuilder.</summary>
		/// <returns>The capacity of this ReadOnlyCollectionBuilder.</returns>
		// Token: 0x1700017D RID: 381
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00022450 File Offset: 0x00020650
		public int Capacity
		{
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
						if (this._size > 0)
						{
							Array.Copy(this._items, 0, array, 0, this._size);
						}
						this._items = array;
						return;
					}
					this._items = Array.Empty<T>();
				}
			}
		}

		/// <summary>Returns number of elements in the ReadOnlyCollectionBuilder.</summary>
		/// <returns>The number of elements in the ReadOnlyCollectionBuilder.</returns>
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000224B7 File Offset: 0x000206B7
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Returns the index of the first occurrence of a given value in the builder.</summary>
		/// <param name="item">An item to search for.</param>
		/// <returns>The index of the first occurrence of an item.</returns>
		// Token: 0x060008C7 RID: 2247 RVA: 0x000224BF File Offset: 0x000206BF
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._items, item, 0, this._size);
		}

		/// <summary>Inserts an item to the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item">The object to insert into the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</param>
		// Token: 0x060008C8 RID: 2248 RVA: 0x000224D4 File Offset: 0x000206D4
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

		/// <summary>Removes the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		// Token: 0x060008C9 RID: 2249 RVA: 0x00022564 File Offset: 0x00020764
		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this._size)
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

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		// Token: 0x1700017F RID: 383
		public T this[int index]
		{
			get
			{
				if (index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return this._items[index];
			}
			set
			{
				if (index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				this._items[index] = value;
				this._version++;
			}
		}

		/// <summary>Adds an item to the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</summary>
		/// <param name="item">The object to add to the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</param>
		// Token: 0x060008CC RID: 2252 RVA: 0x00022638 File Offset: 0x00020838
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

		/// <summary>Removes all items from the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</summary>
		// Token: 0x060008CD RID: 2253 RVA: 0x0002268E File Offset: 0x0002088E
		public void Clear()
		{
			if (this._size > 0)
			{
				Array.Clear(this._items, 0, this._size);
				this._size = 0;
			}
			this._version++;
		}

		/// <summary>Determines whether the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> contains a specific value</summary>
		/// <param name="item">the object to locate in the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</param>
		/// <returns>true if item is found in the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />; otherwise, false.</returns>
		// Token: 0x060008CE RID: 2254 RVA: 0x000226C0 File Offset: 0x000208C0
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
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			for (int j = 0; j < this._size; j++)
			{
				if (@default.Equals(this._items[j], item))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Copies the elements of the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> to an <see cref="T:System.Array" />, starting at particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</param>
		/// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
		// Token: 0x060008CF RID: 2255 RVA: 0x0002272C File Offset: 0x0002092C
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00008049 File Offset: 0x00006249
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</summary>
		/// <param name="item">The object to remove from the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</param>
		/// <returns>true if item was successfully removed from the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />; otherwise, false. This method also returns false if item is not found in the original <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</returns>
		// Token: 0x060008D1 RID: 2257 RVA: 0x00022744 File Offset: 0x00020944
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

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
		// Token: 0x060008D2 RID: 2258 RVA: 0x00022767 File Offset: 0x00020967
		public IEnumerator<T> GetEnumerator()
		{
			return new ReadOnlyCollectionBuilder<T>.Enumerator(this);
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x060008D3 RID: 2259 RVA: 0x0002276F File Offset: 0x0002096F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00008049 File Offset: 0x00006249
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>The position into which the new element was inserted.</returns>
		// Token: 0x060008D5 RID: 2261 RVA: 0x00022778 File Offset: 0x00020978
		int IList.Add(object value)
		{
			ReadOnlyCollectionBuilder<T>.ValidateNullValue(value, "value");
			try
			{
				this.Add((T)((object)value));
			}
			catch (InvalidCastException)
			{
				throw Error.InvalidTypeException(value, typeof(T), "value");
			}
			return this.Count - 1;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IList" /> contains a specific value.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060008D6 RID: 2262 RVA: 0x000227D0 File Offset: 0x000209D0
		bool IList.Contains(object value)
		{
			return ReadOnlyCollectionBuilder<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The object to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>The index of <paramref name="item" /> if found in the list; otherwise, –1.</returns>
		// Token: 0x060008D7 RID: 2263 RVA: 0x000227E8 File Offset: 0x000209E8
		int IList.IndexOf(object value)
		{
			if (ReadOnlyCollectionBuilder<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		/// <summary>Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="value">The object to insert into the <see cref="T:System.Collections.IList" />.</param>
		// Token: 0x060008D8 RID: 2264 RVA: 0x00022800 File Offset: 0x00020A00
		void IList.Insert(int index, object value)
		{
			ReadOnlyCollectionBuilder<T>.ValidateNullValue(value, "value");
			try
			{
				this.Insert(index, (T)((object)value));
			}
			catch (InvalidCastException)
			{
				throw Error.InvalidTypeException(value, typeof(T), "value");
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00008049 File Offset: 0x00006249
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Collections.IList" />.</param>
		// Token: 0x060008DA RID: 2266 RVA: 0x00022850 File Offset: 0x00020A50
		void IList.Remove(object value)
		{
			if (ReadOnlyCollectionBuilder<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		// Token: 0x17000183 RID: 387
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				ReadOnlyCollectionBuilder<T>.ValidateNullValue(value, "value");
				try
				{
					this[index] = (T)((object)value);
				}
				catch (InvalidCastException)
				{
					throw Error.InvalidTypeException(value, typeof(T), "value");
				}
			}
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1" /> to an array, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x060008DD RID: 2269 RVA: 0x000228C8 File Offset: 0x00020AC8
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("array");
			}
			Array.Copy(this._items, 0, array, index, this._size);
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00008049 File Offset: 0x00006249
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Copies the elements of the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> to a new array.</summary>
		/// <returns>An array containing copies of the elements of the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.</returns>
		// Token: 0x060008E0 RID: 2272 RVA: 0x00022900 File Offset: 0x00020B00
		public T[] ToArray()
		{
			T[] array = new T[this._size];
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>Creates a <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> containing all of the elements of the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />, avoiding copying the elements to the new array if possible. Resets the <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> after the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> has been created.</summary>
		/// <returns>A new instance of <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</returns>
		// Token: 0x060008E1 RID: 2273 RVA: 0x00022930 File Offset: 0x00020B30
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			T[] list;
			if (this._size == this._items.Length)
			{
				list = this._items;
			}
			else
			{
				list = this.ToArray();
			}
			this._items = Array.Empty<T>();
			this._size = 0;
			this._version++;
			return new TrueReadOnlyCollection<T>(list);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00022984 File Offset: 0x00020B84
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = 4;
				if (this._items.Length != 0)
				{
					num = this._items.Length * 2;
				}
				if (num < min)
				{
					num = min;
				}
				this.Capacity = num;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000229C0 File Offset: 0x00020BC0
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000229F0 File Offset: 0x00020BF0
		private static void ValidateNullValue(object value, string argument)
		{
			if (value == null && default(T) != null)
			{
				throw Error.InvalidNullValue(typeof(T), argument);
			}
		}

		// Token: 0x040002A0 RID: 672
		private T[] _items;

		// Token: 0x040002A1 RID: 673
		private int _size;

		// Token: 0x040002A2 RID: 674
		private int _version;

		// Token: 0x0200010B RID: 267
		[Serializable]
		private class Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x060008E5 RID: 2277 RVA: 0x00022A21 File Offset: 0x00020C21
			internal Enumerator(ReadOnlyCollectionBuilder<T> builder)
			{
				this._builder = builder;
				this._version = builder._version;
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00022A4F File Offset: 0x00020C4F
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x000073D5 File Offset: 0x000055D5
			public void Dispose()
			{
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00022A57 File Offset: 0x00020C57
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index > this._builder._size)
					{
						throw Error.EnumerationIsDone();
					}
					return this._current;
				}
			}

			// Token: 0x060008E9 RID: 2281 RVA: 0x00022A88 File Offset: 0x00020C88
			public bool MoveNext()
			{
				if (this._version != this._builder._version)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
				if (this._index < this._builder._size)
				{
					T[] items = this._builder._items;
					int index = this._index;
					this._index = index + 1;
					this._current = items[index];
					return true;
				}
				this._index = this._builder._size + 1;
				this._current = default(T);
				return false;
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x00022B0A File Offset: 0x00020D0A
			void IEnumerator.Reset()
			{
				if (this._version != this._builder._version)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x040002A3 RID: 675
			private readonly ReadOnlyCollectionBuilder<T> _builder;

			// Token: 0x040002A4 RID: 676
			private readonly int _version;

			// Token: 0x040002A5 RID: 677
			private int _index;

			// Token: 0x040002A6 RID: 678
			private T _current;
		}
	}
}
