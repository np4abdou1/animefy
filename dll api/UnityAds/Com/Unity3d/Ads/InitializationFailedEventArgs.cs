using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C5 RID: 709
	public class InitializationFailedEventArgs : EventArgs
	{
		// Token: 0x060027F0 RID: 10224 RVA: 0x00067256 File Offset: 0x00065456
		public InitializationFailedEventArgs(UnityAds.UnityAdsInitializationError p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x0006726C File Offset: 0x0006546C
		public UnityAds.UnityAdsInitializationError P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x00067274 File Offset: 0x00065474
		public string P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x0400080B RID: 2059
		private UnityAds.UnityAdsInitializationError p0;

		// Token: 0x0400080C RID: 2060
		private string p1;
	}
}
