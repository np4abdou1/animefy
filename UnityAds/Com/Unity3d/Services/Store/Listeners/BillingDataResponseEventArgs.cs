using System;
using System.Collections;
using Com.Unity3d.Services.Store.Gpbl.Bridges;

namespace Com.Unity3d.Services.Store.Listeners
{
	// Token: 0x0200003A RID: 58
	public class BillingDataResponseEventArgs : EventArgs
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000328A File Offset: 0x0000148A
		public BillingDataResponseEventArgs(BillingResultBridge p0, IList p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000032A0 File Offset: 0x000014A0
		public BillingResultBridge P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000032A8 File Offset: 0x000014A8
		public IList P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x0400000F RID: 15
		private BillingResultBridge p0;

		// Token: 0x04000010 RID: 16
		private IList p1;
	}
}
