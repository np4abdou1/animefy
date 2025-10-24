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
	// Token: 0x0200006C RID: 108
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Job", DoNotGenerateAcw = true)]
	internal class IJobInvoker : Java.Lang.Object, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IJobInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJobInvoker._members;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000E4FF File Offset: 0x0000C6FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJobInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000E50B File Offset: 0x0000C70B
		[NullableContext(2)]
		public static IJob GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJob>(handle, transfer);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000E514 File Offset: 0x0000C714
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJobInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.Job'.");
			}
			return handle;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000E53F File Offset: 0x0000C73F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000E570 File Offset: 0x0000C770
		public IJobInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJobInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		private static Delegate GetGetCancellationExceptionHandler()
		{
			if (IJobInvoker.cb_getCancellationException == null)
			{
				IJobInvoker.cb_getCancellationException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJobInvoker.n_GetCancellationException));
			}
			return IJobInvoker.cb_getCancellationException;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		private static IntPtr n_GetCancellationException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationException);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
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

		// Token: 0x06000455 RID: 1109 RVA: 0x0000E631 File Offset: 0x0000C831
		private static Delegate GetGetChildrenHandler()
		{
			if (IJobInvoker.cb_getChildren == null)
			{
				IJobInvoker.cb_getChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJobInvoker.n_GetChildren));
			}
			return IJobInvoker.cb_getChildren;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000E655 File Offset: 0x0000C855
		private static IntPtr n_GetChildren(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Children);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000E66C File Offset: 0x0000C86C
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

		// Token: 0x06000458 RID: 1112 RVA: 0x0000E6BD File Offset: 0x0000C8BD
		private static Delegate GetIsActiveHandler()
		{
			if (IJobInvoker.cb_isActive == null)
			{
				IJobInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IJobInvoker.n_IsActive));
			}
			return IJobInvoker.cb_isActive;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000E6E1 File Offset: 0x0000C8E1
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
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

		// Token: 0x0600045B RID: 1115 RVA: 0x0000E730 File Offset: 0x0000C930
		private static Delegate GetIsCancelledHandler()
		{
			if (IJobInvoker.cb_isCancelled == null)
			{
				IJobInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IJobInvoker.n_IsCancelled));
			}
			return IJobInvoker.cb_isCancelled;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000E754 File Offset: 0x0000C954
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000E763 File Offset: 0x0000C963
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

		// Token: 0x0600045E RID: 1118 RVA: 0x0000E7A3 File Offset: 0x0000C9A3
		private static Delegate GetIsCompletedHandler()
		{
			if (IJobInvoker.cb_isCompleted == null)
			{
				IJobInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IJobInvoker.n_IsCompleted));
			}
			return IJobInvoker.cb_isCompleted;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000E7C7 File Offset: 0x0000C9C7
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
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

		// Token: 0x06000461 RID: 1121 RVA: 0x0000E816 File Offset: 0x0000CA16
		private static Delegate GetGetOnJoinHandler()
		{
			if (IJobInvoker.cb_getOnJoin == null)
			{
				IJobInvoker.cb_getOnJoin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJobInvoker.n_GetOnJoin));
			}
			return IJobInvoker.cb_getOnJoin;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000E83A File Offset: 0x0000CA3A
		private static IntPtr n_GetOnJoin(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnJoin);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000E850 File Offset: 0x0000CA50
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

		// Token: 0x06000464 RID: 1124 RVA: 0x0000E8A1 File Offset: 0x0000CAA1
		private static Delegate GetGetParentHandler()
		{
			if (IJobInvoker.cb_getParent == null)
			{
				IJobInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJobInvoker.n_GetParent));
			}
			return IJobInvoker.cb_getParent;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000E8C5 File Offset: 0x0000CAC5
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000E8DC File Offset: 0x0000CADC
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

		// Token: 0x06000467 RID: 1127 RVA: 0x0000E92D File Offset: 0x0000CB2D
		private static Delegate GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler()
		{
			if (IJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ == null)
			{
				IJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_AttachChild_Lkotlinx_coroutines_ChildJob_));
			}
			return IJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000E954 File Offset: 0x0000CB54
		private static IntPtr n_AttachChild_Lkotlinx_coroutines_ChildJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IJob @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IChildJob object2 = Java.Lang.Object.GetObject<IChildJob>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachChild(object2));
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000E97C File Offset: 0x0000CB7C
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

		// Token: 0x0600046A RID: 1130 RVA: 0x0000E9FA File Offset: 0x0000CBFA
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IJobInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000EA20 File Offset: 0x0000CC20
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IJob @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000EA44 File Offset: 0x0000CC44
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

		// Token: 0x0600046D RID: 1133 RVA: 0x0000EAB7 File Offset: 0x0000CCB7
		private static Delegate GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler()
		{
			if (IJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == null)
			{
				IJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZL_L(IJobInvoker.n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_));
			}
			return IJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000EADC File Offset: 0x0000CCDC
		private static IntPtr n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, bool onCancelling, bool invokeImmediately, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(onCancelling, invokeImmediately, object2));
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000EB08 File Offset: 0x0000CD08
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

		// Token: 0x06000470 RID: 1136 RVA: 0x0000EBAF File Offset: 0x0000CDAF
		private static Delegate GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == null)
			{
				IJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_));
			}
			return IJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
		private static IntPtr n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(object2));
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000EBFC File Offset: 0x0000CDFC
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

		// Token: 0x06000473 RID: 1139 RVA: 0x0000EC7A File Offset: 0x0000CE7A
		private static Delegate GetJoin_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ == null)
			{
				IJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_Join_Lkotlin_coroutines_Continuation_));
			}
			return IJobInvoker.cb_join_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		private static IntPtr n_Join_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJob @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Join(object2));
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
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

		// Token: 0x06000476 RID: 1142 RVA: 0x0000ED46 File Offset: 0x0000CF46
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (IJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				IJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return IJobInvoker.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IJob @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000ED94 File Offset: 0x0000CF94
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

		// Token: 0x06000479 RID: 1145 RVA: 0x0000EE12 File Offset: 0x0000D012
		private static Delegate GetStartHandler()
		{
			if (IJobInvoker.cb_start == null)
			{
				IJobInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IJobInvoker.n_Start));
			}
			return IJobInvoker.cb_start;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000EE36 File Offset: 0x0000D036
		private static bool n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000EE45 File Offset: 0x0000D045
		public bool Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000EE85 File Offset: 0x0000D085
		private static Delegate GetGetKeyHandler()
		{
			if (IJobInvoker.cb_getKey == null)
			{
				IJobInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJobInvoker.n_GetKey));
			}
			return IJobInvoker.cb_getKey;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000EEA9 File Offset: 0x0000D0A9
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
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

		// Token: 0x0600047F RID: 1151 RVA: 0x0000EF11 File Offset: 0x0000D111
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				IJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IJobInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return IJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000EF38 File Offset: 0x0000D138
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000EF6C File Offset: 0x0000D16C
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

		// Token: 0x06000482 RID: 1154 RVA: 0x0000F00C File Offset: 0x0000D20C
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000F030 File Offset: 0x0000D230
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000F058 File Offset: 0x0000D258
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

		// Token: 0x06000485 RID: 1157 RVA: 0x0000F0D6 File Offset: 0x0000D2D6
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000F124 File Offset: 0x0000D324
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

		// Token: 0x06000488 RID: 1160 RVA: 0x0000F1A2 File Offset: 0x0000D3A2
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IJobInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return IJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<IJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
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

		// Token: 0x0400017F RID: 383
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Job", typeof(IJobInvoker));

		// Token: 0x04000180 RID: 384
		private IntPtr class_ref;

		// Token: 0x04000181 RID: 385
		[Nullable(2)]
		private static Delegate cb_getCancellationException;

		// Token: 0x04000182 RID: 386
		private IntPtr id_getCancellationException;

		// Token: 0x04000183 RID: 387
		[Nullable(2)]
		private static Delegate cb_getChildren;

		// Token: 0x04000184 RID: 388
		private IntPtr id_getChildren;

		// Token: 0x04000185 RID: 389
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x04000186 RID: 390
		private IntPtr id_isActive;

		// Token: 0x04000187 RID: 391
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x04000188 RID: 392
		private IntPtr id_isCancelled;

		// Token: 0x04000189 RID: 393
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x0400018A RID: 394
		private IntPtr id_isCompleted;

		// Token: 0x0400018B RID: 395
		[Nullable(2)]
		private static Delegate cb_getOnJoin;

		// Token: 0x0400018C RID: 396
		private IntPtr id_getOnJoin;

		// Token: 0x0400018D RID: 397
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x0400018E RID: 398
		private IntPtr id_getParent;

		// Token: 0x0400018F RID: 399
		[Nullable(2)]
		private static Delegate cb_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x04000190 RID: 400
		private IntPtr id_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x04000191 RID: 401
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000192 RID: 402
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000193 RID: 403
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x04000194 RID: 404
		private IntPtr id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x04000195 RID: 405
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000196 RID: 406
		private IntPtr id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000197 RID: 407
		[Nullable(2)]
		private static Delegate cb_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000198 RID: 408
		private IntPtr id_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000199 RID: 409
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x0400019A RID: 410
		private IntPtr id_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x0400019B RID: 411
		[Nullable(2)]
		private static Delegate cb_start;

		// Token: 0x0400019C RID: 412
		private IntPtr id_start;

		// Token: 0x0400019D RID: 413
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x0400019E RID: 414
		private IntPtr id_getKey;

		// Token: 0x0400019F RID: 415
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001A0 RID: 416
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001A1 RID: 417
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001A2 RID: 418
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001A3 RID: 419
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001A4 RID: 420
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001A5 RID: 421
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040001A6 RID: 422
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
