﻿using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Serves as the base class for application-defined exceptions.</summary>
	// Token: 0x02000077 RID: 119
	[Serializable]
	public class ApplicationException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class.</summary>
		// Token: 0x0600027B RID: 635 RVA: 0x0000E741 File Offset: 0x0000C941
		public ApplicationException() : base("Error in the application.")
		{
			base.HResult = -2146232832;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class with a specified error message.</summary>
		/// <param name="message">A message that describes the error. </param>
		// Token: 0x0600027C RID: 636 RVA: 0x0000E759 File Offset: 0x0000C959
		public ApplicationException(string message) : base(message)
		{
			base.HResult = -2146232832;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x0600027D RID: 637 RVA: 0x0000E76D File Offset: 0x0000C96D
		public ApplicationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232832;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ApplicationException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x0600027E RID: 638 RVA: 0x0000E782 File Offset: 0x0000C982
		protected ApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
