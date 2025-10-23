using System;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A5 RID: 421
	public class UnityBannerClickEventArgs : EventArgs
	{
		// Token: 0x06001346 RID: 4934 RVA: 0x00036C20 File Offset: 0x00034E20
		public UnityBannerClickEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00036C2F File Offset: 0x00034E2F
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000493 RID: 1171
		private string p0;
	}
}
