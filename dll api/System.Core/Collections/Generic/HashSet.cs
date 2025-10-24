using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	/// <summary>Represents a set of values.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <typeparam name="T">The type of elements in the hash set.</typeparam>
	// Token: 0x0200014C RID: 332
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.HashSet`1" /> class that is empty and uses the default equality comparer for the set type.</summary>
		// Token: 0x06000A82 RID: 2690 RVA: 0x00027202 File Offset: 0x00025402
		public HashSet() : this(EqualityComparer<T>.Default)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.HashSet`1" /> class that is empty and uses the specified equality comparer for the set type.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> implementation to use when comparing values in the set, or <see langword="null" /> to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1" /> implementation for the set type.</param>
		// Token: 0x06000A83 RID: 2691 RVA: 0x0002720F File Offset: 0x0002540F
		public HashSet(IEqualityComparer<T> comparer)
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<T>.Default;
			}
			this._comparer = comparer;
			this._lastIndex = 0;
			this._count = 0;
			this._freeList = -1;
			this._version = 0;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.HashSet`1" /> class that uses the default equality comparer for the set type, contains elements copied from the specified collection, and has sufficient capacity to accommodate the number of elements copied.</summary>
		/// <param name="collection">The collection whose elements are copied to the new set.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="collection" /> is <see langword="null" />.</exception>
		// Token: 0x06000A84 RID: 2692 RVA: 0x00027244 File Offset: 0x00025444
		public HashSet(IEnumerable<T> collection) : this(collection, EqualityComparer<T>.Default)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.HashSet`1" /> class that uses the specified equality comparer for the set type, contains elements copied from the specified collection, and has sufficient capacity to accommodate the number of elements copied.</summary>
		/// <param name="collection">The collection whose elements are copied to the new set.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> implementation to use when comparing values in the set, or <see langword="null" /> to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1" /> implementation for the set type.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="collection" /> is <see langword="null" />.</exception>
		// Token: 0x06000A85 RID: 2693 RVA: 0x00027254 File Offset: 0x00025454
		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer) : this(comparer)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			HashSet<T> hashSet = collection as HashSet<T>;
			if (hashSet != null && HashSet<T>.AreEqualityComparersEqual(this, hashSet))
			{
				this.CopyFrom(hashSet);
				return;
			}
			ICollection<T> collection2 = collection as ICollection<T>;
			int capacity = (collection2 == null) ? 0 : collection2.Count;
			this.Initialize(capacity);
			this.UnionWith(collection);
			if (this._count > 0 && this._slots.Length / this._count > 3)
			{
				this.TrimExcess();
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.HashSet`1" /> class with serialized data.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</param>
		// Token: 0x06000A86 RID: 2694 RVA: 0x000272D5 File Offset: 0x000254D5
		protected HashSet(SerializationInfo info, StreamingContext context)
		{
			this._siInfo = info;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000272E4 File Offset: 0x000254E4
		private void CopyFrom(HashSet<T> source)
		{
			int count = source._count;
			if (count == 0)
			{
				return;
			}
			int num = source._buckets.Length;
			if (HashHelpers.ExpandPrime(count + 1) >= num)
			{
				this._buckets = (int[])source._buckets.Clone();
				this._slots = (HashSet<T>.Slot[])source._slots.Clone();
				this._lastIndex = source._lastIndex;
				this._freeList = source._freeList;
			}
			else
			{
				int lastIndex = source._lastIndex;
				HashSet<T>.Slot[] slots = source._slots;
				this.Initialize(count);
				int num2 = 0;
				for (int i = 0; i < lastIndex; i++)
				{
					int hashCode = slots[i].hashCode;
					if (hashCode >= 0)
					{
						this.AddValue(num2, hashCode, slots[i].value);
						num2++;
					}
				}
				this._lastIndex = num2;
			}
			this._count = count;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000273BF File Offset: 0x000255BF
		void ICollection<!0>.Add(T item)
		{
			this.AddIfNotPresent(item);
		}

		/// <summary>Removes all elements from a <see cref="T:System.Collections.Generic.HashSet`1" /> object.</summary>
		// Token: 0x06000A89 RID: 2697 RVA: 0x000273CC File Offset: 0x000255CC
		public void Clear()
		{
			if (this._lastIndex > 0)
			{
				Array.Clear(this._slots, 0, this._lastIndex);
				Array.Clear(this._buckets, 0, this._buckets.Length);
				this._lastIndex = 0;
				this._count = 0;
				this._freeList = -1;
			}
			this._version++;
		}

		/// <summary>Determines whether a <see cref="T:System.Collections.Generic.HashSet`1" /> object contains the specified element.</summary>
		/// <param name="item">The element to locate in the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Generic.HashSet`1" /> object contains the specified element; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A8A RID: 2698 RVA: 0x0002742C File Offset: 0x0002562C
		public bool Contains(T item)
		{
			if (this._buckets != null)
			{
				int num = 0;
				int num2 = this.InternalGetHashCode(item);
				HashSet<T>.Slot[] slots = this._slots;
				for (int i = this._buckets[num2 % this._buckets.Length] - 1; i >= 0; i = slots[i].next)
				{
					if (slots[i].hashCode == num2 && this._comparer.Equals(slots[i].value, item))
					{
						return true;
					}
					if (num >= slots.Length)
					{
						throw new InvalidOperationException("Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.");
					}
					num++;
				}
			}
			return false;
		}

		/// <summary>Copies the elements of a <see cref="T:System.Collections.Generic.HashSet`1" /> object to an array, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.Generic.HashSet`1" /> object. The array must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="arrayIndex" /> is greater than the length of the destination <paramref name="array" />.</exception>
		// Token: 0x06000A8B RID: 2699 RVA: 0x000274BA File Offset: 0x000256BA
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.CopyTo(array, arrayIndex, this._count);
		}

		/// <summary>Removes the specified element from a <see cref="T:System.Collections.Generic.HashSet`1" /> object.</summary>
		/// <param name="item">The element to remove.</param>
		/// <returns>
		///     <see langword="true" /> if the element is successfully found and removed; otherwise, <see langword="false" />.  This method returns <see langword="false" /> if <paramref name="item" /> is not found in the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</returns>
		// Token: 0x06000A8C RID: 2700 RVA: 0x000274CC File Offset: 0x000256CC
		public bool Remove(T item)
		{
			if (this._buckets != null)
			{
				int num = this.InternalGetHashCode(item);
				int num2 = num % this._buckets.Length;
				int num3 = -1;
				int num4 = 0;
				HashSet<T>.Slot[] slots = this._slots;
				for (int i = this._buckets[num2] - 1; i >= 0; i = slots[i].next)
				{
					if (slots[i].hashCode == num && this._comparer.Equals(slots[i].value, item))
					{
						if (num3 < 0)
						{
							this._buckets[num2] = slots[i].next + 1;
						}
						else
						{
							slots[num3].next = slots[i].next;
						}
						slots[i].hashCode = -1;
						if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
						{
							slots[i].value = default(T);
						}
						slots[i].next = this._freeList;
						this._count--;
						this._version++;
						if (this._count == 0)
						{
							this._lastIndex = 0;
							this._freeList = -1;
						}
						else
						{
							this._freeList = i;
						}
						return true;
					}
					if (num4 >= slots.Length)
					{
						throw new InvalidOperationException("Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.");
					}
					num4++;
					num3 = i;
				}
			}
			return false;
		}

		/// <summary>Gets the number of elements that are contained in a set.</summary>
		/// <returns>The number of elements that are contained in the set.</returns>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0002762E File Offset: 0x0002582E
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00008049 File Offset: 0x00006249
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Returns an enumerator that iterates through a <see cref="T:System.Collections.Generic.HashSet`1" /> object.</summary>
		/// <returns>A <see cref="T:System.Collections.Generic.HashSet`1.Enumerator" /> object for the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</returns>
		// Token: 0x06000A8F RID: 2703 RVA: 0x00027636 File Offset: 0x00025836
		public HashSet<T>.Enumerator GetEnumerator()
		{
			return new HashSet<T>.Enumerator(this);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002763E File Offset: 0x0002583E
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new HashSet<T>.Enumerator(this);
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		// Token: 0x06000A91 RID: 2705 RVA: 0x0002763E File Offset: 0x0002583E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new HashSet<T>.Enumerator(this);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize a <see cref="T:System.Collections.Generic.HashSet`1" /> object.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.HashSet`1" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06000A92 RID: 2706 RVA: 0x0002764C File Offset: 0x0002584C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("Version", this._version);
			info.AddValue("Comparer", this._comparer, typeof(IComparer<T>));
			info.AddValue("Capacity", (this._buckets == null) ? 0 : this._buckets.Length);
			if (this._buckets != null)
			{
				T[] array = new T[this._count];
				this.CopyTo(array);
				info.AddValue("Elements", array, typeof(T[]));
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Generic.HashSet`1" /> object is invalid.</exception>
		// Token: 0x06000A93 RID: 2707 RVA: 0x000276E4 File Offset: 0x000258E4
		public virtual void OnDeserialization(object sender)
		{
			if (this._siInfo == null)
			{
				return;
			}
			int @int = this._siInfo.GetInt32("Capacity");
			this._comparer = (IEqualityComparer<T>)this._siInfo.GetValue("Comparer", typeof(IEqualityComparer<T>));
			this._freeList = -1;
			if (@int != 0)
			{
				this._buckets = new int[@int];
				this._slots = new HashSet<T>.Slot[@int];
				T[] array = (T[])this._siInfo.GetValue("Elements", typeof(T[]));
				if (array == null)
				{
					throw new SerializationException("The keys for this dictionary are missing.");
				}
				for (int i = 0; i < array.Length; i++)
				{
					this.AddIfNotPresent(array[i]);
				}
			}
			else
			{
				this._buckets = null;
			}
			this._version = this._siInfo.GetInt32("Version");
			this._siInfo = null;
		}

		/// <summary>Adds the specified element to a set.</summary>
		/// <param name="item">The element to add to the set.</param>
		/// <returns>
		///     <see langword="true" /> if the element is added to the <see cref="T:System.Collections.Generic.HashSet`1" /> object; <see langword="false" /> if the element is already present.</returns>
		// Token: 0x06000A94 RID: 2708 RVA: 0x000277C2 File Offset: 0x000259C2
		public bool Add(T item)
		{
			return this.AddIfNotPresent(item);
		}

		/// <summary>Modifies the current <see cref="T:System.Collections.Generic.HashSet`1" /> object to contain all elements that are present in itself, the specified collection, or both.</summary>
		/// <param name="other">The collection to compare to the current <see cref="T:System.Collections.Generic.HashSet`1" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="other" /> is <see langword="null" />.</exception>
		// Token: 0x06000A95 RID: 2709 RVA: 0x000277CC File Offset: 0x000259CC
		public void UnionWith(IEnumerable<T> other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			foreach (T value in other)
			{
				this.AddIfNotPresent(value);
			}
		}

		/// <summary>Copies the elements of a <see cref="T:System.Collections.Generic.HashSet`1" /> object to an array.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.Generic.HashSet`1" /> object. The array must have zero-based indexing.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		// Token: 0x06000A96 RID: 2710 RVA: 0x00027824 File Offset: 0x00025A24
		public void CopyTo(T[] array)
		{
			this.CopyTo(array, 0, this._count);
		}

		/// <summary>Copies the specified number of elements of a <see cref="T:System.Collections.Generic.HashSet`1" /> object to an array, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the <see cref="T:System.Collections.Generic.HashSet`1" /> object. The array must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <param name="count">The number of elements to copy to <paramref name="array" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="arrayIndex" /> is less than 0.-or-
		///         <paramref name="count" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="arrayIndex" /> is greater than the length of the destination <paramref name="array" />.-or-
		///         <paramref name="count" /> is greater than the available space from the <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		// Token: 0x06000A97 RID: 2711 RVA: 0x00027834 File Offset: 0x00025A34
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, "Non negative number is required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", count, "Non negative number is required.");
			}
			if (arrayIndex > array.Length || count > array.Length - arrayIndex)
			{
				throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
			}
			int num = 0;
			int num2 = 0;
			while (num2 < this._lastIndex && num < count)
			{
				if (this._slots[num2].hashCode >= 0)
				{
					array[arrayIndex + num] = this._slots[num2].value;
					num++;
				}
				num2++;
			}
		}

		/// <summary>Gets the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> object that is used to determine equality for the values in the set.</summary>
		/// <returns>The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> object that is used to determine equality for the values in the set.</returns>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000278E5 File Offset: 0x00025AE5
		public IEqualityComparer<T> Comparer
		{
			get
			{
				return this._comparer;
			}
		}

		/// <summary>Sets the capacity of a <see cref="T:System.Collections.Generic.HashSet`1" /> object to the actual number of elements it contains, rounded up to a nearby, implementation-specific value.</summary>
		// Token: 0x06000A99 RID: 2713 RVA: 0x000278F0 File Offset: 0x00025AF0
		public void TrimExcess()
		{
			if (this._count == 0)
			{
				this._buckets = null;
				this._slots = null;
				this._version++;
				return;
			}
			int prime = HashHelpers.GetPrime(this._count);
			HashSet<T>.Slot[] array = new HashSet<T>.Slot[prime];
			int[] array2 = new int[prime];
			int num = 0;
			for (int i = 0; i < this._lastIndex; i++)
			{
				if (this._slots[i].hashCode >= 0)
				{
					array[num] = this._slots[i];
					int num2 = array[num].hashCode % prime;
					array[num].next = array2[num2] - 1;
					array2[num2] = num + 1;
					num++;
				}
			}
			this._lastIndex = num;
			this._slots = array;
			this._buckets = array2;
			this._freeList = -1;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000279C8 File Offset: 0x00025BC8
		private int Initialize(int capacity)
		{
			int prime = HashHelpers.GetPrime(capacity);
			this._buckets = new int[prime];
			this._slots = new HashSet<T>.Slot[prime];
			return prime;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000279F8 File Offset: 0x00025BF8
		private void IncreaseCapacity()
		{
			int num = HashHelpers.ExpandPrime(this._count);
			if (num <= this._count)
			{
				throw new ArgumentException("HashSet capacity is too big.");
			}
			this.SetCapacity(num);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00027A2C File Offset: 0x00025C2C
		private void SetCapacity(int newSize)
		{
			HashSet<T>.Slot[] array = new HashSet<T>.Slot[newSize];
			if (this._slots != null)
			{
				Array.Copy(this._slots, 0, array, 0, this._lastIndex);
			}
			int[] array2 = new int[newSize];
			for (int i = 0; i < this._lastIndex; i++)
			{
				int num = array[i].hashCode % newSize;
				array[i].next = array2[num] - 1;
				array2[num] = i + 1;
			}
			this._slots = array;
			this._buckets = array2;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00027AA8 File Offset: 0x00025CA8
		private bool AddIfNotPresent(T value)
		{
			if (this._buckets == null)
			{
				this.Initialize(0);
			}
			int num = this.InternalGetHashCode(value);
			int num2 = num % this._buckets.Length;
			int num3 = 0;
			HashSet<T>.Slot[] slots = this._slots;
			for (int i = this._buckets[num2] - 1; i >= 0; i = slots[i].next)
			{
				if (slots[i].hashCode == num && this._comparer.Equals(slots[i].value, value))
				{
					return false;
				}
				if (num3 >= slots.Length)
				{
					throw new InvalidOperationException("Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.");
				}
				num3++;
			}
			int num4;
			if (this._freeList >= 0)
			{
				num4 = this._freeList;
				this._freeList = slots[num4].next;
			}
			else
			{
				if (this._lastIndex == slots.Length)
				{
					this.IncreaseCapacity();
					slots = this._slots;
					num2 = num % this._buckets.Length;
				}
				num4 = this._lastIndex;
				this._lastIndex++;
			}
			slots[num4].hashCode = num;
			slots[num4].value = value;
			slots[num4].next = this._buckets[num2] - 1;
			this._buckets[num2] = num4 + 1;
			this._count++;
			this._version++;
			return true;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00027C00 File Offset: 0x00025E00
		private void AddValue(int index, int hashCode, T value)
		{
			int num = hashCode % this._buckets.Length;
			this._slots[index].hashCode = hashCode;
			this._slots[index].value = value;
			this._slots[index].next = this._buckets[num] - 1;
			this._buckets[num] = index + 1;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00027C62 File Offset: 0x00025E62
		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			return set1.Comparer.Equals(set2.Comparer);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00027C75 File Offset: 0x00025E75
		private int InternalGetHashCode(T item)
		{
			if (item == null)
			{
				return 0;
			}
			return this._comparer.GetHashCode(item) & int.MaxValue;
		}

		// Token: 0x0400031D RID: 797
		private int[] _buckets;

		// Token: 0x0400031E RID: 798
		private HashSet<T>.Slot[] _slots;

		// Token: 0x0400031F RID: 799
		private int _count;

		// Token: 0x04000320 RID: 800
		private int _lastIndex;

		// Token: 0x04000321 RID: 801
		private int _freeList;

		// Token: 0x04000322 RID: 802
		private IEqualityComparer<T> _comparer;

		// Token: 0x04000323 RID: 803
		private int _version;

		// Token: 0x04000324 RID: 804
		private SerializationInfo _siInfo;

		// Token: 0x0200014D RID: 333
		internal struct Slot
		{
			// Token: 0x04000325 RID: 805
			internal int hashCode;

			// Token: 0x04000326 RID: 806
			internal int next;

			// Token: 0x04000327 RID: 807
			internal T value;
		}

		/// <summary>Enumerates the elements of a <see cref="T:System.Collections.Generic.HashSet`1" /> object.</summary>
		// Token: 0x0200014E RID: 334
		[Serializable]
		public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x06000AA1 RID: 2721 RVA: 0x00027C93 File Offset: 0x00025E93
			internal Enumerator(HashSet<T> set)
			{
				this._set = set;
				this._index = 0;
				this._version = set._version;
				this._current = default(T);
			}

			/// <summary>Releases all resources used by a <see cref="T:System.Collections.Generic.HashSet`1.Enumerator" /> object.</summary>
			// Token: 0x06000AA2 RID: 2722 RVA: 0x000073D5 File Offset: 0x000055D5
			public void Dispose()
			{
			}

			/// <summary>Advances the enumerator to the next element of the <see cref="T:System.Collections.Generic.HashSet`1" /> collection.</summary>
			/// <returns>
			///     <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06000AA3 RID: 2723 RVA: 0x00027CBC File Offset: 0x00025EBC
			public bool MoveNext()
			{
				if (this._version != this._set._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				while (this._index < this._set._lastIndex)
				{
					if (this._set._slots[this._index].hashCode >= 0)
					{
						this._current = this._set._slots[this._index].value;
						this._index++;
						return true;
					}
					this._index++;
				}
				this._index = this._set._lastIndex + 1;
				this._current = default(T);
				return false;
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the <see cref="T:System.Collections.Generic.HashSet`1" /> collection at the current position of the enumerator.</returns>
			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00027D77 File Offset: 0x00025F77
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			/// <summary>Gets the element at the current position of the enumerator.</summary>
			/// <returns>The element in the collection at the current position of the enumerator, as an <see cref="T:System.Object" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element. </exception>
			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00027D7F File Offset: 0x00025F7F
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._set._lastIndex + 1)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this.Current;
				}
			}

			/// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
			/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
			// Token: 0x06000AA6 RID: 2726 RVA: 0x00027DB4 File Offset: 0x00025FB4
			void IEnumerator.Reset()
			{
				if (this._version != this._set._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x04000328 RID: 808
			private HashSet<T> _set;

			// Token: 0x04000329 RID: 809
			private int _index;

			// Token: 0x0400032A RID: 810
			private int _version;

			// Token: 0x0400032B RID: 811
			private T _current;
		}
	}
}
