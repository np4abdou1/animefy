using System;
using Com.Applovin.Sdk;

namespace Com.Applovin.Adview
{
	// Token: 0x02000196 RID: 406
	public class AdFailedToDisplayEventArgs : EventArgs
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x00036C7B File Offset: 0x00034E7B
		public AdFailedToDisplayEventArgs(IAppLovinAd p0, AppLovinAdView p1, AppLovinAdViewDisplayErrorCode p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00036C98 File Offset: 0x00034E98
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00036CA0 File Offset: 0x00034EA0
		public AppLovinAdView P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00036CA8 File Offset: 0x00034EA8
		public AppLovinAdViewDisplayErrorCode P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x04000632 RID: 1586
		private IAppLovinAd p0;

		// Token: 0x04000633 RID: 1587
		private AppLovinAdView p1;

		// Token: 0x04000634 RID: 1588
		private AppLovinAdViewDisplayErrorCode p2;
	}
}
