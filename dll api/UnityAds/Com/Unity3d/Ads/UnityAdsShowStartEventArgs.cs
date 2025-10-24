using System;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D1 RID: 721
	public class UnityAdsShowStartEventArgs : EventArgs
	{
		// Token: 0x06002834 RID: 10292 RVA: 0x00067BAE File Offset: 0x00065DAE
		public UnityAdsShowStartEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x00067BBD File Offset: 0x00065DBD
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400082D RID: 2093
		private string p0;
	}
}
