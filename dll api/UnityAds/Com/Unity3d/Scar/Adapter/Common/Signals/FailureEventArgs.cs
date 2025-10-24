using System;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002AC RID: 684
	public class FailureEventArgs : EventArgs
	{
		// Token: 0x06002719 RID: 10009 RVA: 0x00064D23 File Offset: 0x00062F23
		public FailureEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x00064D32 File Offset: 0x00062F32
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040007C2 RID: 1986
		private string p0;
	}
}
