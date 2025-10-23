using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x02000034 RID: 52
	internal sealed class GroupedEnumerable<TSource, TKey> : IIListProvider<IGrouping<TKey, TSource>>, IEnumerable<IGrouping<TKey, TSource>>, IEnumerable
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00007467 File Offset: 0x00005667
		public GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			this._source = source;
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			this._keySelector = keySelector;
			this._comparer = comparer;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000074A2 File Offset: 0x000056A2
		public IEnumerator<IGrouping<TKey, TSource>> GetEnumerator()
		{
			return Lookup<TKey, TSource>.Create(this._source, this._keySelector, this._comparer).GetEnumerator();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000074C0 File Offset: 0x000056C0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000074C8 File Offset: 0x000056C8
		public IGrouping<TKey, TSource>[] ToArray()
		{
			return ((IIListProvider<IGrouping<TKey, TSource>>)Lookup<TKey, TSource>.Create(this._source, this._keySelector, this._comparer)).ToArray();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000074E6 File Offset: 0x000056E6
		public List<IGrouping<TKey, TSource>> ToList()
		{
			return ((IIListProvider<IGrouping<TKey, TSource>>)Lookup<TKey, TSource>.Create(this._source, this._keySelector, this._comparer)).ToList();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007504 File Offset: 0x00005704
		public int GetCount(bool onlyIfCheap)
		{
			if (!onlyIfCheap)
			{
				return Lookup<TKey, TSource>.Create(this._source, this._keySelector, this._comparer).Count;
			}
			return -1;
		}

		// Token: 0x04000061 RID: 97
		private readonly IEnumerable<TSource> _source;

		// Token: 0x04000062 RID: 98
		private readonly Func<TSource, TKey> _keySelector;

		// Token: 0x04000063 RID: 99
		private readonly IEqualityComparer<TKey> _comparer;
	}
}
