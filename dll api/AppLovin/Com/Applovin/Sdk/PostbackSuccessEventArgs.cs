using System;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200008A RID: 138
	public class PostbackSuccessEventArgs : EventArgs
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x0000C232 File Offset: 0x0000A432
		public PostbackSuccessEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000C241 File Offset: 0x0000A441
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400014C RID: 332
		private string p0;
	}
}
