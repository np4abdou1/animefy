using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads characters from a byte stream in a particular encoding.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000530 RID: 1328
	[Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x0600271C RID: 10012 RVA: 0x0009C1D3 File Offset: 0x0009A3D3
		private void CheckAsyncTaskInProgress()
		{
			if (!this._asyncReadTask.IsCompleted)
			{
				StreamReader.ThrowAsyncIOInProgress();
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0009C1E7 File Offset: 0x0009A3E7
		private static void ThrowAsyncIOInProgress()
		{
			throw new InvalidOperationException("The stream is currently in use by a previous operation on the stream.");
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0009C1F3 File Offset: 0x0009A3F3
		internal StreamReader()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> is <see langword="null" />. </exception>
		// Token: 0x0600271F RID: 10015 RVA: 0x0009C206 File Offset: 0x0009A406
		public StreamReader(Stream stream) : this(stream, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> is <see langword="null" />. </exception>
		// Token: 0x06002720 RID: 10016 RVA: 0x0009C210 File Offset: 0x0009A410
		public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) : this(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		// Token: 0x06002721 RID: 10017 RVA: 0x0009C225 File Offset: 0x0009A425
		public StreamReader(Stream stream, Encoding encoding) : this(stream, encoding, true, 1024, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="detectEncodingFromByteOrderMarks">
		///       <see langword="true" /> to look for byte order marks at the beginning of the file; otherwise, <see langword="false" />.</param>
		/// <param name="bufferSize">The minimum buffer size.</param>
		/// <param name="leaveOpen">
		///       <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, <see langword="false" />.</param>
		// Token: 0x06002722 RID: 10018 RVA: 0x0009C238 File Offset: 0x0009A438
		public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			if (stream == null || encoding == null)
			{
				throw new ArgumentNullException((stream == null) ? "stream" : "encoding");
			}
			if (!stream.CanRead)
			{
				throw new ArgumentException("Stream was not readable.");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
			}
			this.Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name.</summary>
		/// <param name="path">The complete file path to be read. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is an empty string (""). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
		// Token: 0x06002723 RID: 10019 RVA: 0x0009C2A6 File Offset: 0x0009A4A6
		public StreamReader(string path) : this(path, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified byte order mark detection option.</summary>
		/// <param name="path">The complete file path to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is an empty string (""). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
		// Token: 0x06002724 RID: 10020 RVA: 0x0009C2B0 File Offset: 0x0009A4B0
		public StreamReader(string path, bool detectEncodingFromByteOrderMarks) : this(path, Encoding.UTF8, detectEncodingFromByteOrderMarks, 1024)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding.</summary>
		/// <param name="path">The complete file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is an empty string (""). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
		// Token: 0x06002725 RID: 10021 RVA: 0x0009C2C4 File Offset: 0x0009A4C4
		public StreamReader(string path, Encoding encoding) : this(path, encoding, true, 1024)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified file name, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The complete file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size, in number of 16-bit characters. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is an empty string (""). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="buffersize" /> is less than or equal to zero. </exception>
		// Token: 0x06002726 RID: 10022 RVA: 0x0009C2D4 File Offset: 0x0009A4D4
		public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
			}
			Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan);
			this.Init(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, false);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x0009C358 File Offset: 0x0009A558
		private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			this._stream = stream;
			this._encoding = encoding;
			this._decoder = encoding.GetDecoder();
			if (bufferSize < 128)
			{
				bufferSize = 128;
			}
			this._byteBuffer = new byte[bufferSize];
			this._maxCharsPerBuffer = encoding.GetMaxCharCount(bufferSize);
			this._charBuffer = new char[this._maxCharsPerBuffer];
			this._byteLen = 0;
			this._bytePos = 0;
			this._detectEncoding = detectEncodingFromByteOrderMarks;
			this._checkPreamble = (encoding.Preamble.Length > 0);
			this._isBlocked = false;
			this._closable = !leaveOpen;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x0009C3F9 File Offset: 0x0009A5F9
		internal void Init(Stream stream)
		{
			this._stream = stream;
			this._closable = true;
		}

		/// <summary>Closes the <see cref="T:System.IO.StreamReader" /> object and the underlying stream, and releases any system resources associated with the reader.</summary>
		// Token: 0x06002729 RID: 10025 RVA: 0x0009C409 File Offset: 0x0009A609
		public override void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Closes the underlying stream, releases the unmanaged resources used by the <see cref="T:System.IO.StreamReader" />, and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x0600272A RID: 10026 RVA: 0x0009C414 File Offset: 0x0009A614
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.LeaveOpen && disposing && this._stream != null)
				{
					this._stream.Close();
				}
			}
			finally
			{
				if (!this.LeaveOpen && this._stream != null)
				{
					this._stream = null;
					this._encoding = null;
					this._decoder = null;
					this._byteBuffer = null;
					this._charBuffer = null;
					this._charPos = 0;
					this._charLen = 0;
					base.Dispose(disposing);
				}
			}
		}

		/// <summary>Gets the current character encoding that the current <see cref="T:System.IO.StreamReader" /> object is using.</summary>
		/// <returns>The current character encoding used by the current reader. The value can be different after the first call to any <see cref="Overload:System.IO.StreamReader.Read" /> method of <see cref="T:System.IO.StreamReader" />, since encoding autodetection is not done until the first call to a <see cref="Overload:System.IO.StreamReader.Read" /> method.</returns>
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x0009C49C File Offset: 0x0009A69C
		public virtual Encoding CurrentEncoding
		{
			get
			{
				return this._encoding;
			}
		}

		/// <summary>Returns the underlying stream.</summary>
		/// <returns>The underlying stream.</returns>
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x0009C4A4 File Offset: 0x0009A6A4
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x0009C4AC File Offset: 0x0009A6AC
		internal bool LeaveOpen
		{
			get
			{
				return !this._closable;
			}
		}

		/// <summary>Returns the next available character but does not consume it.</summary>
		/// <returns>An integer representing the next character to be read, or -1 if there are no characters to be read or if the stream does not support seeking.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600272E RID: 10030 RVA: 0x0009C4B8 File Offset: 0x0009A6B8
		public override int Peek()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && (this._isBlocked || this.ReadBuffer() == 0))
			{
				return -1;
			}
			return (int)this._charBuffer[this._charPos];
		}

		/// <summary>Reads the next character from the input stream and advances the character position by one character.</summary>
		/// <returns>The next character from the input stream represented as an <see cref="T:System.Int32" /> object, or -1 if no more characters are available.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600272F RID: 10031 RVA: 0x0009C50C File Offset: 0x0009A70C
		public override int Read()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return -1;
			}
			int result = (int)this._charBuffer[this._charPos];
			this._charPos++;
			return result;
		}

		/// <summary>Reads a specified maximum of characters from the current stream into a buffer, beginning at the specified index.</summary>
		/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index + count - 1" />) replaced by the characters read from the current source. </param>
		/// <param name="index">The index of <paramref name="buffer" /> at which to begin writing. </param>
		/// <param name="count">The maximum number of characters to read. </param>
		/// <returns>The number of characters that have been read, or 0 if at the end of the stream and no data was read. The number will be less than or equal to the <paramref name="count" /> parameter, depending on whether the data is available within the stream.</returns>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs, such as the stream is closed. </exception>
		// Token: 0x06002730 RID: 10032 RVA: 0x0009C568 File Offset: 0x0009A768
		public override int Read(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return this.ReadSpan(new Span<char>(buffer, index, count));
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0009C5CC File Offset: 0x0009A7CC
		public override int Read(Span<char> buffer)
		{
			if (!(base.GetType() == typeof(StreamReader)))
			{
				return base.Read(buffer);
			}
			return this.ReadSpan(buffer);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0009C5F4 File Offset: 0x0009A7F4
		private int ReadSpan(Span<char> buffer)
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			int num = 0;
			bool flag = false;
			int i = buffer.Length;
			while (i > 0)
			{
				int num2 = this._charLen - this._charPos;
				if (num2 == 0)
				{
					num2 = this.ReadBuffer(buffer.Slice(num), out flag);
				}
				if (num2 == 0)
				{
					break;
				}
				if (num2 > i)
				{
					num2 = i;
				}
				if (!flag)
				{
					new Span<char>(this._charBuffer, this._charPos, num2).CopyTo(buffer.Slice(num));
					this._charPos += num2;
				}
				num += num2;
				i -= num2;
				if (this._isBlocked)
				{
					break;
				}
			}
			return num;
		}

		/// <summary>Reads all characters from the current position to the end of the stream.</summary>
		/// <returns>The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns an empty string ("").</returns>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002733 RID: 10035 RVA: 0x0009C6A0 File Offset: 0x0009A8A0
		public override string ReadToEnd()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			StringBuilder stringBuilder = new StringBuilder(this._charLen - this._charPos);
			do
			{
				stringBuilder.Append(this._charBuffer, this._charPos, this._charLen - this._charPos);
				this._charPos = this._charLen;
				this.ReadBuffer();
			}
			while (this._charLen > 0);
			return stringBuilder.ToString();
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0009C71C File Offset: 0x0009A91C
		private void CompressBuffer(int n)
		{
			Buffer.BlockCopy(this._byteBuffer, n, this._byteBuffer, 0, this._byteLen - n);
			this._byteLen -= n;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0009C748 File Offset: 0x0009A948
		private void DetectEncoding()
		{
			if (this._byteLen < 2)
			{
				return;
			}
			this._detectEncoding = false;
			bool flag = false;
			if (this._byteBuffer[0] == 254 && this._byteBuffer[1] == 255)
			{
				this._encoding = Encoding.BigEndianUnicode;
				this.CompressBuffer(2);
				flag = true;
			}
			else if (this._byteBuffer[0] == 255 && this._byteBuffer[1] == 254)
			{
				if (this._byteLen < 4 || this._byteBuffer[2] != 0 || this._byteBuffer[3] != 0)
				{
					this._encoding = Encoding.Unicode;
					this.CompressBuffer(2);
					flag = true;
				}
				else
				{
					this._encoding = Encoding.UTF32;
					this.CompressBuffer(4);
					flag = true;
				}
			}
			else if (this._byteLen >= 3 && this._byteBuffer[0] == 239 && this._byteBuffer[1] == 187 && this._byteBuffer[2] == 191)
			{
				this._encoding = Encoding.UTF8;
				this.CompressBuffer(3);
				flag = true;
			}
			else if (this._byteLen >= 4 && this._byteBuffer[0] == 0 && this._byteBuffer[1] == 0 && this._byteBuffer[2] == 254 && this._byteBuffer[3] == 255)
			{
				this._encoding = new UTF32Encoding(true, true);
				this.CompressBuffer(4);
				flag = true;
			}
			else if (this._byteLen == 2)
			{
				this._detectEncoding = true;
			}
			if (flag)
			{
				this._decoder = this._encoding.GetDecoder();
				int maxCharCount = this._encoding.GetMaxCharCount(this._byteBuffer.Length);
				if (maxCharCount > this._maxCharsPerBuffer)
				{
					this._charBuffer = new char[maxCharCount];
				}
				this._maxCharsPerBuffer = maxCharCount;
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0009C900 File Offset: 0x0009AB00
		private unsafe bool IsPreamble()
		{
			if (!this._checkPreamble)
			{
				return this._checkPreamble;
			}
			ReadOnlySpan<byte> preamble = this._encoding.Preamble;
			int num = (this._byteLen >= preamble.Length) ? (preamble.Length - this._bytePos) : (this._byteLen - this._bytePos);
			int i = 0;
			while (i < num)
			{
				if (this._byteBuffer[this._bytePos] != *preamble[this._bytePos])
				{
					this._bytePos = 0;
					this._checkPreamble = false;
					break;
				}
				i++;
				this._bytePos++;
			}
			if (this._checkPreamble && this._bytePos == preamble.Length)
			{
				this.CompressBuffer(preamble.Length);
				this._bytePos = 0;
				this._checkPreamble = false;
				this._detectEncoding = false;
			}
			return this._checkPreamble;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0009C9DC File Offset: 0x0009ABDC
		internal virtual int ReadBuffer()
		{
			this._charLen = 0;
			this._charPos = 0;
			if (!this._checkPreamble)
			{
				this._byteLen = 0;
			}
			for (;;)
			{
				if (this._checkPreamble)
				{
					int num = this._stream.Read(this._byteBuffer, this._bytePos, this._byteBuffer.Length - this._bytePos);
					if (num == 0)
					{
						break;
					}
					this._byteLen += num;
				}
				else
				{
					this._byteLen = this._stream.Read(this._byteBuffer, 0, this._byteBuffer.Length);
					if (this._byteLen == 0)
					{
						goto Block_5;
					}
				}
				this._isBlocked = (this._byteLen < this._byteBuffer.Length);
				if (!this.IsPreamble())
				{
					if (this._detectEncoding && this._byteLen >= 2)
					{
						this.DetectEncoding();
					}
					this._charLen += this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, this._charLen);
				}
				if (this._charLen != 0)
				{
					goto Block_9;
				}
			}
			if (this._byteLen > 0)
			{
				this._charLen += this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, this._charLen);
				this._bytePos = (this._byteLen = 0);
			}
			return this._charLen;
			Block_5:
			return this._charLen;
			Block_9:
			return this._charLen;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0009CB44 File Offset: 0x0009AD44
		private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer)
		{
			this._charLen = 0;
			this._charPos = 0;
			if (!this._checkPreamble)
			{
				this._byteLen = 0;
			}
			int num = 0;
			readToUserBuffer = (userBuffer.Length >= this._maxCharsPerBuffer);
			for (;;)
			{
				if (this._checkPreamble)
				{
					int num2 = this._stream.Read(this._byteBuffer, this._bytePos, this._byteBuffer.Length - this._bytePos);
					if (num2 == 0)
					{
						break;
					}
					this._byteLen += num2;
				}
				else
				{
					this._byteLen = this._stream.Read(this._byteBuffer, 0, this._byteBuffer.Length);
					if (this._byteLen == 0)
					{
						goto IL_1CD;
					}
				}
				this._isBlocked = (this._byteLen < this._byteBuffer.Length);
				if (!this.IsPreamble())
				{
					if (this._detectEncoding && this._byteLen >= 2)
					{
						this.DetectEncoding();
						readToUserBuffer = (userBuffer.Length >= this._maxCharsPerBuffer);
					}
					this._charPos = 0;
					if (readToUserBuffer)
					{
						num += this._decoder.GetChars(new ReadOnlySpan<byte>(this._byteBuffer, 0, this._byteLen), userBuffer.Slice(num), false);
						this._charLen = 0;
					}
					else
					{
						num = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, num);
						this._charLen += num;
					}
				}
				if (num != 0)
				{
					goto IL_1CD;
				}
			}
			if (this._byteLen > 0)
			{
				if (readToUserBuffer)
				{
					num = this._decoder.GetChars(new ReadOnlySpan<byte>(this._byteBuffer, 0, this._byteLen), userBuffer.Slice(num), false);
					this._charLen = 0;
				}
				else
				{
					num = this._decoder.GetChars(this._byteBuffer, 0, this._byteLen, this._charBuffer, num);
					this._charLen += num;
				}
			}
			return num;
			IL_1CD:
			this._isBlocked &= (num < userBuffer.Length);
			return num;
		}

		/// <summary>Reads a line of characters from the current stream and returns the data as a string.</summary>
		/// <returns>The next line from the input stream, or <see langword="null" /> if the end of the input stream is reached.</returns>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002739 RID: 10041 RVA: 0x0009CD38 File Offset: 0x0009AF38
		public override string ReadLine()
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen && this.ReadBuffer() == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = null;
			int num;
			char c;
			for (;;)
			{
				num = this._charPos;
				do
				{
					c = this._charBuffer[num];
					if (c == '\r' || c == '\n')
					{
						goto IL_51;
					}
					num++;
				}
				while (num < this._charLen);
				num = this._charLen - this._charPos;
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(num + 80);
				}
				stringBuilder.Append(this._charBuffer, this._charPos, num);
				if (this.ReadBuffer() <= 0)
				{
					goto Block_11;
				}
			}
			IL_51:
			string result;
			if (stringBuilder != null)
			{
				stringBuilder.Append(this._charBuffer, this._charPos, num - this._charPos);
				result = stringBuilder.ToString();
			}
			else
			{
				result = new string(this._charBuffer, this._charPos, num - this._charPos);
			}
			this._charPos = num + 1;
			if (c == '\r' && (this._charPos < this._charLen || this.ReadBuffer() > 0) && this._charBuffer[this._charPos] == '\n')
			{
				this._charPos++;
			}
			return result;
			Block_11:
			return stringBuilder.ToString();
		}

		/// <summary>Reads a specified maximum number of characters from the current stream asynchronously and writes the data to a buffer, beginning at the specified index. </summary>
		/// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
		/// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
		/// <param name="count">The maximum number of characters to read. If the end of the stream is reached before the specified number of characters is written into the buffer, the current method returns.</param>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of characters read into the buffer. The result value can be less than the number of characters requested if the number of characters currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
		// Token: 0x0600273A RID: 10042 RVA: 0x0009CE70 File Offset: 0x0009B070
		public override Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (base.GetType() != typeof(StreamReader))
			{
				return base.ReadAsync(buffer, index, count);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Cannot read from a closed TextReader.");
			}
			this.CheckAsyncTaskInProgress();
			Task<int> task = this.ReadAsyncInternal(new Memory<char>(buffer, index, count), default(CancellationToken)).AsTask();
			this._asyncReadTask = task;
			return task;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0009CF2C File Offset: 0x0009B12C
		internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			StreamReader.<ReadAsyncInternal>d__66 <ReadAsyncInternal>d__;
			<ReadAsyncInternal>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadAsyncInternal>d__.<>4__this = this;
			<ReadAsyncInternal>d__.buffer = buffer;
			<ReadAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadAsyncInternal>d__.<>1__state = -1;
			<ReadAsyncInternal>d__.<>t__builder.Start<StreamReader.<ReadAsyncInternal>d__66>(ref <ReadAsyncInternal>d__);
			return <ReadAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0009CF80 File Offset: 0x0009B180
		private Task<int> ReadBufferAsync()
		{
			StreamReader.<ReadBufferAsync>d__69 <ReadBufferAsync>d__;
			<ReadBufferAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadBufferAsync>d__.<>4__this = this;
			<ReadBufferAsync>d__.<>1__state = -1;
			<ReadBufferAsync>d__.<>t__builder.Start<StreamReader.<ReadBufferAsync>d__69>(ref <ReadBufferAsync>d__);
			return <ReadBufferAsync>d__.<>t__builder.Task;
		}

		/// <summary>A <see cref="T:System.IO.StreamReader" /> object around an empty stream.</summary>
		// Token: 0x04001457 RID: 5207
		public static readonly StreamReader Null = new StreamReader.NullStreamReader();

		// Token: 0x04001458 RID: 5208
		private Stream _stream;

		// Token: 0x04001459 RID: 5209
		private Encoding _encoding;

		// Token: 0x0400145A RID: 5210
		private Decoder _decoder;

		// Token: 0x0400145B RID: 5211
		private byte[] _byteBuffer;

		// Token: 0x0400145C RID: 5212
		private char[] _charBuffer;

		// Token: 0x0400145D RID: 5213
		private int _charPos;

		// Token: 0x0400145E RID: 5214
		private int _charLen;

		// Token: 0x0400145F RID: 5215
		private int _byteLen;

		// Token: 0x04001460 RID: 5216
		private int _bytePos;

		// Token: 0x04001461 RID: 5217
		private int _maxCharsPerBuffer;

		// Token: 0x04001462 RID: 5218
		private bool _detectEncoding;

		// Token: 0x04001463 RID: 5219
		private bool _checkPreamble;

		// Token: 0x04001464 RID: 5220
		private bool _isBlocked;

		// Token: 0x04001465 RID: 5221
		private bool _closable;

		// Token: 0x04001466 RID: 5222
		private Task _asyncReadTask = Task.CompletedTask;

		// Token: 0x02000531 RID: 1329
		private class NullStreamReader : StreamReader
		{
			// Token: 0x0600273E RID: 10046 RVA: 0x0009CFCF File Offset: 0x0009B1CF
			internal NullStreamReader()
			{
				base.Init(Stream.Null);
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x0600273F RID: 10047 RVA: 0x0009CFE2 File Offset: 0x0009B1E2
			public override Stream BaseStream
			{
				get
				{
					return Stream.Null;
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06002740 RID: 10048 RVA: 0x0009CFE9 File Offset: 0x0009B1E9
			public override Encoding CurrentEncoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x06002741 RID: 10049 RVA: 0x00002A7D File Offset: 0x00000C7D
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x06002742 RID: 10050 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
			public override int Peek()
			{
				return -1;
			}

			// Token: 0x06002743 RID: 10051 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
			public override int Read()
			{
				return -1;
			}

			// Token: 0x06002744 RID: 10052 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x06002745 RID: 10053 RVA: 0x0002AC82 File Offset: 0x00028E82
			public override string ReadLine()
			{
				return null;
			}

			// Token: 0x06002746 RID: 10054 RVA: 0x00011C1B File Offset: 0x0000FE1B
			public override string ReadToEnd()
			{
				return string.Empty;
			}

			// Token: 0x06002747 RID: 10055 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			internal override int ReadBuffer()
			{
				return 0;
			}
		}
	}
}
