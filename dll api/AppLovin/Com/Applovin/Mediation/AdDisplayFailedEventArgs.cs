using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A5 RID: 165
	public class AdDisplayFailedEventArgs : EventArgs
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x0000F11E File Offset: 0x0000D31E
		public AdDisplayFailedEventArgs(IMaxAd p0, IMaxError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0000F134 File Offset: 0x0000D334
		public IMaxAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0000F13C File Offset: 0x0000D33C
		public IMaxError P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x040001D3 RID: 467
		private IMaxAd p0;

		// Token: 0x040001D4 RID: 468
		private IMaxError p1;
	}
}
