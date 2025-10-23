using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Mono.Security;

namespace System.IO
{
	/// <summary>Reads primitive data types as binary values in a specific encoding.</summary>
	// Token: 0x02000557 RID: 1367
	[ComVisible(true)]
	public class BinaryReader : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is <see langword="null" />, or is already closed. </exception>
		// Token: 0x06002888 RID: 10376 RVA: 0x000A14D2 File Offset: 0x0009F6D2
		public BinaryReader(Stream input) : this(input, new UTF8Encoding(), false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is <see langword="null" />, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="encoding" /> is <see langword="null" />. </exception>
		// Token: 0x06002889 RID: 10377 RVA: 0x000A14E1 File Offset: 0x0009F6E1
		public BinaryReader(Stream input, Encoding encoding) : this(input, encoding, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryReader" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">
		///       <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is <see langword="null" />, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="encoding" /> or <paramref name="input" /> is <see langword="null" />. </exception>
		// Token: 0x0600288A RID: 10378 RVA: 0x000A14EC File Offset: 0x0009F6EC
		public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (!input.CanRead)
			{
				throw new ArgumentException(Environment.GetResourceString("Stream was not readable."));
			}
			this.m_stream = input;
			this.m_decoder = encoding.GetDecoder();
			this.m_maxCharsSize = encoding.GetMaxCharCount(128);
			int num = encoding.GetMaxByteCount(1);
			if (num < 16)
			{
				num = 16;
			}
			this.m_buffer = new byte[num];
			this.m_2BytesPerChar = (encoding is UnicodeEncoding);
			this.m_isMemoryStream = (this.m_stream.GetType() == typeof(MemoryStream));
			this.m_leaveOpen = leaveOpen;
		}

		/// <summary>Closes the current reader and the underlying stream.</summary>
		// Token: 0x0600288B RID: 10379 RVA: 0x000A15A9 File Offset: 0x0009F7A9
		public virtual void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.BinaryReader" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x0600288C RID: 10380 RVA: 0x000A15B4 File Offset: 0x0009F7B4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				Stream stream = this.m_stream;
				this.m_stream = null;
				if (stream != null && !this.m_leaveOpen)
				{
					stream.Close();
				}
			}
			this.m_stream = null;
			this.m_buffer = null;
			this.m_decoder = null;
			this.m_charBytes = null;
			this.m_singleChar = null;
			this.m_charBuffer = null;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.IO.BinaryReader" /> class.</summary>
		// Token: 0x0600288D RID: 10381 RVA: 0x000A15A9 File Offset: 0x0009F7A9
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Reads characters from the underlying stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific character being read from the stream.</summary>
		/// <returns>The next character from the input stream, or -1 if no characters are currently available.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x0600288E RID: 10382 RVA: 0x000A160D File Offset: 0x0009F80D
		public virtual int Read()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			return this.InternalReadOneChar();
		}

		/// <summary>Reads a <see langword="Boolean" /> value from the current stream and advances the current position of the stream by one byte.</summary>
		/// <returns>
		///     <see langword="true" /> if the byte is nonzero; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600288F RID: 10383 RVA: 0x000A1622 File Offset: 0x0009F822
		public virtual bool ReadBoolean()
		{
			this.FillBuffer(1);
			return this.m_buffer[0] > 0;
		}

		/// <summary>Reads the next byte from the current stream and advances the current position of the stream by one byte.</summary>
		/// <returns>The next byte read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002890 RID: 10384 RVA: 0x000A1636 File Offset: 0x0009F836
		public virtual byte ReadByte()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			int num = this.m_stream.ReadByte();
			if (num == -1)
			{
				__Error.EndOfFile();
			}
			return (byte)num;
		}

		/// <summary>Reads a signed byte from this stream and advances the current position of the stream by one byte.</summary>
		/// <returns>A signed byte read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002891 RID: 10385 RVA: 0x000A165A File Offset: 0x0009F85A
		[CLSCompliant(false)]
		public virtual sbyte ReadSByte()
		{
			this.FillBuffer(1);
			return (sbyte)this.m_buffer[0];
		}

		/// <summary>Reads the next character from the current stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific character being read from the stream.</summary>
		/// <returns>A character read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentException">A surrogate character was read. </exception>
		// Token: 0x06002892 RID: 10386 RVA: 0x000A166C File Offset: 0x0009F86C
		public virtual char ReadChar()
		{
			int num = this.Read();
			if (num == -1)
			{
				__Error.EndOfFile();
			}
			return (char)num;
		}

		/// <summary>Reads a 2-byte signed integer from the current stream and advances the current position of the stream by two bytes.</summary>
		/// <returns>A 2-byte signed integer read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002893 RID: 10387 RVA: 0x000A167E File Offset: 0x0009F87E
		public virtual short ReadInt16()
		{
			this.FillBuffer(2);
			return (short)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8);
		}

		/// <summary>Reads a 2-byte unsigned integer from the current stream using little-endian encoding and advances the position of the stream by two bytes.</summary>
		/// <returns>A 2-byte unsigned integer read from this stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002894 RID: 10388 RVA: 0x000A169B File Offset: 0x0009F89B
		[CLSCompliant(false)]
		public virtual ushort ReadUInt16()
		{
			this.FillBuffer(2);
			return (ushort)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8);
		}

		/// <summary>Reads a 4-byte signed integer from the current stream and advances the current position of the stream by four bytes.</summary>
		/// <returns>A 4-byte signed integer read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002895 RID: 10389 RVA: 0x000A16B8 File Offset: 0x0009F8B8
		public virtual int ReadInt32()
		{
			if (this.m_isMemoryStream)
			{
				if (this.m_stream == null)
				{
					__Error.FileNotOpen();
				}
				return (this.m_stream as MemoryStream).InternalReadInt32();
			}
			this.FillBuffer(4);
			return (int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24;
		}

		/// <summary>Reads a 4-byte unsigned integer from the current stream and advances the position of the stream by four bytes.</summary>
		/// <returns>A 4-byte unsigned integer read from this stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002896 RID: 10390 RVA: 0x000A171D File Offset: 0x0009F91D
		[CLSCompliant(false)]
		public virtual uint ReadUInt32()
		{
			this.FillBuffer(4);
			return (uint)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24);
		}

		/// <summary>Reads an 8-byte signed integer from the current stream and advances the current position of the stream by eight bytes.</summary>
		/// <returns>An 8-byte signed integer read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002897 RID: 10391 RVA: 0x000A1754 File Offset: 0x0009F954
		public virtual long ReadInt64()
		{
			this.FillBuffer(8);
			uint num = (uint)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24);
			return (long)((ulong)((int)this.m_buffer[4] | (int)this.m_buffer[5] << 8 | (int)this.m_buffer[6] << 16 | (int)this.m_buffer[7] << 24) << 32 | (ulong)num);
		}

		/// <summary>Reads an 8-byte unsigned integer from the current stream and advances the position of the stream by eight bytes.</summary>
		/// <returns>An 8-byte unsigned integer read from this stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x06002898 RID: 10392 RVA: 0x000A17C8 File Offset: 0x0009F9C8
		[CLSCompliant(false)]
		public virtual ulong ReadUInt64()
		{
			this.FillBuffer(8);
			uint num = (uint)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24);
			return (ulong)((int)this.m_buffer[4] | (int)this.m_buffer[5] << 8 | (int)this.m_buffer[6] << 16 | (int)this.m_buffer[7] << 24) << 32 | (ulong)num;
		}

		/// <summary>Reads a 4-byte floating point value from the current stream and advances the current position of the stream by four bytes.</summary>
		/// <returns>A 4-byte floating point value read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002899 RID: 10393 RVA: 0x000A183A File Offset: 0x0009FA3A
		[SecuritySafeCritical]
		public virtual float ReadSingle()
		{
			this.FillBuffer(4);
			return BitConverterLE.ToSingle(this.m_buffer, 0);
		}

		/// <summary>Reads an 8-byte floating point value from the current stream and advances the current position of the stream by eight bytes.</summary>
		/// <returns>An 8-byte floating point value read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600289A RID: 10394 RVA: 0x000A184F File Offset: 0x0009FA4F
		[SecuritySafeCritical]
		public virtual double ReadDouble()
		{
			this.FillBuffer(8);
			return BitConverterLE.ToDouble(this.m_buffer, 0);
		}

		/// <summary>Reads a string from the current stream. The string is prefixed with the length, encoded as an integer seven bits at a time.</summary>
		/// <returns>The string being read.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600289B RID: 10395 RVA: 0x000A1864 File Offset: 0x0009FA64
		public virtual string ReadString()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			int num = 0;
			int num2 = this.Read7BitEncodedInt();
			if (num2 < 0)
			{
				throw new IOException(Environment.GetResourceString("BinaryReader encountered an invalid string length of {0} characters.", new object[]
				{
					num2
				}));
			}
			if (num2 == 0)
			{
				return string.Empty;
			}
			if (this.m_charBytes == null)
			{
				this.m_charBytes = new byte[128];
			}
			if (this.m_charBuffer == null)
			{
				this.m_charBuffer = new char[this.m_maxCharsSize];
			}
			StringBuilder stringBuilder = null;
			int chars;
			for (;;)
			{
				int count = (num2 - num > 128) ? 128 : (num2 - num);
				int num3 = this.m_stream.Read(this.m_charBytes, 0, count);
				if (num3 == 0)
				{
					__Error.EndOfFile();
				}
				chars = this.m_decoder.GetChars(this.m_charBytes, 0, num3, this.m_charBuffer, 0);
				if (num == 0 && num3 == num2)
				{
					break;
				}
				if (stringBuilder == null)
				{
					stringBuilder = StringBuilderCache.Acquire(num2);
				}
				stringBuilder.Append(this.m_charBuffer, 0, chars);
				num += num3;
				if (num >= num2)
				{
					goto Block_11;
				}
			}
			return new string(this.m_charBuffer, 0, chars);
			Block_11:
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000A197C File Offset: 0x0009FB7C
		[SecurityCritical]
		private unsafe int InternalReadChars(char[] buffer, int index, int count)
		{
			int i = count;
			if (this.m_charBytes == null)
			{
				this.m_charBytes = new byte[128];
			}
			while (i > 0)
			{
				int num = i;
				DecoderNLS decoderNLS = this.m_decoder as DecoderNLS;
				if (decoderNLS != null && decoderNLS.HasState && num > 1)
				{
					num--;
				}
				if (this.m_2BytesPerChar)
				{
					num <<= 1;
				}
				if (num > 128)
				{
					num = 128;
				}
				int num2 = 0;
				byte[] array;
				if (this.m_isMemoryStream)
				{
					MemoryStream memoryStream = this.m_stream as MemoryStream;
					num2 = memoryStream.InternalGetPosition();
					num = memoryStream.InternalEmulateRead(num);
					array = memoryStream.InternalGetBuffer();
				}
				else
				{
					num = this.m_stream.Read(this.m_charBytes, 0, num);
					array = this.m_charBytes;
				}
				if (num == 0)
				{
					return count - i;
				}
				int chars;
				checked
				{
					if (num2 < 0 || num < 0 || num2 + num > array.Length)
					{
						throw new ArgumentOutOfRangeException("byteCount");
					}
					if (index < 0 || i < 0 || index + i > buffer.Length)
					{
						throw new ArgumentOutOfRangeException("charsRemaining");
					}
					byte[] array2;
					byte* ptr;
					if ((array2 = array) == null || array2.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array2[0];
					}
					fixed (char[] array3 = buffer)
					{
						char* ptr2;
						if (buffer == null || array3.Length == 0)
						{
							ptr2 = null;
						}
						else
						{
							ptr2 = &array3[0];
						}
						chars = this.m_decoder.GetChars(ptr + num2, num, ptr2 + index, i, false);
					}
					array2 = null;
				}
				i -= chars;
				index += chars;
			}
			return count - i;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000A1AE8 File Offset: 0x0009FCE8
		private int InternalReadOneChar()
		{
			int num = 0;
			long num2 = 0L;
			if (this.m_stream.CanSeek)
			{
				num2 = this.m_stream.Position;
			}
			if (this.m_charBytes == null)
			{
				this.m_charBytes = new byte[128];
			}
			if (this.m_singleChar == null)
			{
				this.m_singleChar = new char[1];
			}
			while (num == 0)
			{
				int num3 = this.m_2BytesPerChar ? 2 : 1;
				int num4 = this.m_stream.ReadByte();
				this.m_charBytes[0] = (byte)num4;
				if (num4 == -1)
				{
					num3 = 0;
				}
				if (num3 == 2)
				{
					num4 = this.m_stream.ReadByte();
					this.m_charBytes[1] = (byte)num4;
					if (num4 == -1)
					{
						num3 = 1;
					}
				}
				if (num3 == 0)
				{
					return -1;
				}
				try
				{
					num = this.m_decoder.GetChars(this.m_charBytes, 0, num3, this.m_singleChar, 0);
				}
				catch
				{
					if (this.m_stream.CanSeek)
					{
						this.m_stream.Seek(num2 - this.m_stream.Position, SeekOrigin.Current);
					}
					throw;
				}
			}
			if (num == 0)
			{
				return -1;
			}
			return (int)this.m_singleChar[0];
		}

		/// <summary>Reads the specified number of characters from the current stream, returns the data in a character array, and advances the current position in accordance with the <see langword="Encoding" /> used and the specific character being read from the stream.</summary>
		/// <param name="count">The number of characters to read. </param>
		/// <returns>A character array containing data read from the underlying stream. This might be less than the number of characters requested if the end of the stream is reached.</returns>
		/// <exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is negative. </exception>
		// Token: 0x0600289E RID: 10398 RVA: 0x000A1C04 File Offset: 0x0009FE04
		[SecuritySafeCritical]
		public virtual char[] ReadChars(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (count == 0)
			{
				return EmptyArray<char>.Value;
			}
			char[] array = new char[count];
			int num = this.InternalReadChars(array, 0, count);
			if (num != count)
			{
				char[] array2 = new char[num];
				Buffer.InternalBlockCopy(array, 0, array2, 0, 2 * num);
				array = array2;
			}
			return array;
		}

		/// <summary>Reads the specified number of bytes from the stream, starting from a specified point in the byte array. </summary>
		/// <param name="buffer">The buffer to read data into. </param>
		/// <param name="index">The starting point in the buffer at which to begin reading into the buffer. </param>
		/// <param name="count">The number of bytes to read. </param>
		/// <returns>The number of bytes read into <paramref name="buffer" />. This might be less than the number of bytes requested if that many bytes are not available, or it might be zero if the end of the stream is reached.</returns>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. -or-The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600289F RID: 10399 RVA: 0x000A1C6C File Offset: 0x0009FE6C
		public virtual int Read(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", Environment.GetResourceString("Buffer cannot be null."));
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("Non-negative number required."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			return this.m_stream.Read(buffer, index, count);
		}

		/// <summary>Reads the specified number of bytes from the current stream into a byte array and advances the current position by that number of bytes.</summary>
		/// <param name="count">The number of bytes to read. This value must be 0 or a non-negative number or an exception will occur.</param>
		/// <returns>A byte array containing data read from the underlying stream. This might be less than the number of bytes requested if the end of the stream is reached.</returns>
		/// <exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is negative. </exception>
		// Token: 0x060028A0 RID: 10400 RVA: 0x000A1CF8 File Offset: 0x0009FEF8
		public virtual byte[] ReadBytes(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (count == 0)
			{
				return EmptyArray<byte>.Value;
			}
			byte[] array = new byte[count];
			int num = 0;
			do
			{
				int num2 = this.m_stream.Read(array, num, count);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				count -= num2;
			}
			while (count > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.InternalBlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}

		/// <summary>Fills the internal buffer with the specified number of bytes read from the stream.</summary>
		/// <param name="numBytes">The number of bytes to be read. </param>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached before <paramref name="numBytes" /> could be read. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Requested <paramref name="numBytes" /> is larger than the internal buffer size.</exception>
		// Token: 0x060028A1 RID: 10401 RVA: 0x000A1D78 File Offset: 0x0009FF78
		protected virtual void FillBuffer(int numBytes)
		{
			if (this.m_buffer != null && (numBytes < 0 || numBytes > this.m_buffer.Length))
			{
				throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("The number of bytes requested does not fit into BinaryReader's internal buffer."));
			}
			int num = 0;
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (numBytes == 1)
			{
				int num2 = this.m_stream.ReadByte();
				if (num2 == -1)
				{
					__Error.EndOfFile();
				}
				this.m_buffer[0] = (byte)num2;
				return;
			}
			do
			{
				int num2 = this.m_stream.Read(this.m_buffer, num, numBytes - num);
				if (num2 == 0)
				{
					__Error.EndOfFile();
				}
				num += num2;
			}
			while (num < numBytes);
		}

		/// <summary>Reads in a 32-bit integer in compressed format.</summary>
		/// <returns>A 32-bit integer in compressed format.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.FormatException">The stream is corrupted.</exception>
		// Token: 0x060028A2 RID: 10402 RVA: 0x000A1E0C File Offset: 0x000A000C
		protected internal int Read7BitEncodedInt()
		{
			int num = 0;
			int num2 = 0;
			while (num2 != 35)
			{
				byte b = this.ReadByte();
				num |= (int)(b & 127) << num2;
				num2 += 7;
				if ((b & 128) == 0)
				{
					return num;
				}
			}
			throw new FormatException(Environment.GetResourceString("Too many bytes in what should have been a 7 bit encoded Int32."));
		}

		// Token: 0x04001526 RID: 5414
		private Stream m_stream;

		// Token: 0x04001527 RID: 5415
		private byte[] m_buffer;

		// Token: 0x04001528 RID: 5416
		private Decoder m_decoder;

		// Token: 0x04001529 RID: 5417
		private byte[] m_charBytes;

		// Token: 0x0400152A RID: 5418
		private char[] m_singleChar;

		// Token: 0x0400152B RID: 5419
		private char[] m_charBuffer;

		// Token: 0x0400152C RID: 5420
		private int m_maxCharsSize;

		// Token: 0x0400152D RID: 5421
		private bool m_2BytesPerChar;

		// Token: 0x0400152E RID: 5422
		private bool m_isMemoryStream;

		// Token: 0x0400152F RID: 5423
		private bool m_leaveOpen;
	}
}
