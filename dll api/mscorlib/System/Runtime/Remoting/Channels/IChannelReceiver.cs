using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Provides required functions and properties for the receiver channels.</summary>
	// Token: 0x02000347 RID: 839
	[ComVisible(true)]
	public interface IChannelReceiver : IChannel
	{
		/// <summary>Gets the channel-specific data.</summary>
		/// <returns>The channel data.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001AEB RID: 6891
		object ChannelData { get; }

		/// <summary>Instructs the current channel to start listening for requests.</summary>
		/// <param name="data">Optional initialization information. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001AEC RID: 6892
		void StartListening(object data);
	}
}
