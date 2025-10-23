using System;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000F1 RID: 241
	public class AppEventEventArgs : EventArgs
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x0001BB56 File Offset: 0x00019D56
		public AppEventEventArgs(LifecycleEvent p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0001BB65 File Offset: 0x00019D65
		public LifecycleEvent P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400023C RID: 572
		private LifecycleEvent p0;
	}
}
