using System;

namespace Mono.Btls
{
	// Token: 0x02000056 RID: 86
	internal class MonoBtlsX509LookupAndroid : MonoBtlsX509LookupMono
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000818A File Offset: 0x0000638A
		protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name)
		{
			return AndroidPlatform.CertStoreLookup(name);
		}
	}
}
