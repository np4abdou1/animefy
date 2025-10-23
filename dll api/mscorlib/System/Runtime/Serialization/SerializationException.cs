using System;

namespace System.Runtime.Serialization
{
	/// <summary>The exception thrown when an error occurs during serialization or deserialization.</summary>
	// Token: 0x02000392 RID: 914
	[Serializable]
	public class SerializationException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class with default properties.</summary>
		// Token: 0x06001C72 RID: 7282 RVA: 0x00079104 File Offset: 0x00077304
		public SerializationException() : base(SerializationException.s_nullMessage)
		{
			base.HResult = -2146233076;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class with a specified message.</summary>
		/// <param name="message">Indicates the reason why the exception occurred. </param>
		// Token: 0x06001C73 RID: 7283 RVA: 0x0007911C File Offset: 0x0007731C
		public SerializationException(string message) : base(message)
		{
			base.HResult = -2146233076;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06001C74 RID: 7284 RVA: 0x00079130 File Offset: 0x00077330
		public SerializationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233076;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class from serialized data.</summary>
		/// <param name="info">The serialization information object holding the serialized object data in the name-value form. </param>
		/// <param name="context">The contextual information about the source or destination of the exception. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001C75 RID: 7285 RVA: 0x0000E339 File Offset: 0x0000C539
		protected SerializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000BEF RID: 3055
		private static string s_nullMessage = "Serialization error.";
	}
}
