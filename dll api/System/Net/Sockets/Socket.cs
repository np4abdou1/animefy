using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Net.Sockets
{
	/// <summary>Implements the Berkeley sockets interface.</summary>
	// Token: 0x020001FB RID: 507
	public class Socket : IDisposable
	{
		// Token: 0x06000D97 RID: 3479 RVA: 0x000474D4 File Offset: 0x000456D4
		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
			}
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs = LazyInitializer.EnsureInitialized<Socket.AwaitableSocketAsyncEventArgs>(ref LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs()).ValueTaskReceive, () => new Socket.AwaitableSocketAsyncEventArgs());
			if (awaitableSocketAsyncEventArgs.Reserve())
			{
				awaitableSocketAsyncEventArgs.SetBuffer(buffer);
				awaitableSocketAsyncEventArgs.SocketFlags = socketFlags;
				awaitableSocketAsyncEventArgs.WrapExceptionsInIOExceptions = fromNetworkStream;
				return awaitableSocketAsyncEventArgs.ReceiveAsync(this);
			}
			return new ValueTask<int>(this.ReceiveAsyncApm(buffer, socketFlags));
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00047580 File Offset: 0x00045780
		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
				this.BeginReceive(arraySegment.Array, arraySegment.Offset, arraySegment.Count, socketFlags, delegate(IAsyncResult iar)
				{
					TaskCompletionSource<int> taskCompletionSource3 = (TaskCompletionSource<int>)iar.AsyncState;
					try
					{
						taskCompletionSource3.TrySetResult(((Socket)taskCompletionSource3.Task.AsyncState).EndReceive(iar));
					}
					catch (Exception exception)
					{
						taskCompletionSource3.TrySetException(exception);
					}
				}, taskCompletionSource);
				return taskCompletionSource.Task;
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			TaskCompletionSource<int> taskCompletionSource2 = new TaskCompletionSource<int>(this);
			this.BeginReceive(array, 0, buffer.Length, socketFlags, delegate(IAsyncResult iar)
			{
				Tuple<TaskCompletionSource<int>, Memory<byte>, byte[]> tuple = (Tuple<TaskCompletionSource<int>, Memory<byte>, byte[]>)iar.AsyncState;
				try
				{
					int num = ((Socket)tuple.Item1.Task.AsyncState).EndReceive(iar);
					new ReadOnlyMemory<byte>(tuple.Item3, 0, num).Span.CopyTo(tuple.Item2.Span);
					tuple.Item1.TrySetResult(num);
				}
				catch (Exception exception)
				{
					tuple.Item1.TrySetException(exception);
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(tuple.Item3, false);
				}
			}, Tuple.Create<TaskCompletionSource<int>, Memory<byte>, byte[]>(taskCompletionSource2, buffer, array));
			return taskCompletionSource2.Task;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00047640 File Offset: 0x00045840
		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask(Task.FromCanceled(cancellationToken));
			}
			Socket.AwaitableSocketAsyncEventArgs awaitableSocketAsyncEventArgs = LazyInitializer.EnsureInitialized<Socket.AwaitableSocketAsyncEventArgs>(ref LazyInitializer.EnsureInitialized<Socket.CachedEventArgs>(ref this._cachedTaskEventArgs, () => new Socket.CachedEventArgs()).ValueTaskSend, () => new Socket.AwaitableSocketAsyncEventArgs());
			if (awaitableSocketAsyncEventArgs.Reserve())
			{
				awaitableSocketAsyncEventArgs.SetBuffer(MemoryMarshal.AsMemory<byte>(buffer));
				awaitableSocketAsyncEventArgs.SocketFlags = socketFlags;
				awaitableSocketAsyncEventArgs.WrapExceptionsInIOExceptions = true;
				return awaitableSocketAsyncEventArgs.SendAsyncForNetworkStream(this);
			}
			return new ValueTask(this.SendAsyncApm(buffer, socketFlags));
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000476F0 File Offset: 0x000458F0
		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>(this);
				this.BeginSend(arraySegment.Array, arraySegment.Offset, arraySegment.Count, socketFlags, delegate(IAsyncResult iar)
				{
					TaskCompletionSource<int> taskCompletionSource3 = (TaskCompletionSource<int>)iar.AsyncState;
					try
					{
						taskCompletionSource3.TrySetResult(((Socket)taskCompletionSource3.Task.AsyncState).EndSend(iar));
					}
					catch (Exception exception)
					{
						taskCompletionSource3.TrySetException(exception);
					}
				}, taskCompletionSource);
				return taskCompletionSource.Task;
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			buffer.Span.CopyTo(array);
			TaskCompletionSource<int> taskCompletionSource2 = new TaskCompletionSource<int>(this);
			this.BeginSend(array, 0, buffer.Length, socketFlags, delegate(IAsyncResult iar)
			{
				Tuple<TaskCompletionSource<int>, byte[]> tuple = (Tuple<TaskCompletionSource<int>, byte[]>)iar.AsyncState;
				try
				{
					tuple.Item1.TrySetResult(((Socket)tuple.Item1.Task.AsyncState).EndSend(iar));
				}
				catch (Exception exception)
				{
					tuple.Item1.TrySetException(exception);
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(tuple.Item2, false);
				}
			}, Tuple.Create<TaskCompletionSource<int>, byte[]>(taskCompletionSource2, array));
			return taskCompletionSource2.Task;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000477C0 File Offset: 0x000459C0
		private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			SocketError socketError = saea.SocketError;
			Socket acceptSocket = saea.AcceptSocket;
			bool flag;
			AsyncTaskMethodBuilder<Socket> completionResponsibility = saea.GetCompletionResponsibility(out flag);
			if (flag)
			{
				s.ReturnSocketAsyncEventArgs(saea);
			}
			if (socketError == SocketError.Success)
			{
				completionResponsibility.SetResult(acceptSocket);
				return;
			}
			completionResponsibility.SetException(Socket.GetException(socketError, false));
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00047808 File Offset: 0x00045A08
		private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			SocketError socketError = saea.SocketError;
			int bytesTransferred = saea.BytesTransferred;
			bool wrapExceptionsInIOExceptions = saea._wrapExceptionsInIOExceptions;
			bool flag;
			AsyncTaskMethodBuilder<int> completionResponsibility = saea.GetCompletionResponsibility(out flag);
			if (flag)
			{
				s.ReturnSocketAsyncEventArgs(saea, isReceive);
			}
			if (socketError == SocketError.Success)
			{
				completionResponsibility.SetResult(bytesTransferred);
				return;
			}
			completionResponsibility.SetException(Socket.GetException(socketError, wrapExceptionsInIOExceptions));
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0004785C File Offset: 0x00045A5C
		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			Exception ex = new SocketException((int)error);
			if (!wrapExceptionsInIOExceptions)
			{
				return ex;
			}
			return new IOException(SR.Format("Unable to transfer data on the transport connection: {0}.", ex.Message), ex);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0004788C File Offset: 0x00045A8C
		private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
			saea._accessed = false;
			saea._builder = default(AsyncTaskMethodBuilder<int>);
			saea._wrapExceptionsInIOExceptions = false;
			if (isReceive)
			{
				Volatile.Write<Socket.Int32TaskSocketAsyncEventArgs>(ref this._cachedTaskEventArgs.TaskReceive, saea);
				return;
			}
			Volatile.Write<Socket.Int32TaskSocketAsyncEventArgs>(ref this._cachedTaskEventArgs.TaskSend, saea);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000478D9 File Offset: 0x00045AD9
		private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
			saea.AcceptSocket = null;
			saea._accessed = false;
			saea._builder = default(AsyncTaskMethodBuilder<Socket>);
			Volatile.Write<Socket.TaskSocketAsyncEventArgs<Socket>>(ref this._cachedTaskEventArgs.TaskAccept, saea);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.Socket" /> class using the specified address family, socket type and protocol.</summary>
		/// <param name="addressFamily">One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values. </param>
		/// <param name="socketType">One of the <see cref="T:System.Net.Sockets.SocketType" /> values. </param>
		/// <param name="protocolType">One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">The combination of <paramref name="addressFamily" />, <paramref name="socketType" />, and <paramref name="protocolType" /> results in an invalid socket. </exception>
		// Token: 0x06000DA0 RID: 3488 RVA: 0x00047908 File Offset: 0x00045B08
		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
			Socket.s_LoggingEnabled = Logging.On;
			bool flag = Socket.s_LoggingEnabled;
			Socket.InitializeSockets();
			int num;
			this.m_Handle = new SafeSocketHandle(Socket.Socket_icall(addressFamily, socketType, protocolType, out num), true);
			if (this.m_Handle.IsInvalid)
			{
				throw new SocketException();
			}
			this.addressFamily = addressFamily;
			this.socketType = socketType;
			this.protocolType = protocolType;
			IPProtectionLevel ipprotectionLevel = SettingsSectionInternal.Section.IPProtectionLevel;
			if (ipprotectionLevel != IPProtectionLevel.Unspecified)
			{
				this.SetIPProtectionLevel(ipprotectionLevel);
			}
			this.SocketDefaults();
			bool flag2 = Socket.s_LoggingEnabled;
		}

		/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 4 (IPv4).</summary>
		/// <returns>
		///     <see langword="true" /> if the operating system and network adaptors support the IPv4 protocol; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x000479B7 File Offset: 0x00045BB7
		public static bool OSSupportsIPv4
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_SupportsIPv4;
			}
		}

		/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 6 (IPv6).</summary>
		/// <returns>
		///     <see langword="true" /> if the operating system and network adaptors support the IPv6 protocol; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000479C5 File Offset: 0x00045BC5
		public static bool OSSupportsIPv6
		{
			get
			{
				Socket.InitializeSockets();
				return Socket.s_OSSupportsIPv6;
			}
		}

		/// <summary>Gets the operating system handle for the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> that represents the operating system handle for the <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x000479D3 File Offset: 0x00045BD3
		public IntPtr Handle
		{
			get
			{
				return this.m_Handle.DangerousGetHandle();
			}
		}

		/// <summary>Gets the address family of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values.</returns>
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000479E0 File Offset: 0x00045BE0
		public AddressFamily AddressFamily
		{
			get
			{
				return this.addressFamily;
			}
		}

		/// <summary>Gets the type of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>One of the <see cref="T:System.Net.Sockets.SocketType" /> values.</returns>
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x000479E8 File Offset: 0x00045BE8
		public SocketType SocketType
		{
			get
			{
				return this.socketType;
			}
		}

		/// <summary>Gets the protocol type of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values.</returns>
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000479F0 File Offset: 0x00045BF0
		public ProtocolType ProtocolType
		{
			get
			{
				return this.protocolType;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the <see cref="T:System.Net.Sockets.Socket" /> allows Internet Protocol (IP) datagrams to be fragmented.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> allows datagram fragmentation; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This property can be set only for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x170002CF RID: 719
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x000479F8 File Offset: 0x00045BF8
		public bool DontFragment
		{
			set
			{
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment, value ? 1 : 0);
					return;
				}
				throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the <see cref="T:System.Net.Sockets.Socket" /> is a dual-mode socket used for both IPv4 and IPv6.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> is a  dual-mode socket; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00047A23 File Offset: 0x00045C23
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00047A51 File Offset: 0x00045C51
		public bool DualMode
		{
			get
			{
				if (this.AddressFamily != AddressFamily.InterNetworkV6)
				{
					throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
				}
				return (int)this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only) == 0;
			}
			set
			{
				if (this.AddressFamily != AddressFamily.InterNetworkV6)
				{
					throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
				}
				this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, value ? 0 : 1);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00047A7E File Offset: 0x00045C7E
		private bool IsDualMode
		{
			get
			{
				return this.AddressFamily == AddressFamily.InterNetworkV6 && this.DualMode;
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00047A92 File Offset: 0x00045C92
		internal bool CanTryAddressFamily(AddressFamily family)
		{
			return family == this.addressFamily || (family == AddressFamily.InterNetwork && this.IsDualMode);
		}

		/// <summary>Sends the set of buffers in the list to a connected <see cref="T:System.Net.Sockets.Socket" />, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
		/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffers" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="buffers" /> is empty.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DAC RID: 3500 RVA: 0x00047AAC File Offset: 0x00045CAC
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Send(buffers, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Sends the specified number of bytes of data to a connected <see cref="T:System.Net.Sockets.Socket" />, starting at the specified offset, and using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to be sent. </param>
		/// <param name="offset">The position in the data buffer at which to begin sending data. </param>
		/// <param name="size">The number of bytes to send. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values. </param>
		/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///         <paramref name="socketFlags" /> is not a valid combination of values.-or- An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DAD RID: 3501 RVA: 0x00047AD0 File Offset: 0x00045CD0
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Send(buffer, offset, size, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Receives the specified number of bytes from a bound <see cref="T:System.Net.Sockets.Socket" /> into the specified offset position of the receive buffer, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for received data. </param>
		/// <param name="offset">The location in <paramref name="buffer" /> to store the received data. </param>
		/// <param name="size">The number of bytes to receive. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values. </param>
		/// <returns>The number of bytes received.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///         <paramref name="socketFlags" /> is not a valid combination of values.-or- The <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> property was not set.-or- An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions. </exception>
		// Token: 0x06000DAE RID: 3502 RVA: 0x00047AF4 File Offset: 0x00045CF4
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Receive(buffer, offset, size, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Receives data from a bound <see cref="T:System.Net.Sockets.Socket" /> into the list of receive buffers, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
		/// <returns>The number of bytes received.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffers" /> is <see langword="null" />.-or-
		///         <paramref name="buffers" />.Count is zero.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred while attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DAF RID: 3503 RVA: 0x00047B18 File Offset: 0x00045D18
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			SocketError socketError;
			int result = this.Receive(buffers, socketFlags, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Sets low-level operating modes for the <see cref="T:System.Net.Sockets.Socket" /> using the <see cref="T:System.Net.Sockets.IOControlCode" /> enumeration to specify control codes.</summary>
		/// <param name="ioControlCode">A <see cref="T:System.Net.Sockets.IOControlCode" /> value that specifies the control code of the operation to perform. </param>
		/// <param name="optionInValue">An array of type <see cref="T:System.Byte" /> that contains the input data required by the operation. </param>
		/// <param name="optionOutValue">An array of type <see cref="T:System.Byte" /> that contains the output data returned by the operation. </param>
		/// <returns>The number of bytes in the <paramref name="optionOutValue" /> parameter.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.InvalidOperationException">An attempt was made to change the blocking mode without using the <see cref="P:System.Net.Sockets.Socket.Blocking" /> property. </exception>
		// Token: 0x06000DB0 RID: 3504 RVA: 0x00047B39 File Offset: 0x00045D39
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return this.IOControl((int)ioControlCode, optionInValue, optionOutValue);
		}

		/// <summary>Set the IP protection level on a socket.</summary>
		/// <param name="level">The IP protection level to set on this socket. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="level" /> parameter cannot be <see cref="F:System.Net.Sockets.IPProtectionLevel.Unspecified" />. The IP protection level cannot be set to unspecified.</exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Net.Sockets.AddressFamily" /> of the socket must be either <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</exception>
		// Token: 0x06000DB1 RID: 3505 RVA: 0x00047B48 File Offset: 0x00045D48
		public void SetIPProtectionLevel(IPProtectionLevel level)
		{
			if (level == IPProtectionLevel.Unspecified)
			{
				throw new ArgumentException(SR.GetString("The specified value is not valid."), "level");
			}
			if (this.addressFamily == AddressFamily.InterNetworkV6)
			{
				this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPProtectionLevel, (int)level);
				return;
			}
			if (this.addressFamily == AddressFamily.InterNetwork)
			{
				this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.IPProtectionLevel, (int)level);
				return;
			}
			throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
		}

		/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to send. </param>
		/// <param name="offset">The zero-based position in the <paramref name="buffer" /> parameter at which to begin sending data. </param>
		/// <param name="size">The number of bytes to send. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values. </param>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous send.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See remarks section below. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is less than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DB2 RID: 3506 RVA: 0x00047BA8 File Offset: 0x00045DA8
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			SocketError socketError;
			IAsyncResult result = this.BeginSend(buffer, offset, size, socketFlags, out socketError, callback, state);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Ends a pending asynchronous send.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information for this asynchronous operation. </param>
		/// <returns>If successful, the number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />; otherwise, an invalid <see cref="T:System.Net.Sockets.Socket" /> error.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> was previously called for the asynchronous send. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DB3 RID: 3507 RVA: 0x00047BD8 File Offset: 0x00045DD8
		public int EndSend(IAsyncResult asyncResult)
		{
			SocketError socketError;
			int result = this.EndSend(asyncResult, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Begins to asynchronously receive data from a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for the received data. </param>
		/// <param name="offset">The zero-based position in the <paramref name="buffer" /> parameter at which to store the received data. </param>
		/// <param name="size">The number of bytes to receive. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values. </param>
		/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete. </param>
		/// <param name="state">A user-defined object that contains information about the receive operation. This object is passed to the <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> delegate when the operation is complete.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous read.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		// Token: 0x06000DB4 RID: 3508 RVA: 0x00047BF8 File Offset: 0x00045DF8
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			SocketError socketError;
			IAsyncResult result = this.BeginReceive(buffer, offset, size, socketFlags, out socketError, callback, state);
			if (socketError != SocketError.Success && socketError != SocketError.IOPending)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		/// <summary>Ends a pending asynchronous read.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation. </param>
		/// <returns>The number of bytes received.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> was previously called for the asynchronous read. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DB5 RID: 3509 RVA: 0x00047C28 File Offset: 0x00045E28
		public int EndReceive(IAsyncResult asyncResult)
		{
			SocketError socketError;
			int result = this.EndReceive(asyncResult, out socketError);
			if (socketError != SocketError.Success)
			{
				throw new SocketException(socketError);
			}
			return result;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00047C48 File Offset: 0x00045E48
		private static object InternalSyncObject
		{
			get
			{
				if (Socket.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange(ref Socket.s_InternalSyncObject, value, null);
				}
				return Socket.s_InternalSyncObject;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00047C74 File Offset: 0x00045E74
		internal bool CleanedUp
		{
			get
			{
				return this.m_IntCleanedUp == 1;
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00047C80 File Offset: 0x00045E80
		internal static void InitializeSockets()
		{
			if (!Socket.s_Initialized)
			{
				object internalSyncObject = Socket.InternalSyncObject;
				lock (internalSyncObject)
				{
					if (!Socket.s_Initialized)
					{
						bool flag2 = Socket.IsProtocolSupported(NetworkInterfaceComponent.IPv4);
						bool flag3 = Socket.IsProtocolSupported(NetworkInterfaceComponent.IPv6);
						if (flag3)
						{
							Socket.s_OSSupportsIPv6 = true;
							flag3 = SettingsSectionInternal.Section.Ipv6Enabled;
						}
						Socket.s_SupportsIPv4 = flag2;
						Socket.s_SupportsIPv6 = flag3;
						Socket.s_Initialized = true;
					}
				}
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Net.Sockets.Socket" /> class.</summary>
		// Token: 0x06000DB9 RID: 3513 RVA: 0x00047D08 File Offset: 0x00045F08
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.Socket" /> class.</summary>
		// Token: 0x06000DBA RID: 3514 RVA: 0x00047D18 File Offset: 0x00045F18
		~Socket()
		{
			this.Dispose(false);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00047D48 File Offset: 0x00045F48
		internal void InternalShutdown(SocketShutdown how)
		{
			if (!this.is_connected || this.CleanedUp)
			{
				return;
			}
			int num;
			Socket.Shutdown_internal(this.m_Handle, how, out num);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00047D74 File Offset: 0x00045F74
		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
			if (this.CleanedUp && this.is_closed)
			{
				if (silent)
				{
					return;
				}
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			else
			{
				int num;
				Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, null, null, optionValue, out num);
				if (!silent && num != 0)
				{
					throw new SocketException(num);
				}
				return;
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00047DC8 File Offset: 0x00045FC8
		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		{
			this.addressFamily = family;
			this.socketType = type;
			this.protocolType = proto;
			this.m_Handle = safe_handle;
			this.is_connected = true;
			Socket.InitializeSockets();
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00047E28 File Offset: 0x00046028
		private void SocketDefaults()
		{
			try
			{
				if (this.addressFamily == AddressFamily.InterNetwork)
				{
					this.DontFragment = false;
					if (this.protocolType == ProtocolType.Tcp)
					{
						this.NoDelay = false;
					}
				}
				else if (this.addressFamily == AddressFamily.InterNetworkV6)
				{
					this.DualMode = true;
				}
			}
			catch (SocketException)
			{
			}
		}

		// Token: 0x06000DBF RID: 3519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error);

		/// <summary>Gets the local endpoint.</summary>
		/// <returns>The <see cref="T:System.Net.EndPoint" /> that the <see cref="T:System.Net.Sockets.Socket" /> is using for communications.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00047E80 File Offset: 0x00046080
		public EndPoint LocalEndPoint
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (this.seed_endpoint == null)
				{
					return null;
				}
				int num;
				SocketAddress socketAddress = Socket.LocalEndPoint_internal(this.m_Handle, (int)this.addressFamily, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				return this.seed_endpoint.Create(socketAddress);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00047EC8 File Offset: 0x000460C8
		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			bool flag = false;
			SocketAddress result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.LocalEndPoint_icall(safeHandle.DangerousGetHandle(), family, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06000DC2 RID: 3522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error);

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Net.Sockets.Socket" /> is in blocking mode.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> will block; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00047F0C File Offset: 0x0004610C
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00047F14 File Offset: 0x00046114
		public bool Blocking
		{
			get
			{
				return this.is_blocking;
			}
			set
			{
				this.ThrowIfDisposedAndClosed();
				int num;
				Socket.Blocking_internal(this.m_Handle, value, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				this.is_blocking = value;
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00047F48 File Offset: 0x00046148
		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Blocking_icall(safeHandle.DangerousGetHandle(), block, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000DC6 RID: 3526
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Blocking_icall(IntPtr socket, bool block, out int error);

		/// <summary>Gets a value that indicates whether a <see cref="T:System.Net.Sockets.Socket" /> is connected to a remote host as of the last <see cref="Overload:System.Net.Sockets.Socket.Send" /> or <see cref="Overload:System.Net.Sockets.Socket.Receive" /> operation.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> was connected to a remote resource as of the most recent operation; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00047F88 File Offset: 0x00046188
		public bool Connected
		{
			get
			{
				return this.is_connected;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the stream <see cref="T:System.Net.Sockets.Socket" /> is using the Nagle algorithm.</summary>
		/// <returns>
		///     <see langword="false" /> if the <see cref="T:System.Net.Sockets.Socket" /> uses the Nagle algorithm; otherwise, <see langword="true" />. The default is <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x170002D7 RID: 727
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00047F90 File Offset: 0x00046190
		public bool NoDelay
		{
			set
			{
				this.ThrowIfDisposedAndClosed();
				this.ThrowIfUdp();
				this.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
			}
		}

		/// <summary>Gets the remote endpoint.</summary>
		/// <returns>The <see cref="T:System.Net.EndPoint" /> with which the <see cref="T:System.Net.Sockets.Socket" /> is communicating.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00047FB0 File Offset: 0x000461B0
		public EndPoint RemoteEndPoint
		{
			get
			{
				this.ThrowIfDisposedAndClosed();
				if (!this.is_connected || this.seed_endpoint == null)
				{
					return null;
				}
				int num;
				SocketAddress socketAddress = Socket.RemoteEndPoint_internal(this.m_Handle, (int)this.addressFamily, out num);
				if (num != 0)
				{
					throw new SocketException(num);
				}
				return this.seed_endpoint.Create(socketAddress);
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00048000 File Offset: 0x00046200
		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			bool flag = false;
			SocketAddress result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.RemoteEndPoint_icall(safeHandle.DangerousGetHandle(), family, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06000DCB RID: 3531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error);

		/// <summary>Determines the status of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="microSeconds">The time to wait for a response, in microseconds. </param>
		/// <param name="mode">One of the <see cref="T:System.Net.Sockets.SelectMode" /> values. </param>
		/// <returns>The status of the <see cref="T:System.Net.Sockets.Socket" /> based on the polling mode value passed in the <paramref name="mode" /> parameter.Mode Return Value 
		///             <see cref="F:System.Net.Sockets.SelectMode.SelectRead" />
		///
		///             <see langword="true" /> if <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> has been called and a connection is pending; -or- 
		///             <see langword="true" /> if data is available for reading; -or- 
		///             <see langword="true" /> if the connection has been closed, reset, or terminated; otherwise, returns <see langword="false" />. 
		///             <see cref="F:System.Net.Sockets.SelectMode.SelectWrite" />
		///
		///             <see langword="true" />, if processing a <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" />, and the connection has succeeded; -or- 
		///             <see langword="true" /> if data can be sent; otherwise, returns <see langword="false" />. 
		///             <see cref="F:System.Net.Sockets.SelectMode.SelectError" />
		///
		///             <see langword="true" /> if processing a <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" /> that does not block, and the connection has failed; -or- 
		///             <see langword="true" /> if <see cref="F:System.Net.Sockets.SocketOptionName.OutOfBandInline" /> is not set and out-of-band data is available; otherwise, returns <see langword="false" />. </returns>
		/// <exception cref="T:System.NotSupportedException">The <paramref name="mode" /> parameter is not one of the <see cref="T:System.Net.Sockets.SelectMode" /> values. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See remarks below. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DCC RID: 3532 RVA: 0x00048044 File Offset: 0x00046244
		public bool Poll(int microSeconds, SelectMode mode)
		{
			this.ThrowIfDisposedAndClosed();
			if (mode != SelectMode.SelectRead && mode != SelectMode.SelectWrite && mode != SelectMode.SelectError)
			{
				throw new NotSupportedException("'mode' parameter is not valid.");
			}
			int num;
			bool flag = Socket.Poll_internal(this.m_Handle, mode, microSeconds, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (mode == SelectMode.SelectWrite && flag && !this.is_connected && (int)this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error) == 0)
			{
				this.is_connected = true;
			}
			return flag;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000480B8 File Offset: 0x000462B8
		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			bool flag = false;
			bool result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.Poll_icall(safeHandle.DangerousGetHandle(), mode, timeout, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06000DCE RID: 3534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error);

		/// <summary>Creates a new <see cref="T:System.Net.Sockets.Socket" /> for a newly created connection.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> for a newly created connection.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.InvalidOperationException">The accepting socket is not listening for connections. You must call <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> before calling <see cref="M:System.Net.Sockets.Socket.Accept" />. </exception>
		// Token: 0x06000DCF RID: 3535 RVA: 0x000480FC File Offset: 0x000462FC
		public Socket Accept()
		{
			this.ThrowIfDisposedAndClosed();
			int num = 0;
			SafeSocketHandle safe_handle = Socket.Accept_internal(this.m_Handle, out num, this.is_blocking);
			if (num != 0)
			{
				if (this.is_closed)
				{
					num = 10004;
				}
				throw new SocketException(num);
			}
			return new Socket(this.AddressFamily, this.SocketType, this.ProtocolType, safe_handle)
			{
				seed_endpoint = this.seed_endpoint,
				Blocking = this.Blocking
			};
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00048170 File Offset: 0x00046370
		internal void Accept(Socket acceptSocket)
		{
			this.ThrowIfDisposedAndClosed();
			int num = 0;
			SafeSocketHandle handle = Socket.Accept_internal(this.m_Handle, out num, this.is_blocking);
			if (num != 0)
			{
				if (this.is_closed)
				{
					num = 10004;
				}
				throw new SocketException(num);
			}
			acceptSocket.addressFamily = this.AddressFamily;
			acceptSocket.socketType = this.SocketType;
			acceptSocket.protocolType = this.ProtocolType;
			acceptSocket.m_Handle = handle;
			acceptSocket.is_connected = true;
			acceptSocket.seed_endpoint = this.seed_endpoint;
			acceptSocket.Blocking = this.Blocking;
		}

		/// <summary>Begins an asynchronous operation to accept an incoming connection attempt.</summary>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous <see cref="T:System.Net.Sockets.Socket" /> creation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
		/// <exception cref="T:System.NotSupportedException">Windows NT is required for this method. </exception>
		/// <exception cref="T:System.InvalidOperationException">The accepting socket is not listening for connections. You must call <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> before calling <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />.-or- The accepted socket is bound. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="receiveSize" /> is less than 0. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		// Token: 0x06000DD1 RID: 3537 RVA: 0x000481FC File Offset: 0x000463FC
		public IAsyncResult BeginAccept(AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_bound || !this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Accept);
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Asynchronously accepts an incoming connection attempt and creates a new <see cref="T:System.Net.Sockets.Socket" /> to handle remote host communication.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information for this asynchronous operation as well as any user defined data. </param>
		/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> to handle communication with the remote host.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> method was previously called. </exception>
		/// <exception cref="T:System.NotSupportedException">Windows NT is required for this method. </exception>
		// Token: 0x06000DD2 RID: 3538 RVA: 0x00048250 File Offset: 0x00046450
		public Socket EndAccept(IAsyncResult asyncResult)
		{
			byte[] array;
			int num;
			return this.EndAccept(out array, out num, asyncResult);
		}

		/// <summary>Asynchronously accepts an incoming connection attempt and creates a new <see cref="T:System.Net.Sockets.Socket" /> object to handle remote host communication. This method returns a buffer that contains the initial data and the number of bytes transferred.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the bytes transferred. </param>
		/// <param name="bytesTransferred">The number of bytes transferred. </param>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> object that stores state information for this asynchronous operation as well as any user defined data. </param>
		/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> object to handle communication with the remote host.</returns>
		/// <exception cref="T:System.NotSupportedException">Windows NT is required for this method. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is empty. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> method was previously called. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />. See the Remarks section for more information. </exception>
		// Token: 0x06000DD3 RID: 3539 RVA: 0x00048268 File Offset: 0x00046468
		public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndAccept", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			buffer = socketAsyncResult.Buffer.ToArray();
			bytesTransferred = socketAsyncResult.Total;
			return socketAsyncResult.AcceptedSocket;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000482C4 File Offset: 0x000464C4
		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			SafeSocketHandle result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = new SafeSocketHandle(Socket.Accept_icall(safeHandle.DangerousGetHandle(), out error, blocking), true);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06000DD5 RID: 3541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Accept_icall(IntPtr sock, out int error, bool blocking);

		/// <summary>Associates a <see cref="T:System.Net.Sockets.Socket" /> with a local endpoint.</summary>
		/// <param name="localEP">The local <see cref="T:System.Net.EndPoint" /> to associate with the <see cref="T:System.Net.Sockets.Socket" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="localEP" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
		// Token: 0x06000DD6 RID: 3542 RVA: 0x00048308 File Offset: 0x00046508
		public void Bind(EndPoint localEP)
		{
			this.ThrowIfDisposedAndClosed();
			if (localEP == null)
			{
				throw new ArgumentNullException("localEP");
			}
			IPEndPoint ipendPoint = localEP as IPEndPoint;
			if (ipendPoint != null)
			{
				localEP = this.RemapIPEndPoint(ipendPoint);
			}
			int num;
			Socket.Bind_internal(this.m_Handle, localEP.Serialize(), out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (num == 0)
			{
				this.is_bound = true;
			}
			this.seed_endpoint = localEP;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0004836C File Offset: 0x0004656C
		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Bind_icall(safeHandle.DangerousGetHandle(), sa, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000DD8 RID: 3544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Bind_icall(IntPtr sock, SocketAddress sa, out int error);

		/// <summary>Places a <see cref="T:System.Net.Sockets.Socket" /> in a listening state.</summary>
		/// <param name="backlog">The maximum length of the pending connections queue. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DD9 RID: 3545 RVA: 0x000483AC File Offset: 0x000465AC
		public void Listen(int backlog)
		{
			this.ThrowIfDisposedAndClosed();
			if (!this.is_bound)
			{
				throw new SocketException(10022);
			}
			int num;
			Socket.Listen_internal(this.m_Handle, backlog, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			this.is_listening = true;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000483F4 File Offset: 0x000465F4
		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Listen_icall(safeHandle.DangerousGetHandle(), backlog, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000DDB RID: 3547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Listen_icall(IntPtr sock, int backlog, out int error);

		/// <summary>Establishes a connection to a remote host. The host is specified by an IP address and a port number.</summary>
		/// <param name="address">The IP address of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="address" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.NotSupportedException">This method is valid for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="address" /> is zero.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />ing.</exception>
		// Token: 0x06000DDC RID: 3548 RVA: 0x00048434 File Offset: 0x00046634
		public void Connect(IPAddress address, int port)
		{
			this.Connect(new IPEndPoint(address, port));
		}

		/// <summary>Establishes a connection to a remote host.</summary>
		/// <param name="remoteEP">An <see cref="T:System.Net.EndPoint" /> that represents the remote device. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="remoteEP" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />ing.</exception>
		// Token: 0x06000DDD RID: 3549 RVA: 0x00048444 File Offset: 0x00046644
		public void Connect(EndPoint remoteEP)
		{
			this.ThrowIfDisposedAndClosed();
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			IPEndPoint ipendPoint = remoteEP as IPEndPoint;
			if (ipendPoint != null && this.socketType != SocketType.Dgram && (ipendPoint.Address.Equals(IPAddress.Any) || ipendPoint.Address.Equals(IPAddress.IPv6Any)))
			{
				throw new SocketException(10049);
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			if (ipendPoint != null)
			{
				remoteEP = this.RemapIPEndPoint(ipendPoint);
			}
			SocketAddress sa = remoteEP.Serialize();
			int num = 0;
			Socket.Connect_internal(this.m_Handle, sa, out num, this.is_blocking);
			if (num == 0 || num == 10035)
			{
				this.seed_endpoint = remoteEP;
			}
			if (num != 0)
			{
				if (this.is_closed)
				{
					num = 10004;
				}
				throw new SocketException(num);
			}
			this.is_connected = (this.socketType != SocketType.Dgram || ipendPoint == null || (!ipendPoint.Address.Equals(IPAddress.Any) && !ipendPoint.Address.Equals(IPAddress.IPv6Any)));
			this.is_bound = true;
		}

		/// <summary>Begins an asynchronous request for a remote host connection. The host is specified by a host name and a port number.</summary>
		/// <param name="host">The name of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the connect operation is complete. </param>
		/// <param name="state">A user-defined object that contains information about the connect operation. This object is passed to the <paramref name="requestCallback" /> delegate when the operation is complete.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous connection.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="host" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.NotSupportedException">This method is valid for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />ing.</exception>
		// Token: 0x06000DDE RID: 3550 RVA: 0x0004854C File Offset: 0x0004674C
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (this.addressFamily != AddressFamily.InterNetwork && this.addressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("This method is valid only for sockets in the InterNetwork and InterNetworkV6 families");
			}
			if (port <= 0 || port > 65535)
			{
				throw new ArgumentOutOfRangeException("port", "Must be > 0 and < 65536");
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult sockares = new SocketAsyncResult(this, callback, state, SocketOperation.Connect)
			{
				Port = port
			};
			Dns.GetHostAddressesAsync(host).ContinueWith(delegate(Task<IPAddress[]> t)
			{
				if (t.IsFaulted)
				{
					sockares.Complete(t.Exception.InnerException);
					return;
				}
				if (t.IsCanceled)
				{
					sockares.Complete(new OperationCanceledException());
					return;
				}
				sockares.Addresses = t.Result;
				Socket.BeginMConnect(sockares);
			}, TaskScheduler.Default);
			return sockares;
		}

		/// <summary>Begins an asynchronous request for a remote host connection.</summary>
		/// <param name="remoteEP">An <see cref="T:System.Net.EndPoint" /> that represents the remote host. </param>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous connection.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="remoteEP" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />ing.</exception>
		// Token: 0x06000DDF RID: 3551 RVA: 0x000485F5 File Offset: 0x000467F5
		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			if (this.is_listening)
			{
				throw new InvalidOperationException();
			}
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Connect);
			socketAsyncResult.EndPoint = remoteEP;
			Socket.BeginSConnect(socketAsyncResult);
			return socketAsyncResult;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00048630 File Offset: 0x00046830
		private static bool BeginMConnect(SocketAsyncResult sockares)
		{
			Exception e = null;
			for (int i = sockares.CurrentAddress; i < sockares.Addresses.Length; i++)
			{
				try
				{
					sockares.CurrentAddress++;
					sockares.EndPoint = new IPEndPoint(sockares.Addresses[i], sockares.Port);
					if (sockares.socket.CanTryAddressFamily(sockares.EndPoint.AddressFamily))
					{
						return Socket.BeginSConnect(sockares);
					}
				}
				catch (Exception e)
				{
				}
			}
			sockares.Complete(e, true);
			return false;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000486C0 File Offset: 0x000468C0
		private static bool BeginSConnect(SocketAsyncResult sockares)
		{
			EndPoint endPoint = sockares.EndPoint;
			if (endPoint is IPEndPoint)
			{
				IPEndPoint ipendPoint = (IPEndPoint)endPoint;
				if (ipendPoint.Address.Equals(IPAddress.Any) || ipendPoint.Address.Equals(IPAddress.IPv6Any))
				{
					sockares.Complete(new SocketException(10049), true);
					return false;
				}
				endPoint = (sockares.EndPoint = sockares.socket.RemapIPEndPoint(ipendPoint));
			}
			if (!sockares.socket.CanTryAddressFamily(sockares.EndPoint.AddressFamily))
			{
				sockares.Complete(new ArgumentException("None of the discovered or specified addresses match the socket address family."), true);
				return false;
			}
			int num = 0;
			if (sockares.socket.connect_in_progress)
			{
				sockares.socket.connect_in_progress = false;
				sockares.socket.m_Handle.Dispose();
				sockares.socket.m_Handle = new SafeSocketHandle(Socket.Socket_icall(sockares.socket.addressFamily, sockares.socket.socketType, sockares.socket.protocolType, out num), true);
				if (num != 0)
				{
					sockares.Complete(new SocketException(num), true);
					return false;
				}
			}
			bool flag = sockares.socket.is_blocking;
			if (flag)
			{
				sockares.socket.Blocking = false;
			}
			Socket.Connect_internal(sockares.socket.m_Handle, endPoint.Serialize(), out num, false);
			if (flag)
			{
				sockares.socket.Blocking = true;
			}
			if (num == 0)
			{
				sockares.socket.is_connected = true;
				sockares.socket.is_bound = true;
				sockares.Complete(true);
				return false;
			}
			if (num != 10036 && num != 10035)
			{
				sockares.socket.is_connected = false;
				sockares.socket.is_bound = false;
				sockares.Complete(new SocketException(num), true);
				return false;
			}
			sockares.socket.is_connected = false;
			sockares.socket.is_bound = false;
			sockares.socket.connect_in_progress = true;
			IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginConnectCallback, sockares));
			return true;
		}

		/// <summary>Ends a pending asynchronous connection request.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginConnect(System.Net.EndPoint,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndConnect(System.IAsyncResult)" /> was previously called for the asynchronous connection. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DE2 RID: 3554 RVA: 0x000488A8 File Offset: 0x00046AA8
		public void EndConnect(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndConnect", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000488E8 File Offset: 0x00046AE8
		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				Socket.Connect_icall(safeHandle.DangerousGetHandle(), sa, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
		}

		// Token: 0x06000DE4 RID: 3556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking);

		/// <summary>Closes the socket connection and allows reuse of the socket.</summary>
		/// <param name="reuseSocket">
		///       <see langword="true" /> if this socket can be reused after the current connection is closed; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.PlatformNotSupportedException">This method requires Windows 2000 or earlier, or the exception will be thrown.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		// Token: 0x06000DE5 RID: 3557 RVA: 0x00048924 File Offset: 0x00046B24
		public void Disconnect(bool reuseSocket)
		{
			this.ThrowIfDisposedAndClosed();
			int num = 0;
			Socket.Disconnect_internal(this.m_Handle, reuseSocket, out num);
			if (num == 0)
			{
				this.is_connected = false;
				return;
			}
			if (num == 50)
			{
				throw new PlatformNotSupportedException();
			}
			throw new SocketException(num);
		}

		/// <summary>Ends a pending asynchronous disconnect request.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> object that stores state information and any user-defined data for this asynchronous operation. </param>
		/// <exception cref="T:System.NotSupportedException">The operating system is Windows 2000 or earlier, and this method requires Windows XP. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginDisconnect(System.Boolean,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndDisconnect(System.IAsyncResult)" /> was previously called for the asynchronous connection. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.Net.WebException">The disconnect request has timed out. </exception>
		// Token: 0x06000DE6 RID: 3558 RVA: 0x00048968 File Offset: 0x00046B68
		public void EndDisconnect(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndDisconnect", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000489A8 File Offset: 0x00046BA8
		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Disconnect_icall(safeHandle.DangerousGetHandle(), reuse, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000DE8 RID: 3560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Disconnect_icall(IntPtr sock, bool reuse, out int error);

		/// <summary>Receives data from a bound <see cref="T:System.Net.Sockets.Socket" /> into a receive buffer, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for the received data.</param>
		/// <param name="offset">The position in the <paramref name="buffer" /> parameter to store the received data. </param>
		/// <param name="size">The number of bytes to receive. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <returns>The number of bytes received.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///         <paramref name="socketFlags" /> is not a valid combination of values.-or- The <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> property is not set.-or- An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions. </exception>
		// Token: 0x06000DE9 RID: 3561 RVA: 0x000489E8 File Offset: 0x00046BE8
		public unsafe int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			int num;
			int result;
			fixed (byte[] array = buffer)
			{
				byte* ptr;
				if (buffer == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				result = Socket.Receive_internal(this.m_Handle, ptr + offset, size, socketFlags, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
				this.is_bound = false;
				return result;
			}
			this.is_connected = true;
			return result;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00048A74 File Offset: 0x00046C74
		private unsafe int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			int num;
			int result;
			using (MemoryHandle memoryHandle = buffer.Slice(offset, size).Pin())
			{
				result = Socket.Receive_internal(this.m_Handle, (byte*)memoryHandle.Pointer, size, socketFlags, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
				this.is_bound = false;
			}
			else
			{
				this.is_connected = true;
			}
			return result;
		}

		/// <summary>Receives data from a bound <see cref="T:System.Net.Sockets.Socket" /> into the list of receive buffers, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <returns>The number of bytes received.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffers" /> is <see langword="null" />.-or-
		///         <paramref name="buffers" />.Count is zero.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred while attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DEB RID: 3563 RVA: 0x00048B0C File Offset: 0x00046D0C
		[CLSCompliant(false)]
		public unsafe int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers == null || buffers.Count == 0)
			{
				throw new ArgumentNullException("buffers");
			}
			int count = buffers.Count;
			GCHandle[] array = new GCHandle[count];
			int num;
			int result;
			try
			{
				try
				{
					Socket.WSABUF[] array2;
					Socket.WSABUF* ptr;
					if ((array2 = new Socket.WSABUF[count]) == null || array2.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array2[0];
					}
					for (int i = 0; i < count; i++)
					{
						ArraySegment<byte> arraySegment = buffers[i];
						if (arraySegment.Offset < 0 || arraySegment.Count < 0 || arraySegment.Count > arraySegment.Array.Length - arraySegment.Offset)
						{
							throw new ArgumentOutOfRangeException("segment");
						}
						try
						{
						}
						finally
						{
							array[i] = GCHandle.Alloc(arraySegment.Array, GCHandleType.Pinned);
						}
						ptr[i].len = arraySegment.Count;
						ptr[i].buf = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(arraySegment.Array, arraySegment.Offset);
					}
					result = Socket.Receive_internal(this.m_Handle, ptr, count, socketFlags, out num, this.is_blocking);
				}
				finally
				{
					Socket.WSABUF[] array2 = null;
				}
			}
			finally
			{
				for (int j = 0; j < count; j++)
				{
					if (array[j].IsAllocated)
					{
						array[j].Free();
					}
				}
			}
			errorCode = (SocketError)num;
			return result;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00048C8C File Offset: 0x00046E8C
		public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			byte[] array = new byte[buffer.Length];
			int result = this.Receive(array, 0, array.Length, socketFlags, out errorCode);
			array.CopyTo(buffer);
			return result;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00048CBC File Offset: 0x00046EBC
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			byte[] array = buffer.ToArray();
			return this.Send(array, 0, array.Length, socketFlags, out errorCode);
		}

		/// <summary>Begins an asynchronous request to receive data from a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <returns>Returns <see langword="true" /> if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns <see langword="false" /> if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <exception cref="T:System.ArgumentException">An argument was invalid. The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		// Token: 0x06000DEE RID: 3566 RVA: 0x00048CE0 File Offset: 0x00046EE0
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (e.MemoryBuffer.Equals(default(Memory<byte>)) && e.BufferList == null)
			{
				throw new NullReferenceException("Either e.Buffer or e.BufferList must be valid buffers.");
			}
			if (e.BufferList != null)
			{
				this.InitSocketAsyncEventArgs(e, Socket.ReceiveAsyncCallback, e, SocketOperation.ReceiveGeneric);
				e.socket_async_result.Buffers = e.BufferList;
				this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveGenericCallback, e.socket_async_result));
			}
			else
			{
				this.InitSocketAsyncEventArgs(e, Socket.ReceiveAsyncCallback, e, SocketOperation.Receive);
				e.socket_async_result.Buffer = e.MemoryBuffer;
				e.socket_async_result.Offset = e.Offset;
				e.socket_async_result.Size = e.Count;
				this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveCallback, e.socket_async_result));
			}
			return true;
		}

		/// <summary>Begins to asynchronously receive data from a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that is the storage location for the received data.</param>
		/// <param name="offset">The location in <paramref name="buffer" /> to store the received data.</param>
		/// <param name="size">The number of bytes to receive. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <param name="callback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
		/// <param name="state">A user-defined object that contains information about the receive operation. This object is passed to the <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> delegate when the operation is complete.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous read.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		// Token: 0x06000DEF RID: 3567 RVA: 0x00048DDC File Offset: 0x00046FDC
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			errorCode = SocketError.Success;
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Receive)
			{
				Buffer = buffer,
				Offset = offset,
				Size = size,
				SockFlags = socketFlags
			};
			this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveCallback, socketAsyncResult));
			return socketAsyncResult;
		}

		/// <summary>Ends a pending asynchronous read.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation.</param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <returns>The number of bytes received.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> was previously called for the asynchronous read. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DF0 RID: 3568 RVA: 0x00048E50 File Offset: 0x00047050
		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndReceive", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			errorCode = socketAsyncResult.ErrorCode;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
			}
			if (errorCode == SocketError.Success)
			{
				socketAsyncResult.CheckIfThrowDelayedException();
			}
			return socketAsyncResult.Total;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00048EC0 File Offset: 0x000470C0
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Receive_array_icall(safeHandle.DangerousGetHandle(), bufarray, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06000DF2 RID: 3570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00048F00 File Offset: 0x00047100
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Receive_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06000DF4 RID: 3572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00048F40 File Offset: 0x00047140
		private unsafe int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			SocketAddress socketAddress = remoteEP.Serialize();
			int num;
			int result;
			using (MemoryHandle memoryHandle = buffer.Slice(offset, size).Pin())
			{
				result = Socket.ReceiveFrom_internal(this.m_Handle, (byte*)memoryHandle.Pointer, size, socketFlags, ref socketAddress, out num, this.is_blocking);
			}
			errorCode = (SocketError)num;
			if (errorCode != SocketError.Success)
			{
				if (errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
				{
					this.is_connected = false;
				}
				else if (errorCode == SocketError.WouldBlock && this.is_blocking)
				{
					errorCode = SocketError.TimedOut;
				}
				return 0;
			}
			this.is_connected = true;
			this.is_bound = true;
			if (socketAddress != null)
			{
				remoteEP = remoteEP.Create(socketAddress);
			}
			this.seed_endpoint = remoteEP;
			return result;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00049014 File Offset: 0x00047214
		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			this.ThrowIfDisposedAndClosed();
			if (Interlocked.CompareExchange(ref sockares.EndCalled, 1, 0) == 1)
			{
				throw new InvalidOperationException("EndReceiveFrom can only be called once per asynchronous operation");
			}
			if (!sockares.IsCompleted)
			{
				sockares.AsyncWaitHandle.WaitOne();
			}
			sockares.CheckIfThrowDelayedException();
			ares.RemoteEndPoint = sockares.EndPoint;
			return sockares.Total;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00049070 File Offset: 0x00047270
		private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.ReceiveFrom_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, ref sockaddr, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06000DF8 RID: 3576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking);

		/// <summary>Sends the specified number of bytes of data to a connected <see cref="T:System.Net.Sockets.Socket" />, starting at the specified offset, and using the specified <see cref="T:System.Net.Sockets.SocketFlags" /></summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to be sent. </param>
		/// <param name="offset">The position in the data buffer at which to begin sending data. </param>
		/// <param name="size">The number of bytes to send. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values. </param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is greater than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///         <paramref name="socketFlags" /> is not a valid combination of values.-or- An operating system error occurs while accessing the <see cref="T:System.Net.Sockets.Socket" />. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DF9 RID: 3577 RVA: 0x000490B4 File Offset: 0x000472B4
		public unsafe int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (size == 0)
			{
				errorCode = SocketError.Success;
				return 0;
			}
			int num = 0;
			for (;;)
			{
				int num2;
				fixed (byte[] array = buffer)
				{
					byte* ptr;
					if (buffer == null || array.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array[0];
					}
					num += Socket.Send_internal(this.m_Handle, ptr + (offset + num), size - num, socketFlags, out num2, this.is_blocking);
				}
				errorCode = (SocketError)num2;
				if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
				{
					break;
				}
				this.is_connected = true;
				if (num >= size)
				{
					return num;
				}
			}
			this.is_connected = false;
			this.is_bound = false;
			return num;
		}

		/// <summary>Sends the set of buffers in the list to a connected <see cref="T:System.Net.Sockets.Socket" />, using the specified <see cref="T:System.Net.Sockets.SocketFlags" />.</summary>
		/// <param name="buffers">A list of <see cref="T:System.ArraySegment`1" />s of type <see cref="T:System.Byte" /> that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values.</param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <returns>The number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffers" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="buffers" /> is empty.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DFA RID: 3578 RVA: 0x00049158 File Offset: 0x00047358
		[CLSCompliant(false)]
		public unsafe int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			if (buffers == null)
			{
				throw new ArgumentNullException("buffers");
			}
			if (buffers.Count == 0)
			{
				throw new ArgumentException("Buffer is empty", "buffers");
			}
			int count = buffers.Count;
			GCHandle[] array = new GCHandle[count];
			int num;
			int result;
			try
			{
				try
				{
					Socket.WSABUF[] array2;
					Socket.WSABUF* ptr;
					if ((array2 = new Socket.WSABUF[count]) == null || array2.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array2[0];
					}
					for (int i = 0; i < count; i++)
					{
						ArraySegment<byte> arraySegment = buffers[i];
						if (arraySegment.Offset < 0 || arraySegment.Count < 0 || arraySegment.Count > arraySegment.Array.Length - arraySegment.Offset)
						{
							throw new ArgumentOutOfRangeException("segment");
						}
						try
						{
						}
						finally
						{
							array[i] = GCHandle.Alloc(arraySegment.Array, GCHandleType.Pinned);
						}
						ptr[i].len = arraySegment.Count;
						ptr[i].buf = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(arraySegment.Array, arraySegment.Offset);
					}
					result = Socket.Send_internal(this.m_Handle, ptr, count, socketFlags, out num, this.is_blocking);
				}
				finally
				{
					Socket.WSABUF[] array2 = null;
				}
			}
			finally
			{
				for (int j = 0; j < count; j++)
				{
					if (array[j].IsAllocated)
					{
						array[j].Free();
					}
				}
			}
			errorCode = (SocketError)num;
			return result;
		}

		/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <returns>Returns <see langword="true" /> if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns <see langword="false" /> if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">The <see cref="T:System.Net.Sockets.Socket" /> is not yet connected or was not obtained via an <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" />,or <see cref="Overload:System.Net.Sockets.Socket.BeginAccept" />, method.</exception>
		// Token: 0x06000DFB RID: 3579 RVA: 0x000492E8 File Offset: 0x000474E8
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			this.ThrowIfDisposedAndClosed();
			if (e.MemoryBuffer.Equals(default(Memory<byte>)) && e.BufferList == null)
			{
				throw new NullReferenceException("Either e.Buffer or e.BufferList must be valid buffers.");
			}
			if (e.BufferList != null)
			{
				this.InitSocketAsyncEventArgs(e, Socket.SendAsyncCallback, e, SocketOperation.SendGeneric);
				e.socket_async_result.Buffers = e.BufferList;
				this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginSendGenericCallback, e.socket_async_result));
			}
			else
			{
				this.InitSocketAsyncEventArgs(e, Socket.SendAsyncCallback, e, SocketOperation.Send);
				e.socket_async_result.Buffer = e.MemoryBuffer;
				e.socket_async_result.Offset = e.Offset;
				e.socket_async_result.Size = e.Count;
				this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
				{
					Socket.BeginSendCallback((SocketAsyncResult)s, 0);
				}, e.socket_async_result));
			}
			return true;
		}

		/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="buffer">An array of type <see cref="T:System.Byte" /> that contains the data to send. </param>
		/// <param name="offset">The zero-based position in the <paramref name="buffer" /> parameter at which to begin sending data. </param>
		/// <param name="size">The number of bytes to send. </param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="T:System.Net.Sockets.SocketFlags" /> values. </param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <param name="callback">The <see cref="T:System.AsyncCallback" /> delegate. </param>
		/// <param name="state">An object that contains state information for this request. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> that references the asynchronous send.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See remarks section below. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than 0.-or- 
		///         <paramref name="offset" /> is less than the length of <paramref name="buffer" />.-or- 
		///         <paramref name="size" /> is less than 0.-or- 
		///         <paramref name="size" /> is greater than the length of <paramref name="buffer" /> minus the value of the <paramref name="offset" /> parameter. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DFC RID: 3580 RVA: 0x00049400 File Offset: 0x00047600
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			this.ThrowIfDisposedAndClosed();
			this.ThrowIfBufferNull(buffer);
			this.ThrowIfBufferOutOfRange(buffer, offset, size);
			if (!this.is_connected)
			{
				errorCode = SocketError.NotConnected;
				return null;
			}
			errorCode = SocketError.Success;
			SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Send)
			{
				Buffer = buffer,
				Offset = offset,
				Size = size,
				SockFlags = socketFlags
			};
			this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
			{
				Socket.BeginSendCallback((SocketAsyncResult)s, 0);
			}, socketAsyncResult));
			return socketAsyncResult;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000494A0 File Offset: 0x000476A0
		private unsafe static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
			int num = 0;
			try
			{
				using (MemoryHandle memoryHandle = sockares.Buffer.Slice(sockares.Offset, sockares.Size).Pin())
				{
					num = Socket.Send_internal(sockares.socket.m_Handle, (byte*)memoryHandle.Pointer, sockares.Size, sockares.SockFlags, out sockares.error, false);
				}
			}
			catch (Exception e)
			{
				sockares.Complete(e);
				return;
			}
			if (sockares.error == 0)
			{
				sent_so_far += num;
				sockares.Offset += num;
				sockares.Size -= num;
				if (sockares.socket.CleanedUp)
				{
					sockares.Complete(sent_so_far);
					return;
				}
				if (sockares.Size > 0)
				{
					IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, delegate(IOAsyncResult s)
					{
						Socket.BeginSendCallback((SocketAsyncResult)s, sent_so_far);
					}, sockares));
					return;
				}
				sockares.Total = sent_so_far;
			}
			sockares.Complete(sent_so_far);
		}

		/// <summary>Ends a pending asynchronous send.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information for this asynchronous operation.</param>
		/// <param name="errorCode">A <see cref="T:System.Net.Sockets.SocketError" /> object that stores the socket error.</param>
		/// <returns>If successful, the number of bytes sent to the <see cref="T:System.Net.Sockets.Socket" />; otherwise, an invalid <see cref="T:System.Net.Sockets.Socket" /> error.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> was previously called for the asynchronous send. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000DFE RID: 3582 RVA: 0x000495D0 File Offset: 0x000477D0
		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndSend", "asyncResult");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			errorCode = socketAsyncResult.ErrorCode;
			if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
			{
				this.is_connected = false;
			}
			if (errorCode == SocketError.Success)
			{
				socketAsyncResult.CheckIfThrowDelayedException();
			}
			return socketAsyncResult.Total;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00049640 File Offset: 0x00047840
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Send_array_icall(safeHandle.DangerousGetHandle(), bufarray, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06000E00 RID: 3584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x06000E01 RID: 3585 RVA: 0x00049680 File Offset: 0x00047880
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			int result;
			try
			{
				safeHandle.RegisterForBlockingSyscall();
				result = Socket.Send_icall(safeHandle.DangerousGetHandle(), buffer, count, flags, out error, blocking);
			}
			finally
			{
				safeHandle.UnRegisterForBlockingSyscall();
			}
			return result;
		}

		// Token: 0x06000E02 RID: 3586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		/// <summary>Ends a pending asynchronous send to a specific location.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> that stores state information and any user defined data for this asynchronous operation. </param>
		/// <returns>If successful, the number of bytes sent; otherwise, an invalid <see cref="T:System.Net.Sockets.Socket" /> error.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not returned by a call to the <see cref="M:System.Net.Sockets.Socket.BeginSendTo(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint,System.AsyncCallback,System.Object)" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Net.Sockets.Socket.EndSendTo(System.IAsyncResult)" /> was previously called for the asynchronous send. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000E03 RID: 3587 RVA: 0x000496C0 File Offset: 0x000478C0
		public int EndSendTo(IAsyncResult asyncResult)
		{
			this.ThrowIfDisposedAndClosed();
			SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, "EndSendTo", "result");
			if (!socketAsyncResult.IsCompleted)
			{
				socketAsyncResult.AsyncWaitHandle.WaitOne();
			}
			socketAsyncResult.CheckIfThrowDelayedException();
			return socketAsyncResult.Total;
		}

		/// <summary>Returns the value of a specified <see cref="T:System.Net.Sockets.Socket" /> option, represented as an object.</summary>
		/// <param name="optionLevel">One of the <see cref="T:System.Net.Sockets.SocketOptionLevel" /> values. </param>
		/// <param name="optionName">One of the <see cref="T:System.Net.Sockets.SocketOptionName" /> values. </param>
		/// <returns>An object that represents the value of the option. When the <paramref name="optionName" /> parameter is set to <see cref="F:System.Net.Sockets.SocketOptionName.Linger" /> the return value is an instance of the <see cref="T:System.Net.Sockets.LingerOption" /> class. When <paramref name="optionName" /> is set to <see cref="F:System.Net.Sockets.SocketOptionName.AddMembership" /> or <see cref="F:System.Net.Sockets.SocketOptionName.DropMembership" />, the return value is an instance of the <see cref="T:System.Net.Sockets.MulticastOption" /> class. When <paramref name="optionName" /> is any other value, the return value is an integer.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information.-or-
		///         <paramref name="optionName" /> was set to the unsupported value <see cref="F:System.Net.Sockets.SocketOptionName.MaxConnections" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000E04 RID: 3588 RVA: 0x00049708 File Offset: 0x00047908
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			this.ThrowIfDisposedAndClosed();
			object obj;
			int num;
			Socket.GetSocketOption_obj_internal(this.m_Handle, optionLevel, optionName, out obj, out num);
			if (num != 0)
			{
				throw new SocketException(num);
			}
			if (optionName == SocketOptionName.Linger)
			{
				return (LingerOption)obj;
			}
			if (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership)
			{
				return (MulticastOption)obj;
			}
			if (obj is int)
			{
				return (int)obj;
			}
			return obj;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004976C File Offset: 0x0004796C
		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.GetSocketOption_obj_icall(safeHandle.DangerousGetHandle(), level, name, out obj_val, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000E06 RID: 3590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error);

		/// <summary>Sets the specified <see cref="T:System.Net.Sockets.Socket" /> option to the specified integer value.</summary>
		/// <param name="optionLevel">One of the <see cref="T:System.Net.Sockets.SocketOptionLevel" /> values. </param>
		/// <param name="optionName">One of the <see cref="T:System.Net.Sockets.SocketOptionName" /> values. </param>
		/// <param name="optionValue">A value of the option. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000E07 RID: 3591 RVA: 0x000497B0 File Offset: 0x000479B0
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			this.ThrowIfDisposedAndClosed();
			int num;
			Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, null, null, optionValue, out num);
			if (num == 0)
			{
				return;
			}
			if (num == 10022)
			{
				throw new ArgumentException();
			}
			throw new SocketException(num);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000497F0 File Offset: 0x000479F0
		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.SetSocketOption_icall(safeHandle.DangerousGetHandle(), level, name, obj_val, byte_val, int_val, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000E09 RID: 3593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error);

		/// <summary>Sets low-level operating modes for the <see cref="T:System.Net.Sockets.Socket" /> using numerical control codes.</summary>
		/// <param name="ioControlCode">An <see cref="T:System.Int32" /> value that specifies the control code of the operation to perform. </param>
		/// <param name="optionInValue">A <see cref="T:System.Byte" /> array that contains the input data required by the operation. </param>
		/// <param name="optionOutValue">A <see cref="T:System.Byte" /> array that contains the output data returned by the operation. </param>
		/// <returns>The number of bytes in the <paramref name="optionOutValue" /> parameter.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.InvalidOperationException">An attempt was made to change the blocking mode without using the <see cref="P:System.Net.Sockets.Socket.Blocking" /> property. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call stack does not have the required permissions. </exception>
		// Token: 0x06000E0A RID: 3594 RVA: 0x00049838 File Offset: 0x00047A38
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			if (this.CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			int num2;
			int num = Socket.IOControl_internal(this.m_Handle, ioControlCode, optionInValue, optionOutValue, out num2);
			if (num2 != 0)
			{
				throw new SocketException(num2);
			}
			if (num == -1)
			{
				throw new InvalidOperationException("Must use Blocking property instead.");
			}
			return num;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00049888 File Offset: 0x00047A88
		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error)
		{
			bool flag = false;
			int result;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				result = Socket.IOControl_icall(safeHandle.DangerousGetHandle(), ioctl_code, input, output, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06000E0C RID: 3596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error);

		/// <summary>Closes the <see cref="T:System.Net.Sockets.Socket" /> connection and releases all associated resources.</summary>
		// Token: 0x06000E0D RID: 3597 RVA: 0x000498D0 File Offset: 0x00047AD0
		public void Close()
		{
			this.linger_timeout = 0;
			this.Dispose();
		}

		/// <summary>Closes the <see cref="T:System.Net.Sockets.Socket" /> connection and releases all associated resources with a specified timeout to allow queued data to be sent. </summary>
		/// <param name="timeout">Wait up to <paramref name="timeout" /> seconds to send any remaining data, then close the socket.</param>
		// Token: 0x06000E0E RID: 3598 RVA: 0x000498DF File Offset: 0x00047ADF
		public void Close(int timeout)
		{
			this.linger_timeout = timeout;
			this.Dispose();
		}

		// Token: 0x06000E0F RID: 3599
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Close_icall(IntPtr socket, out int error);

		// Token: 0x06000E10 RID: 3600 RVA: 0x000498F0 File Offset: 0x00047AF0
		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
			bool flag = false;
			try
			{
				safeHandle.DangerousAddRef(ref flag);
				Socket.Shutdown_icall(safeHandle.DangerousGetHandle(), how, out error);
			}
			finally
			{
				if (flag)
				{
					safeHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x06000E11 RID: 3601
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error);

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.Socket" />, and optionally disposes of the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources. </param>
		// Token: 0x06000E12 RID: 3602 RVA: 0x00049930 File Offset: 0x00047B30
		protected virtual void Dispose(bool disposing)
		{
			if (this.CleanedUp)
			{
				return;
			}
			this.m_IntCleanedUp = 1;
			bool flag = this.is_connected;
			this.is_connected = false;
			if (this.m_Handle != null)
			{
				this.is_closed = true;
				IntPtr handle = this.Handle;
				if (flag)
				{
					this.Linger(handle);
				}
				this.m_Handle.Dispose();
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00049988 File Offset: 0x00047B88
		private void Linger(IntPtr handle)
		{
			if (!this.is_connected || this.linger_timeout <= 0)
			{
				return;
			}
			int num;
			Socket.Shutdown_icall(handle, SocketShutdown.Receive, out num);
			if (num != 0)
			{
				return;
			}
			int num2 = this.linger_timeout / 1000;
			int num3 = this.linger_timeout % 1000;
			if (num3 > 0)
			{
				Socket.Poll_icall(handle, SelectMode.SelectRead, num3 * 1000, out num);
				if (num != 0)
				{
					return;
				}
			}
			if (num2 > 0)
			{
				LingerOption obj_val = new LingerOption(true, num2);
				Socket.SetSocketOption_icall(handle, SocketOptionLevel.Socket, SocketOptionName.Linger, obj_val, null, 0, out num);
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00049A08 File Offset: 0x00047C08
		private void ThrowIfDisposedAndClosed()
		{
			if (this.CleanedUp && this.is_closed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00049A2B File Offset: 0x00047C2B
		private void ThrowIfBufferNull(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00049A3C File Offset: 0x00047C3C
		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
		{
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "offset must be >= 0");
			}
			if (offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset", "offset must be <= buffer.Length");
			}
			if (size < 0)
			{
				throw new ArgumentOutOfRangeException("size", "size must be >= 0");
			}
			if (size > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("size", "size must be <= buffer.Length - offset");
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00049A9F File Offset: 0x00047C9F
		private void ThrowIfUdp()
		{
			if (this.protocolType == ProtocolType.Udp)
			{
				throw new SocketException(10042);
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00049AB8 File Offset: 0x00047CB8
		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			if (ares == null)
			{
				throw new ArgumentNullException(argName);
			}
			SocketAsyncResult socketAsyncResult = ares as SocketAsyncResult;
			if (socketAsyncResult == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", argName);
			}
			if (Interlocked.CompareExchange(ref socketAsyncResult.EndCalled, 1, 0) == 1)
			{
				throw new InvalidOperationException(methodName + " can only be called once per asynchronous operation");
			}
			return socketAsyncResult;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00049B08 File Offset: 0x00047D08
		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
			Task task = sem.WaitAsync();
			if (!task.IsCompleted)
			{
				task.ContinueWith(delegate(Task t)
				{
					if (this.CleanedUp)
					{
						job.MarkDisposed();
						return;
					}
					IOSelector.Add(handle, job);
				});
				return;
			}
			if (this.CleanedUp)
			{
				job.MarkDisposed();
				return;
			}
			IOSelector.Add(handle, job);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00049B78 File Offset: 0x00047D78
		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
		{
			e.socket_async_result.Init(this, callback, state, operation);
			if (e.AcceptSocket != null)
			{
				e.socket_async_result.AcceptSocket = e.AcceptSocket;
			}
			e.SetCurrentSocket(this);
			e.SetLastOperation(this.SocketOperationToSocketAsyncOperation(operation));
			e.SocketError = SocketError.Success;
			e.SetBytesTransferred(0);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00049BD4 File Offset: 0x00047DD4
		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			switch (op)
			{
			case SocketOperation.Accept:
				return SocketAsyncOperation.Accept;
			case SocketOperation.Connect:
				return SocketAsyncOperation.Connect;
			case SocketOperation.Receive:
			case SocketOperation.ReceiveGeneric:
				return SocketAsyncOperation.Receive;
			case SocketOperation.ReceiveFrom:
				return SocketAsyncOperation.ReceiveFrom;
			case SocketOperation.Send:
			case SocketOperation.SendGeneric:
				return SocketAsyncOperation.Send;
			case SocketOperation.SendTo:
				return SocketAsyncOperation.SendTo;
			case SocketOperation.Disconnect:
				return SocketAsyncOperation.Disconnect;
			}
			throw new NotImplementedException(string.Format("Operation {0} is not implemented", op));
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00049C3D File Offset: 0x00047E3D
		private IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			if (this.IsDualMode && input.AddressFamily == AddressFamily.InterNetwork)
			{
				return new IPEndPoint(input.Address.MapToIPv6(), input.Port);
			}
			return input;
		}

		// Token: 0x06000E1D RID: 3613
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void cancel_blocking_socket_operation(Thread thread);

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00049C68 File Offset: 0x00047E68
		internal static int FamilyHint
		{
			get
			{
				int num = 0;
				if (Socket.OSSupportsIPv4)
				{
					num = 1;
				}
				if (Socket.OSSupportsIPv6)
				{
					num = ((num == 0) ? 2 : 0);
				}
				return num;
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00009518 File Offset: 0x00007718
		private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			return true;
		}

		// Token: 0x04000A41 RID: 2625
		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
		{
			Socket.CompleteAccept((Socket)s, (Socket.TaskSocketAsyncEventArgs<Socket>)e);
		};

		// Token: 0x04000A42 RID: 2626
		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
		{
			Socket.CompleteSendReceive((Socket)s, (Socket.Int32TaskSocketAsyncEventArgs)e, true);
		};

		// Token: 0x04000A43 RID: 2627
		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler = delegate(object s, SocketAsyncEventArgs e)
		{
			Socket.CompleteSendReceive((Socket)s, (Socket.Int32TaskSocketAsyncEventArgs)e, false);
		};

		// Token: 0x04000A44 RID: 2628
		private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel = new Socket.TaskSocketAsyncEventArgs<Socket>();

		// Token: 0x04000A45 RID: 2629
		private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel = new Socket.Int32TaskSocketAsyncEventArgs();

		// Token: 0x04000A46 RID: 2630
		private static readonly Task<int> s_zeroTask = Task.FromResult<int>(0);

		// Token: 0x04000A47 RID: 2631
		private Socket.CachedEventArgs _cachedTaskEventArgs;

		// Token: 0x04000A48 RID: 2632
		private static object s_InternalSyncObject;

		// Token: 0x04000A49 RID: 2633
		internal static volatile bool s_SupportsIPv4;

		// Token: 0x04000A4A RID: 2634
		internal static volatile bool s_SupportsIPv6;

		// Token: 0x04000A4B RID: 2635
		internal static volatile bool s_OSSupportsIPv6;

		// Token: 0x04000A4C RID: 2636
		internal static volatile bool s_Initialized;

		// Token: 0x04000A4D RID: 2637
		private static volatile bool s_LoggingEnabled;

		// Token: 0x04000A4E RID: 2638
		internal static volatile bool s_PerfCountersEnabled;

		// Token: 0x04000A4F RID: 2639
		internal const int DefaultCloseTimeout = -1;

		// Token: 0x04000A50 RID: 2640
		private const int SOCKET_CLOSED_CODE = 10004;

		// Token: 0x04000A51 RID: 2641
		private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";

		// Token: 0x04000A52 RID: 2642
		private bool is_closed;

		// Token: 0x04000A53 RID: 2643
		private bool is_listening;

		// Token: 0x04000A54 RID: 2644
		private bool useOverlappedIO;

		// Token: 0x04000A55 RID: 2645
		private int linger_timeout;

		// Token: 0x04000A56 RID: 2646
		private AddressFamily addressFamily;

		// Token: 0x04000A57 RID: 2647
		private SocketType socketType;

		// Token: 0x04000A58 RID: 2648
		private ProtocolType protocolType;

		// Token: 0x04000A59 RID: 2649
		internal SafeSocketHandle m_Handle;

		// Token: 0x04000A5A RID: 2650
		internal EndPoint seed_endpoint;

		// Token: 0x04000A5B RID: 2651
		internal SemaphoreSlim ReadSem = new SemaphoreSlim(1, 1);

		// Token: 0x04000A5C RID: 2652
		internal SemaphoreSlim WriteSem = new SemaphoreSlim(1, 1);

		// Token: 0x04000A5D RID: 2653
		internal bool is_blocking = true;

		// Token: 0x04000A5E RID: 2654
		internal bool is_bound;

		// Token: 0x04000A5F RID: 2655
		internal bool is_connected;

		// Token: 0x04000A60 RID: 2656
		private int m_IntCleanedUp;

		// Token: 0x04000A61 RID: 2657
		internal bool connect_in_progress;

		// Token: 0x04000A62 RID: 2658
		internal readonly int ID;

		// Token: 0x04000A63 RID: 2659
		private static AsyncCallback AcceptAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.AcceptSocket = socketAsyncEventArgs.CurrentSocket.EndAccept(ares);
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				if (socketAsyncEventArgs.AcceptSocket == null)
				{
					socketAsyncEventArgs.AcceptSocket = new Socket(socketAsyncEventArgs.CurrentSocket.AddressFamily, socketAsyncEventArgs.CurrentSocket.SocketType, socketAsyncEventArgs.CurrentSocket.ProtocolType, null);
				}
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04000A64 RID: 2660
		private static IOAsyncCallback BeginAcceptCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			Socket socket = null;
			try
			{
				if (socketAsyncResult.AcceptSocket == null)
				{
					socket = socketAsyncResult.socket.Accept();
				}
				else
				{
					socket = socketAsyncResult.AcceptSocket;
					socketAsyncResult.socket.Accept(socket);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(socket);
		};

		// Token: 0x04000A65 RID: 2661
		private static IOAsyncCallback BeginAcceptReceiveCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			Socket socket = null;
			try
			{
				if (socketAsyncResult.AcceptSocket == null)
				{
					socket = socketAsyncResult.socket.Accept();
				}
				else
				{
					socket = socketAsyncResult.AcceptSocket;
					socketAsyncResult.socket.Accept(socket);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			int total = 0;
			if (socketAsyncResult.Size > 0)
			{
				try
				{
					SocketError socketError;
					total = socket.Receive(socketAsyncResult.Buffer, socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, out socketError);
					if (socketError != SocketError.Success)
					{
						socketAsyncResult.Complete(new SocketException((int)socketError));
						return;
					}
				}
				catch (Exception e2)
				{
					socketAsyncResult.Complete(e2);
					return;
				}
			}
			socketAsyncResult.Complete(socket, total);
		};

		// Token: 0x04000A66 RID: 2662
		private static AsyncCallback ConnectAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.CurrentSocket.EndConnect(ares);
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04000A67 RID: 2663
		private static IOAsyncCallback BeginConnectCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			if (socketAsyncResult.EndPoint == null)
			{
				socketAsyncResult.Complete(new SocketException(10049));
				return;
			}
			try
			{
				int num = (int)socketAsyncResult.socket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error);
				if (num == 0)
				{
					socketAsyncResult.socket.seed_endpoint = socketAsyncResult.EndPoint;
					socketAsyncResult.socket.is_connected = true;
					socketAsyncResult.socket.is_bound = true;
					socketAsyncResult.socket.connect_in_progress = false;
					socketAsyncResult.error = 0;
					socketAsyncResult.Complete();
				}
				else if (socketAsyncResult.Addresses == null)
				{
					socketAsyncResult.socket.connect_in_progress = false;
					socketAsyncResult.Complete(new SocketException(num));
				}
				else if (socketAsyncResult.CurrentAddress >= socketAsyncResult.Addresses.Length)
				{
					socketAsyncResult.Complete(new SocketException(num));
				}
				else
				{
					Socket.BeginMConnect(socketAsyncResult);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.socket.connect_in_progress = false;
				socketAsyncResult.Complete(e);
			}
		};

		// Token: 0x04000A68 RID: 2664
		private static AsyncCallback DisconnectAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.CurrentSocket.EndDisconnect(ares);
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04000A69 RID: 2665
		private static IOAsyncCallback BeginDisconnectCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			try
			{
				socketAsyncResult.socket.Disconnect(socketAsyncResult.ReuseSocket);
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete();
		};

		// Token: 0x04000A6A RID: 2666
		private static AsyncCallback ReceiveAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndReceive(ares));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04000A6B RID: 2667
		private static IOAsyncCallback BeginReceiveCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				using (MemoryHandle memoryHandle = socketAsyncResult.Buffer.Slice(socketAsyncResult.Offset, socketAsyncResult.Size).Pin())
				{
					total = Socket.Receive_internal(socketAsyncResult.socket.m_Handle, (byte*)memoryHandle.Pointer, socketAsyncResult.Size, socketAsyncResult.SockFlags, out socketAsyncResult.error, socketAsyncResult.socket.is_blocking);
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x04000A6C RID: 2668
		private static IOAsyncCallback BeginReceiveGenericCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				total = socketAsyncResult.socket.Receive(socketAsyncResult.Buffers, socketAsyncResult.SockFlags);
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x04000A6D RID: 2669
		private static AsyncCallback ReceiveFromAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndReceiveFrom_internal((SocketAsyncResult)ares, socketAsyncEventArgs));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04000A6E RID: 2670
		private static IOAsyncCallback BeginReceiveFromCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				SocketError socketError;
				total = socketAsyncResult.socket.ReceiveFrom(socketAsyncResult.Buffer, socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, ref socketAsyncResult.EndPoint, out socketError);
				if (socketError != SocketError.Success)
				{
					socketAsyncResult.Complete(new SocketException(socketError));
					return;
				}
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x04000A6F RID: 2671
		private static AsyncCallback SendAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndSend(ares));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x04000A70 RID: 2672
		private static IOAsyncCallback BeginSendGenericCallback = delegate(IOAsyncResult ares)
		{
			SocketAsyncResult socketAsyncResult = (SocketAsyncResult)ares;
			int total = 0;
			try
			{
				total = socketAsyncResult.socket.Send(socketAsyncResult.Buffers, socketAsyncResult.SockFlags);
			}
			catch (Exception e)
			{
				socketAsyncResult.Complete(e);
				return;
			}
			socketAsyncResult.Complete(total);
		};

		// Token: 0x04000A71 RID: 2673
		private static AsyncCallback SendToAsyncCallback = delegate(IAsyncResult ares)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = (SocketAsyncEventArgs)((SocketAsyncResult)ares).AsyncState;
			if (Interlocked.Exchange(ref socketAsyncEventArgs.in_progress, 0) != 1)
			{
				throw new InvalidOperationException("No operation in progress");
			}
			try
			{
				socketAsyncEventArgs.SetBytesTransferred(socketAsyncEventArgs.CurrentSocket.EndSendTo(ares));
			}
			catch (SocketException ex)
			{
				socketAsyncEventArgs.SocketError = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				socketAsyncEventArgs.SocketError = SocketError.OperationAborted;
			}
			finally
			{
				socketAsyncEventArgs.Complete_internal();
			}
		};

		// Token: 0x020001FC RID: 508
		private sealed class CachedEventArgs
		{
			// Token: 0x04000A72 RID: 2674
			public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept;

			// Token: 0x04000A73 RID: 2675
			public Socket.Int32TaskSocketAsyncEventArgs TaskReceive;

			// Token: 0x04000A74 RID: 2676
			public Socket.Int32TaskSocketAsyncEventArgs TaskSend;

			// Token: 0x04000A75 RID: 2677
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;

			// Token: 0x04000A76 RID: 2678
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;
		}

		// Token: 0x020001FD RID: 509
		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			// Token: 0x06000E22 RID: 3618 RVA: 0x00049E36 File Offset: 0x00048036
			internal TaskSocketAsyncEventArgs() : base(false)
			{
			}

			// Token: 0x06000E23 RID: 3619 RVA: 0x00049E40 File Offset: 0x00048040
			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
			{
				AsyncTaskMethodBuilder<TResult> builder;
				lock (this)
				{
					responsibleForReturningToPool = this._accessed;
					this._accessed = true;
					Task<TResult> task = this._builder.Task;
					builder = this._builder;
				}
				return builder;
			}

			// Token: 0x04000A77 RID: 2679
			internal AsyncTaskMethodBuilder<TResult> _builder;

			// Token: 0x04000A78 RID: 2680
			internal bool _accessed;
		}

		// Token: 0x020001FE RID: 510
		private sealed class Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int>
		{
			// Token: 0x04000A79 RID: 2681
			internal bool _wrapExceptionsInIOExceptions;
		}

		// Token: 0x020001FF RID: 511
		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
		{
			// Token: 0x06000E25 RID: 3621 RVA: 0x00049EA0 File Offset: 0x000480A0
			public AwaitableSocketAsyncEventArgs() : base(false)
			{
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00049EB4 File Offset: 0x000480B4
			// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00049EBC File Offset: 0x000480BC
			public bool WrapExceptionsInIOExceptions { get; set; }

			// Token: 0x06000E28 RID: 3624 RVA: 0x00049EC5 File Offset: 0x000480C5
			public bool Reserve()
			{
				return Interlocked.CompareExchange<Action<object>>(ref this._continuation, null, Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel) == Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel;
			}

			// Token: 0x06000E29 RID: 3625 RVA: 0x00049EDF File Offset: 0x000480DF
			private void Release()
			{
				this._token += 1;
				Volatile.Write<Action<object>>(ref this._continuation, Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel);
			}

			// Token: 0x06000E2A RID: 3626 RVA: 0x00049F00 File Offset: 0x00048100
			protected override void OnCompleted(SocketAsyncEventArgs _)
			{
				Action<object> action = this._continuation;
				if (action != null || (action = Interlocked.CompareExchange<Action<object>>(ref this._continuation, Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel, null)) != null)
				{
					object userToken = base.UserToken;
					base.UserToken = null;
					this._continuation = Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel;
					ExecutionContext executionContext = this._executionContext;
					if (executionContext == null)
					{
						this.InvokeContinuation(action, userToken, false);
						return;
					}
					this._executionContext = null;
					ExecutionContext.Run(executionContext, delegate(object runState)
					{
						Tuple<Socket.AwaitableSocketAsyncEventArgs, Action<object>, object> tuple = (Tuple<Socket.AwaitableSocketAsyncEventArgs, Action<object>, object>)runState;
						tuple.Item1.InvokeContinuation(tuple.Item2, tuple.Item3, false);
					}, Tuple.Create<Socket.AwaitableSocketAsyncEventArgs, Action<object>, object>(this, action, userToken));
				}
			}

			// Token: 0x06000E2B RID: 3627 RVA: 0x00049F90 File Offset: 0x00048190
			public ValueTask<int> ReceiveAsync(Socket socket)
			{
				if (socket.ReceiveAsync(this))
				{
					return new ValueTask<int>(this, this._token);
				}
				int bytesTransferred = base.BytesTransferred;
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					return new ValueTask<int>(Task.FromException<int>(this.CreateException(socketError)));
				}
				return new ValueTask<int>(bytesTransferred);
			}

			// Token: 0x06000E2C RID: 3628 RVA: 0x00049FE4 File Offset: 0x000481E4
			public ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				if (socket.SendAsync(this))
				{
					return new ValueTask(this, this._token);
				}
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					return new ValueTask(Task.FromException(this.CreateException(socketError)));
				}
				return default(ValueTask);
			}

			// Token: 0x06000E2D RID: 3629 RVA: 0x0004A032 File Offset: 0x00048232
			public ValueTaskSourceStatus GetStatus(short token)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				if (this._continuation != Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel)
				{
					return ValueTaskSourceStatus.Pending;
				}
				if (base.SocketError != SocketError.Success)
				{
					return ValueTaskSourceStatus.Faulted;
				}
				return ValueTaskSourceStatus.Succeeded;
			}

			// Token: 0x06000E2E RID: 3630 RVA: 0x0004A060 File Offset: 0x00048260
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				if ((flags & ValueTaskSourceOnCompletedFlags.FlowExecutionContext) != ValueTaskSourceOnCompletedFlags.None)
				{
					this._executionContext = ExecutionContext.Capture();
				}
				if ((flags & ValueTaskSourceOnCompletedFlags.UseSchedulingContext) != ValueTaskSourceOnCompletedFlags.None)
				{
					SynchronizationContext synchronizationContext = SynchronizationContext.Current;
					if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
					{
						this._scheduler = synchronizationContext;
					}
					else
					{
						TaskScheduler taskScheduler = TaskScheduler.Current;
						if (taskScheduler != TaskScheduler.Default)
						{
							this._scheduler = taskScheduler;
						}
					}
				}
				base.UserToken = state;
				Action<object> action = Interlocked.CompareExchange<Action<object>>(ref this._continuation, continuation, null);
				if (action == Socket.AwaitableSocketAsyncEventArgs.s_completedSentinel)
				{
					this._executionContext = null;
					base.UserToken = null;
					this.InvokeContinuation(continuation, state, true);
					return;
				}
				if (action != null)
				{
					this.ThrowMultipleContinuationsException();
				}
			}

			// Token: 0x06000E2F RID: 3631 RVA: 0x0004A110 File Offset: 0x00048310
			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
			{
				object scheduler = this._scheduler;
				this._scheduler = null;
				if (scheduler != null)
				{
					SynchronizationContext synchronizationContext = scheduler as SynchronizationContext;
					if (synchronizationContext != null)
					{
						synchronizationContext.Post(delegate(object s)
						{
							Tuple<Action<object>, object> tuple = (Tuple<Action<object>, object>)s;
							tuple.Item1(tuple.Item2);
						}, Tuple.Create<Action<object>, object>(continuation, state));
						return;
					}
					Task.Factory.StartNew(continuation, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach, (TaskScheduler)scheduler);
					return;
				}
				else
				{
					if (forceAsync)
					{
						ThreadPool.QueueUserWorkItem<object>(continuation, state, true);
						return;
					}
					continuation(state);
					return;
				}
			}

			// Token: 0x06000E30 RID: 3632 RVA: 0x0004A194 File Offset: 0x00048394
			public int GetResult(short token)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				SocketError socketError = base.SocketError;
				int bytesTransferred = base.BytesTransferred;
				this.Release();
				if (socketError != SocketError.Success)
				{
					this.ThrowException(socketError);
				}
				return bytesTransferred;
			}

			// Token: 0x06000E31 RID: 3633 RVA: 0x0004A1D0 File Offset: 0x000483D0
			void IValueTaskSource.GetResult(short token)
			{
				if (token != this._token)
				{
					this.ThrowIncorrectTokenException();
				}
				SocketError socketError = base.SocketError;
				this.Release();
				if (socketError != SocketError.Success)
				{
					this.ThrowException(socketError);
				}
			}

			// Token: 0x06000E32 RID: 3634 RVA: 0x0004A203 File Offset: 0x00048403
			private void ThrowIncorrectTokenException()
			{
				throw new InvalidOperationException("The result of the operation was already consumed and may not be used again.");
			}

			// Token: 0x06000E33 RID: 3635 RVA: 0x0004A20F File Offset: 0x0004840F
			private void ThrowMultipleContinuationsException()
			{
				throw new InvalidOperationException("Another continuation was already registered.");
			}

			// Token: 0x06000E34 RID: 3636 RVA: 0x0004A21B File Offset: 0x0004841B
			private void ThrowException(SocketError error)
			{
				throw this.CreateException(error);
			}

			// Token: 0x06000E35 RID: 3637 RVA: 0x0004A224 File Offset: 0x00048424
			private Exception CreateException(SocketError error)
			{
				SocketException ex = new SocketException((int)error);
				if (!this.WrapExceptionsInIOExceptions)
				{
					return ex;
				}
				return new IOException(SR.Format("Unable to read data from the transport connection: {0}.", ex.Message), ex);
			}

			// Token: 0x04000A7A RID: 2682
			internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved = new Socket.AwaitableSocketAsyncEventArgs
			{
				_continuation = null
			};

			// Token: 0x04000A7B RID: 2683
			private static readonly Action<object> s_completedSentinel = delegate(object state)
			{
				throw new Exception("s_completedSentinel");
			};

			// Token: 0x04000A7C RID: 2684
			private static readonly Action<object> s_availableSentinel = delegate(object state)
			{
				throw new Exception("s_availableSentinel");
			};

			// Token: 0x04000A7D RID: 2685
			private Action<object> _continuation = Socket.AwaitableSocketAsyncEventArgs.s_availableSentinel;

			// Token: 0x04000A7E RID: 2686
			private ExecutionContext _executionContext;

			// Token: 0x04000A7F RID: 2687
			private object _scheduler;

			// Token: 0x04000A80 RID: 2688
			private short _token;
		}

		// Token: 0x02000201 RID: 513
		private struct WSABUF
		{
			// Token: 0x04000A85 RID: 2693
			public int len;

			// Token: 0x04000A86 RID: 2694
			public IntPtr buf;
		}
	}
}
