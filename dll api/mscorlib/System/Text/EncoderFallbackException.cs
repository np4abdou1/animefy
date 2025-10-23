using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>The exception that is thrown when an encoder fallback operation fails. This class cannot be inherited.</summary>
	// Token: 0x02000253 RID: 595
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackException" /> class.</summary>
		// Token: 0x06001476 RID: 5238 RVA: 0x0004FCDF File Offset: 0x0004DEDF
		public EncoderFallbackException() : base("Value does not fall within the expected range.")
		{
			base.HResult = -2147024809;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00050C9D File Offset: 0x0004EE9D
		internal EncoderFallbackException(string message, char charUnknown, int index) : base(message)
		{
			this._charUnknown = charUnknown;
			this._index = index;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00050CB4 File Offset: 0x0004EEB4
		internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index) : base(message)
		{
			if (!char.IsHighSurrogate(charUnknownHigh))
			{
				throw new ArgumentOutOfRangeException("charUnknownHigh", SR.Format("Valid values are between {0} and {1}, inclusive.", 55296, 56319));
			}
			if (!char.IsLowSurrogate(charUnknownLow))
			{
				throw new ArgumentOutOfRangeException("CharUnknownLow", SR.Format("Valid values are between {0} and {1}, inclusive.", 56320, 57343));
			}
			this._charUnknownHigh = charUnknownHigh;
			this._charUnknownLow = charUnknownLow;
			this._index = index;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000E8CA File Offset: 0x0000CACA
		private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x04000824 RID: 2084
		private char _charUnknown;

		// Token: 0x04000825 RID: 2085
		private char _charUnknownHigh;

		// Token: 0x04000826 RID: 2086
		private char _charUnknownLow;

		// Token: 0x04000827 RID: 2087
		private int _index;
	}
}
