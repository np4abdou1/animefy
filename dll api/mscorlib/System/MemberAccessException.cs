using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt to access a class member fails.</summary>
	// Token: 0x020000D1 RID: 209
	[Serializable]
	public class MemberAccessException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class.</summary>
		// Token: 0x060006F8 RID: 1784 RVA: 0x0001D2F7 File Offset: 0x0001B4F7
		public MemberAccessException() : base("Cannot access member.")
		{
			base.HResult = -2146233062;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x060006F9 RID: 1785 RVA: 0x0001D30F File Offset: 0x0001B50F
		public MemberAccessException(string message) : base(message)
		{
			base.HResult = -2146233062;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not a null reference (<see langword="Nothing" /> in Visual Basic), the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x060006FA RID: 1786 RVA: 0x0001D323 File Offset: 0x0001B523
		public MemberAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233062;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x060006FB RID: 1787 RVA: 0x0000E339 File Offset: 0x0000C539
		protected MemberAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
