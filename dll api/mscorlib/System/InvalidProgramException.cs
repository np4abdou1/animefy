using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a program contains invalid Microsoft intermediate language (MSIL) or metadata. Generally this indicates a bug in the compiler that generated the program.</summary>
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public sealed class InvalidProgramException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidProgramException" /> class with default properties.</summary>
		// Token: 0x060006A6 RID: 1702 RVA: 0x0001C9EF File Offset: 0x0001ABEF
		public InvalidProgramException() : base("Common Language Runtime detected an invalid program.")
		{
			base.HResult = -2146233030;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidProgramException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x060006A7 RID: 1703 RVA: 0x0001CA07 File Offset: 0x0001AC07
		public InvalidProgramException(string message) : base(message)
		{
			base.HResult = -2146233030;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000E339 File Offset: 0x0000C539
		internal InvalidProgramException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
