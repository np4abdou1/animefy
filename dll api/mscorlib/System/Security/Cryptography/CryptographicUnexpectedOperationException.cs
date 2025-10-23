using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography
{
	/// <summary>The exception that is thrown when an unexpected operation occurs during a cryptographic operation.</summary>
	// Token: 0x020002AB RID: 683
	[ComVisible(true)]
	[Serializable]
	public class CryptographicUnexpectedOperationException : CryptographicException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> class with default properties.</summary>
		// Token: 0x06001725 RID: 5925 RVA: 0x0005F849 File Offset: 0x0005DA49
		public CryptographicUnexpectedOperationException()
		{
			base.SetErrorCode(-2146233295);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06001726 RID: 5926 RVA: 0x0005F85C File Offset: 0x0005DA5C
		public CryptographicUnexpectedOperationException(string message) : base(message)
		{
			base.SetErrorCode(-2146233295);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06001727 RID: 5927 RVA: 0x0005F870 File Offset: 0x0005DA70
		protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
