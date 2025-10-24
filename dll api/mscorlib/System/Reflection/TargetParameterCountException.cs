using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown when the number of parameters for an invocation does not match the number expected. This class cannot be inherited.</summary>
	// Token: 0x020004C1 RID: 1217
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetParameterCountException" /> class with an empty message string and the root cause of the exception.</summary>
		// Token: 0x06002255 RID: 8789 RVA: 0x0008B042 File Offset: 0x00089242
		public TargetParameterCountException() : base("Number of parameters specified does not match the expected number.")
		{
			base.HResult = -2147352562;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetParameterCountException" /> class with its message string set to the given message and the root cause exception.</summary>
		/// <param name="message">A <see langword="String" /> describing the reason this exception was thrown. </param>
		// Token: 0x06002256 RID: 8790 RVA: 0x0008B05A File Offset: 0x0008925A
		public TargetParameterCountException(string message) : base(message)
		{
			base.HResult = -2147352562;
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0004439A File Offset: 0x0004259A
		internal TargetParameterCountException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
