using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies socket send and receive behaviors.</summary>
	// Token: 0x02000210 RID: 528
	[Flags]
	public enum SocketFlags
	{
		/// <summary>Use no flags for this call.</summary>
		// Token: 0x04000B3F RID: 2879
		None = 0,
		/// <summary>Process out-of-band data.</summary>
		// Token: 0x04000B40 RID: 2880
		OutOfBand = 1,
		/// <summary>Peek at the incoming message.</summary>
		// Token: 0x04000B41 RID: 2881
		Peek = 2,
		/// <summary>Send without using routing tables.</summary>
		// Token: 0x04000B42 RID: 2882
		DontRoute = 4,
		/// <summary>Provides a standard value for the number of WSABUF structures that are used to send and receive data. This value is not used or supported on .NET Framework 4.5.</summary>
		// Token: 0x04000B43 RID: 2883
		MaxIOVectorLength = 16,
		/// <summary>The message was too large to fit into the specified buffer and was truncated.</summary>
		// Token: 0x04000B44 RID: 2884
		Truncated = 256,
		/// <summary>Indicates that the control data did not fit into an internal 64-KB buffer and was truncated.</summary>
		// Token: 0x04000B45 RID: 2885
		ControlDataTruncated = 512,
		/// <summary>Indicates a broadcast packet.</summary>
		// Token: 0x04000B46 RID: 2886
		Broadcast = 1024,
		/// <summary>Indicates a multicast packet.</summary>
		// Token: 0x04000B47 RID: 2887
		Multicast = 2048,
		/// <summary>Partial send or receive for message.</summary>
		// Token: 0x04000B48 RID: 2888
		Partial = 32768
	}
}
