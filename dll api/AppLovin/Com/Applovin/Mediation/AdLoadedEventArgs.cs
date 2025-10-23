using System;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A9 RID: 169
	public class AdLoadedEventArgs : EventArgs
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x0000F198 File Offset: 0x0000D398
		public AdLoadedEventArgs(IMaxAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0000F1A7 File Offset: 0x0000D3A7
		public IMaxAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040001D9 RID: 473
		private IMaxAd p0;
	}
}
