using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt is made to store an element of the wrong type within an array. </summary>
	// Token: 0x0200007E RID: 126
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ArrayTypeMismatchException" /> class.</summary>
		// Token: 0x060002B7 RID: 695 RVA: 0x0000ECFB File Offset: 0x0000CEFB
		public ArrayTypeMismatchException() : base("Attempted to access an element as a type incompatible with the array.")
		{
			base.HResult = -2146233085;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArrayTypeMismatchException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x060002B8 RID: 696 RVA: 0x0000E339 File Offset: 0x0000C539
		protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
