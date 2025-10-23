using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when the <see cref="Overload:System.Threading.Semaphore.Release" /> method is called on a semaphore whose count is already at the maximum. </summary>
	// Token: 0x020001AB RID: 427
	[Serializable]
	public class SemaphoreFullException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with default values.</summary>
		// Token: 0x06001053 RID: 4179 RVA: 0x000442F8 File Offset: 0x000424F8
		public SemaphoreFullException() : base("Adding the specified count to the semaphore would cause it to exceed its maximum count.")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
		// Token: 0x06001054 RID: 4180 RVA: 0x0000E339 File Offset: 0x0000C539
		protected SemaphoreFullException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
