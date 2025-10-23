using System;

namespace System.Net.Sockets
{
	/// <summary>Defines the polling modes for the <see cref="M:System.Net.Sockets.Socket.Poll(System.Int32,System.Net.Sockets.SelectMode)" /> method.</summary>
	// Token: 0x0200020D RID: 525
	public enum SelectMode
	{
		/// <summary>Read status mode.</summary>
		// Token: 0x04000B00 RID: 2816
		SelectRead,
		/// <summary>Write status mode.</summary>
		// Token: 0x04000B01 RID: 2817
		SelectWrite,
		/// <summary>Error status mode.</summary>
		// Token: 0x04000B02 RID: 2818
		SelectError
	}
}
