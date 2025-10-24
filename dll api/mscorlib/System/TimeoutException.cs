using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when the time allotted for a process or operation has expired.</summary>
	// Token: 0x02000108 RID: 264
	[Serializable]
	public class TimeoutException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.TimeoutException" /> class.</summary>
		// Token: 0x06000985 RID: 2437 RVA: 0x00029CC0 File Offset: 0x00027EC0
		public TimeoutException() : base("The operation has timed out.")
		{
			base.HResult = -2146233083;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeoutException" /> class with the specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000986 RID: 2438 RVA: 0x00029CD8 File Offset: 0x00027ED8
		public TimeoutException(string message) : base(message)
		{
			base.HResult = -2146233083;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeoutException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination. The <paramref name="context" /> parameter is reserved for future use, and can be specified as <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is <see langword="null" />, or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
		// Token: 0x06000987 RID: 2439 RVA: 0x0000E339 File Offset: 0x0000C539
		protected TimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
