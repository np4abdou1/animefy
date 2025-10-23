using System;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x0200002E RID: 46
	internal readonly struct Buffer<TElement>
	{
		// Token: 0x06000149 RID: 329 RVA: 0x0000729C File Offset: 0x0000549C
		internal Buffer(IEnumerable<TElement> source)
		{
			IIListProvider<TElement> iilistProvider = source as IIListProvider<TElement>;
			if (iilistProvider != null)
			{
				TElement[] array = iilistProvider.ToArray();
				this._items = array;
				this._count = array.Length;
				return;
			}
			this._items = EnumerableHelpers.ToArray<TElement>(source, out this._count);
		}

		// Token: 0x04000055 RID: 85
		internal readonly TElement[] _items;

		// Token: 0x04000056 RID: 86
		internal readonly int _count;
	}
}
