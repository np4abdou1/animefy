using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>The exception that is thrown when a decoder fallback operation fails. This class cannot be inherited.</summary>
	// Token: 0x02000248 RID: 584
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class. </summary>
		// Token: 0x06001424 RID: 5156 RVA: 0x0004FCDF File Offset: 0x0004DEDF
		public DecoderFallbackException() : base("Value does not fall within the expected range.")
		{
			base.HResult = -2147024809;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class. Parameters specify the error message, the array of bytes being decoded, and the index of the byte that cannot be decoded.</summary>
		/// <param name="message">An error message.</param>
		/// <param name="bytesUnknown">The input byte array.</param>
		/// <param name="index">The index position in <paramref name="bytesUnknown" /> of the byte that cannot be decoded.</param>
		// Token: 0x06001425 RID: 5157 RVA: 0x0004FCF7 File Offset: 0x0004DEF7
		public DecoderFallbackException(string message, byte[] bytesUnknown, int index) : base(message)
		{
			this._bytesUnknown = bytesUnknown;
			this._index = index;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0000E8CA File Offset: 0x0000CACA
		private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x0400080D RID: 2061
		private byte[] _bytesUnknown;

		// Token: 0x0400080E RID: 2062
		private int _index;
	}
}
