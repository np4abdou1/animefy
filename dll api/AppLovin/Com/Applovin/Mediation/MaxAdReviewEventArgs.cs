using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B1 RID: 177
	public class MaxAdReviewEventArgs : EventArgs
	{
		// Token: 0x060005FE RID: 1534 RVA: 0x0000F73F File Offset: 0x0000D93F
		public MaxAdReviewEventArgs(string p0, IMaxAd p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0000F755 File Offset: 0x0000D955
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0000F75D File Offset: 0x0000D95D
		public IMaxAd P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x040001EC RID: 492
		private string p0;

		// Token: 0x040001ED RID: 493
		private IMaxAd p1;
	}
}
