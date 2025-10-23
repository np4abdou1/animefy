using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x02000038 RID: 56
	internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable, IPartition<TElement>, IIListProvider<TElement>
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00007847 File Offset: 0x00005A47
		private int[] SortedMap(Buffer<TElement> buffer)
		{
			return this.GetEnumerableSorter().Sort(buffer._items, buffer._count);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00007860 File Offset: 0x00005A60
		public IEnumerator<TElement> GetEnumerator()
		{
			Buffer<TElement> buffer = new Buffer<TElement>(this._source);
			if (buffer._count > 0)
			{
				int[] map = this.SortedMap(buffer);
				int num;
				for (int i = 0; i < buffer._count; i = num + 1)
				{
					yield return buffer._items[map[i]];
					num = i;
				}
				map = null;
			}
			yield break;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007870 File Offset: 0x00005A70
		public TElement[] ToArray()
		{
			Buffer<TElement> buffer = new Buffer<TElement>(this._source);
			int count = buffer._count;
			if (count == 0)
			{
				return buffer._items;
			}
			TElement[] array = new TElement[count];
			int[] array2 = this.SortedMap(buffer);
			for (int num = 0; num != array.Length; num++)
			{
				array[num] = buffer._items[array2[num]];
			}
			return array;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000078D4 File Offset: 0x00005AD4
		public List<TElement> ToList()
		{
			Buffer<TElement> buffer = new Buffer<TElement>(this._source);
			int count = buffer._count;
			List<TElement> list = new List<TElement>(count);
			if (count > 0)
			{
				int[] array = this.SortedMap(buffer);
				for (int num = 0; num != count; num++)
				{
					list.Add(buffer._items[array[num]]);
				}
			}
			return list;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007930 File Offset: 0x00005B30
		public int GetCount(bool onlyIfCheap)
		{
			IIListProvider<TElement> iilistProvider = this._source as IIListProvider<TElement>;
			if (iilistProvider != null)
			{
				return iilistProvider.GetCount(onlyIfCheap);
			}
			if (onlyIfCheap && !(this._source is ICollection<TElement>) && !(this._source is ICollection))
			{
				return -1;
			}
			return this._source.Count<TElement>();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000797E File Offset: 0x00005B7E
		private EnumerableSorter<TElement> GetEnumerableSorter()
		{
			return this.GetEnumerableSorter(null);
		}

		// Token: 0x0600017E RID: 382
		internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

		// Token: 0x0600017F RID: 383 RVA: 0x00007987 File Offset: 0x00005B87
		private CachingComparer<TElement> GetComparer()
		{
			return this.GetComparer(null);
		}

		// Token: 0x06000180 RID: 384
		internal abstract CachingComparer<TElement> GetComparer(CachingComparer<TElement> childComparer);

		// Token: 0x06000181 RID: 385 RVA: 0x00007990 File Offset: 0x00005B90
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007998 File Offset: 0x00005B98
		IOrderedEnumerable<TElement> IOrderedEnumerable<!0>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			return new OrderedEnumerable<TElement, TKey>(this._source, keySelector, comparer, descending, this);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000079AC File Offset: 0x00005BAC
		public TElement TryGetFirst(out bool found)
		{
			CachingComparer<TElement> comparer = this.GetComparer();
			TElement telement;
			using (IEnumerator<TElement> enumerator = this._source.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					found = false;
					telement = default(TElement);
					telement = telement;
				}
				else
				{
					TElement telement2 = enumerator.Current;
					comparer.SetElement(telement2);
					while (enumerator.MoveNext())
					{
						TElement telement3 = enumerator.Current;
						if (comparer.Compare(telement3, true) < 0)
						{
							telement2 = telement3;
						}
					}
					found = true;
					telement = telement2;
				}
			}
			return telement;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007A34 File Offset: 0x00005C34
		public TElement TryGetFirst(Func<TElement, bool> predicate, out bool found)
		{
			CachingComparer<TElement> comparer = this.GetComparer();
			TElement telement3;
			using (IEnumerator<TElement> enumerator = this._source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TElement telement = enumerator.Current;
					if (predicate(telement))
					{
						comparer.SetElement(telement);
						while (enumerator.MoveNext())
						{
							TElement telement2 = enumerator.Current;
							if (predicate(telement2) && comparer.Compare(telement2, true) < 0)
							{
								telement = telement2;
							}
						}
						found = true;
						return telement;
					}
				}
				found = false;
				telement3 = default(TElement);
				telement3 = telement3;
			}
			return telement3;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007AD0 File Offset: 0x00005CD0
		public TElement TryGetLast(out bool found)
		{
			TElement telement;
			using (IEnumerator<TElement> enumerator = this._source.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					found = false;
					telement = default(TElement);
					telement = telement;
				}
				else
				{
					CachingComparer<TElement> comparer = this.GetComparer();
					TElement telement2 = enumerator.Current;
					comparer.SetElement(telement2);
					while (enumerator.MoveNext())
					{
						TElement telement3 = enumerator.Current;
						if (comparer.Compare(telement3, false) >= 0)
						{
							telement2 = telement3;
						}
					}
					found = true;
					telement = telement2;
				}
			}
			return telement;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007B58 File Offset: 0x00005D58
		public TElement TryGetLast(Func<TElement, bool> predicate, out bool found)
		{
			CachingComparer<TElement> comparer = this.GetComparer();
			TElement telement3;
			using (IEnumerator<TElement> enumerator = this._source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TElement telement = enumerator.Current;
					if (predicate(telement))
					{
						comparer.SetElement(telement);
						while (enumerator.MoveNext())
						{
							TElement telement2 = enumerator.Current;
							if (predicate(telement2) && comparer.Compare(telement2, false) >= 0)
							{
								telement = telement2;
							}
						}
						found = true;
						return telement;
					}
				}
				found = false;
				telement3 = default(TElement);
				telement3 = telement3;
			}
			return telement3;
		}

		// Token: 0x0400006C RID: 108
		internal IEnumerable<TElement> _source;
	}
}
