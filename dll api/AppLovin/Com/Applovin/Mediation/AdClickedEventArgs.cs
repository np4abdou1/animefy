using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A4 RID: 164
	public class AdClickedEventArgs : EventArgs
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x0000F107 File Offset: 0x0000D307
		public AdClickedEventArgs(IMaxAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0000F116 File Offset: 0x0000D316
		public IMaxAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040001D2 RID: 466
		private IMaxAd p0;
	}
}
