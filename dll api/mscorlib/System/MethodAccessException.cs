using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an invalid attempt to access a method, such as accessing a private method from partially trusted code.</summary>
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public class MethodAccessException : MemberAccessException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.MethodAccessException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error, such as "Attempt to access the method failed." This message takes into account the current system culture.</summary>
		// Token: 0x06000720 RID: 1824 RVA: 0x0001DEB9 File Offset: 0x0001C0B9
		public MethodAccessException() : base("Attempt to access the method failed.")
		{
			base.HResult = -2146233072;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MethodAccessException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x06000721 RID: 1825 RVA: 0x0001DED1 File Offset: 0x0001C0D1
		public MethodAccessException(string message) : base(message)
		{
			base.HResult = -2146233072;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MethodAccessException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000722 RID: 1826 RVA: 0x00013B15 File Offset: 0x00011D15
		protected MethodAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
