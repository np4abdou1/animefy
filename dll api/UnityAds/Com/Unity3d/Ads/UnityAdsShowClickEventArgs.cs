using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002CE RID: 718
	public class UnityAdsShowClickEventArgs : EventArgs
	{
		// Token: 0x0600282B RID: 10283 RVA: 0x00067B3C File Offset: 0x00065D3C
		public UnityAdsShowClickEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x00067B4B File Offset: 0x00065D4B
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000827 RID: 2087
		private string p0;
	}
}
