using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000355 RID: 853
	[Register("java/util/concurrent/ScheduledExecutorService", "", "Java.Util.Concurrent.IScheduledExecutorServiceInvoker")]
	public interface IScheduledExecutorService : IExecutorService, IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060025AB RID: 9643
		IScheduledFuture Schedule(IRunnable command, long delay, TimeUnit unit);

		// Token: 0x060025AC RID: 9644
		[JavaTypeParameters(new string[]
		{
			"V"
		})]
		IScheduledFuture Schedule(ICallable callable, long delay, TimeUnit unit);

		// Token: 0x060025AD RID: 9645
		IScheduledFuture ScheduleAtFixedRate(IRunnable command, long initialDelay, long period, TimeUnit unit);

		// Token: 0x060025AE RID: 9646
		IScheduledFuture ScheduleWithFixedDelay(IRunnable command, long initialDelay, long delay, TimeUnit unit);
	}
}
