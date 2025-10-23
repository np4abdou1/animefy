using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net.Sockets
{
	// Token: 0x02000218 RID: 536
	[StructLayout(0)]
	internal sealed class SocketAsyncResult : IOAsyncResult
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0004B8AD File Offset: 0x00049AAD
		public IntPtr Handle
		{
			get
			{
				if (this.socket == null)
				{
					return IntPtr.Zero;
				}
				return this.socket.Handle;
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0004B8C8 File Offset: 0x00049AC8
		public SocketAsyncResult()
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0004B8D0 File Offset: 0x00049AD0
		public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
		{
			base.Init(callback, state);
			this.socket = socket;
			this.operation = operation;
			this.DelayedException = null;
			this.EndPoint = null;
			this.Buffer = null;
			this.Offset = 0;
			this.Size = 0;
			this.SockFlags = SocketFlags.None;
			this.AcceptSocket = null;
			this.Addresses = null;
			this.Port = 0;
			this.Buffers = null;
			this.ReuseSocket = false;
			this.CurrentAddress = 0;
			this.AcceptedSocket = null;
			this.Total = 0;
			this.error = 0;
			this.EndCalled = 0;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0004B969 File Offset: 0x00049B69
		public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) : base(callback, state)
		{
			this.socket = socket;
			this.operation = operation;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0004B984 File Offset: 0x00049B84
		public SocketError ErrorCode
		{
			get
			{
				SocketException ex = this.DelayedException as SocketException;
				if (ex != null)
				{
					return ex.SocketErrorCode;
				}
				if (this.error != 0)
				{
					return (SocketError)this.error;
				}
				return SocketError.Success;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0004B9B7 File Offset: 0x00049BB7
		public void CheckIfThrowDelayedException()
		{
			if (this.DelayedException != null)
			{
				this.socket.is_connected = false;
				throw this.DelayedException;
			}
			if (this.error != 0)
			{
				this.socket.is_connected = false;
				throw new SocketException(this.error);
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		internal override void CompleteDisposed()
		{
			this.Complete();
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0004B9FC File Offset: 0x00049BFC
		public void Complete()
		{
			if (this.operation != SocketOperation.Receive && this.socket.CleanedUp)
			{
				this.DelayedException = new ObjectDisposedException(this.socket.GetType().ToString());
			}
			base.IsCompleted = true;
			Socket socket = this.socket;
			SocketOperation socketOperation = this.operation;
			if (!base.CompletedSynchronously && base.AsyncCallback != null)
			{
				ThreadPool.UnsafeQueueUserWorkItem(delegate(object state)
				{
					((SocketAsyncResult)state).AsyncCallback((SocketAsyncResult)state);
				}, this);
			}
			switch (socketOperation)
			{
			case SocketOperation.Accept:
			case SocketOperation.Receive:
			case SocketOperation.ReceiveFrom:
			case SocketOperation.ReceiveGeneric:
				socket.ReadSem.Release();
				return;
			case SocketOperation.Connect:
			case SocketOperation.RecvJustCallback:
			case SocketOperation.SendJustCallback:
			case SocketOperation.Disconnect:
			case SocketOperation.AcceptReceive:
				break;
			case SocketOperation.Send:
			case SocketOperation.SendTo:
			case SocketOperation.SendGeneric:
				socket.WriteSem.Release();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0004BAD5 File Offset: 0x00049CD5
		public void Complete(bool synch)
		{
			base.CompletedSynchronously = synch;
			this.Complete();
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		public void Complete(int total)
		{
			this.Total = total;
			this.Complete();
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0004BAF3 File Offset: 0x00049CF3
		public void Complete(Exception e, bool synch)
		{
			this.DelayedException = e;
			base.CompletedSynchronously = synch;
			this.Complete();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0004BB09 File Offset: 0x00049D09
		public void Complete(Exception e)
		{
			this.DelayedException = e;
			this.Complete();
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0004BB18 File Offset: 0x00049D18
		public void Complete(Socket s)
		{
			this.AcceptedSocket = s;
			this.Complete();
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0004BB27 File Offset: 0x00049D27
		public void Complete(Socket s, int total)
		{
			this.AcceptedSocket = s;
			this.Total = total;
			this.Complete();
		}

		// Token: 0x04000BA3 RID: 2979
		public Socket socket;

		// Token: 0x04000BA4 RID: 2980
		public SocketOperation operation;

		// Token: 0x04000BA5 RID: 2981
		private Exception DelayedException;

		// Token: 0x04000BA6 RID: 2982
		public EndPoint EndPoint;

		// Token: 0x04000BA7 RID: 2983
		public Memory<byte> Buffer;

		// Token: 0x04000BA8 RID: 2984
		public int Offset;

		// Token: 0x04000BA9 RID: 2985
		public int Size;

		// Token: 0x04000BAA RID: 2986
		public SocketFlags SockFlags;

		// Token: 0x04000BAB RID: 2987
		public Socket AcceptSocket;

		// Token: 0x04000BAC RID: 2988
		public IPAddress[] Addresses;

		// Token: 0x04000BAD RID: 2989
		public int Port;

		// Token: 0x04000BAE RID: 2990
		public IList<ArraySegment<byte>> Buffers;

		// Token: 0x04000BAF RID: 2991
		public bool ReuseSocket;

		// Token: 0x04000BB0 RID: 2992
		public int CurrentAddress;

		// Token: 0x04000BB1 RID: 2993
		public Socket AcceptedSocket;

		// Token: 0x04000BB2 RID: 2994
		public int Total;

		// Token: 0x04000BB3 RID: 2995
		internal int error;

		// Token: 0x04000BB4 RID: 2996
		public int EndCalled;
	}
}
