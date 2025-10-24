using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
	// Token: 0x02000094 RID: 148
	[StructLayout(0)]
	internal class IOSelectorJob : IThreadPoolWorkItem
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00015C88 File Offset: 0x00013E88
		public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state)
		{
			this.operation = operation;
			this.callback = callback;
			this.state = state;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00015CA5 File Offset: 0x00013EA5
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			this.callback(this.state);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004D67 File Offset: 0x00002F67
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00015CB8 File Offset: 0x00013EB8
		public void MarkDisposed()
		{
			this.state.CompleteDisposed();
		}

		// Token: 0x0400028C RID: 652
		private IOOperation operation;

		// Token: 0x0400028D RID: 653
		private IOAsyncCallback callback;

		// Token: 0x0400028E RID: 654
		private IOAsyncResult state;
	}
}
