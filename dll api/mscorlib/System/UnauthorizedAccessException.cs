using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when the operating system denies access because of an I/O error or a specific type of security error.</summary>
	// Token: 0x02000115 RID: 277
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.UnauthorizedAccessException" /> class.</summary>
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002BA05 File Offset: 0x00029C05
		public UnauthorizedAccessException() : base("Attempted to perform an unauthorized operation.")
		{
			base.HResult = -2147024891;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UnauthorizedAccessException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002BA1D File Offset: 0x00029C1D
		public UnauthorizedAccessException(string message) : base(message)
		{
			base.HResult = -2147024891;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UnauthorizedAccessException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not a null reference (<see langword="Nothing" /> in Visual Basic), the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002BA31 File Offset: 0x00029C31
		public UnauthorizedAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147024891;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UnauthorizedAccessException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000E339 File Offset: 0x0000C539
		protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
