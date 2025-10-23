using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Creates server channel sinks for the server channel through which remoting messages flow.</summary>
	// Token: 0x0200034B RID: 843
	[ComVisible(true)]
	public interface IServerChannelSinkProvider
	{
		/// <summary>Gets or sets the next sink provider in the channel sink provider chain.</summary>
		/// <returns>The next sink provider in the channel sink provider chain.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x17000303 RID: 771
		// (set) Token: 0x06001AF0 RID: 6896
		IServerChannelSinkProvider Next { set; }
	}
}
