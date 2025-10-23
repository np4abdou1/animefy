using System;

namespace Mono.Security.X509
{
	// Token: 0x02000015 RID: 21
	[Flags]
	[Serializable]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000068 RID: 104
		InvalidBasicConstraints = 1024,
		// Token: 0x04000069 RID: 105
		NoError = 0,
		// Token: 0x0400006A RID: 106
		NotSignatureValid = 8,
		// Token: 0x0400006B RID: 107
		NotTimeNested = 2,
		// Token: 0x0400006C RID: 108
		NotTimeValid = 1,
		// Token: 0x0400006D RID: 109
		PartialChain = 65536,
		// Token: 0x0400006E RID: 110
		UntrustedRoot = 32
	}
}
