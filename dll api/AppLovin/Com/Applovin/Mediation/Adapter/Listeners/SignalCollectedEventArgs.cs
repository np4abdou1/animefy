using System;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000126 RID: 294
	public class SignalCollectedEventArgs : EventArgs
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x000231E4 File Offset: 0x000213E4
		public SignalCollectedEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000231F3 File Offset: 0x000213F3
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000493 RID: 1171
		private string p0;
	}
}
