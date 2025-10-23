using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x0200003A RID: 58
	internal sealed class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00007CDC File Offset: 0x00005EDC
		internal OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, OrderedEnumerable<TElement> parent)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			this._source = source;
			this._parent = parent;
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			this._keySelector = keySelector;
			this._comparer = (comparer ?? Comparer<TKey>.Default);
			this._descending = descending;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007D3C File Offset: 0x00005F3C
		internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			EnumerableSorter<TElement> enumerableSorter = new EnumerableSorter<TElement, TKey>(this._keySelector, this._comparer, this._descending, next);
			if (this._parent != null)
			{
				enumerableSorter = this._parent.GetEnumerableSorter(enumerableSorter);
			}
			return enumerableSorter;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007D78 File Offset: 0x00005F78
		internal override CachingComparer<TElement> GetComparer(CachingComparer<TElement> childComparer)
		{
			CachingComparer<TElement> cachingComparer = (childComparer == null) ? new CachingComparer<TElement, TKey>(this._keySelector, this._comparer, this._descending) : new CachingComparerWithChild<TElement, TKey>(this._keySelector, this._comparer, this._descending, childComparer);
			if (this._parent == null)
			{
				return cachingComparer;
			}
			return this._parent.GetComparer(cachingComparer);
		}

		// Token: 0x04000073 RID: 115
		private readonly OrderedEnumerable<TElement> _parent;

		// Token: 0x04000074 RID: 116
		private readonly Func<TElement, TKey> _keySelector;

		// Token: 0x04000075 RID: 117
		private readonly IComparer<TKey> _comparer;

		// Token: 0x04000076 RID: 118
		private readonly bool _descending;
	}
}
