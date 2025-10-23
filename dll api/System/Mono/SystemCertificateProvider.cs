using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using Mono.Btls;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono
{
	// Token: 0x02000002 RID: 2
	internal class SystemCertificateProvider : ISystemCertificateProvider
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static X509PalImpl GetX509Pal()
		{
			MonoTlsProvider monoTlsProvider = SystemCertificateProvider.provider;
			Guid? guid = (monoTlsProvider != null) ? new Guid?(monoTlsProvider.ID) : null;
			Guid btlsId = Mono.Net.Security.MonoTlsProviderFactory.BtlsId;
			if (guid != null && (guid == null || guid.GetValueOrDefault() == btlsId))
			{
				return new X509PalImplBtls(SystemCertificateProvider.provider);
			}
			return new X509PalImplMono();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020BC File Offset: 0x000002BC
		private static void EnsureInitialized()
		{
			object obj = SystemCertificateProvider.syncRoot;
			lock (obj)
			{
				if (Interlocked.CompareExchange(ref SystemCertificateProvider.initialized, 1, 0) == 0)
				{
					SystemCertificateProvider.provider = Mono.Security.Interface.MonoTlsProviderFactory.GetProvider();
					SystemCertificateProvider.x509pal = SystemCertificateProvider.GetX509Pal();
				}
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000211C File Offset: 0x0000031C
		public X509PalImpl X509Pal
		{
			get
			{
				SystemCertificateProvider.EnsureInitialized();
				return SystemCertificateProvider.x509pal;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002128 File Offset: 0x00000328
		public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			if (data == null || data.Length == 0)
			{
				return null;
			}
			if ((importFlags & CertificateImportFlags.DisableNativeBackend) == CertificateImportFlags.None)
			{
				X509CertificateImpl x509CertificateImpl = this.X509Pal.Import(data);
				if (x509CertificateImpl != null)
				{
					return x509CertificateImpl;
				}
			}
			if ((importFlags & CertificateImportFlags.DisableAutomaticFallback) != CertificateImportFlags.None)
			{
				return null;
			}
			return this.X509Pal.ImportFallback(data);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000216A File Offset: 0x0000036A
		X509CertificateImpl ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags)
		{
			return this.Import(data, password, keyStorageFlags, importFlags);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002178 File Offset: 0x00000378
		public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			if (data == null || data.Length == 0)
			{
				return null;
			}
			if ((importFlags & CertificateImportFlags.DisableNativeBackend) == CertificateImportFlags.None)
			{
				X509Certificate2Impl x509Certificate2Impl = this.X509Pal.Import(data, password, keyStorageFlags);
				if (x509Certificate2Impl != null)
				{
					return x509Certificate2Impl;
				}
			}
			if ((importFlags & CertificateImportFlags.DisableAutomaticFallback) != CertificateImportFlags.None)
			{
				return null;
			}
			return this.X509Pal.ImportFallback(data, password, keyStorageFlags);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021C0 File Offset: 0x000003C0
		X509CertificateImpl ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags)
		{
			return this.Import(cert, importFlags);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021CC File Offset: 0x000003CC
		public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			if (cert.Impl == null)
			{
				return null;
			}
			X509Certificate2Impl x509Certificate2Impl = cert.Impl as X509Certificate2Impl;
			if (x509Certificate2Impl != null)
			{
				return (X509Certificate2Impl)x509Certificate2Impl.Clone();
			}
			if ((importFlags & CertificateImportFlags.DisableNativeBackend) == CertificateImportFlags.None)
			{
				x509Certificate2Impl = this.X509Pal.Import(cert);
				if (x509Certificate2Impl != null)
				{
					return x509Certificate2Impl;
				}
			}
			if ((importFlags & CertificateImportFlags.DisableAutomaticFallback) != CertificateImportFlags.None)
			{
				return null;
			}
			return this.X509Pal.ImportFallback(cert.GetRawCertData());
		}

		// Token: 0x04000001 RID: 1
		private static MonoTlsProvider provider;

		// Token: 0x04000002 RID: 2
		private static int initialized;

		// Token: 0x04000003 RID: 3
		private static X509PalImpl x509pal;

		// Token: 0x04000004 RID: 4
		private static object syncRoot = new object();
	}
}
