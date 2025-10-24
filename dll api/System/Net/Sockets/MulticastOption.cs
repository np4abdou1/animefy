using System;

namespace System.Net.Sockets
{
	/// <summary>Contains <see cref="T:System.Net.IPAddress" /> values used to join and drop multicast groups.</summary>
	// Token: 0x0200020B RID: 523
	public class MulticastOption
	{
		// Token: 0x04000AE2 RID: 2786
		private IPAddress group;

		// Token: 0x04000AE3 RID: 2787
		private IPAddress localAddress;

		// Token: 0x04000AE4 RID: 2788
		private int ifIndex;
	}
}
