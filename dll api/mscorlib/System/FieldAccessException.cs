using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an invalid attempt to access a private or protected field inside a class.</summary>
	// Token: 0x0200009C RID: 156
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.FieldAccessException" /> class.</summary>
		// Token: 0x06000542 RID: 1346 RVA: 0x00013AE9 File Offset: 0x00011CE9
		public FieldAccessException() : base("Attempted to access a field that is not accessible by the caller.")
		{
			base.HResult = -2146233081;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.FieldAccessException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		// Token: 0x06000543 RID: 1347 RVA: 0x00013B01 File Offset: 0x00011D01
		public FieldAccessException(string message) : base(message)
		{
			base.HResult = -2146233081;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.FieldAccessException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000544 RID: 1348 RVA: 0x00013B15 File Offset: 0x00011D15
		protected FieldAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
