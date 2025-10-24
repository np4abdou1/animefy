using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using Mono.Security;

namespace System.IO
{
	/// <summary>Writes primitive types in binary to a stream and supports writing strings in a specific encoding.</summary>
	// Token: 0x02000558 RID: 1368
	[ComVisible(true)]
	[Serializable]
	public class BinaryWriter : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class that writes to a stream.</summary>
		// Token: 0x060028A3 RID: 10403 RVA: 0x000A1E53 File Offset: 0x000A0053
		protected BinaryWriter()
		{
			this.OutStream = Stream.Null;
			this._buffer = new byte[16];
			this._encoding = new UTF8Encoding(false, true);
			this._encoder = this._encoding.GetEncoder();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="output" /> is <see langword="null" />. </exception>
		// Token: 0x060028A4 RID: 10404 RVA: 0x000A1E91 File Offset: 0x000A0091
		public BinaryWriter(Stream output) : this(output, new UTF8Encoding(false, true), false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="output" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		// Token: 0x060028A5 RID: 10405 RVA: 0x000A1EA2 File Offset: 0x000A00A2
		public BinaryWriter(Stream output, Encoding encoding) : this(output, encoding, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.BinaryWriter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">
		///       <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="output" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		// Token: 0x060028A6 RID: 10406 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (!output.CanWrite)
			{
				throw new ArgumentException(Environment.GetResourceString("Stream was not writable."));
			}
			this.OutStream = output;
			this._buffer = new byte[16];
			this._encoding = encoding;
			this._encoder = this._encoding.GetEncoder();
			this._leaveOpen = leaveOpen;
		}

		/// <summary>Closes the current <see cref="T:System.IO.BinaryWriter" /> and the underlying stream.</summary>
		// Token: 0x060028A7 RID: 10407 RVA: 0x000A1F2A File Offset: 0x000A012A
		public virtual void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.BinaryWriter" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060028A8 RID: 10408 RVA: 0x000A1F33 File Offset: 0x000A0133
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._leaveOpen)
				{
					this.OutStream.Flush();
					return;
				}
				this.OutStream.Close();
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.IO.BinaryWriter" /> class.</summary>
		// Token: 0x060028A9 RID: 10409 RVA: 0x000A1F2A File Offset: 0x000A012A
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.</summary>
		// Token: 0x060028AA RID: 10410 RVA: 0x000A1F57 File Offset: 0x000A0157
		public virtual void Flush()
		{
			this.OutStream.Flush();
		}

		/// <summary>Writes a one-byte <see langword="Boolean" /> value to the current stream, with 0 representing <see langword="false" /> and 1 representing <see langword="true" />.</summary>
		/// <param name="value">The <see langword="Boolean" /> value to write (0 or 1). </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028AB RID: 10411 RVA: 0x000A1F64 File Offset: 0x000A0164
		public virtual void Write(bool value)
		{
			this._buffer[0] = (value ? 1 : 0);
			this.OutStream.Write(this._buffer, 0, 1);
		}

		/// <summary>Writes an unsigned byte to the current stream and advances the stream position by one byte.</summary>
		/// <param name="value">The unsigned byte to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028AC RID: 10412 RVA: 0x000A1F89 File Offset: 0x000A0189
		public virtual void Write(byte value)
		{
			this.OutStream.WriteByte(value);
		}

		/// <summary>Writes a signed byte to the current stream and advances the stream position by one byte.</summary>
		/// <param name="value">The signed byte to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028AD RID: 10413 RVA: 0x000A1F97 File Offset: 0x000A0197
		[CLSCompliant(false)]
		public virtual void Write(sbyte value)
		{
			this.OutStream.WriteByte((byte)value);
		}

		/// <summary>Writes a byte array to the underlying stream.</summary>
		/// <param name="buffer">A byte array containing the data to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		// Token: 0x060028AE RID: 10414 RVA: 0x000A1FA6 File Offset: 0x000A01A6
		public virtual void Write(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			this.OutStream.Write(buffer, 0, buffer.Length);
		}

		/// <summary>Writes a region of a byte array to the current stream.</summary>
		/// <param name="buffer">A byte array containing the data to write. </param>
		/// <param name="index">The starting point in <paramref name="buffer" /> at which to begin writing. </param>
		/// <param name="count">The number of bytes to write. </param>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028AF RID: 10415 RVA: 0x000A1FC6 File Offset: 0x000A01C6
		public virtual void Write(byte[] buffer, int index, int count)
		{
			this.OutStream.Write(buffer, index, count);
		}

		/// <summary>Writes a Unicode character to the current stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific characters being written to the stream.</summary>
		/// <param name="ch">The non-surrogate, Unicode character to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="ch" /> is a single surrogate character.</exception>
		// Token: 0x060028B0 RID: 10416 RVA: 0x000A1FD8 File Offset: 0x000A01D8
		[SecuritySafeCritical]
		public unsafe virtual void Write(char ch)
		{
			if (char.IsSurrogate(ch))
			{
				throw new ArgumentException(Environment.GetResourceString("Unicode surrogate characters must be written out as pairs together in the same call, not individually. Consider passing in a character array instead."));
			}
			byte[] array;
			byte* bytes;
			if ((array = this._buffer) == null || array.Length == 0)
			{
				bytes = null;
			}
			else
			{
				bytes = &array[0];
			}
			int bytes2 = this._encoder.GetBytes(&ch, 1, bytes, this._buffer.Length, true);
			array = null;
			this.OutStream.Write(this._buffer, 0, bytes2);
		}

		/// <summary>Writes a character array to the current stream and advances the current position of the stream in accordance with the <see langword="Encoding" /> used and the specific characters being written to the stream.</summary>
		/// <param name="chars">A character array containing the data to write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x060028B1 RID: 10417 RVA: 0x000A204C File Offset: 0x000A024C
		public virtual void Write(char[] chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars");
			}
			byte[] bytes = this._encoding.GetBytes(chars, 0, chars.Length);
			this.OutStream.Write(bytes, 0, bytes.Length);
		}

		/// <summary>Writes an eight-byte floating-point value to the current stream and advances the stream position by eight bytes.</summary>
		/// <param name="value">The eight-byte floating-point value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B2 RID: 10418 RVA: 0x000A2088 File Offset: 0x000A0288
		[SecuritySafeCritical]
		public virtual void Write(double value)
		{
			this.OutStream.Write(BitConverterLE.GetBytes(value), 0, 8);
		}

		/// <summary>Writes a two-byte signed integer to the current stream and advances the stream position by two bytes.</summary>
		/// <param name="value">The two-byte signed integer to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B3 RID: 10419 RVA: 0x000A209D File Offset: 0x000A029D
		public virtual void Write(short value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this.OutStream.Write(this._buffer, 0, 2);
		}

		/// <summary>Writes a two-byte unsigned integer to the current stream and advances the stream position by two bytes.</summary>
		/// <param name="value">The two-byte unsigned integer to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B4 RID: 10420 RVA: 0x000A209D File Offset: 0x000A029D
		[CLSCompliant(false)]
		public virtual void Write(ushort value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this.OutStream.Write(this._buffer, 0, 2);
		}

		/// <summary>Writes a four-byte signed integer to the current stream and advances the stream position by four bytes.</summary>
		/// <param name="value">The four-byte signed integer to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B5 RID: 10421 RVA: 0x000A20C8 File Offset: 0x000A02C8
		public virtual void Write(int value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this.OutStream.Write(this._buffer, 0, 4);
		}

		/// <summary>Writes a four-byte unsigned integer to the current stream and advances the stream position by four bytes.</summary>
		/// <param name="value">The four-byte unsigned integer to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B6 RID: 10422 RVA: 0x000A2118 File Offset: 0x000A0318
		[CLSCompliant(false)]
		public virtual void Write(uint value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this.OutStream.Write(this._buffer, 0, 4);
		}

		/// <summary>Writes an eight-byte signed integer to the current stream and advances the stream position by eight bytes.</summary>
		/// <param name="value">The eight-byte signed integer to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B7 RID: 10423 RVA: 0x000A2168 File Offset: 0x000A0368
		public virtual void Write(long value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this._buffer[4] = (byte)(value >> 32);
			this._buffer[5] = (byte)(value >> 40);
			this._buffer[6] = (byte)(value >> 48);
			this._buffer[7] = (byte)(value >> 56);
			this.OutStream.Write(this._buffer, 0, 8);
		}

		/// <summary>Writes an eight-byte unsigned integer to the current stream and advances the stream position by eight bytes.</summary>
		/// <param name="value">The eight-byte unsigned integer to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B8 RID: 10424 RVA: 0x000A21EC File Offset: 0x000A03EC
		[CLSCompliant(false)]
		public virtual void Write(ulong value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this._buffer[4] = (byte)(value >> 32);
			this._buffer[5] = (byte)(value >> 40);
			this._buffer[6] = (byte)(value >> 48);
			this._buffer[7] = (byte)(value >> 56);
			this.OutStream.Write(this._buffer, 0, 8);
		}

		/// <summary>Writes a four-byte floating-point value to the current stream and advances the stream position by four bytes.</summary>
		/// <param name="value">The four-byte floating-point value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028B9 RID: 10425 RVA: 0x000A2270 File Offset: 0x000A0470
		[SecuritySafeCritical]
		public virtual void Write(float value)
		{
			this.OutStream.Write(BitConverterLE.GetBytes(value), 0, 4);
		}

		/// <summary>Writes a length-prefixed string to this stream in the current encoding of the <see cref="T:System.IO.BinaryWriter" />, and advances the current position of the stream in accordance with the encoding used and the specific characters being written to the stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		// Token: 0x060028BA RID: 10426 RVA: 0x000A2288 File Offset: 0x000A0488
		[SecuritySafeCritical]
		public unsafe virtual void Write(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int byteCount = this._encoding.GetByteCount(value);
			this.Write7BitEncodedInt(byteCount);
			if (this._largeByteBuffer == null)
			{
				this._largeByteBuffer = new byte[256];
				this._maxChars = this._largeByteBuffer.Length / this._encoding.GetMaxByteCount(1);
			}
			if (byteCount <= this._largeByteBuffer.Length)
			{
				this._encoding.GetBytes(value, 0, value.Length, this._largeByteBuffer, 0);
				this.OutStream.Write(this._largeByteBuffer, 0, byteCount);
				return;
			}
			int num = 0;
			int num2;
			for (int i = value.Length; i > 0; i -= num2)
			{
				num2 = ((i > this._maxChars) ? this._maxChars : i);
				if (num < 0 || num2 < 0 || checked(num + num2) > value.Length)
				{
					throw new ArgumentOutOfRangeException("charCount");
				}
				int bytes2;
				fixed (string text = value)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					byte[] array;
					byte* bytes;
					if ((array = this._largeByteBuffer) == null || array.Length == 0)
					{
						bytes = null;
					}
					else
					{
						bytes = &array[0];
					}
					bytes2 = this._encoder.GetBytes(checked(ptr + num), num2, bytes, this._largeByteBuffer.Length, num2 == i);
					array = null;
				}
				this.OutStream.Write(this._largeByteBuffer, 0, bytes2);
				num += num2;
			}
		}

		/// <summary>Writes a 32-bit integer in a compressed format.</summary>
		/// <param name="value">The 32-bit integer to be written. </param>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">The stream is closed. </exception>
		// Token: 0x060028BB RID: 10427 RVA: 0x000A23E8 File Offset: 0x000A05E8
		protected void Write7BitEncodedInt(int value)
		{
			uint num;
			for (num = (uint)value; num >= 128U; num >>= 7)
			{
				this.Write((byte)(num | 128U));
			}
			this.Write((byte)num);
		}

		/// <summary>Specifies a <see cref="T:System.IO.BinaryWriter" /> with no backing store.</summary>
		// Token: 0x04001530 RID: 5424
		public static readonly BinaryWriter Null = new BinaryWriter();

		/// <summary>Holds the underlying stream.</summary>
		// Token: 0x04001531 RID: 5425
		protected Stream OutStream;

		// Token: 0x04001532 RID: 5426
		private byte[] _buffer;

		// Token: 0x04001533 RID: 5427
		private Encoding _encoding;

		// Token: 0x04001534 RID: 5428
		private Encoder _encoder;

		// Token: 0x04001535 RID: 5429
		[OptionalField]
		private bool _leaveOpen;

		// Token: 0x04001536 RID: 5430
		private byte[] _largeByteBuffer;

		// Token: 0x04001537 RID: 5431
		private int _maxChars;
	}
}
