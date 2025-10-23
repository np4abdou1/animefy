using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown for invalid casting or explicit conversion.</summary>
	// Token: 0x020000C7 RID: 199
	[Serializable]
	public class InvalidCastException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class.</summary>
		// Token: 0x0600069E RID: 1694 RVA: 0x0001C96D File Offset: 0x0001AB6D
		public InvalidCastException() : base("Specified cast is not valid.")
		{
			base.HResult = -2147467262;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x0600069F RID: 1695 RVA: 0x0001C985 File Offset: 0x0001AB85
		public InvalidCastException(string message) : base(message)
		{
			base.HResult = -2147467262;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x060006A0 RID: 1696 RVA: 0x0001C999 File Offset: 0x0001AB99
		public InvalidCastException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467262;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x060006A1 RID: 1697 RVA: 0x0000E339 File Offset: 0x0000C539
		protected InvalidCastException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
