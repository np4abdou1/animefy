using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing characters to a stream in a particular encoding.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000534 RID: 1332
	[Serializable]
	public class StreamWriter : TextWriter
	{
		// Token: 0x0600274C RID: 10060 RVA: 0x0009D85A File Offset: 0x0009BA5A
		private void CheckAsyncTaskInProgress()
		{
			if (!this._asyncWriteTask.IsCompleted)
			{
				StreamWriter.ThrowAsyncIOInProgress();
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0009C1E7 File Offset: 0x0009A3E7
		private static void ThrowAsyncIOInProgress()
		{
			throw new InvalidOperationException("The stream is currently in use by a previous operation on the stream.");
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x0009D86E File Offset: 0x0009BA6E
		private static Encoding UTF8NoBOM
		{
			get
			{
				return EncodingHelper.UTF8Unmarked;
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0009D875 File Offset: 0x0009BA75
		internal StreamWriter() : base(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using UTF-8 encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not writable. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> is <see langword="null" />. </exception>
		// Token: 0x06002750 RID: 10064 RVA: 0x0009D889 File Offset: 0x0009BA89
		public StreamWriter(Stream stream) : this(stream, StreamWriter.UTF8NoBOM, 1024, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not writable. </exception>
		// Token: 0x06002751 RID: 10065 RVA: 0x0009D89D File Offset: 0x0009BA9D
		public StreamWriter(Stream stream, Encoding encoding) : this(stream, encoding, 1024, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to write to.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="bufferSize">The buffer size, in bytes.</param>
		/// <param name="leaveOpen">
		///       <see langword="true" /> to leave the stream open after the <see cref="T:System.IO.StreamWriter" /> object is disposed; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="bufferSize" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not writable. </exception>
		// Token: 0x06002752 RID: 10066 RVA: 0x0009D8B0 File Offset: 0x0009BAB0
		public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) : base(null)
		{
			if (stream == null || encoding == null)
			{
				throw new ArgumentNullException((stream == null) ? "stream" : "encoding");
			}
			if (!stream.CanWrite)
			{
				throw new ArgumentException("Stream was not writable.");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
			}
			this.Init(stream, encoding, bufferSize, leaveOpen);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file by using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary>
		/// <param name="path">The complete file path to write to. </param>
		/// <param name="append">
		///       <see langword="true" /> to append data to the file; <see langword="false" /> to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file. </param>
		/// <exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is empty. -or-
		///         <paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06002753 RID: 10067 RVA: 0x0009D91C File Offset: 0x0009BB1C
		public StreamWriter(string path, bool append) : this(path, append, StreamWriter.UTF8NoBOM, 1024)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamWriter" /> class for the specified file on the specified path, using the specified encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.</summary>
		/// <param name="path">The complete file path to write to. </param>
		/// <param name="append">
		///       <see langword="true" /> to append data to the file; <see langword="false" /> to overwrite the file. If the specified file does not exist, this parameter has no effect, and the constructor creates a new file.</param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="bufferSize">The buffer size, in bytes. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is an empty string (""). -or-
		///         <paramref name="path" /> contains the name of a system device (com1, com2, and so on).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> or <paramref name="encoding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="bufferSize" /> is negative. </exception>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="path" /> includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters. </exception>
		// Token: 0x06002754 RID: 10068 RVA: 0x0009D930 File Offset: 0x0009BB30
		public StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
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
			Stream streamArg = new FileStream(path, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read, 4096, FileOptions.SequentialScan);
			this.Init(streamArg, encoding, bufferSize, false);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0009D9B8 File Offset: 0x0009BBB8
		private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
			this._stream = streamArg;
			this._encoding = encodingArg;
			this._encoder = this._encoding.GetEncoder();
			if (bufferSize < 128)
			{
				bufferSize = 128;
			}
			this._charBuffer = new char[bufferSize];
			this._byteBuffer = new byte[this._encoding.GetMaxByteCount(bufferSize)];
			this._charLen = bufferSize;
			if (this._stream.CanSeek && this._stream.Position > 0L)
			{
				this._haveWrittenPreamble = true;
			}
			this._closable = !shouldLeaveOpen;
		}

		/// <summary>Closes the current <see langword="StreamWriter" /> object and the underlying stream.</summary>
		/// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
		// Token: 0x06002756 RID: 10070 RVA: 0x0009DA4B File Offset: 0x0009BC4B
		public override void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StreamWriter" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		/// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
		// Token: 0x06002757 RID: 10071 RVA: 0x0009DA5C File Offset: 0x0009BC5C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (this._stream != null && disposing)
				{
					this.CheckAsyncTaskInProgress();
					this.Flush(true, true);
				}
			}
			finally
			{
				if (!this.LeaveOpen && this._stream != null)
				{
					try
					{
						if (disposing)
						{
							this._stream.Close();
						}
					}
					finally
					{
						this._stream = null;
						this._byteBuffer = null;
						this._charBuffer = null;
						this._encoding = null;
						this._encoder = null;
						this._charLen = 0;
						base.Dispose(disposing);
					}
				}
			}
		}

		/// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The current writer is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error has occurred. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair. </exception>
		// Token: 0x06002758 RID: 10072 RVA: 0x0009DAF4 File Offset: 0x0009BCF4
		public override void Flush()
		{
			this.CheckAsyncTaskInProgress();
			this.Flush(true, true);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0009DB04 File Offset: 0x0009BD04
		private void Flush(bool flushStream, bool flushEncoder)
		{
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Can not write to a closed TextWriter.");
			}
			if (this._charPos == 0 && !flushStream && !flushEncoder)
			{
				return;
			}
			if (!this._haveWrittenPreamble)
			{
				this._haveWrittenPreamble = true;
				ReadOnlySpan<byte> preamble = this._encoding.Preamble;
				if (preamble.Length > 0)
				{
					this._stream.Write(preamble);
				}
			}
			int bytes = this._encoder.GetBytes(this._charBuffer, 0, this._charPos, this._byteBuffer, 0, flushEncoder);
			this._charPos = 0;
			if (bytes > 0)
			{
				this._stream.Write(this._byteBuffer, 0, bytes);
			}
			if (flushStream)
			{
				this._stream.Flush();
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.IO.StreamWriter" /> will flush its buffer to the underlying stream after every call to <see cref="M:System.IO.StreamWriter.Write(System.Char)" />.</summary>
		/// <returns>
		///     <see langword="true" /> to force <see cref="T:System.IO.StreamWriter" /> to flush its buffer; otherwise, <see langword="false" />.</returns>
		// Token: 0x170005BA RID: 1466
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x0009DBB2 File Offset: 0x0009BDB2
		public virtual bool AutoFlush
		{
			set
			{
				this.CheckAsyncTaskInProgress();
				this._autoFlush = value;
				if (value)
				{
					this.Flush(true, false);
				}
			}
		}

		/// <summary>Gets the underlying stream that interfaces with a backing store.</summary>
		/// <returns>The stream this <see langword="StreamWriter" /> is writing to.</returns>
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x0009DBCC File Offset: 0x0009BDCC
		public virtual Stream BaseStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x0009DBD4 File Offset: 0x0009BDD4
		internal bool LeaveOpen
		{
			get
			{
				return !this._closable;
			}
		}

		/// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary>
		/// <returns>The <see cref="T:System.Text.Encoding" /> specified in the constructor for the current instance, or <see cref="T:System.Text.UTF8Encoding" /> if an encoding was not specified.</returns>
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x0009DBDF File Offset: 0x0009BDDF
		public override Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		/// <summary>Writes a character to the stream.</summary>
		/// <param name="value">The character to write to the stream. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
		// Token: 0x0600275E RID: 10078 RVA: 0x0009DBE8 File Offset: 0x0009BDE8
		public override void Write(char value)
		{
			this.CheckAsyncTaskInProgress();
			if (this._charPos == this._charLen)
			{
				this.Flush(false, false);
			}
			this._charBuffer[this._charPos] = value;
			this._charPos++;
			if (this._autoFlush)
			{
				this.Flush(true, false);
			}
		}

		/// <summary>Writes a character array to the stream.</summary>
		/// <param name="buffer">A character array containing the data to write. If <paramref name="buffer" /> is <see langword="null" />, nothing is written. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
		// Token: 0x0600275F RID: 10079 RVA: 0x0009DC3D File Offset: 0x0009BE3D
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(char[] buffer)
		{
			this.WriteSpan(buffer, false);
		}

		/// <summary>Writes a subarray of characters to the stream.</summary>
		/// <param name="buffer">A character array that contains the data to write. </param>
		/// <param name="index">The character position in the buffer at which to start reading data. </param>
		/// <param name="count">The maximum number of characters to write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
		// Token: 0x06002760 RID: 10080 RVA: 0x0009DC4C File Offset: 0x0009BE4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			this.WriteSpan(buffer.AsSpan(index, count), false);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0009DCBC File Offset: 0x0009BEBC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine)
		{
			this.CheckAsyncTaskInProgress();
			if (buffer.Length <= 4 && buffer.Length <= this._charLen - this._charPos)
			{
				for (int i = 0; i < buffer.Length; i++)
				{
					char[] charBuffer = this._charBuffer;
					int charPos = this._charPos;
					this._charPos = charPos + 1;
					charBuffer[charPos] = *buffer[i];
				}
			}
			else
			{
				char[] charBuffer2 = this._charBuffer;
				if (charBuffer2 == null)
				{
					throw new ObjectDisposedException(null, "Can not write to a closed TextWriter.");
				}
				fixed (char* reference = MemoryMarshal.GetReference<char>(buffer))
				{
					char* ptr = reference;
					fixed (char* ptr2 = &charBuffer2[0])
					{
						char* ptr3 = ptr2;
						char* ptr4 = ptr;
						int j = buffer.Length;
						int num = this._charPos;
						while (j > 0)
						{
							if (num == charBuffer2.Length)
							{
								this.Flush(false, false);
								num = 0;
							}
							int num2 = Math.Min(charBuffer2.Length - num, j);
							int num3 = num2 * 2;
							Buffer.MemoryCopy((void*)ptr4, (void*)(ptr3 + num), (long)num3, (long)num3);
							this._charPos += num2;
							num += num2;
							ptr4 += num2;
							j -= num2;
						}
					}
				}
			}
			if (appendNewLine)
			{
				char[] coreNewLine = this.CoreNewLine;
				for (int k = 0; k < coreNewLine.Length; k++)
				{
					if (this._charPos == this._charLen)
					{
						this.Flush(false, false);
					}
					this._charBuffer[this._charPos] = coreNewLine[k];
					this._charPos++;
				}
			}
			if (this._autoFlush)
			{
				this.Flush(true, false);
			}
		}

		/// <summary>Writes a string to the stream.</summary>
		/// <param name="value">The string to write to the stream. If <paramref name="value" /> is null, nothing is written. </param>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002762 RID: 10082 RVA: 0x0009DE3C File Offset: 0x0009C03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(string value)
		{
			this.WriteSpan(value, false);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0009DE4B File Offset: 0x0009C04B
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteLine(string value)
		{
			this.CheckAsyncTaskInProgress();
			this.WriteSpan(value, true);
		}

		/// <summary>Writes a character to the stream asynchronously.</summary>
		/// <param name="value">The character to write to the stream.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
		// Token: 0x06002764 RID: 10084 RVA: 0x0009DE60 File Offset: 0x0009C060
		public override Task WriteAsync(char value)
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(value);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Can not write to a closed TextWriter.");
			}
			this.CheckAsyncTaskInProgress();
			Task task = StreamWriter.WriteAsyncInternal(this, value, this._charBuffer, this._charPos, this._charLen, this.CoreNewLine, this._autoFlush, false);
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0009DED8 File Offset: 0x0009C0D8
		private static Task WriteAsyncInternal(StreamWriter _this, char value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
		{
			StreamWriter.<WriteAsyncInternal>d__57 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__._this = _this;
			<WriteAsyncInternal>d__.value = value;
			<WriteAsyncInternal>d__.charBuffer = charBuffer;
			<WriteAsyncInternal>d__.charPos = charPos;
			<WriteAsyncInternal>d__.charLen = charLen;
			<WriteAsyncInternal>d__.coreNewLine = coreNewLine;
			<WriteAsyncInternal>d__.autoFlush = autoFlush;
			<WriteAsyncInternal>d__.appendNewLine = appendNewLine;
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<StreamWriter.<WriteAsyncInternal>d__57>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Writes a string to the stream asynchronously.</summary>
		/// <param name="value">The string to write to the stream. If <paramref name="value" /> is <see langword="null" />, nothing is written.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
		// Token: 0x06002766 RID: 10086 RVA: 0x0009DF58 File Offset: 0x0009C158
		public override Task WriteAsync(string value)
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(value);
			}
			if (value == null)
			{
				return Task.CompletedTask;
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Can not write to a closed TextWriter.");
			}
			this.CheckAsyncTaskInProgress();
			Task task = StreamWriter.WriteAsyncInternal(this, value, this._charBuffer, this._charPos, this._charLen, this.CoreNewLine, this._autoFlush, false);
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0009DFD8 File Offset: 0x0009C1D8
		private static Task WriteAsyncInternal(StreamWriter _this, string value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine)
		{
			StreamWriter.<WriteAsyncInternal>d__59 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__._this = _this;
			<WriteAsyncInternal>d__.value = value;
			<WriteAsyncInternal>d__.charBuffer = charBuffer;
			<WriteAsyncInternal>d__.charPos = charPos;
			<WriteAsyncInternal>d__.charLen = charLen;
			<WriteAsyncInternal>d__.coreNewLine = coreNewLine;
			<WriteAsyncInternal>d__.autoFlush = autoFlush;
			<WriteAsyncInternal>d__.appendNewLine = appendNewLine;
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<StreamWriter.<WriteAsyncInternal>d__59>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Writes a subarray of characters to the stream asynchronously.</summary>
		/// <param name="buffer">A character array that contains the data to write.</param>
		/// <param name="index">The character position in the buffer at which to begin reading data.</param>
		/// <param name="count">The maximum number of characters to write.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation. </exception>
		// Token: 0x06002768 RID: 10088 RVA: 0x0009E058 File Offset: 0x0009C258
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.WriteAsync(buffer, index, count);
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Can not write to a closed TextWriter.");
			}
			this.CheckAsyncTaskInProgress();
			Task task = StreamWriter.WriteAsyncInternal(this, new ReadOnlyMemory<char>(buffer, index, count), this._charBuffer, this._charPos, this._charLen, this.CoreNewLine, this._autoFlush, false, default(CancellationToken));
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x0009E130 File Offset: 0x0009C330
		private static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<char> source, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken)
		{
			StreamWriter.<WriteAsyncInternal>d__62 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__._this = _this;
			<WriteAsyncInternal>d__.source = source;
			<WriteAsyncInternal>d__.charBuffer = charBuffer;
			<WriteAsyncInternal>d__.charPos = charPos;
			<WriteAsyncInternal>d__.charLen = charLen;
			<WriteAsyncInternal>d__.coreNewLine = coreNewLine;
			<WriteAsyncInternal>d__.autoFlush = autoFlush;
			<WriteAsyncInternal>d__.appendNewLine = appendNewLine;
			<WriteAsyncInternal>d__.cancellationToken = cancellationToken;
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<StreamWriter.<WriteAsyncInternal>d__62>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Clears all buffers for this stream asynchronously and causes any buffered data to be written to the underlying device.</summary>
		/// <returns>A task that represents the asynchronous flush operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		// Token: 0x0600276A RID: 10090 RVA: 0x0009E1B8 File Offset: 0x0009C3B8
		public override Task FlushAsync()
		{
			if (base.GetType() != typeof(StreamWriter))
			{
				return base.FlushAsync();
			}
			if (this._stream == null)
			{
				throw new ObjectDisposedException(null, "Can not write to a closed TextWriter.");
			}
			this.CheckAsyncTaskInProgress();
			Task task = this.FlushAsyncInternal(true, true, this._charBuffer, this._charPos, default(CancellationToken));
			this._asyncWriteTask = task;
			return task;
		}

		// Token: 0x170005BE RID: 1470
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x0009E223 File Offset: 0x0009C423
		private int CharPos_Prop
		{
			set
			{
				this._charPos = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x0009E22C File Offset: 0x0009C42C
		private bool HaveWrittenPreamble_Prop
		{
			set
			{
				this._haveWrittenPreamble = value;
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0009E238 File Offset: 0x0009C438
		private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (sCharPos == 0 && !flushStream && !flushEncoder)
			{
				return Task.CompletedTask;
			}
			Task result = StreamWriter.FlushAsyncInternal(this, flushStream, flushEncoder, sCharBuffer, sCharPos, this._haveWrittenPreamble, this._encoding, this._encoder, this._byteBuffer, this._stream, cancellationToken);
			this._charPos = 0;
			return result;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0009E298 File Offset: 0x0009C498
		private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, byte[] byteBuffer, Stream stream, CancellationToken cancellationToken)
		{
			StreamWriter.<FlushAsyncInternal>d__74 <FlushAsyncInternal>d__;
			<FlushAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushAsyncInternal>d__._this = _this;
			<FlushAsyncInternal>d__.flushStream = flushStream;
			<FlushAsyncInternal>d__.flushEncoder = flushEncoder;
			<FlushAsyncInternal>d__.charBuffer = charBuffer;
			<FlushAsyncInternal>d__.charPos = charPos;
			<FlushAsyncInternal>d__.haveWrittenPreamble = haveWrittenPreamble;
			<FlushAsyncInternal>d__.encoding = encoding;
			<FlushAsyncInternal>d__.encoder = encoder;
			<FlushAsyncInternal>d__.byteBuffer = byteBuffer;
			<FlushAsyncInternal>d__.stream = stream;
			<FlushAsyncInternal>d__.cancellationToken = cancellationToken;
			<FlushAsyncInternal>d__.<>1__state = -1;
			<FlushAsyncInternal>d__.<>t__builder.Start<StreamWriter.<FlushAsyncInternal>d__74>(ref <FlushAsyncInternal>d__);
			return <FlushAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Provides a <see langword="StreamWriter" /> with no backing store that can be written to, but not read from.</summary>
		// Token: 0x0400147A RID: 5242
		public new static readonly StreamWriter Null = new StreamWriter(Stream.Null, StreamWriter.UTF8NoBOM, 128, true);

		// Token: 0x0400147B RID: 5243
		private Stream _stream;

		// Token: 0x0400147C RID: 5244
		private Encoding _encoding;

		// Token: 0x0400147D RID: 5245
		private Encoder _encoder;

		// Token: 0x0400147E RID: 5246
		private byte[] _byteBuffer;

		// Token: 0x0400147F RID: 5247
		private char[] _charBuffer;

		// Token: 0x04001480 RID: 5248
		private int _charPos;

		// Token: 0x04001481 RID: 5249
		private int _charLen;

		// Token: 0x04001482 RID: 5250
		private bool _autoFlush;

		// Token: 0x04001483 RID: 5251
		private bool _haveWrittenPreamble;

		// Token: 0x04001484 RID: 5252
		private bool _closable;

		// Token: 0x04001485 RID: 5253
		private Task _asyncWriteTask = Task.CompletedTask;
	}
}
