using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200005C RID: 92
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Delay", DoNotGenerateAcw = true)]
	internal class IDelayInvoker : Java.Lang.Object, IDelay, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000CE18 File Offset: 0x0000B018
		private static IntPtr java_class_ref
		{
			get
			{
				return IDelayInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000CE3C File Offset: 0x0000B03C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDelayInvoker._members;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000CE43 File Offset: 0x0000B043
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000CE4B File Offset: 0x0000B04B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDelayInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000CE57 File Offset: 0x0000B057
		[NullableContext(2)]
		public static IDelay GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDelay>(handle, transfer);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000CE60 File Offset: 0x0000B060
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDelayInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.Delay'.");
			}
			return handle;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000CE8B File Offset: 0x0000B08B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public IDelayInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDelayInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
		[Obsolete]
		private static Delegate GetDelay_JLkotlin_coroutines_Continuation_Handler()
		{
			if (IDelayInvoker.cb_delay_JLkotlin_coroutines_Continuation_ == null)
			{
				IDelayInvoker.cb_delay_JLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(IDelayInvoker.n_Delay_JLkotlin_coroutines_Continuation_));
			}
			return IDelayInvoker.cb_delay_JLkotlin_coroutines_Continuation_;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Obsolete]
		private static IntPtr n_Delay_JLkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, long time, IntPtr native_p1)
		{
			IDelay @object = Java.Lang.Object.GetObject<IDelay>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Delay(time, object2));
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000CF44 File Offset: 0x0000B144
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Delay(long time, IContinuation p1)
		{
			if (this.id_delay_JLkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_delay_JLkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "delay", "(JLkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(time);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_delay_JLkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
		private static Delegate GetInvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IDelayInvoker.cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IDelayInvoker.cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJLL_L(IDelayInvoker.n_InvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_));
			}
			return IDelayInvoker.cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		private static IntPtr n_InvokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, long timeMillis, IntPtr native_block, IntPtr native_context)
		{
			IDelay @object = Java.Lang.Object.GetObject<IDelay>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_block, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object3 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnTimeout(timeMillis, object2, object3));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000D030 File Offset: 0x0000B230
		public unsafe IDisposableHandle InvokeOnTimeout(long timeMillis, IRunnable block, ICoroutineContext context)
		{
			if (this.id_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_ == IntPtr.Zero)
			{
				this.id_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnTimeout", "(JLjava/lang/Runnable;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/DisposableHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeMillis);
			ptr[1] = new JValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
			ptr[2] = new JValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
			return Java.Lang.Object.GetObject<IDisposableHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000D0EB File Offset: 0x0000B2EB
		private static Delegate GetScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_Handler()
		{
			if (IDelayInvoker.cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_ == null)
			{
				IDelayInvoker.cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_V(IDelayInvoker.n_ScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_));
			}
			return IDelayInvoker.cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000D110 File Offset: 0x0000B310
		private static void n_ScheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_(IntPtr jnienv, IntPtr native__this, long timeMillis, IntPtr native_continuation)
		{
			IDelay @object = Java.Lang.Object.GetObject<IDelay>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICancellableContinuation object2 = Java.Lang.Object.GetObject<ICancellableContinuation>(native_continuation, JniHandleOwnership.DoNotTransfer);
			@object.ScheduleResumeAfterDelay(timeMillis, object2);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000D134 File Offset: 0x0000B334
		public unsafe void ScheduleResumeAfterDelay(long timeMillis, ICancellableContinuation continuation)
		{
			if (this.id_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_ == IntPtr.Zero)
			{
				this.id_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_ = JNIEnv.GetMethodID(this.class_ref, "scheduleResumeAfterDelay", "(JLkotlinx/coroutines/CancellableContinuation;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeMillis);
			ptr[1] = new JValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_, ptr);
		}

		// Token: 0x04000148 RID: 328
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Delay", typeof(IDelayInvoker));

		// Token: 0x04000149 RID: 329
		private IntPtr class_ref;

		// Token: 0x0400014A RID: 330
		[Nullable(2)]
		private static Delegate cb_delay_JLkotlin_coroutines_Continuation_;

		// Token: 0x0400014B RID: 331
		private IntPtr id_delay_JLkotlin_coroutines_Continuation_;

		// Token: 0x0400014C RID: 332
		[Nullable(2)]
		private static Delegate cb_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x0400014D RID: 333
		private IntPtr id_invokeOnTimeout_JLjava_lang_Runnable_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x0400014E RID: 334
		[Nullable(2)]
		private static Delegate cb_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_;

		// Token: 0x0400014F RID: 335
		private IntPtr id_scheduleResumeAfterDelay_JLkotlinx_coroutines_CancellableContinuation_;
	}
}
