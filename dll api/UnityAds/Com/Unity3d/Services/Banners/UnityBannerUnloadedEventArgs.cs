using System;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001AA RID: 426
	public class UnityBannerUnloadedEventArgs : EventArgs
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x00036CA2 File Offset: 0x00034EA2
		public UnityBannerUnloadedEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00036CB1 File Offset: 0x00034EB1
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000499 RID: 1177
		private string p0;
	}
}
