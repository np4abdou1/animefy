using System;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Listeners
{
	// Token: 0x02000204 RID: 516
	public class InitializationStatusEventArgs : EventArgs
	{
		// Token: 0x0600180F RID: 6159 RVA: 0x000459A6 File Offset: 0x00043BA6
		public InitializationStatusEventArgs(Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x000459B5 File Offset: 0x00043BB5
		public Java.Lang.Object P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040005DB RID: 1499
		private Java.Lang.Object p0;
	}
}
