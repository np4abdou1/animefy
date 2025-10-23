using System;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000162 RID: 354
	public class SuccessEventArgs : EventArgs
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x00029A71 File Offset: 0x00027C71
		public SuccessEventArgs(Configuration p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00029A80 File Offset: 0x00027C80
		public Configuration P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00029A88 File Offset: 0x00027C88
		public SuccessEventArgs(PrivacyConfig p0)
		{
			this.p01 = p0;
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00029A97 File Offset: 0x00027C97
		public PrivacyConfig P02
		{
			get
			{
				return this.p01;
			}
		}

		// Token: 0x04000397 RID: 919
		private Configuration p0;

		// Token: 0x04000398 RID: 920
		private PrivacyConfig p01;
	}
}
