using System;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000052 RID: 82
	public class AdColonyRewardEventArgs : EventArgs
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0000CABA File Offset: 0x0000ACBA
		public AdColonyRewardEventArgs(AdColonyReward p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000CAC9 File Offset: 0x0000ACC9
		public AdColonyReward P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400012D RID: 301
		private AdColonyReward p0;
	}
}
