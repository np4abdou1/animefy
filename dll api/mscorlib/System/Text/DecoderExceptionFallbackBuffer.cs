using System;
using System.Globalization;

namespace System.Text
{
	/// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> when an encoded input byte sequence cannot be converted to a decoded output character. This class cannot be inherited.</summary>
	// Token: 0x02000247 RID: 583
	public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
	{
		/// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> when the input byte sequence cannot be decoded. The nominal return value is not used. </summary>
		/// <param name="bytesUnknown">An input array of bytes.</param>
		/// <param name="index">The index position of a byte in the input.</param>
		/// <returns>None. No value is returned because the <see cref="M:System.Text.DecoderExceptionFallbackBuffer.Fallback(System.Byte[],System.Int32)" /> method always throws an exception. The nominal return value is <see langword="true" />. A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
		/// <exception cref="T:System.Text.DecoderFallbackException">This method always throws an exception that reports the value and index position of the input byte that cannot be decoded. </exception>
		// Token: 0x0600141F RID: 5151 RVA: 0x0004FC46 File Offset: 0x0004DE46
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			this.Throw(bytesUnknown, index);
			return true;
		}

		/// <summary>Retrieves the next character in the exception data buffer.</summary>
		/// <returns>The return value is always the Unicode character NULL (U+0000). A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
		// Token: 0x06001420 RID: 5152 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override char GetNextChar()
		{
			return '\0';
		}

		/// <summary>Gets the number of characters in the current <see cref="T:System.Text.DecoderExceptionFallbackBuffer" /> object that remain to be processed.</summary>
		/// <returns>The return value is always zero. A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override int Remaining
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0004FC54 File Offset: 0x0004DE54
		private void Throw(byte[] bytesUnknown, int index)
		{
			StringBuilder stringBuilder = new StringBuilder(bytesUnknown.Length * 3);
			int num = 0;
			while (num < bytesUnknown.Length && num < 20)
			{
				stringBuilder.Append('[');
				stringBuilder.Append(bytesUnknown[num].ToString("X2", CultureInfo.InvariantCulture));
				stringBuilder.Append(']');
				num++;
			}
			if (num == 20)
			{
				stringBuilder.Append(" ...");
			}
			throw new DecoderFallbackException(SR.Format("Unable to translate bytes {0} at index {1} from specified code page to Unicode.", stringBuilder, index), bytesUnknown, index);
		}
	}
}
