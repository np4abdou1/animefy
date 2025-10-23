using System;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A7 RID: 423
	public class UnityBannerHideEventArgs : EventArgs
	{
		// Token: 0x0600134A RID: 4938 RVA: 0x00036C4E File Offset: 0x00034E4E
		public UnityBannerHideEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00036C5D File Offset: 0x00034E5D
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000495 RID: 1173
		private string p0;
	}
}
