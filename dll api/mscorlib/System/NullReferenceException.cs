using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to dereference a null object reference.</summary>
	// Token: 0x020000DD RID: 221
	[Serializable]
	public class NullReferenceException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.NullReferenceException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error, such as "The value 'null' was found where an instance of an object was required." This message takes into account the current system culture.</summary>
		// Token: 0x06000737 RID: 1847 RVA: 0x0001E0AE File Offset: 0x0001C2AE
		public NullReferenceException() : base("Object reference not set to an instance of an object.")
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NullReferenceException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x06000738 RID: 1848 RVA: 0x0001E0C6 File Offset: 0x0001C2C6
		public NullReferenceException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NullReferenceException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000739 RID: 1849 RVA: 0x0001E0DA File Offset: 0x0001C2DA
		public NullReferenceException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NullReferenceException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x0600073A RID: 1850 RVA: 0x0000E339 File Offset: 0x0000C539
		protected NullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
