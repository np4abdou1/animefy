using System;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000ED RID: 237
	public class AppActiveEventArgs : EventArgs
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x0001B91F File Offset: 0x00019B1F
		public AppActiveEventArgs(bool p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0001B92E File Offset: 0x00019B2E
		public bool P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000235 RID: 565
		private bool p0;
	}
}
