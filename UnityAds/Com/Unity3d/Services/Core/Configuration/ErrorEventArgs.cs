using System;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000161 RID: 353
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x00029A3E File Offset: 0x00027C3E
		public ErrorEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00029A4D File Offset: 0x00027C4D
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00029A55 File Offset: 0x00027C55
		public ErrorEventArgs()
		{
			this.p01 = this.p0;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00029A69 File Offset: 0x00027C69
		public string P01
		{
			get
			{
				return this.p01;
			}
		}

		// Token: 0x04000395 RID: 917
		private string p0;

		// Token: 0x04000396 RID: 918
		private string p01;
	}
}
