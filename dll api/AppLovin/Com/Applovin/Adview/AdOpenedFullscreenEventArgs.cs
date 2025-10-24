using System;
using Com.Applovin.Sdk;

namespace Com.Applovin.Adview
{
	// Token: 0x02000198 RID: 408
	public class AdOpenedFullscreenEventArgs : EventArgs
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x00036CD6 File Offset: 0x00034ED6
		public AdOpenedFullscreenEventArgs(IAppLovinAd p0, AppLovinAdView p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00036CEC File Offset: 0x00034EEC
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00036CF4 File Offset: 0x00034EF4
		public AppLovinAdView P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000637 RID: 1591
		private IAppLovinAd p0;

		// Token: 0x04000638 RID: 1592
		private AppLovinAdView p1;
	}
}
