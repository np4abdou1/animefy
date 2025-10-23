using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections
{
	/// <summary>Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.</summary>
	// Token: 0x020005E4 RID: 1508
	[DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the default initial capacity, and is sorted according to the <see cref="T:System.IComparable" /> interface implemented by each key added to the <see cref="T:System.Collections.SortedList" /> object.</summary>
		// Token: 0x06002CE9 RID: 11497 RVA: 0x000B8CAF File Offset: 0x000B6EAF
		public SortedList()
		{
			this.Init();
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000B8CBD File Offset: 0x000B6EBD
		private void Init()
		{
			this.keys = Array.Empty<object>();
			this.values = Array.Empty<object>();
			this._size = 0;
			this.comparer = new Comparer(CultureInfo.CurrentCulture);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the specified initial capacity, and is sorted according to the <see cref="T:System.IComparable" /> interface implemented by each key added to the <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="initialCapacity">The initial number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="initialCapacity" /> is less than zero. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough available memory to create a <see cref="T:System.Collections.SortedList" /> object with the specified <paramref name="initialCapacity" />.</exception>
		// Token: 0x06002CEB RID: 11499 RVA: 0x000B8CEC File Offset: 0x000B6EEC
		public SortedList(int initialCapacity)
		{
			if (initialCapacity < 0)
			{
				throw new ArgumentOutOfRangeException("initialCapacity", "Non-negative number required.");
			}
			this.keys = new object[initialCapacity];
			this.values = new object[initialCapacity];
			this.comparer = new Comparer(CultureInfo.CurrentCulture);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the default initial capacity, and is sorted according to the specified <see cref="T:System.Collections.IComparer" /> interface.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing keys.-or- 
		///       <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each key. </param>
		// Token: 0x06002CEC RID: 11500 RVA: 0x000B8D3B File Offset: 0x000B6F3B
		public SortedList(IComparer comparer) : this()
		{
			if (comparer != null)
			{
				this.comparer = comparer;
			}
		}

		/// <summary>Adds an element with the specified key and value to a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="key">The key of the element to add. </param>
		/// <param name="value">The value of the element to add. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">An element with the specified <paramref name="key" /> already exists in the <see cref="T:System.Collections.SortedList" /> object.-or- The <see cref="T:System.Collections.SortedList" /> is set to use the <see cref="T:System.IComparable" /> interface, and <paramref name="key" /> does not implement the <see cref="T:System.IComparable" /> interface. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough available memory to add the element to the <see cref="T:System.Collections.SortedList" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception>
		// Token: 0x06002CED RID: 11501 RVA: 0x000B8D50 File Offset: 0x000B6F50
		public virtual void Add(object key, object value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			int num = Array.BinarySearch(this.keys, 0, this._size, key, this.comparer);
			if (num >= 0)
			{
				throw new ArgumentException(SR.Format("Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'", this.GetKey(num), key));
			}
			this.Insert(~num, key, value);
		}

		/// <summary>Gets or sets the capacity of a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>The number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value assigned is less than the current number of elements in the <see cref="T:System.Collections.SortedList" /> object.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
		// Token: 0x170006E6 RID: 1766
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x000B8DB0 File Offset: 0x000B6FB0
		public virtual int Capacity
		{
			set
			{
				if (value < this.Count)
				{
					throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
				}
				if (value != this.keys.Length)
				{
					if (value > 0)
					{
						object[] destinationArray = new object[value];
						object[] destinationArray2 = new object[value];
						if (this._size > 0)
						{
							Array.Copy(this.keys, 0, destinationArray, 0, this._size);
							Array.Copy(this.values, 0, destinationArray2, 0, this._size);
						}
						this.keys = destinationArray;
						this.values = destinationArray2;
						return;
					}
					this.keys = Array.Empty<object>();
					this.values = Array.Empty<object>();
				}
			}
		}

		/// <summary>Gets the number of elements contained in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000B8E49 File Offset: 0x000B7049
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Gets the keys in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000B8E51 File Offset: 0x000B7051
		public virtual ICollection Keys
		{
			get
			{
				return this.GetKeyList();
			}
		}

		/// <summary>Gets the values in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000B8E59 File Offset: 0x000B7059
		public virtual ICollection Values
		{
			get
			{
				return this.GetValueList();
			}
		}

		/// <summary>Gets a value indicating whether a <see cref="T:System.Collections.SortedList" /> object is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether a <see cref="T:System.Collections.SortedList" /> object has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether access to a <see cref="T:System.Collections.SortedList" /> object is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.SortedList" /> object is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000B8E61 File Offset: 0x000B7061
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

		/// <summary>Removes all elements from a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> object is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception>
		// Token: 0x06002CF6 RID: 11510 RVA: 0x000B8E83 File Offset: 0x000B7083
		public virtual void Clear()
		{
			this.version++;
			Array.Clear(this.keys, 0, this._size);
			Array.Clear(this.values, 0, this._size);
			this._size = 0;
		}

		/// <summary>Creates a shallow copy of a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x06002CF7 RID: 11511 RVA: 0x000B8EC0 File Offset: 0x000B70C0
		public virtual object Clone()
		{
			SortedList sortedList = new SortedList(this._size);
			Array.Copy(this.keys, 0, sortedList.keys, 0, this._size);
			Array.Copy(this.values, 0, sortedList.values, 0, this._size);
			sortedList._size = this._size;
			sortedList.version = this.version;
			sortedList.comparer = this.comparer;
			return sortedList;
		}

		/// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="key" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception>
		// Token: 0x06002CF8 RID: 11512 RVA: 0x000B8F30 File Offset: 0x000B7130
		public virtual bool Contains(object key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		/// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="key" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception>
		// Token: 0x06002CF9 RID: 11513 RVA: 0x000B8F30 File Offset: 0x000B7130
		public virtual bool ContainsKey(object key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		/// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific value.</summary>
		/// <param name="value">The value to locate in the <see cref="T:System.Collections.SortedList" /> object. The value can be <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="value" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002CFA RID: 11514 RVA: 0x000B8F3F File Offset: 0x000B713F
		public virtual bool ContainsValue(object value)
		{
			return this.IndexOfValue(value) >= 0;
		}

		/// <summary>Copies <see cref="T:System.Collections.SortedList" /> elements to a one-dimensional <see cref="T:System.Array" /> object, starting at the specified index in the array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> object that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.SortedList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.SortedList" /> object is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.SortedList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002CFB RID: 11515 RVA: 0x000B8F50 File Offset: 0x000B7150
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Array cannot be null.");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
			}
			if (array.Length - arrayIndex < this.Count)
			{
				throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				DictionaryEntry dictionaryEntry = new DictionaryEntry(this.keys[i], this.values[i]);
				array.SetValue(dictionaryEntry, i + arrayIndex);
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000B8FF0 File Offset: 0x000B71F0
		private void EnsureCapacity(int min)
		{
			int num = (this.keys.Length == 0) ? 16 : (this.keys.Length * 2);
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

		/// <summary>Gets the value at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="index">The zero-based index of the value to get. </param>
		/// <returns>The value at the specified index of the <see cref="T:System.Collections.SortedList" /> object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object. </exception>
		// Token: 0x06002CFD RID: 11517 RVA: 0x000B9030 File Offset: 0x000B7230
		public virtual object GetByIndex(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return this.values[index];
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that iterates through the <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x06002CFE RID: 11518 RVA: 0x000B9057 File Offset: 0x000B7257
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SortedList.SortedListEnumerator(this, 0, this._size, 3);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object that iterates through a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x06002CFF RID: 11519 RVA: 0x000B9057 File Offset: 0x000B7257
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new SortedList.SortedListEnumerator(this, 0, this._size, 3);
		}

		/// <summary>Gets the key at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="index">The zero-based index of the key to get. </param>
		/// <returns>The key at the specified index of the <see cref="T:System.Collections.SortedList" /> object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object.</exception>
		// Token: 0x06002D00 RID: 11520 RVA: 0x000B9067 File Offset: 0x000B7267
		public virtual object GetKey(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return this.keys[index];
		}

		/// <summary>Gets the keys in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> object containing the keys in the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x06002D01 RID: 11521 RVA: 0x000B908E File Offset: 0x000B728E
		public virtual IList GetKeyList()
		{
			if (this.keyList == null)
			{
				this.keyList = new SortedList.KeyList(this);
			}
			return this.keyList;
		}

		/// <summary>Gets the values in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> object containing the values in the <see cref="T:System.Collections.SortedList" /> object.</returns>
		// Token: 0x06002D02 RID: 11522 RVA: 0x000B90AA File Offset: 0x000B72AA
		public virtual IList GetValueList()
		{
			if (this.valueList == null)
			{
				this.valueList = new SortedList.ValueList(this);
			}
			return this.valueList;
		}

		/// <summary>Gets and sets the value associated with a specific key in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="key">The key associated with the value to get or set. </param>
		/// <returns>The value associated with the <paramref name="key" /> parameter in the <see cref="T:System.Collections.SortedList" /> object, if <paramref name="key" /> is found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.SortedList" /> object is read-only.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough available memory to add the element to the <see cref="T:System.Collections.SortedList" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception>
		// Token: 0x170006EE RID: 1774
		public virtual object this[object key]
		{
			get
			{
				int num = this.IndexOfKey(key);
				if (num >= 0)
				{
					return this.values[num];
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				int num = Array.BinarySearch(this.keys, 0, this._size, key, this.comparer);
				if (num >= 0)
				{
					this.values[num] = value;
					this.version++;
					return;
				}
				this.Insert(~num, key, value);
			}
		}

		/// <summary>Returns the zero-based index of the specified key in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object. </param>
		/// <returns>The zero-based index of the <paramref name="key" /> parameter, if <paramref name="key" /> is found in the <see cref="T:System.Collections.SortedList" /> object; otherwise, -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception>
		// Token: 0x06002D05 RID: 11525 RVA: 0x000B914C File Offset: 0x000B734C
		public virtual int IndexOfKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			int num = Array.BinarySearch(this.keys, 0, this._size, key, this.comparer);
			if (num < 0)
			{
				return -1;
			}
			return num;
		}

		/// <summary>Returns the zero-based index of the first occurrence of the specified value in a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="value">The value to locate in the <see cref="T:System.Collections.SortedList" /> object. The value can be <see langword="null" />. </param>
		/// <returns>The zero-based index of the first occurrence of the <paramref name="value" /> parameter, if <paramref name="value" /> is found in the <see cref="T:System.Collections.SortedList" /> object; otherwise, -1.</returns>
		// Token: 0x06002D06 RID: 11526 RVA: 0x000B918D File Offset: 0x000B738D
		public virtual int IndexOfValue(object value)
		{
			return Array.IndexOf<object>(this.values, value, 0, this._size);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000B91A4 File Offset: 0x000B73A4
		private void Insert(int index, object key, object value)
		{
			if (this._size == this.keys.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this.keys, index, this.keys, index + 1, this._size - index);
				Array.Copy(this.values, index, this.values, index + 1, this._size - index);
			}
			this.keys[index] = key;
			this.values[index] = value;
			this._size++;
			this.version++;
		}

		/// <summary>Removes the element at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="index">The zero-based index of the element to remove. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception>
		// Token: 0x06002D08 RID: 11528 RVA: 0x000B9240 File Offset: 0x000B7440
		public virtual void RemoveAt(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this.keys, index + 1, this.keys, index, this._size - index);
				Array.Copy(this.values, index + 1, this.values, index, this._size - index);
			}
			this.keys[this._size] = null;
			this.values[this._size] = null;
			this.version++;
		}

		/// <summary>Removes the element with the specified key from a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="key">The key of the element to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> object is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception>
		// Token: 0x06002D09 RID: 11529 RVA: 0x000B92E8 File Offset: 0x000B74E8
		public virtual void Remove(object key)
		{
			int num = this.IndexOfKey(key);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Returns a synchronized (thread-safe) wrapper for a <see cref="T:System.Collections.SortedList" /> object.</summary>
		/// <param name="list">The <see cref="T:System.Collections.SortedList" /> object to synchronize. </param>
		/// <returns>A synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.SortedList" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="list" /> is <see langword="null" />. </exception>
		// Token: 0x06002D0A RID: 11530 RVA: 0x000B9308 File Offset: 0x000B7508
		public static SortedList Synchronized(SortedList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new SortedList.SyncSortedList(list);
		}

		// Token: 0x04001879 RID: 6265
		private object[] keys;

		// Token: 0x0400187A RID: 6266
		private object[] values;

		// Token: 0x0400187B RID: 6267
		private int _size;

		// Token: 0x0400187C RID: 6268
		private int version;

		// Token: 0x0400187D RID: 6269
		private IComparer comparer;

		// Token: 0x0400187E RID: 6270
		private SortedList.KeyList keyList;

		// Token: 0x0400187F RID: 6271
		private SortedList.ValueList valueList;

		// Token: 0x04001880 RID: 6272
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020005E5 RID: 1509
		[Serializable]
		private class SyncSortedList : SortedList
		{
			// Token: 0x06002D0B RID: 11531 RVA: 0x000B931E File Offset: 0x000B751E
			internal SyncSortedList(SortedList list)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000B933C File Offset: 0x000B753C
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

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000B9384 File Offset: 0x000B7584
			public override object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000B938C File Offset: 0x000B758C
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000B9399 File Offset: 0x000B7599
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06002D10 RID: 11536 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170006F4 RID: 1780
			public override object this[object key]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[key];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[key] = value;
					}
				}
			}

			// Token: 0x06002D13 RID: 11539 RVA: 0x000B9438 File Offset: 0x000B7638
			public override void Add(object key, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Add(key, value);
				}
			}

			// Token: 0x06002D14 RID: 11540 RVA: 0x000B9480 File Offset: 0x000B7680
			public override void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06002D15 RID: 11541 RVA: 0x000B94C8 File Offset: 0x000B76C8
			public override object Clone()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = this._list.Clone();
				}
				return result;
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x000B9510 File Offset: 0x000B7710
			public override bool Contains(object key)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(key);
				}
				return result;
			}

			// Token: 0x06002D17 RID: 11543 RVA: 0x000B9558 File Offset: 0x000B7758
			public override bool ContainsKey(object key)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.ContainsKey(key);
				}
				return result;
			}

			// Token: 0x06002D18 RID: 11544 RVA: 0x000B95A0 File Offset: 0x000B77A0
			public override bool ContainsValue(object key)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.ContainsValue(key);
				}
				return result;
			}

			// Token: 0x06002D19 RID: 11545 RVA: 0x000B95E8 File Offset: 0x000B77E8
			public override void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x000B9630 File Offset: 0x000B7830
			public override object GetByIndex(int index)
			{
				object root = this._root;
				object byIndex;
				lock (root)
				{
					byIndex = this._list.GetByIndex(index);
				}
				return byIndex;
			}

			// Token: 0x06002D1B RID: 11547 RVA: 0x000B9678 File Offset: 0x000B7878
			public override IDictionaryEnumerator GetEnumerator()
			{
				object root = this._root;
				IDictionaryEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06002D1C RID: 11548 RVA: 0x000B96C0 File Offset: 0x000B78C0
			public override object GetKey(int index)
			{
				object root = this._root;
				object key;
				lock (root)
				{
					key = this._list.GetKey(index);
				}
				return key;
			}

			// Token: 0x06002D1D RID: 11549 RVA: 0x000B9708 File Offset: 0x000B7908
			public override IList GetKeyList()
			{
				object root = this._root;
				IList keyList;
				lock (root)
				{
					keyList = this._list.GetKeyList();
				}
				return keyList;
			}

			// Token: 0x06002D1E RID: 11550 RVA: 0x000B9750 File Offset: 0x000B7950
			public override IList GetValueList()
			{
				object root = this._root;
				IList valueList;
				lock (root)
				{
					valueList = this._list.GetValueList();
				}
				return valueList;
			}

			// Token: 0x06002D1F RID: 11551 RVA: 0x000B9798 File Offset: 0x000B7998
			public override int IndexOfKey(object key)
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOfKey(key);
				}
				return result;
			}

			// Token: 0x06002D20 RID: 11552 RVA: 0x000B97F4 File Offset: 0x000B79F4
			public override int IndexOfValue(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOfValue(value);
				}
				return result;
			}

			// Token: 0x06002D21 RID: 11553 RVA: 0x000B983C File Offset: 0x000B7A3C
			public override void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x06002D22 RID: 11554 RVA: 0x000B9884 File Offset: 0x000B7A84
			public override void Remove(object key)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(key);
				}
			}

			// Token: 0x04001881 RID: 6273
			private SortedList _list;

			// Token: 0x04001882 RID: 6274
			private object _root;
		}

		// Token: 0x020005E6 RID: 1510
		[Serializable]
		private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
		{
			// Token: 0x06002D23 RID: 11555 RVA: 0x000B98CC File Offset: 0x000B7ACC
			internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
			{
				this._sortedList = sortedList;
				this._index = index;
				this._startIndex = index;
				this._endIndex = index + count;
				this._version = sortedList.version;
				this._getObjectRetType = getObjRetType;
				this._current = false;
			}

			// Token: 0x06002D24 RID: 11556 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000B9918 File Offset: 0x000B7B18
			public virtual object Key
			{
				get
				{
					if (this._version != this._sortedList.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._key;
				}
			}

			// Token: 0x06002D26 RID: 11558 RVA: 0x000B9954 File Offset: 0x000B7B54
			public virtual bool MoveNext()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index < this._endIndex)
				{
					this._key = this._sortedList.keys[this._index];
					this._value = this._sortedList.values[this._index];
					this._index++;
					this._current = true;
					return true;
				}
				this._key = null;
				this._value = null;
				this._current = false;
				return false;
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000B99EC File Offset: 0x000B7BEC
			public virtual DictionaryEntry Entry
			{
				get
				{
					if (this._version != this._sortedList.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return new DictionaryEntry(this._key, this._value);
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06002D28 RID: 11560 RVA: 0x000B9A3C File Offset: 0x000B7C3C
			public virtual object Current
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					if (this._getObjectRetType == 1)
					{
						return this._key;
					}
					if (this._getObjectRetType == 2)
					{
						return this._value;
					}
					return new DictionaryEntry(this._key, this._value);
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000B9A92 File Offset: 0x000B7C92
			public virtual object Value
			{
				get
				{
					if (this._version != this._sortedList.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._value;
				}
			}

			// Token: 0x06002D2A RID: 11562 RVA: 0x000B9ACC File Offset: 0x000B7CCC
			public virtual void Reset()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._index = this._startIndex;
				this._current = false;
				this._key = null;
				this._value = null;
			}

			// Token: 0x04001883 RID: 6275
			private SortedList _sortedList;

			// Token: 0x04001884 RID: 6276
			private object _key;

			// Token: 0x04001885 RID: 6277
			private object _value;

			// Token: 0x04001886 RID: 6278
			private int _index;

			// Token: 0x04001887 RID: 6279
			private int _startIndex;

			// Token: 0x04001888 RID: 6280
			private int _endIndex;

			// Token: 0x04001889 RID: 6281
			private int _version;

			// Token: 0x0400188A RID: 6282
			private bool _current;

			// Token: 0x0400188B RID: 6283
			private int _getObjectRetType;
		}

		// Token: 0x020005E7 RID: 1511
		[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[Serializable]
		private class KeyList : IList, ICollection, IEnumerable
		{
			// Token: 0x06002D2B RID: 11563 RVA: 0x000B9B18 File Offset: 0x000B7D18
			internal KeyList(SortedList sortedList)
			{
				this.sortedList = sortedList;
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000B9B27 File Offset: 0x000B7D27
			public virtual int Count
			{
				get
				{
					return this.sortedList._size;
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06002D2D RID: 11565 RVA: 0x0000B18D File Offset: 0x0000938D
			public virtual bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06002D2E RID: 11566 RVA: 0x0000B18D File Offset: 0x0000938D
			public virtual bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000B9B34 File Offset: 0x000B7D34
			public virtual bool IsSynchronized
			{
				get
				{
					return this.sortedList.IsSynchronized;
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000B9B41 File Offset: 0x000B7D41
			public virtual object SyncRoot
			{
				get
				{
					return this.sortedList.SyncRoot;
				}
			}

			// Token: 0x06002D31 RID: 11569 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual int Add(object key)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06002D32 RID: 11570 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void Clear()
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06002D33 RID: 11571 RVA: 0x000B9B5A File Offset: 0x000B7D5A
			public virtual bool Contains(object key)
			{
				return this.sortedList.Contains(key);
			}

			// Token: 0x06002D34 RID: 11572 RVA: 0x000B9B68 File Offset: 0x000B7D68
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array != null && array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				Array.Copy(this.sortedList.keys, 0, array, arrayIndex, this.sortedList.Count);
			}

			// Token: 0x06002D35 RID: 11573 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void Insert(int index, object value)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x170006FE RID: 1790
			public virtual object this[int index]
			{
				get
				{
					return this.sortedList.GetKey(index);
				}
				set
				{
					throw new NotSupportedException("Mutating a key collection derived from a dictionary is not allowed.");
				}
			}

			// Token: 0x06002D38 RID: 11576 RVA: 0x000B9BBE File Offset: 0x000B7DBE
			public virtual IEnumerator GetEnumerator()
			{
				return new SortedList.SortedListEnumerator(this.sortedList, 0, this.sortedList.Count, 1);
			}

			// Token: 0x06002D39 RID: 11577 RVA: 0x000B9BD8 File Offset: 0x000B7DD8
			public virtual int IndexOf(object key)
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				int num = Array.BinarySearch(this.sortedList.keys, 0, this.sortedList.Count, key, this.sortedList.comparer);
				if (num >= 0)
				{
					return num;
				}
				return -1;
			}

			// Token: 0x06002D3A RID: 11578 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void Remove(object key)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06002D3B RID: 11579 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void RemoveAt(int index)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x0400188C RID: 6284
			private SortedList sortedList;
		}

		// Token: 0x020005E8 RID: 1512
		[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[Serializable]
		private class ValueList : IList, ICollection, IEnumerable
		{
			// Token: 0x06002D3C RID: 11580 RVA: 0x000B9C28 File Offset: 0x000B7E28
			internal ValueList(SortedList sortedList)
			{
				this.sortedList = sortedList;
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000B9C37 File Offset: 0x000B7E37
			public virtual int Count
			{
				get
				{
					return this.sortedList._size;
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06002D3E RID: 11582 RVA: 0x0000B18D File Offset: 0x0000938D
			public virtual bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0000B18D File Offset: 0x0000938D
			public virtual bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000B9C44 File Offset: 0x000B7E44
			public virtual bool IsSynchronized
			{
				get
				{
					return this.sortedList.IsSynchronized;
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000B9C51 File Offset: 0x000B7E51
			public virtual object SyncRoot
			{
				get
				{
					return this.sortedList.SyncRoot;
				}
			}

			// Token: 0x06002D42 RID: 11586 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual int Add(object key)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06002D43 RID: 11587 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void Clear()
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06002D44 RID: 11588 RVA: 0x000B9C5E File Offset: 0x000B7E5E
			public virtual bool Contains(object value)
			{
				return this.sortedList.ContainsValue(value);
			}

			// Token: 0x06002D45 RID: 11589 RVA: 0x000B9C6C File Offset: 0x000B7E6C
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array != null && array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				Array.Copy(this.sortedList.values, 0, array, arrayIndex, this.sortedList.Count);
			}

			// Token: 0x06002D46 RID: 11590 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void Insert(int index, object value)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x17000704 RID: 1796
			public virtual object this[int index]
			{
				get
				{
					return this.sortedList.GetByIndex(index);
				}
				set
				{
					throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
				}
			}

			// Token: 0x06002D49 RID: 11593 RVA: 0x000B9CB6 File Offset: 0x000B7EB6
			public virtual IEnumerator GetEnumerator()
			{
				return new SortedList.SortedListEnumerator(this.sortedList, 0, this.sortedList.Count, 2);
			}

			// Token: 0x06002D4A RID: 11594 RVA: 0x000B9CD0 File Offset: 0x000B7ED0
			public virtual int IndexOf(object value)
			{
				return Array.IndexOf<object>(this.sortedList.values, value, 0, this.sortedList.Count);
			}

			// Token: 0x06002D4B RID: 11595 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void Remove(object value)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06002D4C RID: 11596 RVA: 0x000B9B4E File Offset: 0x000B7D4E
			public virtual void RemoveAt(int index)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x0400188D RID: 6285
			private SortedList sortedList;
		}

		// Token: 0x020005E9 RID: 1513
		internal class SortedListDebugView
		{
		}
	}
}
