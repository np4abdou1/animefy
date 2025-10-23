using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when an attempt is made to open a system mutex, semaphore, or event wait handle that does not exist.</summary>
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public class WaitHandleCannotBeOpenedException : ApplicationException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> class with default values.</summary>
		// Token: 0x06001064 RID: 4196 RVA: 0x0004436E File Offset: 0x0004256E
		public WaitHandleCannotBeOpenedException() : base("No handle of the given name exists.")
		{
			base.HResult = -2146233044;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		// Token: 0x06001065 RID: 4197 RVA: 0x00044386 File Offset: 0x00042586
		public WaitHandleCannotBeOpenedException(string message) : base(message)
		{
			base.HResult = -2146233044;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
		// Token: 0x06001066 RID: 4198 RVA: 0x0004439A File Offset: 0x0004259A
		protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
