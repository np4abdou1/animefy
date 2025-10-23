using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C9 RID: 713
	public class UnityAdsAdLoadedEventArgs : EventArgs
	{
		// Token: 0x06002808 RID: 10248 RVA: 0x000675E5 File Offset: 0x000657E5
		public UnityAdsAdLoadedEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x000675F4 File Offset: 0x000657F4
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000816 RID: 2070
		private string p0;
	}
}
