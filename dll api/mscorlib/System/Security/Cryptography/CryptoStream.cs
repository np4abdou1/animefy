using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Security.Cryptography
{
	/// <summary>Defines a stream that links data streams to cryptographic transformations.</summary>
	// Token: 0x0200029A RID: 666
	public class CryptoStream : Stream, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptoStream" /> class with a target data stream, the transformation to use, and the mode of the stream.</summary>
		/// <param name="stream">The stream on which to perform the cryptographic transformation. </param>
		/// <param name="transform">The cryptographic transformation that is to be performed on the stream. </param>
		/// <param name="mode">One of the <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not readable.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not writable.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is invalid.</exception>
		// Token: 0x060016C9 RID: 5833 RVA: 0x0005DB59 File Offset: 0x0005BD59
		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) : this(stream, transform, mode, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptoStream" /> class.</summary>
		/// <param name="stream">The stream on which to perform the cryptographic transformation.</param>
		/// <param name="transform">The cryptographic transformation that is to be performed on the stream.</param>
		/// <param name="mode">The mode of the stream.</param>
		/// <param name="leaveOpen">
		///   <see langword="true" /> to not close the underlying stream when the <see cref="T:System.Security.Cryptography.CryptoStream" />  object is disposed; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not readable.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="stream" /> is not writable.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="mode" /> is invalid.</exception>
		// Token: 0x060016CA RID: 5834 RVA: 0x0005DB68 File Offset: 0x0005BD68
		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
		{
			this._stream = stream;
			this._transformMode = mode;
			this._transform = transform;
			this._leaveOpen = leaveOpen;
			CryptoStreamMode transformMode = this._transformMode;
			if (transformMode != CryptoStreamMode.Read)
			{
				if (transformMode != CryptoStreamMode.Write)
				{
					throw new ArgumentException("Argument {0} should be larger than {1}.");
				}
				if (!this._stream.CanWrite)
				{
					throw new ArgumentException(SR.Format("Stream was not writable.", "stream"));
				}
				this._canWrite = true;
			}
			else
			{
				if (!this._stream.CanRead)
				{
					throw new ArgumentException(SR.Format("Stream was not readable.", "stream"));
				}
				this._canRead = true;
			}
			this.InitializeBuffer();
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Security.Cryptography.CryptoStream" /> is readable.</summary>
		/// <returns>
		///     <see langword="true" /> if the current stream is readable; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x0005DC0F File Offset: 0x0005BE0F
		public override bool CanRead
		{
			get
			{
				return this._canRead;
			}
		}

		/// <summary>Gets a value indicating whether you can seek within the current <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
		/// <returns>Always <see langword="false" />.</returns>
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Security.Cryptography.CryptoStream" /> is writable.</summary>
		/// <returns>
		///     <see langword="true" /> if the current stream is writable; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0005DC17 File Offset: 0x0005BE17
		public override bool CanWrite
		{
			get
			{
				return this._canWrite;
			}
		}

		/// <summary>Gets the length in bytes of the stream.</summary>
		/// <returns>This property is not supported.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported. </exception>
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0005DC1F File Offset: 0x0005BE1F
		public override long Length
		{
			get
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
		}

		/// <summary>Gets or sets the position within the current stream.</summary>
		/// <returns>This property is not supported.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported. </exception>
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x0005DC1F File Offset: 0x0005BE1F
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0005DC1F File Offset: 0x0005BE1F
		public override long Position
		{
			get
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
			set
			{
				throw new NotSupportedException("Stream does not support seeking.");
			}
		}

		/// <summary>Gets a value indicating whether the final buffer block has been written to the underlying stream. </summary>
		/// <returns>
		///     <see langword="true" /> if the final block has been flushed; otherwise, <see langword="false" />. </returns>
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0005DC2B File Offset: 0x0005BE2B
		public bool HasFlushedFinalBlock
		{
			get
			{
				return this._finalBlockTransformed;
			}
		}

		/// <summary>Updates the underlying data source or repository with the current state of the buffer, then clears the buffer.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key is corrupt which can cause invalid padding to the stream. </exception>
		/// <exception cref="T:System.NotSupportedException">The current stream is not writable.-or- The final block has already been transformed. </exception>
		// Token: 0x060016D2 RID: 5842 RVA: 0x0005DC34 File Offset: 0x0005BE34
		public void FlushFinalBlock()
		{
			if (this._finalBlockTransformed)
			{
				throw new NotSupportedException("FlushFinalBlock() method was called twice on a CryptoStream. It can only be called once.");
			}
			byte[] array = this._transform.TransformFinalBlock(this._inputBuffer, 0, this._inputBufferIndex);
			this._finalBlockTransformed = true;
			if (this._canWrite && this._outputBufferIndex > 0)
			{
				this._stream.Write(this._outputBuffer, 0, this._outputBufferIndex);
				this._outputBufferIndex = 0;
			}
			if (this._canWrite)
			{
				this._stream.Write(array, 0, array.Length);
			}
			CryptoStream cryptoStream = this._stream as CryptoStream;
			if (cryptoStream != null)
			{
				if (!cryptoStream.HasFlushedFinalBlock)
				{
					cryptoStream.FlushFinalBlock();
				}
			}
			else
			{
				this._stream.Flush();
			}
			if (this._inputBuffer != null)
			{
				Array.Clear(this._inputBuffer, 0, this._inputBuffer.Length);
			}
			if (this._outputBuffer != null)
			{
				Array.Clear(this._outputBuffer, 0, this._outputBuffer.Length);
			}
		}

		/// <summary>Clears all buffers for the current stream and causes any buffered data to be written to the underlying device.</summary>
		// Token: 0x060016D3 RID: 5843 RVA: 0x00002A7D File Offset: 0x00000C7D
		public override void Flush()
		{
		}

		/// <summary>Clears all buffers for the current stream asynchronously, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A task that represents the asynchronous flush operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		// Token: 0x060016D4 RID: 5844 RVA: 0x0005DD1E File Offset: 0x0005BF1E
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (base.GetType() != typeof(CryptoStream))
			{
				return base.FlushAsync(cancellationToken);
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return Task.CompletedTask;
			}
			return Task.FromCanceled(cancellationToken);
		}

		/// <summary>Sets the position within the current stream.</summary>
		/// <param name="offset">A byte offset relative to the <paramref name="origin" /> parameter. </param>
		/// <param name="origin">A <see cref="T:System.IO.SeekOrigin" /> object indicating the reference point used to obtain the new position. </param>
		/// <returns>This method is not supported.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x060016D5 RID: 5845 RVA: 0x0005DC1F File Offset: 0x0005BE1F
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("Stream does not support seeking.");
		}

		/// <summary>Sets the length of the current stream.</summary>
		/// <param name="value">The desired length of the current stream in bytes. </param>
		/// <exception cref="T:System.NotSupportedException">This property exists only to support inheritance from <see cref="T:System.IO.Stream" />, and cannot be used.</exception>
		// Token: 0x060016D6 RID: 5846 RVA: 0x0005DC1F File Offset: 0x0005BE1F
		public override void SetLength(long value)
		{
			throw new NotSupportedException("Stream does not support seeking.");
		}

		/// <summary>Reads a sequence of bytes from the current stream asynchronously, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
		/// <param name="buffer">The buffer to write the data into.</param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A task that represents the asynchronous read operation. The value of the task object's <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
		// Token: 0x060016D7 RID: 5847 RVA: 0x0005DD54 File Offset: 0x0005BF54
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckReadArguments(buffer, offset, count);
			return this.ReadAsyncInternal(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0005DD6A File Offset: 0x0005BF6A
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0005DD83 File Offset: 0x0005BF83
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0005DD8C File Offset: 0x0005BF8C
		private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			CryptoStream.<ReadAsyncInternal>d__37 <ReadAsyncInternal>d__;
			<ReadAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadAsyncInternal>d__.<>4__this = this;
			<ReadAsyncInternal>d__.buffer = buffer;
			<ReadAsyncInternal>d__.offset = offset;
			<ReadAsyncInternal>d__.count = count;
			<ReadAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadAsyncInternal>d__.<>1__state = -1;
			<ReadAsyncInternal>d__.<>t__builder.Start<CryptoStream.<ReadAsyncInternal>d__37>(ref <ReadAsyncInternal>d__);
			return <ReadAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0005DDF0 File Offset: 0x0005BFF0
		public override int ReadByte()
		{
			if (this._outputBufferIndex > 1)
			{
				int result = (int)this._outputBuffer[0];
				Buffer.BlockCopy(this._outputBuffer, 1, this._outputBuffer, 0, this._outputBufferIndex - 1);
				this._outputBufferIndex--;
				return result;
			}
			return base.ReadByte();
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0005DE40 File Offset: 0x0005C040
		public override void WriteByte(byte value)
		{
			if (this._inputBufferIndex + 1 < this._inputBlockSize)
			{
				byte[] inputBuffer = this._inputBuffer;
				int inputBufferIndex = this._inputBufferIndex;
				this._inputBufferIndex = inputBufferIndex + 1;
				inputBuffer[inputBufferIndex] = value;
				return;
			}
			base.WriteByte(value);
		}

		/// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
		/// <param name="buffer">An array of bytes. A maximum of <paramref name="count" /> bytes are read from the current stream and stored in <paramref name="buffer" />. </param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream. </param>
		/// <param name="count">The maximum number of bytes to be read from the current stream. </param>
		/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero if the end of the stream has been reached.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> associated with current <see cref="T:System.Security.Cryptography.CryptoStream" /> object does not match the underlying stream.  For example, this exception is thrown when using <see cref="F:System.Security.Cryptography.CryptoStreamMode.Read" /> with an underlying stream that is write only.  </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.-or- The <paramref name="count" /> parameter is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">Thesum of the <paramref name="count" /> and <paramref name="offset" /> parameters is longer than the length of the buffer. </exception>
		// Token: 0x060016DD RID: 5853 RVA: 0x0005DE80 File Offset: 0x0005C080
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.CheckReadArguments(buffer, offset, count);
			return this.ReadAsyncCore(buffer, offset, count, default(CancellationToken), false).GetAwaiter().GetResult();
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0005DEB8 File Offset: 0x0005C0B8
		private void CheckReadArguments(byte[] buffer, int offset, int count)
		{
			if (!this.CanRead)
			{
				throw new NotSupportedException("Stream does not support reading.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0005DF14 File Offset: 0x0005C114
		private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			CryptoStream.<ReadAsyncCore>d__42 <ReadAsyncCore>d__;
			<ReadAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ReadAsyncCore>d__.<>4__this = this;
			<ReadAsyncCore>d__.buffer = buffer;
			<ReadAsyncCore>d__.offset = offset;
			<ReadAsyncCore>d__.count = count;
			<ReadAsyncCore>d__.cancellationToken = cancellationToken;
			<ReadAsyncCore>d__.useAsync = useAsync;
			<ReadAsyncCore>d__.<>1__state = -1;
			<ReadAsyncCore>d__.<>t__builder.Start<CryptoStream.<ReadAsyncCore>d__42>(ref <ReadAsyncCore>d__);
			return <ReadAsyncCore>d__.<>t__builder.Task;
		}

		/// <summary>Writes a sequence of bytes to the current stream asynchronously, advances the current position within the stream by the number of bytes written, and monitors cancellation requests.</summary>
		/// <param name="buffer">The buffer to write data from.</param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin writing bytes to the stream.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
		// Token: 0x060016E0 RID: 5856 RVA: 0x0005DF81 File Offset: 0x0005C181
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckWriteArguments(buffer, offset, count);
			return this.WriteAsyncInternal(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0005DF97 File Offset: 0x0005C197
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0005DFB0 File Offset: 0x0005C1B0
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
		private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			CryptoStream.<WriteAsyncInternal>d__46 <WriteAsyncInternal>d__;
			<WriteAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncInternal>d__.<>4__this = this;
			<WriteAsyncInternal>d__.buffer = buffer;
			<WriteAsyncInternal>d__.offset = offset;
			<WriteAsyncInternal>d__.count = count;
			<WriteAsyncInternal>d__.cancellationToken = cancellationToken;
			<WriteAsyncInternal>d__.<>1__state = -1;
			<WriteAsyncInternal>d__.<>t__builder.Start<CryptoStream.<WriteAsyncInternal>d__46>(ref <WriteAsyncInternal>d__);
			return <WriteAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Writes a sequence of bytes to the current <see cref="T:System.Security.Cryptography.CryptoStream" /> and advances the current position within the stream by the number of bytes written.</summary>
		/// <param name="buffer">An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" /> to the current stream. </param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream. </param>
		/// <param name="count">The number of bytes to be written to the current stream. </param>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Security.Cryptography.CryptoStreamMode" /> associated with current <see cref="T:System.Security.Cryptography.CryptoStream" /> object does not match the underlying stream.  For example, this exception is thrown when using <see cref="F:System.Security.Cryptography.CryptoStreamMode.Write" />  with an underlying stream that is read only.  </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than zero.-or- The <paramref name="count" /> parameter is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">The sum of the <paramref name="count" /> and <paramref name="offset" /> parameters is longer than the length of the buffer. </exception>
		// Token: 0x060016E4 RID: 5860 RVA: 0x0005E01C File Offset: 0x0005C21C
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.CheckWriteArguments(buffer, offset, count);
			this.WriteAsyncCore(buffer, offset, count, default(CancellationToken), false).GetAwaiter().GetResult();
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0005E054 File Offset: 0x0005C254
		private void CheckWriteArguments(byte[] buffer, int offset, int count)
		{
			if (!this.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0005E0B0 File Offset: 0x0005C2B0
		private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			CryptoStream.<WriteAsyncCore>d__49 <WriteAsyncCore>d__;
			<WriteAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteAsyncCore>d__.<>4__this = this;
			<WriteAsyncCore>d__.buffer = buffer;
			<WriteAsyncCore>d__.offset = offset;
			<WriteAsyncCore>d__.count = count;
			<WriteAsyncCore>d__.cancellationToken = cancellationToken;
			<WriteAsyncCore>d__.useAsync = useAsync;
			<WriteAsyncCore>d__.<>1__state = -1;
			<WriteAsyncCore>d__.<>t__builder.Start<CryptoStream.<WriteAsyncCore>d__49>(ref <WriteAsyncCore>d__);
			return <WriteAsyncCore>d__.<>t__builder.Task;
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
		// Token: 0x060016E7 RID: 5863 RVA: 0x0005E11D File Offset: 0x0005C31D
		public void Clear()
		{
			this.Close();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.CryptoStream" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060016E8 RID: 5864 RVA: 0x0005E128 File Offset: 0x0005C328
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (!this._finalBlockTransformed)
					{
						this.FlushFinalBlock();
					}
					if (!this._leaveOpen)
					{
						this._stream.Dispose();
					}
				}
			}
			finally
			{
				try
				{
					this._finalBlockTransformed = true;
					if (this._inputBuffer != null)
					{
						Array.Clear(this._inputBuffer, 0, this._inputBuffer.Length);
					}
					if (this._outputBuffer != null)
					{
						Array.Clear(this._outputBuffer, 0, this._outputBuffer.Length);
					}
					this._inputBuffer = null;
					this._outputBuffer = null;
					this._canRead = false;
					this._canWrite = false;
				}
				finally
				{
					base.Dispose(disposing);
				}
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0005E1E0 File Offset: 0x0005C3E0
		private void InitializeBuffer()
		{
			if (this._transform != null)
			{
				this._inputBlockSize = this._transform.InputBlockSize;
				this._inputBuffer = new byte[this._inputBlockSize];
				this._outputBlockSize = this._transform.OutputBlockSize;
				this._outputBuffer = new byte[this._outputBlockSize];
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x0005E239 File Offset: 0x0005C439
		private SemaphoreSlim AsyncActiveSemaphore
		{
			get
			{
				return LazyInitializer.EnsureInitialized<SemaphoreSlim>(ref this._lazyAsyncActiveSemaphore, () => new SemaphoreSlim(1, 1));
			}
		}

		// Token: 0x0400091C RID: 2332
		private readonly Stream _stream;

		// Token: 0x0400091D RID: 2333
		private readonly ICryptoTransform _transform;

		// Token: 0x0400091E RID: 2334
		private readonly CryptoStreamMode _transformMode;

		// Token: 0x0400091F RID: 2335
		private byte[] _inputBuffer;

		// Token: 0x04000920 RID: 2336
		private int _inputBufferIndex;

		// Token: 0x04000921 RID: 2337
		private int _inputBlockSize;

		// Token: 0x04000922 RID: 2338
		private byte[] _outputBuffer;

		// Token: 0x04000923 RID: 2339
		private int _outputBufferIndex;

		// Token: 0x04000924 RID: 2340
		private int _outputBlockSize;

		// Token: 0x04000925 RID: 2341
		private bool _canRead;

		// Token: 0x04000926 RID: 2342
		private bool _canWrite;

		// Token: 0x04000927 RID: 2343
		private bool _finalBlockTransformed;

		// Token: 0x04000928 RID: 2344
		private SemaphoreSlim _lazyAsyncActiveSemaphore;

		// Token: 0x04000929 RID: 2345
		private readonly bool _leaveOpen;
	}
}
