using System;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A9 RID: 425
	public class UnityBannerShowEventArgs : EventArgs
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x00036C8B File Offset: 0x00034E8B
		public UnityBannerShowEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00036C9A File Offset: 0x00034E9A
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000498 RID: 1176
		private string p0;
	}
}
