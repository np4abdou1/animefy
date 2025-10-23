using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when recursive entry into a lock is not compatible with the recursion policy for the lock.</summary>
	// Token: 0x020001A8 RID: 424
	[Serializable]
	public class LockRecursionException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with a system-supplied message that describes the error.</summary>
		// Token: 0x0600104B RID: 4171 RVA: 0x0001CA1B File Offset: 0x0001AC1B
		public LockRecursionException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with a specified message that describes the error.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor must make sure that this string has been localized for the current system culture. </param>
		// Token: 0x0600104C RID: 4172 RVA: 0x0001CA23 File Offset: 0x0001AC23
		public LockRecursionException(string message) : base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		// Token: 0x0600104D RID: 4173 RVA: 0x0000E782 File Offset: 0x0000C982
		protected LockRecursionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
