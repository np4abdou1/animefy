using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000083 RID: 131
	public class VideoPlaybackEndedEventArgs : EventArgs
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x0000B8E3 File Offset: 0x00009AE3
		public VideoPlaybackEndedEventArgs(IAppLovinAd p0, double p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000B900 File Offset: 0x00009B00
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000B908 File Offset: 0x00009B08
		public double P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000B910 File Offset: 0x00009B10
		public bool P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x04000130 RID: 304
		private IAppLovinAd p0;

		// Token: 0x04000131 RID: 305
		private double p1;

		// Token: 0x04000132 RID: 306
		private bool p2;
	}
}
