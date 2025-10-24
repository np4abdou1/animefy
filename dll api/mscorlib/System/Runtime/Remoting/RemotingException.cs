using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	/// <summary>The exception that is thrown when something has gone wrong during remoting.</summary>
	// Token: 0x0200030F RID: 783
	[ComVisible(true)]
	[Serializable]
	public class RemotingException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class with default properties.</summary>
		// Token: 0x060019B9 RID: 6585 RVA: 0x0005B170 File Offset: 0x00059370
		public RemotingException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class with a specified message.</summary>
		/// <param name="message">The error message that explains why the exception occurred. </param>
		// Token: 0x060019BA RID: 6586 RVA: 0x000708A3 File Offset: 0x0006EAA3
		public RemotingException(string message) : base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class from serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination of the exception. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />. </exception>
		// Token: 0x060019BB RID: 6587 RVA: 0x0000E339 File Offset: 0x0000C539
		protected RemotingException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains why the exception occurred. </param>
		/// <param name="InnerException">The exception that is the cause of the current exception. If the <paramref name="InnerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x060019BC RID: 6588 RVA: 0x000708AC File Offset: 0x0006EAAC
		public RemotingException(string message, Exception InnerException) : base(message, InnerException)
		{
		}
	}
}
