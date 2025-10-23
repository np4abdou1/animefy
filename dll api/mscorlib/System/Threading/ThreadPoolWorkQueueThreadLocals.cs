using System;
using System.Security;

namespace System.Threading
{
	// Token: 0x020001E9 RID: 489
	internal sealed class ThreadPoolWorkQueueThreadLocals
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x00048A1F File Offset: 0x00046C1F
		public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
		{
			this.workQueue = tpq;
			this.workStealingQueue = new ThreadPoolWorkQueue.WorkStealingQueue();
			ThreadPoolWorkQueue.allThreadQueues.Add(this.workStealingQueue);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00048A60 File Offset: 0x00046C60
		[SecurityCritical]
		private void CleanUp()
		{
			if (this.workStealingQueue != null)
			{
				if (this.workQueue != null)
				{
					bool flag = false;
					while (!flag)
					{
						try
						{
						}
						finally
						{
							IThreadPoolWorkItem callback = null;
							if (this.workStealingQueue.LocalPop(out callback))
							{
								this.workQueue.Enqueue(callback, true);
							}
							else
							{
								flag = true;
							}
						}
					}
				}
				ThreadPoolWorkQueue.allThreadQueues.Remove(this.workStealingQueue);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00048ACC File Offset: 0x00046CCC
		[SecuritySafeCritical]
		~ThreadPoolWorkQueueThreadLocals()
		{
			if (!Environment.HasShutdownStarted && !AppDomain.CurrentDomain.IsFinalizingForUnload())
			{
				this.CleanUp();
			}
		}

		// Token: 0x040006DE RID: 1758
		[ThreadStatic]
		[SecurityCritical]
		public static ThreadPoolWorkQueueThreadLocals threadLocals;

		// Token: 0x040006DF RID: 1759
		public readonly ThreadPoolWorkQueue workQueue;

		// Token: 0x040006E0 RID: 1760
		public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

		// Token: 0x040006E1 RID: 1761
		public readonly Random random = new Random(Thread.CurrentThread.ManagedThreadId);
	}
}
