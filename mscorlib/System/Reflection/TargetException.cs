﻿using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Represents the exception that is thrown when an attempt is made to invoke an invalid target.</summary>
	// Token: 0x020004BF RID: 1215
	[Serializable]
	public class TargetException : ApplicationException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with an empty message and the root cause of the exception.</summary>
		// Token: 0x0600224E RID: 8782 RVA: 0x0008AFEC File Offset: 0x000891EC
		public TargetException() : this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with the given message and the root cause exception.</summary>
		/// <param name="message">A <see langword="String" /> describing the reason why the exception occurred. </param>
		// Token: 0x0600224F RID: 8783 RVA: 0x0008AFF5 File Offset: 0x000891F5
		public TargetException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06002250 RID: 8784 RVA: 0x0008AFFF File Offset: 0x000891FF
		public TargetException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232829;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">The data for serializing or deserializing the object. </param>
		/// <param name="context">The source of and destination for the object. </param>
		// Token: 0x06002251 RID: 8785 RVA: 0x0004439A File Offset: 0x0004259A
		protected TargetException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
