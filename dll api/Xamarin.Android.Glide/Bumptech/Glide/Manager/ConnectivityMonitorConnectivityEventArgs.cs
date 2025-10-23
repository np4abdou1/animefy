using System;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000073 RID: 115
	public class ConnectivityMonitorConnectivityEventArgs : EventArgs
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x00010A6B File Offset: 0x0000EC6B
		public ConnectivityMonitorConnectivityEventArgs(bool p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00010A7A File Offset: 0x0000EC7A
		public bool P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000110 RID: 272
		private bool p0;
	}
}
