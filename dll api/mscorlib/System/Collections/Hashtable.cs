using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections
{
	/// <summary>Represents a collection of key/value pairs that are organized based on the hash code of the key.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020005F5 RID: 1525
	[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
	{
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x000BBC66 File Offset: 0x000B9E66
		private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable
		{
			get
			{
				return LazyInitializer.EnsureInitialized<ConditionalWeakTable<object, SerializationInfo>>(ref Hashtable.s_serializationInfoTable);
			}
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal Hashtable(bool trash)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity, load factor, hash code provider, and comparer.</summary>
		// Token: 0x06002DF2 RID: 11762 RVA: 0x000BBC72 File Offset: 0x000B9E72
		public Hashtable() : this(0, 1f)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, and the default load factor, hash code provider, and comparer.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero. </exception>
		// Token: 0x06002DF3 RID: 11763 RVA: 0x000BBC80 File Offset: 0x000B9E80
		public Hashtable(int capacity) : this(capacity, 1f)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and load factor, and the default hash code provider and comparer.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero.-or- 
		///         <paramref name="loadFactor" /> is less than 0.1.-or- 
		///         <paramref name="loadFactor" /> is greater than 1.0. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="capacity" /> is causing an overflow.</exception>
		// Token: 0x06002DF4 RID: 11764 RVA: 0x000BBC90 File Offset: 0x000B9E90
		public Hashtable(int capacity, float loadFactor)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "Non-negative number required.");
			}
			if (loadFactor < 0.1f || loadFactor > 1f)
			{
				throw new ArgumentOutOfRangeException("loadFactor", SR.Format("Load factor needs to be between 0.1 and 1.0.", 0.1, 1.0));
			}
			this._loadFactor = 0.72f * loadFactor;
			double num = (double)((float)capacity / this._loadFactor);
			if (num > 2147483647.0)
			{
				throw new ArgumentException("Hashtable's capacity overflowed and went negative. Check load factor, capacity and the current size of the table.", "capacity");
			}
			int num2 = (num > 3.0) ? HashHelpers.GetPrime((int)num) : 3;
			this._buckets = new Hashtable.bucket[num2];
			this._loadsize = (int)(this._loadFactor * (float)num2);
			this._isWriterInProgress = false;
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, and <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- 
		///       <see langword="null" /> to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero.-or- 
		///         <paramref name="loadFactor" /> is less than 0.1.-or- 
		///         <paramref name="loadFactor" /> is greater than 1.0. </exception>
		// Token: 0x06002DF5 RID: 11765 RVA: 0x000BBD68 File Offset: 0x000B9F68
		public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) : this(capacity, loadFactor)
		{
			this._keycomparer = equalityComparer;
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" /> object.-or- 
		///       <see langword="null" /> to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		// Token: 0x06002DF6 RID: 11766 RVA: 0x000BBD79 File Offset: 0x000B9F79
		public Hashtable(IEqualityComparer equalityComparer) : this(0, 1f, equalityComparer)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and <see cref="T:System.Collections.IEqualityComparer" />, and the default load factor.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- 
		///       <see langword="null" /> to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero. </exception>
		// Token: 0x06002DF7 RID: 11767 RVA: 0x000BBD88 File Offset: 0x000B9F88
		public Hashtable(int capacity, IEqualityComparer equalityComparer) : this(capacity, 1f, equalityComparer)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06002DF8 RID: 11768 RVA: 0x000BBD97 File Offset: 0x000B9F97
		protected Hashtable(SerializationInfo info, StreamingContext context)
		{
			Hashtable.SerializationInfoTable.Add(this, info);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x000BBDAC File Offset: 0x000B9FAC
		private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
		{
			uint num = (uint)(this.GetHash(key) & int.MaxValue);
			seed = num;
			incr = 1U + seed * 101U % (uint)(hashsize - 1);
			return num;
		}

		/// <summary>Adds an element with the specified key and value into the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="key">The key of the element to add. </param>
		/// <param name="value">The value of the element to add. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Hashtable" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception>
		// Token: 0x06002DFA RID: 11770 RVA: 0x000BBDD9 File Offset: 0x000B9FD9
		public virtual void Add(object key, object value)
		{
			this.Insert(key, value, true);
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only. </exception>
		// Token: 0x06002DFB RID: 11771 RVA: 0x000BBDE4 File Offset: 0x000B9FE4
		public virtual void Clear()
		{
			if (this._count == 0 && this._occupancy == 0)
			{
				return;
			}
			this._isWriterInProgress = true;
			for (int i = 0; i < this._buckets.Length; i++)
			{
				this._buckets[i].hash_coll = 0;
				this._buckets[i].key = null;
				this._buckets[i].val = null;
			}
			this._count = 0;
			this._occupancy = 0;
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x06002DFC RID: 11772 RVA: 0x000BBE74 File Offset: 0x000BA074
		public virtual object Clone()
		{
			Hashtable.bucket[] buckets = this._buckets;
			Hashtable hashtable = new Hashtable(this._count, this._keycomparer);
			hashtable._version = this._version;
			hashtable._loadFactor = this._loadFactor;
			hashtable._count = 0;
			int i = buckets.Length;
			while (i > 0)
			{
				i--;
				object key = buckets[i].key;
				if (key != null && key != buckets)
				{
					hashtable[key] = buckets[i].val;
				}
			}
			return hashtable;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06002DFD RID: 11773 RVA: 0x000BBEF3 File Offset: 0x000BA0F3
		public virtual bool Contains(object key)
		{
			return this.ContainsKey(key);
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06002DFE RID: 11774 RVA: 0x000BBEFC File Offset: 0x000BA0FC
		public virtual bool ContainsKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			Hashtable.bucket[] buckets = this._buckets;
			uint num2;
			uint num3;
			uint num = this.InitHash(key, buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = (int)(num2 % (uint)buckets.Length);
			for (;;)
			{
				Hashtable.bucket bucket = buckets[num5];
				if (bucket.key == null)
				{
					break;
				}
				if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
				{
					return true;
				}
				num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)buckets.Length));
				if (bucket.hash_coll >= 0 || ++num4 >= buckets.Length)
				{
					return false;
				}
			}
			return false;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific value.</summary>
		/// <param name="value">The value to locate in the <see cref="T:System.Collections.Hashtable" />. The value can be <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified <paramref name="value" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002DFF RID: 11775 RVA: 0x000BBF9C File Offset: 0x000BA19C
		public virtual bool ContainsValue(object value)
		{
			if (value == null)
			{
				int num = this._buckets.Length;
				while (--num >= 0)
				{
					if (this._buckets[num].key != null && this._buckets[num].key != this._buckets && this._buckets[num].val == null)
					{
						return true;
					}
				}
			}
			else
			{
				int num2 = this._buckets.Length;
				while (--num2 >= 0)
				{
					object val = this._buckets[num2].val;
					if (val != null && val.Equals(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000BC038 File Offset: 0x000BA238
		private void CopyKeys(Array array, int arrayIndex)
		{
			Hashtable.bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					array.SetValue(key, arrayIndex++);
				}
			}
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x000BC080 File Offset: 0x000BA280
		private void CopyEntries(Array array, int arrayIndex)
		{
			Hashtable.bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					DictionaryEntry dictionaryEntry = new DictionaryEntry(key, buckets[num].val);
					array.SetValue(dictionaryEntry, arrayIndex++);
				}
			}
		}

		/// <summary>Copies the <see cref="T:System.Collections.Hashtable" /> elements to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Hashtable" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Hashtable" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Hashtable" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x06002E02 RID: 11778 RVA: 0x000BC0E4 File Offset: 0x000BA2E4
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
			this.CopyEntries(array, arrayIndex);
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000BC154 File Offset: 0x000BA354
		private void CopyValues(Array array, int arrayIndex)
		{
			Hashtable.bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					array.SetValue(buckets[num].val, arrayIndex++);
				}
			}
		}

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <param name="key">The key whose value to get or set. </param>
		/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns <see langword="null" />, and attempting to set it creates a new element using the specified key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception>
		// Token: 0x1700072D RID: 1837
		public virtual object this[object key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				Hashtable.bucket[] buckets = this._buckets;
				uint num2;
				uint num3;
				uint num = this.InitHash(key, buckets.Length, out num2, out num3);
				int num4 = 0;
				int num5 = (int)(num2 % (uint)buckets.Length);
				Hashtable.bucket bucket;
				for (;;)
				{
					SpinWait spinWait = default(SpinWait);
					for (;;)
					{
						int version = this._version;
						bucket = buckets[num5];
						if (!this._isWriterInProgress && version == this._version)
						{
							break;
						}
						spinWait.SpinOnce();
					}
					if (bucket.key == null)
					{
						break;
					}
					if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
					{
						goto Block_5;
					}
					num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)buckets.Length));
					if (bucket.hash_coll >= 0 || ++num4 >= buckets.Length)
					{
						goto IL_CA;
					}
				}
				return null;
				Block_5:
				return bucket.val;
				IL_CA:
				return null;
			}
			set
			{
				this.Insert(key, value, false);
			}
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000BC28C File Offset: 0x000BA48C
		private void expand()
		{
			int newsize = HashHelpers.ExpandPrime(this._buckets.Length);
			this.rehash(newsize);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000BC2AE File Offset: 0x000BA4AE
		private void rehash()
		{
			this.rehash(this._buckets.Length);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000BC2BE File Offset: 0x000BA4BE
		private void UpdateVersion()
		{
			this._version++;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000BC2D4 File Offset: 0x000BA4D4
		private void rehash(int newsize)
		{
			this._occupancy = 0;
			Hashtable.bucket[] array = new Hashtable.bucket[newsize];
			for (int i = 0; i < this._buckets.Length; i++)
			{
				Hashtable.bucket bucket = this._buckets[i];
				if (bucket.key != null && bucket.key != this._buckets)
				{
					int hashcode = bucket.hash_coll & int.MaxValue;
					this.putEntry(array, bucket.key, bucket.val, hashcode);
				}
			}
			this._isWriterInProgress = true;
			this._buckets = array;
			this._loadsize = (int)(this._loadFactor * (float)newsize);
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06002E0A RID: 11786 RVA: 0x000BC375 File Offset: 0x000BA575
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Hashtable.HashtableEnumerator(this, 3);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that iterates through the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x06002E0B RID: 11787 RVA: 0x000BC375 File Offset: 0x000BA575
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new Hashtable.HashtableEnumerator(this, 3);
		}

		/// <summary>Returns the hash code for the specified key.</summary>
		/// <param name="key">The <see cref="T:System.Object" /> for which a hash code is to be returned. </param>
		/// <returns>The hash code for <paramref name="key" />.</returns>
		/// <exception cref="T:System.NullReferenceException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06002E0C RID: 11788 RVA: 0x000BC37E File Offset: 0x000BA57E
		protected virtual int GetHash(object key)
		{
			if (this._keycomparer != null)
			{
				return this._keycomparer.GetHashCode(key);
			}
			return key.GetHashCode();
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> has a fixed size.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Compares a specific <see cref="T:System.Object" /> with a specific key in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="item">The <see cref="T:System.Object" /> to compare with <paramref name="key" />. </param>
		/// <param name="key">The key in the <see cref="T:System.Collections.Hashtable" /> to compare with <paramref name="item" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="item" /> and <paramref name="key" /> are equal; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="item" /> is <see langword="null" />.-or- 
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06002E10 RID: 11792 RVA: 0x000BC39B File Offset: 0x000BA59B
		protected virtual bool KeyEquals(object item, object key)
		{
			if (this._buckets == item)
			{
				return false;
			}
			if (item == key)
			{
				return true;
			}
			if (this._keycomparer != null)
			{
				return this._keycomparer.Equals(item, key);
			}
			return item != null && item.Equals(key);
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x000BC3D0 File Offset: 0x000BA5D0
		public virtual ICollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Hashtable.KeyCollection(this);
				}
				return this._keys;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000BC3EC File Offset: 0x000BA5EC
		public virtual ICollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Hashtable.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x000BC408 File Offset: 0x000BA608
		private void Insert(object key, object nvalue, bool add)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			if (this._count >= this._loadsize)
			{
				this.expand();
			}
			else if (this._occupancy > this._loadsize && this._count > 100)
			{
				this.rehash();
			}
			uint num2;
			uint num3;
			uint num = this.InitHash(key, this._buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = -1;
			int num6 = (int)(num2 % (uint)this._buckets.Length);
			for (;;)
			{
				if (num5 == -1 && this._buckets[num6].key == this._buckets && this._buckets[num6].hash_coll < 0)
				{
					num5 = num6;
				}
				if (this._buckets[num6].key == null || (this._buckets[num6].key == this._buckets && ((long)this._buckets[num6].hash_coll & (long)((ulong)-2147483648)) == 0L))
				{
					break;
				}
				if ((long)(this._buckets[num6].hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(this._buckets[num6].key, key))
				{
					goto Block_12;
				}
				if (num5 == -1 && this._buckets[num6].hash_coll >= 0)
				{
					Hashtable.bucket[] buckets = this._buckets;
					int num7 = num6;
					buckets[num7].hash_coll = (buckets[num7].hash_coll | int.MinValue);
					this._occupancy++;
				}
				num6 = (int)(((long)num6 + (long)((ulong)num3)) % (long)((ulong)this._buckets.Length));
				if (++num4 >= this._buckets.Length)
				{
					goto Block_16;
				}
			}
			if (num5 != -1)
			{
				num6 = num5;
			}
			this._isWriterInProgress = true;
			this._buckets[num6].val = nvalue;
			this._buckets[num6].key = key;
			Hashtable.bucket[] buckets2 = this._buckets;
			int num8 = num6;
			buckets2[num8].hash_coll = (buckets2[num8].hash_coll | (int)num);
			this._count++;
			this.UpdateVersion();
			this._isWriterInProgress = false;
			return;
			Block_12:
			if (add)
			{
				throw new ArgumentException(SR.Format("Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'", this._buckets[num6].key, key));
			}
			this._isWriterInProgress = true;
			this._buckets[num6].val = nvalue;
			this.UpdateVersion();
			this._isWriterInProgress = false;
			return;
			Block_16:
			if (num5 != -1)
			{
				this._isWriterInProgress = true;
				this._buckets[num5].val = nvalue;
				this._buckets[num5].key = key;
				Hashtable.bucket[] buckets3 = this._buckets;
				int num9 = num5;
				buckets3[num9].hash_coll = (buckets3[num9].hash_coll | (int)num);
				this._count++;
				this.UpdateVersion();
				this._isWriterInProgress = false;
				return;
			}
			throw new InvalidOperationException("Hashtable insert failed. Load factor too high. The most common cause is multiple threads writing to the Hashtable simultaneously.");
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000BC6D8 File Offset: 0x000BA8D8
		private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode)
		{
			uint num = (uint)(1 + hashcode * 101 % (newBuckets.Length - 1));
			int num2 = hashcode % newBuckets.Length;
			while (newBuckets[num2].key != null && newBuckets[num2].key != this._buckets)
			{
				if (newBuckets[num2].hash_coll >= 0)
				{
					int num3 = num2;
					newBuckets[num3].hash_coll = (newBuckets[num3].hash_coll | int.MinValue);
					this._occupancy++;
				}
				num2 = (int)(((long)num2 + (long)((ulong)num)) % (long)((ulong)newBuckets.Length));
			}
			newBuckets[num2].val = nvalue;
			newBuckets[num2].key = key;
			int num4 = num2;
			newBuckets[num4].hash_coll = (newBuckets[num4].hash_coll | hashcode);
		}

		/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="key">The key of the element to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception>
		// Token: 0x06002E15 RID: 11797 RVA: 0x000BC78C File Offset: 0x000BA98C
		public virtual void Remove(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			uint num2;
			uint num3;
			uint num = this.InitHash(key, this._buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = (int)(num2 % (uint)this._buckets.Length);
			for (;;)
			{
				Hashtable.bucket bucket = this._buckets[num5];
				if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
				{
					break;
				}
				num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)this._buckets.Length));
				if (bucket.hash_coll >= 0 || ++num4 >= this._buckets.Length)
				{
					return;
				}
			}
			this._isWriterInProgress = true;
			Hashtable.bucket[] buckets = this._buckets;
			int num6 = num5;
			buckets[num6].hash_coll = (buckets[num6].hash_coll & int.MinValue);
			if (this._buckets[num5].hash_coll != 0)
			{
				this._buckets[num5].key = this._buckets;
			}
			else
			{
				this._buckets[num5].key = null;
			}
			this._buckets[num5].val = null;
			this._count--;
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000BC8CA File Offset: 0x000BAACA
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

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</returns>
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000BC8EC File Offset: 0x000BAAEC
		public virtual int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>Returns a synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="table">The <see cref="T:System.Collections.Hashtable" /> to synchronize. </param>
		/// <returns>A synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="table" /> is <see langword="null" />. </exception>
		// Token: 0x06002E18 RID: 11800 RVA: 0x000BC8F4 File Offset: 0x000BAAF4
		public static Hashtable Synchronized(Hashtable table)
		{
			if (table == null)
			{
				throw new ArgumentNullException("table");
			}
			return new Hashtable.SyncHashtable(table);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified.</exception>
		// Token: 0x06002E19 RID: 11801 RVA: 0x000BC90C File Offset: 0x000BAB0C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				int version = this._version;
				info.AddValue("LoadFactor", this._loadFactor);
				info.AddValue("Version", this._version);
				IEqualityComparer keycomparer = this._keycomparer;
				if (keycomparer == null)
				{
					info.AddValue("Comparer", null, typeof(IComparer));
					info.AddValue("HashCodeProvider", null, typeof(IHashCodeProvider));
				}
				else if (keycomparer is CompatibleComparer)
				{
					CompatibleComparer compatibleComparer = keycomparer as CompatibleComparer;
					info.AddValue("Comparer", compatibleComparer.Comparer, typeof(IComparer));
					info.AddValue("HashCodeProvider", compatibleComparer.HashCodeProvider, typeof(IHashCodeProvider));
				}
				else
				{
					info.AddValue("KeyComparer", keycomparer, typeof(IEqualityComparer));
				}
				info.AddValue("HashSize", this._buckets.Length);
				object[] array = new object[this._count];
				object[] array2 = new object[this._count];
				this.CopyKeys(array, 0);
				this.CopyValues(array2, 0);
				info.AddValue("Keys", array, typeof(object[]));
				info.AddValue("Values", array2, typeof(object[]));
				if (this._version != version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Hashtable" /> is invalid. </exception>
		// Token: 0x06002E1A RID: 11802 RVA: 0x000BCAA8 File Offset: 0x000BACA8
		public virtual void OnDeserialization(object sender)
		{
			if (this._buckets != null)
			{
				return;
			}
			SerializationInfo serializationInfo;
			Hashtable.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				throw new SerializationException("OnDeserialization method was called while the object was not being deserialized.");
			}
			int num = 0;
			IComparer comparer = null;
			IHashCodeProvider hashCodeProvider = null;
			object[] array = null;
			object[] array2 = null;
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				uint num2 = <PrivateImplementationDetails>.ComputeStringHash(name);
				if (num2 <= 1613443821U)
				{
					if (num2 != 891156946U)
					{
						if (num2 != 1228509323U)
						{
							if (num2 == 1613443821U)
							{
								if (name == "Keys")
								{
									array = (object[])serializationInfo.GetValue("Keys", typeof(object[]));
								}
							}
						}
						else if (name == "KeyComparer")
						{
							this._keycomparer = (IEqualityComparer)serializationInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
						}
					}
					else if (name == "Comparer")
					{
						comparer = (IComparer)serializationInfo.GetValue("Comparer", typeof(IComparer));
					}
				}
				else if (num2 <= 2484309429U)
				{
					if (num2 != 2370642523U)
					{
						if (num2 == 2484309429U)
						{
							if (name == "HashCodeProvider")
							{
								hashCodeProvider = (IHashCodeProvider)serializationInfo.GetValue("HashCodeProvider", typeof(IHashCodeProvider));
							}
						}
					}
					else if (name == "Values")
					{
						array2 = (object[])serializationInfo.GetValue("Values", typeof(object[]));
					}
				}
				else if (num2 != 3356145248U)
				{
					if (num2 == 3483216242U)
					{
						if (name == "LoadFactor")
						{
							this._loadFactor = serializationInfo.GetSingle("LoadFactor");
						}
					}
				}
				else if (name == "HashSize")
				{
					num = serializationInfo.GetInt32("HashSize");
				}
			}
			this._loadsize = (int)(this._loadFactor * (float)num);
			if (this._keycomparer == null && (comparer != null || hashCodeProvider != null))
			{
				this._keycomparer = new CompatibleComparer(hashCodeProvider, comparer);
			}
			this._buckets = new Hashtable.bucket[num];
			if (array == null)
			{
				throw new SerializationException("The keys for this dictionary are missing.");
			}
			if (array2 == null)
			{
				throw new SerializationException("The values for this dictionary are missing.");
			}
			if (array.Length != array2.Length)
			{
				throw new SerializationException("The keys and values arrays have different sizes.");
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					throw new SerializationException("One of the serialized keys is null.");
				}
				this.Insert(array[i], array2[i], true);
			}
			this._version = serializationInfo.GetInt32("Version");
			Hashtable.SerializationInfoTable.Remove(this);
		}

		// Token: 0x040018AC RID: 6316
		private Hashtable.bucket[] _buckets;

		// Token: 0x040018AD RID: 6317
		private int _count;

		// Token: 0x040018AE RID: 6318
		private int _occupancy;

		// Token: 0x040018AF RID: 6319
		private int _loadsize;

		// Token: 0x040018B0 RID: 6320
		private float _loadFactor;

		// Token: 0x040018B1 RID: 6321
		private volatile int _version;

		// Token: 0x040018B2 RID: 6322
		private volatile bool _isWriterInProgress;

		// Token: 0x040018B3 RID: 6323
		private ICollection _keys;

		// Token: 0x040018B4 RID: 6324
		private ICollection _values;

		// Token: 0x040018B5 RID: 6325
		private IEqualityComparer _keycomparer;

		// Token: 0x040018B6 RID: 6326
		private object _syncRoot;

		// Token: 0x040018B7 RID: 6327
		private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable;

		// Token: 0x020005F6 RID: 1526
		private struct bucket
		{
			// Token: 0x040018B8 RID: 6328
			public object key;

			// Token: 0x040018B9 RID: 6329
			public object val;

			// Token: 0x040018BA RID: 6330
			public int hash_coll;
		}

		// Token: 0x020005F7 RID: 1527
		[Serializable]
		private class KeyCollection : ICollection, IEnumerable
		{
			// Token: 0x06002E1B RID: 11803 RVA: 0x000BCD8E File Offset: 0x000BAF8E
			internal KeyCollection(Hashtable hashtable)
			{
				this._hashtable = hashtable;
			}

			// Token: 0x06002E1C RID: 11804 RVA: 0x000BCDA0 File Offset: 0x000BAFA0
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < this._hashtable._count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				this._hashtable.CopyKeys(array, arrayIndex);
			}

			// Token: 0x06002E1D RID: 11805 RVA: 0x000BCE15 File Offset: 0x000BB015
			public virtual IEnumerator GetEnumerator()
			{
				return new Hashtable.HashtableEnumerator(this._hashtable, 1);
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06002E1E RID: 11806 RVA: 0x000BCE23 File Offset: 0x000BB023
			public virtual bool IsSynchronized
			{
				get
				{
					return this._hashtable.IsSynchronized;
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06002E1F RID: 11807 RVA: 0x000BCE30 File Offset: 0x000BB030
			public virtual object SyncRoot
			{
				get
				{
					return this._hashtable.SyncRoot;
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000BCE3D File Offset: 0x000BB03D
			public virtual int Count
			{
				get
				{
					return this._hashtable._count;
				}
			}

			// Token: 0x040018BB RID: 6331
			private Hashtable _hashtable;
		}

		// Token: 0x020005F8 RID: 1528
		[Serializable]
		private class ValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06002E21 RID: 11809 RVA: 0x000BCE4A File Offset: 0x000BB04A
			internal ValueCollection(Hashtable hashtable)
			{
				this._hashtable = hashtable;
			}

			// Token: 0x06002E22 RID: 11810 RVA: 0x000BCE5C File Offset: 0x000BB05C
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < this._hashtable._count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				this._hashtable.CopyValues(array, arrayIndex);
			}

			// Token: 0x06002E23 RID: 11811 RVA: 0x000BCED1 File Offset: 0x000BB0D1
			public virtual IEnumerator GetEnumerator()
			{
				return new Hashtable.HashtableEnumerator(this._hashtable, 2);
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000BCEDF File Offset: 0x000BB0DF
			public virtual bool IsSynchronized
			{
				get
				{
					return this._hashtable.IsSynchronized;
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06002E25 RID: 11813 RVA: 0x000BCEEC File Offset: 0x000BB0EC
			public virtual object SyncRoot
			{
				get
				{
					return this._hashtable.SyncRoot;
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000BCEF9 File Offset: 0x000BB0F9
			public virtual int Count
			{
				get
				{
					return this._hashtable._count;
				}
			}

			// Token: 0x040018BC RID: 6332
			private Hashtable _hashtable;
		}

		// Token: 0x020005F9 RID: 1529
		[Serializable]
		private class SyncHashtable : Hashtable, IEnumerable
		{
			// Token: 0x06002E27 RID: 11815 RVA: 0x000BCF06 File Offset: 0x000BB106
			internal SyncHashtable(Hashtable table) : base(false)
			{
				this._table = table;
			}

			// Token: 0x06002E28 RID: 11816 RVA: 0x000BCF16 File Offset: 0x000BB116
			internal SyncHashtable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06002E29 RID: 11817 RVA: 0x0002FCDD File Offset: 0x0002DEDD
			public override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000BCF25 File Offset: 0x000BB125
			public override int Count
			{
				get
				{
					return this._table.Count;
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000BCF32 File Offset: 0x000BB132
			public override bool IsReadOnly
			{
				get
				{
					return this._table.IsReadOnly;
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000BCF3F File Offset: 0x000BB13F
			public override bool IsFixedSize
			{
				get
				{
					return this._table.IsFixedSize;
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06002E2D RID: 11821 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700073F RID: 1855
			public override object this[object key]
			{
				get
				{
					return this._table[key];
				}
				set
				{
					object syncRoot = this._table.SyncRoot;
					lock (syncRoot)
					{
						this._table[key] = value;
					}
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06002E30 RID: 11824 RVA: 0x000BCFA8 File Offset: 0x000BB1A8
			public override object SyncRoot
			{
				get
				{
					return this._table.SyncRoot;
				}
			}

			// Token: 0x06002E31 RID: 11825 RVA: 0x000BCFB8 File Offset: 0x000BB1B8
			public override void Add(object key, object value)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Add(key, value);
				}
			}

			// Token: 0x06002E32 RID: 11826 RVA: 0x000BD004 File Offset: 0x000BB204
			public override void Clear()
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Clear();
				}
			}

			// Token: 0x06002E33 RID: 11827 RVA: 0x000BD050 File Offset: 0x000BB250
			public override bool Contains(object key)
			{
				return this._table.Contains(key);
			}

			// Token: 0x06002E34 RID: 11828 RVA: 0x000BD05E File Offset: 0x000BB25E
			public override bool ContainsKey(object key)
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				return this._table.ContainsKey(key);
			}

			// Token: 0x06002E35 RID: 11829 RVA: 0x000BD080 File Offset: 0x000BB280
			public override bool ContainsValue(object key)
			{
				object syncRoot = this._table.SyncRoot;
				bool result;
				lock (syncRoot)
				{
					result = this._table.ContainsValue(key);
				}
				return result;
			}

			// Token: 0x06002E36 RID: 11830 RVA: 0x000BD0D0 File Offset: 0x000BB2D0
			public override void CopyTo(Array array, int arrayIndex)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.CopyTo(array, arrayIndex);
				}
			}

			// Token: 0x06002E37 RID: 11831 RVA: 0x000BD11C File Offset: 0x000BB31C
			public override object Clone()
			{
				object syncRoot = this._table.SyncRoot;
				object result;
				lock (syncRoot)
				{
					result = Hashtable.Synchronized((Hashtable)this._table.Clone());
				}
				return result;
			}

			// Token: 0x06002E38 RID: 11832 RVA: 0x000BD174 File Offset: 0x000BB374
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._table.GetEnumerator();
			}

			// Token: 0x06002E39 RID: 11833 RVA: 0x000BD174 File Offset: 0x000BB374
			public override IDictionaryEnumerator GetEnumerator()
			{
				return this._table.GetEnumerator();
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000BD184 File Offset: 0x000BB384
			public override ICollection Keys
			{
				get
				{
					object syncRoot = this._table.SyncRoot;
					ICollection keys;
					lock (syncRoot)
					{
						keys = this._table.Keys;
					}
					return keys;
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000BD1D0 File Offset: 0x000BB3D0
			public override ICollection Values
			{
				get
				{
					object syncRoot = this._table.SyncRoot;
					ICollection values;
					lock (syncRoot)
					{
						values = this._table.Values;
					}
					return values;
				}
			}

			// Token: 0x06002E3C RID: 11836 RVA: 0x000BD21C File Offset: 0x000BB41C
			public override void Remove(object key)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Remove(key);
				}
			}

			// Token: 0x06002E3D RID: 11837 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void OnDeserialization(object sender)
			{
			}

			// Token: 0x040018BD RID: 6333
			protected Hashtable _table;
		}

		// Token: 0x020005FA RID: 1530
		[Serializable]
		private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
		{
			// Token: 0x06002E3E RID: 11838 RVA: 0x000BD268 File Offset: 0x000BB468
			internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
			{
				this._hashtable = hashtable;
				this._bucket = hashtable._buckets.Length;
				this._version = hashtable._version;
				this._current = false;
				this._getObjectRetType = getObjRetType;
			}

			// Token: 0x06002E3F RID: 11839 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000BD2A1 File Offset: 0x000BB4A1
			public virtual object Key
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					return this._currentKey;
				}
			}

			// Token: 0x06002E41 RID: 11841 RVA: 0x000BD2BC File Offset: 0x000BB4BC
			public virtual bool MoveNext()
			{
				if (this._version != this._hashtable._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				while (this._bucket > 0)
				{
					this._bucket--;
					object key = this._hashtable._buckets[this._bucket].key;
					if (key != null && key != this._hashtable._buckets)
					{
						this._currentKey = key;
						this._currentValue = this._hashtable._buckets[this._bucket].val;
						this._current = true;
						return true;
					}
				}
				this._current = false;
				return false;
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000BD366 File Offset: 0x000BB566
			public virtual DictionaryEntry Entry
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return new DictionaryEntry(this._currentKey, this._currentValue);
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06002E43 RID: 11843 RVA: 0x000BD38C File Offset: 0x000BB58C
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
						return this._currentKey;
					}
					if (this._getObjectRetType == 2)
					{
						return this._currentValue;
					}
					return new DictionaryEntry(this._currentKey, this._currentValue);
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000BD3E2 File Offset: 0x000BB5E2
			public virtual object Value
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._currentValue;
				}
			}

			// Token: 0x06002E45 RID: 11845 RVA: 0x000BD400 File Offset: 0x000BB600
			public virtual void Reset()
			{
				if (this._version != this._hashtable._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._current = false;
				this._bucket = this._hashtable._buckets.Length;
				this._currentKey = null;
				this._currentValue = null;
			}

			// Token: 0x040018BE RID: 6334
			private Hashtable _hashtable;

			// Token: 0x040018BF RID: 6335
			private int _bucket;

			// Token: 0x040018C0 RID: 6336
			private int _version;

			// Token: 0x040018C1 RID: 6337
			private bool _current;

			// Token: 0x040018C2 RID: 6338
			private int _getObjectRetType;

			// Token: 0x040018C3 RID: 6339
			private object _currentKey;

			// Token: 0x040018C4 RID: 6340
			private object _currentValue;
		}

		// Token: 0x020005FB RID: 1531
		internal class HashtableDebugView
		{
		}
	}
}
