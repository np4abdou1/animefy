using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Contributes an interception sink at the context boundary on the server end of a remoting call.</summary>
	// Token: 0x02000338 RID: 824
	[ComVisible(true)]
	public interface IContributeServerContextSink
	{
		/// <summary>Takes the first sink in the chain of sinks composed so far, and then chains its message sink in front of the chain already formed.</summary>
		/// <param name="nextSink">The chain of sinks composed so far. </param>
		/// <returns>The composite sink chain.</returns>
		// Token: 0x06001AAA RID: 6826
		IMessageSink GetServerContextSink(IMessageSink nextSink);
	}
}
