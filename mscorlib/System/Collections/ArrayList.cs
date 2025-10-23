using System;
using System.Diagnostics;
using System.Threading;

namespace System.Collections
{
	/// <summary>Implements the <see cref="T:System.Collections.IList" /> interface using an array whose size is dynamically increased as required.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020005EF RID: 1519
	[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ArrayList : IList, ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06002D73 RID: 11635 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal ArrayList(bool trash)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that is empty and has the default initial capacity.</summary>
		// Token: 0x06002D74 RID: 11636 RVA: 0x000BA684 File Offset: 0x000B8884
		public ArrayList()
		{
			this._items = Array.Empty<object>();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that is empty and has the specified initial capacity.</summary>
		/// <param name="capacity">The number of elements that the new list can initially store. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero. </exception>
		// Token: 0x06002D75 RID: 11637 RVA: 0x000BA698 File Offset: 0x000B8898
		public ArrayList(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", SR.Format("'{0}' must be non-negative.", "capacity"));
			}
			if (capacity == 0)
			{
				this._items = Array.Empty<object>();
				return;
			}
			this._items = new object[capacity];
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.</summary>
		/// <param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements are copied to the new list. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="c" /> is <see langword="null" />. </exception>
		// Token: 0x06002D76 RID: 11638 RVA: 0x000BA6E4 File Offset: 0x000B88E4
		public ArrayList(ICollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException("c", "Collection cannot be null.");
			}
			int count = c.Count;
			if (count == 0)
			{
				this._items = Array.Empty<object>();
				return;
			}
			this._items = new object[count];
			this.AddRange(c);
		}

		/// <summary>Gets or sets the number of elements that the <see cref="T:System.Collections.ArrayList" /> can contain.</summary>
		/// <returns>The number of elements that the <see cref="T:System.Collections.ArrayList" /> can contain.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <see cref="P:System.Collections.ArrayList.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000BA733 File Offset: 0x000B8933
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x000BA740 File Offset: 0x000B8940
		public virtual int Capacity
		{
			get
			{
				return this._items.Length;
			}
			set
			{
				if (value < this._size)
				{
					throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						object[] array = new object[value];
						if (this._size > 0)
						{
							Array.Copy(this._items, 0, array, 0, this._size);
						}
						this._items = array;
						return;
					}
					this._items = new object[4];
				}
			}
		}

		/// <summary>Gets the number of elements actually contained in the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>The number of elements actually contained in the <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x000BA7AD File Offset: 0x000B89AD
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.ArrayList" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.ArrayList" /> has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.ArrayList" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.ArrayList" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ArrayList" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ArrayList" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x000BA7B5 File Offset: 0x000B89B5
		public virtual object SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set. </param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception>
		// Token: 0x17000715 RID: 1813
		public virtual object this[int index]
		{
			get
			{
				if (index < 0 || index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				return this._items[index];
			}
			set
			{
				if (index < 0 || index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this._items[index] = value;
				this._version++;
			}
		}

		/// <summary>Creates an <see cref="T:System.Collections.ArrayList" /> wrapper for a specific <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="list">The <see cref="T:System.Collections.IList" /> to wrap.</param>
		/// <returns>The <see cref="T:System.Collections.ArrayList" /> wrapper around the <see cref="T:System.Collections.IList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="list" /> is <see langword="null" />.</exception>
		// Token: 0x06002D80 RID: 11648 RVA: 0x000BA834 File Offset: 0x000B8A34
		public static ArrayList Adapter(IList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.IListWrapper(list);
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be added to the end of the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />. </param>
		/// <returns>The <see cref="T:System.Collections.ArrayList" /> index at which the <paramref name="value" /> has been added.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D81 RID: 11649 RVA: 0x000BA84C File Offset: 0x000B8A4C
		public virtual int Add(object value)
		{
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			this._items[this._size] = value;
			this._version++;
			int size = this._size;
			this._size = size + 1;
			return size;
		}

		/// <summary>Adds the elements of an <see cref="T:System.Collections.ICollection" /> to the end of the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements should be added to the end of the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be <see langword="null" />, but it can contain elements that are <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="c" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D82 RID: 11650 RVA: 0x000BA8A4 File Offset: 0x000B8AA4
		public virtual void AddRange(ICollection c)
		{
			this.InsertRange(this._size, c);
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D83 RID: 11651 RVA: 0x000BA8B3 File Offset: 0x000B8AB3
		public virtual void Clear()
		{
			if (this._size > 0)
			{
				Array.Clear(this._items, 0, this._size);
				this._size = 0;
			}
			this._version++;
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x06002D84 RID: 11652 RVA: 0x000BA8E8 File Offset: 0x000B8AE8
		public virtual object Clone()
		{
			ArrayList arrayList = new ArrayList(this._size);
			arrayList._size = this._size;
			arrayList._version = this._version;
			Array.Copy(this._items, 0, arrayList._items, 0, this._size);
			return arrayList;
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="item">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> is found in the <see cref="T:System.Collections.ArrayList" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002D85 RID: 11653 RVA: 0x000BA934 File Offset: 0x000B8B34
		public virtual bool Contains(object item)
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
			for (int j = 0; j < this._size; j++)
			{
				if (this._items[j] != null && this._items[j].Equals(item))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the beginning of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.ArrayList" /> is greater than the number of elements that the destination <paramref name="array" /> can contain. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002D86 RID: 11654 RVA: 0x000BA991 File Offset: 0x000B8B91
		public virtual void CopyTo(Array array)
		{
			this.CopyTo(array, 0);
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.ArrayList" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002D87 RID: 11655 RVA: 0x000BA99B File Offset: 0x000B8B9B
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		/// <summary>Copies a range of elements from the <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="index">The zero-based index in the source <see cref="T:System.Collections.ArrayList" /> at which copying begins. </param>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <param name="count">The number of elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="arrayIndex" /> is less than zero.-or- 
		///         <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- 
		///         <paramref name="index" /> is equal to or greater than the <see cref="P:System.Collections.ArrayList.Count" /> of the source <see cref="T:System.Collections.ArrayList" />.-or- The number of elements from <paramref name="index" /> to the end of the source <see cref="T:System.Collections.ArrayList" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002D88 RID: 11656 RVA: 0x000BA9D0 File Offset: 0x000B8BD0
		public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
		{
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			Array.Copy(this._items, index, array, arrayIndex, count);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000BAA20 File Offset: 0x000B8C20
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = (this._items.Length == 0) ? 4 : (this._items.Length * 2);
				if (num > 2146435071)
				{
					num = 2146435071;
				}
				if (num < min)
				{
					num = min;
				}
				this.Capacity = num;
			}
		}

		/// <summary>Returns an enumerator for the entire <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the entire <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x06002D8A RID: 11658 RVA: 0x000BAA6A File Offset: 0x000B8C6A
		public virtual IEnumerator GetEnumerator()
		{
			return new ArrayList.ArrayListEnumeratorSimple(this);
		}

		/// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />. </param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the entire <see cref="T:System.Collections.ArrayList" />, if found; otherwise, -1.</returns>
		// Token: 0x06002D8B RID: 11659 RVA: 0x000BAA72 File Offset: 0x000B8C72
		public virtual int IndexOf(object value)
		{
			return Array.IndexOf(this._items, value, 0, this._size);
		}

		/// <summary>Inserts an element into the <see cref="T:System.Collections.ArrayList" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D8C RID: 11660 RVA: 0x000BAA88 File Offset: 0x000B8C88
		public virtual void Insert(int index, object value)
		{
			if (index < 0 || index > this._size)
			{
				throw new ArgumentOutOfRangeException("index", "Insertion index was out of range. Must be non-negative and less than or equal to size.");
			}
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = value;
			this._size++;
			this._version++;
		}

		/// <summary>Inserts the elements of a collection into the <see cref="T:System.Collections.ArrayList" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which the new elements should be inserted. </param>
		/// <param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements should be inserted into the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be <see langword="null" />, but it can contain elements that are <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="c" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D8D RID: 11661 RVA: 0x000BAB1C File Offset: 0x000B8D1C
		public virtual void InsertRange(int index, ICollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException("c", "Collection cannot be null.");
			}
			if (index < 0 || index > this._size)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int count = c.Count;
			if (count > 0)
			{
				this.EnsureCapacity(this._size + count);
				if (index < this._size)
				{
					Array.Copy(this._items, index, this._items, index + count, this._size - index);
				}
				object[] array = new object[count];
				c.CopyTo(array, 0);
				array.CopyTo(this._items, index);
				this._size += count;
				this._version++;
			}
		}

		/// <summary>Returns a read-only <see cref="T:System.Collections.ArrayList" /> wrapper.</summary>
		/// <param name="list">The <see cref="T:System.Collections.ArrayList" /> to wrap. </param>
		/// <returns>A read-only <see cref="T:System.Collections.ArrayList" /> wrapper around <paramref name="list" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="list" /> is <see langword="null" />. </exception>
		// Token: 0x06002D8E RID: 11662 RVA: 0x000BABD0 File Offset: 0x000B8DD0
		public static ArrayList ReadOnly(ArrayList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.ReadOnlyArrayList(list);
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D8F RID: 11663 RVA: 0x000BABE8 File Offset: 0x000B8DE8
		public virtual void Remove(object obj)
		{
			int num = this.IndexOf(obj);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="index">The zero-based index of the element to remove. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D90 RID: 11664 RVA: 0x000BAC08 File Offset: 0x000B8E08
		public virtual void RemoveAt(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			this._items[this._size] = null;
			this._version++;
		}

		/// <summary>Removes a range of elements from the <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="index">The zero-based starting index of the range of elements to remove. </param>
		/// <param name="count">The number of elements to remove. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.ArrayList" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception>
		// Token: 0x06002D91 RID: 11665 RVA: 0x000BAC84 File Offset: 0x000B8E84
		public virtual void RemoveRange(int index, int count)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (count > 0)
			{
				int i = this._size;
				this._size -= count;
				if (index < this._size)
				{
					Array.Copy(this._items, index + count, this._items, index, this._size - index);
				}
				while (i > this._size)
				{
					this._items[--i] = null;
				}
				this._version++;
			}
		}

		/// <summary>Sorts the elements in the entire <see cref="T:System.Collections.ArrayList" /> using the specified comparer.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- A null reference (<see langword="Nothing" /> in Visual Basic) to use the <see cref="T:System.IComparable" /> implementation of each element. </param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only. </exception>
		/// <exception cref="T:System.InvalidOperationException">An error occurred while comparing two elements.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <see langword="null" /> is passed for <paramref name="comparer" />, and the elements in the list do not implement <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06002D92 RID: 11666 RVA: 0x000BAD34 File Offset: 0x000B8F34
		public virtual void Sort(IComparer comparer)
		{
			this.Sort(0, this.Count, comparer);
		}

		/// <summary>Sorts the elements in a range of elements in <see cref="T:System.Collections.ArrayList" /> using the specified comparer.</summary>
		/// <param name="index">The zero-based starting index of the range to sort. </param>
		/// <param name="count">The length of the range to sort. </param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- A null reference (<see langword="Nothing" /> in Visual Basic) to use the <see cref="T:System.IComparable" /> implementation of each element. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the <see cref="T:System.Collections.ArrayList" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only. </exception>
		/// <exception cref="T:System.InvalidOperationException">An error occurred while comparing two elements.</exception>
		// Token: 0x06002D93 RID: 11667 RVA: 0x000BAD44 File Offset: 0x000B8F44
		public virtual void Sort(int index, int count, IComparer comparer)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			Array.Sort(this._items, index, count, comparer);
			this._version++;
		}

		/// <summary>Returns an <see cref="T:System.Collections.ArrayList" /> wrapper that is synchronized (thread safe).</summary>
		/// <param name="list">The <see cref="T:System.Collections.ArrayList" /> to synchronize. </param>
		/// <returns>An <see cref="T:System.Collections.ArrayList" /> wrapper that is synchronized (thread safe).</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="list" /> is <see langword="null" />. </exception>
		// Token: 0x06002D94 RID: 11668 RVA: 0x000BADAB File Offset: 0x000B8FAB
		public static ArrayList Synchronized(ArrayList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.SyncArrayList(list);
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ArrayList" /> to a new <see cref="T:System.Object" /> array.</summary>
		/// <returns>An <see cref="T:System.Object" /> array containing copies of the elements of the <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x06002D95 RID: 11669 RVA: 0x000BADC4 File Offset: 0x000B8FC4
		public virtual object[] ToArray()
		{
			if (this._size == 0)
			{
				return Array.Empty<object>();
			}
			object[] array = new object[this._size];
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ArrayList" /> to a new array of the specified element type.</summary>
		/// <param name="type">The element <see cref="T:System.Type" /> of the destination array to create and copy elements to.</param>
		/// <returns>An array of the specified element type containing copies of the elements of the <see cref="T:System.Collections.ArrayList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the specified type. </exception>
		// Token: 0x06002D96 RID: 11670 RVA: 0x000BAE00 File Offset: 0x000B9000
		public virtual Array ToArray(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			Array array = Array.CreateInstance(type, this._size);
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		// Token: 0x0400189E RID: 6302
		private object[] _items;

		// Token: 0x0400189F RID: 6303
		private int _size;

		// Token: 0x040018A0 RID: 6304
		private int _version;

		// Token: 0x040018A1 RID: 6305
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020005F0 RID: 1520
		[Serializable]
		private class IListWrapper : ArrayList
		{
			// Token: 0x06002D97 RID: 11671 RVA: 0x000BAE43 File Offset: 0x000B9043
			internal IListWrapper(IList list)
			{
				this._list = list;
				this._version = 0;
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000BAE59 File Offset: 0x000B9059
			// (set) Token: 0x06002D99 RID: 11673 RVA: 0x000BAE66 File Offset: 0x000B9066
			public override int Capacity
			{
				get
				{
					return this._list.Count;
				}
				set
				{
					if (value < this.Count)
					{
						throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
					}
				}
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000BAE59 File Offset: 0x000B9059
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000BAE81 File Offset: 0x000B9081
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000BAE8E File Offset: 0x000B908E
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000BAE9B File Offset: 0x000B909B
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x1700071B RID: 1819
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
					this._version++;
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000BAED3 File Offset: 0x000B90D3
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06002DA1 RID: 11681 RVA: 0x000BAEE0 File Offset: 0x000B90E0
			public override int Add(object obj)
			{
				int result = this._list.Add(obj);
				this._version++;
				return result;
			}

			// Token: 0x06002DA2 RID: 11682 RVA: 0x000BAEFC File Offset: 0x000B90FC
			public override void AddRange(ICollection c)
			{
				this.InsertRange(this.Count, c);
			}

			// Token: 0x06002DA3 RID: 11683 RVA: 0x000BAF0B File Offset: 0x000B910B
			public override void Clear()
			{
				if (this._list.IsFixedSize)
				{
					throw new NotSupportedException("Collection was of a fixed size.");
				}
				this._list.Clear();
				this._version++;
			}

			// Token: 0x06002DA4 RID: 11684 RVA: 0x000BAF3E File Offset: 0x000B913E
			public override object Clone()
			{
				return new ArrayList.IListWrapper(this._list);
			}

			// Token: 0x06002DA5 RID: 11685 RVA: 0x000BAF4B File Offset: 0x000B914B
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06002DA6 RID: 11686 RVA: 0x000BAF59 File Offset: 0x000B9159
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06002DA7 RID: 11687 RVA: 0x000BAF68 File Offset: 0x000B9168
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0 || arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "arrayIndex", "Non-negative number required.");
				}
				if (count < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				for (int i = index; i < index + count; i++)
				{
					array.SetValue(this._list[i], arrayIndex++);
				}
			}

			// Token: 0x06002DA8 RID: 11688 RVA: 0x000BB02E File Offset: 0x000B922E
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06002DA9 RID: 11689 RVA: 0x000BB03B File Offset: 0x000B923B
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06002DAA RID: 11690 RVA: 0x000BB049 File Offset: 0x000B9249
			public override void Insert(int index, object obj)
			{
				this._list.Insert(index, obj);
				this._version++;
			}

			// Token: 0x06002DAB RID: 11691 RVA: 0x000BB068 File Offset: 0x000B9268
			public override void InsertRange(int index, ICollection c)
			{
				if (c == null)
				{
					throw new ArgumentNullException("c", "Collection cannot be null.");
				}
				if (index < 0 || index > this.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (c.Count > 0)
				{
					ArrayList arrayList = this._list as ArrayList;
					if (arrayList != null)
					{
						arrayList.InsertRange(index, c);
					}
					else
					{
						foreach (object value in c)
						{
							this._list.Insert(index++, value);
						}
					}
					this._version++;
				}
			}

			// Token: 0x06002DAC RID: 11692 RVA: 0x000BB100 File Offset: 0x000B9300
			public override void Remove(object value)
			{
				int num = this.IndexOf(value);
				if (num >= 0)
				{
					this.RemoveAt(num);
				}
			}

			// Token: 0x06002DAD RID: 11693 RVA: 0x000BB120 File Offset: 0x000B9320
			public override void RemoveAt(int index)
			{
				this._list.RemoveAt(index);
				this._version++;
			}

			// Token: 0x06002DAE RID: 11694 RVA: 0x000BB13C File Offset: 0x000B933C
			public override void RemoveRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (count > 0)
				{
					this._version++;
				}
				while (count > 0)
				{
					this._list.RemoveAt(index);
					count--;
				}
			}

			// Token: 0x06002DAF RID: 11695 RVA: 0x000BB1B0 File Offset: 0x000B93B0
			public override void Sort(int index, int count, IComparer comparer)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				object[] array = new object[count];
				this.CopyTo(index, array, 0, count);
				Array.Sort(array, 0, count, comparer);
				for (int i = 0; i < count; i++)
				{
					this._list[i + index] = array[i];
				}
				this._version++;
			}

			// Token: 0x06002DB0 RID: 11696 RVA: 0x000BB240 File Offset: 0x000B9440
			public override object[] ToArray()
			{
				if (this.Count == 0)
				{
					return Array.Empty<object>();
				}
				object[] array = new object[this.Count];
				this._list.CopyTo(array, 0);
				return array;
			}

			// Token: 0x06002DB1 RID: 11697 RVA: 0x000BB278 File Offset: 0x000B9478
			public override Array ToArray(Type type)
			{
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				Array array = Array.CreateInstance(type, this._list.Count);
				this._list.CopyTo(array, 0);
				return array;
			}

			// Token: 0x040018A2 RID: 6306
			private IList _list;
		}

		// Token: 0x020005F1 RID: 1521
		[Serializable]
		private class SyncArrayList : ArrayList
		{
			// Token: 0x06002DB2 RID: 11698 RVA: 0x000BB2B9 File Offset: 0x000B94B9
			internal SyncArrayList(ArrayList list) : base(false)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x000BB2D8 File Offset: 0x000B94D8
			// (set) Token: 0x06002DB4 RID: 11700 RVA: 0x000BB320 File Offset: 0x000B9520
			public override int Capacity
			{
				get
				{
					object root = this._root;
					int capacity;
					lock (root)
					{
						capacity = this._list.Capacity;
					}
					return capacity;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list.Capacity = value;
					}
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x000BB368 File Offset: 0x000B9568
			public override int Count
			{
				get
				{
					object root = this._root;
					int count;
					lock (root)
					{
						count = this._list.Count;
					}
					return count;
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000BB3B0 File Offset: 0x000B95B0
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x000BB3BD File Offset: 0x000B95BD
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000722 RID: 1826
			public override object this[int index]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[index];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[index] = value;
					}
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000BB45C File Offset: 0x000B965C
			public override object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x06002DBC RID: 11708 RVA: 0x000BB464 File Offset: 0x000B9664
			public override int Add(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.Add(value);
				}
				return result;
			}

			// Token: 0x06002DBD RID: 11709 RVA: 0x000BB4AC File Offset: 0x000B96AC
			public override void AddRange(ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.AddRange(c);
				}
			}

			// Token: 0x06002DBE RID: 11710 RVA: 0x000BB4F4 File Offset: 0x000B96F4
			public override void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06002DBF RID: 11711 RVA: 0x000BB53C File Offset: 0x000B973C
			public override object Clone()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = new ArrayList.SyncArrayList((ArrayList)this._list.Clone());
				}
				return result;
			}

			// Token: 0x06002DC0 RID: 11712 RVA: 0x000BB590 File Offset: 0x000B9790
			public override bool Contains(object item)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(item);
				}
				return result;
			}

			// Token: 0x06002DC1 RID: 11713 RVA: 0x000BB5D8 File Offset: 0x000B97D8
			public override void CopyTo(Array array)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array);
				}
			}

			// Token: 0x06002DC2 RID: 11714 RVA: 0x000BB620 File Offset: 0x000B9820
			public override void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06002DC3 RID: 11715 RVA: 0x000BB668 File Offset: 0x000B9868
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(index, array, arrayIndex, count);
				}
			}

			// Token: 0x06002DC4 RID: 11716 RVA: 0x000BB6B4 File Offset: 0x000B98B4
			public override IEnumerator GetEnumerator()
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06002DC5 RID: 11717 RVA: 0x000BB6FC File Offset: 0x000B98FC
			public override int IndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value);
				}
				return result;
			}

			// Token: 0x06002DC6 RID: 11718 RVA: 0x000BB744 File Offset: 0x000B9944
			public override void Insert(int index, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Insert(index, value);
				}
			}

			// Token: 0x06002DC7 RID: 11719 RVA: 0x000BB78C File Offset: 0x000B998C
			public override void InsertRange(int index, ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.InsertRange(index, c);
				}
			}

			// Token: 0x06002DC8 RID: 11720 RVA: 0x000BB7D4 File Offset: 0x000B99D4
			public override void Remove(object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(value);
				}
			}

			// Token: 0x06002DC9 RID: 11721 RVA: 0x000BB81C File Offset: 0x000B9A1C
			public override void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x06002DCA RID: 11722 RVA: 0x000BB864 File Offset: 0x000B9A64
			public override void RemoveRange(int index, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveRange(index, count);
				}
			}

			// Token: 0x06002DCB RID: 11723 RVA: 0x000BB8AC File Offset: 0x000B9AAC
			public override void Sort(IComparer comparer)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort(comparer);
				}
			}

			// Token: 0x06002DCC RID: 11724 RVA: 0x000BB8F4 File Offset: 0x000B9AF4
			public override void Sort(int index, int count, IComparer comparer)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort(index, count, comparer);
				}
			}

			// Token: 0x06002DCD RID: 11725 RVA: 0x000BB93C File Offset: 0x000B9B3C
			public override object[] ToArray()
			{
				object root = this._root;
				object[] result;
				lock (root)
				{
					result = this._list.ToArray();
				}
				return result;
			}

			// Token: 0x06002DCE RID: 11726 RVA: 0x000BB984 File Offset: 0x000B9B84
			public override Array ToArray(Type type)
			{
				object root = this._root;
				Array result;
				lock (root)
				{
					result = this._list.ToArray(type);
				}
				return result;
			}

			// Token: 0x040018A3 RID: 6307
			private ArrayList _list;

			// Token: 0x040018A4 RID: 6308
			private object _root;
		}

		// Token: 0x020005F2 RID: 1522
		[Serializable]
		private class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x06002DCF RID: 11727 RVA: 0x000BB9CC File Offset: 0x000B9BCC
			internal ReadOnlyArrayList(ArrayList l)
			{
				this._list = l;
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x000BB9DB File Offset: 0x000B9BDB
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x000BB9E8 File Offset: 0x000B9BE8
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17000728 RID: 1832
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					throw new NotSupportedException("Collection is read-only.");
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x000BBA0F File Offset: 0x000B9C0F
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06002DD7 RID: 11735 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override int Add(object obj)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DD8 RID: 11736 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void AddRange(ICollection c)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000BBA1C File Offset: 0x000B9C1C
			// (set) Token: 0x06002DDA RID: 11738 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override int Capacity
			{
				get
				{
					return this._list.Capacity;
				}
				set
				{
					throw new NotSupportedException("Collection is read-only.");
				}
			}

			// Token: 0x06002DDB RID: 11739 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DDC RID: 11740 RVA: 0x000BBA29 File Offset: 0x000B9C29
			public override object Clone()
			{
				return new ArrayList.ReadOnlyArrayList(this._list)
				{
					_list = (ArrayList)this._list.Clone()
				};
			}

			// Token: 0x06002DDD RID: 11741 RVA: 0x000BBA4C File Offset: 0x000B9C4C
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06002DDE RID: 11742 RVA: 0x000BBA5A File Offset: 0x000B9C5A
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06002DDF RID: 11743 RVA: 0x000BBA69 File Offset: 0x000B9C69
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				this._list.CopyTo(index, array, arrayIndex, count);
			}

			// Token: 0x06002DE0 RID: 11744 RVA: 0x000BBA7B File Offset: 0x000B9C7B
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06002DE1 RID: 11745 RVA: 0x000BBA88 File Offset: 0x000B9C88
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06002DE2 RID: 11746 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void Insert(int index, object obj)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DE3 RID: 11747 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void InsertRange(int index, ICollection c)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DE4 RID: 11748 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void Remove(object value)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DE5 RID: 11749 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void RemoveAt(int index)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DE6 RID: 11750 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void RemoveRange(int index, int count)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DE7 RID: 11751 RVA: 0x000BBA03 File Offset: 0x000B9C03
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002DE8 RID: 11752 RVA: 0x000BBA96 File Offset: 0x000B9C96
			public override object[] ToArray()
			{
				return this._list.ToArray();
			}

			// Token: 0x06002DE9 RID: 11753 RVA: 0x000BBAA3 File Offset: 0x000B9CA3
			public override Array ToArray(Type type)
			{
				return this._list.ToArray(type);
			}

			// Token: 0x040018A5 RID: 6309
			private ArrayList _list;
		}

		// Token: 0x020005F3 RID: 1523
		[Serializable]
		private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
		{
			// Token: 0x06002DEA RID: 11754 RVA: 0x000BBAB4 File Offset: 0x000B9CB4
			internal ArrayListEnumeratorSimple(ArrayList list)
			{
				this._list = list;
				this._index = -1;
				this._version = list._version;
				this._isArrayList = (list.GetType() == typeof(ArrayList));
				this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
			}

			// Token: 0x06002DEB RID: 11755 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06002DEC RID: 11756 RVA: 0x000BBB08 File Offset: 0x000B9D08
			public bool MoveNext()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._isArrayList)
				{
					if (this._index < this._list._size - 1)
					{
						object[] items = this._list._items;
						int num = this._index + 1;
						this._index = num;
						this._currentElement = items[num];
						return true;
					}
					this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
					this._index = this._list._size;
					return false;
				}
				else
				{
					if (this._index < this._list.Count - 1)
					{
						ArrayList list = this._list;
						int num = this._index + 1;
						this._index = num;
						this._currentElement = list[num];
						return true;
					}
					this._index = this._list.Count;
					this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
					return false;
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06002DED RID: 11757 RVA: 0x000BBBEC File Offset: 0x000B9DEC
			public object Current
			{
				get
				{
					object currentElement = this._currentElement;
					if (ArrayList.ArrayListEnumeratorSimple.s_dummyObject != currentElement)
					{
						return currentElement;
					}
					if (this._index == -1)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					throw new InvalidOperationException("Enumeration already finished.");
				}
			}

			// Token: 0x06002DEE RID: 11758 RVA: 0x000BBC28 File Offset: 0x000B9E28
			public void Reset()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
				this._index = -1;
			}

			// Token: 0x040018A6 RID: 6310
			private ArrayList _list;

			// Token: 0x040018A7 RID: 6311
			private int _index;

			// Token: 0x040018A8 RID: 6312
			private int _version;

			// Token: 0x040018A9 RID: 6313
			private object _currentElement;

			// Token: 0x040018AA RID: 6314
			private bool _isArrayList;

			// Token: 0x040018AB RID: 6315
			private static object s_dummyObject = new object();
		}

		// Token: 0x020005F4 RID: 1524
		internal class ArrayListDebugView
		{
		}
	}
}
