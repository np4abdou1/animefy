using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Encapsulates the results of an asynchronous operation on a delegate.</summary>
	// Token: 0x02000363 RID: 867
	[ComVisible(true)]
	[StructLayout(0)]
	public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
	{
		// Token: 0x06001B4E RID: 6990 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal AsyncResult()
		{
		}

		/// <summary>Gets the object provided as the last parameter of a <see langword="BeginInvoke" /> method call.</summary>
		/// <returns>The object provided as the last parameter of a <see langword="BeginInvoke" /> method call.</returns>
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00075C48 File Offset: 0x00073E48
		public virtual object AsyncState
		{
			get
			{
				return this.async_state;
			}
		}

		/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</summary>
		/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</returns>
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00075C50 File Offset: 0x00073E50
		public virtual WaitHandle AsyncWaitHandle
		{
			get
			{
				WaitHandle result;
				lock (this)
				{
					if (this.handle == null)
					{
						this.handle = new ManualResetEvent(this.completed);
					}
					result = this.handle;
				}
				return result;
			}
		}

		/// <summary>Gets a value indicating whether the <see langword="BeginInvoke" /> call completed synchronously.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see langword="BeginInvoke" /> call completed synchronously; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00075CA8 File Offset: 0x00073EA8
		public virtual bool CompletedSynchronously
		{
			get
			{
				return this.sync_completed;
			}
		}

		/// <summary>Gets a value indicating whether the server has completed the call.</summary>
		/// <returns>
		///     <see langword="true" /> after the server has completed the call; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00075CB0 File Offset: 0x00073EB0
		public virtual bool IsCompleted
		{
			get
			{
				return this.completed;
			}
		}

		/// <summary>Gets the delegate object on which the asynchronous call was invoked.</summary>
		/// <returns>The delegate object on which the asynchronous call was invoked.</returns>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00075CB8 File Offset: 0x00073EB8
		public virtual object AsyncDelegate
		{
			get
			{
				return this.async_delegate;
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface.</summary>
		/// <param name="msg">The request <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> interface. </param>
		/// <param name="replySink">The response <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface. </param>
		/// <returns>No value is returned.</returns>
		// Token: 0x06001B54 RID: 6996 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}

		/// <summary>Sets an <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call, which provides a way to control asynchronous messages after they have been dispatched.</summary>
		/// <param name="mc">The <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call. </param>
		// Token: 0x06001B55 RID: 6997 RVA: 0x00075CC0 File Offset: 0x00073EC0
		public virtual void SetMessageCtrl(IMessageCtrl mc)
		{
			this.message_ctrl = mc;
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00075CCC File Offset: 0x00073ECC
		internal IMessage EndInvoke()
		{
			lock (this)
			{
				if (this.completed)
				{
					return this.reply_message;
				}
			}
			this.AsyncWaitHandle.WaitOne();
			return this.reply_message;
		}

		/// <summary>Synchronously processes a response message returned by a method call on a remote object.</summary>
		/// <param name="msg">A response message to a method call on a remote object.</param>
		/// <returns>Returns <see langword="null" />.</returns>
		// Token: 0x06001B57 RID: 6999 RVA: 0x00075D28 File Offset: 0x00073F28
		public virtual IMessage SyncProcessMessage(IMessage msg)
		{
			this.reply_message = msg;
			lock (this)
			{
				this.completed = true;
				if (this.handle != null)
				{
					((ManualResetEvent)this.AsyncWaitHandle).Set();
				}
			}
			if (this.async_callback != null)
			{
				((AsyncCallback)this.async_callback)(this);
			}
			return null;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x00075DA0 File Offset: 0x00073FA0
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x00075DA8 File Offset: 0x00073FA8
		internal MonoMethodMessage CallMessage
		{
			get
			{
				return this.call_message;
			}
			set
			{
				this.call_message = value;
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00075DB1 File Offset: 0x00073FB1
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			this.Invoke();
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00002A7D File Offset: 0x00000C7D
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x06001B5C RID: 7004
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern object Invoke();

		// Token: 0x04000B70 RID: 2928
		private object async_state;

		// Token: 0x04000B71 RID: 2929
		private WaitHandle handle;

		// Token: 0x04000B72 RID: 2930
		private object async_delegate;

		// Token: 0x04000B73 RID: 2931
		private IntPtr data;

		// Token: 0x04000B74 RID: 2932
		private object object_data;

		// Token: 0x04000B75 RID: 2933
		private bool sync_completed;

		// Token: 0x04000B76 RID: 2934
		private bool completed;

		// Token: 0x04000B77 RID: 2935
		private bool endinvoke_called;

		// Token: 0x04000B78 RID: 2936
		private object async_callback;

		// Token: 0x04000B79 RID: 2937
		private ExecutionContext current;

		// Token: 0x04000B7A RID: 2938
		private ExecutionContext original;

		// Token: 0x04000B7B RID: 2939
		private long add_time;

		// Token: 0x04000B7C RID: 2940
		private MonoMethodMessage call_message;

		// Token: 0x04000B7D RID: 2941
		private IMessageCtrl message_ctrl;

		// Token: 0x04000B7E RID: 2942
		private IMessage reply_message;

		// Token: 0x04000B7F RID: 2943
		private WaitCallback orig_cb;
	}
}
