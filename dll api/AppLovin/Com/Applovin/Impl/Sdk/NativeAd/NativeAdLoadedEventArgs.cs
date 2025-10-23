using System;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200014F RID: 335
	public class NativeAdLoadedEventArgs : EventArgs
	{
		// Token: 0x06001035 RID: 4149 RVA: 0x0002F356 File Offset: 0x0002D556
		public NativeAdLoadedEventArgs(IAppLovinNativeAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0002F365 File Offset: 0x0002D565
		public IAppLovinNativeAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400055B RID: 1371
		private IAppLovinNativeAd p0;
	}
}
