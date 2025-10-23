using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is not enough memory to continue the execution of a program.</summary>
	// Token: 0x0200012B RID: 299
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.OutOfMemoryException" /> class.</summary>
		// Token: 0x06000B8F RID: 2959 RVA: 0x0002FFFC File Offset: 0x0002E1FC
		public OutOfMemoryException() : base("Insufficient memory to continue the execution of the program.")
		{
			base.HResult = -2147024882;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OutOfMemoryException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000B90 RID: 2960 RVA: 0x00030014 File Offset: 0x0002E214
		public OutOfMemoryException(string message) : base(message)
		{
			base.HResult = -2147024882;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OutOfMemoryException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000B91 RID: 2961 RVA: 0x0000E339 File Offset: 0x0000C539
		protected OutOfMemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
