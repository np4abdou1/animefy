using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to combine two delegates based on the <see cref="T:System.Delegate" /> type instead of the <see cref="T:System.MulticastDelegate" /> type. This class cannot be inherited. </summary>
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.MulticastNotSupportedException" /> class.</summary>
		// Token: 0x06000729 RID: 1833 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
		public MulticastNotSupportedException() : base("Attempted to add multiple callbacks to a delegate that does not support multicast.")
		{
			base.HResult = -2146233068;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MulticastNotSupportedException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x0600072A RID: 1834 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		public MulticastNotSupportedException(string message) : base(message)
		{
			base.HResult = -2146233068;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0000E339 File Offset: 0x0000C539
		internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
