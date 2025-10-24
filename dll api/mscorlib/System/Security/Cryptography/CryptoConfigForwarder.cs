using System;

namespace System.Security.Cryptography
{
	// Token: 0x020002ED RID: 749
	internal static class CryptoConfigForwarder
	{
		// Token: 0x060018C6 RID: 6342 RVA: 0x0006CE62 File Offset: 0x0006B062
		internal static object CreateFromName(string name)
		{
			return CryptoConfig.CreateFromName(name);
		}
	}
}
