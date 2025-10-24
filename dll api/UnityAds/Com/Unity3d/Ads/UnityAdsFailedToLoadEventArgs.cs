using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002CA RID: 714
	public class UnityAdsFailedToLoadEventArgs : EventArgs
	{
		// Token: 0x0600280A RID: 10250 RVA: 0x000675FC File Offset: 0x000657FC
		public UnityAdsFailedToLoadEventArgs(string p0, UnityAds.UnityAdsLoadError p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x00067619 File Offset: 0x00065819
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x00067621 File Offset: 0x00065821
		public UnityAds.UnityAdsLoadError P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x00067629 File Offset: 0x00065829
		public string P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x04000817 RID: 2071
		private string p0;

		// Token: 0x04000818 RID: 2072
		private UnityAds.UnityAdsLoadError p1;

		// Token: 0x04000819 RID: 2073
		private string p2;
	}
}
