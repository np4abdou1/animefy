using System;
using System.Collections.Generic;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000AA RID: 170
	public class RequestStartEventArgs : EventArgs
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00011086 File Offset: 0x0000F286
		public RequestStartEventArgs(string p0, long p1, int p2, IDictionary<string, IList<string>> p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000110AB File Offset: 0x0000F2AB
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000110B3 File Offset: 0x0000F2B3
		public long P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000110BB File Offset: 0x0000F2BB
		public int P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x000110C3 File Offset: 0x0000F2C3
		public IDictionary<string, IList<string>> P3
		{
			get
			{
				return this.p3;
			}
		}

		// Token: 0x04000175 RID: 373
		private string p0;

		// Token: 0x04000176 RID: 374
		private long p1;

		// Token: 0x04000177 RID: 375
		private int p2;

		// Token: 0x04000178 RID: 376
		private IDictionary<string, IList<string>> p3;
	}
}
