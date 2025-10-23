using System;
using Com.Applovin.Sdk;

namespace Com.Applovin.Adview
{
	// Token: 0x02000197 RID: 407
	public class AdLeftApplicationEventArgs : EventArgs
	{
		// Token: 0x060012F6 RID: 4854 RVA: 0x00036CB0 File Offset: 0x00034EB0
		public AdLeftApplicationEventArgs(IAppLovinAd p0, AppLovinAdView p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00036CC6 File Offset: 0x00034EC6
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00036CCE File Offset: 0x00034ECE
		public AppLovinAdView P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000635 RID: 1589
		private IAppLovinAd p0;

		// Token: 0x04000636 RID: 1590
		private AppLovinAdView p1;
	}
}
