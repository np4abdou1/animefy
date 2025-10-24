using System;
using System.Collections.Generic;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A5 RID: 165
	public class CompleteEventArgs : EventArgs
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x00010C70 File Offset: 0x0000EE70
		public CompleteEventArgs(string p0, string p1, int p2, IDictionary<string, IList<string>> p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00010C95 File Offset: 0x0000EE95
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00010C9D File Offset: 0x0000EE9D
		public string P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00010CA5 File Offset: 0x0000EEA5
		public int P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00010CAD File Offset: 0x0000EEAD
		public IDictionary<string, IList<string>> P3
		{
			get
			{
				return this.p3;
			}
		}

		// Token: 0x04000165 RID: 357
		private string p0;

		// Token: 0x04000166 RID: 358
		private string p1;

		// Token: 0x04000167 RID: 359
		private int p2;

		// Token: 0x04000168 RID: 360
		private IDictionary<string, IList<string>> p3;
	}
}
