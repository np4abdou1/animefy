using System;

namespace System.Net.Sockets
{
	/// <summary>Defines constants that are used by the <see cref="M:System.Net.Sockets.Socket.Shutdown(System.Net.Sockets.SocketShutdown)" /> method.</summary>
	// Token: 0x02000213 RID: 531
	public enum SocketShutdown
	{
		/// <summary>Disables a <see cref="T:System.Net.Sockets.Socket" /> for receiving. This field is constant.</summary>
		// Token: 0x04000B7F RID: 2943
		Receive,
		/// <summary>Disables a <see cref="T:System.Net.Sockets.Socket" /> for sending. This field is constant.</summary>
		// Token: 0x04000B80 RID: 2944
		Send,
		/// <summary>Disables a <see cref="T:System.Net.Sockets.Socket" /> for both sending and receiving. This field is constant.</summary>
		// Token: 0x04000B81 RID: 2945
		Both
	}
}
