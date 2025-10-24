using System;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A1 RID: 161
	public class ResolveEventArgs : EventArgs
	{
		// Token: 0x060005DB RID: 1499 RVA: 0x000108A3 File Offset: 0x0000EAA3
		public ResolveEventArgs(string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000108B9 File Offset: 0x0000EAB9
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000108C1 File Offset: 0x0000EAC1
		public string P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x0400015A RID: 346
		private string p0;

		// Token: 0x0400015B RID: 347
		private string p1;
	}
}
