using System;

namespace Warkiz.Widgets
{
	// Token: 0x02000014 RID: 20
	public class SeekingEventArgs : EventArgs
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00006126 File Offset: 0x00004326
		public SeekingEventArgs(SeekParams seekParams)
		{
			this.seekParams = seekParams;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00006135 File Offset: 0x00004335
		public SeekParams SeekParams
		{
			get
			{
				return this.seekParams;
			}
		}

		// Token: 0x0400007A RID: 122
		private SeekParams seekParams;
	}
}
