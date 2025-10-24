using System;

namespace System.Net.Sockets
{
	/// <summary>Defines configuration option names.</summary>
	// Token: 0x02000212 RID: 530
	public enum SocketOptionName
	{
		/// <summary>Record debugging information.</summary>
		// Token: 0x04000B50 RID: 2896
		Debug = 1,
		/// <summary>The socket is listening.</summary>
		// Token: 0x04000B51 RID: 2897
		AcceptConnection,
		/// <summary>Allows the socket to be bound to an address that is already in use.</summary>
		// Token: 0x04000B52 RID: 2898
		ReuseAddress = 4,
		/// <summary>Use keep-alives.</summary>
		// Token: 0x04000B53 RID: 2899
		KeepAlive = 8,
		/// <summary>Do not route; send the packet directly to the interface addresses.</summary>
		// Token: 0x04000B54 RID: 2900
		DontRoute = 16,
		/// <summary>Permit sending broadcast messages on the socket.</summary>
		// Token: 0x04000B55 RID: 2901
		Broadcast = 32,
		/// <summary>Bypass hardware when possible.</summary>
		// Token: 0x04000B56 RID: 2902
		UseLoopback = 64,
		/// <summary>Linger on close if unsent data is present.</summary>
		// Token: 0x04000B57 RID: 2903
		Linger = 128,
		/// <summary>Receives out-of-band data in the normal data stream.</summary>
		// Token: 0x04000B58 RID: 2904
		OutOfBandInline = 256,
		/// <summary>Close the socket gracefully without lingering.</summary>
		// Token: 0x04000B59 RID: 2905
		DontLinger = -129,
		/// <summary>Enables a socket to be bound for exclusive access.</summary>
		// Token: 0x04000B5A RID: 2906
		ExclusiveAddressUse = -5,
		/// <summary>Specifies the total per-socket buffer space reserved for sends. This is unrelated to the maximum message size or the size of a TCP window.</summary>
		// Token: 0x04000B5B RID: 2907
		SendBuffer = 4097,
		/// <summary>Specifies the total per-socket buffer space reserved for receives. This is unrelated to the maximum message size or the size of a TCP window.</summary>
		// Token: 0x04000B5C RID: 2908
		ReceiveBuffer,
		/// <summary>Specifies the low water mark for <see cref="Overload:System.Net.Sockets.Socket.Send" /> operations.</summary>
		// Token: 0x04000B5D RID: 2909
		SendLowWater,
		/// <summary>Specifies the low water mark for <see cref="Overload:System.Net.Sockets.Socket.Receive" /> operations.</summary>
		// Token: 0x04000B5E RID: 2910
		ReceiveLowWater,
		/// <summary>Send a time-out. This option applies only to synchronous methods; it has no effect on asynchronous methods such as the <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method.</summary>
		// Token: 0x04000B5F RID: 2911
		SendTimeout,
		/// <summary>Receive a time-out. This option applies only to synchronous methods; it has no effect on asynchronous methods such as the <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method.</summary>
		// Token: 0x04000B60 RID: 2912
		ReceiveTimeout,
		/// <summary>Get the error status and clear.</summary>
		// Token: 0x04000B61 RID: 2913
		Error,
		/// <summary>Get the socket type.</summary>
		// Token: 0x04000B62 RID: 2914
		Type,
		/// <summary>Indicates that the system should defer ephemeral port allocation for outbound connections. This is equivalent to using the Winsock2 SO_REUSE_UNICASTPORT socket option.</summary>
		// Token: 0x04000B63 RID: 2915
		ReuseUnicastPort = 12295,
		/// <summary>Not supported; will throw a <see cref="T:System.Net.Sockets.SocketException" /> if used.</summary>
		// Token: 0x04000B64 RID: 2916
		MaxConnections = 2147483647,
		/// <summary>Specifies the IP options to be inserted into outgoing datagrams.</summary>
		// Token: 0x04000B65 RID: 2917
		IPOptions = 1,
		/// <summary>Indicates that the application provides the IP header for outgoing datagrams.</summary>
		// Token: 0x04000B66 RID: 2918
		HeaderIncluded,
		/// <summary>Change the IP header type of the service field.</summary>
		// Token: 0x04000B67 RID: 2919
		TypeOfService,
		/// <summary>Set the IP header Time-to-Live field.</summary>
		// Token: 0x04000B68 RID: 2920
		IpTimeToLive,
		/// <summary>Set the interface for outgoing multicast packets.</summary>
		// Token: 0x04000B69 RID: 2921
		MulticastInterface = 9,
		/// <summary>An IP multicast Time to Live.</summary>
		// Token: 0x04000B6A RID: 2922
		MulticastTimeToLive,
		/// <summary>An IP multicast loopback.</summary>
		// Token: 0x04000B6B RID: 2923
		MulticastLoopback,
		/// <summary>Add an IP group membership.</summary>
		// Token: 0x04000B6C RID: 2924
		AddMembership,
		/// <summary>Drop an IP group membership.</summary>
		// Token: 0x04000B6D RID: 2925
		DropMembership,
		/// <summary>Do not fragment IP datagrams.</summary>
		// Token: 0x04000B6E RID: 2926
		DontFragment,
		/// <summary>Join a source group.</summary>
		// Token: 0x04000B6F RID: 2927
		AddSourceMembership,
		/// <summary>Drop a source group.</summary>
		// Token: 0x04000B70 RID: 2928
		DropSourceMembership,
		/// <summary>Block data from a source.</summary>
		// Token: 0x04000B71 RID: 2929
		BlockSource,
		/// <summary>Unblock a previously blocked source.</summary>
		// Token: 0x04000B72 RID: 2930
		UnblockSource,
		/// <summary>Return information about received packets.</summary>
		// Token: 0x04000B73 RID: 2931
		PacketInformation,
		/// <summary>Specifies the maximum number of router hops for an Internet Protocol version 6 (IPv6) packet. This is similar to Time to Live (TTL) for Internet Protocol version 4.</summary>
		// Token: 0x04000B74 RID: 2932
		HopLimit = 21,
		/// <summary>Enables restriction of a IPv6 socket to a specified scope, such as addresses with the same link local or site local prefix.This socket option enables applications to place access restrictions on IPv6 sockets. Such restrictions enable an application running on a private LAN to simply and robustly harden itself against external attacks. This socket option widens or narrows the scope of a listening socket, enabling unrestricted access from public and private users when appropriate, or restricting access only to the same site, as required. This socket option has defined protection levels specified in the <see cref="T:System.Net.Sockets.IPProtectionLevel" /> enumeration.</summary>
		// Token: 0x04000B75 RID: 2933
		IPProtectionLevel = 23,
		/// <summary>Indicates if a socket created for the AF_INET6 address family is restricted to IPv6 communications only. Sockets created for the AF_INET6 address family may be used for both IPv6 and IPv4 communications. Some applications may want to restrict their use of a socket created for the AF_INET6 address family to IPv6 communications only. When this value is non-zero (the default on Windows), a socket created for the AF_INET6 address family can be used to send and receive IPv6 packets only. When this value is zero, a socket created for the AF_INET6 address family can be used to send and receive packets to and from an IPv6 address or an IPv4 address. Note that the ability to interact with an IPv4 address requires the use of IPv4 mapped addresses. This socket option is supported on Windows Vista or later.</summary>
		// Token: 0x04000B76 RID: 2934
		IPv6Only = 27,
		/// <summary>Disables the Nagle algorithm for send coalescing.</summary>
		// Token: 0x04000B77 RID: 2935
		NoDelay = 1,
		/// <summary>Use urgent data as defined in RFC-1222. This option can be set only once; after it is set, it cannot be turned off.</summary>
		// Token: 0x04000B78 RID: 2936
		BsdUrgent,
		/// <summary>Use expedited data as defined in RFC-1222. This option can be set only once; after it is set, it cannot be turned off.</summary>
		// Token: 0x04000B79 RID: 2937
		Expedited = 2,
		/// <summary>Send UDP datagrams with checksum set to zero.</summary>
		// Token: 0x04000B7A RID: 2938
		NoChecksum = 1,
		/// <summary>Set or get the UDP checksum coverage.</summary>
		// Token: 0x04000B7B RID: 2939
		ChecksumCoverage = 20,
		/// <summary>Updates an accepted socket's properties by using those of an existing socket. This is equivalent to using the Winsock2 SO_UPDATE_ACCEPT_CONTEXT socket option and is supported only on connection-oriented sockets.</summary>
		// Token: 0x04000B7C RID: 2940
		UpdateAcceptContext = 28683,
		/// <summary>Updates a connected socket's properties by using those of an existing socket. This is equivalent to using the Winsock2 SO_UPDATE_CONNECT_CONTEXT socket option and is supported only on connection-oriented sockets.</summary>
		// Token: 0x04000B7D RID: 2941
		UpdateConnectContext = 28688
	}
}
