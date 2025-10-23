using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to read or write protected memory.</summary>
	// Token: 0x02000060 RID: 96
	[Serializable]
	public class AccessViolationException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.AccessViolationException" /> class with a system-supplied message that describes the error.</summary>
		// Token: 0x06000216 RID: 534 RVA: 0x0000E321 File Offset: 0x0000C521
		public AccessViolationException() : base("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.")
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.AccessViolationException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06000217 RID: 535 RVA: 0x0000E339 File Offset: 0x0000C539
		protected AccessViolationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
