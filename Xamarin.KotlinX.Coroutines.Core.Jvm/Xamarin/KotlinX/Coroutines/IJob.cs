using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200006B RID: 107
	[NullableContext(1)]
	[Register("kotlinx/coroutines/Job", "", "Xamarin.KotlinX.Coroutines.IJobInvoker")]
	public interface IJob : ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600043B RID: 1083
		CancellationException CancellationException { [Register("getCancellationException", "()Ljava/util/concurrent/CancellationException;", "GetGetCancellationExceptionHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600043C RID: 1084
		ISequence Children { [Register("getChildren", "()Lkotlin/sequences/Sequence;", "GetGetChildrenHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600043D RID: 1085
		bool IsActive { [Register("isActive", "()Z", "GetIsActiveHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600043E RID: 1086
		bool IsCancelled { [Register("isCancelled", "()Z", "GetIsCancelledHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600043F RID: 1087
		bool IsCompleted { [Register("isCompleted", "()Z", "GetIsCompletedHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000440 RID: 1088
		ISelectClause0 OnJoin { [Register("getOnJoin", "()Lkotlinx/coroutines/selects/SelectClause0;", "GetGetOnJoinHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000441 RID: 1089
		[Nullable(2)]
		IJob Parent { [NullableContext(2)] [Register("getParent", "()Lkotlinx/coroutines/Job;", "GetGetParentHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x06000442 RID: 1090
		[Register("attachChild", "(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;", "GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IChildHandle AttachChild(IChildJob child);

		// Token: 0x06000443 RID: 1091
		[NullableContext(2)]
		[Register("cancel", "(Ljava/util/concurrent/CancellationException;)V", "GetCancel_Ljava_util_concurrent_CancellationException_Handler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void Cancel(CancellationException cause);

		// Token: 0x06000444 RID: 1092
		[Register("invokeOnCompletion", "(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", "GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IDisposableHandle InvokeOnCompletion(bool onCancelling, bool invokeImmediately, IFunction1 handler);

		// Token: 0x06000445 RID: 1093
		[Register("invokeOnCompletion", "(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", "GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IDisposableHandle InvokeOnCompletion(IFunction1 handler);

		// Token: 0x06000446 RID: 1094
		[Register("join", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetJoin_Lkotlin_coroutines_Continuation_Handler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		[return: Nullable(2)]
		Java.Lang.Object Join(IContinuation p0);

		// Token: 0x06000447 RID: 1095
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "GetPlus_Lkotlinx_coroutines_Job_Handler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IJob Plus(IJob other);

		// Token: 0x06000448 RID: 1096
		[Register("start", "()Z", "GetStartHandler:Xamarin.KotlinX.Coroutines.IJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool Start();

		// Token: 0x0400017E RID: 382
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Job", typeof(IJob), true);
	}
}
