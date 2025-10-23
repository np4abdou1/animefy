using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>The exception that is thrown when reading is attempted past the end of a stream.</summary>
	// Token: 0x02000522 RID: 1314
	[Serializable]
	public class EndOfStreamException : IOException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.EndOfStreamException" /> class with its message string set to a system-supplied message and its HRESULT set to COR_E_ENDOFSTREAM.</summary>
		// Token: 0x060026C7 RID: 9927 RVA: 0x0009ADCA File Offset: 0x00098FCA
		public EndOfStreamException() : base("Attempted to read past the end of the stream.")
		{
			base.HResult = -2147024858;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.EndOfStreamException" /> class with its message string set to <paramref name="message" /> and its HRESULT set to COR_E_ENDOFSTREAM.</summary>
		/// <param name="message">A string that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x060026C8 RID: 9928 RVA: 0x0009ADE2 File Offset: 0x00098FE2
		public EndOfStreamException(string message) : base(message)
		{
			base.HResult = -2147024858;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.EndOfStreamException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060026C9 RID: 9929 RVA: 0x0009ADC0 File Offset: 0x00098FC0
		protected EndOfStreamException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
