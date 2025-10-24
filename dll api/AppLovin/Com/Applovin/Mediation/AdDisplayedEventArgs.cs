using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A6 RID: 166
	public class AdDisplayedEventArgs : EventArgs
	{
		// Token: 0x060005CE RID: 1486 RVA: 0x0000F144 File Offset: 0x0000D344
		public AdDisplayedEventArgs(IMaxAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000F153 File Offset: 0x0000D353
		public IMaxAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040001D5 RID: 469
		private IMaxAd p0;
	}
}
