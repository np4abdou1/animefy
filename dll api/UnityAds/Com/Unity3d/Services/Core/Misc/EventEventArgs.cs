using System;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000D9 RID: 217
	public class EventEventArgs : EventArgs
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x00018B58 File Offset: 0x00016D58
		public EventEventArgs(Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00018B67 File Offset: 0x00016D67
		public Java.Lang.Object P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000200 RID: 512
		private Java.Lang.Object p0;
	}
}
