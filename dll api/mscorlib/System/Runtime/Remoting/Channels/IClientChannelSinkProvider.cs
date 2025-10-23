using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Creates client channel sinks for the client channel through which remoting messages flow.</summary>
	// Token: 0x02000349 RID: 841
	[ComVisible(true)]
	public interface IClientChannelSinkProvider
	{
		/// <summary>Gets or sets the next sink provider in the channel sink provider chain.</summary>
		/// <returns>The next sink provider in the channel sink provider chain.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x17000301 RID: 769
		// (set) Token: 0x06001AEE RID: 6894
		IClientChannelSinkProvider Next { set; }
	}
}
