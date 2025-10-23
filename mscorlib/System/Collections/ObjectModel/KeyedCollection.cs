﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
	/// <summary>Provides the abstract base class for a collection whose keys are embedded in the values.</summary>
	/// <typeparam name="TKey">The type of keys in the collection.</typeparam>
	/// <typeparam name="TItem">The type of items in the collection.</typeparam>
	// Token: 0x02000606 RID: 1542
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> class that uses the default equality comparer.</summary>
		// Token: 0x06002EDA RID: 11994 RVA: 0x000BF075 File Offset: 0x000BD275
		protected KeyedCollection() : this(null, 0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> class that uses the specified equality comparer.</summary>
		/// <param name="comparer">The implementation of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface to use when comparing keys, or <see langword="null" /> to use the default equality comparer for the type of the key, obtained from <see cref="P:System.Collections.Generic.EqualityComparer`1.Default" />.</param>
		// Token: 0x06002EDB RID: 11995 RVA: 0x000BF07F File Offset: 0x000BD27F
		protected KeyedCollection(IEqualityComparer<TKey> comparer) : this(comparer, 0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> class that uses the specified equality comparer and creates a lookup dictionary when the specified threshold is exceeded.</summary>
		/// <param name="comparer">The implementation of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface to use when comparing keys, or <see langword="null" /> to use the default equality comparer for the type of the key, obtained from <see cref="P:System.Collections.Generic.EqualityComparer`1.Default" />.</param>
		/// <param name="dictionaryCreationThreshold">The number of elements the collection can hold without creating a lookup dictionary (0 creates the lookup dictionary when the first item is added), or –1 to specify that a lookup dictionary is never created.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="dictionaryCreationThreshold" /> is less than –1.</exception>
		// Token: 0x06002EDC RID: 11996 RVA: 0x000BF08C File Offset: 0x000BD28C
		protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) : base(new List<TItem>())
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<TKey>.Default;
			}
			if (dictionaryCreationThreshold == -1)
			{
				dictionaryCreationThreshold = int.MaxValue;
			}
			if (dictionaryCreationThreshold < -1)
			{
				throw new ArgumentOutOfRangeException("dictionaryCreationThreshold", "The specified threshold for creating dictionary is out of range.");
			}
			this.comparer = comparer;
			this.threshold = dictionaryCreationThreshold;
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000BF0DB File Offset: 0x000BD2DB
		private new List<TItem> Items
		{
			get
			{
				return (List<TItem>)base.Items;
			}
		}

		/// <summary>Gets the element with the specified key. </summary>
		/// <param name="key">The key of the element to get.</param>
		/// <returns>The element with the specified key. If an element with the specified key is not found, an exception is thrown.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">An element with the specified key does not exist in the collection.</exception>
		// Token: 0x1700076F RID: 1903
		public TItem this[TKey key]
		{
			get
			{
				TItem result;
				if (this.TryGetValue(key, out result))
				{
					return result;
				}
				throw new KeyNotFoundException(SR.Format("The given key '{0}' was not present in the dictionary.", key.ToString()));
			}
		}

		/// <summary>Determines whether the collection contains an element with the specified key.</summary>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002EDF RID: 11999 RVA: 0x000BF120 File Offset: 0x000BD320
		public bool Contains(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (this.dict != null)
			{
				return this.dict.ContainsKey(key);
			}
			foreach (TItem item in this.Items)
			{
				if (this.comparer.Equals(this.GetKeyForItem(item), key))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000BF1B0 File Offset: 0x000BD3B0
		public bool TryGetValue(TKey key, out TItem item)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (this.dict != null)
			{
				return this.dict.TryGetValue(key, out item);
			}
			foreach (TItem titem in this.Items)
			{
				TKey keyForItem = this.GetKeyForItem(titem);
				if (keyForItem != null && this.comparer.Equals(key, keyForItem))
				{
					item = titem;
					return true;
				}
			}
			item = default(TItem);
			return false;
		}

		/// <summary>Gets the lookup dictionary of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
		/// <returns>The lookup dictionary of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, if it exists; otherwise, <see langword="null" />.</returns>
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x000BF25C File Offset: 0x000BD45C
		protected IDictionary<TKey, TItem> Dictionary
		{
			get
			{
				return this.dict;
			}
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
		// Token: 0x06002EE2 RID: 12002 RVA: 0x000BF264 File Offset: 0x000BD464
		protected override void ClearItems()
		{
			base.ClearItems();
			if (this.dict != null)
			{
				this.dict.Clear();
			}
			this.keyCount = 0;
		}

		/// <summary>When implemented in a derived class, extracts the key from the specified element.</summary>
		/// <param name="item">The element from which to extract the key.</param>
		/// <returns>The key for the specified element.</returns>
		// Token: 0x06002EE3 RID: 12003
		protected abstract TKey GetKeyForItem(TItem item);

		/// <summary>Inserts an element into the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> at the specified index.</summary>
		/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
		/// <param name="item">The object to insert.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than 0.-or-
		///         <paramref name="index" /> is greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06002EE4 RID: 12004 RVA: 0x000BF288 File Offset: 0x000BD488
		protected override void InsertItem(int index, TItem item)
		{
			TKey keyForItem = this.GetKeyForItem(item);
			if (keyForItem != null)
			{
				this.AddKey(keyForItem, item);
			}
			base.InsertItem(index, item);
		}

		/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
		/// <param name="index">The index of the element to remove.</param>
		// Token: 0x06002EE5 RID: 12005 RVA: 0x000BF2B8 File Offset: 0x000BD4B8
		protected override void RemoveItem(int index)
		{
			TKey keyForItem = this.GetKeyForItem(this.Items[index]);
			if (keyForItem != null)
			{
				this.RemoveKey(keyForItem);
			}
			base.RemoveItem(index);
		}

		/// <summary>Replaces the item at the specified index with the specified item.</summary>
		/// <param name="index">The zero-based index of the item to be replaced.</param>
		/// <param name="item">The new item.</param>
		// Token: 0x06002EE6 RID: 12006 RVA: 0x000BF2F0 File Offset: 0x000BD4F0
		protected override void SetItem(int index, TItem item)
		{
			TKey keyForItem = this.GetKeyForItem(item);
			TKey keyForItem2 = this.GetKeyForItem(this.Items[index]);
			if (this.comparer.Equals(keyForItem2, keyForItem))
			{
				if (keyForItem != null && this.dict != null)
				{
					this.dict[keyForItem] = item;
				}
			}
			else
			{
				if (keyForItem != null)
				{
					this.AddKey(keyForItem, item);
				}
				if (keyForItem2 != null)
				{
					this.RemoveKey(keyForItem2);
				}
			}
			base.SetItem(index, item);
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000BF370 File Offset: 0x000BD570
		private void AddKey(TKey key, TItem item)
		{
			if (this.dict != null)
			{
				this.dict.Add(key, item);
				return;
			}
			if (this.keyCount == this.threshold)
			{
				this.CreateDictionary();
				this.dict.Add(key, item);
				return;
			}
			if (this.Contains(key))
			{
				throw new ArgumentException(SR.Format("An item with the same key has already been added. Key: {0}", key));
			}
			this.keyCount++;
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000BF3E4 File Offset: 0x000BD5E4
		private void CreateDictionary()
		{
			this.dict = new Dictionary<TKey, TItem>(this.comparer);
			foreach (TItem titem in this.Items)
			{
				TKey keyForItem = this.GetKeyForItem(titem);
				if (keyForItem != null)
				{
					this.dict.Add(keyForItem, titem);
				}
			}
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000BF460 File Offset: 0x000BD660
		private void RemoveKey(TKey key)
		{
			if (this.dict != null)
			{
				this.dict.Remove(key);
				return;
			}
			this.keyCount--;
		}

		// Token: 0x040018DF RID: 6367
		private readonly IEqualityComparer<TKey> comparer;

		// Token: 0x040018E0 RID: 6368
		private Dictionary<TKey, TItem> dict;

		// Token: 0x040018E1 RID: 6369
		private int keyCount;

		// Token: 0x040018E2 RID: 6370
		private readonly int threshold;
	}
}
