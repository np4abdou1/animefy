using System;

namespace System.Linq
{
	// Token: 0x0200003B RID: 59
	internal abstract class CachingComparer<TElement>
	{
		// Token: 0x06000191 RID: 401
		internal abstract int Compare(TElement element, bool cacheLower);

		// Token: 0x06000192 RID: 402
		internal abstract void SetElement(TElement element);
	}
}
