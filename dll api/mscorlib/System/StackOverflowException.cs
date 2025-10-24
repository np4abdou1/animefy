using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when the execution stack overflows because it contains too many nested method calls. This class cannot be inherited.</summary>
	// Token: 0x020000F7 RID: 247
	[Serializable]
	public sealed class StackOverflowException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.StackOverflowException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error, such as "The requested operation caused a stack overflow." This message takes into account the current system culture.</summary>
		// Token: 0x06000869 RID: 2153 RVA: 0x00025E93 File Offset: 0x00024093
		public StackOverflowException() : base("Operation caused a stack overflow.")
		{
			base.HResult = -2147023895;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.StackOverflowException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of message is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x0600086A RID: 2154 RVA: 0x00025EAB File Offset: 0x000240AB
		public StackOverflowException(string message) : base(message)
		{
			base.HResult = -2147023895;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000E339 File Offset: 0x0000C539
		internal StackOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
