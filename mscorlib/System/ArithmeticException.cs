﻿using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown for errors in an arithmetic, casting, or conversion operation.</summary>
	// Token: 0x0200007B RID: 123
	[Serializable]
	public class ArithmeticException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ArithmeticException" /> class.</summary>
		// Token: 0x06000293 RID: 659 RVA: 0x0000E9DD File Offset: 0x0000CBDD
		public ArithmeticException() : base("Overflow or underflow in the arithmetic operation.")
		{
			base.HResult = -2147024362;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArithmeticException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x06000294 RID: 660 RVA: 0x0000E9F5 File Offset: 0x0000CBF5
		public ArithmeticException(string message) : base(message)
		{
			base.HResult = -2147024362;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArithmeticException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000295 RID: 661 RVA: 0x0000EA09 File Offset: 0x0000CC09
		public ArithmeticException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024362;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArithmeticException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000296 RID: 662 RVA: 0x0000E339 File Offset: 0x0000C539
		protected ArithmeticException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
