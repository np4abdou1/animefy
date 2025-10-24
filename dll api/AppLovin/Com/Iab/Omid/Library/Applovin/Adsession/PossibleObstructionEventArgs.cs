using System;
using System.Collections.Generic;
using Android.Views;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000046 RID: 70
	public class PossibleObstructionEventArgs : EventArgs
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00005380 File Offset: 0x00003580
		public PossibleObstructionEventArgs(string p0, IList<View> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00005396 File Offset: 0x00003596
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000539E File Offset: 0x0000359E
		public IList<View> P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x0400004E RID: 78
		private string p0;

		// Token: 0x0400004F RID: 79
		private IList<View> p1;
	}
}
