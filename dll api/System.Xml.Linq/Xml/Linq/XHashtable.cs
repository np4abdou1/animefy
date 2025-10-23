using System;
using System.Threading;

namespace System.Xml.Linq
{
	// Token: 0x02000020 RID: 32
	internal sealed class XHashtable<TValue>
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00006C2E File Offset: 0x00004E2E
		public XHashtable(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
		{
			this._state = new XHashtable<TValue>.XHashtableState(extractKey, capacity);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006C43 File Offset: 0x00004E43
		public bool TryGetValue(string key, int index, int count, out TValue value)
		{
			return this._state.TryGetValue(key, index, count, out value);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006C58 File Offset: 0x00004E58
		public TValue Add(TValue value)
		{
			TValue result;
			while (!this._state.TryAdd(value, out result))
			{
				lock (this)
				{
					XHashtable<TValue>.XHashtableState state = this._state.Resize();
					Thread.MemoryBarrier();
					this._state = state;
				}
			}
			return result;
		}

		// Token: 0x0400008C RID: 140
		private XHashtable<TValue>.XHashtableState _state;

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000121 RID: 289
		public delegate string ExtractKeyDelegate(TValue value);

		// Token: 0x02000022 RID: 34
		private sealed class XHashtableState
		{
			// Token: 0x06000124 RID: 292 RVA: 0x00006CC4 File Offset: 0x00004EC4
			public XHashtableState(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
			{
				this._buckets = new int[capacity];
				this._entries = new XHashtable<TValue>.XHashtableState.Entry[capacity];
				this._extractKey = extractKey;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00006CEC File Offset: 0x00004EEC
			public XHashtable<TValue>.XHashtableState Resize()
			{
				if (this._numEntries < this._buckets.Length)
				{
					return this;
				}
				int num = 0;
				for (int i = 0; i < this._buckets.Length; i++)
				{
					int j = this._buckets[i];
					if (j == 0)
					{
						j = Interlocked.CompareExchange(ref this._buckets[i], -1, 0);
					}
					while (j > 0)
					{
						if (this._extractKey(this._entries[j].Value) != null)
						{
							num++;
						}
						if (this._entries[j].Next == 0)
						{
							j = Interlocked.CompareExchange(ref this._entries[j].Next, -1, 0);
						}
						else
						{
							j = this._entries[j].Next;
						}
					}
				}
				if (num < this._buckets.Length / 2)
				{
					num = this._buckets.Length;
				}
				else
				{
					num = this._buckets.Length * 2;
					if (num < 0)
					{
						throw new OverflowException();
					}
				}
				XHashtable<TValue>.XHashtableState xhashtableState = new XHashtable<TValue>.XHashtableState(this._extractKey, num);
				for (int k = 0; k < this._buckets.Length; k++)
				{
					for (int l = this._buckets[k]; l > 0; l = this._entries[l].Next)
					{
						TValue tvalue;
						xhashtableState.TryAdd(this._entries[l].Value, out tvalue);
					}
				}
				return xhashtableState;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00006E44 File Offset: 0x00005044
			public bool TryGetValue(string key, int index, int count, out TValue value)
			{
				int hashCode = XHashtable<TValue>.XHashtableState.ComputeHashCode(key, index, count);
				int num = 0;
				if (this.FindEntry(hashCode, key, index, count, ref num))
				{
					value = this._entries[num].Value;
					return true;
				}
				value = default(TValue);
				return false;
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00006E90 File Offset: 0x00005090
			public bool TryAdd(TValue value, out TValue newValue)
			{
				newValue = value;
				string text = this._extractKey(value);
				if (text == null)
				{
					return true;
				}
				int num = XHashtable<TValue>.XHashtableState.ComputeHashCode(text, 0, text.Length);
				int num2 = Interlocked.Increment(ref this._numEntries);
				if (num2 < 0 || num2 >= this._buckets.Length)
				{
					return false;
				}
				this._entries[num2].Value = value;
				this._entries[num2].HashCode = num;
				Thread.MemoryBarrier();
				int num3 = 0;
				while (!this.FindEntry(num, text, 0, text.Length, ref num3))
				{
					if (num3 == 0)
					{
						num3 = Interlocked.CompareExchange(ref this._buckets[num & this._buckets.Length - 1], num2, 0);
					}
					else
					{
						num3 = Interlocked.CompareExchange(ref this._entries[num3].Next, num2, 0);
					}
					if (num3 <= 0)
					{
						return num3 == 0;
					}
				}
				newValue = this._entries[num3].Value;
				return true;
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00006F80 File Offset: 0x00005180
			private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex)
			{
				int num = entryIndex;
				int i;
				if (num == 0)
				{
					i = this._buckets[hashCode & this._buckets.Length - 1];
				}
				else
				{
					i = num;
				}
				while (i > 0)
				{
					if (this._entries[i].HashCode == hashCode)
					{
						string text = this._extractKey(this._entries[i].Value);
						if (text == null)
						{
							if (this._entries[i].Next > 0)
							{
								this._entries[i].Value = default(TValue);
								i = this._entries[i].Next;
								if (num == 0)
								{
									this._buckets[hashCode & this._buckets.Length - 1] = i;
									continue;
								}
								this._entries[num].Next = i;
								continue;
							}
						}
						else if (count == text.Length && string.CompareOrdinal(key, index, text, 0, count) == 0)
						{
							entryIndex = i;
							return true;
						}
					}
					num = i;
					i = this._entries[i].Next;
				}
				entryIndex = num;
				return false;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00007094 File Offset: 0x00005294
			private static int ComputeHashCode(string key, int index, int count)
			{
				int num = 352654597;
				int num2 = index + count;
				for (int i = index; i < num2; i++)
				{
					num += (num << 7 ^ (int)key[i]);
				}
				num -= num >> 17;
				num -= num >> 11;
				num -= num >> 5;
				return num & int.MaxValue;
			}

			// Token: 0x0400008D RID: 141
			private int[] _buckets;

			// Token: 0x0400008E RID: 142
			private XHashtable<TValue>.XHashtableState.Entry[] _entries;

			// Token: 0x0400008F RID: 143
			private int _numEntries;

			// Token: 0x04000090 RID: 144
			private XHashtable<TValue>.ExtractKeyDelegate _extractKey;

			// Token: 0x02000023 RID: 35
			private struct Entry
			{
				// Token: 0x04000091 RID: 145
				public TValue Value;

				// Token: 0x04000092 RID: 146
				public int HashCode;

				// Token: 0x04000093 RID: 147
				public int Next;
			}
		}
	}
}
