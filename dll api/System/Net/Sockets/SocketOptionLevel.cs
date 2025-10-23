using System;

namespace System.Net.Sockets
{
	/// <summary>Defines socket option levels for the <see cref="M:System.Net.Sockets.Socket.SetSocketOption(System.Net.Sockets.SocketOptionLevel,System.Net.Sockets.SocketOptionName,System.Int32)" /> and <see cref="M:System.Net.Sockets.Socket.GetSocketOption(System.Net.Sockets.SocketOptionLevel,System.Net.Sockets.SocketOptionName)" /> methods.</summary>
	// Token: 0x02000211 RID: 529
	public enum SocketOptionLevel
	{
		/// <summary>
		///     <see cref="T:System.Net.Sockets.Socket" /> options apply to all sockets.</summary>
		// Token: 0x04000B4A RID: 2890
		Socket = 65535,
		/// <summary>
		///     <see cref="T:System.Net.Sockets.Socket" /> options apply only to IP sockets.</summary>
		// Token: 0x04000B4B RID: 2891
		IP = 0,
		/// <summary>
		///     <see cref="T:System.Net.Sockets.Socket" /> options apply only to IPv6 sockets.</summary>
		// Token: 0x04000B4C RID: 2892
		IPv6 = 41,
		/// <summary>
		///     <see cref="T:System.Net.Sockets.Socket" /> options apply only to TCP sockets.</summary>
		// Token: 0x04000B4D RID: 2893
		Tcp = 6,
		/// <summary>
		///     <see cref="T:System.Net.Sockets.Socket" /> options apply only to UDP sockets.</summary>
		// Token: 0x04000B4E RID: 2894
		Udp = 17
	}
}
