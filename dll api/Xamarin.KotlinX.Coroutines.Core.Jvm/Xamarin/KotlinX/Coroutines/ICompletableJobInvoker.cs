using System;
using System.ComponentModel;
using System.Diagnostics;
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
	// Token: 0x02000049 RID: 73
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletableJob", DoNotGenerateAcw = true)]
	internal class ICompletableJobInvoker : Java.Lang.Object, ICompletableJob, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00009100 File Offset: 0x00007300
		private static IntPtr java_class_ref
		{
			get
			{
				return ICompletableJobInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00009124 File Offset: 0x00007324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICompletableJobInvoker._members;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000912B File Offset: 0x0000732B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00009133 File Offset: 0x00007333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICompletableJobInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000913F File Offset: 0x0000733F
		[NullableContext(2)]
		public static ICompletableJob GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICompletableJob>(handle, transfer);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00009148 File Offset: 0x00007348
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICompletableJobInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CompletableJob'.");
			}
			return handle;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00009173 File Offset: 0x00007373
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000091A4 File Offset: 0x000073A4
		public ICompletableJobInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICompletableJobInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000091DC File Offset: 0x000073DC
		private static Delegate GetCompleteHandler()
		{
			if (ICompletableJobInvoker.cb_complete == null)
			{
				ICompletableJobInvoker.cb_complete = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableJobInvoker.n_Complete));
			}
			return ICompletableJobInvoker.cb_complete;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00009200 File Offset: 0x00007400
		private static bool n_Complete(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Complete();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000920F File Offset: 0x0000740F
		public bool Complete()
		{
			if (this.id_complete == IntPtr.Zero)
			{
				this.id_complete = JNIEnv.GetMethodID(this.class_ref, "complete", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_complete);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000924F File Offset: 0x0000744F
		private static Delegate GetCompleteExceptionally_Ljava_lang_Throwable_Handler()
		{
			if (ICompletableJobInvoker.cb_completeExceptionally_Ljava_lang_Throwable_ == null)
			{
				ICompletableJobInvoker.cb_completeExceptionally_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICompletableJobInvoker.n_CompleteExceptionally_Ljava_lang_Throwable_));
			}
			return ICompletableJobInvoker.cb_completeExceptionally_Ljava_lang_Throwable_;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00009274 File Offset: 0x00007474
		private static bool n_CompleteExceptionally_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			ICompletableJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_exception, JniHandleOwnership.DoNotTransfer);
			return @object.CompleteExceptionally(object2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00009298 File Offset: 0x00007498
		public unsafe bool CompleteExceptionally(Throwable exception)
		{
			if (this.id_completeExceptionally_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_completeExceptionally_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "completeExceptionally", "(Ljava/lang/Throwable;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((exception == null) ? IntPtr.Zero : exception.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_completeExceptionally_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000930B File Offset: 0x0000750B
		private static Delegate GetGetCancellationExceptionHandler()
		{
			if (ICompletableJobInvoker.cb_getCancellationException == null)
			{
				ICompletableJobInvoker.cb_getCancellationException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableJobInvoker.n_GetCancellationException));
			}
			return ICompletableJobInvoker.cb_getCancellationException;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000932F File Offset: 0x0000752F
		private static IntPtr n_GetCancellationException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationException);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00009344 File Offset: 0x00007544
		public CancellationException CancellationException
		{
			get
			{
				if (this.id_getCancellationException == IntPtr.Zero)
				{
					this.id_getCancellationException = JNIEnv.GetMethodID(this.class_ref, "getCancellationException", "()Ljava/util/concurrent/CancellationException;");
				}
				return Java.Lang.Object.GetObject<CancellationException>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCancellationException), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00009395 File Offset: 0x00007595
		private static Delegate GetGetChildrenHandler()
		{
			if (ICompletableJobInvoker.cb_getChildren == null)
			{
				ICompletableJobInvoker.cb_getChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableJobInvoker.n_GetChildren));
			}
			return ICompletableJobInvoker.cb_getChildren;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000093B9 File Offset: 0x000075B9
		private static IntPtr n_GetChildren(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Children);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000093D0 File Offset: 0x000075D0
		public ISequence Children
		{
			get
			{
				if (this.id_getChildren == IntPtr.Zero)
				{
					this.id_getChildren = JNIEnv.GetMethodID(this.class_ref, "getChildren", "()Lkotlin/sequences/Sequence;");
				}
				return Java.Lang.Object.GetObject<ISequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getChildren), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00009421 File Offset: 0x00007621
		private static Delegate GetIsActiveHandler()
		{
			if (ICompletableJobInvoker.cb_isActive == null)
			{
				ICompletableJobInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableJobInvoker.n_IsActive));
			}
			return ICompletableJobInvoker.cb_isActive;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00009445 File Offset: 0x00007645
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00009454 File Offset: 0x00007654
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

		// Token: 0x060002A3 RID: 675 RVA: 0x00009494 File Offset: 0x00007694
		private static Delegate GetIsCancelledHandler()
		{
			if (ICompletableJobInvoker.cb_isCancelled == null)
			{
				ICompletableJobInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableJobInvoker.n_IsCancelled));
			}
			return ICompletableJobInvoker.cb_isCancelled;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000094B8 File Offset: 0x000076B8
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000094C7 File Offset: 0x000076C7
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

		// Token: 0x060002A6 RID: 678 RVA: 0x00009507 File Offset: 0x00007707
		private static Delegate GetIsCompletedHandler()
		{
			if (ICompletableJobInvoker.cb_isCompleted == null)
			{
				ICompletableJobInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableJobInvoker.n_IsCompleted));
			}
			return ICompletableJobInvoker.cb_isCompleted;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000952B File Offset: 0x0000772B
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000953A File Offset: 0x0000773A
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

		// Token: 0x060002A9 RID: 681 RVA: 0x0000957A File Offset: 0x0000777A
		private static Delegate GetGetOnJoinHandler()
		{
			if (ICompletableJobInvoker.cb_getOnJoin == null)
			{
				ICompletableJobInvoker.cb_getOnJoin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableJobInvoker.n_GetOnJoin));
			}
			return ICompletableJobInvoker.cb_getOnJoin;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000959E File Offset: 0x0000779E
		private static IntPtr n_GetOnJoin(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnJoin);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000095B4 File Offset: 0x000077B4
		public ISelectClause0 OnJoin
		{
			get
			{
				if (this.id_getOnJoin == IntPtr.Zero)
				{
					this.id_getOnJoin = JNIEnv.GetMethodID(this.class_ref, "getOnJoin", "()Lkotlinx/coroutines/selects/SelectClause0;");
				}
				return Java.Lang.Object.GetObject<ISelectClause0>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnJoin), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00009605 File Offset: 0x00007805
		private static Delegate GetGetParentHandler()
		{
			if (ICompletableJobInvoker.cb_getParent == null)
			{
				ICompletableJobInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableJobInvoker.n_GetParent));
			}
			return ICompletableJobInvoker.cb_getParent;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00009629 File Offset: 0x00007829
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00009640 File Offset: 0x00007840
		[Nullable(2)]
		public IJob Parent
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getParent == IntPtr.Zero)
				{
					this.id_getParent = JNIEnv.GetMethodID(this.class_ref, "getParent", "()Lkotlinx/coroutines/Job;");
				}
				return Java.Lang.Object.GetObject<IJob>(JNIEnv.CallObjectMethod(base.Handle, this.id_getParent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009691 File Offset: 0x00007891
		private static Delegate GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler()
		{
			if (ICompletableJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ == null)
			{
				ICompletableJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_AttachChild_Lkotlinx_coroutines_ChildJob_));
			}
			return ICompletableJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000096B8 File Offset: 0x000078B8
		private static IntPtr n_AttachChild_Lkotlinx_coroutines_ChildJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IChildJob object2 = Java.Lang.Object.GetObject<IChildJob>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachChild(object2));
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000096E0 File Offset: 0x000078E0
		public unsafe IChildHandle AttachChild(IChildJob child)
		{
			if (this.id_attachChild_Lkotlinx_coroutines_ChildJob_ == IntPtr.Zero)
			{
				this.id_attachChild_Lkotlinx_coroutines_ChildJob_ = JNIEnv.GetMethodID(this.class_ref, "attachChild", "(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : ((Java.Lang.Object)child).Handle);
			return Java.Lang.Object.GetObject<IChildHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_attachChild_Lkotlinx_coroutines_ChildJob_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000975E File Offset: 0x0000795E
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (ICompletableJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				ICompletableJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ICompletableJobInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return ICompletableJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00009784 File Offset: 0x00007984
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000097A8 File Offset: 0x000079A8
		[NullableContext(2)]
		public unsafe void Cancel(CancellationException cause)
		{
			if (this.id_cancel_Ljava_util_concurrent_CancellationException_ == IntPtr.Zero)
			{
				this.id_cancel_Ljava_util_concurrent_CancellationException_ = JNIEnv.GetMethodID(this.class_ref, "cancel", "(Ljava/util/concurrent/CancellationException;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cause == null) ? IntPtr.Zero : cause.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_cancel_Ljava_util_concurrent_CancellationException_, ptr);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000981B File Offset: 0x00007A1B
		private static Delegate GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler()
		{
			if (ICompletableJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == null)
			{
				ICompletableJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZL_L(ICompletableJobInvoker.n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_));
			}
			return ICompletableJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00009840 File Offset: 0x00007A40
		private static IntPtr n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, bool onCancelling, bool invokeImmediately, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(onCancelling, invokeImmediately, object2));
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000986C File Offset: 0x00007A6C
		public unsafe IDisposableHandle InvokeOnCompletion(bool onCancelling, bool invokeImmediately, IFunction1 handler)
		{
			if (this.id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnCompletion", "(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(onCancelling);
			ptr[1] = new JValue(invokeImmediately);
			ptr[2] = new JValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
			return Java.Lang.Object.GetObject<IDisposableHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00009913 File Offset: 0x00007B13
		private static Delegate GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ICompletableJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == null)
			{
				ICompletableJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_));
			}
			return ICompletableJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00009938 File Offset: 0x00007B38
		private static IntPtr n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(object2));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009960 File Offset: 0x00007B60
		public unsafe IDisposableHandle InvokeOnCompletion(IFunction1 handler)
		{
			if (this.id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invokeOnCompletion", "(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
			return Java.Lang.Object.GetObject<IDisposableHandle>(JNIEnv.CallObjectMethod(base.Handle, this.id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000099DE File Offset: 0x00007BDE
		private static Delegate GetJoin_Lkotlin_coroutines_Continuation_Handler()
		{
			if (ICompletableJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ == null)
			{
				ICompletableJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_Join_Lkotlin_coroutines_Continuation_));
			}
			return ICompletableJobInvoker.cb_join_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00009A04 File Offset: 0x00007C04
		private static IntPtr n_Join_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Join(object2));
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00009A2C File Offset: 0x00007C2C
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Join(IContinuation p0)
		{
			if (this.id_join_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_join_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "join", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_join_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00009AAA File Offset: 0x00007CAA
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (ICompletableJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				ICompletableJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return ICompletableJobInvoker.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009AD0 File Offset: 0x00007CD0
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IJob @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00009AF8 File Offset: 0x00007CF8
		public unsafe IJob Plus(IJob other)
		{
			if (this.id_plus_Lkotlinx_coroutines_Job_ == IntPtr.Zero)
			{
				this.id_plus_Lkotlinx_coroutines_Job_ = JNIEnv.GetMethodID(this.class_ref, "plus", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return Java.Lang.Object.GetObject<IJob>(JNIEnv.CallObjectMethod(base.Handle, this.id_plus_Lkotlinx_coroutines_Job_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009B76 File Offset: 0x00007D76
		private static Delegate GetStartHandler()
		{
			if (ICompletableJobInvoker.cb_start == null)
			{
				ICompletableJobInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICompletableJobInvoker.n_Start));
			}
			return ICompletableJobInvoker.cb_start;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009B9A File Offset: 0x00007D9A
		private static bool n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00009BA9 File Offset: 0x00007DA9
		public bool Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_start);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009BE9 File Offset: 0x00007DE9
		private static Delegate GetGetKeyHandler()
		{
			if (ICompletableJobInvoker.cb_getKey == null)
			{
				ICompletableJobInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICompletableJobInvoker.n_GetKey));
			}
			return ICompletableJobInvoker.cb_getKey;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009C0D File Offset: 0x00007E0D
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00009C24 File Offset: 0x00007E24
		public ICoroutineContextKey Key
		{
			get
			{
				if (this.id_getKey == IntPtr.Zero)
				{
					this.id_getKey = JNIEnv.GetMethodID(this.class_ref, "getKey", "()Lkotlin/coroutines/CoroutineContext$Key;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContextKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_getKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009C75 File Offset: 0x00007E75
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ICompletableJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				ICompletableJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ICompletableJobInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return ICompletableJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009C9C File Offset: 0x00007E9C
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00009CD0 File Offset: 0x00007ED0
		[NullableContext(2)]
		public unsafe Java.Lang.Object Fold(Java.Lang.Object initial, [Nullable(1)] IFunction2 operation)
		{
			if (this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "fold", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((initial == null) ? IntPtr.Zero : initial.Handle);
			ptr[1] = new JValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009D70 File Offset: 0x00007F70
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICompletableJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICompletableJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICompletableJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00009D94 File Offset: 0x00007F94
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00009DBC File Offset: 0x00007FBC
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Get(ICoroutineContextKey key)
		{
			if (this.id_get_Lkotlin_coroutines_CoroutineContext_Key_ == IntPtr.Zero)
			{
				this.id_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Lkotlin_coroutines_CoroutineContext_Key_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00009E3A File Offset: 0x0000803A
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (ICompletableJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				ICompletableJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return ICompletableJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00009E60 File Offset: 0x00008060
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009E88 File Offset: 0x00008088
		public unsafe ICoroutineContext MinusKey(ICoroutineContextKey key)
		{
			if (this.id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == IntPtr.Zero)
			{
				this.id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNIEnv.GetMethodID(this.class_ref, "minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
			return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00009F06 File Offset: 0x00008106
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (ICompletableJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				ICompletableJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICompletableJobInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return ICompletableJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00009F2C File Offset: 0x0000812C
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<ICompletableJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009F54 File Offset: 0x00008154
		public unsafe ICoroutineContext Plus(ICoroutineContext context)
		{
			if (this.id_plus_Lkotlin_coroutines_CoroutineContext_ == IntPtr.Zero)
			{
				this.id_plus_Lkotlin_coroutines_CoroutineContext_ = JNIEnv.GetMethodID(this.class_ref, "plus", "(Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
			return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_plus_Lkotlin_coroutines_CoroutineContext_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000BC RID: 188
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletableJob", typeof(ICompletableJobInvoker));

		// Token: 0x040000BD RID: 189
		private IntPtr class_ref;

		// Token: 0x040000BE RID: 190
		[Nullable(2)]
		private static Delegate cb_complete;

		// Token: 0x040000BF RID: 191
		private IntPtr id_complete;

		// Token: 0x040000C0 RID: 192
		[Nullable(2)]
		private static Delegate cb_completeExceptionally_Ljava_lang_Throwable_;

		// Token: 0x040000C1 RID: 193
		private IntPtr id_completeExceptionally_Ljava_lang_Throwable_;

		// Token: 0x040000C2 RID: 194
		[Nullable(2)]
		private static Delegate cb_getCancellationException;

		// Token: 0x040000C3 RID: 195
		private IntPtr id_getCancellationException;

		// Token: 0x040000C4 RID: 196
		[Nullable(2)]
		private static Delegate cb_getChildren;

		// Token: 0x040000C5 RID: 197
		private IntPtr id_getChildren;

		// Token: 0x040000C6 RID: 198
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x040000C7 RID: 199
		private IntPtr id_isActive;

		// Token: 0x040000C8 RID: 200
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x040000C9 RID: 201
		private IntPtr id_isCancelled;

		// Token: 0x040000CA RID: 202
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x040000CB RID: 203
		private IntPtr id_isCompleted;

		// Token: 0x040000CC RID: 204
		[Nullable(2)]
		private static Delegate cb_getOnJoin;

		// Token: 0x040000CD RID: 205
		private IntPtr id_getOnJoin;

		// Token: 0x040000CE RID: 206
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x040000CF RID: 207
		private IntPtr id_getParent;

		// Token: 0x040000D0 RID: 208
		[Nullable(2)]
		private static Delegate cb_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x040000D1 RID: 209
		private IntPtr id_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x040000D2 RID: 210
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040000D3 RID: 211
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040000D4 RID: 212
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x040000D5 RID: 213
		private IntPtr id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x040000D6 RID: 214
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040000D7 RID: 215
		private IntPtr id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040000D8 RID: 216
		[Nullable(2)]
		private static Delegate cb_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x040000D9 RID: 217
		private IntPtr id_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x040000DA RID: 218
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x040000DB RID: 219
		private IntPtr id_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x040000DC RID: 220
		[Nullable(2)]
		private static Delegate cb_start;

		// Token: 0x040000DD RID: 221
		private IntPtr id_start;

		// Token: 0x040000DE RID: 222
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x040000DF RID: 223
		private IntPtr id_getKey;

		// Token: 0x040000E0 RID: 224
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040000E1 RID: 225
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040000E2 RID: 226
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000E3 RID: 227
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000E4 RID: 228
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000E5 RID: 229
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040000E6 RID: 230
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040000E7 RID: 231
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
