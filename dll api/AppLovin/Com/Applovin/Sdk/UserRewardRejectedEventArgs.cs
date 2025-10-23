using System;
using System.Collections.Generic;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200007A RID: 122
	public class UserRewardRejectedEventArgs : EventArgs
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x0000AF80 File Offset: 0x00009180
		public UserRewardRejectedEventArgs(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000AF96 File Offset: 0x00009196
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0000AF9E File Offset: 0x0000919E
		public IDictionary<string, string> P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000112 RID: 274
		private IAppLovinAd p0;

		// Token: 0x04000113 RID: 275
		private IDictionary<string, string> p1;
	}
}
