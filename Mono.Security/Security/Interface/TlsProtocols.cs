using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000047 RID: 71
	[Flags]
	public enum TlsProtocols
	{
		// Token: 0x040001FF RID: 511
		Zero = 0,
		// Token: 0x04000200 RID: 512
		Tls10Client = 128,
		// Token: 0x04000201 RID: 513
		Tls10Server = 64,
		// Token: 0x04000202 RID: 514
		Tls10 = 192,
		// Token: 0x04000203 RID: 515
		Tls11Client = 512,
		// Token: 0x04000204 RID: 516
		Tls11Server = 256,
		// Token: 0x04000205 RID: 517
		Tls11 = 768,
		// Token: 0x04000206 RID: 518
		Tls12Client = 2048,
		// Token: 0x04000207 RID: 519
		Tls12Server = 1024,
		// Token: 0x04000208 RID: 520
		Tls12 = 3072,
		// Token: 0x04000209 RID: 521
		ClientMask = 2688,
		// Token: 0x0400020A RID: 522
		ServerMask = 1344
	}
}
