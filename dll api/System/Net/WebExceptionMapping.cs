using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000162 RID: 354
	internal static class WebExceptionMapping
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x00033F18 File Offset: 0x00032118
		internal static string GetWebStatusString(WebExceptionStatus status)
		{
			int num = (int)status;
			if (num >= WebExceptionMapping.s_Mapping.Length || num < 0)
			{
				throw new InternalException();
			}
			string text = Volatile.Read<string>(ref WebExceptionMapping.s_Mapping[num]);
			if (text == null)
			{
				text = "net_webstatus_" + status.ToString();
				Volatile.Write<string>(ref WebExceptionMapping.s_Mapping[num], text);
			}
			return text;
		}

		// Token: 0x0400071C RID: 1820
		private static readonly string[] s_Mapping = new string[21];
	}
}
