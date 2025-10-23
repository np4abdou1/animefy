using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D5 RID: 725
	public class UnityAdsTokenEventArgs : EventArgs
	{
		// Token: 0x06002849 RID: 10313 RVA: 0x00067E84 File Offset: 0x00066084
		public UnityAdsTokenEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x00067E93 File Offset: 0x00066093
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000837 RID: 2103
		private string p0;
	}
}
