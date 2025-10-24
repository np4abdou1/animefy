using System;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B2 RID: 690
	public class SignalsCollectionFailedEventArgs : EventArgs
	{
		// Token: 0x06002736 RID: 10038 RVA: 0x00065097 File Offset: 0x00063297
		public SignalsCollectionFailedEventArgs(string p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x000650A6 File Offset: 0x000632A6
		public string P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x040007D0 RID: 2000
		private string p0;
	}
}
