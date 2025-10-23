using System;

namespace System.Collections.Generic
{
	// Token: 0x0200062B RID: 1579
	internal class LowLevelDictionary<TKey, TValue>
	{
		// Token: 0x0600300F RID: 12303 RVA: 0x000C2525 File Offset: 0x000C0725
		public LowLevelDictionary() : this(17, new LowLevelDictionary<TKey, TValue>.DefaultComparer<TKey>())
		{
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x000C2534 File Offset: 0x000C0734
		public LowLevelDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			this._comparer = comparer;
			this.Clear(capacity);
		}

		// Token: 0x170007CC RID: 1996
		public TValue this[TKey key]
		{
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				this._version++;
				LowLevelDictionary<TKey, TValue>.Entry entry = this.Find(key);
				if (entry != null)
				{
					entry._value = value;
					return;
				}
				this.UncheckedAdd(key, value);
			}
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x000C2596 File Offset: 0x000C0796
		public void Clear(int capacity = 17)
		{
			this._version++;
			this._buckets = new LowLevelDictionary<TKey, TValue>.Entry[capacity];
			this._numEntries = 0;
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x000C25BC File Offset: 0x000C07BC
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int bucket = this.GetBucket(key, 0);
			LowLevelDictionary<TKey, TValue>.Entry entry = null;
			for (LowLevelDictionary<TKey, TValue>.Entry entry2 = this._buckets[bucket]; entry2 != null; entry2 = entry2._next)
			{
				if (this._comparer.Equals(key, entry2._key))
				{
					if (entry == null)
					{
						this._buckets[bucket] = entry2._next;
					}
					else
					{
						entry._next = entry2._next;
					}
					this._version++;
					this._numEntries--;
					return true;
				}
				entry = entry2;
			}
			return false;
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x000C2650 File Offset: 0x000C0850
		private LowLevelDictionary<TKey, TValue>.Entry Find(TKey key)
		{
			int bucket = this.GetBucket(key, 0);
			for (LowLevelDictionary<TKey, TValue>.Entry entry = this._buckets[bucket]; entry != null; entry = entry._next)
			{
				if (this._comparer.Equals(key, entry._key))
				{
					return entry;
				}
			}
			return null;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x000C2694 File Offset: 0x000C0894
		private LowLevelDictionary<TKey, TValue>.Entry UncheckedAdd(TKey key, TValue value)
		{
			LowLevelDictionary<TKey, TValue>.Entry entry = new LowLevelDictionary<TKey, TValue>.Entry();
			entry._key = key;
			entry._value = value;
			int bucket = this.GetBucket(key, 0);
			entry._next = this._buckets[bucket];
			this._buckets[bucket] = entry;
			this._numEntries++;
			if (this._numEntries > this._buckets.Length * 2)
			{
				this.ExpandBuckets();
			}
			return entry;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000C26FC File Offset: 0x000C08FC
		private void ExpandBuckets()
		{
			try
			{
				int num = this._buckets.Length * 2 + 1;
				LowLevelDictionary<TKey, TValue>.Entry[] array = new LowLevelDictionary<TKey, TValue>.Entry[num];
				for (int i = 0; i < this._buckets.Length; i++)
				{
					LowLevelDictionary<TKey, TValue>.Entry next;
					for (LowLevelDictionary<TKey, TValue>.Entry entry = this._buckets[i]; entry != null; entry = next)
					{
						next = entry._next;
						int bucket = this.GetBucket(entry._key, num);
						entry._next = array[bucket];
						array[bucket] = entry;
					}
				}
				this._buckets = array;
			}
			catch (OutOfMemoryException)
			{
			}
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x000C2780 File Offset: 0x000C0980
		private int GetBucket(TKey key, int numBuckets = 0)
		{
			return (this._comparer.GetHashCode(key) & int.MaxValue) % ((numBuckets == 0) ? this._buckets.Length : numBuckets);
		}

		// Token: 0x04001924 RID: 6436
		private LowLevelDictionary<TKey, TValue>.Entry[] _buckets;

		// Token: 0x04001925 RID: 6437
		private int _numEntries;

		// Token: 0x04001926 RID: 6438
		private int _version;

		// Token: 0x04001927 RID: 6439
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x0200062C RID: 1580
		private sealed class Entry
		{
			// Token: 0x04001928 RID: 6440
			public TKey _key;

			// Token: 0x04001929 RID: 6441
			public TValue _value;

			// Token: 0x0400192A RID: 6442
			public LowLevelDictionary<TKey, TValue>.Entry _next;
		}

		// Token: 0x0200062D RID: 1581
		private sealed class DefaultComparer<T> : IEqualityComparer<T>
		{
			// Token: 0x06003019 RID: 12313 RVA: 0x000C27A4 File Offset: 0x000C09A4
			public bool Equals(T x, T y)
			{
				if (x == null)
				{
					return y == null;
				}
				IEquatable<T> equatable = x as IEquatable<T>;
				if (equatable != null)
				{
					return equatable.Equals(y);
				}
				return x.Equals(y);
			}

			// Token: 0x0600301A RID: 12314 RVA: 0x000C27EB File Offset: 0x000C09EB
			public int GetHashCode(T obj)
			{
				return obj.GetHashCode();
			}
		}
	}
}
