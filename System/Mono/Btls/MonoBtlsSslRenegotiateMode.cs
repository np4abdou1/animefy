using System;

namespace Mono.Btls
{
	// Token: 0x0200004B RID: 75
	[Flags]
	internal enum MonoBtlsSslRenegotiateMode
	{
		// Token: 0x040000D9 RID: 217
		NEVER = 0,
		// Token: 0x040000DA RID: 218
		ONCE = 1,
		// Token: 0x040000DB RID: 219
		FREELY = 2,
		// Token: 0x040000DC RID: 220
		IGNORE = 3
	}
}
