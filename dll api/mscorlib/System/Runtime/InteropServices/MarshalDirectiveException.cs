using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The exception that is thrown by the marshaler when it encounters a <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> it does not support.</summary>
	// Token: 0x020003FB RID: 1019
	[Serializable]
	public class MarshalDirectiveException : SystemException
	{
		/// <summary>Initializes a new instance of the <see langword="MarshalDirectiveException" /> class with default properties.</summary>
		// Token: 0x06001F22 RID: 7970 RVA: 0x000863D3 File Offset: 0x000845D3
		public MarshalDirectiveException() : base("Marshaling directives are invalid.")
		{
			base.HResult = -2146233035;
		}

		/// <summary>Initializes a new instance of the <see langword="MarshalDirectiveException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that specifies the reason for the exception. </param>
		// Token: 0x06001F23 RID: 7971 RVA: 0x000863EB File Offset: 0x000845EB
		public MarshalDirectiveException(string message) : base(message)
		{
			base.HResult = -2146233035;
		}

		/// <summary>Initializes a new instance of the <see langword="MarshalDirectiveException" /> class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001F24 RID: 7972 RVA: 0x0000E339 File Offset: 0x0000C539
		protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
