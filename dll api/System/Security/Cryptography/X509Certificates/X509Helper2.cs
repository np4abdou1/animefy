using System;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000105 RID: 261
	internal static class X509Helper2
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x0002A8FC File Offset: 0x00028AFC
		internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate)
		{
			X509Certificate2ImplMono x509Certificate2ImplMono = certificate.Impl as X509Certificate2ImplMono;
			if (x509Certificate2ImplMono != null)
			{
				return x509Certificate2ImplMono.MonoCertificate;
			}
			return new X509Certificate(certificate.RawData);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0002A92A File Offset: 0x00028B2A
		internal static X509ChainImpl CreateChainImpl(bool useMachineContext)
		{
			return new X509ChainImplMono(useMachineContext);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0002A932 File Offset: 0x00028B32
		public static bool IsValid(X509ChainImpl impl)
		{
			return impl != null && impl.IsValid;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002A93F File Offset: 0x00028B3F
		internal static void ThrowIfContextInvalid(X509ChainImpl impl)
		{
			if (!X509Helper2.IsValid(impl))
			{
				throw X509Helper2.GetInvalidChainContextException();
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0002A94F File Offset: 0x00028B4F
		internal static Exception GetInvalidChainContextException()
		{
			return new CryptographicException(Locale.GetText("Chain instance is empty."));
		}
	}
}
