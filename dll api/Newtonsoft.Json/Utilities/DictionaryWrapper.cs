using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A4 RID: 164
	[NullableContext(1)]
	[Nullable(0)]
	internal class DictionaryWrapper<[Nullable(2)] TKey, [Nullable(2)] TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
	{
		// Token: 0x06000569 RID: 1385 RVA: 0x0001E0B9 File Offset: 0x0001C2B9
		public DictionaryWrapper(IDictionary dictionary)
		{
			ValidationUtils.ArgumentNotNull(dictionary, "dictionary");
			this._dictionary = dictionary;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001E0D3 File Offset: 0x0001C2D3
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
			ValidationUtils.ArgumentNotNull(dictionary, "dictionary");
			this._genericDictionary = dictionary;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001E0ED File Offset: 0x0001C2ED
		public DictionaryWrapper(IReadOnlyDictionary<TKey, TValue> dictionary)
		{
			ValidationUtils.ArgumentNotNull(dictionary, "dictionary");
			this._readOnlyDictionary = dictionary;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001E107 File Offset: 0x0001C307
		internal IDictionary<TKey, TValue> GenericDictionary
		{
			get
			{
				return this._genericDictionary;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001E10F File Offset: 0x0001C30F
		public void Add(TKey key, TValue value)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Add(key, value);
				return;
			}
			if (this._genericDictionary != null)
			{
				this._genericDictionary.Add(key, value);
				return;
			}
			throw new NotSupportedException();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001E14C File Offset: 0x0001C34C
		public bool ContainsKey(TKey key)
		{
			if (this._dictionary != null)
			{
				return this._dictionary.Contains(key);
			}
			if (this._readOnlyDictionary != null)
			{
				return this._readOnlyDictionary.ContainsKey(key);
			}
			return this.GenericDictionary.ContainsKey(key);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001E18C File Offset: 0x0001C38C
		public ICollection<TKey> Keys
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Keys.Cast<TKey>().ToList<TKey>();
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary.Keys.ToList<TKey>();
				}
				return this.GenericDictionary.Keys;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		public bool Remove(TKey key)
		{
			if (this._dictionary != null)
			{
				if (this._dictionary.Contains(key))
				{
					this._dictionary.Remove(key);
					return true;
				}
				return false;
			}
			else
			{
				if (this._readOnlyDictionary != null)
				{
					throw new NotSupportedException();
				}
				return this.GenericDictionary.Remove(key);
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001E234 File Offset: 0x0001C434
		public bool TryGetValue(TKey key, [Nullable(2)] out TValue value)
		{
			if (this._dictionary != null)
			{
				if (!this._dictionary.Contains(key))
				{
					value = default(TValue);
					return false;
				}
				value = (TValue)((object)this._dictionary[key]);
				return true;
			}
			else
			{
				if (this._readOnlyDictionary != null)
				{
					throw new NotSupportedException();
				}
				return this.GenericDictionary.TryGetValue(key, out value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		public ICollection<TValue> Values
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Values.Cast<TValue>().ToList<TValue>();
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary.Values.ToList<TValue>();
				}
				return this.GenericDictionary.Values;
			}
		}

		// Token: 0x170000BA RID: 186
		public TValue this[TKey key]
		{
			get
			{
				if (this._dictionary != null)
				{
					return (TValue)((object)this._dictionary[key]);
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary[key];
				}
				return this.GenericDictionary[key];
			}
			set
			{
				if (this._dictionary != null)
				{
					this._dictionary[key] = value;
					return;
				}
				if (this._readOnlyDictionary != null)
				{
					throw new NotSupportedException();
				}
				this.GenericDictionary[key] = value;
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001E37C File Offset: 0x0001C57C
		public void Add([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> item)
		{
			if (this._dictionary != null)
			{
				((IList)this._dictionary).Add(item);
				return;
			}
			if (this._readOnlyDictionary != null)
			{
				throw new NotSupportedException();
			}
			IDictionary<TKey, TValue> genericDictionary = this._genericDictionary;
			if (genericDictionary == null)
			{
				return;
			}
			genericDictionary.Add(item);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
		public void Clear()
		{
			if (this._dictionary != null)
			{
				this._dictionary.Clear();
				return;
			}
			if (this._readOnlyDictionary != null)
			{
				throw new NotSupportedException();
			}
			this.GenericDictionary.Clear();
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
		public bool Contains([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> item)
		{
			if (this._dictionary != null)
			{
				return ((IList)this._dictionary).Contains(item);
			}
			if (this._readOnlyDictionary != null)
			{
				return this._readOnlyDictionary.Contains(item);
			}
			return this.GenericDictionary.Contains(item);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001E448 File Offset: 0x0001C648
		public void CopyTo([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			if (this._dictionary != null)
			{
				using (IDictionaryEnumerator enumerator = this._dictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DictionaryEntry entry = enumerator.Entry;
						array[arrayIndex++] = new KeyValuePair<TKey, TValue>((TKey)((object)entry.Key), (TValue)((object)entry.Value));
					}
					return;
				}
			}
			if (this._readOnlyDictionary != null)
			{
				throw new NotSupportedException();
			}
			this.GenericDictionary.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001E4E4 File Offset: 0x0001C6E4
		public int Count
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.Count;
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary.Count;
				}
				return this.GenericDictionary.Count;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001E519 File Offset: 0x0001C719
		public bool IsReadOnly
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary.IsReadOnly;
				}
				return this._readOnlyDictionary != null || this.GenericDictionary.IsReadOnly;
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001E544 File Offset: 0x0001C744
		public bool Remove([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> item)
		{
			if (this._dictionary != null)
			{
				if (!this._dictionary.Contains(item.Key))
				{
					return true;
				}
				if (object.Equals(this._dictionary[item.Key], item.Value))
				{
					this._dictionary.Remove(item.Key);
					return true;
				}
				return false;
			}
			else
			{
				if (this._readOnlyDictionary != null)
				{
					throw new NotSupportedException();
				}
				return this.GenericDictionary.Remove(item);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001E5D4 File Offset: 0x0001C7D4
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			if (this._dictionary != null)
			{
				return (from DictionaryEntry de in this._dictionary
				select new KeyValuePair<TKey, TValue>((TKey)((object)de.Key), (TValue)((object)de.Value))).GetEnumerator();
			}
			if (this._readOnlyDictionary != null)
			{
				return this._readOnlyDictionary.GetEnumerator();
			}
			return this.GenericDictionary.GetEnumerator();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001E63D File Offset: 0x0001C83D
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001E645 File Offset: 0x0001C845
		void IDictionary.Add(object key, [Nullable(2)] object value)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Add(key, value);
				return;
			}
			if (this._readOnlyDictionary != null)
			{
				throw new NotSupportedException();
			}
			this.GenericDictionary.Add((TKey)((object)key), (TValue)((object)value));
		}

		// Token: 0x170000BD RID: 189
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			[return: Nullable(2)]
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary[key];
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary[(TKey)((object)key)];
				}
				return this.GenericDictionary[(TKey)((object)key)];
			}
			[param: Nullable(2)]
			set
			{
				if (this._dictionary != null)
				{
					this._dictionary[key] = value;
					return;
				}
				if (this._readOnlyDictionary != null)
				{
					throw new NotSupportedException();
				}
				this.GenericDictionary[(TKey)((object)key)] = (TValue)((object)value);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001E718 File Offset: 0x0001C918
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			if (this._dictionary != null)
			{
				return this._dictionary.GetEnumerator();
			}
			if (this._readOnlyDictionary != null)
			{
				return new DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TKey, TValue>(this._readOnlyDictionary.GetEnumerator());
			}
			return new DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TKey, TValue>(this.GenericDictionary.GetEnumerator());
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001E76C File Offset: 0x0001C96C
		bool IDictionary.Contains(object key)
		{
			if (this._genericDictionary != null)
			{
				return this._genericDictionary.ContainsKey((TKey)((object)key));
			}
			if (this._readOnlyDictionary != null)
			{
				return this._readOnlyDictionary.ContainsKey((TKey)((object)key));
			}
			return this._dictionary.Contains(key);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001E7B9 File Offset: 0x0001C9B9
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this._genericDictionary == null && (this._readOnlyDictionary != null || this._dictionary.IsFixedSize);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001E7DA File Offset: 0x0001C9DA
		ICollection IDictionary.Keys
		{
			get
			{
				if (this._genericDictionary != null)
				{
					return this._genericDictionary.Keys.ToList<TKey>();
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary.Keys.ToList<TKey>();
				}
				return this._dictionary.Keys;
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001E819 File Offset: 0x0001CA19
		public void Remove(object key)
		{
			if (this._dictionary != null)
			{
				this._dictionary.Remove(key);
				return;
			}
			if (this._readOnlyDictionary != null)
			{
				throw new NotSupportedException();
			}
			this.GenericDictionary.Remove((TKey)((object)key));
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001E850 File Offset: 0x0001CA50
		ICollection IDictionary.Values
		{
			get
			{
				if (this._genericDictionary != null)
				{
					return this._genericDictionary.Values.ToList<TValue>();
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary.Values.ToList<TValue>();
				}
				return this._dictionary.Values;
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001E88F File Offset: 0x0001CA8F
		void ICollection.CopyTo(Array array, int index)
		{
			if (this._dictionary != null)
			{
				this._dictionary.CopyTo(array, index);
				return;
			}
			if (this._readOnlyDictionary != null)
			{
				throw new NotSupportedException();
			}
			this.GenericDictionary.CopyTo((KeyValuePair<TKey, TValue>[])array, index);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001E8C7 File Offset: 0x0001CAC7
		bool ICollection.IsSynchronized
		{
			get
			{
				return this._dictionary != null && this._dictionary.IsSynchronized;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0001E8DE File Offset: 0x0001CADE
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0001E900 File Offset: 0x0001CB00
		public object UnderlyingDictionary
		{
			get
			{
				if (this._dictionary != null)
				{
					return this._dictionary;
				}
				if (this._readOnlyDictionary != null)
				{
					return this._readOnlyDictionary;
				}
				return this.GenericDictionary;
			}
		}

		// Token: 0x040003FE RID: 1022
		[Nullable(2)]
		private readonly IDictionary _dictionary;

		// Token: 0x040003FF RID: 1023
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		// Token: 0x04000400 RID: 1024
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;

		// Token: 0x04000401 RID: 1025
		[Nullable(2)]
		private object _syncRoot;

		// Token: 0x020000A5 RID: 165
		[Nullable(0)]
		private readonly struct DictionaryEnumerator<[Nullable(2)] TEnumeratorKey, [Nullable(2)] TEnumeratorValue> : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600058B RID: 1419 RVA: 0x0001E926 File Offset: 0x0001CB26
			public DictionaryEnumerator([Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})] IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				ValidationUtils.ArgumentNotNull(e, "e");
				this._e = e;
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600058C RID: 1420 RVA: 0x0001E93A File Offset: 0x0001CB3A
			public DictionaryEntry Entry
			{
				get
				{
					return (DictionaryEntry)this.Current;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001E948 File Offset: 0x0001CB48
			public object Key
			{
				get
				{
					return this.Entry.Key;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001E964 File Offset: 0x0001CB64
			[Nullable(2)]
			public object Value
			{
				[NullableContext(2)]
				get
				{
					return this.Entry.Value;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001E980 File Offset: 0x0001CB80
			public object Current
			{
				get
				{
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> keyValuePair = this._e.Current;
					object key = keyValuePair.Key;
					keyValuePair = this._e.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x0001E9C7 File Offset: 0x0001CBC7
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x0001E9D4 File Offset: 0x0001CBD4
			public void Reset()
			{
				this._e.Reset();
			}

			// Token: 0x04000402 RID: 1026
			[Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}
	}
}
