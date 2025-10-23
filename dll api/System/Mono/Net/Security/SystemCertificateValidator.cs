using System;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000025 RID: 37
	internal static class SystemCertificateValidator
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x0000549D File Offset: 0x0000369D
		static SystemCertificateValidator()
		{
			SystemCertificateValidator.is_macosx = false;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000023F6 File Offset: 0x000005F6
		internal static bool NeedsChain(MonoTlsSettings settings)
		{
			return false;
		}

		// Token: 0x04000099 RID: 153
		private static bool is_macosx;

		// Token: 0x0400009A RID: 154
		private static X509KeyUsageFlags s_flags = X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature;
	}
}
