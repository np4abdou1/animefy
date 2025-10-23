using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A8 RID: 168
	public class AdLoadFailedEventArgs : EventArgs
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x0000F172 File Offset: 0x0000D372
		public AdLoadFailedEventArgs(string p0, IMaxError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0000F188 File Offset: 0x0000D388
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0000F190 File Offset: 0x0000D390
		public IMaxError P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x040001D7 RID: 471
		private string p0;

		// Token: 0x040001D8 RID: 472
		private IMaxError p1;
	}
}
