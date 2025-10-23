using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200007C RID: 124
	public class ValidationRequestFailedEventArgs : EventArgs
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x0000AFCC File Offset: 0x000091CC
		public ValidationRequestFailedEventArgs(IAppLovinAd p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000AFE2 File Offset: 0x000091E2
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000AFEA File Offset: 0x000091EA
		public int P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000116 RID: 278
		private IAppLovinAd p0;

		// Token: 0x04000117 RID: 279
		private int p1;
	}
}
