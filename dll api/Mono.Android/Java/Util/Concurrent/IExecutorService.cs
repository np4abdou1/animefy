using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000351 RID: 849
	[Register("java/util/concurrent/ExecutorService", "", "Java.Util.Concurrent.IExecutorServiceInvoker")]
	public interface IExecutorService : IExecutor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002556 RID: 9558
		bool IsShutdown { get; }

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002557 RID: 9559
		bool IsTerminated { get; }

		// Token: 0x06002558 RID: 9560
		bool AwaitTermination(long timeout, TimeUnit unit);

		// Token: 0x06002559 RID: 9561
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		IList InvokeAll(ICollection tasks);

		// Token: 0x0600255A RID: 9562
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		IList InvokeAll(ICollection tasks, long timeout, TimeUnit unit);

		// Token: 0x0600255B RID: 9563
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object InvokeAny(ICollection tasks);

		// Token: 0x0600255C RID: 9564
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object InvokeAny(ICollection tasks, long timeout, TimeUnit unit);

		// Token: 0x0600255D RID: 9565
		void Shutdown();

		// Token: 0x0600255E RID: 9566
		IList<IRunnable> ShutdownNow();

		// Token: 0x0600255F RID: 9567
		IFuture Submit(IRunnable task);

		// Token: 0x06002560 RID: 9568
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		IFuture Submit(IRunnable task, Java.Lang.Object result);

		// Token: 0x06002561 RID: 9569
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		IFuture Submit(ICallable task);
	}
}
