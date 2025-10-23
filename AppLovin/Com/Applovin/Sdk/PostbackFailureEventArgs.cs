using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000089 RID: 137
	public class PostbackFailureEventArgs : EventArgs
	{
		// Token: 0x06000483 RID: 1155 RVA: 0x0000C20C File Offset: 0x0000A40C
		public PostbackFailureEventArgs(string p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0000C222 File Offset: 0x0000A422
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000C22A File Offset: 0x0000A42A
		public int P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x0400014A RID: 330
		private string p0;

		// Token: 0x0400014B RID: 331
		private int p1;
	}
}
