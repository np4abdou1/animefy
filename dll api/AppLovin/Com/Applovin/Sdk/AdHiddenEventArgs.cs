using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000070 RID: 112
	public class AdHiddenEventArgs : EventArgs
	{
		// Token: 0x060003CF RID: 975 RVA: 0x0000A6F6 File Offset: 0x000088F6
		public AdHiddenEventArgs(IAppLovinAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000A705 File Offset: 0x00008905
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040000F7 RID: 247
		private IAppLovinAd p0;
	}
}
