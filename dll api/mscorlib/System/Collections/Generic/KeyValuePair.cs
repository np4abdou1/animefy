using System;
using System.Text;

namespace System.Collections.Generic
{
	// Token: 0x02000623 RID: 1571
	public static class KeyValuePair
	{
		// Token: 0x06002FBC RID: 12220 RVA: 0x000C1474 File Offset: 0x000BF674
		internal static string PairToString(object key, object value)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			stringBuilder.Append('[');
			if (key != null)
			{
				stringBuilder.Append(key);
			}
			stringBuilder.Append(", ");
			if (value != null)
			{
				stringBuilder.Append(value);
			}
			stringBuilder.Append(']');
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}
	}
}
