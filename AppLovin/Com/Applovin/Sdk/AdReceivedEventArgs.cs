using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000074 RID: 116
	public class AdReceivedEventArgs : EventArgs
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0000AA03 File Offset: 0x00008C03
		public AdReceivedEventArgs(IAppLovinAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000AA12 File Offset: 0x00008C12
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000101 RID: 257
		private IAppLovinAd p0;
	}
}
