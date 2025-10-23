using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown by methods invoked through reflection. This class cannot be inherited.</summary>
	// Token: 0x020004C0 RID: 1216
	[Serializable]
	public sealed class TargetInvocationException : ApplicationException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetInvocationException" /> class with a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06002252 RID: 8786 RVA: 0x0008B014 File Offset: 0x00089214
		public TargetInvocationException(Exception inner) : base("Exception has been thrown by the target of an invocation.", inner)
		{
			base.HResult = -2146232828;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetInvocationException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06002253 RID: 8787 RVA: 0x0008B02D File Offset: 0x0008922D
		public TargetInvocationException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232828;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0004439A File Offset: 0x0004259A
		internal TargetInvocationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
