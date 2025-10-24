using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Internal;

namespace Xamarin.KotlinX.Coroutines.CoroutinesAndroid
{
	// Token: 0x0200000A RID: 10
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/android/HandlerDispatcher", DoNotGenerateAcw = true)]
	public abstract class HandlerDispatcher : MainCoroutineDispatcher, IDelay, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020A8 File Offset: 0x000002A8
		internal static IntPtr class_ref
		{
			get
			{
				return HandlerDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020CC File Offset: 0x000002CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HandlerDispatcher._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020D4 File Offset: 0x000002D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HandlerDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020F8 File Offset: 0x000002F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HandlerDispatcher._members.ManagedPeerType;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002104 File Offset: 0x00000304
		protected HandlerDispatcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002110 File Offset: 0x00000310
		[NullableContext(2)]
		[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe HandlerDispatcher(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
				base.SetHandle(HandlerDispatcher._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HandlerDispatcher._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_constructor_marker);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021C0 File Offset: 0x000003C0
		[Obsolete]
		private static Delegate GetDelay_JLkotlin_coroutines_Continuation_Handler()
		{
			if (HandlerDispatcher.cb_delay_JLkotlin_coroutines_Continuation_ == null)
			{
				HandlerDispatcher.cb_delay_JLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(HandlerDispatcher.n_Delay_JLkotlin_coroutines_Continuation_));
			}
			return HandlerDispatcher.cb_delay_JLkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021E4 File Offset: 0x000003E4
		[Obsolete]
		private static IntPtr n_Delay_JLkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, long time, IntPtr native__completion)
		{
			HandlerDispatcher @object = Java.Lang.Object.GetObject<HandlerDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native__completion, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Delay(time, object2));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002210 File Offset: 0x00000410
		[Obsolete("deprecated")]
		[Register("delay", "(JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetDelay_JLkotlin_coroutines_Continuation_Handler")]
		[return: Nullable(2)]
		public unsafe virtual Java.Lang.Object Delay(long time, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(time);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HandlerDispatcher._members.InstanceMethods.InvokeVirtualObjectMethod("delay.(JLkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000229C File Offset: 0x0000049C
		private static Delegate GetInvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (HandlerDispatcher.cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				HandlerDispatcher.cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJLL_L(HandlerDispatcher.n_InvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_));
			}
			return HandlerDispatcher.cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022C0 File Offset: 0x000004C0
		private static IntPtr n_InvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, long timeMillis, IntPtr native_block, IntPtr native_context)
		{
			HandlerDispatcher @object = Java.Lang.Object.GetObject<HandlerDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_block, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object3 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnTimeout(timeMillis, object2, object3));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022F4 File Offset: 0x000004F4
		[Register("invokeOnTimeout", "(JLjava/lang/Runnable;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/DisposableHandle;", "GetInvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_Handler")]
		public unsafe virtual IDisposableHandle InvokeOnTimeout(long timeMillis, IRunnable block, ICoroutineContext context)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeMillis);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[2] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(HandlerDispatcher._members.InstanceMethods.InvokeVirtualObjectMethod("invokeOnTimeout.(JLjava/lang/Runnable;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/DisposableHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000023B0 File Offset: 0x000005B0
		private static Delegate GetScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_Handler()
		{
			if (HandlerDispatcher.cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_ == null)
			{
				HandlerDispatcher.cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_V(HandlerDispatcher.n_ScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_));
			}
			return HandlerDispatcher.cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023D4 File Offset: 0x000005D4
		private static void n_ScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_(IntPtr jnienv, IntPtr native__this, long timeMillis, IntPtr native_continuation)
		{
			HandlerDispatcher @object = Java.Lang.Object.GetObject<HandlerDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICancellableContinuation object2 = Java.Lang.Object.GetObject<ICancellableContinuation>(native_continuation, JniHandleOwnership.DoNotTransfer);
			@object.ScheduleResumeAfterDelay(timeMillis, object2);
		}

		// Token: 0x06000021 RID: 33
		[Register("scheduleResumeAfterDelay", "(JLkotlinx/coroutines/CancellableContinuation;)V", "GetScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_Handler")]
		public abstract void ScheduleResumeAfterDelay(long timeMillis, ICancellableContinuation continuation);

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/android/HandlerDispatcher", typeof(HandlerDispatcher));

		// Token: 0x04000005 RID: 5
		[Nullable(2)]
		private static Delegate cb_delay_JLkotlin_coroutines_Continuation_;

		// Token: 0x04000006 RID: 6
		[Nullable(2)]
		private static Delegate cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000007 RID: 7
		[Nullable(2)]
		private static Delegate cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_;
	}
}
