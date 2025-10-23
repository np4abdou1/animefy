using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	// Token: 0x02000041 RID: 65
	internal interface IPartition<TElement> : IIListProvider<TElement>, IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x060001A7 RID: 423
		TElement TryGetFirst(out bool found);

		// Token: 0x060001A8 RID: 424
		TElement TryGetLast(out bool found);
	}
}
