using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Contributes an interception sink at the context boundary on the client end of a remoting call.</summary>
	// Token: 0x02000335 RID: 821
	[ComVisible(true)]
	public interface IContributeClientContextSink
	{
		/// <summary>Takes the first sink in the chain of sinks composed so far, and then chains its message sink in front of the chain already formed.</summary>
		/// <param name="nextSink">The chain of sinks composed so far. </param>
		/// <returns>The composite sink chain.</returns>
		// Token: 0x06001AA7 RID: 6823
		IMessageSink GetClientContextSink(IMessageSink nextSink);
	}
}
