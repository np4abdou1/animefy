using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a requested method or operation is not implemented.</summary>
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class NotImplementedException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.NotImplementedException" /> class with default properties.</summary>
		// Token: 0x06000730 RID: 1840 RVA: 0x0001E041 File Offset: 0x0001C241
		public NotImplementedException() : base("The method or operation is not implemented.")
		{
			base.HResult = -2147467263;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotImplementedException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06000731 RID: 1841 RVA: 0x0001E059 File Offset: 0x0001C259
		public NotImplementedException(string message) : base(message)
		{
			base.HResult = -2147467263;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotImplementedException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06000732 RID: 1842 RVA: 0x0000E339 File Offset: 0x0000C539
		protected NotImplementedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
