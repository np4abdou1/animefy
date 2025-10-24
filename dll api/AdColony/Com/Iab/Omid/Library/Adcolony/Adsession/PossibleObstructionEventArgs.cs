using System;
using System.Collections.Generic;
using Android.Views;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000031 RID: 49
	public class PossibleObstructionEventArgs : EventArgs
	{
		// Token: 0x06000194 RID: 404 RVA: 0x000052B8 File Offset: 0x000034B8
		public PossibleObstructionEventArgs(string p0, IList<View> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000052CE File Offset: 0x000034CE
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000052D6 File Offset: 0x000034D6
		public IList<View> P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x0400004B RID: 75
		private string p0;

		// Token: 0x0400004C RID: 76
		private IList<View> p1;
	}
}
