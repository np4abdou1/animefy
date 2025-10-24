using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000118 RID: 280
	internal interface IValueTupleInternal : ITuple
	{
		// Token: 0x06000ABF RID: 2751
		int GetHashCode(IEqualityComparer comparer);

		// Token: 0x06000AC0 RID: 2752
		string ToStringEnd();
	}
}
