using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when a method requires the caller to own the lock on a given Monitor, and the method is invoked by a caller that does not own that lock.</summary>
	// Token: 0x020001AD RID: 429
	[Serializable]
	public class SynchronizationLockException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SynchronizationLockException" /> class with default properties.</summary>
		// Token: 0x06001059 RID: 4185 RVA: 0x00044305 File Offset: 0x00042505
		public SynchronizationLockException() : base("Object synchronization method was called from an unsynchronized block of code.")
		{
			base.HResult = -2146233064;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SynchronizationLockException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x0600105A RID: 4186 RVA: 0x0004431D File Offset: 0x0004251D
		public SynchronizationLockException(string message) : base(message)
		{
			base.HResult = -2146233064;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SynchronizationLockException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x0600105B RID: 4187 RVA: 0x0000E339 File Offset: 0x0000C539
		protected SynchronizationLockException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
