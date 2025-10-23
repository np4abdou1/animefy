using System;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200014E RID: 334
	public class NativeAdLoadFailedEventArgs : EventArgs
	{
		// Token: 0x06001033 RID: 4147 RVA: 0x0002F33F File Offset: 0x0002D53F
		public NativeAdLoadFailedEventArgs(int p0)
		{
			this.p0 = p0;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0002F34E File Offset: 0x0002D54E
		public int P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400055A RID: 1370
		private int p0;
	}
}
