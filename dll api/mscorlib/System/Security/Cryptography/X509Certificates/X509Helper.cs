using System;
using Microsoft.Win32.SafeHandles;
using Mono;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020002F2 RID: 754
	internal static class X509Helper
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0006D640 File Offset: 0x0006B840
		private static ISystemCertificateProvider CertificateProvider
		{
			get
			{
				return DependencyInjector.SystemProvider.CertificateProvider;
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0006D64C File Offset: 0x0006B84C
		public static X509CertificateImpl InitFromCertificate(X509Certificate cert)
		{
			return X509Helper.CertificateProvider.Import(cert, CertificateImportFlags.None);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0006D65A File Offset: 0x0006B85A
		public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
		{
			if (impl == null)
			{
				return null;
			}
			return impl.Clone();
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0006D667 File Offset: 0x0006B867
		public static bool IsValid(X509CertificateImpl impl)
		{
			return impl != null && impl.IsValid;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0006D674 File Offset: 0x0006B874
		internal static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			if (!X509Helper.IsValid(impl))
			{
				throw X509Helper.GetInvalidContextException();
			}
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0006D684 File Offset: 0x0006B884
		internal static Exception GetInvalidContextException()
		{
			return new CryptographicException(Locale.GetText("Certificate instance is empty."));
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0006D695 File Offset: 0x0006B895
		public static X509CertificateImpl Import(byte[] rawData)
		{
			return X509Helper.CertificateProvider.Import(rawData, CertificateImportFlags.None);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0006D6A3 File Offset: 0x0006B8A3
		public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return X509Helper.CertificateProvider.Import(rawData, password, keyStorageFlags, CertificateImportFlags.None);
		}
	}
}
