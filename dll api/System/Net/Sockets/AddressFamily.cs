using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies the addressing scheme that an instance of the <see cref="T:System.Net.Sockets.Socket" /> class can use.</summary>
	// Token: 0x02000207 RID: 519
	public enum AddressFamily
	{
		/// <summary>Unknown address family.</summary>
		// Token: 0x04000A99 RID: 2713
		Unknown = -1,
		/// <summary>Unspecified address family.</summary>
		// Token: 0x04000A9A RID: 2714
		Unspecified,
		/// <summary>Unix local to host address.</summary>
		// Token: 0x04000A9B RID: 2715
		Unix,
		/// <summary>Address for IP version 4.</summary>
		// Token: 0x04000A9C RID: 2716
		InterNetwork,
		/// <summary>ARPANET IMP address.</summary>
		// Token: 0x04000A9D RID: 2717
		ImpLink,
		/// <summary>Address for PUP protocols.</summary>
		// Token: 0x04000A9E RID: 2718
		Pup,
		/// <summary>Address for MIT CHAOS protocols.</summary>
		// Token: 0x04000A9F RID: 2719
		Chaos,
		/// <summary>Address for Xerox NS protocols.</summary>
		// Token: 0x04000AA0 RID: 2720
		NS,
		/// <summary>IPX or SPX address.</summary>
		// Token: 0x04000AA1 RID: 2721
		Ipx = 6,
		/// <summary>Address for ISO protocols.</summary>
		// Token: 0x04000AA2 RID: 2722
		Iso,
		/// <summary>Address for OSI protocols.</summary>
		// Token: 0x04000AA3 RID: 2723
		Osi = 7,
		/// <summary>European Computer Manufacturers Association (ECMA) address.</summary>
		// Token: 0x04000AA4 RID: 2724
		Ecma,
		/// <summary>Address for Datakit protocols.</summary>
		// Token: 0x04000AA5 RID: 2725
		DataKit,
		/// <summary>Addresses for CCITT protocols, such as X.25.</summary>
		// Token: 0x04000AA6 RID: 2726
		Ccitt,
		/// <summary>IBM SNA address.</summary>
		// Token: 0x04000AA7 RID: 2727
		Sna,
		/// <summary>DECnet address.</summary>
		// Token: 0x04000AA8 RID: 2728
		DecNet,
		/// <summary>Direct data-link interface address.</summary>
		// Token: 0x04000AA9 RID: 2729
		DataLink,
		/// <summary>LAT address.</summary>
		// Token: 0x04000AAA RID: 2730
		Lat,
		/// <summary>NSC Hyperchannel address.</summary>
		// Token: 0x04000AAB RID: 2731
		HyperChannel,
		/// <summary>AppleTalk address.</summary>
		// Token: 0x04000AAC RID: 2732
		AppleTalk,
		/// <summary>NetBios address.</summary>
		// Token: 0x04000AAD RID: 2733
		NetBios,
		/// <summary>VoiceView address.</summary>
		// Token: 0x04000AAE RID: 2734
		VoiceView,
		/// <summary>FireFox address.</summary>
		// Token: 0x04000AAF RID: 2735
		FireFox,
		/// <summary>Banyan address.</summary>
		// Token: 0x04000AB0 RID: 2736
		Banyan = 21,
		/// <summary>Native ATM services address.</summary>
		// Token: 0x04000AB1 RID: 2737
		Atm,
		/// <summary>Address for IP version 6.</summary>
		// Token: 0x04000AB2 RID: 2738
		InterNetworkV6,
		/// <summary>Address for Microsoft cluster products.</summary>
		// Token: 0x04000AB3 RID: 2739
		Cluster,
		/// <summary>IEEE 1284.4 workgroup address.</summary>
		// Token: 0x04000AB4 RID: 2740
		Ieee12844,
		/// <summary>IrDA address.</summary>
		// Token: 0x04000AB5 RID: 2741
		Irda,
		/// <summary>Address for Network Designers OSI gateway-enabled protocols.</summary>
		// Token: 0x04000AB6 RID: 2742
		NetworkDesigners = 28,
		/// <summary>MAX address.</summary>
		// Token: 0x04000AB7 RID: 2743
		Max
	}
}
