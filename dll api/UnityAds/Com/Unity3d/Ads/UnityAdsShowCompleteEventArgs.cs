using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002CF RID: 719
	public class UnityAdsShowCompleteEventArgs : EventArgs
	{
		// Token: 0x0600282D RID: 10285 RVA: 0x00067B53 File Offset: 0x00065D53
		public UnityAdsShowCompleteEventArgs(string p0, UnityAds.UnityAdsShowCompletionState p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x00067B69 File Offset: 0x00065D69
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x00067B71 File Offset: 0x00065D71
		public UnityAds.UnityAdsShowCompletionState P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000828 RID: 2088
		private string p0;

		// Token: 0x04000829 RID: 2089
		private UnityAds.UnityAdsShowCompletionState p1;
	}
}
