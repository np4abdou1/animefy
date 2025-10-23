using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x02000040 RID: 64
	internal interface IIListProvider<TElement> : IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x060001A4 RID: 420
		TElement[] ToArray();

		// Token: 0x060001A5 RID: 421
		List<TElement> ToList();

		// Token: 0x060001A6 RID: 422
		int GetCount(bool onlyIfCheap);
	}
}
