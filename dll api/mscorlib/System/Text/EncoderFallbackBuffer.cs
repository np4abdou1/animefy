using System;

namespace System.Text
{
	/// <summary>Provides a buffer that allows a fallback handler to return an alternate string to an encoder when it cannot encode an input character. </summary>
	// Token: 0x02000255 RID: 597
	public abstract class EncoderFallbackBuffer
	{
		/// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified input character. </summary>
		/// <param name="charUnknown">An input character.</param>
		/// <param name="index">The index position of the character in the input buffer.</param>
		/// <returns>
		///     <see langword="true" /> if the fallback buffer can process <paramref name="charUnknown" />; <see langword="false" /> if the fallback buffer ignores <paramref name="charUnknown" />.</returns>
		// Token: 0x0600147F RID: 5247
		public abstract bool Fallback(char charUnknown, int index);

		/// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified surrogate pair.</summary>
		/// <param name="charUnknownHigh">The high surrogate of the input pair.</param>
		/// <param name="charUnknownLow">The low surrogate of the input pair.</param>
		/// <param name="index">The index position of the surrogate pair in the input buffer.</param>
		/// <returns>
		///     <see langword="true" /> if the fallback buffer can process <paramref name="charUnknownHigh" /> and <paramref name="charUnknownLow" />; <see langword="false" /> if the fallback buffer ignores the surrogate pair.</returns>
		// Token: 0x06001480 RID: 5248
		public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

		/// <summary>When overridden in a derived class, retrieves the next character in the fallback buffer.</summary>
		/// <returns>The next character in the fallback buffer.</returns>
		// Token: 0x06001481 RID: 5249
		public abstract char GetNextChar();

		/// <summary>When overridden in a derived class, causes the next call to the <see cref="M:System.Text.EncoderFallbackBuffer.GetNextChar" /> method to access the data buffer character position that is prior to the current character position. </summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="M:System.Text.EncoderFallbackBuffer.MovePrevious" /> operation was successful; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001482 RID: 5250
		public abstract bool MovePrevious();

		/// <summary>When overridden in a derived class, gets the number of characters in the current <see cref="T:System.Text.EncoderFallbackBuffer" /> object that remain to be processed.</summary>
		/// <returns>The number of characters in the current fallback buffer that have not yet been processed.</returns>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001483 RID: 5251
		public abstract int Remaining { get; }

		/// <summary>Initializes all data and state information pertaining to this fallback buffer.</summary>
		// Token: 0x06001484 RID: 5252 RVA: 0x00050D7E File Offset: 0x0004EF7E
		public virtual void Reset()
		{
			while (this.GetNextChar() != '\0')
			{
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00050D88 File Offset: 0x0004EF88
		internal void InternalReset()
		{
			this.charStart = null;
			this.bFallingBack = false;
			this.iRecursionCount = 0;
			this.Reset();
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00050DA6 File Offset: 0x0004EFA6
		internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			this.charStart = charStart;
			this.charEnd = charEnd;
			this.encoder = encoder;
			this.setEncoder = setEncoder;
			this.bUsedEncoder = false;
			this.bFallingBack = false;
			this.iRecursionCount = 0;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00050DDC File Offset: 0x0004EFDC
		internal char InternalGetNextChar()
		{
			char nextChar = this.GetNextChar();
			this.bFallingBack = (nextChar > '\0');
			if (nextChar == '\0')
			{
				this.iRecursionCount = 0;
			}
			return nextChar;
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00050E08 File Offset: 0x0004F008
		internal unsafe virtual bool InternalFallback(char ch, ref char* chars)
		{
			int index = (chars - this.charStart) / 2 - 1;
			if (char.IsHighSurrogate(ch))
			{
				if (chars >= this.charEnd)
				{
					if (this.encoder != null && !this.encoder.MustFlush)
					{
						if (this.setEncoder)
						{
							this.bUsedEncoder = true;
							this.encoder._charLeftOver = ch;
						}
						this.bFallingBack = false;
						return false;
					}
				}
				else
				{
					char c = (char)(*chars);
					if (char.IsLowSurrogate(c))
					{
						if (this.bFallingBack)
						{
							int num = this.iRecursionCount;
							this.iRecursionCount = num + 1;
							if (num > 250)
							{
								this.ThrowLastCharRecursive(char.ConvertToUtf32(ch, c));
							}
						}
						chars += 2;
						this.bFallingBack = this.Fallback(ch, c, index);
						return this.bFallingBack;
					}
				}
			}
			if (this.bFallingBack)
			{
				int num = this.iRecursionCount;
				this.iRecursionCount = num + 1;
				if (num > 250)
				{
					this.ThrowLastCharRecursive((int)ch);
				}
			}
			this.bFallingBack = this.Fallback(ch, index);
			return this.bFallingBack;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00050F06 File Offset: 0x0004F106
		internal void ThrowLastCharRecursive(int charRecursive)
		{
			throw new ArgumentException(SR.Format("Recursive fallback not allowed for character \\\\u{0:X4}.", charRecursive), "chars");
		}

		// Token: 0x0400082A RID: 2090
		internal unsafe char* charStart;

		// Token: 0x0400082B RID: 2091
		internal unsafe char* charEnd;

		// Token: 0x0400082C RID: 2092
		internal EncoderNLS encoder;

		// Token: 0x0400082D RID: 2093
		internal bool setEncoder;

		// Token: 0x0400082E RID: 2094
		internal bool bUsedEncoder;

		// Token: 0x0400082F RID: 2095
		internal bool bFallingBack;

		// Token: 0x04000830 RID: 2096
		internal int iRecursionCount;
	}
}
