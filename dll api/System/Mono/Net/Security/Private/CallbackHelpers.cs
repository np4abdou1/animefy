using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Net.Security.Private
{
	// Token: 0x02000026 RID: 38
	internal static class CallbackHelpers
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x000054B0 File Offset: 0x000036B0
		internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback)
		{
			if (callback == null)
			{
				return null;
			}
			return (string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) => callback(h, c, ch, (SslPolicyErrors)e);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000054E0 File Offset: 0x000036E0
		internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback)
		{
			if (callback == null)
			{
				return null;
			}
			return (string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) => callback(t, lc, rc, ai);
		}
	}
}
