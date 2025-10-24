using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x0200003C RID: 60
	internal class CachingComparer<TElement, TKey> : CachingComparer<TElement>
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00007DD0 File Offset: 0x00005FD0
		public CachingComparer(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			this._keySelector = keySelector;
			this._comparer = comparer;
			this._descending = descending;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007DF0 File Offset: 0x00005FF0
		internal override int Compare(TElement element, bool cacheLower)
		{
			TKey tkey = this._keySelector(element);
			int num = this._descending ? this._comparer.Compare(this._lastKey, tkey) : this._comparer.Compare(tkey, this._lastKey);
			if (cacheLower == num < 0)
			{
				this._lastKey = tkey;
			}
			return num;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007E48 File Offset: 0x00006048
		internal override void SetElement(TElement element)
		{
			this._lastKey = this._keySelector(element);
		}

		// Token: 0x04000077 RID: 119
		protected readonly Func<TElement, TKey> _keySelector;

		// Token: 0x04000078 RID: 120
		protected readonly IComparer<TKey> _comparer;

		// Token: 0x04000079 RID: 121
		protected readonly bool _descending;

		// Token: 0x0400007A RID: 122
		protected TKey _lastKey;
	}
}
