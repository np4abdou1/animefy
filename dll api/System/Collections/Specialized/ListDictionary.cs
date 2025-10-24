using System;
using System.Threading;

namespace System.Collections.Specialized
{
	/// <summary>Implements <see langword="IDictionary" /> using a singly linked list. Recommended for collections that typically include fewer than 10 items.</summary>
	// Token: 0x020002C0 RID: 704
	[Serializable]
	public class ListDictionary : IDictionary, ICollection, IEnumerable
	{
		/// <summary>Creates an empty <see cref="T:System.Collections.Specialized.ListDictionary" /> using the default comparer.</summary>
		// Token: 0x060012B5 RID: 4789 RVA: 0x0000222D File Offset: 0x0000042D
		public ListDictionary()
		{
		}

		/// <summary>Creates an empty <see cref="T:System.Collections.Specialized.ListDictionary" /> using the specified comparer.</summary>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> to use to determine whether two keys are equal.-or- 
		///       <see langword="null" /> to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		// Token: 0x060012B6 RID: 4790 RVA: 0x00059754 File Offset: 0x00057954
		public ListDictionary(IComparer comparer)
		{
			this.comparer = comparer;
		}

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <param name="key">The key whose value to get or set. </param>
		/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns <see langword="null" />, and attempting to set it creates a new entry using the specified key.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x170003B4 RID: 948
		public object this[object key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				ListDictionary.DictionaryNode next = this.head;
				if (this.comparer == null)
				{
					while (next != null)
					{
						if (next.key.Equals(key))
						{
							return next.value;
						}
						next = next.next;
					}
				}
				else
				{
					while (next != null)
					{
						object key2 = next.key;
						if (this.comparer.Compare(key2, key) == 0)
						{
							return next.value;
						}
						next = next.next;
					}
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				this.version++;
				ListDictionary.DictionaryNode dictionaryNode = null;
				ListDictionary.DictionaryNode next;
				for (next = this.head; next != null; next = next.next)
				{
					object key2 = next.key;
					if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
					{
						break;
					}
					dictionaryNode = next;
				}
				if (next != null)
				{
					next.value = value;
					return;
				}
				ListDictionary.DictionaryNode dictionaryNode2 = new ListDictionary.DictionaryNode();
				dictionaryNode2.key = key;
				dictionaryNode2.value = value;
				if (dictionaryNode != null)
				{
					dictionaryNode.next = dictionaryNode2;
				}
				else
				{
					this.head = dictionaryNode2;
				}
				this.count++;
			}
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00059886 File Offset: 0x00057A86
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0005988E File Offset: 0x00057A8E
		public ICollection Keys
		{
			get
			{
				return new ListDictionary.NodeKeyValueCollection(this, true);
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> is read-only.</summary>
		/// <returns>This property always returns <see langword="false" />.</returns>
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> has a fixed size.</summary>
		/// <returns>This property always returns <see langword="false" />.</returns>
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> is synchronized (thread safe).</summary>
		/// <returns>This property always returns <see langword="false" />.</returns>
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000023F6 File Offset: 0x000005F6
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00059897 File Offset: 0x00057A97
		public object SyncRoot
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

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x000598B9 File Offset: 0x00057AB9
		public ICollection Values
		{
			get
			{
				return new ListDictionary.NodeKeyValueCollection(this, false);
			}
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <param name="key">The key of the entry to add. </param>
		/// <param name="value">The value of the entry to add. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">An entry with the same key already exists in the <see cref="T:System.Collections.Specialized.ListDictionary" />. </exception>
		// Token: 0x060012C0 RID: 4800 RVA: 0x000598C4 File Offset: 0x00057AC4
		public void Add(object key, object value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.version++;
			ListDictionary.DictionaryNode dictionaryNode = null;
			for (ListDictionary.DictionaryNode next = this.head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
				{
					throw new ArgumentException(SR.Format("An item with the same key has already been added. Key: {0}", key));
				}
				dictionaryNode = next;
			}
			ListDictionary.DictionaryNode dictionaryNode2 = new ListDictionary.DictionaryNode();
			dictionaryNode2.key = key;
			dictionaryNode2.value = value;
			if (dictionaryNode != null)
			{
				dictionaryNode.next = dictionaryNode2;
			}
			else
			{
				this.head = dictionaryNode2;
			}
			this.count++;
		}

		/// <summary>Removes all entries from the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		// Token: 0x060012C1 RID: 4801 RVA: 0x00059974 File Offset: 0x00057B74
		public void Clear()
		{
			this.count = 0;
			this.head = null;
			this.version++;
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Specialized.ListDictionary" /> contains a specific key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Specialized.ListDictionary" />. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.Specialized.ListDictionary" /> contains an entry with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x060012C2 RID: 4802 RVA: 0x00059994 File Offset: 0x00057B94
		public bool Contains(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			for (ListDictionary.DictionaryNode next = this.head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Copies the <see cref="T:System.Collections.Specialized.ListDictionary" /> entries to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Specialized.ListDictionary" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.ListDictionary" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.ListDictionary" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		// Token: 0x060012C3 RID: 4803 RVA: 0x000599F0 File Offset: 0x00057BF0
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (array.Length - index < this.count)
			{
				throw new ArgumentException("Insufficient space in the target location to copy the information.");
			}
			for (ListDictionary.DictionaryNode next = this.head; next != null; next = next.next)
			{
				array.SetValue(new DictionaryEntry(next.key, next.value), index);
				index++;
			}
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x060012C4 RID: 4804 RVA: 0x00059A75 File Offset: 0x00057C75
		public IDictionaryEnumerator GetEnumerator()
		{
			return new ListDictionary.NodeEnumerator(this);
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that iterates through the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x060012C5 RID: 4805 RVA: 0x00059A75 File Offset: 0x00057C75
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ListDictionary.NodeEnumerator(this);
		}

		/// <summary>Removes the entry with the specified key from the <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <param name="key">The key of the entry to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x060012C6 RID: 4806 RVA: 0x00059A80 File Offset: 0x00057C80
		public void Remove(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.version++;
			ListDictionary.DictionaryNode dictionaryNode = null;
			ListDictionary.DictionaryNode next;
			for (next = this.head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
				{
					break;
				}
				dictionaryNode = next;
			}
			if (next == null)
			{
				return;
			}
			if (next == this.head)
			{
				this.head = next.next;
			}
			else
			{
				dictionaryNode.next = next.next;
			}
			this.count--;
		}

		// Token: 0x04000D14 RID: 3348
		private ListDictionary.DictionaryNode head;

		// Token: 0x04000D15 RID: 3349
		private int version;

		// Token: 0x04000D16 RID: 3350
		private int count;

		// Token: 0x04000D17 RID: 3351
		private readonly IComparer comparer;

		// Token: 0x04000D18 RID: 3352
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020002C1 RID: 705
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x060012C7 RID: 4807 RVA: 0x00059B1F File Offset: 0x00057D1F
			public NodeEnumerator(ListDictionary list)
			{
				this._list = list;
				this._version = list.version;
				this._start = true;
				this._current = null;
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00059B48 File Offset: 0x00057D48
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00059B55 File Offset: 0x00057D55
			public DictionaryEntry Entry
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return new DictionaryEntry(this._current.key, this._current.value);
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x060012CA RID: 4810 RVA: 0x00059B85 File Offset: 0x00057D85
			public object Key
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._current.key;
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x060012CB RID: 4811 RVA: 0x00059BA5 File Offset: 0x00057DA5
			public object Value
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._current.value;
				}
			}

			// Token: 0x060012CC RID: 4812 RVA: 0x00059BC8 File Offset: 0x00057DC8
			public bool MoveNext()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._start)
				{
					this._current = this._list.head;
					this._start = false;
				}
				else if (this._current != null)
				{
					this._current = this._current.next;
				}
				return this._current != null;
			}

			// Token: 0x060012CD RID: 4813 RVA: 0x00059C37 File Offset: 0x00057E37
			public void Reset()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._start = true;
				this._current = null;
			}

			// Token: 0x04000D19 RID: 3353
			private ListDictionary _list;

			// Token: 0x04000D1A RID: 3354
			private ListDictionary.DictionaryNode _current;

			// Token: 0x04000D1B RID: 3355
			private int _version;

			// Token: 0x04000D1C RID: 3356
			private bool _start;
		}

		// Token: 0x020002C2 RID: 706
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x060012CE RID: 4814 RVA: 0x00059C65 File Offset: 0x00057E65
			public NodeKeyValueCollection(ListDictionary list, bool isKeys)
			{
				this._list = list;
				this._isKeys = isKeys;
			}

			// Token: 0x060012CF RID: 4815 RVA: 0x00059C7C File Offset: 0x00057E7C
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
				for (ListDictionary.DictionaryNode dictionaryNode = this._list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
				{
					array.SetValue(this._isKeys ? dictionaryNode.key : dictionaryNode.value, index);
					index++;
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00059CEC File Offset: 0x00057EEC
			int ICollection.Count
			{
				get
				{
					int num = 0;
					for (ListDictionary.DictionaryNode dictionaryNode = this._list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
					{
						num++;
					}
					return num;
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000023F6 File Offset: 0x000005F6
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00059D18 File Offset: 0x00057F18
			object ICollection.SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x060012D3 RID: 4819 RVA: 0x00059D25 File Offset: 0x00057F25
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator(this._list, this._isKeys);
			}

			// Token: 0x04000D1D RID: 3357
			private ListDictionary _list;

			// Token: 0x04000D1E RID: 3358
			private bool _isKeys;

			// Token: 0x020002C3 RID: 707
			private class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x060012D4 RID: 4820 RVA: 0x00059D38 File Offset: 0x00057F38
				public NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
				{
					this._list = list;
					this._isKeys = isKeys;
					this._version = list.version;
					this._start = true;
					this._current = null;
				}

				// Token: 0x170003C3 RID: 963
				// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00059D68 File Offset: 0x00057F68
				public object Current
				{
					get
					{
						if (this._current == null)
						{
							throw new InvalidOperationException("Enumeration has either not started or has already finished.");
						}
						if (!this._isKeys)
						{
							return this._current.value;
						}
						return this._current.key;
					}
				}

				// Token: 0x060012D6 RID: 4822 RVA: 0x00059D9C File Offset: 0x00057F9C
				public bool MoveNext()
				{
					if (this._version != this._list.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (this._start)
					{
						this._current = this._list.head;
						this._start = false;
					}
					else if (this._current != null)
					{
						this._current = this._current.next;
					}
					return this._current != null;
				}

				// Token: 0x060012D7 RID: 4823 RVA: 0x00059E0B File Offset: 0x0005800B
				public void Reset()
				{
					if (this._version != this._list.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					this._start = true;
					this._current = null;
				}

				// Token: 0x04000D1F RID: 3359
				private ListDictionary _list;

				// Token: 0x04000D20 RID: 3360
				private ListDictionary.DictionaryNode _current;

				// Token: 0x04000D21 RID: 3361
				private int _version;

				// Token: 0x04000D22 RID: 3362
				private bool _isKeys;

				// Token: 0x04000D23 RID: 3363
				private bool _start;
			}
		}

		// Token: 0x020002C4 RID: 708
		[Serializable]
		public class DictionaryNode
		{
			// Token: 0x04000D24 RID: 3364
			public object key;

			// Token: 0x04000D25 RID: 3365
			public object value;

			// Token: 0x04000D26 RID: 3366
			public ListDictionary.DictionaryNode next;
		}
	}
}
