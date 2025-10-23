using System;
using Mono.Net.Security;

namespace Mono.Security.Interface
{
	// Token: 0x02000043 RID: 67
	public static class MonoTlsProviderFactory
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00009D19 File Offset: 0x00007F19
		public static MonoTlsProvider GetProvider()
		{
			return (MonoTlsProvider)NoReflectionHelper.GetProvider();
		}
	}
}
