using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is insufficient execution stack available to allow most methods to execute.</summary>
	// Token: 0x020000C3 RID: 195
	[Serializable]
	public sealed class InsufficientExecutionStackException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.InsufficientExecutionStackException" /> class. </summary>
		// Token: 0x0600063F RID: 1599 RVA: 0x0001C24E File Offset: 0x0001A44E
		public InsufficientExecutionStackException() : base("Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.")
		{
			base.HResult = -2146232968;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000E339 File Offset: 0x0000C539
		internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
