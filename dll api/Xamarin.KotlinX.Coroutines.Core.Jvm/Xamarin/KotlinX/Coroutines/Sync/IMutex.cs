using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x02000089 RID: 137
	[Register("kotlinx/coroutines/sync/Mutex", "", "Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker")]
	public interface IMutex : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600060B RID: 1547
		bool IsLocked { [Register("isLocked", "()Z", "GetIsLockedHandler:Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600060C RID: 1548
		[Nullable(1)]
		ISelectClause2 OnLock { [NullableContext(1)] [Register("getOnLock", "()Lkotlinx/coroutines/selects/SelectClause2;", "GetGetOnLockHandler:Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x0600060D RID: 1549
		[NullableContext(1)]
		[Register("holdsLock", "(Ljava/lang/Object;)Z", "GetHoldsLock_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool HoldsLock(Java.Lang.Object owner);

		// Token: 0x0600060E RID: 1550
		[NullableContext(2)]
		[Register("lock", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetLock_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object Lock(Java.Lang.Object owner, [Nullable(1)] IContinuation p1);

		// Token: 0x0600060F RID: 1551
		[NullableContext(2)]
		[Register("tryLock", "(Ljava/lang/Object;)Z", "GetTryLock_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool TryLock(Java.Lang.Object owner);

		// Token: 0x06000610 RID: 1552
		[NullableContext(2)]
		[Register("unlock", "(Ljava/lang/Object;)V", "GetUnlock_Ljava_lang_Object_Handler:Xamarin.KotlinX.Coroutines.Sync.IMutexInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Unlock(Java.Lang.Object owner);
	}
}
