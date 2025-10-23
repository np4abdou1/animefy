using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an arithmetic, casting, or conversion operation in a checked context results in an overflow.</summary>
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public class OverflowException : ArithmeticException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class.</summary>
		// Token: 0x060007B6 RID: 1974 RVA: 0x00022F58 File Offset: 0x00021158
		public OverflowException() : base("Arithmetic operation resulted in an overflow.")
		{
			base.HResult = -2146233066;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x060007B7 RID: 1975 RVA: 0x00022F70 File Offset: 0x00021170
		public OverflowException(string message) : base(message)
		{
			base.HResult = -2146233066;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (<see langword="Nothing" /> in Visual Basic), the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x060007B8 RID: 1976 RVA: 0x00022F84 File Offset: 0x00021184
		public OverflowException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233066;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x060007B9 RID: 1977 RVA: 0x0001365E File Offset: 0x0001185E
		protected OverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
