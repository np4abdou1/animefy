using System;

namespace System.Net
{
	// Token: 0x02000124 RID: 292
	[Flags]
	internal enum FtpMethodFlags
	{
		// Token: 0x040005D7 RID: 1495
		None = 0,
		// Token: 0x040005D8 RID: 1496
		IsDownload = 1,
		// Token: 0x040005D9 RID: 1497
		IsUpload = 2,
		// Token: 0x040005DA RID: 1498
		TakesParameter = 4,
		// Token: 0x040005DB RID: 1499
		MayTakeParameter = 8,
		// Token: 0x040005DC RID: 1500
		DoesNotTakeParameter = 16,
		// Token: 0x040005DD RID: 1501
		ParameterIsDirectory = 32,
		// Token: 0x040005DE RID: 1502
		ShouldParseForResponseUri = 64,
		// Token: 0x040005DF RID: 1503
		HasHttpCommand = 128,
		// Token: 0x040005E0 RID: 1504
		MustChangeWorkingDirectoryToPath = 256
	}
}
