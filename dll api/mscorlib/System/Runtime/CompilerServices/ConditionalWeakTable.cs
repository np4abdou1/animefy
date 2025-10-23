using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.Runtime.CompilerServices
{
	/// <summary>Enables compilers to dynamically attach object fields to managed objects.</summary>
	/// <typeparam name="TKey">The reference type to which the field is attached. </typeparam>
	/// <typeparam name="TValue">The field's type. This must be a reference type.</typeparam>
	// Token: 0x02000476 RID: 1142
	public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class where TValue : class
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> class.</summary>
		// Token: 0x0600208A RID: 8330 RVA: 0x000890AF File Offset: 0x000872AF
		public ConditionalWeakTable()
		{
			this.data = new Ephemeron[13];
			GC.register_ephemeron_array(this.data);
		}

		/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> object. </summary>
		// Token: 0x0600208B RID: 8331 RVA: 0x000890DC File Offset: 0x000872DC
		~ConditionalWeakTable()
		{
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00089104 File Offset: 0x00087304
		private void RehashWithoutResize()
		{
			int num = this.data.Length;
			for (int i = 0; i < num; i++)
			{
				if (this.data[i].key == GC.EPHEMERON_TOMBSTONE)
				{
					this.data[i].key = null;
				}
			}
			for (int j = 0; j < num; j++)
			{
				object key = this.data[j].key;
				if (key != null)
				{
					int num2 = (RuntimeHelpers.GetHashCode(key) & int.MaxValue) % num;
					while (this.data[num2].key != null)
					{
						if (this.data[num2].key == key)
						{
							goto IL_108;
						}
						if (++num2 == num)
						{
							num2 = 0;
						}
					}
					this.data[num2].key = key;
					this.data[num2].value = this.data[j].value;
					this.data[j].key = null;
					this.data[j].value = null;
				}
				IL_108:;
			}
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00089224 File Offset: 0x00087424
		private void RecomputeSize()
		{
			this.size = 0;
			for (int i = 0; i < this.data.Length; i++)
			{
				if (this.data[i].key != null)
				{
					this.size++;
				}
			}
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x0008926C File Offset: 0x0008746C
		private void Rehash()
		{
			this.RecomputeSize();
			uint prime = (uint)HashHelpers.GetPrime((int)((float)this.size / 0.7f) << 1 | 1);
			if (prime > (float)this.data.Length * 0.5f && prime < (float)this.data.Length * 1.1f)
			{
				this.RehashWithoutResize();
				return;
			}
			Ephemeron[] array = new Ephemeron[prime];
			GC.register_ephemeron_array(array);
			this.size = 0;
			for (int i = 0; i < this.data.Length; i++)
			{
				object key = this.data[i].key;
				object value = this.data[i].value;
				if (key != null && key != GC.EPHEMERON_TOMBSTONE)
				{
					int num = array.Length;
					int num2 = -1;
					int num4;
					int num3 = num4 = (RuntimeHelpers.GetHashCode(key) & int.MaxValue) % num;
					do
					{
						object key2 = array[num4].key;
						if (key2 == null || key2 == GC.EPHEMERON_TOMBSTONE)
						{
							goto IL_D3;
						}
						if (++num4 == num)
						{
							num4 = 0;
						}
					}
					while (num4 != num3);
					IL_ED:
					array[num2].key = key;
					array[num2].value = value;
					this.size++;
					goto IL_118;
					IL_D3:
					num2 = num4;
					goto IL_ED;
				}
				IL_118:;
			}
			this.data = array;
		}

		/// <summary>Adds a key to the table.</summary>
		/// <param name="key">The key to add. <paramref name="key" /> represents the object to which the property is attached.</param>
		/// <param name="value">The key's property value.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="key" /> already exists.</exception>
		// Token: 0x0600208F RID: 8335 RVA: 0x000893AC File Offset: 0x000875AC
		public void Add(TKey key, TValue value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("Null key", "key");
			}
			object @lock = this._lock;
			lock (@lock)
			{
				if ((float)this.size >= (float)this.data.Length * 0.7f)
				{
					this.Rehash();
				}
				int num = this.data.Length;
				int num2 = -1;
				int num4;
				int num3 = num4 = (RuntimeHelpers.GetHashCode(key) & int.MaxValue) % num;
				for (;;)
				{
					object key2 = this.data[num4].key;
					if (key2 == null)
					{
						break;
					}
					if (key2 == GC.EPHEMERON_TOMBSTONE && num2 == -1)
					{
						num2 = num4;
					}
					else if (key2 == key)
					{
						goto Block_9;
					}
					if (++num4 == num)
					{
						num4 = 0;
					}
					if (num4 == num3)
					{
						goto IL_C7;
					}
				}
				if (num2 == -1)
				{
					num2 = num4;
					goto IL_C7;
				}
				goto IL_C7;
				Block_9:
				throw new ArgumentException("Key already in the list", "key");
				IL_C7:
				this.data[num2].key = key;
				this.data[num2].value = value;
				this.size++;
			}
		}

		/// <summary>Removes a key and its value from the table.</summary>
		/// <param name="key">The key to remove. </param>
		/// <returns>
		///     <see langword="true" /> if the key is found and removed; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002090 RID: 8336 RVA: 0x000894DC File Offset: 0x000876DC
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("Null key", "key");
			}
			object @lock = this._lock;
			lock (@lock)
			{
				int num = this.data.Length;
				int num3;
				int num2 = num3 = (RuntimeHelpers.GetHashCode(key) & int.MaxValue) % num;
				for (;;)
				{
					object key2 = this.data[num3].key;
					if (key2 == key)
					{
						break;
					}
					if (key2 == null)
					{
						goto Block_5;
					}
					if (++num3 == num)
					{
						num3 = 0;
					}
					if (num3 == num2)
					{
						goto Block_7;
					}
				}
				this.data[num3].key = GC.EPHEMERON_TOMBSTONE;
				this.data[num3].value = null;
				return true;
				Block_5:
				Block_7:;
			}
			return false;
		}

		/// <summary>Gets the value of the specified key.</summary>
		/// <param name="key">The key that represents an object with an attached property.</param>
		/// <param name="value">When this method returns, contains the attached property value. If <paramref name="key" /> is not found, <paramref name="value" /> contains the default value.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="key" /> is found; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		// Token: 0x06002091 RID: 8337 RVA: 0x000895B4 File Offset: 0x000877B4
		public bool TryGetValue(TKey key, out TValue value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("Null key", "key");
			}
			value = default(TValue);
			object @lock = this._lock;
			lock (@lock)
			{
				int num = this.data.Length;
				int num3;
				int num2 = num3 = (RuntimeHelpers.GetHashCode(key) & int.MaxValue) % num;
				for (;;)
				{
					object key2 = this.data[num3].key;
					if (key2 == key)
					{
						break;
					}
					if (key2 == null)
					{
						goto Block_5;
					}
					if (++num3 == num)
					{
						num3 = 0;
					}
					if (num3 == num2)
					{
						goto Block_7;
					}
				}
				value = (TValue)((object)this.data[num3].value);
				return true;
				Block_5:
				Block_7:;
			}
			return false;
		}

		/// <summary>Atomically searches for a specified key in the table and returns the corresponding value. If the key does not exist in the table, the method invokes a callback method to create a value that is bound to the specified key.</summary>
		/// <param name="key">The key to search for. <paramref name="key" /> represents the object to which the property is attached.</param>
		/// <param name="createValueCallback">A delegate to a method that can create a value for the given <paramref name="key" />. It has a single parameter of type <paramref name="TKey" />, and returns a value of type <paramref name="TValue" />.</param>
		/// <returns>The value attached to <paramref name="key" />, if <paramref name="key" /> already exists in the table; otherwise, the new value returned by the <paramref name="createValueCallback" /> delegate.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> or <paramref name="createValueCallback" /> is <see langword="null" />.</exception>
		// Token: 0x06002092 RID: 8338 RVA: 0x00089684 File Offset: 0x00087884
		public TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			if (createValueCallback == null)
			{
				throw new ArgumentNullException("Null create delegate", "createValueCallback");
			}
			object @lock = this._lock;
			TValue tvalue;
			lock (@lock)
			{
				if (this.TryGetValue(key, out tvalue))
				{
					return tvalue;
				}
				tvalue = createValueCallback(key);
				this.Add(key, tvalue);
			}
			return tvalue;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000896F4 File Offset: 0x000878F4
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			object @lock = this._lock;
			IEnumerator<KeyValuePair<TKey, TValue>> enumerator;
			lock (@lock)
			{
				IEnumerator<KeyValuePair<TKey, TValue>> enumerator2;
				if (this.size != 0)
				{
					enumerator = new ConditionalWeakTable<TKey, TValue>.Enumerator(this);
					enumerator2 = enumerator;
				}
				else
				{
					enumerator2 = ((IEnumerable<KeyValuePair<!0, !1>>)Array.Empty<KeyValuePair<TKey, TValue>>()).GetEnumerator();
				}
				enumerator = enumerator2;
			}
			return enumerator;
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0008974C File Offset: 0x0008794C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x04000F88 RID: 3976
		private Ephemeron[] data;

		// Token: 0x04000F89 RID: 3977
		private object _lock = new object();

		// Token: 0x04000F8A RID: 3978
		private int size;

		/// <summary>Represents a method that creates a non-default value to add as part of a key/value pair to a <see cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> object. </summary>
		/// <param name="key">The key that belongs to the value to create.</param>
		/// <returns>An instance of a reference type that represents the value to attach to the specified key.</returns>
		// Token: 0x02000477 RID: 1143
		// (Invoke) Token: 0x06002096 RID: 8342
		public delegate TValue CreateValueCallback(TKey key);

		// Token: 0x02000478 RID: 1144
		private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
		{
			// Token: 0x06002099 RID: 8345 RVA: 0x00089754 File Offset: 0x00087954
			public Enumerator(ConditionalWeakTable<TKey, TValue> table)
			{
				this._table = table;
				this._currentIndex = -1;
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x00089774 File Offset: 0x00087974
			~Enumerator()
			{
				this.Dispose();
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x000897A0 File Offset: 0x000879A0
			public void Dispose()
			{
				if (Interlocked.Exchange<ConditionalWeakTable<TKey, TValue>>(ref this._table, null) != null)
				{
					this._current = default(KeyValuePair<TKey, TValue>);
					GC.SuppressFinalize(this);
				}
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x000897C4 File Offset: 0x000879C4
			public bool MoveNext()
			{
				ConditionalWeakTable<TKey, TValue> table = this._table;
				if (table != null)
				{
					object @lock = table._lock;
					lock (@lock)
					{
						object ephemeron_TOMBSTONE = GC.EPHEMERON_TOMBSTONE;
						while (this._currentIndex < table.data.Length - 1)
						{
							this._currentIndex++;
							Ephemeron ephemeron = table.data[this._currentIndex];
							if (ephemeron.key != null && ephemeron.key != ephemeron_TOMBSTONE)
							{
								this._current = new KeyValuePair<TKey, TValue>((TKey)((object)ephemeron.key), (TValue)((object)ephemeron.value));
								return true;
							}
						}
					}
					return false;
				}
				return false;
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x0600209D RID: 8349 RVA: 0x00089888 File Offset: 0x00087A88
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					if (this._currentIndex < 0)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x0600209E RID: 8350 RVA: 0x0008989E File Offset: 0x00087A9E
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x0600209F RID: 8351 RVA: 0x00002A7D File Offset: 0x00000C7D
			public void Reset()
			{
			}

			// Token: 0x04000F8B RID: 3979
			private ConditionalWeakTable<TKey, TValue> _table;

			// Token: 0x04000F8C RID: 3980
			private int _currentIndex = -1;

			// Token: 0x04000F8D RID: 3981
			private KeyValuePair<TKey, TValue> _current;
		}
	}
}
