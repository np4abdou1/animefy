using System;
using Android.Views;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A8 RID: 424
	public class UnityBannerLoadedEventArgs : EventArgs
	{
		// Token: 0x0600134C RID: 4940 RVA: 0x00036C65 File Offset: 0x00034E65
		public UnityBannerLoadedEventArgs(string p0, View p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00036C7B File Offset: 0x00034E7B
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00036C83 File Offset: 0x00034E83
		public View P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000496 RID: 1174
		private string p0;

		// Token: 0x04000497 RID: 1175
		private View p1;
	}
}
