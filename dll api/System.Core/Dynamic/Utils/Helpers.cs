using System;
using System.Collections.Generic;

namespace System.Dynamic.Utils
{
	// Token: 0x0200013C RID: 316
	internal static class Helpers
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x000257E4 File Offset: 0x000239E4
		internal static T CommonNode<T>(T first, T second, Func<T, T> parent) where T : class
		{
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			if (@default.Equals(first, second))
			{
				return first;
			}
			HashSet<T> hashSet = new HashSet<T>(@default);
			for (T t = first; t != null; t = parent(t))
			{
				hashSet.Add(t);
			}
			for (T t2 = second; t2 != null; t2 = parent(t2))
			{
				if (hashSet.Contains(t2))
				{
					return t2;
				}
			}
			return default(T);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00025850 File Offset: 0x00023A50
		internal static void IncrementCount<T>(T key, Dictionary<T, int> dict)
		{
			int num;
			dict.TryGetValue(key, out num);
			dict[key] = num + 1;
		}
	}
}
