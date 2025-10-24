using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Represents a UTF-7 encoding of Unicode characters.</summary>
	// Token: 0x02000261 RID: 609
	[Serializable]
	public class UTF7Encoding : Encoding
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF7Encoding" /> class.</summary>
		// Token: 0x06001527 RID: 5415 RVA: 0x00054B02 File Offset: 0x00052D02
		public UTF7Encoding() : this(false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF7Encoding" /> class. A parameter specifies whether to allow optional characters.</summary>
		/// <param name="allowOptionals">
		///       <see langword="true" /> to specify that optional characters are allowed; otherwise, <see langword="false" />. </param>
		// Token: 0x06001528 RID: 5416 RVA: 0x00054B0B File Offset: 0x00052D0B
		public UTF7Encoding(bool allowOptionals) : base(65000)
		{
			this._allowOptionals = allowOptionals;
			this.MakeTables();
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00054B28 File Offset: 0x00052D28
		private void MakeTables()
		{
			this._base64Bytes = new byte[64];
			for (int i = 0; i < 64; i++)
			{
				this._base64Bytes[i] = (byte)"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"[i];
			}
			this._base64Values = new sbyte[128];
			for (int j = 0; j < 128; j++)
			{
				this._base64Values[j] = -1;
			}
			for (int k = 0; k < 64; k++)
			{
				this._base64Values[(int)this._base64Bytes[k]] = (sbyte)k;
			}
			this._directEncode = new bool[128];
			int length = "\t\n\r '(),-./0123456789:?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Length;
			for (int l = 0; l < length; l++)
			{
				this._directEncode[(int)"\t\n\r '(),-./0123456789:?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"[l]] = true;
			}
			if (this._allowOptionals)
			{
				length = "!\"#$%&*;<=>@[]^_`{|}".Length;
				for (int m = 0; m < length; m++)
				{
					this._directEncode[(int)"!\"#$%&*;<=>@[]^_`{|}"[m]] = true;
				}
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00054C20 File Offset: 0x00052E20
		internal override void SetDefaultFallbacks()
		{
			this.encoderFallback = new EncoderReplacementFallback(string.Empty);
			this.decoderFallback = new UTF7Encoding.DecoderUTF7Fallback();
		}

		/// <summary>Gets a value indicating whether the specified object is equal to the current <see cref="T:System.Text.UTF7Encoding" /> object.</summary>
		/// <param name="value">An object to compare to the current <see cref="T:System.Text.UTF7Encoding" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is a <see cref="T:System.Text.UTF7Encoding" /> object and is equal to the current <see cref="T:System.Text.UTF7Encoding" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600152B RID: 5419 RVA: 0x00054C40 File Offset: 0x00052E40
		public override bool Equals(object value)
		{
			UTF7Encoding utf7Encoding = value as UTF7Encoding;
			return utf7Encoding != null && (this._allowOptionals == utf7Encoding._allowOptionals && base.EncoderFallback.Equals(utf7Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf7Encoding.DecoderFallback);
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.Text.UTF7Encoding" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600152C RID: 5420 RVA: 0x00054C8D File Offset: 0x00052E8D
		public override int GetHashCode()
		{
			return this.CodePage + base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode();
		}

		/// <summary>Calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
		/// <param name="chars">The character array containing the set of characters to encode. </param>
		/// <param name="index">The index of the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.-or- The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600152D RID: 5421 RVA: 0x00054CB0 File Offset: 0x00052EB0
		public unsafe override int GetByteCount(char[] chars, int index, int count)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (chars.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (count == 0)
			{
				return 0;
			}
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			return this.GetByteCount(ptr + index, count, null);
		}

		/// <summary>Calculates the number of bytes produced by encoding the characters in the specified <see cref="T:System.String" /> object.</summary>
		/// <param name="s">The <see cref="T:System.String" /> object containing the set of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600152E RID: 5422 RVA: 0x00054D38 File Offset: 0x00052F38
		public unsafe override int GetByteCount(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return this.GetByteCount(ptr, s.Length, null);
		}

		/// <summary>Calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary>
		/// <param name="chars">A pointer to the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing " />in Visual Basic .NET). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600152F RID: 5423 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
		[CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			return this.GetByteCount(chars, count, null);
		}

		/// <summary>Encodes a set of characters from the specified <see cref="T:System.String" /> into the specified byte array.</summary>
		/// <param name="s">The <see cref="T:System.String" /> containing the set of characters to encode. </param>
		/// <param name="charIndex">The index of the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
		/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
		/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001530 RID: 5424 RVA: 0x00054D74 File Offset: 0x00052F74
		public unsafe override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (s == null || bytes == null)
			{
				throw new ArgumentNullException((s == null) ? "s" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (s.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("s", "Index and count must refer to a location within the string.");
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr2 = reference;
				return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}

		/// <summary>Encodes a set of characters from the specified character array into the specified byte array.</summary>
		/// <param name="chars">The character array containing the set of characters to encode. </param>
		/// <param name="charIndex">The index of the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
		/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
		/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001531 RID: 5425 RVA: 0x00054E3C File Offset: 0x0005303C
		public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (charCount == 0)
			{
				return 0;
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr2 = reference;
				return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}

		/// <summary>Encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary>
		/// <param name="chars">A pointer to the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes. </param>
		/// <param name="byteCount">The maximum number of bytes to write. </param>
		/// <returns>The actual number of bytes written at the location indicated by <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="byteCount" /> is less than the resulting number of bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001532 RID: 5426 RVA: 0x00054F0C File Offset: 0x0005310C
		[CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			return this.GetBytes(chars, charCount, bytes, byteCount, null);
		}

		/// <summary>Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="index">The index of the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.-or- The resulting number of characters is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001533 RID: 5427 RVA: 0x00054F70 File Offset: 0x00053170
		public unsafe override int GetCharCount(byte[] bytes, int index, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (count == 0)
			{
				return 0;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return this.GetCharCount(ptr + index, count, null);
		}

		/// <summary>Calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary>
		/// <param name="bytes">A pointer to the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero.-or- The resulting number of characters is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001534 RID: 5428 RVA: 0x0004ED6F File Offset: 0x0004CF6F
		[CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			return this.GetCharCount(bytes, count, null);
		}

		/// <summary>Decodes a sequence of bytes from the specified byte array into the specified character array.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="byteIndex">The index of the first byte to decode. </param>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <param name="chars">The character array to contain the resulting set of characters. </param>
		/// <param name="charIndex">The index at which to start writing the resulting set of characters. </param>
		/// <returns>The actual number of characters written into <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- 
		///         <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- 
		///         <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001535 RID: 5429 RVA: 0x00054FF4 File Offset: 0x000531F4
		public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (charIndex < 0 || charIndex > chars.Length)
			{
				throw new ArgumentOutOfRangeException("charIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (byteCount == 0)
			{
				return 0;
			}
			int charCount = chars.Length - charIndex;
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* ptr2 = reference;
				return this.GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, null);
			}
		}

		/// <summary>Decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary>
		/// <param name="bytes">A pointer to the first byte to decode. </param>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <param name="chars">A pointer to the location at which to start writing the resulting set of characters. </param>
		/// <param name="charCount">The maximum number of characters to write. </param>
		/// <returns>The actual number of characters written at the location indicated by <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="charCount" /> is less than the resulting number of characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001536 RID: 5430 RVA: 0x000550C4 File Offset: 0x000532C4
		[CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			return this.GetChars(bytes, byteCount, chars, charCount, null);
		}

		/// <summary>Decodes a range of bytes from a byte array into a string.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="index">The index of the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>A <see cref="T:System.String" /> containing the results of decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001537 RID: 5431 RVA: 0x00055128 File Offset: 0x00053328
		public unsafe override string GetString(byte[] bytes, int index, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (count == 0)
			{
				return string.Empty;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return string.CreateStringFromEncoding(ptr + index, count, this);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000551AE File Offset: 0x000533AE
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			return this.GetBytes(chars, count, null, 0, baseEncoder);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000551BC File Offset: 0x000533BC
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			UTF7Encoding.Encoder encoder = (UTF7Encoding.Encoder)baseEncoder;
			int num = 0;
			int i = -1;
			Encoding.EncodingByteBuffer encodingByteBuffer = new Encoding.EncodingByteBuffer(this, encoder, bytes, byteCount, chars, charCount);
			if (encoder != null)
			{
				num = encoder.bits;
				i = encoder.bitCount;
				while (i >= 6)
				{
					i -= 6;
					if (!encodingByteBuffer.AddByte(this._base64Bytes[num >> i & 63]))
					{
						base.ThrowBytesOverflow(encoder, encodingByteBuffer.Count == 0);
					}
				}
			}
			while (encodingByteBuffer.MoreData)
			{
				char nextChar = encodingByteBuffer.GetNextChar();
				if (nextChar < '\u0080' && this._directEncode[(int)nextChar])
				{
					if (i >= 0)
					{
						if (i > 0)
						{
							if (!encodingByteBuffer.AddByte(this._base64Bytes[num << 6 - i & 63]))
							{
								break;
							}
							i = 0;
						}
						if (!encodingByteBuffer.AddByte(45))
						{
							break;
						}
						i = -1;
					}
					if (!encodingByteBuffer.AddByte((byte)nextChar))
					{
						break;
					}
				}
				else if (i < 0 && nextChar == '+')
				{
					if (!encodingByteBuffer.AddByte(43, 45))
					{
						break;
					}
				}
				else
				{
					if (i < 0)
					{
						if (!encodingByteBuffer.AddByte(43))
						{
							break;
						}
						i = 0;
					}
					num = (num << 16 | (int)nextChar);
					i += 16;
					while (i >= 6)
					{
						i -= 6;
						if (!encodingByteBuffer.AddByte(this._base64Bytes[num >> i & 63]))
						{
							i += 6;
							nextChar = encodingByteBuffer.GetNextChar();
							break;
						}
					}
					if (i >= 6)
					{
						break;
					}
				}
			}
			if (i >= 0 && (encoder == null || encoder.MustFlush))
			{
				if (i > 0 && encodingByteBuffer.AddByte(this._base64Bytes[num << 6 - i & 63]))
				{
					i = 0;
				}
				if (encodingByteBuffer.AddByte(45))
				{
					num = 0;
					i = -1;
				}
				else
				{
					encodingByteBuffer.GetNextChar();
				}
			}
			if (bytes != null && encoder != null)
			{
				encoder.bits = num;
				encoder.bitCount = i;
				encoder._charsUsed = encodingByteBuffer.CharsUsed;
			}
			return encodingByteBuffer.Count;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0005536E File Offset: 0x0005356E
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			return this.GetChars(bytes, count, null, 0, baseDecoder);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0005537C File Offset: 0x0005357C
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UTF7Encoding.Decoder decoder = (UTF7Encoding.Decoder)baseDecoder;
			Encoding.EncodingCharBuffer encodingCharBuffer = new Encoding.EncodingCharBuffer(this, decoder, chars, charCount, bytes, byteCount);
			int num = 0;
			int num2 = -1;
			bool flag = false;
			if (decoder != null)
			{
				num = decoder.bits;
				num2 = decoder.bitCount;
				flag = decoder.firstByte;
			}
			if (num2 >= 16)
			{
				if (!encodingCharBuffer.AddChar((char)(num >> num2 - 16 & 65535)))
				{
					base.ThrowCharsOverflow(decoder, true);
				}
				num2 -= 16;
			}
			while (encodingCharBuffer.MoreData)
			{
				byte nextByte = encodingCharBuffer.GetNextByte();
				int num3;
				if (num2 >= 0)
				{
					sbyte b;
					if (nextByte < 128 && (b = this._base64Values[(int)nextByte]) >= 0)
					{
						flag = false;
						num = (num << 6 | (int)((byte)b));
						num2 += 6;
						if (num2 < 16)
						{
							continue;
						}
						num3 = (num >> num2 - 16 & 65535);
						num2 -= 16;
					}
					else
					{
						num2 = -1;
						if (nextByte != 45)
						{
							if (!encodingCharBuffer.Fallback(nextByte))
							{
								break;
							}
							continue;
						}
						else
						{
							if (!flag)
							{
								continue;
							}
							num3 = 43;
						}
					}
				}
				else
				{
					if (nextByte == 43)
					{
						num2 = 0;
						flag = true;
						continue;
					}
					if (nextByte >= 128)
					{
						if (!encodingCharBuffer.Fallback(nextByte))
						{
							break;
						}
						continue;
					}
					else
					{
						num3 = (int)nextByte;
					}
				}
				if (num3 >= 0 && !encodingCharBuffer.AddChar((char)num3))
				{
					if (num2 >= 0)
					{
						encodingCharBuffer.AdjustBytes(1);
						num2 += 16;
						break;
					}
					break;
				}
			}
			if (chars != null && decoder != null)
			{
				if (decoder.MustFlush)
				{
					decoder.bits = 0;
					decoder.bitCount = -1;
					decoder.firstByte = false;
				}
				else
				{
					decoder.bits = num;
					decoder.bitCount = num2;
					decoder.firstByte = flag;
				}
				decoder._bytesUsed = encodingCharBuffer.BytesUsed;
			}
			return encodingCharBuffer.Count;
		}

		/// <summary>Obtains a decoder that converts a UTF-7 encoded sequence of bytes into a sequence of Unicode characters.</summary>
		/// <returns>A <see cref="T:System.Text.Decoder" /> that converts a UTF-7 encoded sequence of bytes into a sequence of Unicode characters.</returns>
		// Token: 0x0600153C RID: 5436 RVA: 0x00055500 File Offset: 0x00053700
		public override System.Text.Decoder GetDecoder()
		{
			return new UTF7Encoding.Decoder(this);
		}

		/// <summary>Obtains an encoder that converts a sequence of Unicode characters into a UTF-7 encoded sequence of bytes.</summary>
		/// <returns>A <see cref="T:System.Text.Encoder" /> that converts a sequence of Unicode characters into a UTF-7 encoded sequence of bytes.</returns>
		// Token: 0x0600153D RID: 5437 RVA: 0x00055508 File Offset: 0x00053708
		public override System.Text.Encoder GetEncoder()
		{
			return new UTF7Encoding.Encoder(this);
		}

		/// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600153E RID: 5438 RVA: 0x00055510 File Offset: 0x00053710
		public override int GetMaxByteCount(int charCount)
		{
			if (charCount < 0)
			{
				throw new ArgumentOutOfRangeException("charCount", "Non-negative number required.");
			}
			long num = (long)charCount * 3L + 2L;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", "Too many characters. The resulting number of bytes is larger than what can be returned as an int.");
			}
			return (int)num;
		}

		/// <summary>Calculates the maximum number of characters produced by decoding the specified number of bytes.</summary>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> is less than zero.-or- The resulting number of characters is greater than the maximum number that can be returned as an int. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600153F RID: 5439 RVA: 0x00055548 File Offset: 0x00053748
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			int num = byteCount;
			if (num == 0)
			{
				num = 1;
			}
			return num;
		}

		// Token: 0x04000852 RID: 2130
		internal static readonly UTF7Encoding s_default = new UTF7Encoding();

		// Token: 0x04000853 RID: 2131
		private byte[] _base64Bytes;

		// Token: 0x04000854 RID: 2132
		private sbyte[] _base64Values;

		// Token: 0x04000855 RID: 2133
		private bool[] _directEncode;

		// Token: 0x04000856 RID: 2134
		private bool _allowOptionals;

		// Token: 0x02000262 RID: 610
		[Serializable]
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x06001541 RID: 5441 RVA: 0x00054ACB File Offset: 0x00052CCB
			public Decoder(UTF7Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06001542 RID: 5442 RVA: 0x0005557D File Offset: 0x0005377D
			public override void Reset()
			{
				this.bits = 0;
				this.bitCount = -1;
				this.firstByte = false;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x06001543 RID: 5443 RVA: 0x000555A7 File Offset: 0x000537A7
			internal override bool HasState
			{
				get
				{
					return this.bitCount != -1;
				}
			}

			// Token: 0x04000857 RID: 2135
			internal int bits;

			// Token: 0x04000858 RID: 2136
			internal int bitCount;

			// Token: 0x04000859 RID: 2137
			internal bool firstByte;
		}

		// Token: 0x02000263 RID: 611
		[Serializable]
		private sealed class Encoder : EncoderNLS
		{
			// Token: 0x06001544 RID: 5444 RVA: 0x000555B5 File Offset: 0x000537B5
			public Encoder(UTF7Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06001545 RID: 5445 RVA: 0x000555BE File Offset: 0x000537BE
			public override void Reset()
			{
				this.bitCount = -1;
				this.bits = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x06001546 RID: 5446 RVA: 0x000555E1 File Offset: 0x000537E1
			internal override bool HasState
			{
				get
				{
					return this.bits != 0 || this.bitCount != -1;
				}
			}

			// Token: 0x0400085A RID: 2138
			internal int bits;

			// Token: 0x0400085B RID: 2139
			internal int bitCount;
		}

		// Token: 0x02000264 RID: 612
		[Serializable]
		private sealed class DecoderUTF7Fallback : DecoderFallback
		{
			// Token: 0x06001548 RID: 5448 RVA: 0x000555F9 File Offset: 0x000537F9
			public override DecoderFallbackBuffer CreateFallbackBuffer()
			{
				return new UTF7Encoding.DecoderUTF7FallbackBuffer(this);
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x06001549 RID: 5449 RVA: 0x0000B18D File Offset: 0x0000938D
			public override int MaxCharCount
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x0600154A RID: 5450 RVA: 0x00055601 File Offset: 0x00053801
			public override bool Equals(object value)
			{
				return value is UTF7Encoding.DecoderUTF7Fallback;
			}

			// Token: 0x0600154B RID: 5451 RVA: 0x0005560E File Offset: 0x0005380E
			public override int GetHashCode()
			{
				return 984;
			}
		}

		// Token: 0x02000265 RID: 613
		private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
		{
			// Token: 0x0600154C RID: 5452 RVA: 0x00055615 File Offset: 0x00053815
			public DecoderUTF7FallbackBuffer(UTF7Encoding.DecoderUTF7Fallback fallback)
			{
			}

			// Token: 0x0600154D RID: 5453 RVA: 0x00055624 File Offset: 0x00053824
			public override bool Fallback(byte[] bytesUnknown, int index)
			{
				this.cFallback = (char)bytesUnknown[0];
				if (this.cFallback == '\0')
				{
					return false;
				}
				this.iCount = (this.iSize = 1);
				return true;
			}

			// Token: 0x0600154E RID: 5454 RVA: 0x00055658 File Offset: 0x00053858
			public override char GetNextChar()
			{
				int num = this.iCount;
				this.iCount = num - 1;
				if (num > 0)
				{
					return this.cFallback;
				}
				return '\0';
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x0600154F RID: 5455 RVA: 0x00055681 File Offset: 0x00053881
			public override int Remaining
			{
				get
				{
					if (this.iCount <= 0)
					{
						return 0;
					}
					return this.iCount;
				}
			}

			// Token: 0x06001550 RID: 5456 RVA: 0x00055694 File Offset: 0x00053894
			public override void Reset()
			{
				this.iCount = -1;
				this.byteStart = null;
			}

			// Token: 0x06001551 RID: 5457 RVA: 0x000556A5 File Offset: 0x000538A5
			internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
			{
				if (bytes.Length != 1)
				{
					throw new ArgumentException("String contains invalid Unicode code points.");
				}
				if (bytes[0] != 0)
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x0400085C RID: 2140
			private char cFallback;

			// Token: 0x0400085D RID: 2141
			private int iCount = -1;

			// Token: 0x0400085E RID: 2142
			private int iSize;
		}
	}
}
