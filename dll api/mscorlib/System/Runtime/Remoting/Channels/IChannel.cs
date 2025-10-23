using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Provides conduits for messages that cross remoting boundaries.</summary>
	// Token: 0x02000345 RID: 837
	[ComVisible(true)]
	public interface IChannel
	{
		/// <summary>Gets the name of the channel.</summary>
		/// <returns>The name of the channel.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001AE9 RID: 6889
		string ChannelName { get; }

		/// <summary>Gets the priority of the channel.</summary>
		/// <returns>An integer that indicates the priority of the channel.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001AEA RID: 6890
		int ChannelPriority { get; }
	}
}
