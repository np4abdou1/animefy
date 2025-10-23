using System;

namespace System
{
	/// <summary>References a method to be called when a corresponding asynchronous operation completes.</summary>
	/// <param name="ar">The result of the asynchronous operation. </param>
	// Token: 0x02000081 RID: 129
	// (Invoke) Token: 0x060002BF RID: 703
	[Serializable]
	public delegate void AsyncCallback(IAsyncResult ar);
}
