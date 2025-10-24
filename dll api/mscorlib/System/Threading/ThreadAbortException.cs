using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when a call is made to the <see cref="M:System.Threading.Thread.Abort(System.Object)" /> method. This class cannot be inherited.</summary>
	// Token: 0x020001DF RID: 479
	[ComVisible(true)]
	[Serializable]
	public sealed class ThreadAbortException : SystemException
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x00047ED9 File Offset: 0x000460D9
		private ThreadAbortException() : base(Exception.GetMessageFromNativeResources(Exception.ExceptionMessageKind.ThreadAbort))
		{
			base.SetErrorCode(-2146233040);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0000E339 File Offset: 0x0000C539
		internal ThreadAbortException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
