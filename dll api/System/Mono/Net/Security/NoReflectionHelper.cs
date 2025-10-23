using System;

namespace Mono.Net.Security
{
	// Token: 0x02000024 RID: 36
	internal static class NoReflectionHelper
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00005496 File Offset: 0x00003696
		internal static object GetProvider()
		{
			return MonoTlsProviderFactory.GetProvider();
		}
	}
}
