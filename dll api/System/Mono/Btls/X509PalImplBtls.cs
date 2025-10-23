using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x02000068 RID: 104
	internal class X509PalImplBtls : X509PalImpl
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x000093EC File Offset: 0x000075EC
		public X509PalImplBtls(MonoTlsProvider provider)
		{
			this.Provider = (MonoBtlsProvider)provider;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00009400 File Offset: 0x00007600
		private MonoBtlsProvider Provider { get; }

		// Token: 0x060002A4 RID: 676 RVA: 0x00009408 File Offset: 0x00007608
		public override X509CertificateImpl Import(byte[] data)
		{
			return this.Provider.GetNativeCertificate(data, null, X509KeyStorageFlags.DefaultKeySet);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009418 File Offset: 0x00007618
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return this.Provider.GetNativeCertificate(data, password, keyStorageFlags);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009428 File Offset: 0x00007628
		public override X509Certificate2Impl Import(X509Certificate cert)
		{
			return this.Provider.GetNativeCertificate(cert);
		}
	}
}
