using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The exception thrown by the marshaler when it encounters an argument of a variant type that can not be marshaled to managed code.</summary>
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public class InvalidOleVariantTypeException : SystemException
	{
		/// <summary>Initializes a new instance of the <see langword="InvalidOleVariantTypeException" /> class with default values.</summary>
		// Token: 0x06001F3B RID: 7995 RVA: 0x00086693 File Offset: 0x00084893
		public InvalidOleVariantTypeException() : base("Specified OLE variant was invalid.")
		{
			base.HResult = -2146233039;
		}

		/// <summary>Initializes a new instance of the <see langword="InvalidOleVariantTypeException" /> class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001F3C RID: 7996 RVA: 0x0000E339 File Offset: 0x0000C539
		protected InvalidOleVariantTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
