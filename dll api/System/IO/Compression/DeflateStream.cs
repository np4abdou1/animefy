using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Compression
{
	/// <summary>Provides methods and properties for compressing and decompressing streams by using the Deflate algorithm.</summary>
	// Token: 0x0200022A RID: 554
	public class DeflateStream : Stream
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Compression.DeflateStream" /> class by using the specified stream and compression mode.</summary>
		/// <param name="stream">The stream to compress or decompress.</param>
		/// <param name="mode">One of the enumeration values that indicates whether to compress or decompress the stream.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="stream" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="mode" /> is not a valid <see cref="T:System.IO.Compression.CompressionMode" /> value.-or-
		///         <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Compress" />  and <see cref="P:System.IO.Stream.CanWrite" /> is <see langword="false" />.-or-
		///         <see cref="T:System.IO.Compression.CompressionMode" /> is <see cref="F:System.IO.Compression.CompressionMode.Decompress" />  and <see cref="P:System.IO.Stream.CanRead" /> is <see langword="false" />.</exception>
		// Token: 0x06000F1F RID: 3871 RVA: 0x0004C4CA File Offset: 0x0004A6CA
		public DeflateStream(Stream stream, CompressionMode mode) : this(stream, mode, false, false)
		{
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004C4D6 File Offset: 0x0004A6D6
		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) : this(stream, mode, leaveOpen, true)
		{
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
		{
			if (compressedStream == null)
			{
				throw new ArgumentNullException("compressedStream");
			}
			if (mode != CompressionMode.Compress && mode != CompressionMode.Decompress)
			{
				throw new ArgumentException("mode");
			}
			this.base_stream = compressedStream;
			this.native = DeflateStreamNative.Create(compressedStream, mode, gzip);
			if (this.native == null)
			{
				throw new NotImplementedException("Failed to initialize zlib. You probably have an old zlib installed. Version 1.2.0.4 or later is required.");
			}
			this.mode = mode;
			this.leaveOpen = leaveOpen;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0004C550 File Offset: 0x0004A750
		~DeflateStream()
		{
			this.Dispose(false);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Compression.DeflateStream" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x06000F23 RID: 3875 RVA: 0x0004C580 File Offset: 0x0004A780
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				GC.SuppressFinalize(this);
			}
			DeflateStreamNative deflateStreamNative = this.native;
			if (deflateStreamNative != null)
			{
				deflateStreamNative.Dispose(disposing);
			}
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (!this.leaveOpen)
				{
					Stream stream = this.base_stream;
					if (stream != null)
					{
						stream.Close();
					}
					this.base_stream = null;
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0004C5E0 File Offset: 0x0004A7E0
		private unsafe int ReadInternal(byte[] array, int offset, int count)
		{
			if (count == 0)
			{
				return 0;
			}
			byte* ptr;
			if (array == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			IntPtr buffer = new IntPtr((void*)(ptr + offset));
			return this.native.ReadZStream(buffer, count);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0004C621 File Offset: 0x0004A821
		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
		{
			return base.ReadAsync(destination, cancellationToken);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0004C62C File Offset: 0x0004A82C
		internal int ReadCore(Span<byte> destination)
		{
			byte[] array = new byte[destination.Length];
			int num = this.Read(array, 0, array.Length);
			array.AsSpan(0, num).CopyTo(destination);
			return num;
		}

		/// <summary>Reads a number of decompressed bytes into the specified byte array.</summary>
		/// <param name="array">The array to store decompressed bytes.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
		/// <param name="count">The maximum number of decompressed bytes to read.</param>
		/// <returns>The number of bytes that were read into the byte array.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.IO.Compression.CompressionMode" /> value was <see langword="Compress" /> when the object was created.- or - The underlying stream does not support reading.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is less than zero.-or-
		///         <paramref name="array" /> length minus the index starting point is less than <paramref name="count" />.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">The data is in an invalid format.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
		// Token: 0x06000F27 RID: 3879 RVA: 0x0004C664 File Offset: 0x0004A864
		public override int Read(byte[] array, int offset, int count)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (array == null)
			{
				throw new ArgumentNullException("Destination array is null.");
			}
			if (!this.CanRead)
			{
				throw new InvalidOperationException("Stream does not support reading.");
			}
			int num = array.Length;
			if (offset < 0 || count < 0)
			{
				throw new ArgumentException("Dest or count is negative.");
			}
			if (offset > num)
			{
				throw new ArgumentException("destination offset is beyond array size");
			}
			if (offset + count > num)
			{
				throw new ArgumentException("Reading would overrun buffer");
			}
			return this.ReadInternal(array, offset, count);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0004C6EC File Offset: 0x0004A8EC
		private unsafe void WriteInternal(byte[] array, int offset, int count)
		{
			if (count == 0)
			{
				return;
			}
			fixed (byte[] array2 = array)
			{
				byte* ptr;
				if (array == null || array2.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array2[0];
				}
				IntPtr buffer = new IntPtr((void*)(ptr + offset));
				this.native.WriteZStream(buffer, count);
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0004C72E File Offset: 0x0004A92E
		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			return base.WriteAsync(source, cancellationToken);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004C738 File Offset: 0x0004A938
		internal void WriteCore(ReadOnlySpan<byte> source)
		{
			this.Write(source.ToArray(), 0, source.Length);
		}

		/// <summary>Writes compressed bytes to the underlying stream from the specified byte array.</summary>
		/// <param name="array">The buffer that contains the data to compress.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		// Token: 0x06000F2B RID: 3883 RVA: 0x0004C750 File Offset: 0x0004A950
		public override void Write(byte[] array, int offset, int count)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (!this.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing");
			}
			if (offset > array.Length - count)
			{
				throw new ArgumentException("Buffer too small. count/offset wrong.");
			}
			this.WriteInternal(array, offset, count);
		}

		/// <summary>The current implementation of this method has no functionality.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
		// Token: 0x06000F2C RID: 3884 RVA: 0x0004C7D1 File Offset: 0x0004A9D1
		public override void Flush()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (this.CanWrite)
			{
				this.native.Flush();
			}
		}

		/// <summary>Begins an asynchronous read operation. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="array">The byte array to read the data into.</param>
		/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading data from the stream.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <param name="asyncCallback">An optional asynchronous callback, to be called when the read operation is complete.</param>
		/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
		/// <returns>An  object that represents the asynchronous read operation, which could still be pending.</returns>
		/// <exception cref="T:System.IO.IOException">The method tried to read asynchronously past the end of the stream, or a disk error occurred.</exception>
		/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.DeflateStream" /> implementation does not support the read operation.</exception>
		/// <exception cref="T:System.InvalidOperationException">This call cannot be completed. </exception>
		// Token: 0x06000F2D RID: 3885 RVA: 0x0004C800 File Offset: 0x0004AA00
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanRead)
			{
				throw new NotSupportedException("This stream does not support reading");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			if (count + offset > array.Length)
			{
				throw new ArgumentException("Buffer too small. count/offset wrong.");
			}
			return new DeflateStream.ReadMethod(this.ReadInternal).BeginInvoke(array, offset, count, asyncCallback, asyncState);
		}

		/// <summary>Begins an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="array">The buffer to write data from.</param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> to begin writing from.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <param name="asyncCallback">An optional asynchronous callback, to be called when the write operation is complete.</param>
		/// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <returns>An  object that represents the asynchronous write operation, which could still be pending.</returns>
		/// <exception cref="T:System.IO.IOException">The method tried to write asynchronously past the end of the stream, or a disk error occurred.</exception>
		/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
		/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.DeflateStream" /> implementation does not support the write operation.</exception>
		/// <exception cref="T:System.InvalidOperationException">The write operation cannot be performed because the stream is closed.</exception>
		// Token: 0x06000F2E RID: 3886 RVA: 0x0004C89C File Offset: 0x0004AA9C
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanWrite)
			{
				throw new InvalidOperationException("This stream does not support writing");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			if (count + offset > array.Length)
			{
				throw new ArgumentException("Buffer too small. count/offset wrong.");
			}
			return new DeflateStream.WriteMethod(this.WriteInternal).BeginInvoke(array, offset, count, asyncCallback, asyncState);
		}

		/// <summary>Waits for the pending asynchronous read to complete. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
		/// <returns>The number of bytes read from the stream, between 0 (zero) and the number of bytes you requested. <see cref="T:System.IO.Compression.DeflateStream" /> returns 0 only at the end of the stream; otherwise, it blocks until at least one byte is available.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
		/// <exception cref="T:System.SystemException">An exception was thrown during a call to <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The end call is invalid because asynchronous read operations for this stream are not yet complete.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is <see langword="null" />.</exception>
		// Token: 0x06000F2F RID: 3887 RVA: 0x0004C938 File Offset: 0x0004AB38
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			DeflateStream.ReadMethod readMethod = asyncResult2.AsyncDelegate as DeflateStream.ReadMethod;
			if (readMethod == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			return readMethod.EndInvoke(asyncResult);
		}

		/// <summary>Ends an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
		/// <param name="asyncResult">A reference to the outstanding asynchronous I/O request.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
		/// <exception cref="T:System.Exception">An exception was thrown during a call to <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The end write call is invalid.</exception>
		// Token: 0x06000F30 RID: 3888 RVA: 0x0004C990 File Offset: 0x0004AB90
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			DeflateStream.WriteMethod writeMethod = asyncResult2.AsyncDelegate as DeflateStream.WriteMethod;
			if (writeMethod == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			writeMethod.EndInvoke(asyncResult);
		}

		/// <summary>This operation is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">The location in the stream.</param>
		/// <param name="origin">One of the <see cref="T:System.IO.SeekOrigin" /> values.</param>
		/// <returns>A long value.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x06000F31 RID: 3889 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		/// <summary>This operation is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">The length of the stream.</param>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x06000F32 RID: 3890 RVA: 0x00003E34 File Offset: 0x00002034
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		/// <summary>Gets a value indicating whether the stream supports reading while decompressing a file.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Decompress" />, and the underlying stream is opened and supports reading; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0004C9E7 File Offset: 0x0004ABE7
		public override bool CanRead
		{
			get
			{
				return !this.disposed && this.mode == CompressionMode.Decompress && this.base_stream.CanRead;
			}
		}

		/// <summary>Gets a value indicating whether the stream supports seeking.</summary>
		/// <returns>
		///     <see langword="false" /> in all cases.</returns>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the stream supports writing.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.IO.Compression.CompressionMode" /> value is <see langword="Compress" />, and the underlying stream supports writing and is not closed; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0004CA06 File Offset: 0x0004AC06
		public override bool CanWrite
		{
			get
			{
				return !this.disposed && this.mode == CompressionMode.Compress && this.base_stream.CanWrite;
			}
		}

		/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>A long value.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>This property is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>A long value.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x04000BEB RID: 3051
		private Stream base_stream;

		// Token: 0x04000BEC RID: 3052
		private CompressionMode mode;

		// Token: 0x04000BED RID: 3053
		private bool leaveOpen;

		// Token: 0x04000BEE RID: 3054
		private bool disposed;

		// Token: 0x04000BEF RID: 3055
		private DeflateStreamNative native;

		// Token: 0x0200022B RID: 555
		// (Invoke) Token: 0x06000F3A RID: 3898
		private delegate int ReadMethod(byte[] array, int offset, int count);

		// Token: 0x0200022C RID: 556
		// (Invoke) Token: 0x06000F3E RID: 3902
		private delegate void WriteMethod(byte[] array, int offset, int count);
	}
}
