using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Contains communication data sent between cooperating message sinks.</summary>
	// Token: 0x02000374 RID: 884
	[ComVisible(true)]
	public interface IMessage
	{
		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> that represents a collection of the message's properties.</summary>
		/// <returns>A dictionary that represents a collection of the message's properties.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001BB2 RID: 7090
		IDictionary Properties { get; }
	}
}
