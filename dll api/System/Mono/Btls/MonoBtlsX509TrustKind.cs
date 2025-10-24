using System;

namespace Mono.Btls
{
	// Token: 0x02000063 RID: 99
	[Flags]
	internal enum MonoBtlsX509TrustKind
	{
		// Token: 0x04000149 RID: 329
		DEFAULT = 0,
		// Token: 0x0400014A RID: 330
		TRUST_CLIENT = 1,
		// Token: 0x0400014B RID: 331
		TRUST_SERVER = 2,
		// Token: 0x0400014C RID: 332
		TRUST_ALL = 4,
		// Token: 0x0400014D RID: 333
		REJECT_CLIENT = 32,
		// Token: 0x0400014E RID: 334
		REJECT_SERVER = 64,
		// Token: 0x0400014F RID: 335
		REJECT_ALL = 128
	}
}
