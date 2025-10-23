using System;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections.Specialized
{
	/// <summary>Represents a collection of key/value pairs that are accessible by the key or index.</summary>
	// Token: 0x020002C6 RID: 710
	[Serializable]
	public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class.</summary>
		// Token: 0x060012EB RID: 4843 RVA: 0x0005A03D File Offset: 0x0005823D
		public OrderedDictionary() : this(0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class using the specified initial capacity.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection can contain.</param>
		// Token: 0x060012EC RID: 4844 RVA: 0x0005A046 File Offset: 0x00058246
		public OrderedDictionary(int capacity) : this(capacity, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class using the specified initial capacity and comparer.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection can contain.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.-or- 
		///       <see langword="null" /> to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
		// Token: 0x060012ED RID: 4845 RVA: 0x0005A050 File Offset: 0x00058250
		public OrderedDictionary(int capacity, IEqualityComparer comparer)
		{
			this._initialCapacity = capacity;
			this._comparer = comparer;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		// Token: 0x060012EE RID: 4846 RVA: 0x0005A066 File Offset: 0x00058266
		protected OrderedDictionary(SerializationInfo info, StreamingContext context)
		{
			this._siInfo = info;
		}

		/// <summary>Gets the number of key/values pairs contained in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x0005A075 File Offset: 0x00058275
		public int Count
		{
			get
			{
				return this.objectsArray.Count;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x0005A082 File Offset: 0x00058282
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x0005A082 File Offset: 0x00058282
		public bool IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> object is synchronized (thread-safe).</summary>
		/// <returns>This method always returns <see langword="false" />.</returns>
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000023F6 File Offset: 0x000005F6
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x0005A08A File Offset: 0x0005828A
		public ICollection Keys
		{
			get
			{
				return new OrderedDictionary.OrderedDictionaryKeyValueCollection(this.objectsArray, true);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0005A098 File Offset: 0x00058298
		private ArrayList objectsArray
		{
			get
			{
				if (this._objectsArray == null)
				{
					this._objectsArray = new ArrayList(this._initialCapacity);
				}
				return this._objectsArray;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0005A0B9 File Offset: 0x000582B9
		private Hashtable objectsTable
		{
			get
			{
				if (this._objectsTable == null)
				{
					this._objectsTable = new Hashtable(this._initialCapacity, this._comparer);
				}
				return this._objectsTable;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> object.</returns>
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0005A0E0 File Offset: 0x000582E0
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Gets or sets the value with the specified key.</summary>
		/// <param name="key">The key of the value to get or set.</param>
		/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns <see langword="null" />, and attempting to set it creates a new element using the specified key.</returns>
		/// <exception cref="T:System.NotSupportedException">The property is being set and the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		// Token: 0x170003CF RID: 975
		public object this[object key]
		{
			get
			{
				return this.objectsTable[key];
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
				}
				if (this.objectsTable.Contains(key))
				{
					this.objectsTable[key] = value;
					this.objectsArray[this.IndexOfKey(key)] = new DictionaryEntry(key, value);
					return;
				}
				this.Add(key, value);
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0005A172 File Offset: 0x00058372
		public ICollection Values
		{
			get
			{
				return new OrderedDictionary.OrderedDictionaryKeyValueCollection(this.objectsArray, false);
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection with the lowest available index.</summary>
		/// <param name="key">The key of the entry to add.</param>
		/// <param name="value">The value of the entry to add. This value can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		// Token: 0x060012FA RID: 4858 RVA: 0x0005A180 File Offset: 0x00058380
		public void Add(object key, object value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			this.objectsTable.Add(key, value);
			this.objectsArray.Add(new DictionaryEntry(key, value));
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		// Token: 0x060012FB RID: 4859 RVA: 0x0005A1BA File Offset: 0x000583BA
		public void Clear()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			this.objectsTable.Clear();
			this.objectsArray.Clear();
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection contains a specific key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		// Token: 0x060012FC RID: 4860 RVA: 0x0005A1E5 File Offset: 0x000583E5
		public bool Contains(object key)
		{
			return this.objectsTable.Contains(key);
		}

		/// <summary>Copies the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> elements to a one-dimensional <see cref="T:System.Array" /> object at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> object that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		// Token: 0x060012FD RID: 4861 RVA: 0x0005A1F3 File Offset: 0x000583F3
		public void CopyTo(Array array, int index)
		{
			this.objectsTable.CopyTo(array, index);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0005A204 File Offset: 0x00058404
		private int IndexOfKey(object key)
		{
			for (int i = 0; i < this.objectsArray.Count; i++)
			{
				object key2 = ((DictionaryEntry)this.objectsArray[i]).Key;
				if (this._comparer != null)
				{
					if (this._comparer.Equals(key2, key))
					{
						return i;
					}
				}
				else if (key2.Equals(key))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Removes the entry with the specified key from the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <param name="key">The key of the entry to remove.</param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is read-only.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x060012FF RID: 4863 RVA: 0x0005A268 File Offset: 0x00058468
		public void Remove(object key)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int num = this.IndexOfKey(key);
			if (num < 0)
			{
				return;
			}
			this.objectsTable.Remove(key);
			this.objectsArray.RemoveAt(num);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object that iterates through the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x06001300 RID: 4864 RVA: 0x0005A2BB File Offset: 0x000584BB
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new OrderedDictionary.OrderedDictionaryEnumerator(this.objectsArray, 3);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object that iterates through the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</returns>
		// Token: 0x06001301 RID: 4865 RVA: 0x0005A2BB File Offset: 0x000584BB
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new OrderedDictionary.OrderedDictionaryEnumerator(this.objectsArray, 3);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06001302 RID: 4866 RVA: 0x0005A2CC File Offset: 0x000584CC
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("KeyComparer", this._comparer, typeof(IEqualityComparer));
			info.AddValue("ReadOnly", this._readOnly);
			info.AddValue("InitialCapacity", this._initialCapacity);
			object[] array = new object[this.Count];
			this._objectsArray.CopyTo(array);
			info.AddValue("ArrayList", array);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		// Token: 0x06001303 RID: 4867 RVA: 0x0005A348 File Offset: 0x00058548
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialization(sender);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.OrderedDictionary" /> collection is invalid.</exception>
		// Token: 0x06001304 RID: 4868 RVA: 0x0005A354 File Offset: 0x00058554
		protected virtual void OnDeserialization(object sender)
		{
			if (this._siInfo == null)
			{
				throw new SerializationException("OnDeserialization method was called while the object was not being deserialized.");
			}
			this._comparer = (IEqualityComparer)this._siInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
			this._readOnly = this._siInfo.GetBoolean("ReadOnly");
			this._initialCapacity = this._siInfo.GetInt32("InitialCapacity");
			object[] array = (object[])this._siInfo.GetValue("ArrayList", typeof(object[]));
			if (array != null)
			{
				foreach (object obj in array)
				{
					DictionaryEntry dictionaryEntry;
					try
					{
						dictionaryEntry = (DictionaryEntry)obj;
					}
					catch
					{
						throw new SerializationException("There was an error deserializing the OrderedDictionary.  The ArrayList does not contain DictionaryEntries.");
					}
					this.objectsArray.Add(dictionaryEntry);
					this.objectsTable.Add(dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
		}

		// Token: 0x04000D29 RID: 3369
		private ArrayList _objectsArray;

		// Token: 0x04000D2A RID: 3370
		private Hashtable _objectsTable;

		// Token: 0x04000D2B RID: 3371
		private int _initialCapacity;

		// Token: 0x04000D2C RID: 3372
		private IEqualityComparer _comparer;

		// Token: 0x04000D2D RID: 3373
		private bool _readOnly;

		// Token: 0x04000D2E RID: 3374
		private object _syncRoot;

		// Token: 0x04000D2F RID: 3375
		private SerializationInfo _siInfo;

		// Token: 0x020002C7 RID: 711
		private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001305 RID: 4869 RVA: 0x0005A450 File Offset: 0x00058650
			internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType)
			{
				this._arrayEnumerator = array.GetEnumerator();
				this._objectReturnType = objectReturnType;
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06001306 RID: 4870 RVA: 0x0005A46C File Offset: 0x0005866C
			public object Current
			{
				get
				{
					if (this._objectReturnType == 1)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
						return dictionaryEntry.Key;
					}
					if (this._objectReturnType == 2)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
						return dictionaryEntry.Value;
					}
					return this.Entry;
				}
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06001307 RID: 4871 RVA: 0x0005A4C8 File Offset: 0x000586C8
			public DictionaryEntry Entry
			{
				get
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					object key = dictionaryEntry.Key;
					dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					return new DictionaryEntry(key, dictionaryEntry.Value);
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06001308 RID: 4872 RVA: 0x0005A50C File Offset: 0x0005870C
			public object Key
			{
				get
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					return dictionaryEntry.Key;
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06001309 RID: 4873 RVA: 0x0005A534 File Offset: 0x00058734
			public object Value
			{
				get
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					return dictionaryEntry.Value;
				}
			}

			// Token: 0x0600130A RID: 4874 RVA: 0x0005A559 File Offset: 0x00058759
			public bool MoveNext()
			{
				return this._arrayEnumerator.MoveNext();
			}

			// Token: 0x0600130B RID: 4875 RVA: 0x0005A566 File Offset: 0x00058766
			public void Reset()
			{
				this._arrayEnumerator.Reset();
			}

			// Token: 0x04000D30 RID: 3376
			private int _objectReturnType;

			// Token: 0x04000D31 RID: 3377
			private IEnumerator _arrayEnumerator;
		}

		// Token: 0x020002C8 RID: 712
		private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x0600130C RID: 4876 RVA: 0x0005A573 File Offset: 0x00058773
			public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys)
			{
				this._objects = array;
				this._isKeys = isKeys;
			}

			// Token: 0x0600130D RID: 4877 RVA: 0x0005A58C File Offset: 0x0005878C
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
				}
				foreach (object obj in this._objects)
				{
					array.SetValue(this._isKeys ? ((DictionaryEntry)obj).Key : ((DictionaryEntry)obj).Value, index);
					index++;
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x0600130E RID: 4878 RVA: 0x0005A634 File Offset: 0x00058834
			int ICollection.Count
			{
				get
				{
					return this._objects.Count;
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x0600130F RID: 4879 RVA: 0x000023F6 File Offset: 0x000005F6
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06001310 RID: 4880 RVA: 0x0005A641 File Offset: 0x00058841
			object ICollection.SyncRoot
			{
				get
				{
					return this._objects.SyncRoot;
				}
			}

			// Token: 0x06001311 RID: 4881 RVA: 0x0005A64E File Offset: 0x0005884E
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new OrderedDictionary.OrderedDictionaryEnumerator(this._objects, this._isKeys ? 1 : 2);
			}

			// Token: 0x04000D32 RID: 3378
			private ArrayList _objects;

			// Token: 0x04000D33 RID: 3379
			private bool _isKeys;
		}
	}
}
