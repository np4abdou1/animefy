using System;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200004A RID: 74
	public class FragmentOnAttachEventArgs : EventArgs
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x0000D948 File Offset: 0x0000BB48
		public FragmentOnAttachEventArgs(FragmentManager p0, Fragment p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		// Token: 0x0400011B RID: 283
		private FragmentManager p0;

		// Token: 0x0400011C RID: 284
		private Fragment p1;
	}
}
