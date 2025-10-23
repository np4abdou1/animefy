using System;

namespace System.Threading
{
	/// <summary>Notifies a waiting thread that an event has occurred. This class cannot be inherited.</summary>
	// Token: 0x020001A4 RID: 420
	public sealed class AutoResetEvent : EventWaitHandle
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.AutoResetEvent" /> class with a Boolean value indicating whether to set the initial state to signaled.</summary>
		/// <param name="initialState">
		///       <see langword="true" /> to set the initial state to signaled; <see langword="false" /> to set the initial state to non-signaled. </param>
		// Token: 0x06001043 RID: 4163 RVA: 0x00044186 File Offset: 0x00042386
		public AutoResetEvent(bool initialState) : base(initialState, EventResetMode.AutoReset)
		{
		}
	}
}
