using System;

namespace Microsoft.Win32
{
	// Token: 0x0200005A RID: 90
	internal static class Win32Native
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
		public static string GetMessage(int hr)
		{
			return "Error " + hr.ToString();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000E207 File Offset: 0x0000C407
		public static int MakeHRFromErrorCode(int errorCode)
		{
			return -2147024896 | errorCode;
		}
	}
}
