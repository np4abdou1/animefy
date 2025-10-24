using System;

namespace System.Collections
{
	/// <summary>Provides the <see langword="abstract" /> base class for a strongly typed collection.</summary>
	// Token: 0x020005DF RID: 1503
	[Serializable]
	public abstract class CollectionBase : IList, ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CollectionBase" /> class with the default initial capacity.</summary>
		// Token: 0x06002CB2 RID: 11442 RVA: 0x000B8311 File Offset: 0x000B6511
		protected CollectionBase()
		{
			this._list = new ArrayList();
		}

		/// <summary>Gets an <see cref="T:System.Collections.ArrayList" /> containing the list of elements in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.ArrayList" /> representing the <see cref="T:System.Collections.CollectionBase" /> instance itself.Retrieving the value of this property is an O(1) operation.</returns>
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000B8324 File Offset: 0x000B6524
		protected ArrayList InnerList
		{
			get
			{
				return this._list;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.IList" /> containing the list of elements in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> representing the <see cref="T:System.Collections.CollectionBase" /> instance itself.</returns>
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x0000245A File Offset: 0x0000065A
		protected IList List
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.CollectionBase" /> instance. This property cannot be overridden.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.CollectionBase" /> instance.Retrieving the value of this property is an O(1) operation.</returns>
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000B832C File Offset: 0x000B652C
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Removes all objects from the <see cref="T:System.Collections.CollectionBase" /> instance. This method cannot be overridden.</summary>
		// Token: 0x06002CB6 RID: 11446 RVA: 0x000B8339 File Offset: 0x000B6539
		public void Clear()
		{
			this.OnClear();
			this.InnerList.Clear();
			this.OnClearComplete();
		}

		/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.CollectionBase" /> instance. This method is not overridable.</summary>
		/// <param name="index">The zero-based index of the element to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		// Token: 0x06002CB7 RID: 11447 RVA: 0x000B8354 File Offset: 0x000B6554
		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			object value = this.InnerList[index];
			this.OnValidate(value);
			this.OnRemove(index, value);
			this.InnerList.RemoveAt(index);
			try
			{
				this.OnRemoveComplete(index, value);
			}
			catch
			{
				this.InnerList.Insert(index, value);
				throw;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.CollectionBase" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.CollectionBase" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000B83D0 File Offset: 0x000B65D0
		bool IList.IsReadOnly
		{
			get
			{
				return this.InnerList.IsReadOnly;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.CollectionBase" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.CollectionBase" /> has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000B83DD File Offset: 0x000B65DD
		bool IList.IsFixedSize
		{
			get
			{
				return this.InnerList.IsFixedSize;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.CollectionBase" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.CollectionBase" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x000B83EA File Offset: 0x000B65EA
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.InnerList.IsSynchronized;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.CollectionBase" />.</returns>
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000B83F7 File Offset: 0x000B65F7
		object ICollection.SyncRoot
		{
			get
			{
				return this.InnerList.SyncRoot;
			}
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.CollectionBase" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.CollectionBase" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source <see cref="T:System.Collections.CollectionBase" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.CollectionBase" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x06002CBC RID: 11452 RVA: 0x000B8404 File Offset: 0x000B6604
		void ICollection.CopyTo(Array array, int index)
		{
			this.InnerList.CopyTo(array, index);
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		// Token: 0x170006DD RID: 1757
		object IList.this[int index]
		{
			get
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				return this.InnerList[index];
			}
			set
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this.OnValidate(value);
				object obj = this.InnerList[index];
				this.OnSet(index, obj, value);
				this.InnerList[index] = value;
				try
				{
					this.OnSetComplete(index, obj, value);
				}
				catch
				{
					this.InnerList[index] = obj;
					throw;
				}
			}
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.CollectionBase" /> contains a specific element.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.CollectionBase" /> contains the specified <paramref name="value" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002CBF RID: 11455 RVA: 0x000B84C0 File Offset: 0x000B66C0
		bool IList.Contains(object value)
		{
			return this.InnerList.Contains(value);
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to be added to the end of the <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <returns>The <see cref="T:System.Collections.CollectionBase" /> index at which the <paramref name="value" /> has been added.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.CollectionBase" /> is read-only.-or-The <see cref="T:System.Collections.CollectionBase" /> has a fixed size.</exception>
		// Token: 0x06002CC0 RID: 11456 RVA: 0x000B84D0 File Offset: 0x000B66D0
		int IList.Add(object value)
		{
			this.OnValidate(value);
			this.OnInsert(this.InnerList.Count, value);
			int num = this.InnerList.Add(value);
			try
			{
				this.OnInsertComplete(num, value);
			}
			catch
			{
				this.InnerList.RemoveAt(num);
				throw;
			}
			return num;
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="value" /> parameter was not found in the <see cref="T:System.Collections.CollectionBase" /> object.</exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.CollectionBase" /> is read-only.-or-The <see cref="T:System.Collections.CollectionBase" /> has a fixed size.</exception>
		// Token: 0x06002CC1 RID: 11457 RVA: 0x000B8530 File Offset: 0x000B6730
		void IList.Remove(object value)
		{
			this.OnValidate(value);
			int num = this.InnerList.IndexOf(value);
			if (num < 0)
			{
				throw new ArgumentException("Cannot remove the specified item because it was not found in the specified Collection.");
			}
			this.OnRemove(num, value);
			this.InnerList.RemoveAt(num);
			try
			{
				this.OnRemoveComplete(num, value);
			}
			catch
			{
				this.InnerList.Insert(num, value);
				throw;
			}
		}

		/// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the entire <see cref="T:System.Collections.CollectionBase" />, if found; otherwise, -1.</returns>
		// Token: 0x06002CC2 RID: 11458 RVA: 0x000B85A0 File Offset: 0x000B67A0
		int IList.IndexOf(object value)
		{
			return this.InnerList.IndexOf(value);
		}

		/// <summary>Inserts an element into the <see cref="T:System.Collections.CollectionBase" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.CollectionBase" /> is read-only.-or-The <see cref="T:System.Collections.CollectionBase" /> has a fixed size.</exception>
		// Token: 0x06002CC3 RID: 11459 RVA: 0x000B85B0 File Offset: 0x000B67B0
		void IList.Insert(int index, object value)
		{
			if (index < 0 || index > this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this.OnValidate(value);
			this.OnInsert(index, value);
			this.InnerList.Insert(index, value);
			try
			{
				this.OnInsertComplete(index, value);
			}
			catch
			{
				this.InnerList.RemoveAt(index);
				throw;
			}
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.CollectionBase" /> instance.</returns>
		// Token: 0x06002CC4 RID: 11460 RVA: 0x000B8620 File Offset: 0x000B6820
		public IEnumerator GetEnumerator()
		{
			return this.InnerList.GetEnumerator();
		}

		/// <summary>Performs additional custom processes before setting a value in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index at which <paramref name="oldValue" /> can be found.</param>
		/// <param name="oldValue">The value to replace with <paramref name="newValue" />.</param>
		/// <param name="newValue">The new value of the element at <paramref name="index" />.</param>
		// Token: 0x06002CC5 RID: 11461 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnSet(int index, object oldValue, object newValue)
		{
		}

		/// <summary>Performs additional custom processes before inserting a new element into the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index at which to insert <paramref name="value" />.</param>
		/// <param name="value">The new value of the element at <paramref name="index" />.</param>
		// Token: 0x06002CC6 RID: 11462 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnInsert(int index, object value)
		{
		}

		/// <summary>Performs additional custom processes when clearing the contents of the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		// Token: 0x06002CC7 RID: 11463 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnClear()
		{
		}

		/// <summary>Performs additional custom processes when removing an element from the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> can be found.</param>
		/// <param name="value">The value of the element to remove from <paramref name="index" />.</param>
		// Token: 0x06002CC8 RID: 11464 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnRemove(int index, object value)
		{
		}

		/// <summary>Performs additional custom processes when validating a value.</summary>
		/// <param name="value">The object to validate.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x06002CC9 RID: 11465 RVA: 0x000B862D File Offset: 0x000B682D
		protected virtual void OnValidate(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
		}

		/// <summary>Performs additional custom processes after setting a value in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index at which <paramref name="oldValue" /> can be found.</param>
		/// <param name="oldValue">The value to replace with <paramref name="newValue" />.</param>
		/// <param name="newValue">The new value of the element at <paramref name="index" />.</param>
		// Token: 0x06002CCA RID: 11466 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnSetComplete(int index, object oldValue, object newValue)
		{
		}

		/// <summary>Performs additional custom processes after inserting a new element into the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index at which to insert <paramref name="value" />.</param>
		/// <param name="value">The new value of the element at <paramref name="index" />.</param>
		// Token: 0x06002CCB RID: 11467 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnInsertComplete(int index, object value)
		{
		}

		/// <summary>Performs additional custom processes after clearing the contents of the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		// Token: 0x06002CCC RID: 11468 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnClearComplete()
		{
		}

		/// <summary>Performs additional custom processes after removing an element from the <see cref="T:System.Collections.CollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> can be found.</param>
		/// <param name="value">The value of the element to remove from <paramref name="index" />.</param>
		// Token: 0x06002CCD RID: 11469 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void OnRemoveComplete(int index, object value)
		{
		}

		// Token: 0x0400186C RID: 6252
		private ArrayList _list;
	}
}
