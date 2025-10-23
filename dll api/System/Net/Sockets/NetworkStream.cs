using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Provides the underlying stream of data for network access.</summary>
	// Token: 0x020001FA RID: 506
	public class NetworkStream : Stream
	{
		/// <summary>Creates a new instance of the <see cref="T:System.Net.Sockets.NetworkStream" /> class for the specified <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket" /> that the <see cref="T:System.Net.Sockets.NetworkStream" /> will use to send and receive data. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.IOException">The <paramref name="socket" /> parameter is not connected.-or- The <see cref="P:System.Net.Sockets.Socket.SocketType" /> property of the <paramref name="socket" /> parameter is not <see cref="F:System.Net.Sockets.SocketType.Stream" />.-or- The <paramref name="socket" /> parameter is in a nonblocking state. </exception>
		// Token: 0x06000D72 RID: 3442 RVA: 0x00046949 File Offset: 0x00044B49
		public NetworkStream(Socket socket) : this(socket, FileAccess.ReadWrite, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.NetworkStream" /> class for the specified <see cref="T:System.Net.Sockets.Socket" /> with the specified <see cref="T:System.Net.Sockets.Socket" /> ownership.</summary>
		/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket" /> that the <see cref="T:System.Net.Sockets.NetworkStream" /> will use to send and receive data. </param>
		/// <param name="ownsSocket">Set to <see langword="true" /> to indicate that the <see cref="T:System.Net.Sockets.NetworkStream" /> will take ownership of the <see cref="T:System.Net.Sockets.Socket" />; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.IOException">The <paramref name="socket" /> parameter is not connected.-or- the value of the <see cref="P:System.Net.Sockets.Socket.SocketType" /> property of the <paramref name="socket" /> parameter is not <see cref="F:System.Net.Sockets.SocketType.Stream" />.-or- the <paramref name="socket" /> parameter is in a nonblocking state. </exception>
		// Token: 0x06000D73 RID: 3443 RVA: 0x00046954 File Offset: 0x00044B54
		public NetworkStream(Socket socket, bool ownsSocket) : this(socket, FileAccess.ReadWrite, ownsSocket)
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Sockets.NetworkStream" /> class for the specified <see cref="T:System.Net.Sockets.Socket" /> with the specified access rights and the specified <see cref="T:System.Net.Sockets.Socket" /> ownership.</summary>
		/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket" /> that the <see cref="T:System.Net.Sockets.NetworkStream" /> will use to send and receive data. </param>
		/// <param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess" /> values that specifies the type of access given to the <see cref="T:System.Net.Sockets.NetworkStream" /> over the provided <see cref="T:System.Net.Sockets.Socket" />. </param>
		/// <param name="ownsSocket">Set to <see langword="true" /> to indicate that the <see cref="T:System.Net.Sockets.NetworkStream" /> will take ownership of the <see cref="T:System.Net.Sockets.Socket" />; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.IOException">The <paramref name="socket" /> parameter is not connected.-or- The <see cref="P:System.Net.Sockets.Socket.SocketType" /> property of the <paramref name="socket" /> parameter is not <see cref="F:System.Net.Sockets.SocketType.Stream" />.-or- The <paramref name="socket" /> parameter is in a nonblocking state. </exception>
		// Token: 0x06000D74 RID: 3444 RVA: 0x00046960 File Offset: 0x00044B60
		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
		{
			if (socket == null)
			{
				throw new ArgumentNullException("socket");
			}
			if (!socket.Blocking)
			{
				throw new IOException("The operation is not allowed on a non-blocking Socket.");
			}
			if (!socket.Connected)
			{
				throw new IOException("The operation is not allowed on non-connected sockets.");
			}
			if (socket.SocketType != SocketType.Stream)
			{
				throw new IOException("The operation is not allowed on non-stream oriented sockets.");
			}
			this._streamSocket = socket;
			this._ownsSocket = ownsSocket;
			switch (access)
			{
			case FileAccess.Read:
				this._readable = true;
				return;
			case FileAccess.Write:
				this._writeable = true;
				return;
			}
			this._readable = true;
			this._writeable = true;
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Net.Sockets.NetworkStream" /> supports reading.</summary>
		/// <returns>
		///     <see langword="true" /> if data can be read from the stream; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00046A12 File Offset: 0x00044C12
		public override bool CanRead
		{
			get
			{
				return this._readable;
			}
		}

		/// <summary>Gets a value that indicates whether the stream supports seeking. This property is not currently supported.This property always returns <see langword="false" />.</summary>
		/// <returns>
		///     <see langword="false" /> in all cases to indicate that <see cref="T:System.Net.Sockets.NetworkStream" /> cannot seek a specific location in the stream.</returns>
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Net.Sockets.NetworkStream" /> supports writing.</summary>
		/// <returns>
		///     <see langword="true" /> if data can be written to the <see cref="T:System.Net.Sockets.NetworkStream" />; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00046A1A File Offset: 0x00044C1A
		public override bool CanWrite
		{
			get
			{
				return this._writeable;
			}
		}

		/// <summary>Indicates whether timeout properties are usable for <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <returns>
		///     <see langword="true" /> in all cases.</returns>
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00009518 File Offset: 0x00007718
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets or sets the amount of time that a read operation blocks waiting for data. </summary>
		/// <returns>A <see cref="T:System.Int32" /> that specifies the amount of time, in milliseconds, that will elapse before a read operation fails. The default value, <see cref="F:System.Threading.Timeout.Infinite" />, specifies that the read operation does not time out.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00046A24 File Offset: 0x00044C24
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00046A52 File Offset: 0x00044C52
		public override int ReadTimeout
		{
			get
			{
				int num = (int)this._streamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
				if (num == 0)
				{
					return -1;
				}
				return num;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value > 0.");
				}
				this.SetSocketTimeoutOption(SocketShutdown.Receive, value, false);
			}
		}

		/// <summary>Gets or sets the amount of time that a write operation blocks waiting for data. </summary>
		/// <returns>A <see cref="T:System.Int32" /> that specifies the amount of time, in milliseconds, that will elapse before a write operation fails. The default value, <see cref="F:System.Threading.Timeout.Infinite" />, specifies that the write operation does not time out.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00046A78 File Offset: 0x00044C78
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00046AA6 File Offset: 0x00044CA6
		public override int WriteTimeout
		{
			get
			{
				int num = (int)this._streamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
				if (num == 0)
				{
					return -1;
				}
				return num;
			}
			set
			{
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value > 0.");
				}
				this.SetSocketTimeoutOption(SocketShutdown.Send, value, false);
			}
		}

		/// <summary>Gets the length of the data available on the stream. This property is not currently supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>The length of the data available on the stream.</returns>
		/// <exception cref="T:System.NotSupportedException">Any use of this property. </exception>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00042362 File Offset: 0x00040562
		public override long Length
		{
			get
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
		}

		/// <summary>Gets or sets the current position in the stream. This property is not currently supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>The current position in the stream.</returns>
		/// <exception cref="T:System.NotSupportedException">Any use of this property. </exception>
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00042362 File Offset: 0x00040562
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00042362 File Offset: 0x00040562
		public override long Position
		{
			get
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
			set
			{
				throw new NotSupportedException("This stream does not support seek operations.");
			}
		}

		/// <summary>Sets the current position of the stream to the given value. This method is not currently supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">This parameter is not used. </param>
		/// <param name="origin">This parameter is not used. </param>
		/// <returns>The position in the stream.</returns>
		/// <exception cref="T:System.NotSupportedException">Any use of this property. </exception>
		// Token: 0x06000D80 RID: 3456 RVA: 0x00042362 File Offset: 0x00040562
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("This stream does not support seek operations.");
		}

		/// <summary>Reads data from the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the location in memory to store data read from the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <param name="offset">The location in <paramref name="buffer" /> to begin storing the data to. </param>
		/// <param name="size">The number of bytes to read from the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <returns>The number of bytes read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.-or- The <paramref name="offset" /> parameter is greater than the length of <paramref name="buffer" />.-or- The <paramref name="size" /> parameter is less than 0.-or- The <paramref name="size" /> parameter is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. -or-An error occurred when accessing the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.-or- There is a failure reading from the network. </exception>
		// Token: 0x06000D81 RID: 3457 RVA: 0x00046ACC File Offset: 0x00044CCC
		public override int Read(byte[] buffer, int offset, int size)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			int result;
			try
			{
				result = this._streamSocket.Receive(buffer, offset, size, SocketFlags.None);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00046B98 File Offset: 0x00044D98
		public override int Read(Span<byte> destination)
		{
			if (base.GetType() != typeof(NetworkStream))
			{
				return base.Read(destination);
			}
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			SocketError socketError;
			int result = this._streamSocket.Receive(destination, SocketFlags.None, out socketError);
			if (socketError != SocketError.Success)
			{
				SocketException ex = new SocketException((int)socketError);
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00046C24 File Offset: 0x00044E24
		public unsafe override int ReadByte()
		{
			byte result;
			if (this.Read(new Span<byte>((void*)(&result), 1)) != 0)
			{
				return (int)result;
			}
			return -1;
		}

		/// <summary>Writes data to the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to write to the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <param name="offset">The location in <paramref name="buffer" /> from which to start writing data. </param>
		/// <param name="size">The number of bytes to write to the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.-or- The <paramref name="offset" /> parameter is greater than the length of <paramref name="buffer" />.-or- The <paramref name="size" /> parameter is less than 0.-or- The <paramref name="size" /> parameter is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.IO.IOException">There was a failure while writing to the network. -or-An error occurred when accessing the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed.-or- There was a failure reading from the network. </exception>
		// Token: 0x06000D84 RID: 3460 RVA: 0x00046C48 File Offset: 0x00044E48
		public override void Write(byte[] buffer, int offset, int size)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			try
			{
				this._streamSocket.Send(buffer, offset, size, SocketFlags.None);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00046D14 File Offset: 0x00044F14
		public override void Write(ReadOnlySpan<byte> source)
		{
			if (base.GetType() != typeof(NetworkStream))
			{
				base.Write(source);
				return;
			}
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.CanWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			SocketError socketError;
			this._streamSocket.Send(source, SocketFlags.None, out socketError);
			if (socketError != SocketError.Success)
			{
				SocketException ex = new SocketException((int)socketError);
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00046D9F File Offset: 0x00044F9F
		public unsafe override void WriteByte(byte value)
		{
			this.Write(new ReadOnlySpan<byte>((void*)(&value), 1));
		}

		/// <summary>Closes the <see cref="T:System.Net.Sockets.NetworkStream" /> after waiting the specified time to allow data to be sent.</summary>
		/// <param name="timeout">A 32-bit signed integer that specifies the number of milliseconds to wait to send any remaining data before closing.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is less than -1.</exception>
		// Token: 0x06000D87 RID: 3463 RVA: 0x00046DB0 File Offset: 0x00044FB0
		public void Close(int timeout)
		{
			if (timeout < -1)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			this._closeTimeout = timeout;
			base.Dispose();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.NetworkStream" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06000D88 RID: 3464 RVA: 0x00046DD0 File Offset: 0x00044FD0
		protected override void Dispose(bool disposing)
		{
			int cleanedUp = this._cleanedUp ? 1 : 0;
			this._cleanedUp = true;
			if (cleanedUp == 0 && disposing)
			{
				this._readable = false;
				this._writeable = false;
				if (this._ownsSocket)
				{
					this._streamSocket.InternalShutdown(SocketShutdown.Both);
					this._streamSocket.Close(this._closeTimeout);
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		// Token: 0x06000D89 RID: 3465 RVA: 0x00046E30 File Offset: 0x00045030
		~NetworkStream()
		{
			this.Dispose(false);
		}

		/// <summary>Begins an asynchronous read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the location in memory to store data read from the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <param name="offset">The location in <paramref name="buffer" /> to begin storing the data. </param>
		/// <param name="size">The number of bytes to read from the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate that is executed when <see cref="M:System.Net.Sockets.NetworkStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> completes. </param>
		/// <param name="state">An object that contains any additional user-defined data. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous call.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.-or- The <paramref name="offset" /> parameter is greater than the length of the <paramref name="buffer" /> paramater.-or- The <paramref name="size" /> is less than 0.-or- The <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter.</exception>
		/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.-or- There was a failure while reading from the network. -or-An error occurred when accessing the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed. </exception>
		// Token: 0x06000D8A RID: 3466 RVA: 0x00046E60 File Offset: 0x00045060
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			IAsyncResult result;
			try
			{
				result = this._streamSocket.BeginReceive(buffer, offset, size, SocketFlags.None, callback, state);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Handles the end of an asynchronous read.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that represents an asynchronous call. </param>
		/// <returns>The number of bytes read from the <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="asyncResult" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.-or- An error occurred when accessing the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed. </exception>
		// Token: 0x06000D8B RID: 3467 RVA: 0x00046F30 File Offset: 0x00045130
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			int result;
			try
			{
				result = this._streamSocket.EndReceive(asyncResult);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Begins an asynchronous write to a stream.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to write to the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <param name="offset">The location in <paramref name="buffer" /> to begin sending the data. </param>
		/// <param name="size">The number of bytes to write to the <see cref="T:System.Net.Sockets.NetworkStream" />. </param>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate that is executed when <see cref="M:System.Net.Sockets.NetworkStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> completes. </param>
		/// <param name="state">An object that contains any additional user-defined data. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous call.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> parameter is less than 0.-or- The <paramref name="offset" /> parameter is greater than the length of <paramref name="buffer" />.-or- The <paramref name="size" /> parameter is less than 0.-or- The <paramref name="size" /> parameter is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.-or- There was a failure while writing to the network. -or-An error occurred when accessing the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed. </exception>
		// Token: 0x06000D8C RID: 3468 RVA: 0x00046FC0 File Offset: 0x000451C0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			IAsyncResult result;
			try
			{
				result = this._streamSocket.BeginSend(buffer, offset, size, SocketFlags.None, callback, state);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Handles the end of an asynchronous write.</summary>
		/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> that represents the asynchronous call. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.IOException">The underlying <see cref="T:System.Net.Sockets.Socket" /> is closed.-or- An error occurred while writing to the network. -or-An error occurred when accessing the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.NetworkStream" /> is closed. </exception>
		// Token: 0x06000D8D RID: 3469 RVA: 0x00047090 File Offset: 0x00045290
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			try
			{
				this._streamSocket.EndSend(asyncResult);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0004711C File Offset: 0x0004531C
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			Task<int> result;
			try
			{
				result = this._streamSocket.ReceiveAsync(new Memory<byte>(buffer, offset, size), SocketFlags.None, true, cancellationToken).AsTask();
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000471F8 File Offset: 0x000453F8
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			bool canRead = this.CanRead;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canRead)
			{
				throw new InvalidOperationException("The stream does not support reading.");
			}
			ValueTask<int> result;
			try
			{
				result = this._streamSocket.ReceiveAsync(buffer, SocketFlags.None, true, cancellationToken);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00047290 File Offset: 0x00045490
		public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if ((ulong)offset > (ulong)((long)buffer.Length))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if ((ulong)size > (ulong)((long)(buffer.Length - offset)))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			Task result;
			try
			{
				result = this._streamSocket.SendAsyncForNetworkStream(new ReadOnlyMemory<byte>(buffer, offset, size), SocketFlags.None, cancellationToken).AsTask();
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0004736C File Offset: 0x0004556C
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			bool canWrite = this.CanWrite;
			if (this._cleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!canWrite)
			{
				throw new InvalidOperationException("The stream does not support writing.");
			}
			ValueTask result;
			try
			{
				result = this._streamSocket.SendAsyncForNetworkStream(buffer, SocketFlags.None, cancellationToken);
			}
			catch (Exception ex) when (!(ex is OutOfMemoryException))
			{
				throw new IOException(SR.Format("Unable to write data to the transport connection: {0}.", ex.Message), ex);
			}
			return result;
		}

		/// <summary>Flushes data from the stream. This method is reserved for future use.</summary>
		// Token: 0x06000D92 RID: 3474 RVA: 0x00004D67 File Offset: 0x00002F67
		public override void Flush()
		{
		}

		/// <summary>Flushes data from the stream as an asynchronous operation.</summary>
		/// <param name="cancellationToken">A cancellation token used to propagate notification that this  operation should be canceled.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		// Token: 0x06000D93 RID: 3475 RVA: 0x00047400 File Offset: 0x00045600
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		/// <summary>Sets the length of the stream. This method always throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">This parameter is not used. </param>
		/// <exception cref="T:System.NotSupportedException">Any use of this property. </exception>
		// Token: 0x06000D94 RID: 3476 RVA: 0x00042362 File Offset: 0x00040562
		public override void SetLength(long value)
		{
			throw new NotSupportedException("This stream does not support seek operations.");
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00047408 File Offset: 0x00045608
		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, mode, timeout, silent, "SetSocketTimeoutOption");
			}
			if (timeout < 0)
			{
				timeout = 0;
			}
			if ((mode == SocketShutdown.Send || mode == SocketShutdown.Both) && timeout != this._currentWriteTimeout)
			{
				this._streamSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, timeout, silent);
				this._currentWriteTimeout = timeout;
			}
			if ((mode == SocketShutdown.Receive || mode == SocketShutdown.Both) && timeout != this._currentReadTimeout)
			{
				this._streamSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, timeout, silent);
				this._currentReadTimeout = timeout;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000474A0 File Offset: 0x000456A0
		internal Socket InternalSocket
		{
			get
			{
				Socket streamSocket = this._streamSocket;
				if (this._cleanedUp || streamSocket == null)
				{
					throw new ObjectDisposedException(base.GetType().FullName);
				}
				return streamSocket;
			}
		}

		// Token: 0x04000A39 RID: 2617
		private readonly Socket _streamSocket;

		// Token: 0x04000A3A RID: 2618
		private readonly bool _ownsSocket;

		// Token: 0x04000A3B RID: 2619
		private bool _readable;

		// Token: 0x04000A3C RID: 2620
		private bool _writeable;

		// Token: 0x04000A3D RID: 2621
		private int _closeTimeout = -1;

		// Token: 0x04000A3E RID: 2622
		private volatile bool _cleanedUp;

		// Token: 0x04000A3F RID: 2623
		private int _currentReadTimeout = -1;

		// Token: 0x04000A40 RID: 2624
		private int _currentWriteTimeout = -1;
	}
}
