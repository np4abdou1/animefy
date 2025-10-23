using System;
using System.Globalization;

namespace System.Text
{
	/// <summary>Provides a buffer that allows a fallback handler to return an alternate string to a decoder when it cannot decode an input byte sequence. </summary>
	// Token: 0x0200024A RID: 586
	public abstract class DecoderFallbackBuffer
	{
		/// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified input byte sequence.</summary>
		/// <param name="bytesUnknown">An input array of bytes.</param>
		/// <param name="index">The index position of a byte in <paramref name="bytesUnknown" />.</param>
		/// <returns>
		///     <see langword="true" /> if the fallback buffer can process <paramref name="bytesUnknown" />; <see langword="false" /> if the fallback buffer ignores <paramref name="bytesUnknown" />.</returns>
		// Token: 0x0600142C RID: 5164
		public abstract bool Fallback(byte[] bytesUnknown, int index);

		/// <summary>When overridden in a derived class, retrieves the next character in the fallback buffer.</summary>
		/// <returns>The next character in the fallback buffer.</returns>
		// Token: 0x0600142D RID: 5165
		public abstract char GetNextChar();

		/// <summary>When overridden in a derived class, gets the number of characters in the current <see cref="T:System.Text.DecoderFallbackBuffer" /> object that remain to be processed.</summary>
		/// <returns>The number of characters in the current fallback buffer that have not yet been processed.</returns>
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600142E RID: 5166
		public abstract int Remaining { get; }

		/// <summary>Initializes all data and state information pertaining to this fallback buffer.</summary>
		// Token: 0x0600142F RID: 5167 RVA: 0x0004FD56 File Offset: 0x0004DF56
		public virtual void Reset()
		{
			while (this.GetNextChar() != '\0')
			{
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0004FD60 File Offset: 0x0004DF60
		internal void InternalReset()
		{
			this.byteStart = null;
			this.Reset();
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0004FD70 File Offset: 0x0004DF70
		internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
			this.byteStart = byteStart;
			this.charEnd = charEnd;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0004FD80 File Offset: 0x0004DF80
		internal unsafe virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
		{
			if (this.Fallback(bytes, (int)((long)(pBytes - this.byteStart) - (long)bytes.Length)))
			{
				char* ptr = chars;
				bool flag = false;
				char nextChar;
				while ((nextChar = this.GetNextChar()) != '\0')
				{
					if (char.IsSurrogate(nextChar))
					{
						if (char.IsHighSurrogate(nextChar))
						{
							if (flag)
							{
								throw new ArgumentException("String contains invalid Unicode code points.");
							}
							flag = true;
						}
						else
						{
							if (!flag)
							{
								throw new ArgumentException("String contains invalid Unicode code points.");
							}
							flag = false;
						}
					}
					if (ptr >= this.charEnd)
					{
						return false;
					}
					*(ptr++) = nextChar;
				}
				if (flag)
				{
					throw new ArgumentException("String contains invalid Unicode code points.");
				}
				chars = ptr;
			}
			return true;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0004FE10 File Offset: 0x0004E010
		internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
		{
			if (!this.Fallback(bytes, (int)((long)(pBytes - this.byteStart) - (long)bytes.Length)))
			{
				return 0;
			}
			int num = 0;
			bool flag = false;
			char nextChar;
			while ((nextChar = this.GetNextChar()) != '\0')
			{
				if (char.IsSurrogate(nextChar))
				{
					if (char.IsHighSurrogate(nextChar))
					{
						if (flag)
						{
							throw new ArgumentException("String contains invalid Unicode code points.");
						}
						flag = true;
					}
					else
					{
						if (!flag)
						{
							throw new ArgumentException("String contains invalid Unicode code points.");
						}
						flag = false;
					}
				}
				num++;
			}
			if (flag)
			{
				throw new ArgumentException("String contains invalid Unicode code points.");
			}
			return num;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0004FE90 File Offset: 0x0004E090
		internal void ThrowLastBytesRecursive(byte[] bytesUnknown)
		{
			StringBuilder stringBuilder = new StringBuilder(bytesUnknown.Length * 3);
			int num = 0;
			while (num < bytesUnknown.Length && num < 20)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "\\x{0:X2}", bytesUnknown[num]);
				num++;
			}
			if (num == 20)
			{
				stringBuilder.Append(" ...");
			}
			throw new ArgumentException(SR.Format("Recursive fallback not allowed for bytes {0}.", stringBuilder.ToString()), "bytesUnknown");
		}

		// Token: 0x04000811 RID: 2065
		internal unsafe byte* byteStart;

		// Token: 0x04000812 RID: 2066
		internal unsafe char* charEnd;
	}
}
