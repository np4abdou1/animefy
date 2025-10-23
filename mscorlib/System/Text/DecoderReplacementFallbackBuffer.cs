using System;

namespace System.Text
{
	/// <summary>Represents a substitute output string that is emitted when the original input byte sequence cannot be decoded. This class cannot be inherited.</summary>
	// Token: 0x0200024D RID: 589
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderReplacementFallbackBuffer" /> class using the value of a <see cref="T:System.Text.DecoderReplacementFallback" /> object.</summary>
		/// <param name="fallback">A <see cref="T:System.Text.DecoderReplacementFallback" /> object that contains a replacement string. </param>
		// Token: 0x0600144C RID: 5196 RVA: 0x00050467 File Offset: 0x0004E667
		public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
		{
			this._strDefault = fallback.DefaultString;
		}

		/// <summary>Prepares the replacement fallback buffer to use the current replacement string.</summary>
		/// <param name="bytesUnknown">An input byte sequence. This parameter is ignored unless an exception is thrown.</param>
		/// <param name="index">The index position of the byte in <paramref name="bytesUnknown" />. This parameter is ignored in this operation.</param>
		/// <returns>
		///     <see langword="true" /> if the replacement string is not empty; <see langword="false" /> if the replacement string is empty.</returns>
		/// <exception cref="T:System.ArgumentException">This method is called again before the <see cref="M:System.Text.DecoderReplacementFallbackBuffer.GetNextChar" /> method has read all the characters in the replacement fallback buffer.  </exception>
		// Token: 0x0600144D RID: 5197 RVA: 0x00050489 File Offset: 0x0004E689
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			if (this._fallbackCount >= 1)
			{
				base.ThrowLastBytesRecursive(bytesUnknown);
			}
			if (this._strDefault.Length == 0)
			{
				return false;
			}
			this._fallbackCount = this._strDefault.Length;
			this._fallbackIndex = -1;
			return true;
		}

		/// <summary>Retrieves the next character in the replacement fallback buffer.</summary>
		/// <returns>The next character in the replacement fallback buffer.</returns>
		// Token: 0x0600144E RID: 5198 RVA: 0x000504C4 File Offset: 0x0004E6C4
		public override char GetNextChar()
		{
			this._fallbackCount--;
			this._fallbackIndex++;
			if (this._fallbackCount < 0)
			{
				return '\0';
			}
			if (this._fallbackCount == 2147483647)
			{
				this._fallbackCount = -1;
				return '\0';
			}
			return this._strDefault[this._fallbackIndex];
		}

		/// <summary>Gets the number of characters in the replacement fallback buffer that remain to be processed.</summary>
		/// <returns>The number of characters in the replacement fallback buffer that have not yet been processed.</returns>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0005051F File Offset: 0x0004E71F
		public override int Remaining
		{
			get
			{
				if (this._fallbackCount >= 0)
				{
					return this._fallbackCount;
				}
				return 0;
			}
		}

		/// <summary>Initializes all internal state information and data in the <see cref="T:System.Text.DecoderReplacementFallbackBuffer" /> object.</summary>
		// Token: 0x06001450 RID: 5200 RVA: 0x00050532 File Offset: 0x0004E732
		public override void Reset()
		{
			this._fallbackCount = -1;
			this._fallbackIndex = -1;
			this.byteStart = null;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005054A File Offset: 0x0004E74A
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return this._strDefault.Length;
		}

		// Token: 0x04000818 RID: 2072
		private string _strDefault;

		// Token: 0x04000819 RID: 2073
		private int _fallbackCount = -1;

		// Token: 0x0400081A RID: 2074
		private int _fallbackIndex = -1;
	}
}
