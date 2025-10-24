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
	// Token: 0x02000043 RID: 67
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ChildJob", DoNotGenerateAcw = true)]
	internal class IChildJobInvoker : Java.Lang.Object, IChildJob, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00006910 File Offset: 0x00004B10
		private static IntPtr java_class_ref
		{
			get
			{
				return IChildJobInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00006934 File Offset: 0x00004B34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IChildJobInvoker._members;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000693B File Offset: 0x00004B3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00006943 File Offset: 0x00004B43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IChildJobInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000694F File Offset: 0x00004B4F
		[NullableContext(2)]
		public static IChildJob GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IChildJob>(handle, transfer);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006958 File Offset: 0x00004B58
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IChildJobInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.ChildJob'.");
			}
			return handle;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006983 File Offset: 0x00004B83
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000069B4 File Offset: 0x00004BB4
		public IChildJobInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IChildJobInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000069EC File Offset: 0x00004BEC
		private static Delegate GetParentCancelled_Lkotlinx_coroutines_ParentJob_Handler()
		{
			if (IChildJobInvoker.cb_parentCancelled_Lkotlinx_coroutines_ParentJob_ == null)
			{
				IChildJobInvoker.cb_parentCancelled_Lkotlinx_coroutines_ParentJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IChildJobInvoker.n_ParentCancelled_Lkotlinx_coroutines_ParentJob_));
			}
			return IChildJobInvoker.cb_parentCancelled_Lkotlinx_coroutines_ParentJob_;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006A10 File Offset: 0x00004C10
		private static void n_ParentCancelled_Lkotlinx_coroutines_ParentJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_parentJob)
		{
			IChildJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParentJob object2 = Java.Lang.Object.GetObject<IParentJob>(native_parentJob, JniHandleOwnership.DoNotTransfer);
			@object.ParentCancelled(object2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00006A34 File Offset: 0x00004C34
		public unsafe void ParentCancelled(IParentJob parentJob)
		{
			if (this.id_parentCancelled_Lkotlinx_coroutines_ParentJob_ == IntPtr.Zero)
			{
				this.id_parentCancelled_Lkotlinx_coroutines_ParentJob_ = JNIEnv.GetMethodID(this.class_ref, "parentCancelled", "(Lkotlinx/coroutines/ParentJob;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((parentJob == null) ? IntPtr.Zero : ((Java.Lang.Object)parentJob).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_parentCancelled_Lkotlinx_coroutines_ParentJob_, ptr);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00006AAC File Offset: 0x00004CAC
		private static Delegate GetGetCancellationExceptionHandler()
		{
			if (IChildJobInvoker.cb_getCancellationException == null)
			{
				IChildJobInvoker.cb_getCancellationException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChildJobInvoker.n_GetCancellationException));
			}
			return IChildJobInvoker.cb_getCancellationException;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006AD0 File Offset: 0x00004CD0
		private static IntPtr n_GetCancellationException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationException);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00006AE4 File Offset: 0x00004CE4
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

		// Token: 0x060001E7 RID: 487 RVA: 0x00006B35 File Offset: 0x00004D35
		private static Delegate GetGetChildrenHandler()
		{
			if (IChildJobInvoker.cb_getChildren == null)
			{
				IChildJobInvoker.cb_getChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChildJobInvoker.n_GetChildren));
			}
			return IChildJobInvoker.cb_getChildren;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00006B59 File Offset: 0x00004D59
		private static IntPtr n_GetChildren(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Children);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00006B70 File Offset: 0x00004D70
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

		// Token: 0x060001EA RID: 490 RVA: 0x00006BC1 File Offset: 0x00004DC1
		private static Delegate GetIsActiveHandler()
		{
			if (IChildJobInvoker.cb_isActive == null)
			{
				IChildJobInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChildJobInvoker.n_IsActive));
			}
			return IChildJobInvoker.cb_isActive;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00006BE5 File Offset: 0x00004DE5
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00006BF4 File Offset: 0x00004DF4
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

		// Token: 0x060001ED RID: 493 RVA: 0x00006C34 File Offset: 0x00004E34
		private static Delegate GetIsCancelledHandler()
		{
			if (IChildJobInvoker.cb_isCancelled == null)
			{
				IChildJobInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChildJobInvoker.n_IsCancelled));
			}
			return IChildJobInvoker.cb_isCancelled;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00006C58 File Offset: 0x00004E58
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00006C67 File Offset: 0x00004E67
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

		// Token: 0x060001F0 RID: 496 RVA: 0x00006CA7 File Offset: 0x00004EA7
		private static Delegate GetIsCompletedHandler()
		{
			if (IChildJobInvoker.cb_isCompleted == null)
			{
				IChildJobInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChildJobInvoker.n_IsCompleted));
			}
			return IChildJobInvoker.cb_isCompleted;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00006CCB File Offset: 0x00004ECB
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006CDA File Offset: 0x00004EDA
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

		// Token: 0x060001F3 RID: 499 RVA: 0x00006D1A File Offset: 0x00004F1A
		private static Delegate GetGetOnJoinHandler()
		{
			if (IChildJobInvoker.cb_getOnJoin == null)
			{
				IChildJobInvoker.cb_getOnJoin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChildJobInvoker.n_GetOnJoin));
			}
			return IChildJobInvoker.cb_getOnJoin;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00006D3E File Offset: 0x00004F3E
		private static IntPtr n_GetOnJoin(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnJoin);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00006D54 File Offset: 0x00004F54
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

		// Token: 0x060001F6 RID: 502 RVA: 0x00006DA5 File Offset: 0x00004FA5
		private static Delegate GetGetParentHandler()
		{
			if (IChildJobInvoker.cb_getParent == null)
			{
				IChildJobInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChildJobInvoker.n_GetParent));
			}
			return IChildJobInvoker.cb_getParent;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00006DC9 File Offset: 0x00004FC9
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00006DE0 File Offset: 0x00004FE0
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

		// Token: 0x060001F9 RID: 505 RVA: 0x00006E31 File Offset: 0x00005031
		private static Delegate GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler()
		{
			if (IChildJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ == null)
			{
				IChildJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_AttachChild_Lkotlinx_coroutines_ChildJob_));
			}
			return IChildJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00006E58 File Offset: 0x00005058
		private static IntPtr n_AttachChild_Lkotlinx_coroutines_ChildJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IChildJob object2 = Java.Lang.Object.GetObject<IChildJob>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachChild(object2));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00006E80 File Offset: 0x00005080
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

		// Token: 0x060001FC RID: 508 RVA: 0x00006EFE File Offset: 0x000050FE
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IChildJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IChildJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IChildJobInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IChildJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006F24 File Offset: 0x00005124
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00006F48 File Offset: 0x00005148
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

		// Token: 0x060001FF RID: 511 RVA: 0x00006FBB File Offset: 0x000051BB
		private static Delegate GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler()
		{
			if (IChildJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == null)
			{
				IChildJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZL_L(IChildJobInvoker.n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_));
			}
			return IChildJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00006FE0 File Offset: 0x000051E0
		private static IntPtr n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, bool onCancelling, bool invokeImmediately, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(onCancelling, invokeImmediately, object2));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000700C File Offset: 0x0000520C
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

		// Token: 0x06000202 RID: 514 RVA: 0x000070B3 File Offset: 0x000052B3
		private static Delegate GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IChildJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == null)
			{
				IChildJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_));
			}
			return IChildJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000070D8 File Offset: 0x000052D8
		private static IntPtr n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(object2));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007100 File Offset: 0x00005300
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

		// Token: 0x06000205 RID: 517 RVA: 0x0000717E File Offset: 0x0000537E
		private static Delegate GetJoin_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IChildJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ == null)
			{
				IChildJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_Join_Lkotlin_coroutines_Continuation_));
			}
			return IChildJobInvoker.cb_join_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000071A4 File Offset: 0x000053A4
		private static IntPtr n_Join_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Join(object2));
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000071CC File Offset: 0x000053CC
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

		// Token: 0x06000208 RID: 520 RVA: 0x0000724A File Offset: 0x0000544A
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (IChildJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				IChildJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return IChildJobInvoker.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007270 File Offset: 0x00005470
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IJob @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007298 File Offset: 0x00005498
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

		// Token: 0x0600020B RID: 523 RVA: 0x00007316 File Offset: 0x00005516
		private static Delegate GetStartHandler()
		{
			if (IChildJobInvoker.cb_start == null)
			{
				IChildJobInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IChildJobInvoker.n_Start));
			}
			return IChildJobInvoker.cb_start;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000733A File Offset: 0x0000553A
		private static bool n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007349 File Offset: 0x00005549
		public bool Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007389 File Offset: 0x00005589
		private static Delegate GetGetKeyHandler()
		{
			if (IChildJobInvoker.cb_getKey == null)
			{
				IChildJobInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChildJobInvoker.n_GetKey));
			}
			return IChildJobInvoker.cb_getKey;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000073AD File Offset: 0x000055AD
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000073C4 File Offset: 0x000055C4
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

		// Token: 0x06000211 RID: 529 RVA: 0x00007415 File Offset: 0x00005615
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IChildJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				IChildJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IChildJobInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return IChildJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000743C File Offset: 0x0000563C
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007470 File Offset: 0x00005670
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

		// Token: 0x06000214 RID: 532 RVA: 0x00007510 File Offset: 0x00005710
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IChildJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IChildJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IChildJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00007534 File Offset: 0x00005734
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000755C File Offset: 0x0000575C
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

		// Token: 0x06000217 RID: 535 RVA: 0x000075DA File Offset: 0x000057DA
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IChildJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IChildJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IChildJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00007600 File Offset: 0x00005800
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00007628 File Offset: 0x00005828
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

		// Token: 0x0600021A RID: 538 RVA: 0x000076A6 File Offset: 0x000058A6
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IChildJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IChildJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IChildJobInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return IChildJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000076CC File Offset: 0x000058CC
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<IChildJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000076F4 File Offset: 0x000058F4
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

		// Token: 0x0400005C RID: 92
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ChildJob", typeof(IChildJobInvoker));

		// Token: 0x0400005D RID: 93
		private IntPtr class_ref;

		// Token: 0x0400005E RID: 94
		[Nullable(2)]
		private static Delegate cb_parentCancelled_Lkotlinx_coroutines_ParentJob_;

		// Token: 0x0400005F RID: 95
		private IntPtr id_parentCancelled_Lkotlinx_coroutines_ParentJob_;

		// Token: 0x04000060 RID: 96
		[Nullable(2)]
		private static Delegate cb_getCancellationException;

		// Token: 0x04000061 RID: 97
		private IntPtr id_getCancellationException;

		// Token: 0x04000062 RID: 98
		[Nullable(2)]
		private static Delegate cb_getChildren;

		// Token: 0x04000063 RID: 99
		private IntPtr id_getChildren;

		// Token: 0x04000064 RID: 100
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x04000065 RID: 101
		private IntPtr id_isActive;

		// Token: 0x04000066 RID: 102
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x04000067 RID: 103
		private IntPtr id_isCancelled;

		// Token: 0x04000068 RID: 104
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x04000069 RID: 105
		private IntPtr id_isCompleted;

		// Token: 0x0400006A RID: 106
		[Nullable(2)]
		private static Delegate cb_getOnJoin;

		// Token: 0x0400006B RID: 107
		private IntPtr id_getOnJoin;

		// Token: 0x0400006C RID: 108
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x0400006D RID: 109
		private IntPtr id_getParent;

		// Token: 0x0400006E RID: 110
		[Nullable(2)]
		private static Delegate cb_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x0400006F RID: 111
		private IntPtr id_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x04000070 RID: 112
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000071 RID: 113
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000072 RID: 114
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x04000073 RID: 115
		private IntPtr id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x04000074 RID: 116
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000075 RID: 117
		private IntPtr id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000076 RID: 118
		[Nullable(2)]
		private static Delegate cb_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000077 RID: 119
		private IntPtr id_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000078 RID: 120
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x04000079 RID: 121
		private IntPtr id_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x0400007A RID: 122
		[Nullable(2)]
		private static Delegate cb_start;

		// Token: 0x0400007B RID: 123
		private IntPtr id_start;

		// Token: 0x0400007C RID: 124
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x0400007D RID: 125
		private IntPtr id_getKey;

		// Token: 0x0400007E RID: 126
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x0400007F RID: 127
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000080 RID: 128
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000081 RID: 129
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000082 RID: 130
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000083 RID: 131
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000084 RID: 132
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000085 RID: 133
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
