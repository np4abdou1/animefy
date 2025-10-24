using System;
using System.Collections.Generic;

namespace System.IO
{
	// Token: 0x02000568 RID: 1384
	internal static class MonoLinqHelper
	{
		// Token: 0x06002967 RID: 10599 RVA: 0x000A5578 File Offset: 0x000A3778
		public static T[] ToArray<T>(this IEnumerable<T> source)
		{
			return EnumerableHelpers.ToArray<T>(source);
		}
	}
}
