using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections.Generic
{
	/// <summary>Represents a collection of keys and values.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	// Token: 0x0200060D RID: 1549
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that is empty, has the default initial capacity, and uses the default equality comparer for the key type.</summary>
		// Token: 0x06002F32 RID: 12082 RVA: 0x000BFB18 File Offset: 0x000BDD18
		public Dictionary() : this(0, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that is empty, has the specified initial capacity, and uses the default equality comparer for the key type.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Generic.Dictionary`2" /> can contain.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than 0.</exception>
		// Token: 0x06002F33 RID: 12083 RVA: 0x000BFB22 File Offset: 0x000BDD22
		public Dictionary(int capacity) : this(capacity, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that is empty, has the default initial capacity, and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> implementation to use when comparing keys, or <see langword="null" /> to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1" /> for the type of the key.</param>
		// Token: 0x06002F34 RID: 12084 RVA: 0x000BFB2C File Offset: 0x000BDD2C
		public Dictionary(IEqualityComparer<TKey> comparer) : this(0, comparer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that is empty, has the specified initial capacity, and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Generic.Dictionary`2" /> can contain.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> implementation to use when comparing keys, or <see langword="null" /> to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1" /> for the type of the key.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than 0.</exception>
		// Token: 0x06002F35 RID: 12085 RVA: 0x000BFB36 File Offset: 0x000BDD36
		public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			if (capacity > 0)
			{
				this.Initialize(capacity);
			}
			if (comparer != EqualityComparer<TKey>.Default)
			{
				this._comparer = comparer;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that contains elements copied from the specified <see cref="T:System.Collections.Generic.IDictionary`2" /> and uses the default equality comparer for the key type.</summary>
		/// <param name="dictionary">The <see cref="T:System.Collections.Generic.IDictionary`2" /> whose elements are copied to the new <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="dictionary" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="dictionary" /> contains one or more duplicate keys.</exception>
		// Token: 0x06002F36 RID: 12086 RVA: 0x000BFB64 File Offset: 0x000BDD64
		public Dictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that contains elements copied from the specified <see cref="T:System.Collections.Generic.IDictionary`2" /> and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="dictionary">The <see cref="T:System.Collections.Generic.IDictionary`2" /> whose elements are copied to the new <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> implementation to use when comparing keys, or <see langword="null" /> to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1" /> for the type of the key.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="dictionary" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="dictionary" /> contains one or more duplicate keys.</exception>
		// Token: 0x06002F37 RID: 12087 RVA: 0x000BFB70 File Offset: 0x000BDD70
		public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : this((dictionary != null) ? dictionary.Count : 0, comparer)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			if (dictionary.GetType() == typeof(Dictionary<TKey, TValue>))
			{
				Dictionary<TKey, TValue> dictionary2 = (Dictionary<TKey, TValue>)dictionary;
				int count = dictionary2._count;
				Dictionary<TKey, TValue>.Entry[] entries = dictionary2._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						this.Add(entries[i].key, entries[i].value);
					}
				}
				return;
			}
			foreach (KeyValuePair<TKey, TValue> keyValuePair in dictionary)
			{
				this.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000BFC48 File Offset: 0x000BDE48
		public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection) : this(collection, null)
		{
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000BFC54 File Offset: 0x000BDE54
		public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
			ICollection<KeyValuePair<!0, !1>> collection2 = collection as ICollection<KeyValuePair<!0, !1>>;
			this..ctor((collection2 != null) ? collection2.Count : 0, comparer);
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			foreach (KeyValuePair<TKey, TValue> keyValuePair in collection)
			{
				this.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class with serialized data.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		// Token: 0x06002F3A RID: 12090 RVA: 0x000BFCCC File Offset: 0x000BDECC
		protected Dictionary(SerializationInfo info, StreamingContext context)
		{
			HashHelpers.SerializationInfoTable.Add(this, info);
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000BFCE0 File Offset: 0x000BDEE0
		public int Count
		{
			get
			{
				return this._count - this._freeCount;
			}
		}

		/// <summary>Gets a collection containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000BFCEF File Offset: 0x000BDEEF
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Dictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x000BFCEF File Offset: 0x000BDEEF
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Dictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002F3E RID: 12094 RVA: 0x000BFCEF File Offset: 0x000BDEEF
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Dictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		/// <summary>Gets a collection containing the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> containing the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x000BFD0B File Offset: 0x000BDF0B
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Dictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002F40 RID: 12096 RVA: 0x000BFD0B File Offset: 0x000BDF0B
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Dictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x000BFD0B File Offset: 0x000BDF0B
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Dictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <param name="key">The key of the value to get or set.</param>
		/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="T:System.Collections.Generic.KeyNotFoundException" />, and a set operation creates a new element with the specified key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> does not exist in the collection.</exception>
		// Token: 0x17000795 RID: 1941
		public TValue this[TKey key]
		{
			get
			{
				int num = this.FindEntry(key);
				if (num >= 0)
				{
					return this._entries[num].value;
				}
				ThrowHelper.ThrowKeyNotFoundException(key);
				return default(TValue);
			}
			set
			{
				this.TryInsert(key, value, InsertionBehavior.OverwriteExisting);
			}
		}

		/// <summary>Adds the specified key and value to the dictionary.</summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add. The value can be <see langword="null" /> for reference types.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		// Token: 0x06002F44 RID: 12100 RVA: 0x000BFD73 File Offset: 0x000BDF73
		public void Add(TKey key, TValue value)
		{
			this.TryInsert(key, value, InsertionBehavior.ThrowOnExisting);
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000BFD7F File Offset: 0x000BDF7F
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			this.Add(keyValuePair.Key, keyValuePair.Value);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000BFD98 File Offset: 0x000BDF98
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = this.FindEntry(keyValuePair.Key);
			return num >= 0 && EqualityComparer<TValue>.Default.Equals(this._entries[num].value, keyValuePair.Value);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000BFDE0 File Offset: 0x000BDFE0
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = this.FindEntry(keyValuePair.Key);
			if (num >= 0 && EqualityComparer<TValue>.Default.Equals(this._entries[num].value, keyValuePair.Value))
			{
				this.Remove(keyValuePair.Key);
				return true;
			}
			return false;
		}

		/// <summary>Removes all keys and values from the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		// Token: 0x06002F48 RID: 12104 RVA: 0x000BFE34 File Offset: 0x000BE034
		public void Clear()
		{
			int count = this._count;
			if (count > 0)
			{
				Array.Clear(this._buckets, 0, this._buckets.Length);
				this._count = 0;
				this._freeList = -1;
				this._freeCount = 0;
				Array.Clear(this._entries, 0, count);
			}
			this._version++;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Generic.Dictionary`2" /> contains the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.Dictionary`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002F49 RID: 12105 RVA: 0x000BFE90 File Offset: 0x000BE090
		public bool ContainsKey(TKey key)
		{
			return this.FindEntry(key) >= 0;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Generic.Dictionary`2" /> contains a specific value.</summary>
		/// <param name="value">The value to locate in the <see cref="T:System.Collections.Generic.Dictionary`2" />. The value can be <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.Dictionary`2" /> contains an element with the specified value; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002F4A RID: 12106 RVA: 0x000BFEA0 File Offset: 0x000BE0A0
		public bool ContainsValue(TValue value)
		{
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			if (value == null)
			{
				for (int i = 0; i < this._count; i++)
				{
					if (entries[i].hashCode >= 0 && entries[i].value == null)
					{
						return true;
					}
				}
			}
			else if (default(TValue) != null)
			{
				for (int j = 0; j < this._count; j++)
				{
					if (entries[j].hashCode >= 0 && EqualityComparer<TValue>.Default.Equals(entries[j].value, value))
					{
						return true;
					}
				}
			}
			else
			{
				EqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
				for (int k = 0; k < this._count; k++)
				{
					if (entries[k].hashCode >= 0 && @default.Equals(entries[k].value, value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000BFF8C File Offset: 0x000BE18C
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index > array.Length)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			int count = this._count;
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			for (int i = 0; i < count; i++)
			{
				if (entries[i].hashCode >= 0)
				{
					array[index++] = new KeyValuePair<TKey, TValue>(entries[i].key, entries[i].value);
				}
			}
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2.Enumerator" /> structure for the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x06002F4C RID: 12108 RVA: 0x000C0012 File Offset: 0x000BE212
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000C001B File Offset: 0x000BE21B
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Generic.Dictionary`2" /> instance.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Generic.Dictionary`2" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.Dictionary`2" /> instance.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06002F4E RID: 12110 RVA: 0x000C002C File Offset: 0x000BE22C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("Version", this._version);
			info.AddValue("Comparer", this._comparer ?? EqualityComparer<TKey>.Default, typeof(IEqualityComparer<TKey>));
			info.AddValue("HashSize", (this._buckets == null) ? 0 : this._buckets.Length);
			if (this._buckets != null)
			{
				KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[this.Count];
				this.CopyTo(array, 0);
				info.AddValue("KeyValuePairs", array, typeof(KeyValuePair<TKey, TValue>[]));
			}
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000C00C8 File Offset: 0x000BE2C8
		private int FindEntry(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			int num = -1;
			int[] buckets = this._buckets;
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			int num2 = 0;
			if (buckets != null)
			{
				IEqualityComparer<TKey> comparer = this._comparer;
				if (comparer == null)
				{
					int num3 = key.GetHashCode() & int.MaxValue;
					num = buckets[num3 % buckets.Length] - 1;
					if (default(TKey) != null)
					{
						while (num < entries.Length && (entries[num].hashCode != num3 || !EqualityComparer<TKey>.Default.Equals(entries[num].key, key)))
						{
							num = entries[num].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
					else
					{
						EqualityComparer<TKey> @default = EqualityComparer<TKey>.Default;
						while (num < entries.Length && (entries[num].hashCode != num3 || !@default.Equals(entries[num].key, key)))
						{
							num = entries[num].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
				}
				else
				{
					int num4 = comparer.GetHashCode(key) & int.MaxValue;
					num = buckets[num4 % buckets.Length] - 1;
					while (num < entries.Length && (entries[num].hashCode != num4 || !comparer.Equals(entries[num].key, key)))
					{
						num = entries[num].next;
						if (num2 >= entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
						num2++;
					}
				}
			}
			return num;
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000C024C File Offset: 0x000BE44C
		private int Initialize(int capacity)
		{
			int prime = HashHelpers.GetPrime(capacity);
			this._freeList = -1;
			this._buckets = new int[prime];
			this._entries = new Dictionary<TKey, TValue>.Entry[prime];
			return prime;
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000C0280 File Offset: 0x000BE480
		private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			this._version++;
			if (this._buckets == null)
			{
				this.Initialize(0);
			}
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			IEqualityComparer<TKey> comparer = this._comparer;
			int num = ((comparer == null) ? key.GetHashCode() : comparer.GetHashCode(key)) & int.MaxValue;
			int num2 = 0;
			ref int ptr = ref this._buckets[num % this._buckets.Length];
			int i = ptr - 1;
			if (comparer == null)
			{
				if (default(TKey) != null)
				{
					while (i < entries.Length)
					{
						if (entries[i].hashCode == num && EqualityComparer<TKey>.Default.Equals(entries[i].key, key))
						{
							if (behavior == InsertionBehavior.OverwriteExisting)
							{
								entries[i].value = value;
								return true;
							}
							if (behavior == InsertionBehavior.ThrowOnExisting)
							{
								ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException(key);
							}
							return false;
						}
						else
						{
							i = entries[i].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
				}
				else
				{
					EqualityComparer<TKey> @default = EqualityComparer<TKey>.Default;
					while (i < entries.Length)
					{
						if (entries[i].hashCode == num && @default.Equals(entries[i].key, key))
						{
							if (behavior == InsertionBehavior.OverwriteExisting)
							{
								entries[i].value = value;
								return true;
							}
							if (behavior == InsertionBehavior.ThrowOnExisting)
							{
								ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException(key);
							}
							return false;
						}
						else
						{
							i = entries[i].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
				}
			}
			else
			{
				while (i < entries.Length)
				{
					if (entries[i].hashCode == num && comparer.Equals(entries[i].key, key))
					{
						if (behavior == InsertionBehavior.OverwriteExisting)
						{
							entries[i].value = value;
							return true;
						}
						if (behavior == InsertionBehavior.ThrowOnExisting)
						{
							ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException(key);
						}
						return false;
					}
					else
					{
						i = entries[i].next;
						if (num2 >= entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
						num2++;
					}
				}
			}
			bool flag = false;
			bool flag2 = false;
			int num3;
			if (this._freeCount > 0)
			{
				num3 = this._freeList;
				flag2 = true;
				this._freeCount--;
			}
			else
			{
				int count = this._count;
				if (count == entries.Length)
				{
					this.Resize();
					flag = true;
				}
				num3 = count;
				this._count = count + 1;
				entries = this._entries;
			}
			ref int ptr2 = ref flag ? ref this._buckets[num % this._buckets.Length] : ref ptr;
			ref Dictionary<TKey, TValue>.Entry ptr3 = ref entries[num3];
			if (flag2)
			{
				this._freeList = ptr3.next;
			}
			ptr3.hashCode = num;
			ptr3.next = ptr2 - 1;
			ptr3.key = key;
			ptr3.value = value;
			ptr2 = num3 + 1;
			return true;
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Generic.Dictionary`2" /> instance is invalid.</exception>
		// Token: 0x06002F52 RID: 12114 RVA: 0x000C0544 File Offset: 0x000BE744
		public virtual void OnDeserialization(object sender)
		{
			SerializationInfo serializationInfo;
			HashHelpers.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				return;
			}
			int @int = serializationInfo.GetInt32("Version");
			int int2 = serializationInfo.GetInt32("HashSize");
			this._comparer = (IEqualityComparer<TKey>)serializationInfo.GetValue("Comparer", typeof(IEqualityComparer<TKey>));
			if (int2 != 0)
			{
				this.Initialize(int2);
				KeyValuePair<TKey, TValue>[] array = (KeyValuePair<TKey, TValue>[])serializationInfo.GetValue("KeyValuePairs", typeof(KeyValuePair<TKey, TValue>[]));
				if (array == null)
				{
					ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingKeys);
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Key == null)
					{
						ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_NullKey);
					}
					this.Add(array[i].Key, array[i].Value);
				}
			}
			else
			{
				this._buckets = null;
			}
			this._version = @int;
			HashHelpers.SerializationInfoTable.Remove(this);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000C0634 File Offset: 0x000BE834
		private void Resize()
		{
			this.Resize(HashHelpers.ExpandPrime(this._count), false);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x000C0648 File Offset: 0x000BE848
		private void Resize(int newSize, bool forceNewHashCodes)
		{
			int[] array = new int[newSize];
			Dictionary<TKey, TValue>.Entry[] array2 = new Dictionary<TKey, TValue>.Entry[newSize];
			int count = this._count;
			Array.Copy(this._entries, 0, array2, 0, count);
			if (default(TKey) == null && forceNewHashCodes)
			{
				for (int i = 0; i < count; i++)
				{
					if (array2[i].hashCode >= 0)
					{
						array2[i].hashCode = (array2[i].key.GetHashCode() & int.MaxValue);
					}
				}
			}
			for (int j = 0; j < count; j++)
			{
				if (array2[j].hashCode >= 0)
				{
					int num = array2[j].hashCode % newSize;
					array2[j].next = array[num] - 1;
					array[num] = j + 1;
				}
			}
			this._buckets = array;
			this._entries = array2;
		}

		/// <summary>Removes the value with the specified key from the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <param name="key">The key of the element to remove.</param>
		/// <returns>
		///     <see langword="true" /> if the element is successfully found and removed; otherwise, <see langword="false" />.  This method returns <see langword="false" /> if <paramref name="key" /> is not found in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002F55 RID: 12117 RVA: 0x000C0734 File Offset: 0x000BE934
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			if (this._buckets != null)
			{
				IEqualityComparer<TKey> comparer = this._comparer;
				int num = ((comparer != null) ? comparer.GetHashCode(key) : key.GetHashCode()) & int.MaxValue;
				int num2 = num % this._buckets.Length;
				int num3 = -1;
				Dictionary<TKey, TValue>.Entry ptr;
				for (int i = this._buckets[num2] - 1; i >= 0; i = ptr.next)
				{
					ptr = ref this._entries[i];
					if (ptr.hashCode == num)
					{
						IEqualityComparer<TKey> comparer2 = this._comparer;
						if ((comparer2 != null) ? comparer2.Equals(ptr.key, key) : EqualityComparer<TKey>.Default.Equals(ptr.key, key))
						{
							if (num3 < 0)
							{
								this._buckets[num2] = ptr.next + 1;
							}
							else
							{
								this._entries[num3].next = ptr.next;
							}
							ptr.hashCode = -1;
							ptr.next = this._freeList;
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
							{
								ptr.key = default(TKey);
							}
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
							{
								ptr.value = default(TValue);
							}
							this._freeList = i;
							this._freeCount++;
							this._version++;
							return true;
						}
					}
					num3 = i;
				}
			}
			return false;
		}

		/// <summary>Gets the value associated with the specified key.</summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value" /> parameter. This parameter is passed uninitialized.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.Dictionary`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002F56 RID: 12118 RVA: 0x000C088C File Offset: 0x000BEA8C
		public bool TryGetValue(TKey key, out TValue value)
		{
			int num = this.FindEntry(key);
			if (num >= 0)
			{
				value = this._entries[num].value;
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000C08C6 File Offset: 0x000BEAC6
		public bool TryAdd(TKey key, TValue value)
		{
			return this.TryInsert(key, value, InsertionBehavior.None);
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000C08D1 File Offset: 0x000BEAD1
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			this.CopyTo(array, index);
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1" /> to an array, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or-
		///         <paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.Generic.ICollection`1" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.Generic.ICollection`1" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x06002F5A RID: 12122 RVA: 0x000C08DC File Offset: 0x000BEADC
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			if (index > array.Length)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			if (array3 != null)
			{
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				for (int i = 0; i < this._count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array3[index++] = new DictionaryEntry(entries[i].key, entries[i].value);
					}
				}
				return;
			}
			object[] array4 = array as object[];
			if (array4 == null)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
			try
			{
				int count = this._count;
				Dictionary<TKey, TValue>.Entry[] entries2 = this._entries;
				for (int j = 0; j < count; j++)
				{
					if (entries2[j].hashCode >= 0)
					{
						array4[index++] = new KeyValuePair<TKey, TValue>(entries2[j].key, entries2[j].value);
					}
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06002F5B RID: 12123 RVA: 0x000C001B File Offset: 0x000BE21B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />. </returns>
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000C0A3C File Offset: 0x000BEC3C
		object ICollection.SyncRoot
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

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> has a fixed size; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> is read-only; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000C0A5E File Offset: 0x000BEC5E
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000C0A66 File Offset: 0x000BEC66
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Gets or sets the value with the specified key.</summary>
		/// <param name="key">The key of the value to get.</param>
		/// <returns>The value associated with the specified key, or <see langword="null" /> if <paramref name="key" /> is not in the dictionary or <paramref name="key" /> is of a type that is not assignable to the key type <paramref name="TKey" /> of the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">A value is being assigned, and <paramref name="key" /> is of a type that is not assignable to the key type <paramref name="TKey" /> of the <see cref="T:System.Collections.Generic.Dictionary`2" />.-or-
		///         A value is being assigned, and <paramref name="value" /> is of a type that is not assignable to the value type <paramref name="TValue" /> of the <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		// Token: 0x1700079D RID: 1949
		object IDictionary.this[object key]
		{
			get
			{
				if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
				{
					int num = this.FindEntry((TKey)((object)key));
					if (num >= 0)
					{
						return this._entries[num].value;
					}
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
				}
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
				try
				{
					TKey key2 = (TKey)((object)key);
					try
					{
						this[key2] = (TValue)((object)value);
					}
					catch (InvalidCastException)
					{
						ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(TValue));
					}
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof(TKey));
				}
			}
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000C0B28 File Offset: 0x000BED28
		private static bool IsCompatibleKey(object key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			return key is TKey;
		}

		/// <summary>Adds the specified key and value to the dictionary.</summary>
		/// <param name="key">The object to use as the key.</param>
		/// <param name="value">The object to use as the value.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="key" /> is of a type that is not assignable to the key type <paramref name="TKey" /> of the <see cref="T:System.Collections.Generic.Dictionary`2" />.-or-
		///         <paramref name="value" /> is of a type that is not assignable to <paramref name="TValue" />, the type of values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.-or-A value with the same key already exists in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		// Token: 0x06002F65 RID: 12133 RVA: 0x000C0B3C File Offset: 0x000BED3C
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
			try
			{
				TKey key2 = (TKey)((object)key);
				try
				{
					this.Add(key2, (TValue)((object)value));
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(TValue));
				}
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof(TKey));
			}
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IDictionary" /> contains an element with the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002F66 RID: 12134 RVA: 0x000C0BB4 File Offset: 0x000BEDB4
		bool IDictionary.Contains(object key)
		{
			return Dictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06002F67 RID: 12135 RVA: 0x000C0BCC File Offset: 0x000BEDCC
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 1);
		}

		/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">The key of the element to remove.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002F68 RID: 12136 RVA: 0x000C0BDA File Offset: 0x000BEDDA
		void IDictionary.Remove(object key)
		{
			if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
			{
				this.Remove((TKey)((object)key));
			}
		}

		// Token: 0x040018F1 RID: 6385
		private int[] _buckets;

		// Token: 0x040018F2 RID: 6386
		private Dictionary<TKey, TValue>.Entry[] _entries;

		// Token: 0x040018F3 RID: 6387
		private int _count;

		// Token: 0x040018F4 RID: 6388
		private int _freeList;

		// Token: 0x040018F5 RID: 6389
		private int _freeCount;

		// Token: 0x040018F6 RID: 6390
		private int _version;

		// Token: 0x040018F7 RID: 6391
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x040018F8 RID: 6392
		private Dictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x040018F9 RID: 6393
		private Dictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x040018FA RID: 6394
		private object _syncRoot;

		// Token: 0x0200060E RID: 1550
		private struct Entry
		{
			// Token: 0x040018FB RID: 6395
			public int hashCode;

			// Token: 0x040018FC RID: 6396
			public int next;

			// Token: 0x040018FD RID: 6397
			public TKey key;

			// Token: 0x040018FE RID: 6398
			public TValue value;
		}

		/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		// Token: 0x0200060F RID: 1551
		[Serializable]
		public struct Enumerator : IEnumerator<KeyValuePair<!0, !1>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x06002F69 RID: 12137 RVA: 0x000C0BF1 File Offset: 0x000BEDF1
			internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				this._dictionary = dictionary;
				this._version = dictionary._version;
				this._index = 0;
				this._getEnumeratorRetType = getEnumeratorRetType;
				this._current = default(KeyValuePair<TKey, TValue>);
			}

			/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
			/// <returns>
			///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06002F6A RID: 12138 RVA: 0x000C0C20 File Offset: 0x000BEE20
			public bool MoveNext()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				while (this._index < this._dictionary._count)
				{
					Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
					int index = this._index;
					this._index = index + 1;
					ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
					if (ptr.hashCode >= 0)
					{
						this._current = new KeyValuePair<TKey, TValue>(ptr.key, ptr.value);
						return true;
					}
				}
				this._index = this._dictionary._count + 1;
				this._current = default(KeyValuePair<TKey, TValue>);
				return false;
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the <see cref="T:System.Collections.Generic.Dictionary`2" /> at the current position of the enumerator.</returns>
			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000C0CBE File Offset: 0x000BEEBE
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					return this._current;
				}
			}

			/// <summary>Releases all resources used by the <see cref="T:System.Collections.Generic.Dictionary`2.Enumerator" />.</summary>
			// Token: 0x06002F6C RID: 12140 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Dispose()
			{
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the collection at the current position of the enumerator, as an <see cref="T:System.Object" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x06002F6D RID: 12141 RVA: 0x000C0CC8 File Offset: 0x000BEEC8
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					if (this._getEnumeratorRetType == 1)
					{
						return new DictionaryEntry(this._current.Key, this._current.Value);
					}
					return new KeyValuePair<TKey, TValue>(this._current.Key, this._current.Value);
				}
			}

			/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06002F6E RID: 12142 RVA: 0x000C0D4B File Offset: 0x000BEF4B
			void IEnumerator.Reset()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(KeyValuePair<TKey, TValue>);
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the dictionary at the current position of the enumerator, as a <see cref="T:System.Collections.DictionaryEntry" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000C0D78 File Offset: 0x000BEF78
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return new DictionaryEntry(this._current.Key, this._current.Value);
				}
			}

			/// <summary>Gets the key of the element at the current position of the enumerator.</summary>
			/// <returns>The key of the element in the dictionary at the current position of the enumerator.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000C0DCC File Offset: 0x000BEFCC
			object IDictionaryEnumerator.Key
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current.Key;
				}
			}

			/// <summary>Gets the value of the element at the current position of the enumerator.</summary>
			/// <returns>The value of the element in the dictionary at the current position of the enumerator.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000C0E00 File Offset: 0x000BF000
			object IDictionaryEnumerator.Value
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current.Value;
				}
			}

			// Token: 0x040018FF RID: 6399
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x04001900 RID: 6400
			private int _version;

			// Token: 0x04001901 RID: 6401
			private int _index;

			// Token: 0x04001902 RID: 6402
			private KeyValuePair<TKey, TValue> _current;

			// Token: 0x04001903 RID: 6403
			private int _getEnumeratorRetType;
		}

		/// <summary>Represents the collection of keys in a <see cref="T:System.Collections.Generic.Dictionary`2" />. This class cannot be inherited.</summary>
		// Token: 0x02000610 RID: 1552
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> class that reflects the keys in the specified <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
			/// <param name="dictionary">The <see cref="T:System.Collections.Generic.Dictionary`2" /> whose keys are reflected in the new <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="dictionary" /> is <see langword="null" />.</exception>
			// Token: 0x06002F72 RID: 12146 RVA: 0x000C0E34 File Offset: 0x000BF034
			public KeyCollection(Dictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
				}
				this._dictionary = dictionary;
			}

			/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
			/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection.Enumerator" /> for the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</returns>
			// Token: 0x06002F73 RID: 12147 RVA: 0x000C0E4C File Offset: 0x000BF04C
			public Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Copies the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
			/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />. </exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="index" /> is less than zero.</exception>
			/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F74 RID: 12148 RVA: 0x000C0E5C File Offset: 0x000BF05C
			public void CopyTo(TKey[] array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (index < 0 || index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array[index++] = entries[i].key;
					}
				}
			}

			/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
			/// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.Retrieving the value of this property is an O(1) operation.</returns>
			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000C0EE4 File Offset: 0x000BF0E4
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06002F76 RID: 12150 RVA: 0x0000B18D File Offset: 0x0000938D
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06002F77 RID: 12151 RVA: 0x000C0EF1 File Offset: 0x000BF0F1
			void ICollection<!0>.Add(TKey item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			}

			// Token: 0x06002F78 RID: 12152 RVA: 0x000C0EF1 File Offset: 0x000BF0F1
			void ICollection<!0>.Clear()
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			}

			// Token: 0x06002F79 RID: 12153 RVA: 0x000C0EFA File Offset: 0x000BF0FA
			bool ICollection<!0>.Contains(TKey item)
			{
				return this._dictionary.ContainsKey(item);
			}

			// Token: 0x06002F7A RID: 12154 RVA: 0x000C0F08 File Offset: 0x000BF108
			bool ICollection<!0>.Remove(TKey item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
				return false;
			}

			// Token: 0x06002F7B RID: 12155 RVA: 0x000C0F12 File Offset: 0x000BF112
			IEnumerator<TKey> IEnumerable<!0>.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Returns an enumerator that iterates through a collection.</summary>
			/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
			// Token: 0x06002F7C RID: 12156 RVA: 0x000C0F12 File Offset: 0x000BF112
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
			/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="index" /> is less than zero.</exception>
			/// <exception cref="T:System.ArgumentException">
			///         <paramref name="array" /> is multidimensional.-or-
			///         <paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F7D RID: 12157 RVA: 0x000C0F24 File Offset: 0x000BF124
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (array.Rank != 1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
				}
				if (array.GetLowerBound(0) != 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
				}
				if (index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				TKey[] array2 = array as TKey[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				object[] array3 = array as object[];
				if (array3 == null)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].hashCode >= 0)
						{
							array3[index++] = entries[i].key;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
			}

			/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
			/// <returns>
			///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />, this property always returns <see langword="false" />.</returns>
			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06002F7E RID: 12158 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
			/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />, this property always returns the current instance.</returns>
			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06002F7F RID: 12159 RVA: 0x000C1010 File Offset: 0x000BF210
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x04001904 RID: 6404
			private Dictionary<TKey, TValue> _dictionary;

			/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
			// Token: 0x02000611 RID: 1553
			[Serializable]
			public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
			{
				// Token: 0x06002F80 RID: 12160 RVA: 0x000C101D File Offset: 0x000BF21D
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					this._dictionary = dictionary;
					this._version = dictionary._version;
					this._index = 0;
					this._currentKey = default(TKey);
				}

				/// <summary>Releases all resources used by the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection.Enumerator" />.</summary>
				// Token: 0x06002F81 RID: 12161 RVA: 0x00002A7D File Offset: 0x00000C7D
				public void Dispose()
				{
				}

				/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
				/// <returns>
				///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
				/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
				// Token: 0x06002F82 RID: 12162 RVA: 0x000C1048 File Offset: 0x000BF248
				public bool MoveNext()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					while (this._index < this._dictionary._count)
					{
						Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
						int index = this._index;
						this._index = index + 1;
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
						if (ptr.hashCode >= 0)
						{
							this._currentKey = ptr.key;
							return true;
						}
					}
					this._index = this._dictionary._count + 1;
					this._currentKey = default(TKey);
					return false;
				}

				/// <summary>Gets the element at the current position of the enumerator.</summary>
				/// <returns>The element in the <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> at the current position of the enumerator.</returns>
				// Token: 0x170007A7 RID: 1959
				// (get) Token: 0x06002F83 RID: 12163 RVA: 0x000C10DB File Offset: 0x000BF2DB
				public TKey Current
				{
					get
					{
						return this._currentKey;
					}
				}

				/// <summary>Gets the element at the current position of the enumerator.</summary>
				/// <returns>The element in the collection at the current position of the enumerator.</returns>
				/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
				// Token: 0x170007A8 RID: 1960
				// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000C10E3 File Offset: 0x000BF2E3
				object IEnumerator.Current
				{
					get
					{
						if (this._index == 0 || this._index == this._dictionary._count + 1)
						{
							ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
						}
						return this._currentKey;
					}
				}

				/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
				/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
				// Token: 0x06002F85 RID: 12165 RVA: 0x000C1112 File Offset: 0x000BF312
				void IEnumerator.Reset()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					this._index = 0;
					this._currentKey = default(TKey);
				}

				// Token: 0x04001905 RID: 6405
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x04001906 RID: 6406
				private int _index;

				// Token: 0x04001907 RID: 6407
				private int _version;

				// Token: 0x04001908 RID: 6408
				private TKey _currentKey;
			}
		}

		/// <summary>Represents the collection of values in a <see cref="T:System.Collections.Generic.Dictionary`2" />. This class cannot be inherited. </summary>
		// Token: 0x02000612 RID: 1554
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class ValueCollection : ICollection<!1>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> class that reflects the values in the specified <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
			/// <param name="dictionary">The <see cref="T:System.Collections.Generic.Dictionary`2" /> whose values are reflected in the new <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="dictionary" /> is <see langword="null" />.</exception>
			// Token: 0x06002F86 RID: 12166 RVA: 0x000C113F File Offset: 0x000BF33F
			public ValueCollection(Dictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
				}
				this._dictionary = dictionary;
			}

			/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
			/// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection.Enumerator" /> for the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</returns>
			// Token: 0x06002F87 RID: 12167 RVA: 0x000C1157 File Offset: 0x000BF357
			public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Copies the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
			/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="index" /> is less than zero.</exception>
			/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F88 RID: 12168 RVA: 0x000C1164 File Offset: 0x000BF364
			public void CopyTo(TValue[] array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (index < 0 || index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array[index++] = entries[i].value;
					}
				}
			}

			/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
			/// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</returns>
			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06002F89 RID: 12169 RVA: 0x000C11EC File Offset: 0x000BF3EC
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06002F8A RID: 12170 RVA: 0x0000B18D File Offset: 0x0000938D
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06002F8B RID: 12171 RVA: 0x000C11F9 File Offset: 0x000BF3F9
			void ICollection<!1>.Add(TValue item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			}

			// Token: 0x06002F8C RID: 12172 RVA: 0x000C1202 File Offset: 0x000BF402
			bool ICollection<!1>.Remove(TValue item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
				return false;
			}

			// Token: 0x06002F8D RID: 12173 RVA: 0x000C11F9 File Offset: 0x000BF3F9
			void ICollection<!1>.Clear()
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			}

			// Token: 0x06002F8E RID: 12174 RVA: 0x000C120C File Offset: 0x000BF40C
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._dictionary.ContainsValue(item);
			}

			// Token: 0x06002F8F RID: 12175 RVA: 0x000C121A File Offset: 0x000BF41A
			IEnumerator<TValue> IEnumerable<!1>.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Returns an enumerator that iterates through a collection.</summary>
			/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
			// Token: 0x06002F90 RID: 12176 RVA: 0x000C121A File Offset: 0x000BF41A
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
			/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
			/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
			/// <exception cref="T:System.ArgumentNullException">
			///         <paramref name="array" /> is <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">
			///         <paramref name="index" /> is less than zero.</exception>
			/// <exception cref="T:System.ArgumentException">
			///         <paramref name="array" /> is multidimensional.-or-
			///         <paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
			// Token: 0x06002F91 RID: 12177 RVA: 0x000C122C File Offset: 0x000BF42C
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (array.Rank != 1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
				}
				if (array.GetLowerBound(0) != 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
				}
				if (index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				TValue[] array2 = array as TValue[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				object[] array3 = array as object[];
				if (array3 == null)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].hashCode >= 0)
						{
							array3[index++] = entries[i].value;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
			}

			/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
			/// <returns>
			///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />, this property always returns <see langword="false" />.</returns>
			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06002F92 RID: 12178 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
			/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />, this property always returns the current instance.</returns>
			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000C1318 File Offset: 0x000BF518
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x04001909 RID: 6409
			private Dictionary<TKey, TValue> _dictionary;

			/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
			// Token: 0x02000613 RID: 1555
			[Serializable]
			public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
			{
				// Token: 0x06002F94 RID: 12180 RVA: 0x000C1325 File Offset: 0x000BF525
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					this._dictionary = dictionary;
					this._version = dictionary._version;
					this._index = 0;
					this._currentValue = default(TValue);
				}

				/// <summary>Releases all resources used by the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection.Enumerator" />.</summary>
				// Token: 0x06002F95 RID: 12181 RVA: 0x00002A7D File Offset: 0x00000C7D
				public void Dispose()
				{
				}

				/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
				/// <returns>
				///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
				/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
				// Token: 0x06002F96 RID: 12182 RVA: 0x000C1350 File Offset: 0x000BF550
				public bool MoveNext()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					while (this._index < this._dictionary._count)
					{
						Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
						int index = this._index;
						this._index = index + 1;
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
						if (ptr.hashCode >= 0)
						{
							this._currentValue = ptr.value;
							return true;
						}
					}
					this._index = this._dictionary._count + 1;
					this._currentValue = default(TValue);
					return false;
				}

				/// <summary>Gets the element at the current position of the enumerator.</summary>
				/// <returns>The element in the <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> at the current position of the enumerator.</returns>
				// Token: 0x170007AD RID: 1965
				// (get) Token: 0x06002F97 RID: 12183 RVA: 0x000C13E3 File Offset: 0x000BF5E3
				public TValue Current
				{
					get
					{
						return this._currentValue;
					}
				}

				/// <summary>Gets the element at the current position of the enumerator.</summary>
				/// <returns>The element in the collection at the current position of the enumerator.</returns>
				/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
				// Token: 0x170007AE RID: 1966
				// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000C13EB File Offset: 0x000BF5EB
				object IEnumerator.Current
				{
					get
					{
						if (this._index == 0 || this._index == this._dictionary._count + 1)
						{
							ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
						}
						return this._currentValue;
					}
				}

				/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
				/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
				// Token: 0x06002F99 RID: 12185 RVA: 0x000C141A File Offset: 0x000BF61A
				void IEnumerator.Reset()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					this._index = 0;
					this._currentValue = default(TValue);
				}

				// Token: 0x0400190A RID: 6410
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x0400190B RID: 6411
				private int _index;

				// Token: 0x0400190C RID: 6412
				private int _version;

				// Token: 0x0400190D RID: 6413
				private TValue _currentValue;
			}
		}
	}
}
