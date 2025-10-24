using System;

namespace System.Net.Sockets
{
	/// <summary>The type of asynchronous socket operation most recently performed with this context object.</summary>
	// Token: 0x0200020E RID: 526
	public enum SocketAsyncOperation
	{
		/// <summary>None of the socket operations.</summary>
		// Token: 0x04000B04 RID: 2820
		None,
		/// <summary>A socket Accept operation. </summary>
		// Token: 0x04000B05 RID: 2821
		Accept,
		/// <summary>A socket Connect operation.</summary>
		// Token: 0x04000B06 RID: 2822
		Connect,
		/// <summary>A socket Disconnect operation.</summary>
		// Token: 0x04000B07 RID: 2823
		Disconnect,
		/// <summary>A socket Receive operation.</summary>
		// Token: 0x04000B08 RID: 2824
		Receive,
		/// <summary>A socket ReceiveFrom operation.</summary>
		// Token: 0x04000B09 RID: 2825
		ReceiveFrom,
		/// <summary>A socket ReceiveMessageFrom operation.</summary>
		// Token: 0x04000B0A RID: 2826
		ReceiveMessageFrom,
		/// <summary>A socket Send operation.</summary>
		// Token: 0x04000B0B RID: 2827
		Send,
		/// <summary>A socket SendPackets operation.</summary>
		// Token: 0x04000B0C RID: 2828
		SendPackets,
		/// <summary>A socket SendTo operation.</summary>
		// Token: 0x04000B0D RID: 2829
		SendTo
	}
}
