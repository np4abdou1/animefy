using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Represents a callback method to be executed by a thread pool thread.</summary>
	/// <param name="state">An object containing information to be used by the callback method. </param>
	// Token: 0x020001E2 RID: 482
	// (Invoke) Token: 0x060011AA RID: 4522
	[ComVisible(true)]
	public delegate void WaitCallback(object state);
}
