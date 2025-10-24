using System;

namespace System.Net
{
	// Token: 0x020001CB RID: 459
	internal enum ReadState
	{
		// Token: 0x0400092C RID: 2348
		None,
		// Token: 0x0400092D RID: 2349
		Status,
		// Token: 0x0400092E RID: 2350
		Headers,
		// Token: 0x0400092F RID: 2351
		Content,
		// Token: 0x04000930 RID: 2352
		Aborted
	}
}
