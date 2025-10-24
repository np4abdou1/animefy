using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Util.Concurrent.Locks
{
	// Token: 0x0200035C RID: 860
	[Register("java/util/concurrent/locks/Condition", "", "Java.Util.Concurrent.Locks.IConditionInvoker")]
	public interface ICondition : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600262D RID: 9773
		void Await();

		// Token: 0x0600262E RID: 9774
		bool Await(long time, TimeUnit unit);

		// Token: 0x0600262F RID: 9775
		long AwaitNanos(long nanosTimeout);

		// Token: 0x06002630 RID: 9776
		void AwaitUninterruptibly();

		// Token: 0x06002631 RID: 9777
		bool AwaitUntil(Date deadline);

		// Token: 0x06002632 RID: 9778
		void Signal();

		// Token: 0x06002633 RID: 9779
		void SignalAll();
	}
}
