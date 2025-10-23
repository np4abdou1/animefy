using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Util.Concurrent.Locks
{
	// Token: 0x0200035E RID: 862
	[Register("java/util/concurrent/locks/Lock", "", "Java.Util.Concurrent.Locks.ILockInvoker")]
	public interface ILock : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002651 RID: 9809
		void Lock();

		// Token: 0x06002652 RID: 9810
		void LockInterruptibly();

		// Token: 0x06002653 RID: 9811
		ICondition NewCondition();

		// Token: 0x06002654 RID: 9812
		bool TryLock();

		// Token: 0x06002655 RID: 9813
		bool TryLock(long time, TimeUnit unit);

		// Token: 0x06002656 RID: 9814
		void Unlock();
	}
}
