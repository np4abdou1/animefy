using System;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001DD RID: 477
	public class NativeTokenGeneratorEventArgs : EventArgs
	{
		// Token: 0x060015D3 RID: 5587 RVA: 0x0003E994 File Offset: 0x0003CB94
		public NativeTokenGeneratorEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x0003E9A3 File Offset: 0x0003CBA3
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400052E RID: 1326
		private string p0;
	}
}
