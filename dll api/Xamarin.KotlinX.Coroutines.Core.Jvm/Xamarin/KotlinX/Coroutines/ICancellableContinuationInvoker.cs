using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200003D RID: 61
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CancellableContinuation", DoNotGenerateAcw = true)]
	internal class ICancellableContinuationInvoker : Java.Lang.Object, ICancellableContinuation, IContinuation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00005618 File Offset: 0x00003818
		private static IntPtr java_class_ref
		{
			get
			{
				return ICancellableContinuationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000563C File Offset: 0x0000383C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICancellableContinuationInvoker._members;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00005643 File Offset: 0x00003843
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000564B File Offset: 0x0000384B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICancellableContinuationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005657 File Offset: 0x00003857
		[NullableContext(2)]
		public static ICancellableContinuation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICancellableContinuation>(handle, transfer);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005660 File Offset: 0x00003860
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICancellableContinuationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CancellableContinuation'.");
			}
			return handle;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000568B File Offset: 0x0000388B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000056BC File Offset: 0x000038BC
		public ICancellableContinuationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICancellableContinuationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000056F4 File Offset: 0x000038F4
		private static Delegate GetIsActiveHandler()
		{
			if (ICancellableContinuationInvoker.cb_isActive == null)
			{
				ICancellableContinuationInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICancellableContinuationInvoker.n_IsActive));
			}
			return ICancellableContinuationInvoker.cb_isActive;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005718 File Offset: 0x00003918
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00005727 File Offset: 0x00003927
		public bool IsActive
		{
			get
			{
				if (this.id_isActive == IntPtr.Zero)
				{
					this.id_isActive = JNIEnv.GetMethodID(this.class_ref, "isActive", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isActive);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005767 File Offset: 0x00003967
		private static Delegate GetIsCancelledHandler()
		{
			if (ICancellableContinuationInvoker.cb_isCancelled == null)
			{
				ICancellableContinuationInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICancellableContinuationInvoker.n_IsCancelled));
			}
			return ICancellableContinuationInvoker.cb_isCancelled;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000578B File Offset: 0x0000398B
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000579A File Offset: 0x0000399A
		public bool IsCancelled
		{
			get
			{
				if (this.id_isCancelled == IntPtr.Zero)
				{
					this.id_isCancelled = JNIEnv.GetMethodID(this.class_ref, "isCancelled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCancelled);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000057DA File Offset: 0x000039DA
		private static Delegate GetIsCompletedHandler()
		{
			if (ICancellableContinuationInvoker.cb_isCompleted == null)
			{
				ICancellableContinuationInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICancellableContinuationInvoker.n_IsCompleted));
			}
			return ICancellableContinuationInvoker.cb_isCompleted;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000057FE File Offset: 0x000039FE
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000580D File Offset: 0x00003A0D
		public bool IsCompleted
		{
			get
			{
				if (this.id_isCompleted == IntPtr.Zero)
				{
					this.id_isCompleted = JNIEnv.GetMethodID(this.class_ref, "isCompleted", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCompleted);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000584D File Offset: 0x00003A4D
		private static Delegate GetCancel_Ljava_lang_Throwable_Handler()
		{
			if (ICancellableContinuationInvoker.cb_cancel_Ljava_lang_Throwable_ == null)
			{
				ICancellableContinuationInvoker.cb_cancel_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICancellableContinuationInvoker.n_Cancel_Ljava_lang_Throwable_));
			}
			return ICancellableContinuationInvoker.cb_cancel_Ljava_lang_Throwable_;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005874 File Offset: 0x00003A74
		private static bool n_Cancel_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.Cancel(object2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005898 File Offset: 0x00003A98
		[NullableContext(2)]
		public unsafe bool Cancel(Throwable cause)
		{
			if (this.id_cancel_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_cancel_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "cancel", "(Ljava/lang/Throwable;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cause == null) ? IntPtr.Zero : cause.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_cancel_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000590B File Offset: 0x00003B0B
		private static Delegate GetCompleteResume_Ljava_lang_Object_Handler()
		{
			if (ICancellableContinuationInvoker.cb_completeResume_Ljava_lang_Object_ == null)
			{
				ICancellableContinuationInvoker.cb_completeResume_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICancellableContinuationInvoker.n_CompleteResume_Ljava_lang_Object_));
			}
			return ICancellableContinuationInvoker.cb_completeResume_Ljava_lang_Object_;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005930 File Offset: 0x00003B30
		private static void n_CompleteResume_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_token, JniHandleOwnership.DoNotTransfer);
			@object.CompleteResume(object2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005954 File Offset: 0x00003B54
		public unsafe void CompleteResume(Java.Lang.Object token)
		{
			if (this.id_completeResume_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_completeResume_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "completeResume", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((token == null) ? IntPtr.Zero : token.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_completeResume_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000059C7 File Offset: 0x00003BC7
		private static Delegate GetInitCancellabilityHandler()
		{
			if (ICancellableContinuationInvoker.cb_initCancellability == null)
			{
				ICancellableContinuationInvoker.cb_initCancellability = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICancellableContinuationInvoker.n_InitCancellability));
			}
			return ICancellableContinuationInvoker.cb_initCancellability;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000059EB File Offset: 0x00003BEB
		private static void n_InitCancellability(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitCancellability();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000059FA File Offset: 0x00003BFA
		public void InitCancellability()
		{
			if (this.id_initCancellability == IntPtr.Zero)
			{
				this.id_initCancellability = JNIEnv.GetMethodID(this.class_ref, "initCancellability", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_initCancellability);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005A3A File Offset: 0x00003C3A
		private static Delegate GetInvokeOnCancellation_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ICancellableContinuationInvoker.cb_invokeOnCancellation_Lkotlin_jvm_functions_Function1_ == null)
			{
				ICancellableContinuationInvoker.cb_invokeOnCancellation_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICancellableContinuationInvoker.n_InvokeOnCancellation_Lkotlin_jvm_functions_Function1_));
			}
			return ICancellableContinuationInvoker.cb_invokeOnCancellation_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005A60 File Offset: 0x00003C60
		private static void n_InvokeOnCancellation_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			@object.InvokeOnCancellation(object2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe void InvokeOnCancellation(IFunction1 handler)
		{
			if (this.id_invokeOnCancellation_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invokeOnCancellation_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnCancellation", "(Lkotlin/jvm/functions/Function1;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invokeOnCancellation_Lkotlin_jvm_functions_Function1_, ptr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00005AFC File Offset: 0x00003CFC
		private static Delegate GetResume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ICancellableContinuationInvoker.cb_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ == null)
			{
				ICancellableContinuationInvoker.cb_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ICancellableContinuationInvoker.n_Resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_));
			}
			return ICancellableContinuationInvoker.cb_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005B20 File Offset: 0x00003D20
		private static void n_Resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_onCancellation)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IFunction1 object3 = Java.Lang.Object.GetObject<IFunction1>(native_onCancellation, JniHandleOwnership.DoNotTransfer);
			@object.Resume(object2, object3);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00005B4C File Offset: 0x00003D4C
		[NullableContext(2)]
		public unsafe void Resume(Java.Lang.Object value, IFunction1 onCancellation)
		{
			if (this.id_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "resume", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((onCancellation == null) ? IntPtr.Zero : ((Java.Lang.Object)onCancellation).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005BE4 File Offset: 0x00003DE4
		private static Delegate GetResumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_Handler()
		{
			if (ICancellableContinuationInvoker.cb_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_ == null)
			{
				ICancellableContinuationInvoker.cb_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ICancellableContinuationInvoker.n_ResumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_));
			}
			return ICancellableContinuationInvoker.cb_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005C08 File Offset: 0x00003E08
		private static void n_ResumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_value)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoroutineDispatcher object2 = Java.Lang.Object.GetObject<CoroutineDispatcher>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.ResumeUndispatched(object2, object3);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005C34 File Offset: 0x00003E34
		public unsafe void ResumeUndispatched(CoroutineDispatcher p0, [Nullable(2)] Java.Lang.Object value)
		{
			if (this.id_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "resumeUndispatched", "(Lkotlinx/coroutines/CoroutineDispatcher;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005CC7 File Offset: 0x00003EC7
		private static Delegate GetResumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_Handler()
		{
			if (ICancellableContinuationInvoker.cb_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_ == null)
			{
				ICancellableContinuationInvoker.cb_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ICancellableContinuationInvoker.n_ResumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_));
			}
			return ICancellableContinuationInvoker.cb_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005CEC File Offset: 0x00003EEC
		private static void n_ResumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_exception)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoroutineDispatcher object2 = Java.Lang.Object.GetObject<CoroutineDispatcher>(native_p0, JniHandleOwnership.DoNotTransfer);
			Throwable object3 = Java.Lang.Object.GetObject<Throwable>(native_exception, JniHandleOwnership.DoNotTransfer);
			@object.ResumeUndispatchedWithException(object2, object3);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005D18 File Offset: 0x00003F18
		public unsafe void ResumeUndispatchedWithException(CoroutineDispatcher p0, Throwable exception)
		{
			if (this.id_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "resumeUndispatchedWithException", "(Lkotlinx/coroutines/CoroutineDispatcher;Ljava/lang/Throwable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((exception == null) ? IntPtr.Zero : exception.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005DAD File Offset: 0x00003FAD
		private static Delegate GetTryResume_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (ICancellableContinuationInvoker.cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				ICancellableContinuationInvoker.cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICancellableContinuationInvoker.n_TryResume_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return ICancellableContinuationInvoker.cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005DD4 File Offset: 0x00003FD4
		private static IntPtr n_TryResume_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_idempotent)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_idempotent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TryResume(object2, object3));
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005E08 File Offset: 0x00004008
		[NullableContext(2)]
		public unsafe Java.Lang.Object TryResume(Java.Lang.Object value, Java.Lang.Object idempotent)
		{
			if (this.id_tryResume_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_tryResume_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "tryResume", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((idempotent == null) ? IntPtr.Zero : idempotent.Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_tryResume_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00005EA1 File Offset: 0x000040A1
		private static Delegate GetTryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ICancellableContinuationInvoker.cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ == null)
			{
				ICancellableContinuationInvoker.cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICancellableContinuationInvoker.n_TryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_));
			}
			return ICancellableContinuationInvoker.cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005EC8 File Offset: 0x000040C8
		private static IntPtr n_TryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_idempotent, IntPtr native_onCancellation)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_idempotent, JniHandleOwnership.DoNotTransfer);
			IFunction1 object4 = Java.Lang.Object.GetObject<IFunction1>(native_onCancellation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TryResume(object2, object3, object4));
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005F04 File Offset: 0x00004104
		[NullableContext(2)]
		public unsafe Java.Lang.Object TryResume(Java.Lang.Object value, Java.Lang.Object idempotent, IFunction1 onCancellation)
		{
			if (this.id_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "tryResume", "(Ljava/lang/Object;Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((idempotent == null) ? IntPtr.Zero : idempotent.Handle);
			ptr[2] = new JValue((onCancellation == null) ? IntPtr.Zero : ((Java.Lang.Object)onCancellation).Handle);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005FC7 File Offset: 0x000041C7
		private static Delegate GetTryResumeWithException_Ljava_lang_Throwable_Handler()
		{
			if (ICancellableContinuationInvoker.cb_tryResumeWithException_Ljava_lang_Throwable_ == null)
			{
				ICancellableContinuationInvoker.cb_tryResumeWithException_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICancellableContinuationInvoker.n_TryResumeWithException_Ljava_lang_Throwable_));
			}
			return ICancellableContinuationInvoker.cb_tryResumeWithException_Ljava_lang_Throwable_;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005FEC File Offset: 0x000041EC
		private static IntPtr n_TryResumeWithException_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			ICancellableContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_exception, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TryResumeWithException(object2));
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006014 File Offset: 0x00004214
		[return: Nullable(2)]
		public unsafe Java.Lang.Object TryResumeWithException(Throwable exception)
		{
			if (this.id_tryResumeWithException_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_tryResumeWithException_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "tryResumeWithException", "(Ljava/lang/Throwable;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((exception == null) ? IntPtr.Zero : exception.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_tryResumeWithException_Ljava_lang_Throwable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000608D File Offset: 0x0000428D
		private static Delegate GetGetContextHandler()
		{
			if (ICancellableContinuationInvoker.cb_getContext == null)
			{
				ICancellableContinuationInvoker.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICancellableContinuationInvoker.n_GetContext));
			}
			return ICancellableContinuationInvoker.cb_getContext;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000060B1 File Offset: 0x000042B1
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000060C8 File Offset: 0x000042C8
		public ICoroutineContext Context
		{
			get
			{
				if (this.id_getContext == IntPtr.Zero)
				{
					this.id_getContext = JNIEnv.GetMethodID(this.class_ref, "getContext", "()Lkotlin/coroutines/CoroutineContext;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_getContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006119 File Offset: 0x00004319
		private static Delegate GetResumeWith_Ljava_lang_Object_Handler()
		{
			if (ICancellableContinuationInvoker.cb_resumeWith_Ljava_lang_Object_ == null)
			{
				ICancellableContinuationInvoker.cb_resumeWith_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICancellableContinuationInvoker.n_ResumeWith_Ljava_lang_Object_));
			}
			return ICancellableContinuationInvoker.cb_resumeWith_Ljava_lang_Object_;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006140 File Offset: 0x00004340
		private static void n_ResumeWith_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			IContinuation @object = Java.Lang.Object.GetObject<ICancellableContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			@object.ResumeWith(object2);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006164 File Offset: 0x00004364
		public unsafe void ResumeWith(Java.Lang.Object result)
		{
			if (this.id_resumeWith_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_resumeWith_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "resumeWith", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((result == null) ? IntPtr.Zero : result.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_resumeWith_Ljava_lang_Object_, ptr);
		}

		// Token: 0x04000032 RID: 50
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CancellableContinuation", typeof(ICancellableContinuationInvoker));

		// Token: 0x04000033 RID: 51
		private IntPtr class_ref;

		// Token: 0x04000034 RID: 52
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x04000035 RID: 53
		private IntPtr id_isActive;

		// Token: 0x04000036 RID: 54
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x04000037 RID: 55
		private IntPtr id_isCancelled;

		// Token: 0x04000038 RID: 56
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x04000039 RID: 57
		private IntPtr id_isCompleted;

		// Token: 0x0400003A RID: 58
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_lang_Throwable_;

		// Token: 0x0400003B RID: 59
		private IntPtr id_cancel_Ljava_lang_Throwable_;

		// Token: 0x0400003C RID: 60
		[Nullable(2)]
		private static Delegate cb_completeResume_Ljava_lang_Object_;

		// Token: 0x0400003D RID: 61
		private IntPtr id_completeResume_Ljava_lang_Object_;

		// Token: 0x0400003E RID: 62
		[Nullable(2)]
		private static Delegate cb_initCancellability;

		// Token: 0x0400003F RID: 63
		private IntPtr id_initCancellability;

		// Token: 0x04000040 RID: 64
		[Nullable(2)]
		private static Delegate cb_invokeOnCancellation_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000041 RID: 65
		private IntPtr id_invokeOnCancellation_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000042 RID: 66
		[Nullable(2)]
		private static Delegate cb_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000043 RID: 67
		private IntPtr id_resume_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000044 RID: 68
		[Nullable(2)]
		private static Delegate cb_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_;

		// Token: 0x04000045 RID: 69
		private IntPtr id_resumeUndispatched_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Object_;

		// Token: 0x04000046 RID: 70
		[Nullable(2)]
		private static Delegate cb_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_;

		// Token: 0x04000047 RID: 71
		private IntPtr id_resumeUndispatchedWithException_Lkotlinx_coroutines_CoroutineDispatcher_Ljava_lang_Throwable_;

		// Token: 0x04000048 RID: 72
		[Nullable(2)]
		private static Delegate cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000049 RID: 73
		private IntPtr id_tryResume_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400004A RID: 74
		[Nullable(2)]
		private static Delegate cb_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_;

		// Token: 0x0400004B RID: 75
		private IntPtr id_tryResume_Ljava_lang_Object_Ljava_lang_Object_Lkotlin_jvm_functions_Function1_;

		// Token: 0x0400004C RID: 76
		[Nullable(2)]
		private static Delegate cb_tryResumeWithException_Ljava_lang_Throwable_;

		// Token: 0x0400004D RID: 77
		private IntPtr id_tryResumeWithException_Ljava_lang_Throwable_;

		// Token: 0x0400004E RID: 78
		[Nullable(2)]
		private static Delegate cb_getContext;

		// Token: 0x0400004F RID: 79
		private IntPtr id_getContext;

		// Token: 0x04000050 RID: 80
		[Nullable(2)]
		private static Delegate cb_resumeWith_Ljava_lang_Object_;

		// Token: 0x04000051 RID: 81
		private IntPtr id_resumeWith_Ljava_lang_Object_;
	}
}
