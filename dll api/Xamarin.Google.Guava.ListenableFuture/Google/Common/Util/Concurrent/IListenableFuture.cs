using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Google.Common.Util.Concurrent
{
	// Token: 0x0200000D RID: 13
	[Register("com/google/common/util/concurrent/ListenableFuture", "", "Google.Common.Util.Concurrent.IListenableFutureInvoker")]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public interface IListenableFuture : IFuture, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600001E RID: 30
		[NullableContext(2)]
		[Register("addListener", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)V", "GetAddListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler:Google.Common.Util.Concurrent.IListenableFutureInvoker, Xamarin.Google.Guava.ListenableFuture")]
		void AddListener(IRunnable p0, IExecutor p1);
	}
}
