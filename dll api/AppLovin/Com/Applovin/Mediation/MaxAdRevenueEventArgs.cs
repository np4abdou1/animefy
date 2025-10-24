using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000AD RID: 173
	public class MaxAdRevenueEventArgs : EventArgs
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x0000F4DB File Offset: 0x0000D6DB
		public MaxAdRevenueEventArgs(IMaxAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0000F4EA File Offset: 0x0000D6EA
		public IMaxAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040001E5 RID: 485
		private IMaxAd p0;
	}
}
