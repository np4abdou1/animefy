using System;

namespace Mono.Btls
{
	// Token: 0x0200004A RID: 74
	internal enum MonoBtlsSslError
	{
		// Token: 0x040000CB RID: 203
		None,
		// Token: 0x040000CC RID: 204
		Ssl,
		// Token: 0x040000CD RID: 205
		WantRead,
		// Token: 0x040000CE RID: 206
		WantWrite,
		// Token: 0x040000CF RID: 207
		WantX509Lookup,
		// Token: 0x040000D0 RID: 208
		Syscall,
		// Token: 0x040000D1 RID: 209
		ZeroReturn,
		// Token: 0x040000D2 RID: 210
		WantConnect,
		// Token: 0x040000D3 RID: 211
		WantAccept,
		// Token: 0x040000D4 RID: 212
		WantChannelIdLookup,
		// Token: 0x040000D5 RID: 213
		PendingSession = 11,
		// Token: 0x040000D6 RID: 214
		PendingCertificate,
		// Token: 0x040000D7 RID: 215
		WantPrivateKeyOperation
	}
}
