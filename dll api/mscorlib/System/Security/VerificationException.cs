using System;
using System.Runtime.Serialization;

namespace System.Security
{
	/// <summary>The exception that is thrown when the security policy requires code to be type safe and the verification process is unable to verify that the code is type safe.</summary>
	// Token: 0x02000276 RID: 630
	[Serializable]
	public class VerificationException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.VerificationException" /> class with default properties.</summary>
		// Token: 0x06001635 RID: 5685 RVA: 0x0005B158 File Offset: 0x00059358
		public VerificationException() : base("Operation could destabilize the runtime.")
		{
			base.HResult = -2146233075;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.VerificationException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06001636 RID: 5686 RVA: 0x0000E339 File Offset: 0x0000C539
		protected VerificationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
