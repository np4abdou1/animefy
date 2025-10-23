using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when a <see cref="T:System.Threading.Thread" /> is in an invalid <see cref="P:System.Threading.Thread.ThreadState" /> for the method call.</summary>
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class ThreadStateException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ThreadStateException" /> class with default properties.</summary>
		// Token: 0x06001060 RID: 4192 RVA: 0x00044331 File Offset: 0x00042531
		public ThreadStateException() : base("Thread was in an invalid state for the operation being executed.")
		{
			base.HResult = -2146233056;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ThreadStateException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06001061 RID: 4193 RVA: 0x00044349 File Offset: 0x00042549
		public ThreadStateException(string message) : base(message)
		{
			base.HResult = -2146233056;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ThreadStateException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06001062 RID: 4194 RVA: 0x0000E339 File Offset: 0x0000C539
		protected ThreadStateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
