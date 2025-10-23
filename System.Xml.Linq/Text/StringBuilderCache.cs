using System;

namespace System.Text
{
	// Token: 0x02000039 RID: 57
	internal static class StringBuilderCache
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00008C84 File Offset: 0x00006E84
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

		// Token: 0x060001A5 RID: 421 RVA: 0x00008CC0 File Offset: 0x00006EC0
		public static void Release(StringBuilder sb)
		{
			if (sb.Capacity <= 360)
			{
				StringBuilderCache.t_cachedInstance = sb;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008CD5 File Offset: 0x00006ED5
		public static string GetStringAndRelease(StringBuilder sb)
		{
			string result = sb.ToString();
			StringBuilderCache.Release(sb);
			return result;
		}

		// Token: 0x040000E7 RID: 231
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}
