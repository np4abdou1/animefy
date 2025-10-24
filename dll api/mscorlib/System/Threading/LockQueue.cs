using System;

namespace System.Threading
{
	// Token: 0x020001F0 RID: 496
	internal class LockQueue
	{
		// Token: 0x06001215 RID: 4629 RVA: 0x000493C6 File Offset: 0x000475C6
		public LockQueue(ReaderWriterLock rwlock)
		{
			this.rwlock = rwlock;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000493D8 File Offset: 0x000475D8
		public bool Wait(int timeout)
		{
			bool flag = false;
			bool result;
			try
			{
				lock (this)
				{
					this.lockCount++;
					Monitor.Exit(this.rwlock);
					flag = true;
					result = Monitor.Wait(this, timeout);
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Enter(this.rwlock);
					this.lockCount--;
				}
			}
			return result;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0004945C File Offset: 0x0004765C
		public bool IsEmpty
		{
			get
			{
				bool result;
				lock (this)
				{
					result = (this.lockCount == 0);
				}
				return result;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0004949C File Offset: 0x0004769C
		public void Pulse()
		{
			lock (this)
			{
				Monitor.Pulse(this);
			}
		}

		// Token: 0x040006F3 RID: 1779
		private ReaderWriterLock rwlock;

		// Token: 0x040006F4 RID: 1780
		private int lockCount;
	}
}
