using System;
using System.Collections.Generic;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000079 RID: 121
	public class UserOverQuotaEventArgs : EventArgs
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x0000AF5A File Offset: 0x0000915A
		public UserOverQuotaEventArgs(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000AF70 File Offset: 0x00009170
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000AF78 File Offset: 0x00009178
		public IDictionary<string, string> P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000110 RID: 272
		private IAppLovinAd p0;

		// Token: 0x04000111 RID: 273
		private IDictionary<string, string> p1;
	}
}
