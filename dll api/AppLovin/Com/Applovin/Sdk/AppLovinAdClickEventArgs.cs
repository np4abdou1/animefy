using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200006B RID: 107
	public class AppLovinAdClickEventArgs : EventArgs
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x0000A3E3 File Offset: 0x000085E3
		public AppLovinAdClickEventArgs(IAppLovinAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000A3F2 File Offset: 0x000085F2
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040000ED RID: 237
		private IAppLovinAd p0;
	}
}
