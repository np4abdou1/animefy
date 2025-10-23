using System;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B1 RID: 689
	public class SignalsCollectedEventArgs : EventArgs
	{
		// Token: 0x06002734 RID: 10036 RVA: 0x00065080 File Offset: 0x00063280
		public SignalsCollectedEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x0006508F File Offset: 0x0006328F
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040007CF RID: 1999
		private string p0;
	}
}
