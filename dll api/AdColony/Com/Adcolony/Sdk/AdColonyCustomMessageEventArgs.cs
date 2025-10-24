using System;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200004E RID: 78
	public class AdColonyCustomMessageEventArgs : EventArgs
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x0000C882 File Offset: 0x0000AA82
		public AdColonyCustomMessageEventArgs(AdColonyCustomMessage p0)
		{
			this.p0 = p0;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000C891 File Offset: 0x0000AA91
		public AdColonyCustomMessage P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000126 RID: 294
		private AdColonyCustomMessage p0;
	}
}
