using System;
using System.Threading;

namespace System.IO
{
	// Token: 0x0200055E RID: 1374
	internal class FileStreamAsyncResult : IAsyncResult
	{
		// Token: 0x0600290A RID: 10506 RVA: 0x000A3A5F File Offset: 0x000A1C5F
		public FileStreamAsyncResult(AsyncCallback cb, object state)
		{
			this.state = state;
			this.realcb = cb;
			if (this.realcb != null)
			{
				this.cb = new AsyncCallback(FileStreamAsyncResult.CBWrapper);
			}
			this.wh = new ManualResetEvent(false);
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000A3A9B File Offset: 0x000A1C9B
		private static void CBWrapper(IAsyncResult ares)
		{
			((FileStreamAsyncResult)ares).realcb.BeginInvoke(ares, null, null);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000A3AB1 File Offset: 0x000A1CB1
		public object AsyncState
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x000A3AB9 File Offset: 0x000A1CB9
		public bool CompletedSynchronously
		{
			get
			{
				return this.completedSynch;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000A3AC1 File Offset: 0x000A1CC1
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				return this.wh;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x000A3AC9 File Offset: 0x000A1CC9
		public bool IsCompleted
		{
			get
			{
				return this.completed;
			}
		}

		// Token: 0x0400154F RID: 5455
		private object state;

		// Token: 0x04001550 RID: 5456
		private bool completed;

		// Token: 0x04001551 RID: 5457
		private ManualResetEvent wh;

		// Token: 0x04001552 RID: 5458
		private AsyncCallback cb;

		// Token: 0x04001553 RID: 5459
		private bool completedSynch;

		// Token: 0x04001554 RID: 5460
		public int Count;

		// Token: 0x04001555 RID: 5461
		public int OriginalCount;

		// Token: 0x04001556 RID: 5462
		public int BytesRead;

		// Token: 0x04001557 RID: 5463
		private AsyncCallback realcb;
	}
}
