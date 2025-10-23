using System;

namespace System.Text
{
	// Token: 0x0200025E RID: 606
	internal static class StringBuilderCache
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x00053A1C File Offset: 0x00051C1C
		public static StringBuilder Acquire(int capacity = 16)
		{
			if (capacity <= 360)
			{
				StringBuilder stringBuilder = StringBuilderCache.t_cachedInstance;
				if (stringBuilder != null && capacity <= stringBuilder.Capacity)
				{
					StringBuilderCache.t_cachedInstance = null;
					stringBuilder.Clear();
					return stringBuilder;
				}
			}
			return new StringBuilder(capacity);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00053A58 File Offset: 0x00051C58
		public static void Release(StringBuilder sb)
		{
			if (sb.Capacity <= 360)
			{
				StringBuilderCache.t_cachedInstance = sb;
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00053A6D File Offset: 0x00051C6D
		public static string GetStringAndRelease(StringBuilder sb)
		{
			string result = sb.ToString();
			StringBuilderCache.Release(sb);
			return result;
		}

		// Token: 0x04000848 RID: 2120
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}
