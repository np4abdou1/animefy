using System;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002AD RID: 685
	public class SuccessEventArgs : EventArgs
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x00064D3A File Offset: 0x00062F3A
		public SuccessEventArgs(string p0, string p1, Java.Lang.Object p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x00064D57 File Offset: 0x00062F57
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x00064D5F File Offset: 0x00062F5F
		public string P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x00064D67 File Offset: 0x00062F67
		public Java.Lang.Object P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x040007C3 RID: 1987
		private string p0;

		// Token: 0x040007C4 RID: 1988
		private string p1;

		// Token: 0x040007C5 RID: 1989
		private Java.Lang.Object p2;
	}
}
