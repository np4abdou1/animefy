using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Net.Sockets
{
	/// <summary>Represents an asynchronous socket operation.</summary>
	// Token: 0x02000217 RID: 535
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		/// <summary>Gets or sets the socket to use or the socket created for accepting a connection with an asynchronous socket method.</summary>
		/// <returns>The <see cref="T:System.Net.Sockets.Socket" /> to use or the socket created for accepting a connection with an asynchronous socket method.</returns>
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0004B6E3 File Offset: 0x000498E3
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x0004B6EB File Offset: 0x000498EB
		public Socket AcceptSocket { get; set; }

		/// <summary>Gets the number of bytes transferred in the socket operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the number of bytes transferred in the socket operation.</returns>
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0004B6F4 File Offset: 0x000498F4
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x0004B6FC File Offset: 0x000498FC
		public int BytesTransferred { get; private set; }

		/// <summary>Gets the type of socket operation most recently performed with this context object.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketAsyncOperation" /> instance that indicates the type of socket operation most recently performed with this context object.</returns>
		// Token: 0x170002E2 RID: 738
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x0004B705 File Offset: 0x00049905
		private SocketAsyncOperation LastOperation
		{
			[CompilerGenerated]
			set
			{
				this.<LastOperation>k__BackingField = value;
			}
		}

		/// <summary>Gets or sets the remote IP endpoint for an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Net.EndPoint" /> that represents the remote IP endpoint for an asynchronous operation.</returns>
		// Token: 0x170002E3 RID: 739
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x0004B70E File Offset: 0x0004990E
		public EndPoint RemoteEndPoint
		{
			set
			{
				this.remote_ep = value;
			}
		}

		/// <summary>Gets or sets the result of the asynchronous socket operation.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketError" /> that represents the result of the asynchronous socket operation.</returns>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0004B717 File Offset: 0x00049917
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x0004B71F File Offset: 0x0004991F
		public SocketError SocketError { get; set; }

		/// <summary>Gets the results of an asynchronous socket operation or sets the behavior of an asynchronous operation.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketFlags" /> that represents the results of an asynchronous socket operation.</returns>
		// Token: 0x170002E5 RID: 741
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x0004B728 File Offset: 0x00049928
		public SocketFlags SocketFlags
		{
			[CompilerGenerated]
			set
			{
				this.<SocketFlags>k__BackingField = value;
			}
		}

		/// <summary>Gets or sets a user or application object associated with this asynchronous socket operation.</summary>
		/// <returns>An object that represents the user or application object associated with this asynchronous socket operation.</returns>
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0004B731 File Offset: 0x00049931
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x0004B739 File Offset: 0x00049939
		public object UserToken { get; set; }

		// Token: 0x06000E8A RID: 3722 RVA: 0x0004B742 File Offset: 0x00049942
		internal SocketAsyncEventArgs(bool flowExecutionContext)
		{
		}

		/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> class.</summary>
		// Token: 0x06000E8B RID: 3723 RVA: 0x0004B758 File Offset: 0x00049958
		~SocketAsyncEventArgs()
		{
			this.Dispose(false);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0004B788 File Offset: 0x00049988
		private void Dispose(bool disposing)
		{
			this.disposed = true;
			if (disposing)
			{
				int num = this.in_progress;
				return;
			}
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> instance and optionally disposes of the managed resources.</summary>
		// Token: 0x06000E8D RID: 3725 RVA: 0x0004B79E File Offset: 0x0004999E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0004B7AD File Offset: 0x000499AD
		internal void SetBytesTransferred(int value)
		{
			this.BytesTransferred = value;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0004B7B6 File Offset: 0x000499B6
		internal Socket CurrentSocket
		{
			get
			{
				return this.current_socket;
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0004B7BE File Offset: 0x000499BE
		internal void SetCurrentSocket(Socket socket)
		{
			this.current_socket = socket;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0004B7C7 File Offset: 0x000499C7
		internal void SetLastOperation(SocketAsyncOperation op)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("System.Net.Sockets.SocketAsyncEventArgs");
			}
			if (Interlocked.Exchange(ref this.in_progress, 1) != 0)
			{
				throw new InvalidOperationException("Operation already in progress");
			}
			this.LastOperation = op;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0004B7FC File Offset: 0x000499FC
		internal void Complete_internal()
		{
			this.in_progress = 0;
			this.OnCompleted(this);
		}

		/// <summary>Represents a method that is called when an asynchronous operation completes.</summary>
		/// <param name="e">The event that is signaled.</param>
		// Token: 0x06000E93 RID: 3731 RVA: 0x0004B810 File Offset: 0x00049A10
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			if (e == null)
			{
				return;
			}
			EventHandler<SocketAsyncEventArgs> completed = e.Completed;
			if (completed != null)
			{
				completed(e.current_socket, e);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0004B838 File Offset: 0x00049A38
		public Memory<byte> MemoryBuffer
		{
			get
			{
				return this._buffer;
			}
		}

		/// <summary>Gets the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</returns>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0004B840 File Offset: 0x00049A40
		public int Offset
		{
			get
			{
				return this._offset;
			}
		}

		/// <summary>Gets the maximum amount of data, in bytes, to send or receive in an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the maximum amount of data, in bytes, to send or receive.</returns>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0004B848 File Offset: 0x00049A48
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>Gets or sets an array of data buffers to use with an asynchronous socket method.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> that represents an array of data buffers to use with an asynchronous socket method.</returns>
		/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified on a set operation. This exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property has been set to a non-null value and an attempt was made to set the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property to a non-null value.</exception>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0004B850 File Offset: 0x00049A50
		public IList<ArraySegment<byte>> BufferList
		{
			get
			{
				return this._bufferList;
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0004B858 File Offset: 0x00049A58
		public void SetBuffer(Memory<byte> buffer)
		{
			if (buffer.Length != 0 && this._bufferList != null)
			{
				throw new ArgumentException(SR.Format("Buffer and BufferList properties cannot both be non-null.", "BufferList"));
			}
			this._buffer = buffer;
			this._offset = 0;
			this._count = buffer.Length;
			this._bufferIsExplicitArray = false;
		}

		// Token: 0x04000B92 RID: 2962
		private bool disposed;

		// Token: 0x04000B93 RID: 2963
		internal volatile int in_progress;

		// Token: 0x04000B94 RID: 2964
		private EndPoint remote_ep;

		// Token: 0x04000B95 RID: 2965
		private Socket current_socket;

		// Token: 0x04000B96 RID: 2966
		internal SocketAsyncResult socket_async_result = new SocketAsyncResult();

		// Token: 0x04000B9D RID: 2973
		[CompilerGenerated]
		private EventHandler<SocketAsyncEventArgs> Completed;

		// Token: 0x04000B9E RID: 2974
		private Memory<byte> _buffer;

		// Token: 0x04000B9F RID: 2975
		private int _offset;

		// Token: 0x04000BA0 RID: 2976
		private int _count;

		// Token: 0x04000BA1 RID: 2977
		private bool _bufferIsExplicitArray;

		// Token: 0x04000BA2 RID: 2978
		private IList<ArraySegment<byte>> _bufferList;
	}
}
