using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util.Concurrent
{
	// Token: 0x0200034A RID: 842
	[Register("java/util/concurrent/CompletionStage", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class ICompletionStageInvoker : Java.Lang.Object, ICompletionStage, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000677E8 File Offset: 0x000659E8
		private static IntPtr java_class_ref
		{
			get
			{
				return ICompletionStageInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x0006780C File Offset: 0x00065A0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICompletionStageInvoker._members;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x00067813 File Offset: 0x00065A13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x0006781B File Offset: 0x00065A1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICompletionStageInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00067827 File Offset: 0x00065A27
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICompletionStageInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.CompletionStage'.");
			}
			return handle;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00067852 File Offset: 0x00065A52
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00067884 File Offset: 0x00065A84
		public ICompletionStageInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICompletionStageInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000678BC File Offset: 0x00065ABC
		private static Delegate GetAcceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Handler()
		{
			if (ICompletionStageInvoker.cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ == null)
			{
				ICompletionStageInvoker.cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_AcceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_));
			}
			return ICompletionStageInvoker.cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000678E0 File Offset: 0x00065AE0
		private static IntPtr n_AcceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AcceptEither(object2, object3));
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00067914 File Offset: 0x00065B14
		public unsafe ICompletionStage AcceptEither(ICompletionStage other, IConsumer action)
		{
			if (this.id_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ == IntPtr.Zero)
			{
				this.id_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "acceptEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000679B9 File Offset: 0x00065BB9
		private static Delegate GetAcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Handler()
		{
			if (ICompletionStageInvoker.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ == null)
			{
				ICompletionStageInvoker.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_));
			}
			return ICompletionStageInvoker.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000679E0 File Offset: 0x00065BE0
		private static IntPtr n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AcceptEitherAsync(object2, object3));
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00067A14 File Offset: 0x00065C14
		public unsafe ICompletionStage AcceptEitherAsync(ICompletionStage other, IConsumer action)
		{
			if (this.id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ == IntPtr.Zero)
			{
				this.id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00067AB9 File Offset: 0x00065CB9
		private static Delegate GetAcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICompletionStageInvoker.n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00067AE0 File Offset: 0x00065CE0
		private static IntPtr n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AcceptEitherAsync(object2, object3, object4));
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00067B1C File Offset: 0x00065D1C
		public unsafe ICompletionStage AcceptEitherAsync(ICompletionStage other, IConsumer action, IExecutor executor)
		{
			if (this.id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "acceptEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[2] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00067BEB File Offset: 0x00065DEB
		private static Delegate GetApplyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ApplyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00067C10 File Offset: 0x00065E10
		private static IntPtr n_ApplyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyToEither(object2, object3));
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00067C44 File Offset: 0x00065E44
		public unsafe ICompletionStage ApplyToEither(ICompletionStage other, IFunction fn)
		{
			if (this.id_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "applyToEither", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00067CE9 File Offset: 0x00065EE9
		private static Delegate GetApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00067D10 File Offset: 0x00065F10
		private static IntPtr n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyToEitherAsync(object2, object3));
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00067D44 File Offset: 0x00065F44
		public unsafe ICompletionStage ApplyToEitherAsync(ICompletionStage other, IFunction fn)
		{
			if (this.id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00067DE9 File Offset: 0x00065FE9
		private static Delegate GetApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICompletionStageInvoker.n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00067E10 File Offset: 0x00066010
		private static IntPtr n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyToEitherAsync(object2, object3, object4));
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00067E4C File Offset: 0x0006604C
		public unsafe ICompletionStage ApplyToEitherAsync(ICompletionStage other, IFunction fn, IExecutor executor)
		{
			if (this.id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "applyToEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			ptr[2] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00067F1B File Offset: 0x0006611B
		private static Delegate GetExceptionally_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_exceptionally_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_exceptionally_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_Exceptionally_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_exceptionally_Ljava_util_function_Function_;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00067F40 File Offset: 0x00066140
		private static IntPtr n_Exceptionally_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Exceptionally(object2));
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00067F68 File Offset: 0x00066168
		public unsafe ICompletionStage Exceptionally(IFunction fn)
		{
			if (this.id_exceptionally_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_exceptionally_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "exceptionally", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_exceptionally_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00067FE6 File Offset: 0x000661E6
		private static Delegate GetHandle_Ljava_util_function_BiFunction_Handler()
		{
			if (ICompletionStageInvoker.cb_handle_Ljava_util_function_BiFunction_ == null)
			{
				ICompletionStageInvoker.cb_handle_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_Handle_Ljava_util_function_BiFunction_));
			}
			return ICompletionStageInvoker.cb_handle_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0006800C File Offset: 0x0006620C
		private static IntPtr n_Handle_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Handle(object2));
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00068034 File Offset: 0x00066234
		public new unsafe ICompletionStage Handle(IBiFunction fn)
		{
			if (this.id_handle_Ljava_util_function_BiFunction_ == IntPtr.Zero)
			{
				this.id_handle_Ljava_util_function_BiFunction_ = JNIEnv.GetMethodID(this.class_ref, "handle", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_handle_Ljava_util_function_BiFunction_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000680B2 File Offset: 0x000662B2
		private static Delegate GetHandleAsync_Ljava_util_function_BiFunction_Handler()
		{
			if (ICompletionStageInvoker.cb_handleAsync_Ljava_util_function_BiFunction_ == null)
			{
				ICompletionStageInvoker.cb_handleAsync_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_HandleAsync_Ljava_util_function_BiFunction_));
			}
			return ICompletionStageInvoker.cb_handleAsync_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000680D8 File Offset: 0x000662D8
		private static IntPtr n_HandleAsync_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HandleAsync(object2));
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00068100 File Offset: 0x00066300
		public unsafe ICompletionStage HandleAsync(IBiFunction fn)
		{
			if (this.id_handleAsync_Ljava_util_function_BiFunction_ == IntPtr.Zero)
			{
				this.id_handleAsync_Ljava_util_function_BiFunction_ = JNIEnv.GetMethodID(this.class_ref, "handleAsync", "(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_handleAsync_Ljava_util_function_BiFunction_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0006817E File Offset: 0x0006637E
		private static Delegate GetHandleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_HandleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000681A4 File Offset: 0x000663A4
		private static IntPtr n_HandleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HandleAsync(object2, object3));
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000681D8 File Offset: 0x000663D8
		public unsafe ICompletionStage HandleAsync(IBiFunction fn, IExecutor executor)
		{
			if (this.id_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "handleAsync", "(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			ptr[1] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0006827D File Offset: 0x0006647D
		private static Delegate GetRunAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (ICompletionStageInvoker.cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				ICompletionStageInvoker.cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_RunAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return ICompletionStageInvoker.cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000682A4 File Offset: 0x000664A4
		private static IntPtr n_RunAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterBoth(object2, object3));
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000682D8 File Offset: 0x000664D8
		public unsafe ICompletionStage RunAfterBoth(ICompletionStage other, IRunnable action)
		{
			if (this.id_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "runAfterBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0006837D File Offset: 0x0006657D
		private static Delegate GetRunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (ICompletionStageInvoker.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				ICompletionStageInvoker.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return ICompletionStageInvoker.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000683A4 File Offset: 0x000665A4
		private static IntPtr n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterBothAsync(object2, object3));
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000683D8 File Offset: 0x000665D8
		public unsafe ICompletionStage RunAfterBothAsync(ICompletionStage other, IRunnable action)
		{
			if (this.id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0006847D File Offset: 0x0006667D
		private static Delegate GetRunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICompletionStageInvoker.n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000684A4 File Offset: 0x000666A4
		private static IntPtr n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterBothAsync(object2, object3, object4));
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000684E0 File Offset: 0x000666E0
		public unsafe ICompletionStage RunAfterBothAsync(ICompletionStage other, IRunnable action, IExecutor executor)
		{
			if (this.id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "runAfterBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[2] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000685AF File Offset: 0x000667AF
		private static Delegate GetRunAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (ICompletionStageInvoker.cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				ICompletionStageInvoker.cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_RunAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return ICompletionStageInvoker.cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000685D4 File Offset: 0x000667D4
		private static IntPtr n_RunAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterEither(object2, object3));
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00068608 File Offset: 0x00066808
		public unsafe ICompletionStage RunAfterEither(ICompletionStage other, IRunnable action)
		{
			if (this.id_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "runAfterEither", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000686AD File Offset: 0x000668AD
		private static Delegate GetRunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (ICompletionStageInvoker.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				ICompletionStageInvoker.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return ICompletionStageInvoker.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000686D4 File Offset: 0x000668D4
		private static IntPtr n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterEitherAsync(object2, object3));
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00068708 File Offset: 0x00066908
		public unsafe ICompletionStage RunAfterEitherAsync(ICompletionStage other, IRunnable action)
		{
			if (this.id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000687AD File Offset: 0x000669AD
		private static Delegate GetRunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICompletionStageInvoker.n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000687D4 File Offset: 0x000669D4
		private static IntPtr n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterEitherAsync(object2, object3, object4));
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00068810 File Offset: 0x00066A10
		public unsafe ICompletionStage RunAfterEitherAsync(ICompletionStage other, IRunnable action, IExecutor executor)
		{
			if (this.id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "runAfterEitherAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[2] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000688DF File Offset: 0x00066ADF
		private static Delegate GetThenAccept_Ljava_util_function_Consumer_Handler()
		{
			if (ICompletionStageInvoker.cb_thenAccept_Ljava_util_function_Consumer_ == null)
			{
				ICompletionStageInvoker.cb_thenAccept_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenAccept_Ljava_util_function_Consumer_));
			}
			return ICompletionStageInvoker.cb_thenAccept_Ljava_util_function_Consumer_;
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00068904 File Offset: 0x00066B04
		private static IntPtr n_ThenAccept_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAccept(object2));
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x0006892C File Offset: 0x00066B2C
		public unsafe ICompletionStage ThenAccept(IConsumer action)
		{
			if (this.id_thenAccept_Ljava_util_function_Consumer_ == IntPtr.Zero)
			{
				this.id_thenAccept_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "thenAccept", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenAccept_Ljava_util_function_Consumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000689AA File Offset: 0x00066BAA
		private static Delegate GetThenAcceptAsync_Ljava_util_function_Consumer_Handler()
		{
			if (ICompletionStageInvoker.cb_thenAcceptAsync_Ljava_util_function_Consumer_ == null)
			{
				ICompletionStageInvoker.cb_thenAcceptAsync_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenAcceptAsync_Ljava_util_function_Consumer_));
			}
			return ICompletionStageInvoker.cb_thenAcceptAsync_Ljava_util_function_Consumer_;
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000689D0 File Offset: 0x00066BD0
		private static IntPtr n_ThenAcceptAsync_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptAsync(object2));
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000689F8 File Offset: 0x00066BF8
		public unsafe ICompletionStage ThenAcceptAsync(IConsumer action)
		{
			if (this.id_thenAcceptAsync_Ljava_util_function_Consumer_ == IntPtr.Zero)
			{
				this.id_thenAcceptAsync_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "thenAcceptAsync", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenAcceptAsync_Ljava_util_function_Consumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00068A76 File Offset: 0x00066C76
		private static Delegate GetThenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00068A9C File Offset: 0x00066C9C
		private static IntPtr n_ThenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptAsync(object2, object3));
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00068AD0 File Offset: 0x00066CD0
		public unsafe ICompletionStage ThenAcceptAsync(IConsumer action, IExecutor executor)
		{
			if (this.id_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "thenAcceptAsync", "(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[1] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00068B75 File Offset: 0x00066D75
		private static Delegate GetThenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Handler()
		{
			if (ICompletionStageInvoker.cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ == null)
			{
				ICompletionStageInvoker.cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_));
			}
			return ICompletionStageInvoker.cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00068B9C File Offset: 0x00066D9C
		private static IntPtr n_ThenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object3 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptBoth(object2, object3));
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00068BD0 File Offset: 0x00066DD0
		public unsafe ICompletionStage ThenAcceptBoth(ICompletionStage other, IBiConsumer action)
		{
			if (this.id_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ == IntPtr.Zero)
			{
				this.id_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ = JNIEnv.GetMethodID(this.class_ref, "thenAcceptBoth", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00068C75 File Offset: 0x00066E75
		private static Delegate GetThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Handler()
		{
			if (ICompletionStageInvoker.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ == null)
			{
				ICompletionStageInvoker.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_));
			}
			return ICompletionStageInvoker.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00068C9C File Offset: 0x00066E9C
		private static IntPtr n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object3 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptBothAsync(object2, object3));
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00068CD0 File Offset: 0x00066ED0
		public unsafe ICompletionStage ThenAcceptBothAsync(ICompletionStage other, IBiConsumer action)
		{
			if (this.id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ == IntPtr.Zero)
			{
				this.id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ = JNIEnv.GetMethodID(this.class_ref, "thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00068D75 File Offset: 0x00066F75
		private static Delegate GetThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICompletionStageInvoker.n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00068D9C File Offset: 0x00066F9C
		private static IntPtr n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object3 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptBothAsync(object2, object3, object4));
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00068DD8 File Offset: 0x00066FD8
		public unsafe ICompletionStage ThenAcceptBothAsync(ICompletionStage other, IBiConsumer action, IExecutor executor)
		{
			if (this.id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "thenAcceptBothAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[2] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00068EA7 File Offset: 0x000670A7
		private static Delegate GetThenApply_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_thenApply_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_thenApply_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenApply_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_thenApply_Ljava_util_function_Function_;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00068ECC File Offset: 0x000670CC
		private static IntPtr n_ThenApply_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenApply(object2));
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00068EF4 File Offset: 0x000670F4
		public unsafe ICompletionStage ThenApply(IFunction fn)
		{
			if (this.id_thenApply_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_thenApply_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "thenApply", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenApply_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00068F72 File Offset: 0x00067172
		private static Delegate GetThenApplyAsync_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_thenApplyAsync_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_thenApplyAsync_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenApplyAsync_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_thenApplyAsync_Ljava_util_function_Function_;
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00068F98 File Offset: 0x00067198
		private static IntPtr n_ThenApplyAsync_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenApplyAsync(object2));
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00068FC0 File Offset: 0x000671C0
		public unsafe ICompletionStage ThenApplyAsync(IFunction fn)
		{
			if (this.id_thenApplyAsync_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_thenApplyAsync_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "thenApplyAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenApplyAsync_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x0006903E File Offset: 0x0006723E
		private static Delegate GetThenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00069064 File Offset: 0x00067264
		private static IntPtr n_ThenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenApplyAsync(object2, object3));
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00069098 File Offset: 0x00067298
		public unsafe ICompletionStage ThenApplyAsync(IFunction fn, IExecutor executor)
		{
			if (this.id_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "thenApplyAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			ptr[1] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0006913D File Offset: 0x0006733D
		private static Delegate GetThenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Handler()
		{
			if (ICompletionStageInvoker.cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ == null)
			{
				ICompletionStageInvoker.cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_));
			}
			return ICompletionStageInvoker.cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00069164 File Offset: 0x00067364
		private static IntPtr n_ThenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCombine(object2, object3));
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00069198 File Offset: 0x00067398
		public unsafe ICompletionStage ThenCombine(ICompletionStage other, IBiFunction fn)
		{
			if (this.id_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ == IntPtr.Zero)
			{
				this.id_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ = JNIEnv.GetMethodID(this.class_ref, "thenCombine", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0006923D File Offset: 0x0006743D
		private static Delegate GetThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Handler()
		{
			if (ICompletionStageInvoker.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ == null)
			{
				ICompletionStageInvoker.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_));
			}
			return ICompletionStageInvoker.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00069264 File Offset: 0x00067464
		private static IntPtr n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCombineAsync(object2, object3));
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00069298 File Offset: 0x00067498
		public unsafe ICompletionStage ThenCombineAsync(ICompletionStage other, IBiFunction fn)
		{
			if (this.id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ == IntPtr.Zero)
			{
				this.id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ = JNIEnv.GetMethodID(this.class_ref, "thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0006933D File Offset: 0x0006753D
		private static Delegate GetThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ICompletionStageInvoker.n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00069364 File Offset: 0x00067564
		private static IntPtr n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCombineAsync(object2, object3, object4));
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000693A0 File Offset: 0x000675A0
		public unsafe ICompletionStage ThenCombineAsync(ICompletionStage other, IBiFunction fn, IExecutor executor)
		{
			if (this.id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "thenCombineAsync", "(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			ptr[1] = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			ptr[2] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0006946F File Offset: 0x0006766F
		private static Delegate GetThenCompose_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_thenCompose_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_thenCompose_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenCompose_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_thenCompose_Ljava_util_function_Function_;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00069494 File Offset: 0x00067694
		private static IntPtr n_ThenCompose_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCompose(object2));
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000694BC File Offset: 0x000676BC
		public unsafe ICompletionStage ThenCompose(IFunction fn)
		{
			if (this.id_thenCompose_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_thenCompose_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "thenCompose", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenCompose_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0006953A File Offset: 0x0006773A
		private static Delegate GetThenComposeAsync_Ljava_util_function_Function_Handler()
		{
			if (ICompletionStageInvoker.cb_thenComposeAsync_Ljava_util_function_Function_ == null)
			{
				ICompletionStageInvoker.cb_thenComposeAsync_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenComposeAsync_Ljava_util_function_Function_));
			}
			return ICompletionStageInvoker.cb_thenComposeAsync_Ljava_util_function_Function_;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00069560 File Offset: 0x00067760
		private static IntPtr n_ThenComposeAsync_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComposeAsync(object2));
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00069588 File Offset: 0x00067788
		public unsafe ICompletionStage ThenComposeAsync(IFunction fn)
		{
			if (this.id_thenComposeAsync_Ljava_util_function_Function_ == IntPtr.Zero)
			{
				this.id_thenComposeAsync_Ljava_util_function_Function_ = JNIEnv.GetMethodID(this.class_ref, "thenComposeAsync", "(Ljava/util/function/Function;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenComposeAsync_Ljava_util_function_Function_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00069606 File Offset: 0x00067806
		private static Delegate GetThenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0006962C File Offset: 0x0006782C
		private static IntPtr n_ThenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComposeAsync(object2, object3));
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00069660 File Offset: 0x00067860
		public unsafe ICompletionStage ThenComposeAsync(IFunction fn, IExecutor executor)
		{
			if (this.id_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "thenComposeAsync", "(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
			ptr[1] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00069705 File Offset: 0x00067905
		private static Delegate GetThenRun_Ljava_lang_Runnable_Handler()
		{
			if (ICompletionStageInvoker.cb_thenRun_Ljava_lang_Runnable_ == null)
			{
				ICompletionStageInvoker.cb_thenRun_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenRun_Ljava_lang_Runnable_));
			}
			return ICompletionStageInvoker.cb_thenRun_Ljava_lang_Runnable_;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0006972C File Offset: 0x0006792C
		private static IntPtr n_ThenRun_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenRun(object2));
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00069754 File Offset: 0x00067954
		public unsafe ICompletionStage ThenRun(IRunnable action)
		{
			if (this.id_thenRun_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_thenRun_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "thenRun", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenRun_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x000697D2 File Offset: 0x000679D2
		private static Delegate GetThenRunAsync_Ljava_lang_Runnable_Handler()
		{
			if (ICompletionStageInvoker.cb_thenRunAsync_Ljava_lang_Runnable_ == null)
			{
				ICompletionStageInvoker.cb_thenRunAsync_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_ThenRunAsync_Ljava_lang_Runnable_));
			}
			return ICompletionStageInvoker.cb_thenRunAsync_Ljava_lang_Runnable_;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x000697F8 File Offset: 0x000679F8
		private static IntPtr n_ThenRunAsync_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenRunAsync(object2));
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00069820 File Offset: 0x00067A20
		public unsafe ICompletionStage ThenRunAsync(IRunnable action)
		{
			if (this.id_thenRunAsync_Ljava_lang_Runnable_ == IntPtr.Zero)
			{
				this.id_thenRunAsync_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "thenRunAsync", "(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenRunAsync_Ljava_lang_Runnable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0006989E File Offset: 0x00067A9E
		private static Delegate GetThenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_ThenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000698C4 File Offset: 0x00067AC4
		private static IntPtr n_ThenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenRunAsync(object2, object3));
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000698F8 File Offset: 0x00067AF8
		public unsafe ICompletionStage ThenRunAsync(IRunnable action, IExecutor executor)
		{
			if (this.id_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "thenRunAsync", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[1] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0006999D File Offset: 0x00067B9D
		private static Delegate GetToCompletableFutureHandler()
		{
			if (ICompletionStageInvoker.cb_toCompletableFuture == null)
			{
				ICompletionStageInvoker.cb_toCompletableFuture = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletionStageInvoker.n_ToCompletableFuture));
			}
			return ICompletionStageInvoker.cb_toCompletableFuture;
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000699C1 File Offset: 0x00067BC1
		private static IntPtr n_ToCompletableFuture(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToCompletableFuture());
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000699D8 File Offset: 0x00067BD8
		public CompletableFuture ToCompletableFuture()
		{
			if (this.id_toCompletableFuture == IntPtr.Zero)
			{
				this.id_toCompletableFuture = JNIEnv.GetMethodID(this.class_ref, "toCompletableFuture", "()Ljava/util/concurrent/CompletableFuture;");
			}
			return Java.Lang.Object.GetObject<CompletableFuture>(JNIEnv.CallObjectMethod(base.Handle, this.id_toCompletableFuture), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00069A29 File Offset: 0x00067C29
		private static Delegate GetWhenComplete_Ljava_util_function_BiConsumer_Handler()
		{
			if (ICompletionStageInvoker.cb_whenComplete_Ljava_util_function_BiConsumer_ == null)
			{
				ICompletionStageInvoker.cb_whenComplete_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_WhenComplete_Ljava_util_function_BiConsumer_));
			}
			return ICompletionStageInvoker.cb_whenComplete_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00069A50 File Offset: 0x00067C50
		private static IntPtr n_WhenComplete_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WhenComplete(object2));
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00069A78 File Offset: 0x00067C78
		public unsafe ICompletionStage WhenComplete(IBiConsumer action)
		{
			if (this.id_whenComplete_Ljava_util_function_BiConsumer_ == IntPtr.Zero)
			{
				this.id_whenComplete_Ljava_util_function_BiConsumer_ = JNIEnv.GetMethodID(this.class_ref, "whenComplete", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_whenComplete_Ljava_util_function_BiConsumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00069AF6 File Offset: 0x00067CF6
		private static Delegate GetWhenCompleteAsync_Ljava_util_function_BiConsumer_Handler()
		{
			if (ICompletionStageInvoker.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_ == null)
			{
				ICompletionStageInvoker.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletionStageInvoker.n_WhenCompleteAsync_Ljava_util_function_BiConsumer_));
			}
			return ICompletionStageInvoker.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00069B1C File Offset: 0x00067D1C
		private static IntPtr n_WhenCompleteAsync_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WhenCompleteAsync(object2));
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00069B44 File Offset: 0x00067D44
		public unsafe ICompletionStage WhenCompleteAsync(IBiConsumer action)
		{
			if (this.id_whenCompleteAsync_Ljava_util_function_BiConsumer_ == IntPtr.Zero)
			{
				this.id_whenCompleteAsync_Ljava_util_function_BiConsumer_ = JNIEnv.GetMethodID(this.class_ref, "whenCompleteAsync", "(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_whenCompleteAsync_Ljava_util_function_BiConsumer_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00069BC2 File Offset: 0x00067DC2
		private static Delegate GetWhenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (ICompletionStageInvoker.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ == null)
			{
				ICompletionStageInvoker.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletionStageInvoker.n_WhenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_));
			}
			return ICompletionStageInvoker.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00069BE8 File Offset: 0x00067DE8
		private static IntPtr n_WhenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_executor)
		{
			ICompletionStage @object = Java.Lang.Object.GetObject<ICompletionStage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WhenCompleteAsync(object2, object3));
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00069C1C File Offset: 0x00067E1C
		public unsafe ICompletionStage WhenCompleteAsync(IBiConsumer action, IExecutor executor)
		{
			if (this.id_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "whenCompleteAsync", "(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletionStage;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
			ptr[1] = new JValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
			return Java.Lang.Object.GetObject<ICompletionStage>(JNIEnv.CallObjectMethod(base.Handle, this.id_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000EF4 RID: 3828
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/CompletionStage", typeof(ICompletionStageInvoker));

		// Token: 0x04000EF5 RID: 3829
		private IntPtr class_ref;

		// Token: 0x04000EF6 RID: 3830
		private static Delegate cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;

		// Token: 0x04000EF7 RID: 3831
		private IntPtr id_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;

		// Token: 0x04000EF8 RID: 3832
		private static Delegate cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;

		// Token: 0x04000EF9 RID: 3833
		private IntPtr id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;

		// Token: 0x04000EFA RID: 3834
		private static Delegate cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EFB RID: 3835
		private IntPtr id_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EFC RID: 3836
		private static Delegate cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;

		// Token: 0x04000EFD RID: 3837
		private IntPtr id_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;

		// Token: 0x04000EFE RID: 3838
		private static Delegate cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;

		// Token: 0x04000EFF RID: 3839
		private IntPtr id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;

		// Token: 0x04000F00 RID: 3840
		private static Delegate cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F01 RID: 3841
		private IntPtr id_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F02 RID: 3842
		private static Delegate cb_exceptionally_Ljava_util_function_Function_;

		// Token: 0x04000F03 RID: 3843
		private IntPtr id_exceptionally_Ljava_util_function_Function_;

		// Token: 0x04000F04 RID: 3844
		private static Delegate cb_handle_Ljava_util_function_BiFunction_;

		// Token: 0x04000F05 RID: 3845
		private IntPtr id_handle_Ljava_util_function_BiFunction_;

		// Token: 0x04000F06 RID: 3846
		private static Delegate cb_handleAsync_Ljava_util_function_BiFunction_;

		// Token: 0x04000F07 RID: 3847
		private IntPtr id_handleAsync_Ljava_util_function_BiFunction_;

		// Token: 0x04000F08 RID: 3848
		private static Delegate cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F09 RID: 3849
		private IntPtr id_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F0A RID: 3850
		private static Delegate cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F0B RID: 3851
		private IntPtr id_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F0C RID: 3852
		private static Delegate cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F0D RID: 3853
		private IntPtr id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F0E RID: 3854
		private static Delegate cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F0F RID: 3855
		private IntPtr id_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F10 RID: 3856
		private static Delegate cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F11 RID: 3857
		private IntPtr id_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F12 RID: 3858
		private static Delegate cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F13 RID: 3859
		private IntPtr id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000F14 RID: 3860
		private static Delegate cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F15 RID: 3861
		private IntPtr id_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F16 RID: 3862
		private static Delegate cb_thenAccept_Ljava_util_function_Consumer_;

		// Token: 0x04000F17 RID: 3863
		private IntPtr id_thenAccept_Ljava_util_function_Consumer_;

		// Token: 0x04000F18 RID: 3864
		private static Delegate cb_thenAcceptAsync_Ljava_util_function_Consumer_;

		// Token: 0x04000F19 RID: 3865
		private IntPtr id_thenAcceptAsync_Ljava_util_function_Consumer_;

		// Token: 0x04000F1A RID: 3866
		private static Delegate cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F1B RID: 3867
		private IntPtr id_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F1C RID: 3868
		private static Delegate cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F1D RID: 3869
		private IntPtr id_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F1E RID: 3870
		private static Delegate cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F1F RID: 3871
		private IntPtr id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F20 RID: 3872
		private static Delegate cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F21 RID: 3873
		private IntPtr id_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F22 RID: 3874
		private static Delegate cb_thenApply_Ljava_util_function_Function_;

		// Token: 0x04000F23 RID: 3875
		private IntPtr id_thenApply_Ljava_util_function_Function_;

		// Token: 0x04000F24 RID: 3876
		private static Delegate cb_thenApplyAsync_Ljava_util_function_Function_;

		// Token: 0x04000F25 RID: 3877
		private IntPtr id_thenApplyAsync_Ljava_util_function_Function_;

		// Token: 0x04000F26 RID: 3878
		private static Delegate cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F27 RID: 3879
		private IntPtr id_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F28 RID: 3880
		private static Delegate cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;

		// Token: 0x04000F29 RID: 3881
		private IntPtr id_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;

		// Token: 0x04000F2A RID: 3882
		private static Delegate cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;

		// Token: 0x04000F2B RID: 3883
		private IntPtr id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;

		// Token: 0x04000F2C RID: 3884
		private static Delegate cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F2D RID: 3885
		private IntPtr id_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F2E RID: 3886
		private static Delegate cb_thenCompose_Ljava_util_function_Function_;

		// Token: 0x04000F2F RID: 3887
		private IntPtr id_thenCompose_Ljava_util_function_Function_;

		// Token: 0x04000F30 RID: 3888
		private static Delegate cb_thenComposeAsync_Ljava_util_function_Function_;

		// Token: 0x04000F31 RID: 3889
		private IntPtr id_thenComposeAsync_Ljava_util_function_Function_;

		// Token: 0x04000F32 RID: 3890
		private static Delegate cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F33 RID: 3891
		private IntPtr id_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F34 RID: 3892
		private static Delegate cb_thenRun_Ljava_lang_Runnable_;

		// Token: 0x04000F35 RID: 3893
		private IntPtr id_thenRun_Ljava_lang_Runnable_;

		// Token: 0x04000F36 RID: 3894
		private static Delegate cb_thenRunAsync_Ljava_lang_Runnable_;

		// Token: 0x04000F37 RID: 3895
		private IntPtr id_thenRunAsync_Ljava_lang_Runnable_;

		// Token: 0x04000F38 RID: 3896
		private static Delegate cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F39 RID: 3897
		private IntPtr id_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F3A RID: 3898
		private static Delegate cb_toCompletableFuture;

		// Token: 0x04000F3B RID: 3899
		private IntPtr id_toCompletableFuture;

		// Token: 0x04000F3C RID: 3900
		private static Delegate cb_whenComplete_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F3D RID: 3901
		private IntPtr id_whenComplete_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F3E RID: 3902
		private static Delegate cb_whenCompleteAsync_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F3F RID: 3903
		private IntPtr id_whenCompleteAsync_Ljava_util_function_BiConsumer_;

		// Token: 0x04000F40 RID: 3904
		private static Delegate cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000F41 RID: 3905
		private IntPtr id_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;
	}
}
