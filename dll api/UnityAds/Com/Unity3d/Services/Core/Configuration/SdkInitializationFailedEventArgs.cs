using System;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000168 RID: 360
	public class SdkInitializationFailedEventArgs : EventArgs
	{
		// Token: 0x06000FAB RID: 4011 RVA: 0x0002A633 File Offset: 0x00028833
		public SdkInitializationFailedEventArgs(string p0, ErrorState p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0002A650 File Offset: 0x00028850
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0002A658 File Offset: 0x00028858
		public ErrorState P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0002A660 File Offset: 0x00028860
		public int P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x040003C4 RID: 964
		private string p0;

		// Token: 0x040003C5 RID: 965
		private ErrorState p1;

		// Token: 0x040003C6 RID: 966
		private int p2;
	}
}
