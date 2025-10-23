using System;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000FA RID: 250
	public class MaxAdapterOnCompletionEventArgs : EventArgs
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001D2BE File Offset: 0x0001B4BE
		public MaxAdapterOnCompletionEventArgs(MaxAdapterInitializationStatus p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
		public MaxAdapterInitializationStatus P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0001D2DC File Offset: 0x0001B4DC
		public string P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x04000380 RID: 896
		private MaxAdapterInitializationStatus p0;

		// Token: 0x04000381 RID: 897
		private string p1;
	}
}
