using System;
using Android.OS;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200009C RID: 156
	public class AppLovinVariableServiceOnVariablesUpdateEventArgs : EventArgs
	{
		// Token: 0x06000539 RID: 1337 RVA: 0x0000DB12 File Offset: 0x0000BD12
		public AppLovinVariableServiceOnVariablesUpdateEventArgs(Bundle p0)
		{
			this.p0 = p0;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0000DB21 File Offset: 0x0000BD21
		public Bundle P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000191 RID: 401
		private Bundle p0;
	}
}
