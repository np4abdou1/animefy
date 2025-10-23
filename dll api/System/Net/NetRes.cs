using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x02000174 RID: 372
	internal class NetRes
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00035D00 File Offset: 0x00033F00
		public static string GetWebStatusString(string Res, WebExceptionStatus Status)
		{
			string @string = SR.GetString(WebExceptionMapping.GetWebStatusString(Status));
			string string2 = SR.GetString(Res);
			return string.Format(CultureInfo.CurrentCulture, string2, @string);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00035D2C File Offset: 0x00033F2C
		public static string GetWebStatusString(WebExceptionStatus Status)
		{
			return SR.GetString(WebExceptionMapping.GetWebStatusString(Status));
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00035D3C File Offset: 0x00033F3C
		public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription)
		{
			string str = "(";
			int num = (int)statusCode;
			string text = str + num.ToString(NumberFormatInfo.InvariantInfo) + ")";
			string text2 = null;
			try
			{
				text2 = SR.GetString("net_ftpstatuscode_" + statusCode.ToString(), null);
			}
			catch
			{
			}
			if (text2 != null && text2.Length > 0)
			{
				text = text + " " + text2;
			}
			else if (statusDescription != null && statusDescription.Length > 0)
			{
				text = text + " " + statusDescription;
			}
			return text;
		}
	}
}
