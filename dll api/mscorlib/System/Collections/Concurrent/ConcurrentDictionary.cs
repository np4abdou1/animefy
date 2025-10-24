using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Represents a thread-safe collection of key/value pairs that can be accessed by multiple threads concurrently. </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	// Token: 0x020005FE RID: 1534
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06002E4A RID: 11850 RVA: 0x000BD480 File Offset: 0x000BB680
		private static bool IsValueWriteAtomic()
		{
			Type typeFromHandle = typeof(TValue);
			if (!typeFromHandle.IsValueType)
			{
				return true;
			}
			switch (Type.GetTypeCode(typeFromHandle))
			{
			case TypeCode.Boolean:
			case TypeCode.Char:
			case TypeCode.SByte:
			case TypeCode.Byte:
			case TypeCode.Int16:
			case TypeCode.UInt16:
			case TypeCode.Int32:
			case TypeCode.UInt32:
			case TypeCode.Single:
				return true;
			case TypeCode.Int64:
			case TypeCode.UInt64:
			case TypeCode.Double:
				return IntPtr.Size == 8;
			default:
				return false;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> class that is empty, has the default concurrency level, has the default initial capacity, and uses the default comparer for the key type.</summary>
		// Token: 0x06002E4B RID: 11851 RVA: 0x000BD4EF File Offset: 0x000BB6EF
		public ConcurrentDictionary() : this(ConcurrentDictionary<TKey, TValue>.DefaultConcurrencyLevel, 31, true, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> class that is empty, has the default concurrency level and capacity, and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="comparer">The equality comparison implementation to use when comparing keys.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="comparer" /> is <see langword="null" />.</exception>
		// Token: 0x06002E4C RID: 11852 RVA: 0x000BD500 File Offset: 0x000BB700
		public ConcurrentDictionary(IEqualityComparer<TKey> comparer) : this(ConcurrentDictionary<TKey, TValue>.DefaultConcurrencyLevel, 31, true, comparer)
		{
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x000BD514 File Offset: 0x000BB714
		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
			foreach (KeyValuePair<TKey, TValue> keyValuePair in collection)
			{
				if (keyValuePair.Key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				TValue tvalue;
				if (!this.TryAddInternal(keyValuePair.Key, this._comparer.GetHashCode(keyValuePair.Key), keyValuePair.Value, false, false, out tvalue))
				{
					throw new ArgumentException("The source argument contains duplicate keys.");
				}
			}
			if (this._budget == 0)
			{
				this._budget = this._tables._buckets.Length / this._tables._locks.Length;
			}
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x000BD5CC File Offset: 0x000BB7CC
		internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
		{
			if (concurrencyLevel < 1)
			{
				throw new ArgumentOutOfRangeException("concurrencyLevel", "The concurrencyLevel argument must be positive.");
			}
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "The capacity argument must be greater than or equal to zero.");
			}
			if (capacity < concurrencyLevel)
			{
				capacity = concurrencyLevel;
			}
			object[] array = new object[concurrencyLevel];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new object();
			}
			int[] countPerLock = new int[array.Length];
			ConcurrentDictionary<TKey, TValue>.Node[] array2 = new ConcurrentDictionary<TKey, TValue>.Node[capacity];
			this._tables = new ConcurrentDictionary<TKey, TValue>.Tables(array2, array, countPerLock);
			this._comparer = (comparer ?? EqualityComparer<TKey>.Default);
			this._growLockArray = growLockArray;
			this._budget = array2.Length / array.Length;
		}

		/// <summary>Attempts to add the specified key and value to the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add. The value can be  <see langword="null" /> for reference types.</param>
		/// <returns>
		///     <see langword="true" /> if the key/value pair was added to the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> successfully; <see langword="false" /> if the key already exists.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is  <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">The dictionary already contains the maximum number of elements (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06002E4F RID: 11855 RVA: 0x000BD670 File Offset: 0x000BB870
		public bool TryAdd(TKey key, TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			TValue tvalue;
			return this.TryAddInternal(key, this._comparer.GetHashCode(key), value, false, true, out tvalue);
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> contains the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002E50 RID: 11856 RVA: 0x000BD6A4 File Offset: 0x000BB8A4
		public bool ContainsKey(TKey key)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			TValue tvalue;
			return this.TryGetValue(key, out tvalue);
		}

		/// <summary>Attempts to remove and return the value that has the specified key from the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">The key of the element to remove and return.</param>
		/// <param name="value">When this method returns, contains the object removed from the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, or the default value of  the <see langword="TValue" /> type if <paramref name="key" /> does not exist.</param>
		/// <returns>
		///     <see langword="true" /> if the object was removed successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is  <see langword="null" />.</exception>
		// Token: 0x06002E51 RID: 11857 RVA: 0x000BD6C8 File Offset: 0x000BB8C8
		public bool TryRemove(TKey key, out TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return this.TryRemoveInternal(key, out value, false, default(TValue));
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000BD6F4 File Offset: 0x000BB8F4
		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			int hashCode = this._comparer.GetHashCode(key);
			for (;;)
			{
				ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
				int num;
				int num2;
				ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(hashCode, out num, out num2, tables._buckets.Length, tables._locks.Length);
				object obj = tables._locks[num2];
				lock (obj)
				{
					if (tables != this._tables)
					{
						continue;
					}
					ConcurrentDictionary<TKey, TValue>.Node node = null;
					ConcurrentDictionary<TKey, TValue>.Node node2 = tables._buckets[num];
					while (node2 != null)
					{
						if (hashCode == node2._hashcode && this._comparer.Equals(node2._key, key))
						{
							if (matchValue && !EqualityComparer<TValue>.Default.Equals(oldValue, node2._value))
							{
								value = default(TValue);
								return false;
							}
							if (node == null)
							{
								Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], node2._next);
							}
							else
							{
								node._next = node2._next;
							}
							value = node2._value;
							tables._countPerLock[num2]--;
							return true;
						}
						else
						{
							node = node2;
							node2 = node2._next;
						}
					}
				}
				break;
			}
			value = default(TValue);
			return false;
		}

		/// <summary>Attempts to get the value associated with the specified key from the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the object from the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> that has the specified key, or the default value of the type if the operation failed.</param>
		/// <returns>
		///     <see langword="true" /> if the key was found in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is  <see langword="null" />.</exception>
		// Token: 0x06002E53 RID: 11859 RVA: 0x000BD848 File Offset: 0x000BBA48
		public bool TryGetValue(TKey key, out TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return this.TryGetValueInternal(key, this._comparer.GetHashCode(key), out value);
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000BD86C File Offset: 0x000BBA6C
		private bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
			int bucket = ConcurrentDictionary<TKey, TValue>.GetBucket(hashcode, tables._buckets.Length);
			for (ConcurrentDictionary<TKey, TValue>.Node node = Volatile.Read<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[bucket]); node != null; node = node._next)
			{
				if (hashcode == node._hashcode && this._comparer.Equals(node._key, key))
				{
					value = node._value;
					return true;
				}
			}
			value = default(TValue);
			return false;
		}

		/// <summary>Removes all keys and values from the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		// Token: 0x06002E55 RID: 11861 RVA: 0x000BD8E4 File Offset: 0x000BBAE4
		public void Clear()
		{
			int toExclusive = 0;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				ConcurrentDictionary<TKey, TValue>.Tables tables = new ConcurrentDictionary<TKey, TValue>.Tables(new ConcurrentDictionary<TKey, TValue>.Node[31], this._tables._locks, new int[this._tables._countPerLock.Length]);
				this._tables = tables;
				this._budget = Math.Max(1, tables._buckets.Length / tables._locks.Length);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000BD96C File Offset: 0x000BBB6C
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "The index argument is less than zero.");
			}
			int toExclusive = 0;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				int num = 0;
				int num2 = 0;
				while (num2 < this._tables._locks.Length && num >= 0)
				{
					num += this._tables._countPerLock[num2];
					num2++;
				}
				if (array.Length - num < index || num < 0)
				{
					throw new ArgumentException("The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.");
				}
				this.CopyToPairs(array, index);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		/// <summary>Copies the key and value pairs stored in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> to a new array.</summary>
		/// <returns>A new array containing a snapshot of key and value pairs copied from the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		// Token: 0x06002E57 RID: 11863 RVA: 0x000BDA14 File Offset: 0x000BBC14
		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			int toExclusive = 0;
			checked
			{
				KeyValuePair<TKey, TValue>[] result;
				try
				{
					this.AcquireAllLocks(ref toExclusive);
					int num = 0;
					for (int i = 0; i < this._tables._locks.Length; i++)
					{
						num += this._tables._countPerLock[i];
					}
					if (num == 0)
					{
						result = Array.Empty<KeyValuePair<TKey, TValue>>();
					}
					else
					{
						KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[num];
						this.CopyToPairs(array, 0);
						result = array;
					}
				}
				finally
				{
					this.ReleaseLocks(0, toExclusive);
				}
				return result;
			}
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000BDA98 File Offset: 0x000BBC98
		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
			foreach (ConcurrentDictionary<TKey, TValue>.Node node in this._tables._buckets)
			{
				while (node != null)
				{
					array[index] = new KeyValuePair<TKey, TValue>(node._key, node._value);
					index++;
					node = node._next;
				}
			}
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000BDAF0 File Offset: 0x000BBCF0
		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
			foreach (ConcurrentDictionary<TKey, TValue>.Node node in this._tables._buckets)
			{
				while (node != null)
				{
					array[index] = new DictionaryEntry(node._key, node._value);
					index++;
					node = node._next;
				}
			}
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000BDB54 File Offset: 0x000BBD54
		private void CopyToObjects(object[] array, int index)
		{
			foreach (ConcurrentDictionary<TKey, TValue>.Node node in this._tables._buckets)
			{
				while (node != null)
				{
					array[index] = new KeyValuePair<TKey, TValue>(node._key, node._value);
					index++;
					node = node._next;
				}
			}
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <returns>An enumerator for the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		// Token: 0x06002E5B RID: 11867 RVA: 0x000BDBAD File Offset: 0x000BBDAD
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			ConcurrentDictionary<TKey, TValue>.Node[] buckets = this._tables._buckets;
			int num;
			for (int i = 0; i < buckets.Length; i = num + 1)
			{
				ConcurrentDictionary<TKey, TValue>.Node current;
				for (current = Volatile.Read<ConcurrentDictionary<TKey, TValue>.Node>(ref buckets[i]); current != null; current = current._next)
				{
					yield return new KeyValuePair<TKey, TValue>(current._key, current._value);
				}
				current = null;
				num = i;
			}
			yield break;
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000BDBBC File Offset: 0x000BBDBC
		private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			checked
			{
				ConcurrentDictionary<TKey, TValue>.Tables tables;
				bool flag;
				for (;;)
				{
					tables = this._tables;
					int num;
					int num2;
					ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(hashcode, out num, out num2, tables._buckets.Length, tables._locks.Length);
					flag = false;
					bool flag2 = false;
					try
					{
						if (acquireLock)
						{
							Monitor.Enter(tables._locks[num2], ref flag2);
						}
						if (tables != this._tables)
						{
							continue;
						}
						ConcurrentDictionary<TKey, TValue>.Node node = null;
						for (ConcurrentDictionary<TKey, TValue>.Node node2 = tables._buckets[num]; node2 != null; node2 = node2._next)
						{
							if (hashcode == node2._hashcode && this._comparer.Equals(node2._key, key))
							{
								if (updateIfExists)
								{
									if (ConcurrentDictionary<TKey, TValue>.s_isValueWriteAtomic)
									{
										node2._value = value;
									}
									else
									{
										ConcurrentDictionary<TKey, TValue>.Node node3 = new ConcurrentDictionary<TKey, TValue>.Node(node2._key, value, hashcode, node2._next);
										if (node == null)
										{
											Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], node3);
										}
										else
										{
											node._next = node3;
										}
									}
									resultingValue = value;
								}
								else
								{
									resultingValue = node2._value;
								}
								return false;
							}
							node = node2;
						}
						Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], new ConcurrentDictionary<TKey, TValue>.Node(key, value, hashcode, tables._buckets[num]));
						tables._countPerLock[num2]++;
						if (tables._countPerLock[num2] > this._budget)
						{
							flag = true;
						}
					}
					finally
					{
						if (flag2)
						{
							Monitor.Exit(tables._locks[num2]);
						}
					}
					break;
				}
				if (flag)
				{
					this.GrowTable(tables);
				}
				resultingValue = value;
				return true;
			}
		}

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <param name="key">The key of the value to get or set.</param>
		/// <returns>The value of the key/value pair at the specified index.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is  <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> does not exist in the collection.</exception>
		// Token: 0x17000747 RID: 1863
		public TValue this[TKey key]
		{
			get
			{
				TValue result;
				if (!this.TryGetValue(key, out result))
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNotFoundException(key);
				}
				return result;
			}
			set
			{
				if (key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				TValue tvalue;
				this.TryAddInternal(key, this._comparer.GetHashCode(key), value, true, true, out tvalue);
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0002F730 File Offset: 0x0002D930
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowKeyNotFoundException(object key)
		{
			throw new KeyNotFoundException(SR.Format("The given key '{0}' was not present in the dictionary.", key.ToString()));
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000BDDB3 File Offset: 0x000BBFB3
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowKeyNullException()
		{
			throw new ArgumentNullException("key");
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		/// <exception cref="T:System.OverflowException">The dictionary already contains the maximum number of elements (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x000BDDC0 File Offset: 0x000BBFC0
		public int Count
		{
			get
			{
				int toExclusive = 0;
				int countInternal;
				try
				{
					this.AcquireAllLocks(ref toExclusive);
					countInternal = this.GetCountInternal();
				}
				finally
				{
					this.ReleaseLocks(0, toExclusive);
				}
				return countInternal;
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000BDDFC File Offset: 0x000BBFFC
		private int GetCountInternal()
		{
			int num = 0;
			for (int i = 0; i < this._tables._countPerLock.Length; i++)
			{
				num += this._tables._countPerLock[i];
			}
			return num;
		}

		/// <summary>Adds a key/value pair to the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> by using the specified function, if the key does not already exist.</summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="valueFactory">The function used to generate a value for the key</param>
		/// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value for the key as returned by valueFactory if the key was not in the dictionary.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> or <paramref name="valueFactory" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">The dictionary already contains the maximum number of elements (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06002E63 RID: 11875 RVA: 0x000BDE3C File Offset: 0x000BC03C
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (valueFactory == null)
			{
				throw new ArgumentNullException("valueFactory");
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue result;
			if (!this.TryGetValueInternal(key, hashCode, out result))
			{
				this.TryAddInternal(key, hashCode, valueFactory(key), false, true, out result);
			}
			return result;
		}

		/// <summary>Adds a key/value pair to the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> if the key does not already exist.</summary>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">the value to be added, if the key does not already exist</param>
		/// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">The dictionary already contains the maximum number of elements (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06002E64 RID: 11876 RVA: 0x000BDE94 File Offset: 0x000BC094
		public TValue GetOrAdd(TKey key, TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue result;
			if (!this.TryGetValueInternal(key, hashCode, out result))
			{
				this.TryAddInternal(key, hashCode, value, false, true, out result);
			}
			return result;
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000BDED6 File Offset: 0x000BC0D6
		void IDictionary<!0, !1>.Add(TKey key, TValue value)
		{
			if (!this.TryAdd(key, value))
			{
				throw new ArgumentException("The key already existed in the dictionary.");
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000BDEF0 File Offset: 0x000BC0F0
		bool IDictionary<!0, !1>.Remove(TKey key)
		{
			TValue tvalue;
			return this.TryRemove(key, out tvalue);
		}

		/// <summary>Gets a collection containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>A collection of keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000BDF06 File Offset: 0x000BC106
		public ICollection<TKey> Keys
		{
			get
			{
				return this.GetKeys();
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x000BDF06 File Offset: 0x000BC106
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.GetKeys();
			}
		}

		/// <summary>Gets a collection that contains the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>A collection that contains the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />. </returns>
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000BDF0E File Offset: 0x000BC10E
		public ICollection<TValue> Values
		{
			get
			{
				return this.GetValues();
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000BDF0E File Offset: 0x000BC10E
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.GetValues();
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000BDF16 File Offset: 0x000BC116
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			((IDictionary<!0, !1>)this).Add(keyValuePair.Key, keyValuePair.Value);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000BDF2C File Offset: 0x000BC12C
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			TValue x;
			return this.TryGetValue(keyValuePair.Key, out x) && EqualityComparer<TValue>.Default.Equals(x, keyValuePair.Value);
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000BDF60 File Offset: 0x000BC160
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			if (keyValuePair.Key == null)
			{
				throw new ArgumentNullException("keyValuePair", "TKey is a reference type and item.Key is null.");
			}
			TValue tvalue;
			return this.TryRemoveInternal(keyValuePair.Key, out tvalue, true, keyValuePair.Value);
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <returns>An enumerator for the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		// Token: 0x06002E6F RID: 11887 RVA: 0x000BDFA2 File Offset: 0x000BC1A2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Adds the specified key and value to the dictionary.</summary>
		/// <param name="key">The object to use as the key.</param>
		/// <param name="value">The object to use as the value.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="key" /> is of a type that is not assignable to the key type  of the <see cref="T:System.Collections.Generic.Dictionary`2" />. -or- 
		///         <paramref name="value" /> is of a type that is not assignable to the type of values in the <see cref="T:System.Collections.Generic.Dictionary`2" />. -or-A value with the same key already exists in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		/// <exception cref="T:System.OverflowException">The dictionary already contains the maximum number of elements (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06002E70 RID: 11888 RVA: 0x000BDFAC File Offset: 0x000BC1AC
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (!(key is TKey))
			{
				throw new ArgumentException("The key was of an incorrect type for this dictionary.");
			}
			TValue value2;
			try
			{
				value2 = (TValue)((object)value);
			}
			catch (InvalidCastException)
			{
				throw new ArgumentException("The value was of an incorrect type for this dictionary.");
			}
			((IDictionary<!0, !1>)this).Add((TKey)((object)key), value2);
		}

		/// <summary>Gets whether the <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002E71 RID: 11889 RVA: 0x000BE008 File Offset: 0x000BC208
		bool IDictionary.Contains(object key)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return key is TKey && this.ContainsKey((TKey)((object)key));
		}

		/// <summary>Provides a <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <returns>A <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x06002E72 RID: 11890 RVA: 0x000BE028 File Offset: 0x000BC228
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator(this);
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Generic.IDictionary`2" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.IDictionary`2" /> has a fixed size; otherwise, <see langword="false" />. For <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only; otherwise, <see langword="false" />. For <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, this property always returns <see langword="false" />.</returns>
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> that contains the keys of the  <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <returns>An interface that contains the keys of the <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x000BDF06 File Offset: 0x000BC106
		ICollection IDictionary.Keys
		{
			get
			{
				return this.GetKeys();
			}
		}

		/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">The key of the element to remove.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002E76 RID: 11894 RVA: 0x000BE030 File Offset: 0x000BC230
		void IDictionary.Remove(object key)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (key is TKey)
			{
				TValue tvalue;
				this.TryRemove((TKey)((object)key), out tvalue);
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> that contains the values in the <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>An interface that contains the values in the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x000BDF0E File Offset: 0x000BC10E
		ICollection IDictionary.Values
		{
			get
			{
				return this.GetValues();
			}
		}

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <param name="key">The key of the value to get or set.</param>
		/// <returns>The value associated with the specified key, or  <see langword="null" /> if <paramref name="key" /> is not in the dictionary or <paramref name="key" /> is of a type that is not assignable to the key type of the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is  <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">A value is being assigned, and <paramref name="key" /> is of a type that is not assignable to the key type or the value type of the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</exception>
		// Token: 0x17000752 RID: 1874
		object IDictionary.this[object key]
		{
			get
			{
				if (key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				TValue tvalue;
				if (key is TKey && this.TryGetValue((TKey)((object)key), out tvalue))
				{
					return tvalue;
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				if (!(key is TKey))
				{
					throw new ArgumentException("The key was of an incorrect type for this dictionary.");
				}
				if (!(value is TValue))
				{
					throw new ArgumentException("The value was of an incorrect type for this dictionary.");
				}
				this[(TKey)((object)key)] = (TValue)((object)value);
			}
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an array, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.ICollection" />. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="index" /> is equal to or greater than the length of the <paramref name="array" />. -or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		// Token: 0x06002E7A RID: 11898 RVA: 0x000BE0E4 File Offset: 0x000BC2E4
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "The index argument is less than zero.");
			}
			int toExclusive = 0;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
				int num = 0;
				int num2 = 0;
				while (num2 < tables._locks.Length && num >= 0)
				{
					num += tables._countPerLock[num2];
					num2++;
				}
				if (array.Length - num < index || num < 0)
				{
					throw new ArgumentException("The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.");
				}
				KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
				if (array2 != null)
				{
					this.CopyToPairs(array2, index);
				}
				else
				{
					DictionaryEntry[] array3 = array as DictionaryEntry[];
					if (array3 != null)
					{
						this.CopyToEntries(array3, index);
					}
					else
					{
						object[] array4 = array as object[];
						if (array4 == null)
						{
							throw new ArgumentException("The array is multidimensional, or the type parameter for the set cannot be cast automatically to the type of the destination array.", "array");
						}
						this.CopyToObjects(array4, index);
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized with the SyncRoot.</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />. For <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> this property always returns false.</returns>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />. This property is not supported.</summary>
		/// <returns>Always returns null.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported.</exception>
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x000BE1D8 File Offset: 0x000BC3D8
		object ICollection.SyncRoot
		{
			get
			{
				throw new NotSupportedException("The SyncRoot property may not be used for the synchronization of concurrent collections.");
			}
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000BE1E4 File Offset: 0x000BC3E4
		private void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			int toExclusive = 0;
			try
			{
				this.AcquireLocks(0, 1, ref toExclusive);
				if (tables == this._tables)
				{
					long num = 0L;
					for (int i = 0; i < tables._countPerLock.Length; i++)
					{
						num += (long)tables._countPerLock[i];
					}
					if (num < (long)(tables._buckets.Length / 4))
					{
						this._budget = 2 * this._budget;
						if (this._budget < 0)
						{
							this._budget = int.MaxValue;
						}
					}
					else
					{
						int num2 = 0;
						bool flag = false;
						object[] array;
						checked
						{
							try
							{
								num2 = tables._buckets.Length * 2 + 1;
								while (num2 % 3 == 0 || num2 % 5 == 0 || num2 % 7 == 0)
								{
									num2 += 2;
								}
								if (num2 > 2146435071)
								{
									flag = true;
								}
							}
							catch (OverflowException)
							{
								flag = true;
							}
							if (flag)
							{
								num2 = 2146435071;
								this._budget = int.MaxValue;
							}
							this.AcquireLocks(1, tables._locks.Length, ref toExclusive);
							array = tables._locks;
						}
						if (this._growLockArray && tables._locks.Length < 1024)
						{
							array = new object[tables._locks.Length * 2];
							Array.Copy(tables._locks, 0, array, 0, tables._locks.Length);
							for (int j = tables._locks.Length; j < array.Length; j++)
							{
								array[j] = new object();
							}
						}
						ConcurrentDictionary<TKey, TValue>.Node[] array2 = new ConcurrentDictionary<TKey, TValue>.Node[num2];
						int[] array3 = new int[array.Length];
						for (int k = 0; k < tables._buckets.Length; k++)
						{
							checked
							{
								ConcurrentDictionary<TKey, TValue>.Node next;
								for (ConcurrentDictionary<TKey, TValue>.Node node = tables._buckets[k]; node != null; node = next)
								{
									next = node._next;
									int num3;
									int num4;
									ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(node._hashcode, out num3, out num4, array2.Length, array.Length);
									array2[num3] = new ConcurrentDictionary<TKey, TValue>.Node(node._key, node._value, node._hashcode, array2[num3]);
									array3[num4]++;
								}
							}
						}
						this._budget = Math.Max(1, array2.Length / array.Length);
						this._tables = new ConcurrentDictionary<TKey, TValue>.Tables(array2, array, array3);
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000BE42C File Offset: 0x000BC62C
		private static int GetBucket(int hashcode, int bucketCount)
		{
			return (hashcode & int.MaxValue) % bucketCount;
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000BE437 File Offset: 0x000BC637
		private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			bucketNo = (hashcode & int.MaxValue) % bucketCount;
			lockNo = bucketNo % lockCount;
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x000BE44B File Offset: 0x000BC64B
		private static int DefaultConcurrencyLevel
		{
			get
			{
				return PlatformHelper.ProcessorCount;
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000BE454 File Offset: 0x000BC654
		private void AcquireAllLocks(ref int locksAcquired)
		{
			if (CDSCollectionETWBCLProvider.Log.IsEnabled())
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentDictionary_AcquiringAllLocks(this._tables._buckets.Length);
			}
			this.AcquireLocks(0, 1, ref locksAcquired);
			this.AcquireLocks(1, this._tables._locks.Length, ref locksAcquired);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000BE4A8 File Offset: 0x000BC6A8
		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
			object[] locks = this._tables._locks;
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				bool flag = false;
				try
				{
					Monitor.Enter(locks[i], ref flag);
				}
				finally
				{
					if (flag)
					{
						locksAcquired++;
					}
				}
			}
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000BE4F8 File Offset: 0x000BC6F8
		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				Monitor.Exit(this._tables._locks[i]);
			}
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000BE528 File Offset: 0x000BC728
		private ReadOnlyCollection<TKey> GetKeys()
		{
			int toExclusive = 0;
			ReadOnlyCollection<TKey> result;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				int countInternal = this.GetCountInternal();
				if (countInternal < 0)
				{
					throw new OutOfMemoryException();
				}
				List<TKey> list = new List<TKey>(countInternal);
				for (int i = 0; i < this._tables._buckets.Length; i++)
				{
					for (ConcurrentDictionary<TKey, TValue>.Node node = this._tables._buckets[i]; node != null; node = node._next)
					{
						list.Add(node._key);
					}
				}
				result = new ReadOnlyCollection<TKey>(list);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
			return result;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x000BE5C0 File Offset: 0x000BC7C0
		private ReadOnlyCollection<TValue> GetValues()
		{
			int toExclusive = 0;
			ReadOnlyCollection<TValue> result;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				int countInternal = this.GetCountInternal();
				if (countInternal < 0)
				{
					throw new OutOfMemoryException();
				}
				List<TValue> list = new List<TValue>(countInternal);
				for (int i = 0; i < this._tables._buckets.Length; i++)
				{
					for (ConcurrentDictionary<TKey, TValue>.Node node = this._tables._buckets[i]; node != null; node = node._next)
					{
						list.Add(node._value);
					}
				}
				result = new ReadOnlyCollection<TValue>(list);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
			return result;
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x000BE658 File Offset: 0x000BC858
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
			this._serializationArray = this.ToArray();
			this._serializationConcurrencyLevel = tables._locks.Length;
			this._serializationCapacity = tables._buckets.Length;
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000BE696 File Offset: 0x000BC896
		[OnSerialized]
		private void OnSerialized(StreamingContext context)
		{
			this._serializationArray = null;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000BE6A0 File Offset: 0x000BC8A0
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			KeyValuePair<TKey, TValue>[] serializationArray = this._serializationArray;
			ConcurrentDictionary<TKey, TValue>.Node[] buckets = new ConcurrentDictionary<TKey, TValue>.Node[this._serializationCapacity];
			int[] countPerLock = new int[this._serializationConcurrencyLevel];
			object[] array = new object[this._serializationConcurrencyLevel];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new object();
			}
			this._tables = new ConcurrentDictionary<TKey, TValue>.Tables(buckets, array, countPerLock);
			this.InitializeFromCollection(serializationArray);
			this._serializationArray = null;
		}

		// Token: 0x040018C6 RID: 6342
		[NonSerialized]
		private volatile ConcurrentDictionary<TKey, TValue>.Tables _tables;

		// Token: 0x040018C7 RID: 6343
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x040018C8 RID: 6344
		[NonSerialized]
		private readonly bool _growLockArray;

		// Token: 0x040018C9 RID: 6345
		[NonSerialized]
		private int _budget;

		// Token: 0x040018CA RID: 6346
		private KeyValuePair<TKey, TValue>[] _serializationArray;

		// Token: 0x040018CB RID: 6347
		private int _serializationConcurrencyLevel;

		// Token: 0x040018CC RID: 6348
		private int _serializationCapacity;

		// Token: 0x040018CD RID: 6349
		private static readonly bool s_isValueWriteAtomic = ConcurrentDictionary<TKey, TValue>.IsValueWriteAtomic();

		// Token: 0x020005FF RID: 1535
		private sealed class Tables
		{
			// Token: 0x06002E8A RID: 11914 RVA: 0x000BE71D File Offset: 0x000BC91D
			internal Tables(ConcurrentDictionary<TKey, TValue>.Node[] buckets, object[] locks, int[] countPerLock)
			{
				this._buckets = buckets;
				this._locks = locks;
				this._countPerLock = countPerLock;
			}

			// Token: 0x040018CE RID: 6350
			internal readonly ConcurrentDictionary<TKey, TValue>.Node[] _buckets;

			// Token: 0x040018CF RID: 6351
			internal readonly object[] _locks;

			// Token: 0x040018D0 RID: 6352
			internal volatile int[] _countPerLock;
		}

		// Token: 0x02000600 RID: 1536
		[Serializable]
		private sealed class Node
		{
			// Token: 0x06002E8B RID: 11915 RVA: 0x000BE73C File Offset: 0x000BC93C
			internal Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
			{
				this._key = key;
				this._value = value;
				this._next = next;
				this._hashcode = hashcode;
			}

			// Token: 0x040018D1 RID: 6353
			internal readonly TKey _key;

			// Token: 0x040018D2 RID: 6354
			internal TValue _value;

			// Token: 0x040018D3 RID: 6355
			internal volatile ConcurrentDictionary<TKey, TValue>.Node _next;

			// Token: 0x040018D4 RID: 6356
			internal readonly int _hashcode;
		}

		// Token: 0x02000601 RID: 1537
		[Serializable]
		private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002E8C RID: 11916 RVA: 0x000BE763 File Offset: 0x000BC963
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
				this._enumerator = dictionary.GetEnumerator();
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06002E8D RID: 11917 RVA: 0x000BE778 File Offset: 0x000BC978
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

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06002E8E RID: 11918 RVA: 0x000BE7BC File Offset: 0x000BC9BC
			public object Key
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06002E8F RID: 11919 RVA: 0x000BE7E4 File Offset: 0x000BC9E4
			public object Value
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06002E90 RID: 11920 RVA: 0x000BE809 File Offset: 0x000BCA09
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x06002E91 RID: 11921 RVA: 0x000BE816 File Offset: 0x000BCA16
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06002E92 RID: 11922 RVA: 0x000BE823 File Offset: 0x000BCA23
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x040018D5 RID: 6357
			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;
		}
	}
}
