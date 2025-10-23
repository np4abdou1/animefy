using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x0200034F RID: 847
	[Register("java/util/concurrent/Executor", "", "Java.Util.Concurrent.IExecutorInvoker")]
	public interface IExecutor : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600254A RID: 9546
		void Execute(IRunnable command);
	}
}
