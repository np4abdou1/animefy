using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A7 RID: 167
	public class AdHiddenEventArgs : EventArgs
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x0000F15B File Offset: 0x0000D35B
		public AdHiddenEventArgs(IMaxAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0000F16A File Offset: 0x0000D36A
		public IMaxAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040001D6 RID: 470
		private IMaxAd p0;
	}
}
