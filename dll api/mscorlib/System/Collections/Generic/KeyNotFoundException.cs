using System;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	/// <summary>The exception that is thrown when the key specified for accessing an element in a collection does not match any key in the collection.</summary>
	// Token: 0x02000622 RID: 1570
	[Serializable]
	public class KeyNotFoundException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.KeyNotFoundException" /> class using default property values.</summary>
		// Token: 0x06002FB9 RID: 12217 RVA: 0x000C1447 File Offset: 0x000BF647
		public KeyNotFoundException() : base("The given key was not present in the dictionary.")
		{
			base.HResult = -2146232969;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.KeyNotFoundException" /> class with the specified error message.</summary>
		/// <param name="message">The message that describes the error.</param>
		// Token: 0x06002FBA RID: 12218 RVA: 0x000C145F File Offset: 0x000BF65F
		public KeyNotFoundException(string message) : base(message)
		{
			base.HResult = -2146232969;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.KeyNotFoundException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" />  that contains contextual information about the source or destination.</param>
		// Token: 0x06002FBB RID: 12219 RVA: 0x0000E339 File Offset: 0x0000C539
		protected KeyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
