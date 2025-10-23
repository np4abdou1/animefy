using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000353 RID: 851
	[Register("java/util/concurrent/Future", "", "Java.Util.Concurrent.IFutureInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IFuture : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600258F RID: 9615
		bool IsCancelled { get; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002590 RID: 9616
		bool IsDone { get; }

		// Token: 0x06002591 RID: 9617
		bool Cancel(bool mayInterruptIfRunning);

		// Token: 0x06002592 RID: 9618
		Java.Lang.Object Get();

		// Token: 0x06002593 RID: 9619
		Java.Lang.Object Get(long timeout, TimeUnit unit);
	}
}
