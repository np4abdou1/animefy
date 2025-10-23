﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Represents a UTF-8 encoding of Unicode characters.</summary>
	// Token: 0x02000266 RID: 614
	[Serializable]
	public class UTF8Encoding : Encoding
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF8Encoding" /> class.</summary>
		// Token: 0x06001552 RID: 5458 RVA: 0x000556C0 File Offset: 0x000538C0
		public UTF8Encoding() : this(false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF8Encoding" /> class. A parameter specifies whether to provide a Unicode byte order mark. </summary>
		/// <param name="encoderShouldEmitUTF8Identifier">
		///       <see langword="true" /> to specify that the <see cref="M:System.Text.UTF8Encoding.GetPreamble" /> method returns a Unicode byte order mark; otherwise, <see langword="false" />. See the Remarks section for more information. </param>
		// Token: 0x06001553 RID: 5459 RVA: 0x000556C9 File Offset: 0x000538C9
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) : this(encoderShouldEmitUTF8Identifier, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF8Encoding" /> class. Parameters specify whether to provide a Unicode byte order mark and whether to throw an exception when an invalid encoding is detected. </summary>
		/// <param name="encoderShouldEmitUTF8Identifier">
		///       <see langword="true" /> to specify that the <see cref="M:System.Text.UTF8Encoding.GetPreamble" /> method should return a Unicode byte order mark; otherwise, <see langword="false" />. See the Remarks section for more information. </param>
		/// <param name="throwOnInvalidBytes">
		///       <see langword="true" /> to throw an exception when an invalid encoding is detected; otherwise, <see langword="false" />. </param>
		// Token: 0x06001554 RID: 5460 RVA: 0x000556D3 File Offset: 0x000538D3
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) : base(65001)
		{
			this._emitUTF8Identifier = encoderShouldEmitUTF8Identifier;
			this._isThrowException = throwOnInvalidBytes;
			if (this._isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000556FC File Offset: 0x000538FC
		internal override void SetDefaultFallbacks()
		{
			if (this._isThrowException)
			{
				this.encoderFallback = EncoderFallback.ExceptionFallback;
				this.decoderFallback = DecoderFallback.ExceptionFallback;
				return;
			}
			this.encoderFallback = new EncoderReplacementFallback("�");
			this.decoderFallback = new DecoderReplacementFallback("�");
		}

		/// <summary>Calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
		/// <param name="chars">The character array containing the set of characters to encode. </param>
		/// <param name="index">The index of the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-The <see cref="P:System.Text.Encoding.EncoderFallback" /> property is set to <see cref="T:System.Text.EncoderExceptionFallback" />. </exception>
		// Token: 0x06001556 RID: 5462 RVA: 0x00055748 File Offset: 0x00053948
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

		/// <summary>Calculates the number of bytes produced by encoding the characters in the specified <see cref="T:System.String" />.</summary>
		/// <param name="chars">The <see cref="T:System.String" /> containing the set of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001557 RID: 5463 RVA: 0x000557D0 File Offset: 0x000539D0
		public unsafe override int GetByteCount(string chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("s");
			}
			char* ptr = chars;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return this.GetByteCount(ptr, chars.Length, null);
		}

		/// <summary>Calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary>
		/// <param name="chars">A pointer to the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for a complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001558 RID: 5464 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
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
		///         <paramref name="s" /> is <see langword="null" />.-or- 
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="s" /> contains an invalid sequence of characters.-or- 
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001559 RID: 5465 RVA: 0x0005580C File Offset: 0x00053A0C
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
		///         <paramref name="chars" /> is <see langword="null" />.-or- 
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.-or- 
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600155A RID: 5466 RVA: 0x000558D4 File Offset: 0x00053AD4
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
		///         <paramref name="chars" /> is <see langword="null" />.-or- 
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.-or- 
		///         <paramref name="byteCount" /> is less than the resulting number of bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600155B RID: 5467 RVA: 0x000559A4 File Offset: 0x00053BA4
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
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600155C RID: 5468 RVA: 0x00055A08 File Offset: 0x00053C08
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
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600155D RID: 5469 RVA: 0x0004ED6F File Offset: 0x0004CF6F
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
		///         <paramref name="bytes" /> is <see langword="null" />.-or- 
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- 
		///         <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- 
		///         <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.-or- 
		///         <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600155E RID: 5470 RVA: 0x00055A8C File Offset: 0x00053C8C
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
		///         <paramref name="bytes" /> is <see langword="null" />.-or- 
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.-or- 
		///         <paramref name="charCount" /> is less than the resulting number of characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600155F RID: 5471 RVA: 0x00055B5C File Offset: 0x00053D5C
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
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001560 RID: 5472 RVA: 0x00055BC0 File Offset: 0x00053DC0
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

		// Token: 0x06001561 RID: 5473 RVA: 0x00055C48 File Offset: 0x00053E48
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			char* ptr = chars;
			char* ptr2 = ptr + count;
			int num = count;
			int num2 = 0;
			if (baseEncoder != null)
			{
				UTF8Encoding.UTF8Encoder utf8Encoder = (UTF8Encoding.UTF8Encoder)baseEncoder;
				num2 = utf8Encoder.surrogateChar;
				if (utf8Encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = utf8Encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, utf8Encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(chars, ptr2, utf8Encoder, false);
				}
			}
			for (;;)
			{
				if (ptr >= ptr2)
				{
					if (num2 == 0)
					{
						num2 = (int)((encoderFallbackBuffer != null) ? encoderFallbackBuffer.InternalGetNextChar() : '\0');
						if (num2 > 0)
						{
							num++;
							goto IL_14C;
						}
					}
					else if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
					{
						num2 = (int)encoderFallbackBuffer.InternalGetNextChar();
						num++;
						if (UTF8Encoding.InRange(num2, 56320, 57343))
						{
							num2 = 65533;
							num++;
							goto IL_16A;
						}
						if (num2 <= 0)
						{
							break;
						}
						goto IL_14C;
					}
					if (num2 > 0 && (baseEncoder == null || baseEncoder.MustFlush))
					{
						num++;
						goto IL_16A;
					}
					goto IL_432;
				}
				else if (num2 > 0)
				{
					int ch = (int)(*ptr);
					num++;
					if (UTF8Encoding.InRange(ch, 56320, 57343))
					{
						num2 = 65533;
						ptr++;
						goto IL_16A;
					}
					goto IL_16A;
				}
				else
				{
					if (encoderFallbackBuffer != null)
					{
						num2 = (int)encoderFallbackBuffer.InternalGetNextChar();
						if (num2 > 0)
						{
							num++;
							goto IL_14C;
						}
					}
					num2 = (int)(*ptr);
					ptr++;
				}
				IL_14C:
				if (UTF8Encoding.InRange(num2, 55296, 56319))
				{
					num--;
					continue;
				}
				IL_16A:
				if (UTF8Encoding.InRange(num2, 55296, 57343))
				{
					if (encoderFallbackBuffer == null)
					{
						if (baseEncoder == null)
						{
							encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
						}
						else
						{
							encoderFallbackBuffer = baseEncoder.FallbackBuffer;
						}
						encoderFallbackBuffer.InternalInitialize(chars, chars + count, baseEncoder, false);
					}
					char* ptr3 = ptr;
					encoderFallbackBuffer.InternalFallback((char)num2, ref ptr3);
					ptr = ptr3;
					num--;
					num2 = 0;
				}
				else
				{
					if (num2 > 127)
					{
						if (num2 > 2047)
						{
							num++;
						}
						num++;
					}
					if (num < 0)
					{
						goto IL_432;
					}
					if (encoderFallbackBuffer != null && (num2 = (int)encoderFallbackBuffer.InternalGetNextChar()) != 0)
					{
						num++;
						goto IL_14C;
					}
					int num3 = UTF8Encoding.PtrDiff(ptr2, ptr);
					if (num3 <= 13)
					{
						char* ptr4 = ptr2;
						while (ptr < ptr4)
						{
							num2 = (int)(*ptr);
							ptr++;
							if (num2 > 127)
							{
								goto IL_14C;
							}
						}
						goto Block_28;
					}
					num3 &= 268435455;
					char* ptr5 = ptr + num3 - 7;
					IL_422:
					while (ptr < ptr5)
					{
						num2 = (int)(*ptr);
						ptr++;
						if (num2 > 127)
						{
							if (num2 > 2047)
							{
								if ((num2 & 63488) == 55296)
								{
									goto IL_3D0;
								}
								num++;
							}
							num++;
						}
						if ((ptr & 2) != 0)
						{
							num2 = (int)(*ptr);
							ptr++;
							if (num2 > 127)
							{
								if (num2 > 2047)
								{
									if ((num2 & 63488) == 55296)
									{
										goto IL_3D0;
									}
									num++;
								}
								num++;
							}
						}
						while (ptr < ptr5)
						{
							num2 = *(int*)ptr;
							int num4 = *(int*)(ptr + 2);
							if (((num2 | num4) & -8323200) != 0)
							{
								if (((num2 | num4) & -134154240) != 0)
								{
									goto IL_3B1;
								}
								if ((num2 & -8388608) != 0)
								{
									num++;
								}
								if ((num2 & 65408) != 0)
								{
									num++;
								}
								if ((num4 & -8388608) != 0)
								{
									num++;
								}
								if ((num4 & 65408) != 0)
								{
									num++;
								}
							}
							ptr += 4;
							num2 = *(int*)ptr;
							num4 = *(int*)(ptr + 2);
							if (((num2 | num4) & -8323200) != 0)
							{
								if (((num2 | num4) & -134154240) != 0)
								{
									goto IL_3B1;
								}
								if ((num2 & -8388608) != 0)
								{
									num++;
								}
								if ((num2 & 65408) != 0)
								{
									num++;
								}
								if ((num4 & -8388608) != 0)
								{
									num++;
								}
								if ((num4 & 65408) != 0)
								{
									num++;
								}
							}
							ptr += 4;
							continue;
							IL_3B1:
							if (BitConverter.IsLittleEndian)
							{
								num2 = (int)((ushort)num2);
							}
							else
							{
								num2 = (int)((uint)num2 >> 16);
							}
							ptr++;
							if (num2 > 127)
							{
								goto IL_3D0;
							}
							goto IL_422;
						}
						break;
						IL_3D0:
						if (num2 > 2047)
						{
							if (UTF8Encoding.InRange(num2, 55296, 57343))
							{
								int ch2 = (int)(*ptr);
								if (num2 > 56319 || !UTF8Encoding.InRange(ch2, 56320, 57343))
								{
									ptr--;
									break;
								}
								ptr++;
							}
							num++;
						}
						num++;
					}
					num2 = 0;
				}
			}
			num--;
			Block_28:
			IL_432:
			if (num < 0)
			{
				throw new ArgumentException("Conversion buffer overflow.");
			}
			return num;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00056099 File Offset: 0x00054299
		private unsafe static int PtrDiff(char* a, char* b)
		{
			return (int)((uint)((long)((a - b) / 1 * 2)) >> 1);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000560A4 File Offset: 0x000542A4
		private unsafe static int PtrDiff(byte* a, byte* b)
		{
			return (int)((long)(a - b));
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000560AD File Offset: 0x000542AD
		private static bool InRange(int ch, int start, int end)
		{
			return ch - start <= end - start;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000560BC File Offset: 0x000542BC
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			UTF8Encoding.UTF8Encoder utf8Encoder = null;
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			char* ptr = chars;
			byte* ptr2 = bytes;
			char* ptr3 = ptr + charCount;
			byte* ptr4 = ptr2 + byteCount;
			int num = 0;
			if (baseEncoder != null)
			{
				utf8Encoder = (UTF8Encoding.UTF8Encoder)baseEncoder;
				num = utf8Encoder.surrogateChar;
				if (utf8Encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = utf8Encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0 && utf8Encoder._throwOnOverflow)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, utf8Encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(chars, ptr3, utf8Encoder, true);
				}
			}
			for (;;)
			{
				if (ptr >= ptr3)
				{
					if (num == 0)
					{
						num = (int)((encoderFallbackBuffer != null) ? encoderFallbackBuffer.InternalGetNextChar() : '\0');
						if (num > 0)
						{
							goto IL_147;
						}
					}
					else if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
					{
						int num2 = num;
						num = (int)encoderFallbackBuffer.InternalGetNextChar();
						if (UTF8Encoding.InRange(num, 56320, 57343))
						{
							num = num + (num2 << 10) + -56613888;
							goto IL_15D;
						}
						if (num > 0)
						{
							goto IL_147;
						}
						goto IL_53C;
					}
					if (num <= 0)
					{
						goto IL_53C;
					}
					if (utf8Encoder == null)
					{
						goto IL_15D;
					}
					if (utf8Encoder.MustFlush)
					{
						goto IL_15D;
					}
					goto IL_53C;
				}
				else if (num > 0)
				{
					int num3 = (int)(*ptr);
					if (UTF8Encoding.InRange(num3, 56320, 57343))
					{
						num = num3 + (num << 10) + -56613888;
						ptr++;
						goto IL_15D;
					}
					goto IL_15D;
				}
				else
				{
					if (encoderFallbackBuffer != null)
					{
						num = (int)encoderFallbackBuffer.InternalGetNextChar();
						if (num > 0)
						{
							goto IL_147;
						}
					}
					num = (int)(*ptr);
					ptr++;
				}
				IL_147:
				if (UTF8Encoding.InRange(num, 55296, 56319))
				{
					continue;
				}
				IL_15D:
				if (UTF8Encoding.InRange(num, 55296, 57343))
				{
					if (encoderFallbackBuffer == null)
					{
						if (baseEncoder == null)
						{
							encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
						}
						else
						{
							encoderFallbackBuffer = baseEncoder.FallbackBuffer;
						}
						encoderFallbackBuffer.InternalInitialize(chars, ptr3, baseEncoder, true);
					}
					char* ptr5 = ptr;
					encoderFallbackBuffer.InternalFallback((char)num, ref ptr5);
					ptr = ptr5;
					num = 0;
				}
				else
				{
					int num4 = 1;
					if (num > 127)
					{
						if (num > 2047)
						{
							if (num > 65535)
							{
								num4++;
							}
							num4++;
						}
						num4++;
					}
					if (ptr2 != ptr4 - num4)
					{
						break;
					}
					if (num <= 127)
					{
						*ptr2 = (byte)num;
					}
					else
					{
						int num5;
						if (num <= 2047)
						{
							num5 = (int)((byte)(-64 | num >> 6));
						}
						else
						{
							if (num <= 65535)
							{
								num5 = (int)((byte)(-32 | num >> 12));
							}
							else
							{
								*ptr2 = (byte)(-16 | num >> 18);
								ptr2++;
								num5 = (-128 | (num >> 12 & 63));
							}
							*ptr2 = (byte)num5;
							ptr2++;
							num5 = (-128 | (num >> 6 & 63));
						}
						*ptr2 = (byte)num5;
						ptr2++;
						*ptr2 = (byte)(-128 | (num & 63));
					}
					ptr2++;
					if (encoderFallbackBuffer != null && (num = (int)encoderFallbackBuffer.InternalGetNextChar()) != 0)
					{
						goto IL_147;
					}
					int num6 = UTF8Encoding.PtrDiff(ptr3, ptr);
					int num7 = UTF8Encoding.PtrDiff(ptr4, ptr2);
					if (num6 <= 13)
					{
						if (num7 >= num6)
						{
							char* ptr6 = ptr3;
							while (ptr < ptr6)
							{
								num = (int)(*ptr);
								ptr++;
								if (num > 127)
								{
									goto IL_147;
								}
								*ptr2 = (byte)num;
								ptr2++;
							}
							goto Block_37;
						}
						num = 0;
					}
					else
					{
						if (num7 < num6)
						{
							num6 = num7;
						}
						char* ptr7 = ptr + num6 - 5;
						while (ptr < ptr7)
						{
							num = (int)(*ptr);
							ptr++;
							if (num <= 127)
							{
								*ptr2 = (byte)num;
								ptr2++;
								if ((ptr & 2) != 0)
								{
									num = (int)(*ptr);
									ptr++;
									if (num > 127)
									{
										goto IL_44F;
									}
									*ptr2 = (byte)num;
									ptr2++;
								}
								while (ptr < ptr7)
								{
									num = *(int*)ptr;
									int num8 = *(int*)(ptr + 2);
									if (((num | num8) & -8323200) == 0)
									{
										if (BitConverter.IsLittleEndian)
										{
											*ptr2 = (byte)num;
											ptr2[1] = (byte)(num >> 16);
											ptr += 4;
											ptr2[2] = (byte)num8;
											ptr2[3] = (byte)(num8 >> 16);
											ptr2 += 4;
										}
										else
										{
											*ptr2 = (byte)(num >> 16);
											ptr2[1] = (byte)num;
											ptr += 4;
											ptr2[2] = (byte)(num8 >> 16);
											ptr2[3] = (byte)num8;
											ptr2 += 4;
										}
									}
									else
									{
										if (BitConverter.IsLittleEndian)
										{
											num = (int)((ushort)num);
										}
										else
										{
											num = (int)((uint)num >> 16);
										}
										ptr++;
										if (num <= 127)
										{
											*ptr2 = (byte)num;
											ptr2++;
											break;
										}
										goto IL_44F;
									}
								}
								continue;
							}
							IL_44F:
							int num9;
							if (num <= 2047)
							{
								num9 = (-64 | num >> 6);
							}
							else
							{
								if (!UTF8Encoding.InRange(num, 55296, 57343))
								{
									num9 = (-32 | num >> 12);
								}
								else
								{
									if (num > 56319)
									{
										ptr--;
										break;
									}
									num9 = (int)(*ptr);
									ptr++;
									if (!UTF8Encoding.InRange(num9, 56320, 57343))
									{
										ptr -= 2;
										break;
									}
									num = num9 + (num << 10) + -56613888;
									*ptr2 = (byte)(-16 | num >> 18);
									ptr2++;
									num9 = (-128 | (num >> 12 & 63));
								}
								*ptr2 = (byte)num9;
								ptr7--;
								ptr2++;
								num9 = (-128 | (num >> 6 & 63));
							}
							*ptr2 = (byte)num9;
							ptr7--;
							ptr2++;
							*ptr2 = (byte)(-128 | (num & 63));
							ptr2++;
						}
						num = 0;
					}
				}
			}
			if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
			{
				encoderFallbackBuffer.MovePrevious();
				if (num > 65535)
				{
					encoderFallbackBuffer.MovePrevious();
				}
			}
			else
			{
				ptr--;
				if (num > 65535)
				{
					ptr--;
				}
			}
			base.ThrowBytesOverflow(utf8Encoder, ptr2 == bytes);
			num = 0;
			goto IL_53C;
			Block_37:
			num = 0;
			IL_53C:
			if (utf8Encoder != null)
			{
				utf8Encoder.surrogateChar = num;
				utf8Encoder._charsUsed = (int)((long)(ptr - chars));
			}
			return (int)((long)(ptr2 - bytes));
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00056628 File Offset: 0x00054828
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			byte* ptr = bytes;
			byte* ptr2 = ptr + count;
			int num = count;
			int num2 = 0;
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			if (baseDecoder != null)
			{
				num2 = ((UTF8Encoding.UTF8Decoder)baseDecoder).bits;
				num -= num2 >> 30;
			}
			IL_23:
			while (ptr < ptr2)
			{
				if (num2 == 0)
				{
					num2 = (int)(*ptr);
					ptr++;
					goto IL_106;
				}
				int num3 = (int)(*ptr);
				ptr++;
				if ((num3 & -64) != 128)
				{
					ptr--;
					num += num2 >> 30;
				}
				else
				{
					num2 = (num2 << 6 | (num3 & 63));
					if ((num2 & 536870912) == 0)
					{
						if ((num2 & 268435456) != 0)
						{
							if ((num2 & 8388608) != 0 || UTF8Encoding.InRange(num2 & 496, 16, 256))
							{
								continue;
							}
						}
						else if ((num2 & 992) != 0)
						{
							if ((num2 & 992) != 864)
							{
								continue;
							}
						}
					}
					else
					{
						if ((num2 & 270467072) == 268435456)
						{
							num--;
							goto IL_17C;
						}
						goto IL_17C;
					}
				}
				IL_C3:
				if (decoderFallbackBuffer == null)
				{
					if (baseDecoder == null)
					{
						decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
					}
					else
					{
						decoderFallbackBuffer = baseDecoder.FallbackBuffer;
					}
					decoderFallbackBuffer.InternalInitialize(bytes, null);
				}
				num += this.FallbackInvalidByteSequence(ptr, num2, decoderFallbackBuffer);
				num2 = 0;
				continue;
				IL_17C:
				int num4 = UTF8Encoding.PtrDiff(ptr2, ptr);
				if (num4 <= 13)
				{
					byte* ptr3 = ptr2;
					while (ptr < ptr3)
					{
						num2 = (int)(*ptr);
						ptr++;
						if (num2 > 127)
						{
							goto IL_106;
						}
					}
					num2 = 0;
					break;
				}
				byte* ptr4 = ptr + num4 - 7;
				while (ptr < ptr4)
				{
					num2 = (int)(*ptr);
					ptr++;
					if (num2 <= 127)
					{
						if ((ptr & 1) != 0)
						{
							num2 = (int)(*ptr);
							ptr++;
							if (num2 > 127)
							{
								goto IL_26F;
							}
						}
						if ((ptr & 2) != 0)
						{
							num2 = (int)(*(ushort*)ptr);
							if ((num2 & 32896) != 0)
							{
								goto IL_24E;
							}
							ptr += 2;
						}
						while (ptr < ptr4)
						{
							num2 = *(int*)ptr;
							int num5 = *(int*)(ptr + 4);
							if (((num2 | num5) & -2139062144) == 0)
							{
								ptr += 8;
								if (ptr >= ptr4)
								{
									break;
								}
								num2 = *(int*)ptr;
								num5 = *(int*)(ptr + 4);
								if (((num2 | num5) & -2139062144) == 0)
								{
									ptr += 8;
									continue;
								}
							}
							if (BitConverter.IsLittleEndian)
							{
								num2 &= 255;
								goto IL_24E;
							}
							num2 = (int)((uint)num2 >> 16);
							goto IL_24E;
						}
						break;
						IL_24E:
						if (BitConverter.IsLittleEndian)
						{
							num2 &= 255;
						}
						else
						{
							num2 = (int)((uint)num2 >> 8);
						}
						ptr++;
						if (num2 <= 127)
						{
							continue;
						}
					}
					IL_26F:
					int num6 = (int)(*ptr);
					ptr++;
					if ((num2 & 64) != 0 && (num6 & -64) == 128)
					{
						num6 &= 63;
						if ((num2 & 32) != 0)
						{
							num6 |= (num2 & 15) << 6;
							if ((num2 & 16) != 0)
							{
								num2 = (int)(*ptr);
								if (!UTF8Encoding.InRange(num6 >> 4, 1, 16) || (num2 & -64) != 128)
								{
									goto IL_33B;
								}
								num6 = (num6 << 6 | (num2 & 63));
								num2 = (int)ptr[1];
								if ((num2 & -64) != 128)
								{
									goto IL_33B;
								}
								ptr += 2;
								num--;
							}
							else
							{
								num2 = (int)(*ptr);
								if ((num6 & 992) == 0 || (num6 & 992) == 864 || (num2 & -64) != 128)
								{
									goto IL_33B;
								}
								ptr++;
								num--;
							}
						}
						else if ((num2 & 30) == 0)
						{
							goto IL_33B;
						}
						num--;
						continue;
					}
					IL_33B:
					ptr -= 2;
					num2 = 0;
					goto IL_23;
				}
				num2 = 0;
				continue;
				IL_106:
				if (num2 <= 127)
				{
					goto IL_17C;
				}
				num--;
				if ((num2 & 64) == 0)
				{
					goto IL_C3;
				}
				if ((num2 & 32) != 0)
				{
					if ((num2 & 16) != 0)
					{
						num2 &= 15;
						if (num2 > 4)
						{
							num2 |= 240;
							goto IL_C3;
						}
						num2 |= 1347226624;
						num--;
					}
					else
					{
						num2 = ((num2 & 15) | 1210220544);
						num--;
					}
				}
				else
				{
					num2 &= 31;
					if (num2 <= 1)
					{
						num2 |= 192;
						goto IL_C3;
					}
					num2 |= 8388608;
				}
			}
			if (num2 != 0)
			{
				num += num2 >> 30;
				if (baseDecoder == null || baseDecoder.MustFlush)
				{
					if (decoderFallbackBuffer == null)
					{
						if (baseDecoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = baseDecoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(bytes, null);
					}
					num += this.FallbackInvalidByteSequence(ptr, num2, decoderFallbackBuffer);
				}
			}
			return num;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000569C8 File Offset: 0x00054BC8
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			byte* ptr = bytes;
			char* ptr2 = chars;
			byte* ptr3 = ptr + byteCount;
			char* ptr4 = ptr2 + charCount;
			int num = 0;
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			if (baseDecoder != null)
			{
				num = ((UTF8Encoding.UTF8Decoder)baseDecoder).bits;
			}
			IL_28:
			while (ptr < ptr3)
			{
				if (num == 0)
				{
					num = (int)(*ptr);
					ptr++;
					goto IL_169;
				}
				int num2 = (int)(*ptr);
				ptr++;
				if ((num2 & -64) != 128)
				{
					ptr--;
				}
				else
				{
					num = (num << 6 | (num2 & 63));
					if ((num & 536870912) == 0)
					{
						if ((num & 268435456) != 0)
						{
							if ((num & 8388608) != 0 || UTF8Encoding.InRange(num & 496, 16, 256))
							{
								continue;
							}
						}
						else if ((num & 992) != 0)
						{
							if ((num & 992) != 864)
							{
								continue;
							}
						}
					}
					else
					{
						if ((num & 270467072) > 268435456 && ptr2 < ptr4)
						{
							*ptr2 = (char)((num >> 10 & 2047) + -10304);
							ptr2++;
							num = (num & 1023) + 56320;
							goto IL_1EA;
						}
						goto IL_1EA;
					}
				}
				IL_F9:
				if (decoderFallbackBuffer == null)
				{
					if (baseDecoder == null)
					{
						decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
					}
					else
					{
						decoderFallbackBuffer = baseDecoder.FallbackBuffer;
					}
					decoderFallbackBuffer.InternalInitialize(bytes, ptr4);
				}
				byte* ptr5 = ptr;
				char* ptr6 = ptr2;
				bool flag = this.FallbackInvalidByteSequence(ref ptr5, num, decoderFallbackBuffer, ref ptr6);
				ptr = ptr5;
				ptr2 = ptr6;
				if (!flag)
				{
					decoderFallbackBuffer.InternalReset();
					base.ThrowCharsOverflow(baseDecoder, ptr2 == chars);
					num = 0;
					break;
				}
				num = 0;
				continue;
				IL_1EA:
				if (ptr2 >= ptr4)
				{
					num &= 2097151;
					if (num > 127)
					{
						if (num > 2047)
						{
							if (num >= 56320 && num <= 57343)
							{
								ptr--;
								ptr2--;
							}
							else if (num > 65535)
							{
								ptr--;
							}
							ptr--;
						}
						ptr--;
					}
					ptr--;
					base.ThrowCharsOverflow(baseDecoder, ptr2 == chars);
					num = 0;
					break;
				}
				*ptr2 = (char)num;
				ptr2++;
				int num3 = UTF8Encoding.PtrDiff(ptr4, ptr2);
				int num4 = UTF8Encoding.PtrDiff(ptr3, ptr);
				if (num4 > 13)
				{
					if (num3 < num4)
					{
						num4 = num3;
					}
					char* ptr7 = ptr2 + num4 - 7;
					while (ptr2 < ptr7)
					{
						num = (int)(*ptr);
						ptr++;
						if (num <= 127)
						{
							*ptr2 = (char)num;
							ptr2++;
							if ((ptr & 1) != 0)
							{
								num = (int)(*ptr);
								ptr++;
								if (num > 127)
								{
									goto IL_4DC;
								}
								*ptr2 = (char)num;
								ptr2++;
							}
							if ((ptr & 2) != 0)
							{
								num = (int)(*(ushort*)ptr);
								if ((num & 32896) != 0)
								{
									goto IL_4AB;
								}
								if (BitConverter.IsLittleEndian)
								{
									*ptr2 = (char)(num & 127);
									ptr += 2;
									ptr2[1] = (char)(num >> 8 & 127);
									ptr2 += 2;
								}
								else
								{
									*ptr2 = (char)(num >> 8 & 127);
									ptr += 2;
									ptr2[1] = (char)(num & 127);
									ptr2 += 2;
								}
							}
							while (ptr2 < ptr7)
							{
								num = *(int*)ptr;
								int num5 = *(int*)(ptr + 4);
								if (((num | num5) & -2139062144) == 0)
								{
									if (BitConverter.IsLittleEndian)
									{
										*ptr2 = (char)(num & 127);
										ptr2[1] = (char)(num >> 8 & 127);
										ptr2[2] = (char)(num >> 16 & 127);
										ptr2[3] = (char)(num >> 24 & 127);
										ptr += 8;
										ptr2[4] = (char)(num5 & 127);
										ptr2[5] = (char)(num5 >> 8 & 127);
										ptr2[6] = (char)(num5 >> 16 & 127);
										ptr2[7] = (char)(num5 >> 24 & 127);
										ptr2 += 8;
									}
									else
									{
										*ptr2 = (char)(num >> 24 & 127);
										ptr2[1] = (char)(num >> 16 & 127);
										ptr2[2] = (char)(num >> 8 & 127);
										ptr2[3] = (char)(num & 127);
										ptr += 8;
										ptr2[4] = (char)(num5 >> 24 & 127);
										ptr2[5] = (char)(num5 >> 16 & 127);
										ptr2[6] = (char)(num5 >> 8 & 127);
										ptr2[7] = (char)(num5 & 127);
										ptr2 += 8;
									}
								}
								else
								{
									if (BitConverter.IsLittleEndian)
									{
										num &= 255;
										goto IL_4AB;
									}
									num = (int)((uint)num >> 16);
									goto IL_4AB;
								}
							}
							break;
							IL_4AB:
							if (BitConverter.IsLittleEndian)
							{
								num &= 255;
							}
							else
							{
								num = (int)((uint)num >> 8);
							}
							ptr++;
							if (num <= 127)
							{
								*ptr2 = (char)num;
								ptr2++;
								continue;
							}
						}
						IL_4DC:
						int num6 = (int)(*ptr);
						ptr++;
						if ((num & 64) != 0 && (num6 & -64) == 128)
						{
							num6 &= 63;
							if ((num & 32) != 0)
							{
								num6 |= (num & 15) << 6;
								if ((num & 16) != 0)
								{
									num = (int)(*ptr);
									if (!UTF8Encoding.InRange(num6 >> 4, 1, 16) || (num & -64) != 128)
									{
										goto IL_61E;
									}
									num6 = (num6 << 6 | (num & 63));
									num = (int)ptr[1];
									if ((num & -64) != 128)
									{
										goto IL_61E;
									}
									ptr += 2;
									num = (num6 << 6 | (num & 63));
									*ptr2 = (char)((num >> 10 & 2047) + -10304);
									ptr2++;
									num = (num & 1023) + -9216;
									ptr7--;
								}
								else
								{
									num = (int)(*ptr);
									if ((num6 & 992) == 0 || (num6 & 992) == 864 || (num & -64) != 128)
									{
										goto IL_61E;
									}
									ptr++;
									num = (num6 << 6 | (num & 63));
									ptr7--;
								}
							}
							else
							{
								num &= 31;
								if (num <= 1)
								{
									goto IL_61E;
								}
								num = (num << 6 | num6);
							}
							*ptr2 = (char)num;
							ptr2++;
							ptr7--;
							continue;
						}
						IL_61E:
						ptr -= 2;
						num = 0;
						goto IL_28;
					}
					num = 0;
					continue;
				}
				if (num3 < num4)
				{
					num = 0;
					continue;
				}
				byte* ptr8 = ptr3;
				while (ptr < ptr8)
				{
					num = (int)(*ptr);
					ptr++;
					if (num > 127)
					{
						goto IL_169;
					}
					*ptr2 = (char)num;
					ptr2++;
				}
				num = 0;
				break;
				IL_169:
				if (num <= 127)
				{
					goto IL_1EA;
				}
				if ((num & 64) == 0)
				{
					goto IL_F9;
				}
				if ((num & 32) != 0)
				{
					if ((num & 16) != 0)
					{
						num &= 15;
						if (num > 4)
						{
							num |= 240;
							goto IL_F9;
						}
						num |= 1347226624;
					}
					else
					{
						num = ((num & 15) | 1210220544);
					}
				}
				else
				{
					num &= 31;
					if (num <= 1)
					{
						num |= 192;
						goto IL_F9;
					}
					num |= 8388608;
				}
			}
			if (num != 0 && (baseDecoder == null || baseDecoder.MustFlush))
			{
				if (decoderFallbackBuffer == null)
				{
					if (baseDecoder == null)
					{
						decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
					}
					else
					{
						decoderFallbackBuffer = baseDecoder.FallbackBuffer;
					}
					decoderFallbackBuffer.InternalInitialize(bytes, ptr4);
				}
				byte* ptr5 = ptr;
				char* ptr6 = ptr2;
				bool flag2 = this.FallbackInvalidByteSequence(ref ptr5, num, decoderFallbackBuffer, ref ptr6);
				ptr = ptr5;
				ptr2 = ptr6;
				if (!flag2)
				{
					decoderFallbackBuffer.InternalReset();
					base.ThrowCharsOverflow(baseDecoder, ptr2 == chars);
				}
				num = 0;
			}
			if (baseDecoder != null)
			{
				((UTF8Encoding.UTF8Decoder)baseDecoder).bits = num;
				baseDecoder._bytesUsed = (int)((long)(ptr - bytes));
			}
			return UTF8Encoding.PtrDiff(ptr2, chars);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00057094 File Offset: 0x00055294
		private unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
		{
			byte* ptr = pSrc;
			byte[] bytesUnknown = this.GetBytesUnknown(ref ptr, ch);
			if (!fallback.InternalFallback(bytesUnknown, pSrc, ref pTarget))
			{
				pSrc = ptr;
				return false;
			}
			return true;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000570C4 File Offset: 0x000552C4
		private unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
		{
			byte[] bytesUnknown = this.GetBytesUnknown(ref pSrc, ch);
			return fallback.InternalFallback(bytesUnknown, pSrc);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000570E4 File Offset: 0x000552E4
		private unsafe byte[] GetBytesUnknown(ref byte* pSrc, int ch)
		{
			byte[] result;
			if (ch < 256 && ch >= 0)
			{
				pSrc--;
				result = new byte[]
				{
					(byte)ch
				};
			}
			else if ((ch & 402653184) == 0)
			{
				pSrc--;
				result = new byte[]
				{
					(byte)((ch & 31) | 192)
				};
			}
			else if ((ch & 268435456) != 0)
			{
				if ((ch & 8388608) != 0)
				{
					pSrc -= 3;
					result = new byte[]
					{
						(byte)((ch >> 12 & 7) | 240),
						(byte)((ch >> 6 & 63) | 128),
						(byte)((ch & 63) | 128)
					};
				}
				else if ((ch & 131072) != 0)
				{
					pSrc -= 2;
					result = new byte[]
					{
						(byte)((ch >> 6 & 7) | 240),
						(byte)((ch & 63) | 128)
					};
				}
				else
				{
					pSrc--;
					result = new byte[]
					{
						(byte)((ch & 7) | 240)
					};
				}
			}
			else if ((ch & 8388608) != 0)
			{
				pSrc -= 2;
				result = new byte[]
				{
					(byte)((ch >> 6 & 15) | 224),
					(byte)((ch & 63) | 128)
				};
			}
			else
			{
				pSrc--;
				result = new byte[]
				{
					(byte)((ch & 15) | 224)
				};
			}
			return result;
		}

		/// <summary>Obtains a decoder that converts a UTF-8 encoded sequence of bytes into a sequence of Unicode characters. </summary>
		/// <returns>A decoder that converts a UTF-8 encoded sequence of bytes into a sequence of Unicode characters.</returns>
		// Token: 0x0600156B RID: 5483 RVA: 0x00057237 File Offset: 0x00055437
		public override Decoder GetDecoder()
		{
			return new UTF8Encoding.UTF8Decoder(this);
		}

		/// <summary>Obtains an encoder that converts a sequence of Unicode characters into a UTF-8 encoded sequence of bytes.</summary>
		/// <returns>A <see cref="T:System.Text.Encoder" /> that converts a sequence of Unicode characters into a UTF-8 encoded sequence of bytes.</returns>
		// Token: 0x0600156C RID: 5484 RVA: 0x0005723F File Offset: 0x0005543F
		public override Encoder GetEncoder()
		{
			return new UTF8Encoding.UTF8Encoder(this);
		}

		/// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x0600156D RID: 5485 RVA: 0x00057248 File Offset: 0x00055448
		public override int GetMaxByteCount(int charCount)
		{
			if (charCount < 0)
			{
				throw new ArgumentOutOfRangeException("charCount", "Non-negative number required.");
			}
			long num = (long)charCount + 1L;
			if (base.EncoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.EncoderFallback.MaxCharCount;
			}
			num *= 3L;
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
		///         <paramref name="byteCount" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600156E RID: 5486 RVA: 0x000572AC File Offset: 0x000554AC
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			long num = (long)byteCount + 1L;
			if (base.DecoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.DecoderFallback.MaxCharCount;
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Too many bytes. The resulting number of chars is larger than what can be returned as an int.");
			}
			return (int)num;
		}

		/// <summary>Returns a Unicode byte order mark encoded in UTF-8 format, if the <see cref="T:System.Text.UTF8Encoding" /> encoding object is configured to supply one. </summary>
		/// <returns>A byte array containing the Unicode byte order mark, if the <see cref="T:System.Text.UTF8Encoding" /> encoding object is configured to supply one. Otherwise, this method returns a zero-length byte array. </returns>
		// Token: 0x0600156F RID: 5487 RVA: 0x0005730B File Offset: 0x0005550B
		public override byte[] GetPreamble()
		{
			if (this._emitUTF8Identifier)
			{
				return new byte[]
				{
					239,
					187,
					191
				};
			}
			return Array.Empty<byte>();
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0005732C File Offset: 0x0005552C
		public override ReadOnlySpan<byte> Preamble
		{
			get
			{
				return (base.GetType() != typeof(UTF8Encoding)) ? this.GetPreamble() : (this._emitUTF8Identifier ? UTF8Encoding.s_preamble : Array.Empty<byte>());
			}
		}

		/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Text.UTF8Encoding" /> object.</summary>
		/// <param name="value">The object to compare with the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.Text.UTF8Encoding" /> and is equal to the current object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001571 RID: 5489 RVA: 0x00057368 File Offset: 0x00055568
		public override bool Equals(object value)
		{
			UTF8Encoding utf8Encoding = value as UTF8Encoding;
			return utf8Encoding != null && (this._emitUTF8Identifier == utf8Encoding._emitUTF8Identifier && base.EncoderFallback.Equals(utf8Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf8Encoding.DecoderFallback);
		}

		/// <summary>Returns the hash code for the current instance.</summary>
		/// <returns>The hash code for the current instance.</returns>
		// Token: 0x06001572 RID: 5490 RVA: 0x000573B5 File Offset: 0x000555B5
		public override int GetHashCode()
		{
			return base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + 65001 + (this._emitUTF8Identifier ? 1 : 0);
		}

		// Token: 0x0400085F RID: 2143
		internal static readonly UTF8Encoding.UTF8EncodingSealed s_default = new UTF8Encoding.UTF8EncodingSealed(true);

		// Token: 0x04000860 RID: 2144
		internal static readonly byte[] s_preamble = new byte[]
		{
			239,
			187,
			191
		};

		// Token: 0x04000861 RID: 2145
		internal readonly bool _emitUTF8Identifier;

		// Token: 0x04000862 RID: 2146
		private bool _isThrowException;

		// Token: 0x02000267 RID: 615
		internal sealed class UTF8EncodingSealed : UTF8Encoding
		{
			// Token: 0x06001574 RID: 5492 RVA: 0x00057404 File Offset: 0x00055604
			public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) : base(encoderShouldEmitUTF8Identifier)
			{
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x06001575 RID: 5493 RVA: 0x0005740D File Offset: 0x0005560D
			public override ReadOnlySpan<byte> Preamble
			{
				get
				{
					return this._emitUTF8Identifier ? UTF8Encoding.s_preamble : Array.Empty<byte>();
				}
			}
		}

		// Token: 0x02000268 RID: 616
		[Serializable]
		private sealed class UTF8Encoder : EncoderNLS
		{
			// Token: 0x06001576 RID: 5494 RVA: 0x000555B5 File Offset: 0x000537B5
			public UTF8Encoder(UTF8Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06001577 RID: 5495 RVA: 0x00057428 File Offset: 0x00055628
			public override void Reset()
			{
				this.surrogateChar = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x06001578 RID: 5496 RVA: 0x00057444 File Offset: 0x00055644
			internal override bool HasState
			{
				get
				{
					return this.surrogateChar != 0;
				}
			}

			// Token: 0x04000863 RID: 2147
			internal int surrogateChar;
		}

		// Token: 0x02000269 RID: 617
		[Serializable]
		private sealed class UTF8Decoder : DecoderNLS
		{
			// Token: 0x06001579 RID: 5497 RVA: 0x00054ACB File Offset: 0x00052CCB
			public UTF8Decoder(UTF8Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x0600157A RID: 5498 RVA: 0x0005744F File Offset: 0x0005564F
			public override void Reset()
			{
				this.bits = 0;
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x0600157B RID: 5499 RVA: 0x0005746B File Offset: 0x0005566B
			internal override bool HasState
			{
				get
				{
					return this.bits != 0;
				}
			}

			// Token: 0x04000864 RID: 2148
			internal int bits;
		}
	}
}
