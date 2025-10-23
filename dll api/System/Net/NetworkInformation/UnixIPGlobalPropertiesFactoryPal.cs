using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001F1 RID: 497
	internal static class UnixIPGlobalPropertiesFactoryPal
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x00046826 File Offset: 0x00044A26
		public static IPGlobalProperties Create()
		{
			return new AndroidIPGlobalProperties();
		}
	}
}
