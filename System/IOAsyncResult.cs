using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
	// Token: 0x02000093 RID: 147
	[StructLayout(0)]
	internal abstract class IOAsyncResult : IAsyncResult
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x0000222D File Offset: 0x0000042D
		protected IOAsyncResult()
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00015B68 File Offset: 0x00013D68
		protected void Init(AsyncCallback async_callback, object async_state)
		{
			this.async_callback = async_callback;
			this.async_state = async_state;
			this.completed = false;
			this.completed_synchronously = false;
			if (this.wait_handle != null)
			{
				this.wait_handle.Reset();
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00015B9A File Offset: 0x00013D9A
		protected IOAsyncResult(AsyncCallback async_callback, object async_state)
		{
			this.async_callback = async_callback;
			this.async_state = async_state;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00015BB0 File Offset: 0x00013DB0
		public AsyncCallback AsyncCallback
		{
			get
			{
				return this.async_callback;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00015BB8 File Offset: 0x00013DB8
		public object AsyncState
		{
			get
			{
				return this.async_state;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00015BC0 File Offset: 0x00013DC0
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				WaitHandle result;
				lock (this)
				{
					if (this.wait_handle == null)
					{
						this.wait_handle = new ManualResetEvent(this.completed);
					}
					result = this.wait_handle;
				}
				return result;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00015C18 File Offset: 0x00013E18
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00015C20 File Offset: 0x00013E20
		public bool CompletedSynchronously
		{
			get
			{
				return this.completed_synchronously;
			}
			protected set
			{
				this.completed_synchronously = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00015C29 File Offset: 0x00013E29
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00015C34 File Offset: 0x00013E34
		public bool IsCompleted
		{
			get
			{
				return this.completed;
			}
			protected set
			{
				this.completed = value;
				lock (this)
				{
					if (value && this.wait_handle != null)
					{
						this.wait_handle.Set();
					}
				}
			}
		}

		// Token: 0x060003BF RID: 959
		internal abstract void CompleteDisposed();

		// Token: 0x04000287 RID: 647
		private AsyncCallback async_callback;

		// Token: 0x04000288 RID: 648
		private object async_state;

		// Token: 0x04000289 RID: 649
		private ManualResetEvent wait_handle;

		// Token: 0x0400028A RID: 650
		private bool completed_synchronously;

		// Token: 0x0400028B RID: 651
		private bool completed;
	}
}
