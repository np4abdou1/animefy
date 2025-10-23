using System;

namespace System.Threading
{
	/// <summary>Represents a method to be called when a message is to be dispatched to a synchronization context.  </summary>
	/// <param name="state">The object passed to the delegate.</param>
	// Token: 0x020001AC RID: 428
	// (Invoke) Token: 0x06001056 RID: 4182
	public delegate void SendOrPostCallback(object state);
}
