using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt to marshal an object across a context boundary fails.</summary>
	// Token: 0x0200013F RID: 319
	[ComVisible(true)]
	[Serializable]
	public class ContextMarshalException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ContextMarshalException" /> class with default properties.</summary>
		// Token: 0x06000C55 RID: 3157 RVA: 0x00032DF1 File Offset: 0x00030FF1
		public ContextMarshalException() : base(Environment.GetResourceString("Attempted to marshal an object across a context boundary."))
		{
			base.SetErrorCode(-2146233084);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ContextMarshalException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06000C56 RID: 3158 RVA: 0x0000E339 File Offset: 0x0000C539
		protected ContextMarshalException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
