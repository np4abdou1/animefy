using System;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A9 RID: 169
	public class RequestProgressEventArgs : EventArgs
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00011051 File Offset: 0x0000F251
		public RequestProgressEventArgs(string p0, long p1, long p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001106E File Offset: 0x0000F26E
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00011076 File Offset: 0x0000F276
		public long P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001107E File Offset: 0x0000F27E
		public long P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x04000172 RID: 370
		private string p0;

		// Token: 0x04000173 RID: 371
		private long p1;

		// Token: 0x04000174 RID: 372
		private long p2;
	}
}
