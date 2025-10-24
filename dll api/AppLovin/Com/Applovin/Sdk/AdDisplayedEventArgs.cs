using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200006F RID: 111
	public class AdDisplayedEventArgs : EventArgs
	{
		// Token: 0x060003CD RID: 973 RVA: 0x0000A6DF File Offset: 0x000088DF
		public AdDisplayedEventArgs(IAppLovinAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000A6EE File Offset: 0x000088EE
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040000F6 RID: 246
		private IAppLovinAd p0;
	}
}
