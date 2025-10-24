﻿using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown in <see cref="M:System.Type.FindMembers(System.Reflection.MemberTypes,System.Reflection.BindingFlags,System.Reflection.MemberFilter,System.Object)" /> when the filter criteria is not valid for the type of filter you are using.</summary>
	// Token: 0x020004A4 RID: 1188
	[Serializable]
	public class InvalidFilterCriteriaException : ApplicationException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with the default properties.</summary>
		// Token: 0x06002122 RID: 8482 RVA: 0x00089FF0 File Offset: 0x000881F0
		public InvalidFilterCriteriaException() : this("Specified filter criteria was invalid.")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with the given HRESULT and message string.</summary>
		/// <param name="message">The message text for the exception. </param>
		// Token: 0x06002123 RID: 8483 RVA: 0x00089FFD File Offset: 0x000881FD
		public InvalidFilterCriteriaException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06002124 RID: 8484 RVA: 0x0008A007 File Offset: 0x00088207
		public InvalidFilterCriteriaException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232831;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">A <see langword="SerializationInfo" /> object that contains the information required to serialize this instance. </param>
		/// <param name="context">A <see langword="StreamingContext" /> object that contains the source and destination of the serialized stream associated with this instance. </param>
		// Token: 0x06002125 RID: 8485 RVA: 0x0004439A File Offset: 0x0004259A
		protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
