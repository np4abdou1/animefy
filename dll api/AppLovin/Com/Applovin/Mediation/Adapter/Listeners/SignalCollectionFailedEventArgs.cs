using System;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000127 RID: 295
	public class SignalCollectionFailedEventArgs : EventArgs
	{
		// Token: 0x06000D1E RID: 3358 RVA: 0x000231FB File Offset: 0x000213FB
		public SignalCollectionFailedEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0002320A File Offset: 0x0002140A
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
