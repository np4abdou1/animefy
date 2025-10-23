using System;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A0 RID: 160
	public class FailedEventArgs : EventArgs
	{
		// Token: 0x060005D4 RID: 1492 RVA: 0x00010850 File Offset: 0x0000EA50
		public FailedEventArgs(string p0, ResolveHostError p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001086D File Offset: 0x0000EA6D
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00010875 File Offset: 0x0000EA75
		public ResolveHostError P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001087D File Offset: 0x0000EA7D
		public string P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00010885 File Offset: 0x0000EA85
		public FailedEventArgs(string p0, string p1)
		{
			this.p0 = p0;
			this.p01 = p1;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001086D File Offset: 0x0000EA6D
		public string P02
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001089B File Offset: 0x0000EA9B
		public string P01
		{
			get
			{
				return this.p11;
			}
		}

		// Token: 0x04000155 RID: 341
		private string p0;

		// Token: 0x04000156 RID: 342
		private ResolveHostError p1;

		// Token: 0x04000157 RID: 343
		private string p2;

		// Token: 0x04000158 RID: 344
		private string p01;

		// Token: 0x04000159 RID: 345
		private string p11;
	}
}
