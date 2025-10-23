using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000075 RID: 117
	public class FailedToReceiveAdEventArgs : EventArgs
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x0000AA1A File Offset: 0x00008C1A
		public FailedToReceiveAdEventArgs(int p0)
		{
			this.p0 = p0;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000AA29 File Offset: 0x00008C29
		public int P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000102 RID: 258
		private int p0;
	}
}
