using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies the protocols that the <see cref="T:System.Net.Sockets.Socket" /> class supports.</summary>
	// Token: 0x0200020C RID: 524
	public enum ProtocolType
	{
		/// <summary>Internet Protocol.</summary>
		// Token: 0x04000AE6 RID: 2790
		IP,
		/// <summary>IPv6 Hop by Hop Options header.</summary>
		// Token: 0x04000AE7 RID: 2791
		IPv6HopByHopOptions = 0,
		/// <summary>Internet Control Message Protocol.</summary>
		// Token: 0x04000AE8 RID: 2792
		Icmp,
		/// <summary>Internet Group Management Protocol.</summary>
		// Token: 0x04000AE9 RID: 2793
		Igmp,
		/// <summary>Gateway To Gateway Protocol.</summary>
		// Token: 0x04000AEA RID: 2794
		Ggp,
		/// <summary>Internet Protocol version 4.</summary>
		// Token: 0x04000AEB RID: 2795
		IPv4,
		/// <summary>Transmission Control Protocol.</summary>
		// Token: 0x04000AEC RID: 2796
		Tcp = 6,
		/// <summary>PARC Universal Packet Protocol.</summary>
		// Token: 0x04000AED RID: 2797
		Pup = 12,
		/// <summary>User Datagram Protocol.</summary>
		// Token: 0x04000AEE RID: 2798
		Udp = 17,
		/// <summary>Internet Datagram Protocol.</summary>
		// Token: 0x04000AEF RID: 2799
		Idp = 22,
		/// <summary>Internet Protocol version 6 (IPv6). </summary>
		// Token: 0x04000AF0 RID: 2800
		IPv6 = 41,
		/// <summary>IPv6 Routing header.</summary>
		// Token: 0x04000AF1 RID: 2801
		IPv6RoutingHeader = 43,
		/// <summary>IPv6 Fragment header.</summary>
		// Token: 0x04000AF2 RID: 2802
		IPv6FragmentHeader,
		/// <summary>IPv6 Encapsulating Security Payload header.</summary>
		// Token: 0x04000AF3 RID: 2803
		IPSecEncapsulatingSecurityPayload = 50,
		/// <summary>IPv6 Authentication header. For details, see RFC 2292 section 2.2.1, available at http://www.ietf.org.</summary>
		// Token: 0x04000AF4 RID: 2804
		IPSecAuthenticationHeader,
		/// <summary>Internet Control Message Protocol for IPv6.</summary>
		// Token: 0x04000AF5 RID: 2805
		IcmpV6 = 58,
		/// <summary>IPv6 No next header.</summary>
		// Token: 0x04000AF6 RID: 2806
		IPv6NoNextHeader,
		/// <summary>IPv6 Destination Options header.</summary>
		// Token: 0x04000AF7 RID: 2807
		IPv6DestinationOptions,
		/// <summary>Net Disk Protocol (unofficial).</summary>
		// Token: 0x04000AF8 RID: 2808
		ND = 77,
		/// <summary>Raw IP packet protocol.</summary>
		// Token: 0x04000AF9 RID: 2809
		Raw = 255,
		/// <summary>Unspecified protocol.</summary>
		// Token: 0x04000AFA RID: 2810
		Unspecified = 0,
		/// <summary>Internet Packet Exchange Protocol.</summary>
		// Token: 0x04000AFB RID: 2811
		Ipx = 1000,
		/// <summary>Sequenced Packet Exchange protocol.</summary>
		// Token: 0x04000AFC RID: 2812
		Spx = 1256,
		/// <summary>Sequenced Packet Exchange version 2 protocol.</summary>
		// Token: 0x04000AFD RID: 2813
		SpxII,
		/// <summary>Unknown protocol.</summary>
		// Token: 0x04000AFE RID: 2814
		Unknown = -1
	}
}
