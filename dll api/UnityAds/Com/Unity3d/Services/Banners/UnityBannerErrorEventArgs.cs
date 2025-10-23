using System;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A6 RID: 422
	public class UnityBannerErrorEventArgs : EventArgs
	{
		// Token: 0x06001348 RID: 4936 RVA: 0x00036C37 File Offset: 0x00034E37
		public UnityBannerErrorEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00036C46 File Offset: 0x00034E46
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000494 RID: 1172
		private string p0;
	}
}
