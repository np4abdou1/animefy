using System;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200014A RID: 330
	public class AppLovinNativeAdEventEventArgs : EventArgs
	{
		// Token: 0x0600101D RID: 4125 RVA: 0x0002F06B File Offset: 0x0002D26B
		public AppLovinNativeAdEventEventArgs(IAppLovinNativeAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0002F07A File Offset: 0x0002D27A
		public IAppLovinNativeAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000551 RID: 1361
		private IAppLovinNativeAd p0;
	}
}
