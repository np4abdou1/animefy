using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The exception thrown when an invalid COM object is used.</summary>
	// Token: 0x02000400 RID: 1024
	[Serializable]
	public class InvalidComObjectException : SystemException
	{
		/// <summary>Initializes an instance of the <see langword="InvalidComObjectException" /> with default properties.</summary>
		// Token: 0x06001F38 RID: 7992 RVA: 0x00086667 File Offset: 0x00084867
		public InvalidComObjectException() : base("Attempt has been made to use a COM object that does not have a backing class factory.")
		{
			base.HResult = -2146233049;
		}

		/// <summary>Initializes an instance of the <see langword="InvalidComObjectException" /> with a message.</summary>
		/// <param name="message">The message that indicates the reason for the exception. </param>
		// Token: 0x06001F39 RID: 7993 RVA: 0x0008667F File Offset: 0x0008487F
		public InvalidComObjectException(string message) : base(message)
		{
			base.HResult = -2146233049;
		}

		/// <summary>Initializes a new instance of the <see langword="COMException" /> class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001F3A RID: 7994 RVA: 0x0000E339 File Offset: 0x0000C539
		protected InvalidComObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
