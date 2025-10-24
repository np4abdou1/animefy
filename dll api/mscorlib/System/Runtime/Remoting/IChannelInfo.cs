using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Provides custom channel information that is carried along with the <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
	// Token: 0x02000303 RID: 771
	[ComVisible(true)]
	public interface IChannelInfo
	{
		/// <summary>Gets and sets the channel data for each channel.</summary>
		/// <returns>The channel data for each channel.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600195C RID: 6492
		object[] ChannelData { get; }
	}
}
