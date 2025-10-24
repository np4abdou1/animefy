using System;

namespace System.Net.Sockets
{
	/// <summary>Defines error codes for the <see cref="T:System.Net.Sockets.Socket" /> class.</summary>
	// Token: 0x0200020F RID: 527
	public enum SocketError
	{
		/// <summary>The <see cref="T:System.Net.Sockets.Socket" /> operation succeeded.</summary>
		// Token: 0x04000B0F RID: 2831
		Success,
		/// <summary>An unspecified <see cref="T:System.Net.Sockets.Socket" /> error has occurred.</summary>
		// Token: 0x04000B10 RID: 2832
		SocketError = -1,
		/// <summary>A blocking <see cref="T:System.Net.Sockets.Socket" /> call was canceled.</summary>
		// Token: 0x04000B11 RID: 2833
		Interrupted = 10004,
		/// <summary>An attempt was made to access a <see cref="T:System.Net.Sockets.Socket" /> in a way that is forbidden by its access permissions.</summary>
		// Token: 0x04000B12 RID: 2834
		AccessDenied = 10013,
		/// <summary>An invalid pointer address was detected by the underlying socket provider.</summary>
		// Token: 0x04000B13 RID: 2835
		Fault,
		/// <summary>An invalid argument was supplied to a <see cref="T:System.Net.Sockets.Socket" /> member.</summary>
		// Token: 0x04000B14 RID: 2836
		InvalidArgument = 10022,
		/// <summary>There are too many open sockets in the underlying socket provider.</summary>
		// Token: 0x04000B15 RID: 2837
		TooManyOpenSockets = 10024,
		/// <summary>An operation on a nonblocking socket cannot be completed immediately.</summary>
		// Token: 0x04000B16 RID: 2838
		WouldBlock = 10035,
		/// <summary>A blocking operation is in progress.</summary>
		// Token: 0x04000B17 RID: 2839
		InProgress,
		/// <summary>The nonblocking <see cref="T:System.Net.Sockets.Socket" /> already has an operation in progress.</summary>
		// Token: 0x04000B18 RID: 2840
		AlreadyInProgress,
		/// <summary>A <see cref="T:System.Net.Sockets.Socket" /> operation was attempted on a non-socket.</summary>
		// Token: 0x04000B19 RID: 2841
		NotSocket,
		/// <summary>A required address was omitted from an operation on a <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04000B1A RID: 2842
		DestinationAddressRequired,
		/// <summary>The datagram is too long.</summary>
		// Token: 0x04000B1B RID: 2843
		MessageSize,
		/// <summary>The protocol type is incorrect for this <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04000B1C RID: 2844
		ProtocolType,
		/// <summary>An unknown, invalid, or unsupported option or level was used with a <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04000B1D RID: 2845
		ProtocolOption,
		/// <summary>The protocol is not implemented or has not been configured.</summary>
		// Token: 0x04000B1E RID: 2846
		ProtocolNotSupported,
		/// <summary>The support for the specified socket type does not exist in this address family.</summary>
		// Token: 0x04000B1F RID: 2847
		SocketNotSupported,
		/// <summary>The address family is not supported by the protocol family.</summary>
		// Token: 0x04000B20 RID: 2848
		OperationNotSupported,
		/// <summary>The protocol family is not implemented or has not been configured.</summary>
		// Token: 0x04000B21 RID: 2849
		ProtocolFamilyNotSupported,
		/// <summary>The address family specified is not supported. This error is returned if the IPv6 address family was specified and the IPv6 stack is not installed on the local machine. This error is returned if the IPv4 address family was specified and the IPv4 stack is not installed on the local machine.</summary>
		// Token: 0x04000B22 RID: 2850
		AddressFamilyNotSupported,
		/// <summary>Only one use of an address is normally permitted.</summary>
		// Token: 0x04000B23 RID: 2851
		AddressAlreadyInUse,
		/// <summary>The selected IP address is not valid in this context.</summary>
		// Token: 0x04000B24 RID: 2852
		AddressNotAvailable,
		/// <summary>The network is not available.</summary>
		// Token: 0x04000B25 RID: 2853
		NetworkDown,
		/// <summary>No route to the remote host exists.</summary>
		// Token: 0x04000B26 RID: 2854
		NetworkUnreachable,
		/// <summary>The application tried to set <see cref="F:System.Net.Sockets.SocketOptionName.KeepAlive" /> on a connection that has already timed out.</summary>
		// Token: 0x04000B27 RID: 2855
		NetworkReset,
		/// <summary>The connection was aborted by the .NET Framework or the underlying socket provider.</summary>
		// Token: 0x04000B28 RID: 2856
		ConnectionAborted,
		/// <summary>The connection was reset by the remote peer.</summary>
		// Token: 0x04000B29 RID: 2857
		ConnectionReset,
		/// <summary>No free buffer space is available for a <see cref="T:System.Net.Sockets.Socket" /> operation.</summary>
		// Token: 0x04000B2A RID: 2858
		NoBufferSpaceAvailable,
		/// <summary>The <see cref="T:System.Net.Sockets.Socket" /> is already connected.</summary>
		// Token: 0x04000B2B RID: 2859
		IsConnected,
		/// <summary>The application tried to send or receive data, and the <see cref="T:System.Net.Sockets.Socket" /> is not connected.</summary>
		// Token: 0x04000B2C RID: 2860
		NotConnected,
		/// <summary>A request to send or receive data was disallowed because the <see cref="T:System.Net.Sockets.Socket" /> has already been closed.</summary>
		// Token: 0x04000B2D RID: 2861
		Shutdown,
		/// <summary>The connection attempt timed out, or the connected host has failed to respond.</summary>
		// Token: 0x04000B2E RID: 2862
		TimedOut = 10060,
		/// <summary>The remote host is actively refusing a connection.</summary>
		// Token: 0x04000B2F RID: 2863
		ConnectionRefused,
		/// <summary>The operation failed because the remote host is down.</summary>
		// Token: 0x04000B30 RID: 2864
		HostDown = 10064,
		/// <summary>There is no network route to the specified host.</summary>
		// Token: 0x04000B31 RID: 2865
		HostUnreachable,
		/// <summary>Too many processes are using the underlying socket provider.</summary>
		// Token: 0x04000B32 RID: 2866
		ProcessLimit = 10067,
		/// <summary>The network subsystem is unavailable.</summary>
		// Token: 0x04000B33 RID: 2867
		SystemNotReady = 10091,
		/// <summary>The version of the underlying socket provider is out of range.</summary>
		// Token: 0x04000B34 RID: 2868
		VersionNotSupported,
		/// <summary>The underlying socket provider has not been initialized.</summary>
		// Token: 0x04000B35 RID: 2869
		NotInitialized,
		/// <summary>A graceful shutdown is in progress.</summary>
		// Token: 0x04000B36 RID: 2870
		Disconnecting = 10101,
		/// <summary>The specified class was not found.</summary>
		// Token: 0x04000B37 RID: 2871
		TypeNotFound = 10109,
		/// <summary>No such host is known. The name is not an official host name or alias.</summary>
		// Token: 0x04000B38 RID: 2872
		HostNotFound = 11001,
		/// <summary>The name of the host could not be resolved. Try again later.</summary>
		// Token: 0x04000B39 RID: 2873
		TryAgain,
		/// <summary>The error is unrecoverable or the requested database cannot be located.</summary>
		// Token: 0x04000B3A RID: 2874
		NoRecovery,
		/// <summary>The requested name or IP address was not found on the name server.</summary>
		// Token: 0x04000B3B RID: 2875
		NoData,
		/// <summary>The application has initiated an overlapped operation that cannot be completed immediately.</summary>
		// Token: 0x04000B3C RID: 2876
		IOPending = 997,
		/// <summary>The overlapped operation was aborted due to the closure of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04000B3D RID: 2877
		OperationAborted = 995
	}
}
