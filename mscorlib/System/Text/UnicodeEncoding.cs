﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	/// <summary>Represents a UTF-16 encoding of Unicode characters. </summary>
	// Token: 0x0200026A RID: 618
	[Serializable]
	public class UnicodeEncoding : Encoding
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UnicodeEncoding" /> class.</summary>
		// Token: 0x0600157C RID: 5500 RVA: 0x00057476 File Offset: 0x00055676
		public UnicodeEncoding() : this(false, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UnicodeEncoding" /> class. Parameters specify whether to use the big endian byte order and whether the <see cref="M:System.Text.UnicodeEncoding.GetPreamble" /> method returns a Unicode byte order mark. </summary>
		/// <param name="bigEndian">
		///       <see langword="true" /> to use the big endian byte order (most significant byte first), or <see langword="false" /> to use the little endian byte order (least significant byte first). </param>
		/// <param name="byteOrderMark">
		///       <see langword="true" /> to specify that the <see cref="M:System.Text.UnicodeEncoding.GetPreamble" /> method returns a Unicode byte order mark; otherwise, <see langword="false" />. See the Remarks section for more information. </param>
		// Token: 0x0600157D RID: 5501 RVA: 0x00057480 File Offset: 0x00055680
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark) : this(bigEndian, byteOrderMark, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.UnicodeEncoding" /> class. Parameters specify whether to use the big endian byte order, whether to provide a Unicode byte order mark, and whether to throw an exception when an invalid encoding is detected.</summary>
		/// <param name="bigEndian">
		///       <see langword="true" /> to use the big endian byte order (most significant byte first); <see langword="false" /> to use the little endian byte order (least significant byte first). </param>
		/// <param name="byteOrderMark">
		///       <see langword="true" /> to specify that the <see cref="M:System.Text.UnicodeEncoding.GetPreamble" /> method returns a Unicode byte order mark; otherwise, <see langword="false" />. See the Remarks section for more information. </param>
		/// <param name="throwOnInvalidBytes">
		///       <see langword="true" /> to specify that an exception should be thrown when an invalid encoding is detected; otherwise, <see langword="false" />. </param>
		// Token: 0x0600157E RID: 5502 RVA: 0x0005748C File Offset: 0x0005568C
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) : base(bigEndian ? 1201 : 1200)
		{
			this.isThrowException = throwOnInvalidBytes;
			this.bigEndian = bigEndian;
			this.byteOrderMark = byteOrderMark;
			if (this.isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000574D8 File Offset: 0x000556D8
		internal override void SetDefaultFallbacks()
		{
			if (this.isThrowException)
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
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001580 RID: 5504 RVA: 0x00057524 File Offset: 0x00055724
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

		/// <summary>Calculates the number of bytes produced by encoding the characters in the specified string.</summary>
		/// <param name="s">The string that contains the set of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null " />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="s" /> contains an invalid sequence of characters. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001581 RID: 5505 RVA: 0x000575AC File Offset: 0x000557AC
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
		///         <paramref name="chars" /> is <see langword="null " />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled and <paramref name="chars" /> contains an invalid sequence of characters. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001582 RID: 5506 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
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
		/// <param name="s">The string containing the set of characters to encode. </param>
		/// <param name="charIndex">The index of the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
		/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
		/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null " />.-or- 
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="s" /> contains an invalid sequence of characters.-or- 
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001583 RID: 5507 RVA: 0x000575E8 File Offset: 0x000557E8
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
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.-or- 
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001584 RID: 5508 RVA: 0x000576B0 File Offset: 0x000558B0
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
		/// <returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.-or- 
		///         <paramref name="byteCount" /> is less than the resulting number of bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001585 RID: 5509 RVA: 0x00057780 File Offset: 0x00055980
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
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001586 RID: 5510 RVA: 0x000577E4 File Offset: 0x000559E4
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
		///         <paramref name="count" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001587 RID: 5511 RVA: 0x0004ED6F File Offset: 0x0004CF6F
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
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.-or- 
		///         <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001588 RID: 5512 RVA: 0x00057868 File Offset: 0x00055A68
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
		/// <returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />).-or- 
		///         <paramref name="chars" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.-or- 
		///         <paramref name="charCount" /> is less than the resulting number of characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001589 RID: 5513 RVA: 0x00057938 File Offset: 0x00055B38
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
		/// <returns>A <see cref="T:System.String" /> object containing the results of decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null " />(<see langword="Nothing" />). </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x0600158A RID: 5514 RVA: 0x0005799C File Offset: 0x00055B9C
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

		// Token: 0x0600158B RID: 5515 RVA: 0x00057A24 File Offset: 0x00055C24
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			int num = count << 1;
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Too many characters. The resulting number of bytes is larger than what can be returned as an int.");
			}
			char* charStart = chars;
			char* ptr = chars + count;
			char c = '\0';
			bool flag = false;
			ulong* ptr2 = (ulong*)(ptr - 3);
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				if (c > '\0')
				{
					num += 2;
				}
				if (encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
				}
			}
			for (;;)
			{
				char c2;
				char* ptr4;
				if ((c2 = ((encoderFallbackBuffer == null) ? '\0' : encoderFallbackBuffer.InternalGetNextChar())) != '\0' || chars < ptr)
				{
					if (c2 == '\0')
					{
						if ((this.bigEndian ^ BitConverter.IsLittleEndian) && c == '\0' && (chars & 7L) == null)
						{
							ulong* ptr3;
							for (ptr3 = (ulong*)chars; ptr3 < ptr2; ptr3++)
							{
								if ((9223512776490647552UL & *ptr3) != 0UL)
								{
									ulong num2 = (17870556004450629632UL & *ptr3) ^ 15564677810327967744UL;
									if (((num2 & 18446462598732840960UL) == 0UL || (num2 & 281470681743360UL) == 0UL || (num2 & (ulong)-65536) == 0UL || (num2 & 65535UL) == 0UL) && ((18158790778715962368UL & *ptr3) ^ UnicodeEncoding.highLowPatternMask) != 0UL)
									{
										break;
									}
								}
							}
							chars = (char*)ptr3;
							if (chars >= ptr)
							{
								goto IL_27E;
							}
						}
						c2 = *chars;
						chars++;
					}
					else
					{
						num += 2;
					}
					if (c2 >= '\ud800' && c2 <= '\udfff')
					{
						if (c2 <= '\udbff')
						{
							if (c > '\0')
							{
								chars--;
								num -= 2;
								if (encoderFallbackBuffer == null)
								{
									if (encoder == null)
									{
										encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
									}
									else
									{
										encoderFallbackBuffer = encoder.FallbackBuffer;
									}
									encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
								}
								ptr4 = chars;
								encoderFallbackBuffer.InternalFallback(c, ref ptr4);
								chars = ptr4;
								c = '\0';
								continue;
							}
							c = c2;
							continue;
						}
						else
						{
							if (c == '\0')
							{
								num -= 2;
								if (encoderFallbackBuffer == null)
								{
									if (encoder == null)
									{
										encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
									}
									else
									{
										encoderFallbackBuffer = encoder.FallbackBuffer;
									}
									encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
								}
								ptr4 = chars;
								encoderFallbackBuffer.InternalFallback(c2, ref ptr4);
								chars = ptr4;
								continue;
							}
							c = '\0';
							continue;
						}
					}
					else
					{
						if (c > '\0')
						{
							chars--;
							if (encoderFallbackBuffer == null)
							{
								if (encoder == null)
								{
									encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
								}
								else
								{
									encoderFallbackBuffer = encoder.FallbackBuffer;
								}
								encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
							}
							ptr4 = chars;
							encoderFallbackBuffer.InternalFallback(c, ref ptr4);
							chars = ptr4;
							num -= 2;
							c = '\0';
							continue;
						}
						continue;
					}
				}
				IL_27E:
				if (c <= '\0')
				{
					return num;
				}
				num -= 2;
				if (encoder != null && !encoder.MustFlush)
				{
					return num;
				}
				if (flag)
				{
					break;
				}
				if (encoderFallbackBuffer == null)
				{
					if (encoder == null)
					{
						encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
					}
					else
					{
						encoderFallbackBuffer = encoder.FallbackBuffer;
					}
					encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
				}
				ptr4 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr4);
				chars = ptr4;
				c = '\0';
				flag = true;
			}
			throw new ArgumentException(SR.Format("Recursive fallback not allowed for character \\\\u{0:X4}.", c), "chars");
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00057D28 File Offset: 0x00055F28
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			char c = '\0';
			bool flag = false;
			byte* ptr = bytes + byteCount;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			char* ptr4 = chars;
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				if (encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0 && encoder._throwOnOverflow)
					{
						throw new ArgumentException(SR.Format("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", this.EncodingName, encoder.Fallback.GetType()));
					}
					encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, false);
				}
			}
			for (;;)
			{
				char c2;
				char* ptr10;
				if ((c2 = ((encoderFallbackBuffer == null) ? '\0' : encoderFallbackBuffer.InternalGetNextChar())) != '\0' || chars < ptr2)
				{
					if (c2 == '\0')
					{
						if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (chars & 7L) == null && (bytes & 7L) == null && c == '\0')
						{
							ulong* ptr5 = (ulong*)(chars - 3 + (((long)(ptr - bytes) >> 1 < (long)(ptr2 - chars)) ? ((long)(ptr - bytes) >> 1) : ((long)(ptr2 - chars))) * 2L / 8L);
							ulong* ptr6 = (ulong*)chars;
							ulong* ptr7 = (ulong*)bytes;
							while (ptr6 < ptr5)
							{
								if ((9223512776490647552UL & *ptr6) != 0UL)
								{
									ulong num = (17870556004450629632UL & *ptr6) ^ 15564677810327967744UL;
									if (((num & 18446462598732840960UL) == 0UL || (num & 281470681743360UL) == 0UL || (num & (ulong)-65536) == 0UL || (num & 65535UL) == 0UL) && ((18158790778715962368UL & *ptr6) ^ UnicodeEncoding.highLowPatternMask) != 0UL)
									{
										break;
									}
								}
								*ptr7 = *ptr6;
								ptr6++;
								ptr7++;
							}
							chars = (char*)ptr6;
							bytes = (byte*)ptr7;
							if (chars >= ptr2)
							{
								goto IL_488;
							}
						}
						else if (c == '\0' && (this.bigEndian ^ BitConverter.IsLittleEndian) && ((byte*)chars & 7L) != (bytes & 7L) && (bytes & 1) == 0)
						{
							long num2 = ((long)(ptr - bytes) >> 1 < (long)(ptr2 - chars)) ? ((long)(ptr - bytes) >> 1) : ((long)(ptr2 - chars));
							char* ptr8 = (char*)bytes;
							char* ptr9 = chars + num2 * 2L / 2L - 1;
							while (chars < ptr9)
							{
								if (*chars >= '\ud800' && *chars <= '\udfff')
								{
									if (*chars >= '\udc00' || chars[1] < '\udc00')
									{
										break;
									}
									if (chars[1] > '\udfff')
									{
										break;
									}
								}
								else if (chars[1] >= '\ud800' && chars[1] <= '\udfff')
								{
									*ptr8 = *chars;
									ptr8++;
									chars++;
									continue;
								}
								*ptr8 = *chars;
								ptr8[1] = chars[1];
								ptr8 += 2;
								chars += 2;
							}
							bytes = (byte*)ptr8;
							if (chars >= ptr2)
							{
								goto IL_488;
							}
						}
						c2 = *chars;
						chars++;
					}
					if (c2 >= '\ud800' && c2 <= '\udfff')
					{
						if (c2 <= '\udbff')
						{
							if (c > '\0')
							{
								chars--;
								if (encoderFallbackBuffer == null)
								{
									if (encoder == null)
									{
										encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
									}
									else
									{
										encoderFallbackBuffer = encoder.FallbackBuffer;
									}
									encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
								}
								ptr10 = chars;
								encoderFallbackBuffer.InternalFallback(c, ref ptr10);
								chars = ptr10;
								c = '\0';
								continue;
							}
							c = c2;
							continue;
						}
						else
						{
							if (c == '\0')
							{
								if (encoderFallbackBuffer == null)
								{
									if (encoder == null)
									{
										encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
									}
									else
									{
										encoderFallbackBuffer = encoder.FallbackBuffer;
									}
									encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
								}
								ptr10 = chars;
								encoderFallbackBuffer.InternalFallback(c2, ref ptr10);
								chars = ptr10;
								continue;
							}
							if (bytes + 3 >= ptr)
							{
								if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
								{
									encoderFallbackBuffer.MovePrevious();
									encoderFallbackBuffer.MovePrevious();
								}
								else
								{
									chars -= 2;
								}
								base.ThrowBytesOverflow(encoder, bytes == ptr3);
								c = '\0';
								goto IL_488;
							}
							if (this.bigEndian)
							{
								*(bytes++) = (byte)(c >> 8);
								*(bytes++) = (byte)c;
							}
							else
							{
								*(bytes++) = (byte)c;
								*(bytes++) = (byte)(c >> 8);
							}
							c = '\0';
						}
					}
					else if (c > '\0')
					{
						chars--;
						if (encoderFallbackBuffer == null)
						{
							if (encoder == null)
							{
								encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
							}
							else
							{
								encoderFallbackBuffer = encoder.FallbackBuffer;
							}
							encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
						}
						ptr10 = chars;
						encoderFallbackBuffer.InternalFallback(c, ref ptr10);
						chars = ptr10;
						c = '\0';
						continue;
					}
					if (bytes + 1 >= ptr)
					{
						if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
						{
							encoderFallbackBuffer.MovePrevious();
						}
						else
						{
							chars--;
						}
						base.ThrowBytesOverflow(encoder, bytes == ptr3);
					}
					else
					{
						if (this.bigEndian)
						{
							*(bytes++) = (byte)(c2 >> 8);
							*(bytes++) = (byte)c2;
							continue;
						}
						*(bytes++) = (byte)c2;
						*(bytes++) = (byte)(c2 >> 8);
						continue;
					}
				}
				IL_488:
				if (c <= '\0' || (encoder != null && !encoder.MustFlush))
				{
					goto IL_500;
				}
				if (flag)
				{
					break;
				}
				if (encoderFallbackBuffer == null)
				{
					if (encoder == null)
					{
						encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
					}
					else
					{
						encoderFallbackBuffer = encoder.FallbackBuffer;
					}
					encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
				}
				ptr10 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr10);
				chars = ptr10;
				c = '\0';
				flag = true;
			}
			throw new ArgumentException(SR.Format("Recursive fallback not allowed for character \\\\u{0:X4}.", c), "chars");
			IL_500:
			if (encoder != null)
			{
				encoder._charLeftOver = c;
				encoder._charsUsed = (int)((long)(chars - ptr4));
			}
			return (int)((long)(bytes - ptr3));
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00058258 File Offset: 0x00056458
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			UnicodeEncoding.Decoder decoder = (UnicodeEncoding.Decoder)baseDecoder;
			byte* ptr = bytes + count;
			byte* byteStart = bytes;
			int num = -1;
			char c = '\0';
			int num2 = count >> 1;
			ulong* ptr2 = (ulong*)(ptr - 7);
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			if (decoder != null)
			{
				num = decoder.lastByte;
				c = decoder.lastChar;
				if (c > '\0')
				{
					num2++;
				}
				if (num >= 0 && (count & 1) == 1)
				{
					num2++;
				}
			}
			while (bytes < ptr)
			{
				if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (bytes & 7L) == null && num == -1 && c == '\0')
				{
					ulong* ptr3;
					for (ptr3 = (ulong*)bytes; ptr3 < ptr2; ptr3++)
					{
						if ((9223512776490647552UL & *ptr3) != 0UL)
						{
							ulong num3 = (17870556004450629632UL & *ptr3) ^ 15564677810327967744UL;
							if (((num3 & 18446462598732840960UL) == 0UL || (num3 & 281470681743360UL) == 0UL || (num3 & (ulong)-65536) == 0UL || (num3 & 65535UL) == 0UL) && ((18158790778715962368UL & *ptr3) ^ UnicodeEncoding.highLowPatternMask) != 0UL)
							{
								break;
							}
						}
					}
					bytes = (byte*)ptr3;
					if (bytes >= ptr)
					{
						break;
					}
				}
				if (num < 0)
				{
					num = (int)(*(bytes++));
					if (bytes >= ptr)
					{
						break;
					}
				}
				char c2;
				if (this.bigEndian)
				{
					c2 = (char)(num << 8 | (int)(*(bytes++)));
				}
				else
				{
					c2 = (char)((int)(*(bytes++)) << 8 | num);
				}
				num = -1;
				if (c2 >= '\ud800' && c2 <= '\udfff')
				{
					if (c2 <= '\udbff')
					{
						if (c > '\0')
						{
							num2--;
							byte[] bytes2;
							if (this.bigEndian)
							{
								bytes2 = new byte[]
								{
									(byte)(c >> 8),
									(byte)c
								};
							}
							else
							{
								bytes2 = new byte[]
								{
									(byte)c,
									(byte)(c >> 8)
								};
							}
							if (decoderFallbackBuffer == null)
							{
								if (decoder == null)
								{
									decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
								}
								else
								{
									decoderFallbackBuffer = decoder.FallbackBuffer;
								}
								decoderFallbackBuffer.InternalInitialize(byteStart, null);
							}
							num2 += decoderFallbackBuffer.InternalFallback(bytes2, bytes);
						}
						c = c2;
					}
					else if (c == '\0')
					{
						num2--;
						byte[] bytes3;
						if (this.bigEndian)
						{
							bytes3 = new byte[]
							{
								(byte)(c2 >> 8),
								(byte)c2
							};
						}
						else
						{
							bytes3 = new byte[]
							{
								(byte)c2,
								(byte)(c2 >> 8)
							};
						}
						if (decoderFallbackBuffer == null)
						{
							if (decoder == null)
							{
								decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
							}
							else
							{
								decoderFallbackBuffer = decoder.FallbackBuffer;
							}
							decoderFallbackBuffer.InternalInitialize(byteStart, null);
						}
						num2 += decoderFallbackBuffer.InternalFallback(bytes3, bytes);
					}
					else
					{
						c = '\0';
					}
				}
				else if (c > '\0')
				{
					num2--;
					byte[] bytes4;
					if (this.bigEndian)
					{
						bytes4 = new byte[]
						{
							(byte)(c >> 8),
							(byte)c
						};
					}
					else
					{
						bytes4 = new byte[]
						{
							(byte)c,
							(byte)(c >> 8)
						};
					}
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(byteStart, null);
					}
					num2 += decoderFallbackBuffer.InternalFallback(bytes4, bytes);
					c = '\0';
				}
			}
			if (decoder == null || decoder.MustFlush)
			{
				if (c > '\0')
				{
					num2--;
					byte[] bytes5;
					if (this.bigEndian)
					{
						bytes5 = new byte[]
						{
							(byte)(c >> 8),
							(byte)c
						};
					}
					else
					{
						bytes5 = new byte[]
						{
							(byte)c,
							(byte)(c >> 8)
						};
					}
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(byteStart, null);
					}
					num2 += decoderFallbackBuffer.InternalFallback(bytes5, bytes);
					c = '\0';
				}
				if (num >= 0)
				{
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(byteStart, null);
					}
					num2 += decoderFallbackBuffer.InternalFallback(new byte[]
					{
						(byte)num
					}, bytes);
				}
			}
			if (c > '\0')
			{
				num2--;
			}
			return num2;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00058640 File Offset: 0x00056840
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UnicodeEncoding.Decoder decoder = (UnicodeEncoding.Decoder)baseDecoder;
			int num = -1;
			char c = '\0';
			if (decoder != null)
			{
				num = decoder.lastByte;
				c = decoder.lastChar;
			}
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			byte* ptr = bytes + byteCount;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			char* ptr4 = chars;
			while (bytes < ptr)
			{
				if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (chars & 7L) == null && (bytes & 7L) == null && num == -1 && c == '\0')
				{
					ulong* ptr5 = (ulong*)(bytes - 7 + (IntPtr)(((long)(ptr - bytes) >> 1 < (long)(ptr2 - chars)) ? ((long)(ptr - bytes)) : ((long)(ptr2 - chars) << 1)) / 8);
					ulong* ptr6 = (ulong*)bytes;
					ulong* ptr7 = (ulong*)chars;
					while (ptr6 < ptr5)
					{
						if ((9223512776490647552UL & *ptr6) != 0UL)
						{
							ulong num2 = (17870556004450629632UL & *ptr6) ^ 15564677810327967744UL;
							if (((num2 & 18446462598732840960UL) == 0UL || (num2 & 281470681743360UL) == 0UL || (num2 & (ulong)-65536) == 0UL || (num2 & 65535UL) == 0UL) && ((18158790778715962368UL & *ptr6) ^ UnicodeEncoding.highLowPatternMask) != 0UL)
							{
								break;
							}
						}
						*ptr7 = *ptr6;
						ptr6++;
						ptr7++;
					}
					chars = (char*)ptr7;
					bytes = (byte*)ptr6;
					if (bytes >= ptr)
					{
						break;
					}
				}
				if (num < 0)
				{
					num = (int)(*(bytes++));
				}
				else
				{
					char c2;
					if (this.bigEndian)
					{
						c2 = (char)(num << 8 | (int)(*(bytes++)));
					}
					else
					{
						c2 = (char)((int)(*(bytes++)) << 8 | num);
					}
					num = -1;
					if (c2 >= '\ud800' && c2 <= '\udfff')
					{
						if (c2 <= '\udbff')
						{
							if (c > '\0')
							{
								byte[] bytes2;
								if (this.bigEndian)
								{
									bytes2 = new byte[]
									{
										(byte)(c >> 8),
										(byte)c
									};
								}
								else
								{
									bytes2 = new byte[]
									{
										(byte)c,
										(byte)(c >> 8)
									};
								}
								if (decoderFallbackBuffer == null)
								{
									if (decoder == null)
									{
										decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
									}
									else
									{
										decoderFallbackBuffer = decoder.FallbackBuffer;
									}
									decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
								}
								char* ptr8 = chars;
								bool flag = decoderFallbackBuffer.InternalFallback(bytes2, bytes, ref ptr8);
								chars = ptr8;
								if (!flag)
								{
									bytes -= 2;
									decoderFallbackBuffer.InternalReset();
									base.ThrowCharsOverflow(decoder, chars == ptr4);
									break;
								}
							}
							c = c2;
							continue;
						}
						if (c == '\0')
						{
							byte[] bytes3;
							if (this.bigEndian)
							{
								bytes3 = new byte[]
								{
									(byte)(c2 >> 8),
									(byte)c2
								};
							}
							else
							{
								bytes3 = new byte[]
								{
									(byte)c2,
									(byte)(c2 >> 8)
								};
							}
							if (decoderFallbackBuffer == null)
							{
								if (decoder == null)
								{
									decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
								}
								else
								{
									decoderFallbackBuffer = decoder.FallbackBuffer;
								}
								decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
							}
							char* ptr8 = chars;
							bool flag2 = decoderFallbackBuffer.InternalFallback(bytes3, bytes, ref ptr8);
							chars = ptr8;
							if (!flag2)
							{
								bytes -= 2;
								decoderFallbackBuffer.InternalReset();
								base.ThrowCharsOverflow(decoder, chars == ptr4);
								break;
							}
							continue;
						}
						else
						{
							if (chars >= ptr2 - 1)
							{
								bytes -= 2;
								base.ThrowCharsOverflow(decoder, chars == ptr4);
								break;
							}
							*(chars++) = c;
							c = '\0';
						}
					}
					else if (c > '\0')
					{
						byte[] bytes4;
						if (this.bigEndian)
						{
							bytes4 = new byte[]
							{
								(byte)(c >> 8),
								(byte)c
							};
						}
						else
						{
							bytes4 = new byte[]
							{
								(byte)c,
								(byte)(c >> 8)
							};
						}
						if (decoderFallbackBuffer == null)
						{
							if (decoder == null)
							{
								decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
							}
							else
							{
								decoderFallbackBuffer = decoder.FallbackBuffer;
							}
							decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
						}
						char* ptr8 = chars;
						bool flag3 = decoderFallbackBuffer.InternalFallback(bytes4, bytes, ref ptr8);
						chars = ptr8;
						if (!flag3)
						{
							bytes -= 2;
							decoderFallbackBuffer.InternalReset();
							base.ThrowCharsOverflow(decoder, chars == ptr4);
							break;
						}
						c = '\0';
					}
					if (chars >= ptr2)
					{
						bytes -= 2;
						base.ThrowCharsOverflow(decoder, chars == ptr4);
						break;
					}
					*(chars++) = c2;
				}
			}
			if (decoder == null || decoder.MustFlush)
			{
				if (c > '\0')
				{
					byte[] bytes5;
					if (this.bigEndian)
					{
						bytes5 = new byte[]
						{
							(byte)(c >> 8),
							(byte)c
						};
					}
					else
					{
						bytes5 = new byte[]
						{
							(byte)c,
							(byte)(c >> 8)
						};
					}
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
					}
					char* ptr8 = chars;
					bool flag4 = decoderFallbackBuffer.InternalFallback(bytes5, bytes, ref ptr8);
					chars = ptr8;
					if (!flag4)
					{
						bytes -= 2;
						if (num >= 0)
						{
							bytes--;
						}
						decoderFallbackBuffer.InternalReset();
						base.ThrowCharsOverflow(decoder, chars == ptr4);
						bytes += 2;
						if (num >= 0)
						{
							bytes++;
							goto IL_4C7;
						}
						goto IL_4C7;
					}
					else
					{
						c = '\0';
					}
				}
				if (num >= 0)
				{
					if (decoderFallbackBuffer == null)
					{
						if (decoder == null)
						{
							decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
						}
						else
						{
							decoderFallbackBuffer = decoder.FallbackBuffer;
						}
						decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
					}
					char* ptr8 = chars;
					bool flag5 = decoderFallbackBuffer.InternalFallback(new byte[]
					{
						(byte)num
					}, bytes, ref ptr8);
					chars = ptr8;
					if (!flag5)
					{
						bytes--;
						decoderFallbackBuffer.InternalReset();
						base.ThrowCharsOverflow(decoder, chars == ptr4);
						bytes++;
					}
					else
					{
						num = -1;
					}
				}
			}
			IL_4C7:
			if (decoder != null)
			{
				decoder._bytesUsed = (int)((long)(bytes - ptr3));
				decoder.lastChar = c;
				decoder.lastByte = num;
			}
			return (int)((long)(chars - ptr4));
		}

		/// <summary>Obtains an encoder that converts a sequence of Unicode characters into a UTF-16 encoded sequence of bytes.</summary>
		/// <returns>A <see cref="T:System.Text.Encoder" /> object that converts a sequence of Unicode characters into a UTF-16 encoded sequence of bytes.</returns>
		// Token: 0x0600158F RID: 5519 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		/// <summary>Obtains a decoder that converts a UTF-16 encoded sequence of bytes into a sequence of Unicode characters.</summary>
		/// <returns>A <see cref="T:System.Text.Decoder" /> that converts a UTF-16 encoded sequence of bytes into a sequence of Unicode characters.</returns>
		// Token: 0x06001590 RID: 5520 RVA: 0x00058B3B File Offset: 0x00056D3B
		public override System.Text.Decoder GetDecoder()
		{
			return new UnicodeEncoding.Decoder(this);
		}

		/// <summary>Returns a Unicode byte order mark encoded in UTF-16 format, if the constructor for this instance requests a byte order mark.</summary>
		/// <returns>A byte array containing the Unicode byte order mark, if the <see cref="T:System.Text.UnicodeEncoding" /> object is configured to supply one. Otherwise, this method returns a zero-length byte array. </returns>
		// Token: 0x06001591 RID: 5521 RVA: 0x00058B44 File Offset: 0x00056D44
		public override byte[] GetPreamble()
		{
			if (!this.byteOrderMark)
			{
				return Array.Empty<byte>();
			}
			if (this.bigEndian)
			{
				return new byte[]
				{
					254,
					byte.MaxValue
				};
			}
			return new byte[]
			{
				byte.MaxValue,
				254
			};
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00058B94 File Offset: 0x00056D94
		public override ReadOnlySpan<byte> Preamble
		{
			get
			{
				return (base.GetType() != typeof(UnicodeEncoding)) ? this.GetPreamble() : (this.byteOrderMark ? (this.bigEndian ? UnicodeEncoding.s_bigEndianPreamble : UnicodeEncoding.s_littleEndianPreamble) : Array.Empty<byte>());
			}
		}

		/// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> is less than zero.-or- The resulting number of bytes is greater than the maximum number that can be returned as an integer. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x06001593 RID: 5523 RVA: 0x00058BE8 File Offset: 0x00056DE8
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
			num <<= 1;
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
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x06001594 RID: 5524 RVA: 0x00058C4C File Offset: 0x00056E4C
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", "Non-negative number required.");
			}
			long num = (long)(byteCount >> 1) + (long)(byteCount & 1) + 1L;
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

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Text.UnicodeEncoding" /> object.</summary>
		/// <param name="value">The object to compare with the current object. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.Text.UnicodeEncoding" /> and is equal to the current object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001595 RID: 5525 RVA: 0x00058CB4 File Offset: 0x00056EB4
		public override bool Equals(object value)
		{
			UnicodeEncoding unicodeEncoding = value as UnicodeEncoding;
			return unicodeEncoding != null && (this.CodePage == unicodeEncoding.CodePage && this.byteOrderMark == unicodeEncoding.byteOrderMark && this.bigEndian == unicodeEncoding.bigEndian && base.EncoderFallback.Equals(unicodeEncoding.EncoderFallback)) && base.DecoderFallback.Equals(unicodeEncoding.DecoderFallback);
		}

		/// <summary>Returns the hash code for the current instance.</summary>
		/// <returns>The hash code for the current <see cref="T:System.Text.UnicodeEncoding" /> object.</returns>
		// Token: 0x06001596 RID: 5526 RVA: 0x00058D1D File Offset: 0x00056F1D
		public override int GetHashCode()
		{
			return this.CodePage + base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + (this.byteOrderMark ? 4 : 0) + (this.bigEndian ? 8 : 0);
		}

		// Token: 0x04000865 RID: 2149
		internal static readonly UnicodeEncoding s_bigEndianDefault = new UnicodeEncoding(true, true);

		// Token: 0x04000866 RID: 2150
		internal static readonly UnicodeEncoding s_littleEndianDefault = new UnicodeEncoding(false, true);

		// Token: 0x04000867 RID: 2151
		private static readonly byte[] s_bigEndianPreamble = new byte[]
		{
			254,
			byte.MaxValue
		};

		// Token: 0x04000868 RID: 2152
		private static readonly byte[] s_littleEndianPreamble = new byte[]
		{
			byte.MaxValue,
			254
		};

		// Token: 0x04000869 RID: 2153
		internal bool isThrowException;

		// Token: 0x0400086A RID: 2154
		internal bool bigEndian;

		// Token: 0x0400086B RID: 2155
		internal bool byteOrderMark = true;

		// Token: 0x0400086C RID: 2156
		private static readonly ulong highLowPatternMask = 15564677810327967744UL | (BitConverter.IsLittleEndian ? 288230376218820608UL : 4398046512128UL);

		// Token: 0x0200026B RID: 619
		[Serializable]
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x06001598 RID: 5528 RVA: 0x00058DDD File Offset: 0x00056FDD
			public Decoder(UnicodeEncoding encoding) : base(encoding)
			{
			}

			// Token: 0x06001599 RID: 5529 RVA: 0x00058DED File Offset: 0x00056FED
			public override void Reset()
			{
				this.lastByte = -1;
				this.lastChar = '\0';
				if (this._fallbackBuffer != null)
				{
					this._fallbackBuffer.Reset();
				}
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x0600159A RID: 5530 RVA: 0x00058E10 File Offset: 0x00057010
			internal override bool HasState
			{
				get
				{
					return this.lastByte != -1 || this.lastChar > '\0';
				}
			}

			// Token: 0x0400086D RID: 2157
			internal int lastByte = -1;

			// Token: 0x0400086E RID: 2158
			internal char lastChar;
		}
	}
}
