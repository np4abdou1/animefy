using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.ObjectModel
{
	/// <summary>Represents a read-only, generic collection of key/value pairs.</summary>
	/// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
	// Token: 0x02000607 RID: 1543
	[DebuggerTypeProxy(typeof(DictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ReadOnlyDictionary<TKey, TValue> : IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> class that is a wrapper around the specified dictionary.</summary>
		/// <param name="dictionary">The dictionary to wrap.</param>
		// Token: 0x06002EEA RID: 12010 RVA: 0x000BF486 File Offset: 0x000BD686
		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this.m_dictionary = dictionary;
		}

		/// <summary>Gets a key collection that contains the keys of the dictionary.</summary>
		/// <returns>A key collection that contains the keys of the dictionary.</returns>
		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x000BF4A3 File Offset: 0x000BD6A3
		public ReadOnlyDictionary<TKey, TValue>.KeyCollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new ReadOnlyDictionary<TKey, TValue>.KeyCollection(this.m_dictionary.Keys);
				}
				return this._keys;
			}
		}

		/// <summary>Gets a collection that contains the values in the dictionary.</summary>
		/// <returns>A collection that contains the values in the object that implements <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</returns>
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000BF4C9 File Offset: 0x000BD6C9
		public ReadOnlyDictionary<TKey, TValue>.ValueCollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new ReadOnlyDictionary<TKey, TValue>.ValueCollection(this.m_dictionary.Values);
				}
				return this._values;
			}
		}

		/// <summary>Determines whether the dictionary contains an element that has the specified key.</summary>
		/// <param name="key">The key to locate in the dictionary.</param>
		/// <returns>
		///     <see langword="true" /> if the dictionary contains an element that has the specified key; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002EED RID: 12013 RVA: 0x000BF4EF File Offset: 0x000BD6EF
		public bool ContainsKey(TKey key)
		{
			return this.m_dictionary.ContainsKey(key);
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000BF4FD File Offset: 0x000BD6FD
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Retrieves the value that is associated with the specified key.</summary>
		/// <param name="key">The key whose value will be retrieved.</param>
		/// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value" /> parameter. This parameter is passed uninitialized.</param>
		/// <returns>
		///     <see langword="true" /> if the object that implements <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002EEF RID: 12015 RVA: 0x000BF505 File Offset: 0x000BD705
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.m_dictionary.TryGetValue(key, out value);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x000BF514 File Offset: 0x000BD714
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Gets the element that has the specified key.</summary>
		/// <param name="key">The key of the element to get.</param>
		/// <returns>The element that has the specified key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> is not found.</exception>
		// Token: 0x17000775 RID: 1909
		public TValue this[TKey key]
		{
			get
			{
				return this.m_dictionary[key];
			}
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x000BBA03 File Offset: 0x000B9C03
		void IDictionary<!0, !1>.Add(TKey key, TValue value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x000BBA03 File Offset: 0x000B9C03
		bool IDictionary<!0, !1>.Remove(TKey key)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x17000776 RID: 1910
		TValue IDictionary<!0, !1>.this[TKey key]
		{
			get
			{
				return this.m_dictionary[key];
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		/// <summary>Gets the number of items in the dictionary.</summary>
		/// <returns>The number of items in the dictionary.</returns>
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000BF52A File Offset: 0x000BD72A
		public int Count
		{
			get
			{
				return this.m_dictionary.Count;
			}
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000BF537 File Offset: 0x000BD737
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.m_dictionary.Contains(item);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000BF545 File Offset: 0x000BD745
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			this.m_dictionary.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x0000B18D File Offset: 0x0000938D
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000BBA03 File Offset: 0x000B9C03
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000BBA03 File Offset: 0x000B9C03
		void ICollection<KeyValuePair<!0, !1>>.Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x000BBA03 File Offset: 0x000B9C03
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		// Token: 0x06002EFD RID: 12029 RVA: 0x000BF554 File Offset: 0x000BD754
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.m_dictionary.GetEnumerator();
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		// Token: 0x06002EFE RID: 12030 RVA: 0x000BF561 File Offset: 0x000BD761
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_dictionary.GetEnumerator();
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x000BF56E File Offset: 0x000BD76E
		private static bool IsCompatibleKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return key is TKey;
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <param name="key">The key of the element to add. </param>
		/// <param name="value">The value of the element to add. </param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002F00 RID: 12032 RVA: 0x000BBA03 File Offset: 0x000B9C03
		void IDictionary.Add(object key, object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002F01 RID: 12033 RVA: 0x000BBA03 File Offset: 0x000B9C03
		void IDictionary.Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Determines whether the dictionary contains an element that has the specified key.</summary>
		/// <param name="key">The key to locate in the dictionary.</param>
		/// <returns>
		///     <see langword="true" /> if the dictionary contains an element that has the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06002F02 RID: 12034 RVA: 0x000BF587 File Offset: 0x000BD787
		bool IDictionary.Contains(object key)
		{
			return ReadOnlyDictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		/// <summary>Returns an enumerator for the dictionary.</summary>
		/// <returns>An enumerator for the dictionary.</returns>
		// Token: 0x06002F03 RID: 12035 RVA: 0x000BF5A0 File Offset: 0x000BD7A0
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			IDictionary dictionary = this.m_dictionary as IDictionary;
			if (dictionary != null)
			{
				return dictionary.GetEnumerator();
			}
			return new ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator(this.m_dictionary);
		}

		/// <summary>Gets a value that indicates whether the dictionary has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the dictionary has a fixed size; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x0000B18D File Offset: 0x0000938D
		bool IDictionary.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value that indicates whether the dictionary is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> in all cases.</returns>
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x0000B18D File Offset: 0x0000938D
		bool IDictionary.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a collection that contains the keys of the dictionary.</summary>
		/// <returns>A collection that contains the keys of the dictionary.</returns>
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x000BF4FD File Offset: 0x000BD6FD
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <param name="key">The key of the element to remove. </param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002F07 RID: 12039 RVA: 0x000BBA03 File Offset: 0x000B9C03
		void IDictionary.Remove(object key)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Gets a collection that contains the values in the dictionary.</summary>
		/// <returns>A collection that contains the values in the dictionary.</returns>
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x000BF514 File Offset: 0x000BD714
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Gets the element that has the specified key.</summary>
		/// <param name="key">The key of the element to get or set. </param>
		/// <returns>The element that has the specified key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The property is set.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the dictionary has a fixed size. </exception>
		// Token: 0x1700077D RID: 1917
		object IDictionary.this[object key]
		{
			get
			{
				if (ReadOnlyDictionary<TKey, TValue>.IsCompatibleKey(key))
				{
					return this[(TKey)((object)key)];
				}
				return null;
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		/// <summary>Copies the elements of the dictionary to an array, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the dictionary. The array must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source dictionary is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.-or- The type of the source dictionary cannot be cast automatically to the type of the destination <paramref name="array" /><paramref name="." /></exception>
		// Token: 0x06002F0B RID: 12043 RVA: 0x000BF5F0 File Offset: 0x000BD7F0
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException("The lower bound of target array must be zero.");
			}
			if (index < 0 || index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				this.m_dictionary.CopyTo(array2, index);
				return;
			}
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			if (array3 != null)
			{
				using (IEnumerator<KeyValuePair<TKey, TValue>> enumerator = this.m_dictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<TKey, TValue> keyValuePair = enumerator.Current;
						array3[index++] = new DictionaryEntry(keyValuePair.Key, keyValuePair.Value);
					}
					return;
				}
			}
			object[] array4 = array as object[];
			if (array4 == null)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.");
			}
			try
			{
				foreach (KeyValuePair<TKey, TValue> keyValuePair2 in this.m_dictionary)
				{
					array4[index++] = new KeyValuePair<TKey, TValue>(keyValuePair2.Key, keyValuePair2.Value);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.");
			}
		}

		/// <summary>Gets a value that indicates whether access to the dictionary is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the dictionary is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the dictionary.</summary>
		/// <returns>An object that can be used to synchronize access to the dictionary.</returns>
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x000BF778 File Offset: 0x000BD978
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					ICollection collection = this.m_dictionary as ICollection;
					if (collection != null)
					{
						this._syncRoot = collection.SyncRoot;
					}
					else
					{
						Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
					}
				}
				return this._syncRoot;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002F0E RID: 12046 RVA: 0x000BF4FD File Offset: 0x000BD6FD
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000BF514 File Offset: 0x000BD714
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x040018E3 RID: 6371
		private readonly IDictionary<TKey, TValue> m_dictionary;

		// Token: 0x040018E4 RID: 6372
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x040018E5 RID: 6373
		[NonSerialized]
		private ReadOnlyDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x040018E6 RID: 6374
		[NonSerialized]
		private ReadOnlyDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x02000608 RID: 1544
		[Serializable]
		private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002F10 RID: 12048 RVA: 0x000BF7C2 File Offset: 0x000BD9C2
			public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary)
			{
				this._dictionary = dictionary;
				this._enumerator = this._dictionary.GetEnumerator();
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000BF7DC File Offset: 0x000BD9DC
			public DictionaryEntry Entry
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					object key = keyValuePair.Key;
					keyValuePair = this._enumerator.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000BF820 File Offset: 0x000BDA20
			public object Key
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000BF848 File Offset: 0x000BDA48
			public object Value
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06002F14 RID: 12052 RVA: 0x000BF86D File Offset: 0x000BDA6D
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x06002F15 RID: 12053 RVA: 0x000BF87A File Offset: 0x000BDA7A
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06002F16 RID: 12054 RVA: 0x000BF887 File Offset: 0x000BDA87
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x040018E7 RID: 6375
			private readonly IDictionary<TKey, TValue> _dictionary;

			// Token: 0x040018E8 RID: 6376
			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;
		}

		/// <summary>Represents a read-only collection of the keys of a <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> object.</summary>
		// Token: 0x02000609 RID: 1545
		[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x06002F17 RID: 12055 RVA: 0x000BF894 File Offset: 0x000BDA94
			internal KeyCollection(ICollection<TKey> collection)
			{
				if (collection == null)
				{
					throw new ArgumentNullException("collection");
				}
				this._collection = collection;
			}

			// Token: 0x06002F18 RID: 12056 RVA: 0x000BBA03 File Offset: 0x000B9C03
			void ICollection<!0>.Add(TKey item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002F19 RID: 12057 RVA: 0x000BBA03 File Offset: 0x000B9C03
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x000BF8B1 File Offset: 0x000BDAB1
			bool ICollection<!0>.Contains(TKey item)
			{
				return this._collection.Contains(item);
			}

			/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
			/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
			/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="arrayIndex" /> is less than 0.</exception>
			/// <exception cref="T:System.ArgumentException">
			///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source collection is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.-or-Type <paramref name="T" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F1B RID: 12059 RVA: 0x000BF8BF File Offset: 0x000BDABF
			public void CopyTo(TKey[] array, int arrayIndex)
			{
				this._collection.CopyTo(array, arrayIndex);
			}

			/// <summary>Gets the number of elements in the collection.</summary>
			/// <returns>The number of elements in the collection.</returns>
			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000BF8CE File Offset: 0x000BDACE
			public int Count
			{
				get
				{
					return this._collection.Count;
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06002F1D RID: 12061 RVA: 0x0000B18D File Offset: 0x0000938D
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06002F1E RID: 12062 RVA: 0x000BBA03 File Offset: 0x000B9C03
			bool ICollection<!0>.Remove(TKey item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			/// <summary>Returns an enumerator that iterates through the collection.</summary>
			/// <returns>An enumerator that can be used to iterate through the collection.</returns>
			// Token: 0x06002F1F RID: 12063 RVA: 0x000BF8DB File Offset: 0x000BDADB
			public IEnumerator<TKey> GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Returns an enumerator that iterates through the collection.</summary>
			/// <returns>An enumerator that can be used to iterate through the collection.</returns>
			// Token: 0x06002F20 RID: 12064 RVA: 0x000BF8E8 File Offset: 0x000BDAE8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
			/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="index" /> is less than 0.</exception>
			/// <exception cref="T:System.ArgumentException">
			///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source collection is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F21 RID: 12065 RVA: 0x000BF8F5 File Offset: 0x000BDAF5
			void ICollection.CopyTo(Array array, int index)
			{
				ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<TKey>(this._collection, array, index);
			}

			/// <summary>Gets a value that indicates whether access to the collection is synchronized (thread safe).</summary>
			/// <returns>
			///     <see langword="true" /> if access to the collection is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06002F22 RID: 12066 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
			/// <returns>An object that can be used to synchronize access to the collection.</returns>
			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000BF904 File Offset: 0x000BDB04
			object ICollection.SyncRoot
			{
				get
				{
					if (this._syncRoot == null)
					{
						ICollection collection = this._collection as ICollection;
						if (collection != null)
						{
							this._syncRoot = collection.SyncRoot;
						}
						else
						{
							Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
						}
					}
					return this._syncRoot;
				}
			}

			// Token: 0x040018E9 RID: 6377
			private readonly ICollection<TKey> _collection;

			// Token: 0x040018EA RID: 6378
			[NonSerialized]
			private object _syncRoot;
		}

		/// <summary>Represents a read-only collection of the values of a <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> object.</summary>
		// Token: 0x0200060A RID: 1546
		[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x06002F24 RID: 12068 RVA: 0x000BF94E File Offset: 0x000BDB4E
			internal ValueCollection(ICollection<TValue> collection)
			{
				if (collection == null)
				{
					throw new ArgumentNullException("collection");
				}
				this._collection = collection;
			}

			// Token: 0x06002F25 RID: 12069 RVA: 0x000BBA03 File Offset: 0x000B9C03
			void ICollection<!1>.Add(TValue item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002F26 RID: 12070 RVA: 0x000BBA03 File Offset: 0x000B9C03
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06002F27 RID: 12071 RVA: 0x000BF96B File Offset: 0x000BDB6B
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._collection.Contains(item);
			}

			/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
			/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
			/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="arrayIndex" /> is less than 0.</exception>
			/// <exception cref="T:System.ArgumentException">
			///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source collection is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.-or-Type <paramref name="T" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F28 RID: 12072 RVA: 0x000BF979 File Offset: 0x000BDB79
			public void CopyTo(TValue[] array, int arrayIndex)
			{
				this._collection.CopyTo(array, arrayIndex);
			}

			/// <summary>Gets the number of elements in the collection.</summary>
			/// <returns>The number of elements in the collection.</returns>
			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06002F29 RID: 12073 RVA: 0x000BF988 File Offset: 0x000BDB88
			public int Count
			{
				get
				{
					return this._collection.Count;
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x06002F2A RID: 12074 RVA: 0x0000B18D File Offset: 0x0000938D
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06002F2B RID: 12075 RVA: 0x000BBA03 File Offset: 0x000B9C03
			bool ICollection<!1>.Remove(TValue item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			/// <summary>Returns an enumerator that iterates through the collection.</summary>
			/// <returns>An enumerator that can be used to iterate through the collection.</returns>
			// Token: 0x06002F2C RID: 12076 RVA: 0x000BF995 File Offset: 0x000BDB95
			public IEnumerator<TValue> GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Returns an enumerator that iterates through the collection.</summary>
			/// <returns>An enumerator that can be used to iterate through the collection.</returns>
			// Token: 0x06002F2D RID: 12077 RVA: 0x000BF9A2 File Offset: 0x000BDBA2
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
			/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="index" /> is less than 0.</exception>
			/// <exception cref="T:System.ArgumentException">
			///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source collection is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F2E RID: 12078 RVA: 0x000BF9AF File Offset: 0x000BDBAF
			void ICollection.CopyTo(Array array, int index)
			{
				ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<TValue>(this._collection, array, index);
			}

			/// <summary>Gets a value that indicates whether access to the collection is synchronized (thread safe).</summary>
			/// <returns>
			///     <see langword="true" /> if access to the collection is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06002F2F RID: 12079 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
			/// <returns>An object that can be used to synchronize access to the collection.</returns>
			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06002F30 RID: 12080 RVA: 0x000BF9C0 File Offset: 0x000BDBC0
			object ICollection.SyncRoot
			{
				get
				{
					if (this._syncRoot == null)
					{
						ICollection collection = this._collection as ICollection;
						if (collection != null)
						{
							this._syncRoot = collection.SyncRoot;
						}
						else
						{
							Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
						}
					}
					return this._syncRoot;
				}
			}

			// Token: 0x040018EB RID: 6379
			private readonly ICollection<TValue> _collection;

			// Token: 0x040018EC RID: 6380
			[NonSerialized]
			private object _syncRoot;
		}
	}
}
