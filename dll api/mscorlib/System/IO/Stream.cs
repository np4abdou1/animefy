using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Provides a generic view of a sequence of bytes. This is an abstract class.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200054D RID: 1357
	[Serializable]
	public abstract class Stream : MarshalByRefObject, IDisposable
	{
		// Token: 0x0600280E RID: 10254 RVA: 0x000A029D File Offset: 0x0009E49D
		internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			return LazyInitializer.EnsureInitialized<SemaphoreSlim>(ref this._asyncActiveSemaphore, () => new SemaphoreSlim(1, 1));
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports reading.</summary>
		/// <returns>
		///     <see langword="true" /> if the stream supports reading; otherwise, <see langword="false" />.</returns>
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600280F RID: 10255
		public abstract bool CanRead { get; }

		/// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports seeking.</summary>
		/// <returns>
		///     <see langword="true" /> if the stream supports seeking; otherwise, <see langword="false" />.</returns>
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002810 RID: 10256
		public abstract bool CanSeek { get; }

		/// <summary>Gets a value that determines whether the current stream can time out.</summary>
		/// <returns>A value that determines whether the current stream can time out.</returns>
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool CanTimeout
		{
			get
			{
				return false;
			}
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether the current stream supports writing.</summary>
		/// <returns>
		///     <see langword="true" /> if the stream supports writing; otherwise, <see langword="false" />.</returns>
		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002812 RID: 10258
		public abstract bool CanWrite { get; }

		/// <summary>When overridden in a derived class, gets the length in bytes of the stream.</summary>
		/// <returns>A long value representing the length of the stream in bytes.</returns>
		/// <exception cref="T:System.NotSupportedException">A class derived from <see langword="Stream" /> does not support seeking. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002813 RID: 10259
		public abstract long Length { get; }

		/// <summary>When overridden in a derived class, gets or sets the position within the current stream.</summary>
		/// <returns>The current position within the stream.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support seeking. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002814 RID: 10260
		// (set) Token: 0x06002815 RID: 10261
		public abstract long Position { get; set; }

		/// <summary>Gets or sets a value, in miliseconds, that determines how long the stream will attempt to read before timing out. </summary>
		/// <returns>A value, in miliseconds, that determines how long the stream will attempt to read before timing out.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.IO.Stream.ReadTimeout" /> method always throws an <see cref="T:System.InvalidOperationException" />. </exception>
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000A02C9 File Offset: 0x0009E4C9
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x000A02C9 File Offset: 0x0009E4C9
		public virtual int ReadTimeout
		{
			get
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
			set
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
		}

		/// <summary>Gets or sets a value, in miliseconds, that determines how long the stream will attempt to write before timing out. </summary>
		/// <returns>A value, in miliseconds, that determines how long the stream will attempt to write before timing out.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.IO.Stream.WriteTimeout" /> method always throws an <see cref="T:System.InvalidOperationException" />. </exception>
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x000A02C9 File Offset: 0x0009E4C9
		// (set) Token: 0x06002819 RID: 10265 RVA: 0x000A02C9 File Offset: 0x0009E4C9
		public virtual int WriteTimeout
		{
			get
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
			set
			{
				throw new InvalidOperationException("Timeouts are not supported on this stream.");
			}
		}

		/// <summary>Reads the bytes from the current stream and writes them to another stream.</summary>
		/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destination" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The current stream does not support reading.-or-
		///         <paramref name="destination" /> does not support writing.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		// Token: 0x0600281A RID: 10266 RVA: 0x000A02D8 File Offset: 0x0009E4D8
		public void CopyTo(Stream destination)
		{
			int copyBufferSize = this.GetCopyBufferSize();
			this.CopyTo(destination, copyBufferSize);
		}

		/// <summary>Reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary>
		/// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
		/// <param name="bufferSize">The size of the buffer. This value must be greater than zero. The default size is 81920.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="destination" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="bufferSize" /> is negative or zero.</exception>
		/// <exception cref="T:System.NotSupportedException">The current stream does not support reading.-or-
		///         <paramref name="destination" /> does not support writing.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		// Token: 0x0600281B RID: 10267 RVA: 0x000A02F4 File Offset: 0x0009E4F4
		public virtual void CopyTo(Stream destination, int bufferSize)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			byte[] array = ArrayPool<byte>.Shared.Rent(bufferSize);
			try
			{
				int count;
				while ((count = this.Read(array, 0, array.Length)) != 0)
				{
					destination.Write(array, 0, count);
				}
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000A0350 File Offset: 0x0009E550
		private int GetCopyBufferSize()
		{
			int num = 81920;
			if (this.CanSeek)
			{
				long length = this.Length;
				long position = this.Position;
				if (length <= position)
				{
					num = 1;
				}
				else
				{
					long num2 = length - position;
					if (num2 > 0L)
					{
						num = (int)Math.Min((long)num, num2);
					}
				}
			}
			return num;
		}

		/// <summary>Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream. Instead of calling this method, ensure that the stream is properly disposed.</summary>
		// Token: 0x0600281D RID: 10269 RVA: 0x000A0395 File Offset: 0x0009E595
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.IO.Stream" />.</summary>
		// Token: 0x0600281E RID: 10270 RVA: 0x0005E11D File Offset: 0x0005C31D
		public void Dispose()
		{
			this.Close();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.Stream" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x0600281F RID: 10271 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>When overridden in a derived class, clears all buffers for this stream and causes any buffered data to be written to the underlying device.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x06002820 RID: 10272
		public abstract void Flush();

		/// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A task that represents the asynchronous flush operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		// Token: 0x06002821 RID: 10273 RVA: 0x000A03A4 File Offset: 0x0009E5A4
		public virtual Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((Stream)state).Flush();
			}, this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Begins an asynchronous read operation. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
		/// <param name="buffer">The buffer to read the data into. </param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data read from the stream. </param>
		/// <param name="count">The maximum number of bytes to read. </param>
		/// <param name="callback">An optional asynchronous callback, to be called when the read is complete. </param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous read, which could still be pending.</returns>
		/// <exception cref="T:System.IO.IOException">Attempted an asynchronous read past the end of the stream, or a disk error occurs. </exception>
		/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		/// <exception cref="T:System.NotSupportedException">The current <see langword="Stream" /> implementation does not support the read operation. </exception>
		// Token: 0x06002822 RID: 10274 RVA: 0x000A03D7 File Offset: 0x0009E5D7
		public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.BeginReadInternal(buffer, offset, count, callback, state, false, true);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000A03E8 File Offset: 0x0009E5E8
		internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			if (!this.CanRead)
			{
				throw Error.GetReadNotSupported();
			}
			SemaphoreSlim semaphoreSlim = this.EnsureAsyncActiveSemaphoreInitialized();
			Task task = null;
			if (serializeAsynchronously)
			{
				task = semaphoreSlim.WaitAsync();
			}
			else
			{
				semaphoreSlim.Wait();
			}
			Stream.ReadWriteTask readWriteTask = new Stream.ReadWriteTask(true, apm, delegate(object <p0>)
			{
				Stream.ReadWriteTask readWriteTask2 = Task.InternalCurrent as Stream.ReadWriteTask;
				int result;
				try
				{
					result = readWriteTask2._stream.Read(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
				}
				finally
				{
					if (!readWriteTask2._apm)
					{
						readWriteTask2._stream.FinishTrackingAsyncOperation();
					}
					readWriteTask2.ClearBeginState();
				}
				return result;
			}, state, this, buffer, offset, count, callback);
			if (task != null)
			{
				this.RunReadWriteTaskWhenReady(task, readWriteTask);
			}
			else
			{
				this.RunReadWriteTask(readWriteTask);
			}
			return readWriteTask;
		}

		/// <summary>Waits for the pending asynchronous read to complete. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
		/// <param name="asyncResult">The reference to the pending asynchronous request to finish. </param>
		/// <returns>The number of bytes read from the stream, between zero (0) and the number of bytes you requested. Streams return zero (0) only at the end of the stream, otherwise, they should block until at least one byte is available.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">A handle to the pending read operation is not available.-or-The pending operation does not support reading.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
		/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
		// Token: 0x06002824 RID: 10276 RVA: 0x000A0464 File Offset: 0x0009E664
		public virtual int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Stream.ReadWriteTask activeReadWriteTask = this._activeReadWriteTask;
			if (activeReadWriteTask == null)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.");
			}
			if (activeReadWriteTask != asyncResult)
			{
				throw new InvalidOperationException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.");
			}
			if (!activeReadWriteTask._isRead)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.");
			}
			int result;
			try
			{
				result = activeReadWriteTask.GetAwaiter().GetResult();
			}
			finally
			{
				this.FinishTrackingAsyncOperation();
			}
			return result;
		}

		/// <summary>Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
		/// <param name="buffer">The buffer to write the data into.</param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
		// Token: 0x06002825 RID: 10277 RVA: 0x000A04E0 File Offset: 0x0009E6E0
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return this.ReadAsync(buffer, offset, count, CancellationToken.None);
		}

		/// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
		/// <param name="buffer">The buffer to write the data into.</param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
		// Token: 0x06002826 RID: 10278 RVA: 0x000A04F0 File Offset: 0x0009E6F0
		public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.BeginEndReadAsync(buffer, offset, count);
			}
			return Task.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000A050C File Offset: 0x0009E70C
		public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				return new ValueTask<int>(this.ReadAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken));
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			return Stream.<ReadAsync>g__FinishReadAsync|44_0(this.ReadAsync(array, 0, buffer.Length, cancellationToken), array, buffer);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000A0574 File Offset: 0x0009E774
		private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
		{
			if (!this.HasOverriddenBeginEndRead())
			{
				return (Task<int>)this.BeginReadInternal(buffer, offset, count, null, null, true, false);
			}
			return TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>(this, new Stream.ReadWriteParameters
			{
				Buffer = buffer,
				Offset = offset,
				Count = count
			}, (Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginRead(args.Buffer, args.Offset, args.Count, callback, state), (Stream stream, IAsyncResult asyncResult) => stream.EndRead(asyncResult));
		}

		/// <summary>Begins an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
		/// <param name="buffer">The buffer to write data from. </param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> from which to begin writing. </param>
		/// <param name="count">The maximum number of bytes to write. </param>
		/// <param name="callback">An optional asynchronous callback, to be called when the write is complete. </param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests. </param>
		/// <returns>An <see langword="IAsyncResult" /> that represents the asynchronous write, which could still be pending.</returns>
		/// <exception cref="T:System.IO.IOException">Attempted an asynchronous write past the end of the stream, or a disk error occurs. </exception>
		/// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		/// <exception cref="T:System.NotSupportedException">The current <see langword="Stream" /> implementation does not support the write operation. </exception>
		// Token: 0x06002829 RID: 10281 RVA: 0x000A0601 File Offset: 0x0009E801
		public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.BeginWriteInternal(buffer, offset, count, callback, state, false, true);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000A0614 File Offset: 0x0009E814
		internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			if (!this.CanWrite)
			{
				throw Error.GetWriteNotSupported();
			}
			SemaphoreSlim semaphoreSlim = this.EnsureAsyncActiveSemaphoreInitialized();
			Task task = null;
			if (serializeAsynchronously)
			{
				task = semaphoreSlim.WaitAsync();
			}
			else
			{
				semaphoreSlim.Wait();
			}
			Stream.ReadWriteTask readWriteTask = new Stream.ReadWriteTask(false, apm, delegate(object <p0>)
			{
				Stream.ReadWriteTask readWriteTask2 = Task.InternalCurrent as Stream.ReadWriteTask;
				int result;
				try
				{
					readWriteTask2._stream.Write(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
					result = 0;
				}
				finally
				{
					if (!readWriteTask2._apm)
					{
						readWriteTask2._stream.FinishTrackingAsyncOperation();
					}
					readWriteTask2.ClearBeginState();
				}
				return result;
			}, state, this, buffer, offset, count, callback);
			if (task != null)
			{
				this.RunReadWriteTaskWhenReady(task, readWriteTask);
			}
			else
			{
				this.RunReadWriteTask(readWriteTask);
			}
			return readWriteTask;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000A0690 File Offset: 0x0009E890
		private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			if (asyncWaiter.IsCompleted)
			{
				this.RunReadWriteTask(readWriteTask);
				return;
			}
			asyncWaiter.ContinueWith(delegate(Task t, object state)
			{
				Stream.ReadWriteTask readWriteTask2 = (Stream.ReadWriteTask)state;
				readWriteTask2._stream.RunReadWriteTask(readWriteTask2);
			}, readWriteTask, default(CancellationToken), TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000A06E7 File Offset: 0x0009E8E7
		private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			this._activeReadWriteTask = readWriteTask;
			readWriteTask.m_taskScheduler = TaskScheduler.Default;
			readWriteTask.ScheduleAndStart(false);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x000A0702 File Offset: 0x0009E902
		private void FinishTrackingAsyncOperation()
		{
			this._activeReadWriteTask = null;
			this._asyncActiveSemaphore.Release();
		}

		/// <summary>Ends an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
		/// <param name="asyncResult">A reference to the outstanding asynchronous I/O request. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">A handle to the pending write operation is not available.-or-The pending operation does not support writing.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
		/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
		// Token: 0x0600282E RID: 10286 RVA: 0x000A0718 File Offset: 0x0009E918
		public virtual void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Stream.ReadWriteTask activeReadWriteTask = this._activeReadWriteTask;
			if (activeReadWriteTask == null)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.");
			}
			if (activeReadWriteTask != asyncResult)
			{
				throw new InvalidOperationException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.");
			}
			if (activeReadWriteTask._isRead)
			{
				throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.");
			}
			try
			{
				activeReadWriteTask.GetAwaiter().GetResult();
			}
			finally
			{
				this.FinishTrackingAsyncOperation();
			}
		}

		/// <summary>Asynchronously writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
		/// <param name="buffer">The buffer to write data from.</param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
		// Token: 0x0600282F RID: 10287 RVA: 0x000A0794 File Offset: 0x0009E994
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return this.WriteAsync(buffer, offset, count, CancellationToken.None);
		}

		/// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary>
		/// <param name="buffer">The buffer to write data from.</param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
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
		// Token: 0x06002830 RID: 10288 RVA: 0x000A07A4 File Offset: 0x0009E9A4
		public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.BeginEndWriteAsync(buffer, offset, count);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				return new ValueTask(this.WriteAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken));
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			buffer.Span.CopyTo(array);
			return new ValueTask(this.FinishWriteAsync(this.WriteAsync(array, 0, buffer.Length, cancellationToken), array));
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000A083C File Offset: 0x0009EA3C
		private Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
		{
			Stream.<FinishWriteAsync>d__57 <FinishWriteAsync>d__;
			<FinishWriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishWriteAsync>d__.writeTask = writeTask;
			<FinishWriteAsync>d__.localBuffer = localBuffer;
			<FinishWriteAsync>d__.<>1__state = -1;
			<FinishWriteAsync>d__.<>t__builder.Start<Stream.<FinishWriteAsync>d__57>(ref <FinishWriteAsync>d__);
			return <FinishWriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000A0888 File Offset: 0x0009EA88
		private Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
		{
			if (!this.HasOverriddenBeginEndWrite())
			{
				return (Task)this.BeginWriteInternal(buffer, offset, count, null, null, true, false);
			}
			return TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>(this, new Stream.ReadWriteParameters
			{
				Buffer = buffer,
				Offset = offset,
				Count = count
			}, (Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginWrite(args.Buffer, args.Offset, args.Count, callback, state), delegate(Stream stream, IAsyncResult asyncResult)
			{
				stream.EndWrite(asyncResult);
				return default(VoidTaskResult);
			});
		}

		/// <summary>When overridden in a derived class, sets the position within the current stream.</summary>
		/// <param name="offset">A byte offset relative to the <paramref name="origin" /> parameter. </param>
		/// <param name="origin">A value of type <see cref="T:System.IO.SeekOrigin" /> indicating the reference point used to obtain the new position. </param>
		/// <returns>The new position within the current stream.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support seeking, such as if the stream is constructed from a pipe or console output. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x06002834 RID: 10292
		public abstract long Seek(long offset, SeekOrigin origin);

		/// <summary>When overridden in a derived class, sets the length of the current stream.</summary>
		/// <param name="value">The desired length of the current stream in bytes. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking, such as if the stream is constructed from a pipe or console output. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x06002835 RID: 10293
		public abstract void SetLength(long value);

		/// <summary>When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
		/// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source. </param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing the data read from the current stream. </param>
		/// <param name="count">The maximum number of bytes to be read from the current stream. </param>
		/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x06002836 RID: 10294
		public abstract int Read(byte[] buffer, int offset, int count);

		// Token: 0x06002837 RID: 10295 RVA: 0x000A0918 File Offset: 0x0009EB18
		public virtual int Read(Span<byte> buffer)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.Read(array, 0, buffer.Length);
				if ((ulong)num > (ulong)((long)buffer.Length))
				{
					throw new IOException("Stream was too long.");
				}
				new Span<byte>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		/// <summary>Reads a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.</summary>
		/// <returns>The unsigned byte cast to an <see langword="Int32" />, or -1 if at the end of the stream.</returns>
		/// <exception cref="T:System.NotSupportedException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x06002838 RID: 10296 RVA: 0x000A0994 File Offset: 0x0009EB94
		public virtual int ReadByte()
		{
			byte[] array = new byte[1];
			if (this.Read(array, 0, 1) == 0)
			{
				return -1;
			}
			return (int)array[0];
		}

		/// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
		/// <param name="buffer">An array of bytes. This method copies <paramref name="count" /> bytes from <paramref name="buffer" /> to the current stream. </param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream. </param>
		/// <param name="count">The number of bytes to be written to the current stream. </param>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is greater than the buffer length.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" />  is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occured, such as the specified file cannot be found.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="M:System.IO.Stream.Write(System.Byte[],System.Int32,System.Int32)" /> was called after the stream was closed.</exception>
		// Token: 0x06002839 RID: 10297
		public abstract void Write(byte[] buffer, int offset, int count);

		// Token: 0x0600283A RID: 10298 RVA: 0x000A09B8 File Offset: 0x0009EBB8
		public virtual void Write(ReadOnlySpan<byte> buffer)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(array);
				this.Write(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		/// <summary>Writes a byte to the current position in the stream and advances the position within the stream by one byte.</summary>
		/// <param name="value">The byte to write to the stream. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing, or the stream is already closed. </exception>
		/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
		// Token: 0x0600283B RID: 10299 RVA: 0x000A0A14 File Offset: 0x0009EC14
		public virtual void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000A0A38 File Offset: 0x0009EC38
		internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			Stream.SynchronousAsyncResult synchronousAsyncResult;
			try
			{
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(this.Read(buffer, offset, count), state);
			}
			catch (IOException ex)
			{
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(ex, state, false);
			}
			if (callback != null)
			{
				callback(synchronousAsyncResult);
			}
			return synchronousAsyncResult;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000A0A80 File Offset: 0x0009EC80
		internal static int BlockingEndRead(IAsyncResult asyncResult)
		{
			return Stream.SynchronousAsyncResult.EndRead(asyncResult);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000A0A88 File Offset: 0x0009EC88
		internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			Stream.SynchronousAsyncResult synchronousAsyncResult;
			try
			{
				this.Write(buffer, offset, count);
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(state);
			}
			catch (IOException ex)
			{
				synchronousAsyncResult = new Stream.SynchronousAsyncResult(ex, state, true);
			}
			if (callback != null)
			{
				callback(synchronousAsyncResult);
			}
			return synchronousAsyncResult;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000A0AD0 File Offset: 0x0009ECD0
		internal static void BlockingEndWrite(IAsyncResult asyncResult)
		{
			Stream.SynchronousAsyncResult.EndWrite(asyncResult);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0000B18D File Offset: 0x0000938D
		private bool HasOverriddenBeginEndRead()
		{
			return true;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x0000B18D File Offset: 0x0000938D
		private bool HasOverriddenBeginEndWrite()
		{
			return true;
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000A0AE4 File Offset: 0x0009ECE4
		[CompilerGenerated]
		internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination)
		{
			Stream.<<ReadAsync>g__FinishReadAsync|44_0>d <<ReadAsync>g__FinishReadAsync|44_0>d;
			<<ReadAsync>g__FinishReadAsync|44_0>d.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<<ReadAsync>g__FinishReadAsync|44_0>d.readTask = readTask;
			<<ReadAsync>g__FinishReadAsync|44_0>d.localBuffer = localBuffer;
			<<ReadAsync>g__FinishReadAsync|44_0>d.localDestination = localDestination;
			<<ReadAsync>g__FinishReadAsync|44_0>d.<>1__state = -1;
			<<ReadAsync>g__FinishReadAsync|44_0>d.<>t__builder.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>(ref <<ReadAsync>g__FinishReadAsync|44_0>d);
			return <<ReadAsync>g__FinishReadAsync|44_0>d.<>t__builder.Task;
		}

		/// <summary>A <see langword="Stream" /> with no backing store.</summary>
		// Token: 0x040014F9 RID: 5369
		public static readonly Stream Null = new Stream.NullStream();

		// Token: 0x040014FA RID: 5370
		[NonSerialized]
		private Stream.ReadWriteTask _activeReadWriteTask;

		// Token: 0x040014FB RID: 5371
		[NonSerialized]
		private SemaphoreSlim _asyncActiveSemaphore;

		// Token: 0x0200054E RID: 1358
		private struct ReadWriteParameters
		{
			// Token: 0x040014FC RID: 5372
			internal byte[] Buffer;

			// Token: 0x040014FD RID: 5373
			internal int Offset;

			// Token: 0x040014FE RID: 5374
			internal int Count;
		}

		// Token: 0x0200054F RID: 1359
		private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
		{
			// Token: 0x06002845 RID: 10309 RVA: 0x000A0B37 File Offset: 0x0009ED37
			internal void ClearBeginState()
			{
				this._stream = null;
				this._buffer = null;
			}

			// Token: 0x06002846 RID: 10310 RVA: 0x000A0B48 File Offset: 0x0009ED48
			public ReadWriteTask(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) : base(function, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach)
			{
				this._isRead = isRead;
				this._apm = apm;
				this._stream = stream;
				this._buffer = buffer;
				this._offset = offset;
				this._count = count;
				if (callback != null)
				{
					this._callback = callback;
					this._context = ExecutionContext.Capture();
					base.AddCompletionAction(this);
				}
			}

			// Token: 0x06002847 RID: 10311 RVA: 0x000A0BB0 File Offset: 0x0009EDB0
			private static void InvokeAsyncCallback(object completedTask)
			{
				Stream.ReadWriteTask readWriteTask = (Stream.ReadWriteTask)completedTask;
				AsyncCallback callback = readWriteTask._callback;
				readWriteTask._callback = null;
				callback(readWriteTask);
			}

			// Token: 0x06002848 RID: 10312 RVA: 0x000A0BD8 File Offset: 0x0009EDD8
			void ITaskCompletionAction.Invoke(Task completingTask)
			{
				ExecutionContext context = this._context;
				if (context == null)
				{
					AsyncCallback callback = this._callback;
					this._callback = null;
					callback(completingTask);
					return;
				}
				this._context = null;
				ContextCallback contextCallback = Stream.ReadWriteTask.s_invokeAsyncCallback;
				if (contextCallback == null)
				{
					contextCallback = (Stream.ReadWriteTask.s_invokeAsyncCallback = new ContextCallback(Stream.ReadWriteTask.InvokeAsyncCallback));
				}
				ExecutionContext.RunInternal(context, contextCallback, this);
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x06002849 RID: 10313 RVA: 0x0000B18D File Offset: 0x0000938D
			bool ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x040014FF RID: 5375
			internal readonly bool _isRead;

			// Token: 0x04001500 RID: 5376
			internal readonly bool _apm;

			// Token: 0x04001501 RID: 5377
			internal Stream _stream;

			// Token: 0x04001502 RID: 5378
			internal byte[] _buffer;

			// Token: 0x04001503 RID: 5379
			internal readonly int _offset;

			// Token: 0x04001504 RID: 5380
			internal readonly int _count;

			// Token: 0x04001505 RID: 5381
			private AsyncCallback _callback;

			// Token: 0x04001506 RID: 5382
			private ExecutionContext _context;

			// Token: 0x04001507 RID: 5383
			private static ContextCallback s_invokeAsyncCallback;
		}

		// Token: 0x02000550 RID: 1360
		private sealed class NullStream : Stream
		{
			// Token: 0x0600284A RID: 10314 RVA: 0x000A0C2E File Offset: 0x0009EE2E
			internal NullStream()
			{
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x0600284B RID: 10315 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool CanRead
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x0600284C RID: 10316 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool CanWrite
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x0600284D RID: 10317 RVA: 0x0000B18D File Offset: 0x0000938D
			public override bool CanSeek
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x0600284E RID: 10318 RVA: 0x000A0C36 File Offset: 0x0009EE36
			public override long Length
			{
				get
				{
					return 0L;
				}
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x0600284F RID: 10319 RVA: 0x000A0C36 File Offset: 0x0009EE36
			// (set) Token: 0x06002850 RID: 10320 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override long Position
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			// Token: 0x06002851 RID: 10321 RVA: 0x000A0C3A File Offset: 0x0009EE3A
			public override void CopyTo(Stream destination, int bufferSize)
			{
				StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			}

			// Token: 0x06002852 RID: 10322 RVA: 0x00002A7D File Offset: 0x00000C7D
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x06002853 RID: 10323 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void Flush()
			{
			}

			// Token: 0x06002854 RID: 10324 RVA: 0x000A0C44 File Offset: 0x0009EE44
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x06002855 RID: 10325 RVA: 0x000A0C5B File Offset: 0x0009EE5B
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				if (!this.CanRead)
				{
					throw Error.GetReadNotSupported();
				}
				return base.BlockingBeginRead(buffer, offset, count, callback, state);
			}

			// Token: 0x06002856 RID: 10326 RVA: 0x000A0C78 File Offset: 0x0009EE78
			public override int EndRead(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				return Stream.BlockingEndRead(asyncResult);
			}

			// Token: 0x06002857 RID: 10327 RVA: 0x000A0C8E File Offset: 0x0009EE8E
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				if (!this.CanWrite)
				{
					throw Error.GetWriteNotSupported();
				}
				return base.BlockingBeginWrite(buffer, offset, count, callback, state);
			}

			// Token: 0x06002858 RID: 10328 RVA: 0x000A0CAB File Offset: 0x0009EEAB
			public override void EndWrite(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				Stream.BlockingEndWrite(asyncResult);
			}

			// Token: 0x06002859 RID: 10329 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x0600285A RID: 10330 RVA: 0x0002ACA4 File Offset: 0x00028EA4
			public override int Read(Span<byte> buffer)
			{
				return 0;
			}

			// Token: 0x0600285B RID: 10331 RVA: 0x000A0CC1 File Offset: 0x0009EEC1
			public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				return Stream.NullStream.s_zeroTask;
			}

			// Token: 0x0600285C RID: 10332 RVA: 0x000A0CC8 File Offset: 0x0009EEC8
			public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				return new ValueTask<int>(0);
			}

			// Token: 0x0600285D RID: 10333 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
			public override int ReadByte()
			{
				return -1;
			}

			// Token: 0x0600285E RID: 10334 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x0600285F RID: 10335 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void Write(ReadOnlySpan<byte> buffer)
			{
			}

			// Token: 0x06002860 RID: 10336 RVA: 0x000A0CD0 File Offset: 0x0009EED0
			public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x06002861 RID: 10337 RVA: 0x000A0CE8 File Offset: 0x0009EEE8
			public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask);
				}
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}

			// Token: 0x06002862 RID: 10338 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void WriteByte(byte value)
			{
			}

			// Token: 0x06002863 RID: 10339 RVA: 0x000A0C36 File Offset: 0x0009EE36
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x06002864 RID: 10340 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void SetLength(long length)
			{
			}

			// Token: 0x04001508 RID: 5384
			private static readonly Task<int> s_zeroTask = Task.FromResult<int>(0);
		}

		// Token: 0x02000551 RID: 1361
		private sealed class SynchronousAsyncResult : IAsyncResult
		{
			// Token: 0x06002866 RID: 10342 RVA: 0x000A0D20 File Offset: 0x0009EF20
			internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
			{
				this._bytesRead = bytesRead;
				this._stateObject = asyncStateObject;
			}

			// Token: 0x06002867 RID: 10343 RVA: 0x000A0D36 File Offset: 0x0009EF36
			internal SynchronousAsyncResult(object asyncStateObject)
			{
				this._stateObject = asyncStateObject;
				this._isWrite = true;
			}

			// Token: 0x06002868 RID: 10344 RVA: 0x000A0D4C File Offset: 0x0009EF4C
			internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite)
			{
				this._exceptionInfo = ExceptionDispatchInfo.Capture(ex);
				this._stateObject = asyncStateObject;
				this._isWrite = isWrite;
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x06002869 RID: 10345 RVA: 0x0000B18D File Offset: 0x0000938D
			public bool IsCompleted
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x0600286A RID: 10346 RVA: 0x000A0D6E File Offset: 0x0009EF6E
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return LazyInitializer.EnsureInitialized<ManualResetEvent>(ref this._waitHandle, () => new ManualResetEvent(true));
				}
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x0600286B RID: 10347 RVA: 0x000A0D9A File Offset: 0x0009EF9A
			public object AsyncState
			{
				get
				{
					return this._stateObject;
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x0600286C RID: 10348 RVA: 0x0000B18D File Offset: 0x0000938D
			public bool CompletedSynchronously
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600286D RID: 10349 RVA: 0x000A0DA2 File Offset: 0x0009EFA2
			internal void ThrowIfError()
			{
				if (this._exceptionInfo != null)
				{
					this._exceptionInfo.Throw();
				}
			}

			// Token: 0x0600286E RID: 10350 RVA: 0x000A0DB8 File Offset: 0x0009EFB8
			internal static int EndRead(IAsyncResult asyncResult)
			{
				Stream.SynchronousAsyncResult synchronousAsyncResult = asyncResult as Stream.SynchronousAsyncResult;
				if (synchronousAsyncResult == null || synchronousAsyncResult._isWrite)
				{
					throw new ArgumentException("IAsyncResult object did not come from the corresponding async method on this type.");
				}
				if (synchronousAsyncResult._endXxxCalled)
				{
					throw new ArgumentException("EndRead can only be called once for each asynchronous operation.");
				}
				synchronousAsyncResult._endXxxCalled = true;
				synchronousAsyncResult.ThrowIfError();
				return synchronousAsyncResult._bytesRead;
			}

			// Token: 0x0600286F RID: 10351 RVA: 0x000A0E08 File Offset: 0x0009F008
			internal static void EndWrite(IAsyncResult asyncResult)
			{
				Stream.SynchronousAsyncResult synchronousAsyncResult = asyncResult as Stream.SynchronousAsyncResult;
				if (synchronousAsyncResult == null || !synchronousAsyncResult._isWrite)
				{
					throw new ArgumentException("IAsyncResult object did not come from the corresponding async method on this type.");
				}
				if (synchronousAsyncResult._endXxxCalled)
				{
					throw new ArgumentException("EndWrite can only be called once for each asynchronous operation.");
				}
				synchronousAsyncResult._endXxxCalled = true;
				synchronousAsyncResult.ThrowIfError();
			}

			// Token: 0x04001509 RID: 5385
			private readonly object _stateObject;

			// Token: 0x0400150A RID: 5386
			private readonly bool _isWrite;

			// Token: 0x0400150B RID: 5387
			private ManualResetEvent _waitHandle;

			// Token: 0x0400150C RID: 5388
			private ExceptionDispatchInfo _exceptionInfo;

			// Token: 0x0400150D RID: 5389
			private bool _endXxxCalled;

			// Token: 0x0400150E RID: 5390
			private int _bytesRead;
		}
	}
}
