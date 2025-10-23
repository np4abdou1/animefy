using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000082 RID: 130
	public class VideoPlaybackBeganEventArgs : EventArgs
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x0000B8CC File Offset: 0x00009ACC
		public VideoPlaybackBeganEventArgs(IAppLovinAd p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000B8DB File Offset: 0x00009ADB
		public IAppLovinAd P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400012F RID: 303
		private IAppLovinAd p0;
	}
}
