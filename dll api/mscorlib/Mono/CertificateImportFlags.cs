using System;

namespace Mono
{
	// Token: 0x0200000E RID: 14
	[Flags]
	internal enum CertificateImportFlags
	{
		// Token: 0x04000084 RID: 132
		None = 0,
		// Token: 0x04000085 RID: 133
		DisableNativeBackend = 1,
		// Token: 0x04000086 RID: 134
		DisableAutomaticFallback = 2
	}
}
