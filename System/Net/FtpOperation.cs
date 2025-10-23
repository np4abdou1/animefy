using System;

namespace System.Net
{
	// Token: 0x02000123 RID: 291
	internal enum FtpOperation
	{
		// Token: 0x040005C8 RID: 1480
		DownloadFile,
		// Token: 0x040005C9 RID: 1481
		ListDirectory,
		// Token: 0x040005CA RID: 1482
		ListDirectoryDetails,
		// Token: 0x040005CB RID: 1483
		UploadFile,
		// Token: 0x040005CC RID: 1484
		UploadFileUnique,
		// Token: 0x040005CD RID: 1485
		AppendFile,
		// Token: 0x040005CE RID: 1486
		DeleteFile,
		// Token: 0x040005CF RID: 1487
		GetDateTimestamp,
		// Token: 0x040005D0 RID: 1488
		GetFileSize,
		// Token: 0x040005D1 RID: 1489
		Rename,
		// Token: 0x040005D2 RID: 1490
		MakeDirectory,
		// Token: 0x040005D3 RID: 1491
		RemoveDirectory,
		// Token: 0x040005D4 RID: 1492
		PrintWorkingDirectory,
		// Token: 0x040005D5 RID: 1493
		Other
	}
}
