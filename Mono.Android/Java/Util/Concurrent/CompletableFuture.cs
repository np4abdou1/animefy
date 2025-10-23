using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util.Concurrent
{
	// Token: 0x02000344 RID: 836
	[Register("java/util/concurrent/CompletableFuture", DoNotGenerateAcw = true, ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class CompletableFuture : Java.Lang.Object, ICompletionStage, IJavaObject, IDisposable, IJavaPeerable, IFuture
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x00064147 File Offset: 0x00062347
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletableFuture._members;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x00064150 File Offset: 0x00062350
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletableFuture._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x00064174 File Offset: 0x00062374
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletableFuture._members.ManagedPeerType;
			}
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x000021E0 File Offset: 0x000003E0
		protected CompletableFuture(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00064180 File Offset: 0x00062380
		private static Delegate GetIsCancelledHandler()
		{
			if (CompletableFuture.cb_isCancelled == null)
			{
				CompletableFuture.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CompletableFuture.n_IsCancelled));
			}
			return CompletableFuture.cb_isCancelled;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x000641A4 File Offset: 0x000623A4
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000641B3 File Offset: 0x000623B3
		public virtual bool IsCancelled
		{
			get
			{
				return CompletableFuture._members.InstanceMethods.InvokeVirtualBooleanMethod("isCancelled.()Z", this, null);
			}
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000641CC File Offset: 0x000623CC
		private static Delegate GetIsDoneHandler()
		{
			if (CompletableFuture.cb_isDone == null)
			{
				CompletableFuture.cb_isDone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CompletableFuture.n_IsDone));
			}
			return CompletableFuture.cb_isDone;
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x000641F0 File Offset: 0x000623F0
		private static bool n_IsDone(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDone;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000641FF File Offset: 0x000623FF
		public virtual bool IsDone
		{
			get
			{
				return CompletableFuture._members.InstanceMethods.InvokeVirtualBooleanMethod("isDone.()Z", this, null);
			}
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00064218 File Offset: 0x00062418
		private static Delegate GetAcceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Handler()
		{
			if (CompletableFuture.cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ == null)
			{
				CompletableFuture.cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_AcceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_));
			}
			return CompletableFuture.cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0006423C File Offset: 0x0006243C
		private static IntPtr n_AcceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AcceptEither(object2, object3));
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00064270 File Offset: 0x00062470
		public unsafe virtual ICompletionStage AcceptEither(ICompletionStage other, IConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("acceptEither.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00064318 File Offset: 0x00062518
		private static Delegate GetAcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Handler()
		{
			if (CompletableFuture.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ == null)
			{
				CompletableFuture.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_));
			}
			return CompletableFuture.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0006433C File Offset: 0x0006253C
		private static IntPtr n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AcceptEitherAsync(object2, object3));
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00064370 File Offset: 0x00062570
		public unsafe virtual ICompletionStage AcceptEitherAsync(ICompletionStage other, IConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("acceptEitherAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00064418 File Offset: 0x00062618
		private static Delegate GetAcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CompletableFuture.n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0006443C File Offset: 0x0006263C
		private static IntPtr n_AcceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AcceptEitherAsync(object2, object3, object4));
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00064478 File Offset: 0x00062678
		public unsafe virtual ICompletionStage AcceptEitherAsync(ICompletionStage other, IConsumer action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("acceptEitherAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00064550 File Offset: 0x00062750
		private static Delegate GetApplyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ApplyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00064574 File Offset: 0x00062774
		private static IntPtr n_ApplyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyToEither(object2, object3));
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000645A8 File Offset: 0x000627A8
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ApplyToEither(ICompletionStage other, IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("applyToEither.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00064650 File Offset: 0x00062850
		private static Delegate GetApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00064674 File Offset: 0x00062874
		private static IntPtr n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyToEitherAsync(object2, object3));
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000646A8 File Offset: 0x000628A8
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ApplyToEitherAsync(ICompletionStage other, IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("applyToEitherAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00064750 File Offset: 0x00062950
		private static Delegate GetApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CompletableFuture.n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00064774 File Offset: 0x00062974
		private static IntPtr n_ApplyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IFunction object3 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyToEitherAsync(object2, object3, object4));
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000647B0 File Offset: 0x000629B0
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ApplyToEitherAsync(ICompletionStage other, IFunction fn, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				ptr[2] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("applyToEitherAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(fn);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00064888 File Offset: 0x00062A88
		private static Delegate GetCancel_ZHandler()
		{
			if (CompletableFuture.cb_cancel_Z == null)
			{
				CompletableFuture.cb_cancel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(CompletableFuture.n_Cancel_Z));
			}
			return CompletableFuture.cb_cancel_Z;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000648AC File Offset: 0x00062AAC
		private static bool n_Cancel_Z(IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			return Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel(mayInterruptIfRunning);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000648BC File Offset: 0x00062ABC
		public unsafe virtual bool Cancel(bool mayInterruptIfRunning)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(mayInterruptIfRunning);
			return CompletableFuture._members.InstanceMethods.InvokeVirtualBooleanMethod("cancel.(Z)Z", this, ptr);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000648F7 File Offset: 0x00062AF7
		private static Delegate GetExceptionally_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_exceptionally_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_exceptionally_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_Exceptionally_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_exceptionally_Ljava_util_function_Function_;
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0006491C File Offset: 0x00062B1C
		private static IntPtr n_Exceptionally_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Exceptionally(object2));
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00064944 File Offset: 0x00062B44
		public unsafe virtual ICompletionStage Exceptionally(IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("exceptionally.(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000649BC File Offset: 0x00062BBC
		private static Delegate GetGetHandler()
		{
			if (CompletableFuture.cb_get == null)
			{
				CompletableFuture.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CompletableFuture.n_Get));
			}
			return CompletableFuture.cb_get;
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000649E0 File Offset: 0x00062BE0
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000649F4 File Offset: 0x00062BF4
		public virtual Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00064A26 File Offset: 0x00062C26
		private static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (CompletableFuture.cb_get_JLjava_util_concurrent_TimeUnit_ == null)
			{
				CompletableFuture.cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(CompletableFuture.n_Get_JLjava_util_concurrent_TimeUnit_));
			}
			return CompletableFuture.cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00064A4C File Offset: 0x00062C4C
		private static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(timeout, object2));
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00064A78 File Offset: 0x00062C78
		public unsafe virtual Java.Lang.Object Get(long timeout, TimeUnit unit)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeout);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("get.(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return @object;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00064B00 File Offset: 0x00062D00
		private static Delegate GetHandle_Ljava_util_function_BiFunction_Handler()
		{
			if (CompletableFuture.cb_handle_Ljava_util_function_BiFunction_ == null)
			{
				CompletableFuture.cb_handle_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_Handle_Ljava_util_function_BiFunction_));
			}
			return CompletableFuture.cb_handle_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00064B24 File Offset: 0x00062D24
		private static IntPtr n_Handle_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Handle(object2));
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00064B4C File Offset: 0x00062D4C
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public new unsafe virtual ICompletionStage Handle(IBiFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("handle.(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00064BC4 File Offset: 0x00062DC4
		private static Delegate GetHandleAsync_Ljava_util_function_BiFunction_Handler()
		{
			if (CompletableFuture.cb_handleAsync_Ljava_util_function_BiFunction_ == null)
			{
				CompletableFuture.cb_handleAsync_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_HandleAsync_Ljava_util_function_BiFunction_));
			}
			return CompletableFuture.cb_handleAsync_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00064BE8 File Offset: 0x00062DE8
		private static IntPtr n_HandleAsync_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HandleAsync(object2));
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00064C10 File Offset: 0x00062E10
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage HandleAsync(IBiFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("handleAsync.(Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00064C88 File Offset: 0x00062E88
		private static Delegate GetHandleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_HandleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00064CAC File Offset: 0x00062EAC
		private static IntPtr n_HandleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiFunction object2 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HandleAsync(object2, object3));
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00064CE0 File Offset: 0x00062EE0
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage HandleAsync(IBiFunction fn, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				ptr[1] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("handleAsync.(Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00064D88 File Offset: 0x00062F88
		private static Delegate GetRunAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (CompletableFuture.cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				CompletableFuture.cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_RunAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return CompletableFuture.cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00064DAC File Offset: 0x00062FAC
		private static IntPtr n_RunAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterBoth(object2, object3));
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00064DE0 File Offset: 0x00062FE0
		public unsafe virtual ICompletionStage RunAfterBoth(ICompletionStage other, IRunnable action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("runAfterBoth.(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00064E88 File Offset: 0x00063088
		private static Delegate GetRunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (CompletableFuture.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				CompletableFuture.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return CompletableFuture.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00064EAC File Offset: 0x000630AC
		private static IntPtr n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterBothAsync(object2, object3));
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00064EE0 File Offset: 0x000630E0
		public unsafe virtual ICompletionStage RunAfterBothAsync(ICompletionStage other, IRunnable action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("runAfterBothAsync.(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00064F88 File Offset: 0x00063188
		private static Delegate GetRunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CompletableFuture.n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00064FAC File Offset: 0x000631AC
		private static IntPtr n_RunAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterBothAsync(object2, object3, object4));
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00064FE8 File Offset: 0x000631E8
		public unsafe virtual ICompletionStage RunAfterBothAsync(ICompletionStage other, IRunnable action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("runAfterBothAsync.(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000650C0 File Offset: 0x000632C0
		private static Delegate GetRunAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (CompletableFuture.cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				CompletableFuture.cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_RunAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return CompletableFuture.cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000650E4 File Offset: 0x000632E4
		private static IntPtr n_RunAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterEither(object2, object3));
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00065118 File Offset: 0x00063318
		public unsafe virtual ICompletionStage RunAfterEither(ICompletionStage other, IRunnable action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("runAfterEither.(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x000651C0 File Offset: 0x000633C0
		private static Delegate GetRunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Handler()
		{
			if (CompletableFuture.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ == null)
			{
				CompletableFuture.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_));
			}
			return CompletableFuture.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x000651E4 File Offset: 0x000633E4
		private static IntPtr n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterEitherAsync(object2, object3));
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00065218 File Offset: 0x00063418
		public unsafe virtual ICompletionStage RunAfterEitherAsync(ICompletionStage other, IRunnable action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("runAfterEitherAsync.(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000652C0 File Offset: 0x000634C0
		private static Delegate GetRunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CompletableFuture.n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000652E4 File Offset: 0x000634E4
		private static IntPtr n_RunAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunAfterEitherAsync(object2, object3, object4));
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00065320 File Offset: 0x00063520
		public unsafe virtual ICompletionStage RunAfterEitherAsync(ICompletionStage other, IRunnable action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("runAfterEitherAsync.(Ljava/util/concurrent/CompletionStage;Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000653F8 File Offset: 0x000635F8
		private static Delegate GetThenAccept_Ljava_util_function_Consumer_Handler()
		{
			if (CompletableFuture.cb_thenAccept_Ljava_util_function_Consumer_ == null)
			{
				CompletableFuture.cb_thenAccept_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenAccept_Ljava_util_function_Consumer_));
			}
			return CompletableFuture.cb_thenAccept_Ljava_util_function_Consumer_;
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0006541C File Offset: 0x0006361C
		private static IntPtr n_ThenAccept_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAccept(object2));
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00065444 File Offset: 0x00063644
		public unsafe virtual ICompletionStage ThenAccept(IConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenAccept.(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000654BC File Offset: 0x000636BC
		private static Delegate GetThenAcceptAsync_Ljava_util_function_Consumer_Handler()
		{
			if (CompletableFuture.cb_thenAcceptAsync_Ljava_util_function_Consumer_ == null)
			{
				CompletableFuture.cb_thenAcceptAsync_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenAcceptAsync_Ljava_util_function_Consumer_));
			}
			return CompletableFuture.cb_thenAcceptAsync_Ljava_util_function_Consumer_;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000654E0 File Offset: 0x000636E0
		private static IntPtr n_ThenAcceptAsync_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptAsync(object2));
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00065508 File Offset: 0x00063708
		public unsafe virtual ICompletionStage ThenAcceptAsync(IConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenAcceptAsync.(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00065580 File Offset: 0x00063780
		private static Delegate GetThenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000655A4 File Offset: 0x000637A4
		private static IntPtr n_ThenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptAsync(object2, object3));
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000655D8 File Offset: 0x000637D8
		public unsafe virtual ICompletionStage ThenAcceptAsync(IConsumer action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[1] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenAcceptAsync.(Ljava/util/function/Consumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00065680 File Offset: 0x00063880
		private static Delegate GetThenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Handler()
		{
			if (CompletableFuture.cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ == null)
			{
				CompletableFuture.cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_));
			}
			return CompletableFuture.cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000656A4 File Offset: 0x000638A4
		private static IntPtr n_ThenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object3 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptBoth(object2, object3));
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000656D8 File Offset: 0x000638D8
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenAcceptBoth(ICompletionStage other, IBiConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenAcceptBoth.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00065780 File Offset: 0x00063980
		private static Delegate GetThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Handler()
		{
			if (CompletableFuture.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ == null)
			{
				CompletableFuture.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_));
			}
			return CompletableFuture.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000657A4 File Offset: 0x000639A4
		private static IntPtr n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object3 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptBothAsync(object2, object3));
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000657D8 File Offset: 0x000639D8
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenAcceptBothAsync(ICompletionStage other, IBiConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenAcceptBothAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00065880 File Offset: 0x00063A80
		private static Delegate GetThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CompletableFuture.n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000658A4 File Offset: 0x00063AA4
		private static IntPtr n_ThenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object3 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenAcceptBothAsync(object2, object3, object4));
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000658E0 File Offset: 0x00063AE0
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenAcceptBothAsync(ICompletionStage other, IBiConsumer action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenAcceptBothAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000659B8 File Offset: 0x00063BB8
		private static Delegate GetThenApply_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_thenApply_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_thenApply_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenApply_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_thenApply_Ljava_util_function_Function_;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000659DC File Offset: 0x00063BDC
		private static IntPtr n_ThenApply_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenApply(object2));
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00065A04 File Offset: 0x00063C04
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenApply(IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenApply.(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00065A7C File Offset: 0x00063C7C
		private static Delegate GetThenApplyAsync_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_thenApplyAsync_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_thenApplyAsync_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenApplyAsync_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_thenApplyAsync_Ljava_util_function_Function_;
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00065AA0 File Offset: 0x00063CA0
		private static IntPtr n_ThenApplyAsync_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenApplyAsync(object2));
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00065AC8 File Offset: 0x00063CC8
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenApplyAsync(IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenApplyAsync.(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00065B40 File Offset: 0x00063D40
		private static Delegate GetThenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00065B64 File Offset: 0x00063D64
		private static IntPtr n_ThenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenApplyAsync(object2, object3));
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00065B98 File Offset: 0x00063D98
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenApplyAsync(IFunction fn, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				ptr[1] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenApplyAsync.(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00065C40 File Offset: 0x00063E40
		private static Delegate GetThenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Handler()
		{
			if (CompletableFuture.cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ == null)
			{
				CompletableFuture.cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_));
			}
			return CompletableFuture.cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00065C64 File Offset: 0x00063E64
		private static IntPtr n_ThenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCombine(object2, object3));
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00065C98 File Offset: 0x00063E98
		[JavaTypeParameters(new string[]
		{
			"U",
			"V"
		})]
		public unsafe virtual ICompletionStage ThenCombine(ICompletionStage other, IBiFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenCombine.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00065D40 File Offset: 0x00063F40
		private static Delegate GetThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Handler()
		{
			if (CompletableFuture.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ == null)
			{
				CompletableFuture.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_));
			}
			return CompletableFuture.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00065D64 File Offset: 0x00063F64
		private static IntPtr n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCombineAsync(object2, object3));
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00065D98 File Offset: 0x00063F98
		[JavaTypeParameters(new string[]
		{
			"U",
			"V"
		})]
		public unsafe virtual ICompletionStage ThenCombineAsync(ICompletionStage other, IBiFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenCombineAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00065E40 File Offset: 0x00064040
		private static Delegate GetThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CompletableFuture.n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00065E64 File Offset: 0x00064064
		private static IntPtr n_ThenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_other, IntPtr native_fn, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICompletionStage object2 = Java.Lang.Object.GetObject<ICompletionStage>(native_other, JniHandleOwnership.DoNotTransfer);
			IBiFunction object3 = Java.Lang.Object.GetObject<IBiFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object4 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCombineAsync(object2, object3, object4));
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00065EA0 File Offset: 0x000640A0
		[JavaTypeParameters(new string[]
		{
			"U",
			"V"
		})]
		public unsafe virtual ICompletionStage ThenCombineAsync(ICompletionStage other, IBiFunction fn, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[1] = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				ptr[2] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenCombineAsync.(Ljava/util/concurrent/CompletionStage;Ljava/util/function/BiFunction;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
				GC.KeepAlive(fn);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00065F78 File Offset: 0x00064178
		private static Delegate GetThenCompose_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_thenCompose_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_thenCompose_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenCompose_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_thenCompose_Ljava_util_function_Function_;
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00065F9C File Offset: 0x0006419C
		private static IntPtr n_ThenCompose_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenCompose(object2));
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00065FC4 File Offset: 0x000641C4
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenCompose(IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenCompose.(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0006603C File Offset: 0x0006423C
		private static Delegate GetThenComposeAsync_Ljava_util_function_Function_Handler()
		{
			if (CompletableFuture.cb_thenComposeAsync_Ljava_util_function_Function_ == null)
			{
				CompletableFuture.cb_thenComposeAsync_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenComposeAsync_Ljava_util_function_Function_));
			}
			return CompletableFuture.cb_thenComposeAsync_Ljava_util_function_Function_;
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00066060 File Offset: 0x00064260
		private static IntPtr n_ThenComposeAsync_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComposeAsync(object2));
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00066088 File Offset: 0x00064288
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenComposeAsync(IFunction fn)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenComposeAsync.(Ljava/util/function/Function;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
			}
			return @object;
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00066100 File Offset: 0x00064300
		private static Delegate GetThenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00066124 File Offset: 0x00064324
		private static IntPtr n_ThenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_fn, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_fn, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenComposeAsync(object2, object3));
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00066158 File Offset: 0x00064358
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public unsafe virtual ICompletionStage ThenComposeAsync(IFunction fn, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fn == null) ? IntPtr.Zero : ((Java.Lang.Object)fn).Handle);
				ptr[1] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenComposeAsync.(Ljava/util/function/Function;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fn);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00066200 File Offset: 0x00064400
		private static Delegate GetThenRun_Ljava_lang_Runnable_Handler()
		{
			if (CompletableFuture.cb_thenRun_Ljava_lang_Runnable_ == null)
			{
				CompletableFuture.cb_thenRun_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenRun_Ljava_lang_Runnable_));
			}
			return CompletableFuture.cb_thenRun_Ljava_lang_Runnable_;
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00066224 File Offset: 0x00064424
		private static IntPtr n_ThenRun_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenRun(object2));
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0006624C File Offset: 0x0006444C
		public unsafe virtual ICompletionStage ThenRun(IRunnable action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenRun.(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000662C4 File Offset: 0x000644C4
		private static Delegate GetThenRunAsync_Ljava_lang_Runnable_Handler()
		{
			if (CompletableFuture.cb_thenRunAsync_Ljava_lang_Runnable_ == null)
			{
				CompletableFuture.cb_thenRunAsync_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_ThenRunAsync_Ljava_lang_Runnable_));
			}
			return CompletableFuture.cb_thenRunAsync_Ljava_lang_Runnable_;
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000662E8 File Offset: 0x000644E8
		private static IntPtr n_ThenRunAsync_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenRunAsync(object2));
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00066310 File Offset: 0x00064510
		public unsafe virtual ICompletionStage ThenRunAsync(IRunnable action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenRunAsync.(Ljava/lang/Runnable;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00066388 File Offset: 0x00064588
		private static Delegate GetThenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_ThenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000663AC File Offset: 0x000645AC
		private static IntPtr n_ThenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThenRunAsync(object2, object3));
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000663E0 File Offset: 0x000645E0
		public unsafe virtual ICompletionStage ThenRunAsync(IRunnable action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[1] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("thenRunAsync.(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00066488 File Offset: 0x00064688
		private static Delegate GetToCompletableFutureHandler()
		{
			if (CompletableFuture.cb_toCompletableFuture == null)
			{
				CompletableFuture.cb_toCompletableFuture = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CompletableFuture.n_ToCompletableFuture));
			}
			return CompletableFuture.cb_toCompletableFuture;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000664AC File Offset: 0x000646AC
		private static IntPtr n_ToCompletableFuture(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToCompletableFuture());
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000664C0 File Offset: 0x000646C0
		public virtual CompletableFuture ToCompletableFuture()
		{
			return Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("toCompletableFuture.()Ljava/util/concurrent/CompletableFuture;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x000664F2 File Offset: 0x000646F2
		private static Delegate GetWhenComplete_Ljava_util_function_BiConsumer_Handler()
		{
			if (CompletableFuture.cb_whenComplete_Ljava_util_function_BiConsumer_ == null)
			{
				CompletableFuture.cb_whenComplete_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_WhenComplete_Ljava_util_function_BiConsumer_));
			}
			return CompletableFuture.cb_whenComplete_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00066518 File Offset: 0x00064718
		private static IntPtr n_WhenComplete_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WhenComplete(object2));
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00066540 File Offset: 0x00064740
		public unsafe virtual ICompletionStage WhenComplete(IBiConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("whenComplete.(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000665B8 File Offset: 0x000647B8
		private static Delegate GetWhenCompleteAsync_Ljava_util_function_BiConsumer_Handler()
		{
			if (CompletableFuture.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_ == null)
			{
				CompletableFuture.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CompletableFuture.n_WhenCompleteAsync_Ljava_util_function_BiConsumer_));
			}
			return CompletableFuture.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x000665DC File Offset: 0x000647DC
		private static IntPtr n_WhenCompleteAsync_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WhenCompleteAsync(object2));
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00066604 File Offset: 0x00064804
		public unsafe virtual ICompletionStage WhenCompleteAsync(IBiConsumer action)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("whenCompleteAsync.(Ljava/util/function/BiConsumer;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0006667C File Offset: 0x0006487C
		private static Delegate GetWhenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_Handler()
		{
			if (CompletableFuture.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ == null)
			{
				CompletableFuture.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CompletableFuture.n_WhenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_));
			}
			return CompletableFuture.cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000666A0 File Offset: 0x000648A0
		private static IntPtr n_WhenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_executor)
		{
			CompletableFuture @object = Java.Lang.Object.GetObject<CompletableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WhenCompleteAsync(object2, object3));
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x000666D4 File Offset: 0x000648D4
		public unsafe virtual ICompletionStage WhenCompleteAsync(IBiConsumer action, IExecutor executor)
		{
			ICompletionStage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[1] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				@object = Java.Lang.Object.GetObject<CompletableFuture>(CompletableFuture._members.InstanceMethods.InvokeVirtualObjectMethod("whenCompleteAsync.(Ljava/util/function/BiConsumer;Ljava/util/concurrent/Executor;)Ljava/util/concurrent/CompletableFuture;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(action);
				GC.KeepAlive(executor);
			}
			return @object;
		}

		// Token: 0x04000E9C RID: 3740
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/CompletableFuture", typeof(CompletableFuture));

		// Token: 0x04000E9D RID: 3741
		private static Delegate cb_isCancelled;

		// Token: 0x04000E9E RID: 3742
		private static Delegate cb_isDone;

		// Token: 0x04000E9F RID: 3743
		private static Delegate cb_acceptEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;

		// Token: 0x04000EA0 RID: 3744
		private static Delegate cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_;

		// Token: 0x04000EA1 RID: 3745
		private static Delegate cb_acceptEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EA2 RID: 3746
		private static Delegate cb_applyToEither_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;

		// Token: 0x04000EA3 RID: 3747
		private static Delegate cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_;

		// Token: 0x04000EA4 RID: 3748
		private static Delegate cb_applyToEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EA5 RID: 3749
		private static Delegate cb_cancel_Z;

		// Token: 0x04000EA6 RID: 3750
		private static Delegate cb_exceptionally_Ljava_util_function_Function_;

		// Token: 0x04000EA7 RID: 3751
		private static Delegate cb_get;

		// Token: 0x04000EA8 RID: 3752
		private static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000EA9 RID: 3753
		private static Delegate cb_handle_Ljava_util_function_BiFunction_;

		// Token: 0x04000EAA RID: 3754
		private static Delegate cb_handleAsync_Ljava_util_function_BiFunction_;

		// Token: 0x04000EAB RID: 3755
		private static Delegate cb_handleAsync_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EAC RID: 3756
		private static Delegate cb_runAfterBoth_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000EAD RID: 3757
		private static Delegate cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000EAE RID: 3758
		private static Delegate cb_runAfterBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EAF RID: 3759
		private static Delegate cb_runAfterEither_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000EB0 RID: 3760
		private static Delegate cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_;

		// Token: 0x04000EB1 RID: 3761
		private static Delegate cb_runAfterEitherAsync_Ljava_util_concurrent_CompletionStage_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EB2 RID: 3762
		private static Delegate cb_thenAccept_Ljava_util_function_Consumer_;

		// Token: 0x04000EB3 RID: 3763
		private static Delegate cb_thenAcceptAsync_Ljava_util_function_Consumer_;

		// Token: 0x04000EB4 RID: 3764
		private static Delegate cb_thenAcceptAsync_Ljava_util_function_Consumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EB5 RID: 3765
		private static Delegate cb_thenAcceptBoth_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;

		// Token: 0x04000EB6 RID: 3766
		private static Delegate cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_;

		// Token: 0x04000EB7 RID: 3767
		private static Delegate cb_thenAcceptBothAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EB8 RID: 3768
		private static Delegate cb_thenApply_Ljava_util_function_Function_;

		// Token: 0x04000EB9 RID: 3769
		private static Delegate cb_thenApplyAsync_Ljava_util_function_Function_;

		// Token: 0x04000EBA RID: 3770
		private static Delegate cb_thenApplyAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EBB RID: 3771
		private static Delegate cb_thenCombine_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;

		// Token: 0x04000EBC RID: 3772
		private static Delegate cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_;

		// Token: 0x04000EBD RID: 3773
		private static Delegate cb_thenCombineAsync_Ljava_util_concurrent_CompletionStage_Ljava_util_function_BiFunction_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EBE RID: 3774
		private static Delegate cb_thenCompose_Ljava_util_function_Function_;

		// Token: 0x04000EBF RID: 3775
		private static Delegate cb_thenComposeAsync_Ljava_util_function_Function_;

		// Token: 0x04000EC0 RID: 3776
		private static Delegate cb_thenComposeAsync_Ljava_util_function_Function_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EC1 RID: 3777
		private static Delegate cb_thenRun_Ljava_lang_Runnable_;

		// Token: 0x04000EC2 RID: 3778
		private static Delegate cb_thenRunAsync_Ljava_lang_Runnable_;

		// Token: 0x04000EC3 RID: 3779
		private static Delegate cb_thenRunAsync_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000EC4 RID: 3780
		private static Delegate cb_toCompletableFuture;

		// Token: 0x04000EC5 RID: 3781
		private static Delegate cb_whenComplete_Ljava_util_function_BiConsumer_;

		// Token: 0x04000EC6 RID: 3782
		private static Delegate cb_whenCompleteAsync_Ljava_util_function_BiConsumer_;

		// Token: 0x04000EC7 RID: 3783
		private static Delegate cb_whenCompleteAsync_Ljava_util_function_BiConsumer_Ljava_util_concurrent_Executor_;
	}
}
