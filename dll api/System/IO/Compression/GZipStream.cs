using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression
{
	/// <summary>Provides methods and properties used to compress and decompress streams.</summary>
	// Token: 0x02000229 RID: 553
	public class GZipStream : Stream
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.GZipStream" /> class by using the specified stream and compression mode.</summary>
		/// <param name="stream">The stream the compressed or decompressed data is written to.</param>
		/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> enumeration value.-or-
		///         <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" />  and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.-or-
		///         <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" />  and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
		// Token: 0x06000F02 RID: 3842 RVA: 0x0004C252 File Offset: 0x0004A452
		public GZipStream(Stream stream, CompressionMode mode) : this(stream, mode, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.GZipStream" /> class by using the specified stream and compression mode, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream the compressed or decompressed data is written to.</param>
		/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
		/// <param name="leaveOpen">
		///       <see langword="true" /> to leave the stream open after disposing the <see cref="T:System.IO.Compression.GZipStream" /> object; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> value.-or-
		///         <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" />  and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.-or-
		///         <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" />  and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
		// Token: 0x06000F03 RID: 3843 RVA: 0x0004C25D File Offset: 0x0004A45D
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
			this._deflateStream = new DeflateStream(stream, mode, leaveOpen, 31);
		}

		/// <summary>Gets a value indicating whether the stream supports reading while decompressing a file.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Decompress," /> and the underlying stream supports reading and is not closed; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0004C275 File Offset: 0x0004A475
		public override bool CanRead
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				return deflateStream != null && deflateStream.CanRead;
			}
		}

		/// <summary>Gets a value indicating whether the stream supports writing.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Compress" />, and the underlying stream supports writing and is not closed; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0004C288 File Offset: 0x0004A488
		public override bool CanWrite
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				return deflateStream != null && deflateStream.CanWrite;
			}
		}

		/// <summary>Gets a value indicating whether the stream supports seeking.</summary>
		/// <returns>
		///     <see langword="false" /> in all cases.</returns>
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0004C29B File Offset: 0x0004A49B
		public override bool CanSeek
		{
			get
			{
				DeflateStream deflateStream = this._deflateStream;
				return deflateStream != null && deflateStream.CanSeek;
			}
		}

		/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>A long value.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0004C2AE File Offset: 0x0004A4AE
		public override long Length
		{
			get
			{
				throw new NotSupportedException("This operation is not supported.");
			}
		}

		/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>A long value.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0004C2AE File Offset: 0x0004A4AE
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0004C2AE File Offset: 0x0004A4AE
		public override long Position
		{
			get
			{
				throw new NotSupportedException("This operation is not supported.");
			}
			set
			{
				throw new NotSupportedException("This operation is not supported.");
			}
		}

		/// <summary>The current implementation of this method has no functionality.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
		// Token: 0x06000F0A RID: 3850 RVA: 0x0004C2BA File Offset: 0x0004A4BA
		public override void Flush()
		{
			this.CheckDeflateStream();
			this._deflateStream.Flush();
		}

		/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">The location in the stream.</param>
		/// <param name="origin">One of the <see cref="T:System.IO.SeekOrigin" /> values.</param>
		/// <returns>A long value.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x06000F0B RID: 3851 RVA: 0x0004C2AE File Offset: 0x0004A4AE
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("This operation is not supported.");
		}

		/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">The length of the stream.</param>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x06000F0C RID: 3852 RVA: 0x0004C2AE File Offset: 0x0004A4AE
		public override void SetLength(long value)
		{
			throw new NotSupportedException("This operation is not supported.");
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0004C2CD File Offset: 0x0004A4CD
		public override int ReadByte()
		{
			this.CheckDeflateStream();
			return this._deflateStream.ReadByte();
		}

		/// <summary>Begins an asynchronous read operation. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="array">The byte array to read the data into.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading data from the stream.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <param name="asyncCallback">An optional asynchronous callback, to be called when the read operation is complete.</param>
		/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
		/// <returns>An object that represents the asynchronous read operation, which could still be pending.</returns>
		/// <exception cref="T:System.IO.IOException">The method tried to  read asynchronously past the end of the stream, or a disk error occurred.</exception>
		/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.GZipStream" /> implementation does not support the read operation.</exception>
		/// <exception cref="T:System.InvalidOperationException">A read operation cannot be performed because the stream is closed.</exception>
		// Token: 0x06000F0E RID: 3854 RVA: 0x0004C2E0 File Offset: 0x0004A4E0
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.ReadAsync(array, offset, count, CancellationToken.None), asyncCallback, asyncState);
		}

		/// <summary>Waits for the pending asynchronous read to complete. (Consider using the the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
		/// <returns>The number of bytes read from the stream, between 0 (zero) and the number of bytes you requested. <see cref="T:System.IO.Compression.GZipStream" /> returns 0 only at the end of the stream; otherwise, it blocks until at least one byte is available.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
		/// <exception cref="T:System.InvalidOperationException">The end operation cannot be performed because the stream is closed.</exception>
		// Token: 0x06000F0F RID: 3855 RVA: 0x0004C061 File Offset: 0x0004A261
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		/// <summary>Reads a number of decompressed bytes into the specified byte array.</summary>
		/// <param name="array">The array used to store decompressed bytes.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
		/// <param name="count">The maximum number of decompressed bytes to read.</param>
		/// <returns>The number of bytes that were decompressed into the byte array. If the end of the stream has been reached, zero or the number of bytes read is returned.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.IO.Compression.CompressionMode" /> value was <see langword="Compress" /> when the object was created.- or -The underlying stream does not support reading.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is less than zero.-or-
		///         <paramref name="array" /> length minus the index starting point is less than <paramref name="count" />.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">The data is in an invalid format.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
		// Token: 0x06000F10 RID: 3856 RVA: 0x0004C2F9 File Offset: 0x0004A4F9
		public override int Read(byte[] array, int offset, int count)
		{
			this.CheckDeflateStream();
			return this._deflateStream.Read(array, offset, count);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0004C30F File Offset: 0x0004A50F
		public override int Read(Span<byte> buffer)
		{
			if (base.GetType() != typeof(GZipStream))
			{
				return base.Read(buffer);
			}
			this.CheckDeflateStream();
			return this._deflateStream.ReadCore(buffer);
		}

		/// <summary>Begins an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="array">The buffer containing data to write to the current stream.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin writing.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <param name="asyncCallback">An optional asynchronous callback to be called when the write operation is complete.</param>
		/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <returns>An  object that represents the asynchronous write operation, which could still be pending.</returns>
		/// <exception cref="T:System.InvalidOperationException">The underlying stream is <see langword="null" />. -or-The underlying stream is closed.</exception>
		// Token: 0x06000F12 RID: 3858 RVA: 0x0004C342 File Offset: 0x0004A542
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.WriteAsync(array, offset, count, CancellationToken.None), asyncCallback, asyncState);
		}

		/// <summary>Handles the end of an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="asyncResult">The object that represents the asynchronous call.</param>
		/// <exception cref="T:System.InvalidOperationException">The underlying stream is <see langword="null" />. -or-The underlying stream is closed.</exception>
		// Token: 0x06000F13 RID: 3859 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		/// <summary>Writes compressed bytes to the underlying stream from the specified byte array.</summary>
		/// <param name="array">The buffer that contains the data to compress.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <exception cref="T:System.ObjectDisposedException">The write operation cannot be performed because the stream is closed.</exception>
		// Token: 0x06000F14 RID: 3860 RVA: 0x0004C35B File Offset: 0x0004A55B
		public override void Write(byte[] array, int offset, int count)
		{
			this.CheckDeflateStream();
			this._deflateStream.Write(array, offset, count);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0004C371 File Offset: 0x0004A571
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() != typeof(GZipStream))
			{
				base.Write(buffer);
				return;
			}
			this.CheckDeflateStream();
			this._deflateStream.WriteCore(buffer);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0004C3A4 File Offset: 0x0004A5A4
		public override void CopyTo(Stream destination, int bufferSize)
		{
			this.CheckDeflateStream();
			this._deflateStream.CopyTo(destination, bufferSize);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Compression.GZipStream" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x06000F17 RID: 3863 RVA: 0x0004C3BC File Offset: 0x0004A5BC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this._deflateStream != null)
				{
					this._deflateStream.Dispose();
				}
				this._deflateStream = null;
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0004C400 File Offset: 0x0004A600
		public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.ReadAsync(array, offset, count, cancellationToken);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0004C418 File Offset: 0x0004A618
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(GZipStream))
			{
				return base.ReadAsync(buffer, cancellationToken);
			}
			this.CheckDeflateStream();
			return this._deflateStream.ReadAsyncMemory(buffer, cancellationToken);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0004C44D File Offset: 0x0004A64D
		public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.WriteAsync(array, offset, count, cancellationToken);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0004C465 File Offset: 0x0004A665
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (base.GetType() != typeof(GZipStream))
			{
				return base.WriteAsync(buffer, cancellationToken);
			}
			this.CheckDeflateStream();
			return this._deflateStream.WriteAsyncMemory(buffer, cancellationToken);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0004C49A File Offset: 0x0004A69A
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			this.CheckDeflateStream();
			return this._deflateStream.FlushAsync(cancellationToken);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0004C4AE File Offset: 0x0004A6AE
		private void CheckDeflateStream()
		{
			if (this._deflateStream == null)
			{
				GZipStream.ThrowStreamClosedException();
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004C4BD File Offset: 0x0004A6BD
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowStreamClosedException()
		{
			throw new ObjectDisposedException(null, "Cannot access a closed Stream.");
		}

		// Token: 0x04000BEA RID: 3050
		private DeflateStream _deflateStream;
	}
}
