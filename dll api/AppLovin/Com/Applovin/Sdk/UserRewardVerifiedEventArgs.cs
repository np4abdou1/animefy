using System;
using System.Collections.Generic;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200007B RID: 123
	public class UserRewardVerifiedEventArgs : EventArgs
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x0000AFA6 File Offset: 0x000091A6
		public UserRewardVerifiedEventArgs(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000AFBC File Offset: 0x000091BC
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000AFC4 File Offset: 0x000091C4
		public IDictionary<string, string> P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000114 RID: 276
		private IAppLovinAd p0;

		// Token: 0x04000115 RID: 277
		private IDictionary<string, string> p1;
	}
}
