using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x0200003D RID: 61
	internal sealed class CachingComparerWithChild<TElement, TKey> : CachingComparer<TElement, TKey>
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00007E5C File Offset: 0x0000605C
		public CachingComparerWithChild(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, CachingComparer<TElement> child) : base(keySelector, comparer, descending)
		{
			this._child = child;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007E70 File Offset: 0x00006070
		internal override int Compare(TElement element, bool cacheLower)
		{
			TKey tkey = this._keySelector(element);
			int num = this._descending ? this._comparer.Compare(this._lastKey, tkey) : this._comparer.Compare(tkey, this._lastKey);
			if (num == 0)
			{
				return this._child.Compare(element, cacheLower);
			}
			if (cacheLower == num < 0)
			{
				this._lastKey = tkey;
				this._child.SetElement(element);
			}
			return num;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007EE5 File Offset: 0x000060E5
		internal override void SetElement(TElement element)
		{
			base.SetElement(element);
			this._child.SetElement(element);
		}

		// Token: 0x0400007B RID: 123
		private readonly CachingComparer<TElement> _child;
	}
}
