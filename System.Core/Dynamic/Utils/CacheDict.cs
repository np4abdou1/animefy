using System;
using System.Threading;

namespace System.Dynamic.Utils
{
	// Token: 0x02000135 RID: 309
	internal sealed class CacheDict<TKey, TValue>
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x00024F1C File Offset: 0x0002311C
		internal CacheDict(int size)
		{
			int num = CacheDict<TKey, TValue>.AlignSize(size);
			this._mask = num - 1;
			this._entries = new CacheDict<TKey, TValue>.Entry[num];
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00024F4B File Offset: 0x0002314B
		private static int AlignSize(int size)
		{
			size--;
			size |= size >> 1;
			size |= size >> 2;
			size |= size >> 4;
			size |= size >> 8;
			size |= size >> 16;
			size++;
			return size;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00024F7C File Offset: 0x0002317C
		internal bool TryGetValue(TKey key, out TValue value)
		{
			int hashCode = key.GetHashCode();
			int num = hashCode & this._mask;
			CacheDict<TKey, TValue>.Entry entry = Volatile.Read<CacheDict<TKey, TValue>.Entry>(ref this._entries[num]);
			if (entry != null && entry._hash == hashCode)
			{
				TKey key2 = entry._key;
				if (key2.Equals(key))
				{
					value = entry._value;
					return true;
				}
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00024FF0 File Offset: 0x000231F0
		internal void Add(TKey key, TValue value)
		{
			int hashCode = key.GetHashCode();
			int num = hashCode & this._mask;
			CacheDict<TKey, TValue>.Entry entry = Volatile.Read<CacheDict<TKey, TValue>.Entry>(ref this._entries[num]);
			if (entry != null && entry._hash == hashCode)
			{
				TKey key2 = entry._key;
				if (key2.Equals(key))
				{
					return;
				}
			}
			Volatile.Write<CacheDict<TKey, TValue>.Entry>(ref this._entries[num], new CacheDict<TKey, TValue>.Entry(hashCode, key, value));
		}

		// Token: 0x170001B5 RID: 437
		internal TValue this[TKey key]
		{
			set
			{
				this.Add(key, value);
			}
		}

		// Token: 0x040002F8 RID: 760
		private readonly int _mask;

		// Token: 0x040002F9 RID: 761
		private readonly CacheDict<TKey, TValue>.Entry[] _entries;

		// Token: 0x02000136 RID: 310
		private sealed class Entry
		{
			// Token: 0x060009D4 RID: 2516 RVA: 0x00025071 File Offset: 0x00023271
			internal Entry(int hash, TKey key, TValue value)
			{
				this._hash = hash;
				this._key = key;
				this._value = value;
			}

			// Token: 0x040002FA RID: 762
			internal readonly int _hash;

			// Token: 0x040002FB RID: 763
			internal readonly TKey _key;

			// Token: 0x040002FC RID: 764
			internal readonly TValue _value;
		}
	}
}
