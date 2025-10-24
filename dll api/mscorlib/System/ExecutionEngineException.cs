using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an internal error in the execution engine of the common language runtime. This class cannot be inherited.  </summary>
	// Token: 0x0200009B RID: 155
	[Serializable]
	public sealed class ExecutionEngineException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ExecutionEngineException" /> class.</summary>
		// Token: 0x0600053F RID: 1343 RVA: 0x00013ABD File Offset: 0x00011CBD
		public ExecutionEngineException() : base("Internal error in the runtime.")
		{
			base.HResult = -2146233082;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ExecutionEngineException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000540 RID: 1344 RVA: 0x00013AD5 File Offset: 0x00011CD5
		public ExecutionEngineException(string message) : base(message)
		{
			base.HResult = -2146233082;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000E339 File Offset: 0x0000C539
		internal ExecutionEngineException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
