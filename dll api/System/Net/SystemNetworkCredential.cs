using System;

namespace System.Net
{
	// Token: 0x0200014B RID: 331
	internal class SystemNetworkCredential : NetworkCredential
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x000333D8 File Offset: 0x000315D8
		private SystemNetworkCredential() : base(string.Empty, string.Empty, string.Empty)
		{
		}

		// Token: 0x04000689 RID: 1673
		internal static readonly SystemNetworkCredential defaultCredential = new SystemNetworkCredential();
	}
}
