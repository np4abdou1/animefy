using System;

namespace Mono.Security.Interface
{
	// Token: 0x0200003F RID: 63
	[Flags]
	public enum MonoSslPolicyErrors
	{
		// Token: 0x040001E2 RID: 482
		None = 0,
		// Token: 0x040001E3 RID: 483
		RemoteCertificateNotAvailable = 1,
		// Token: 0x040001E4 RID: 484
		RemoteCertificateNameMismatch = 2,
		// Token: 0x040001E5 RID: 485
		RemoteCertificateChainErrors = 4
	}
}
