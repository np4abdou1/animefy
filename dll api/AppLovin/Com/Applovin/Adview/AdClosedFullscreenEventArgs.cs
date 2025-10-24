using System;
using Com.Applovin.Sdk;

namespace Com.Applovin.Adview
{
	// Token: 0x02000195 RID: 405
	public class AdClosedFullscreenEventArgs : EventArgs
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x00036C55 File Offset: 0x00034E55
		public AdClosedFullscreenEventArgs(IAppLovinAd p0, AppLovinAdView p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00036C6B File Offset: 0x00034E6B
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00036C73 File Offset: 0x00034E73
		public AppLovinAdView P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000630 RID: 1584
		private IAppLovinAd p0;

		// Token: 0x04000631 RID: 1585
		private AppLovinAdView p1;
	}
}
