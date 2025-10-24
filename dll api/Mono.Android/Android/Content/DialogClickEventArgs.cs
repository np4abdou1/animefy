using System;

namespace Android.Content
{
	// Token: 0x0200028F RID: 655
	public class DialogClickEventArgs : EventArgs
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x00040C0E File Offset: 0x0003EE0E
		public DialogClickEventArgs(int which)
		{
			this.which = which;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00040C1D File Offset: 0x0003EE1D
		public int Which
		{
			get
			{
				return this.which;
			}
		}

		// Token: 0x04000A87 RID: 2695
		private int which;
	}
}
