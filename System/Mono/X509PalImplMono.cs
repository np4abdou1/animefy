using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x02000005 RID: 5
	internal class X509PalImplMono : X509PalImpl
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000022EA File Offset: 0x000004EA
		public override X509CertificateImpl Import(byte[] data)
		{
			return base.ImportFallback(data);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022F3 File Offset: 0x000004F3
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return base.ImportFallback(data, password, keyStorageFlags);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022FE File Offset: 0x000004FE
		public override X509Certificate2Impl Import(X509Certificate cert)
		{
			return null;
		}
	}
}
