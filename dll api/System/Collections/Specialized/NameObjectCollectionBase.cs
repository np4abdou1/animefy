using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections.Specialized
{
	/// <summary>Provides the <see langword="abstract" /> base class for a collection of associated <see cref="T:System.String" /> keys and <see cref="T:System.Object" /> values that can be accessed either with the key or with the index.</summary>
	// Token: 0x020002CF RID: 719
	[Serializable]
	public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty.</summary>
		// Token: 0x06001348 RID: 4936 RVA: 0x0005AA13 File Offset: 0x00058C13
		protected NameObjectCollectionBase() : this(NameObjectCollectionBase.defaultComparer)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the default initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
		// Token: 0x06001349 RID: 4937 RVA: 0x0005AA20 File Offset: 0x00058C20
		protected NameObjectCollectionBase(IEqualityComparer equalityComparer)
		{
			IEqualityComparer keyComparer;
			if (equalityComparer != null)
			{
				keyComparer = equalityComparer;
			}
			else
			{
				IEqualityComparer equalityComparer2 = NameObjectCollectionBase.defaultComparer;
				keyComparer = equalityComparer2;
			}
			this._keyComparer = keyComparer;
			this.Reset();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is empty, has the specified initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="capacity">The approximate number of entries that the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object can initially contain.</param>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="capacity" /> is less than zero.</exception>
		// Token: 0x0600134A RID: 4938 RVA: 0x0005AA4C File Offset: 0x00058C4C
		protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer) : this(equalityComparer)
		{
			this.Reset(capacity);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0000222D File Offset: 0x0000042D
		internal NameObjectCollectionBase(DBNull dummy)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class that is serializable and uses the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		// Token: 0x0600134C RID: 4940 RVA: 0x0005AA5C File Offset: 0x00058C5C
		protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
		{
			this._serializationInfo = info;
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x0600134D RID: 4941 RVA: 0x0005AA6C File Offset: 0x00058C6C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("ReadOnly", this._readOnly);
			if (this._keyComparer == NameObjectCollectionBase.defaultComparer)
			{
				info.AddValue("HashProvider", CompatibleComparer.DefaultHashCodeProvider, typeof(IHashCodeProvider));
				info.AddValue("Comparer", CompatibleComparer.DefaultComparer, typeof(IComparer));
			}
			else if (this._keyComparer == null)
			{
				info.AddValue("HashProvider", null, typeof(IHashCodeProvider));
				info.AddValue("Comparer", null, typeof(IComparer));
			}
			else if (this._keyComparer is CompatibleComparer)
			{
				CompatibleComparer compatibleComparer = (CompatibleComparer)this._keyComparer;
				info.AddValue("HashProvider", compatibleComparer.HashCodeProvider, typeof(IHashCodeProvider));
				info.AddValue("Comparer", compatibleComparer.Comparer, typeof(IComparer));
			}
			else
			{
				info.AddValue("KeyComparer", this._keyComparer, typeof(IEqualityComparer));
			}
			int count = this._entriesArray.Count;
			info.AddValue("Count", count);
			string[] array = new string[count];
			object[] array2 = new object[count];
			for (int i = 0; i < count; i++)
			{
				NameObjectCollectionBase.NameObjectEntry nameObjectEntry = (NameObjectCollectionBase.NameObjectEntry)this._entriesArray[i];
				array[i] = nameObjectEntry.Key;
				array2[i] = nameObjectEntry.Value;
			}
			info.AddValue("Keys", array, typeof(string[]));
			info.AddValue("Values", array2, typeof(object[]));
			info.AddValue("Version", this._version);
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is invalid.</exception>
		// Token: 0x0600134E RID: 4942 RVA: 0x0005AC20 File Offset: 0x00058E20
		public virtual void OnDeserialization(object sender)
		{
			if (this._keyComparer != null)
			{
				return;
			}
			if (this._serializationInfo == null)
			{
				throw new SerializationException();
			}
			SerializationInfo serializationInfo = this._serializationInfo;
			this._serializationInfo = null;
			bool readOnly = false;
			int num = 0;
			string[] array = null;
			object[] array2 = null;
			IHashCodeProvider hashCodeProvider = null;
			IComparer comparer = null;
			bool flag = false;
			int version = 0;
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				uint num2 = <PrivateImplementationDetails>.ComputeStringHash(name);
				if (num2 <= 1573770551U)
				{
					if (num2 <= 1202781175U)
					{
						if (num2 != 891156946U)
						{
							if (num2 == 1202781175U)
							{
								if (name == "ReadOnly")
								{
									readOnly = serializationInfo.GetBoolean("ReadOnly");
								}
							}
						}
						else if (name == "Comparer")
						{
							comparer = (IComparer)serializationInfo.GetValue("Comparer", typeof(IComparer));
						}
					}
					else if (num2 != 1228509323U)
					{
						if (num2 == 1573770551U)
						{
							if (name == "Version")
							{
								flag = true;
								version = serializationInfo.GetInt32("Version");
							}
						}
					}
					else if (name == "KeyComparer")
					{
						this._keyComparer = (IEqualityComparer)serializationInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
					}
				}
				else if (num2 <= 1944240600U)
				{
					if (num2 != 1613443821U)
					{
						if (num2 == 1944240600U)
						{
							if (name == "HashProvider")
							{
								hashCodeProvider = (IHashCodeProvider)serializationInfo.GetValue("HashProvider", typeof(IHashCodeProvider));
							}
						}
					}
					else if (name == "Keys")
					{
						array = (string[])serializationInfo.GetValue("Keys", typeof(string[]));
					}
				}
				else if (num2 != 2370642523U)
				{
					if (num2 == 3790059668U)
					{
						if (name == "Count")
						{
							num = serializationInfo.GetInt32("Count");
						}
					}
				}
				else if (name == "Values")
				{
					array2 = (object[])serializationInfo.GetValue("Values", typeof(object[]));
				}
			}
			if (this._keyComparer == null)
			{
				if (comparer == null || hashCodeProvider == null)
				{
					throw new SerializationException();
				}
				this._keyComparer = new CompatibleComparer(comparer, hashCodeProvider);
			}
			if (array == null || array2 == null)
			{
				throw new SerializationException();
			}
			this.Reset(num);
			for (int i = 0; i < num; i++)
			{
				this.BaseAdd(array[i], array2[i]);
			}
			this._readOnly = readOnly;
			if (flag)
			{
				this._version = version;
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0005AEFE File Offset: 0x000590FE
		private void Reset()
		{
			this._entriesArray = new ArrayList();
			this._entriesTable = new Hashtable(this._keyComparer);
			this._nullKeyEntry = null;
			this._version++;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0005AF35 File Offset: 0x00059135
		private void Reset(int capacity)
		{
			this._entriesArray = new ArrayList(capacity);
			this._entriesTable = new Hashtable(capacity, this._keyComparer);
			this._nullKeyEntry = null;
			this._version++;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0005AF6E File Offset: 0x0005916E
		private NameObjectCollectionBase.NameObjectEntry FindEntry(string key)
		{
			if (key != null)
			{
				return (NameObjectCollectionBase.NameObjectEntry)this._entriesTable[key];
			}
			return this._nullKeyEntry;
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0005AF8F File Offset: 0x0005918F
		protected bool IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to add. The key can be <see langword="null" />.</param>
		/// <param name="value">The <see cref="T:System.Object" /> value of the entry to add. The value can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x06001353 RID: 4947 RVA: 0x0005AF98 File Offset: 0x00059198
		protected void BaseAdd(string name, object value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException(SR.GetString("Collection is read-only."));
			}
			NameObjectCollectionBase.NameObjectEntry nameObjectEntry = new NameObjectCollectionBase.NameObjectEntry(name, value);
			if (name != null)
			{
				if (this._entriesTable[name] == null)
				{
					this._entriesTable.Add(name, nameObjectEntry);
				}
			}
			else if (this._nullKeyEntry == null)
			{
				this._nullKeyEntry = nameObjectEntry;
			}
			this._entriesArray.Add(nameObjectEntry);
			this._version++;
		}

		/// <summary>Removes the entries with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entries to remove. The key can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x06001354 RID: 4948 RVA: 0x0005B018 File Offset: 0x00059218
		protected void BaseRemove(string name)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException(SR.GetString("Collection is read-only."));
			}
			if (name != null)
			{
				this._entriesTable.Remove(name);
				for (int i = this._entriesArray.Count - 1; i >= 0; i--)
				{
					if (this._keyComparer.Equals(name, this.BaseGetKey(i)))
					{
						this._entriesArray.RemoveAt(i);
					}
				}
			}
			else
			{
				this._nullKeyEntry = null;
				for (int j = this._entriesArray.Count - 1; j >= 0; j--)
				{
					if (this.BaseGetKey(j) == null)
					{
						this._entriesArray.RemoveAt(j);
					}
				}
			}
			this._version++;
		}

		/// <summary>Gets the value of the first entry with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to get. The key can be <see langword="null" />.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the value of the first entry with the specified key, if found; otherwise, <see langword="null" />.</returns>
		// Token: 0x06001355 RID: 4949 RVA: 0x0005B0D0 File Offset: 0x000592D0
		protected object BaseGet(string name)
		{
			NameObjectCollectionBase.NameObjectEntry nameObjectEntry = this.FindEntry(name);
			if (nameObjectEntry == null)
			{
				return null;
			}
			return nameObjectEntry.Value;
		}

		/// <summary>Sets the value of the first entry with the specified key in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance, if found; otherwise, adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="name">The <see cref="T:System.String" /> key of the entry to set. The key can be <see langword="null" />.</param>
		/// <param name="value">The <see cref="T:System.Object" /> that represents the new value of the entry to set. The value can be <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
		// Token: 0x06001356 RID: 4950 RVA: 0x0005B0F0 File Offset: 0x000592F0
		protected void BaseSet(string name, object value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException(SR.GetString("Collection is read-only."));
			}
			NameObjectCollectionBase.NameObjectEntry nameObjectEntry = this.FindEntry(name);
			if (nameObjectEntry != null)
			{
				nameObjectEntry.Value = value;
				this._version++;
				return;
			}
			this.BaseAdd(name, value);
		}

		/// <summary>Gets the value of the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index of the value to get.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the value of the entry at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
		// Token: 0x06001357 RID: 4951 RVA: 0x0005B13E File Offset: 0x0005933E
		protected object BaseGet(int index)
		{
			return ((NameObjectCollectionBase.NameObjectEntry)this._entriesArray[index]).Value;
		}

		/// <summary>Gets the key of the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <param name="index">The zero-based index of the key to get.</param>
		/// <returns>A <see cref="T:System.String" /> that represents the key of the entry at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
		// Token: 0x06001358 RID: 4952 RVA: 0x0005B156 File Offset: 0x00059356
		protected string BaseGetKey(int index)
		{
			return ((NameObjectCollectionBase.NameObjectEntry)this._entriesArray[index]).Key;
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x06001359 RID: 4953 RVA: 0x0005B16E File Offset: 0x0005936E
		public virtual IEnumerator GetEnumerator()
		{
			return new NameObjectCollectionBase.NameObjectKeysEnumerator(this);
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0005B176 File Offset: 0x00059376
		public virtual int Count
		{
			get
			{
				return this._entriesArray.Count;
			}
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or-The number of elements in the source <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		// Token: 0x0600135B RID: 4955 RVA: 0x0005B184 File Offset: 0x00059384
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.GetString("Multi dimension array is not supported on this operation."));
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", SR.GetString("Index {0} is out of range.", new object[]
				{
					index.ToString(CultureInfo.CurrentCulture)
				}));
			}
			if (array.Length - index < this._entriesArray.Count)
			{
				throw new ArgumentException(SR.GetString("Insufficient space in the target location to copy the information."));
			}
			foreach (object value in this)
			{
				array.SetValue(value, index++);
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object.</returns>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0005B22E File Offset: 0x0005942E
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

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object is synchronized (thread safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> object is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x000023F6 File Offset: 0x000005F6
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Returns a <see cref="T:System.String" /> array that contains all the keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
		/// <returns>A <see cref="T:System.String" /> array that contains all the keys in the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</returns>
		// Token: 0x0600135E RID: 4958 RVA: 0x0005B250 File Offset: 0x00059450
		protected string[] BaseGetAllKeys()
		{
			int count = this._entriesArray.Count;
			string[] array = new string[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = this.BaseGetKey(i);
			}
			return array;
		}

		// Token: 0x04000D41 RID: 3393
		private bool _readOnly;

		// Token: 0x04000D42 RID: 3394
		private ArrayList _entriesArray;

		// Token: 0x04000D43 RID: 3395
		private IEqualityComparer _keyComparer;

		// Token: 0x04000D44 RID: 3396
		private volatile Hashtable _entriesTable;

		// Token: 0x04000D45 RID: 3397
		private volatile NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;

		// Token: 0x04000D46 RID: 3398
		private SerializationInfo _serializationInfo;

		// Token: 0x04000D47 RID: 3399
		private int _version;

		// Token: 0x04000D48 RID: 3400
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x04000D49 RID: 3401
		private static StringComparer defaultComparer = StringComparer.InvariantCultureIgnoreCase;

		// Token: 0x020002D0 RID: 720
		internal class NameObjectEntry
		{
			// Token: 0x06001360 RID: 4960 RVA: 0x0005B293 File Offset: 0x00059493
			internal NameObjectEntry(string name, object value)
			{
				this.Key = name;
				this.Value = value;
			}

			// Token: 0x04000D4A RID: 3402
			internal string Key;

			// Token: 0x04000D4B RID: 3403
			internal object Value;
		}

		// Token: 0x020002D1 RID: 721
		[Serializable]
		internal class NameObjectKeysEnumerator : IEnumerator
		{
			// Token: 0x06001361 RID: 4961 RVA: 0x0005B2A9 File Offset: 0x000594A9
			internal NameObjectKeysEnumerator(NameObjectCollectionBase coll)
			{
				this._coll = coll;
				this._version = this._coll._version;
				this._pos = -1;
			}

			// Token: 0x06001362 RID: 4962 RVA: 0x0005B2D0 File Offset: 0x000594D0
			public bool MoveNext()
			{
				if (this._version != this._coll._version)
				{
					throw new InvalidOperationException(SR.GetString("Collection was modified; enumeration operation may not execute."));
				}
				if (this._pos < this._coll.Count - 1)
				{
					this._pos++;
					return true;
				}
				this._pos = this._coll.Count;
				return false;
			}

			// Token: 0x06001363 RID: 4963 RVA: 0x0005B337 File Offset: 0x00059537
			public void Reset()
			{
				if (this._version != this._coll._version)
				{
					throw new InvalidOperationException(SR.GetString("Collection was modified; enumeration operation may not execute."));
				}
				this._pos = -1;
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06001364 RID: 4964 RVA: 0x0005B363 File Offset: 0x00059563
			public object Current
			{
				get
				{
					if (this._pos >= 0 && this._pos < this._coll.Count)
					{
						return this._coll.BaseGetKey(this._pos);
					}
					throw new InvalidOperationException(SR.GetString("Enumeration has either not started or has already finished."));
				}
			}

			// Token: 0x04000D4C RID: 3404
			private int _pos;

			// Token: 0x04000D4D RID: 3405
			private NameObjectCollectionBase _coll;

			// Token: 0x04000D4E RID: 3406
			private int _version;
		}
	}
}
