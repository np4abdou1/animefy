using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001ED RID: 493
	internal static class IPGlobalPropertiesFactoryPal
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x000467AB File Offset: 0x000449AB
		public static IPGlobalProperties Create()
		{
			IPGlobalProperties ipglobalProperties = UnixIPGlobalPropertiesFactoryPal.Create();
			if (ipglobalProperties == null)
			{
				throw new NotImplementedException();
			}
			return ipglobalProperties;
		}
	}
}
