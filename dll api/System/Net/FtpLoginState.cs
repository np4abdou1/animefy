using System;

namespace System.Net
{
	// Token: 0x0200011E RID: 286
	internal enum FtpLoginState : byte
	{
		// Token: 0x040005A2 RID: 1442
		NotLoggedIn,
		// Token: 0x040005A3 RID: 1443
		LoggedIn,
		// Token: 0x040005A4 RID: 1444
		LoggedInButNeedsRelogin,
		// Token: 0x040005A5 RID: 1445
		ReloginFailed
	}
}
