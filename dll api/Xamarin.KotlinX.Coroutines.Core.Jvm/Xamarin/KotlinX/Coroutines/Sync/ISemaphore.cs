using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x0200008B RID: 139
	[Register("kotlinx/coroutines/sync/Semaphore", "", "Xamarin.KotlinX.Coroutines.Sync.ISemaphoreInvoker")]
	public interface ISemaphore : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600062C RID: 1580
		int AvailablePermits { [Register("getAvailablePermits", "()I", "GetGetAvailablePermitsHandler:Xamarin.KotlinX.Coroutines.Sync.ISemaphoreInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x0600062D RID: 1581
		[NullableContext(1)]
		[Register("acquire", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetAcquire_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Sync.ISemaphoreInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Acquire(IContinuation p0);

		// Token: 0x0600062E RID: 1582
		[Register("release", "()V", "GetReleaseHandler:Xamarin.KotlinX.Coroutines.Sync.ISemaphoreInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Release();

		// Token: 0x0600062F RID: 1583
		[Register("tryAcquire", "()Z", "GetTryAcquireHandler:Xamarin.KotlinX.Coroutines.Sync.ISemaphoreInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool TryAcquire();
	}
}
