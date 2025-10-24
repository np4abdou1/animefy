using System;
using Com.Unity3d.Services.Store.Gpbl.Bridges;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x02000048 RID: 72
	public class BillingSetupFinishedEventArgs : EventArgs
	{
		// Token: 0x0600018B RID: 395 RVA: 0x000043AE File Offset: 0x000025AE
		public BillingSetupFinishedEventArgs(BillingResultBridge p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000043BD File Offset: 0x000025BD
		public BillingResultBridge P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400002C RID: 44
		private BillingResultBridge p0;
	}
}
