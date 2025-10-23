using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D0 RID: 720
	public class UnityAdsShowFailureEventArgs : EventArgs
	{
		// Token: 0x06002830 RID: 10288 RVA: 0x00067B79 File Offset: 0x00065D79
		public UnityAdsShowFailureEventArgs(string p0, UnityAds.UnityAdsShowError p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x00067B96 File Offset: 0x00065D96
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x00067B9E File Offset: 0x00065D9E
		public UnityAds.UnityAdsShowError P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x00067BA6 File Offset: 0x00065DA6
		public string P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x0400082A RID: 2090
		private string p0;

		// Token: 0x0400082B RID: 2091
		private UnityAds.UnityAdsShowError p1;

		// Token: 0x0400082C RID: 2092
		private string p2;
	}
}
