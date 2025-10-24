using System;

namespace SQLite
{
	// Token: 0x02000005 RID: 5
	[Flags]
	public enum SQLiteOpenFlags
	{
		// Token: 0x04000005 RID: 5
		ReadOnly = 1,
		// Token: 0x04000006 RID: 6
		ReadWrite = 2,
		// Token: 0x04000007 RID: 7
		Create = 4,
		// Token: 0x04000008 RID: 8
		NoMutex = 32768,
		// Token: 0x04000009 RID: 9
		FullMutex = 65536,
		// Token: 0x0400000A RID: 10
		SharedCache = 131072,
		// Token: 0x0400000B RID: 11
		PrivateCache = 262144,
		// Token: 0x0400000C RID: 12
		ProtectionComplete = 1048576,
		// Token: 0x0400000D RID: 13
		ProtectionCompleteUnlessOpen = 2097152,
		// Token: 0x0400000E RID: 14
		ProtectionCompleteUntilFirstUserAuthentication = 3145728,
		// Token: 0x0400000F RID: 15
		ProtectionNone = 4194304
	}
}
