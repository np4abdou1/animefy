using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an invoked method is not supported, or when there is an attempt to read, seek, or write to a stream that does not support the invoked functionality.</summary>
	// Token: 0x020000DC RID: 220
	[Serializable]
	public class NotSupportedException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error. This message takes into account the current system culture.</summary>
		// Token: 0x06000733 RID: 1843 RVA: 0x0001E06D File Offset: 0x0001C26D
		public NotSupportedException() : base("Specified method is not supported.")
		{
			base.HResult = -2146233067;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x06000734 RID: 1844 RVA: 0x0001E085 File Offset: 0x0001C285
		public NotSupportedException(string message) : base(message)
		{
			base.HResult = -2146233067;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000735 RID: 1845 RVA: 0x0001E099 File Offset: 0x0001C299
		public NotSupportedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233067;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000736 RID: 1846 RVA: 0x0000E339 File Offset: 0x0000C539
		protected NotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
