using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	/// <summary>Provides envoy information.</summary>
	// Token: 0x02000304 RID: 772
	[ComVisible(true)]
	public interface IEnvoyInfo
	{
		/// <summary>Gets or sets the list of envoys that were contributed by the server context and object chains when the object was marshaled.</summary>
		/// <returns>A chain of envoy sinks.</returns>
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600195D RID: 6493
		IMessageSink EnvoySinks { get; }
	}
}
