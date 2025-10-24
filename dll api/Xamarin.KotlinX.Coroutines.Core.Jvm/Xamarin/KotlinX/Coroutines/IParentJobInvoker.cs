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
	// Token: 0x02000073 RID: 115
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ParentJob", DoNotGenerateAcw = true)]
	internal class IParentJobInvoker : Java.Lang.Object, IParentJob, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		private static IntPtr java_class_ref
		{
			get
			{
				return IParentJobInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000FB30 File Offset: 0x0000DD30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IParentJobInvoker._members;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0000FB37 File Offset: 0x0000DD37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000FB3F File Offset: 0x0000DD3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IParentJobInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000FB4B File Offset: 0x0000DD4B
		[NullableContext(2)]
		public static IParentJob GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IParentJob>(handle, transfer);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000FB54 File Offset: 0x0000DD54
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IParentJobInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.ParentJob'.");
			}
			return handle;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000FB7F File Offset: 0x0000DD7F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		public IParentJobInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IParentJobInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		private static Delegate GetGetChildJobCancellationCauseHandler()
		{
			if (IParentJobInvoker.cb_getChildJobCancellationCause == null)
			{
				IParentJobInvoker.cb_getChildJobCancellationCause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParentJobInvoker.n_GetChildJobCancellationCause));
			}
			return IParentJobInvoker.cb_getChildJobCancellationCause;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		private static IntPtr n_GetChildJobCancellationCause(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildJobCancellationCause);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public CancellationException ChildJobCancellationCause
		{
			get
			{
				if (this.id_getChildJobCancellationCause == IntPtr.Zero)
				{
					this.id_getChildJobCancellationCause = JNIEnv.GetMethodID(this.class_ref, "getChildJobCancellationCause", "()Ljava/util/concurrent/CancellationException;");
				}
				return Java.Lang.Object.GetObject<CancellationException>(JNIEnv.CallObjectMethod(base.Handle, this.id_getChildJobCancellationCause), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000FC71 File Offset: 0x0000DE71
		private static Delegate GetGetCancellationExceptionHandler()
		{
			if (IParentJobInvoker.cb_getCancellationException == null)
			{
				IParentJobInvoker.cb_getCancellationException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParentJobInvoker.n_GetCancellationException));
			}
			return IParentJobInvoker.cb_getCancellationException;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000FC95 File Offset: 0x0000DE95
		private static IntPtr n_GetCancellationException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationException);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0000FCAC File Offset: 0x0000DEAC
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

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000FCFD File Offset: 0x0000DEFD
		private static Delegate GetGetChildrenHandler()
		{
			if (IParentJobInvoker.cb_getChildren == null)
			{
				IParentJobInvoker.cb_getChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParentJobInvoker.n_GetChildren));
			}
			return IParentJobInvoker.cb_getChildren;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000FD21 File Offset: 0x0000DF21
		private static IntPtr n_GetChildren(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Children);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000FD38 File Offset: 0x0000DF38
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

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000FD89 File Offset: 0x0000DF89
		private static Delegate GetIsActiveHandler()
		{
			if (IParentJobInvoker.cb_isActive == null)
			{
				IParentJobInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IParentJobInvoker.n_IsActive));
			}
			return IParentJobInvoker.cb_isActive;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000FDAD File Offset: 0x0000DFAD
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000FDBC File Offset: 0x0000DFBC
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

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		private static Delegate GetIsCancelledHandler()
		{
			if (IParentJobInvoker.cb_isCancelled == null)
			{
				IParentJobInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IParentJobInvoker.n_IsCancelled));
			}
			return IParentJobInvoker.cb_isCancelled;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000FE20 File Offset: 0x0000E020
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000FE2F File Offset: 0x0000E02F
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

		// Token: 0x060004CC RID: 1228 RVA: 0x0000FE6F File Offset: 0x0000E06F
		private static Delegate GetIsCompletedHandler()
		{
			if (IParentJobInvoker.cb_isCompleted == null)
			{
				IParentJobInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IParentJobInvoker.n_IsCompleted));
			}
			return IParentJobInvoker.cb_isCompleted;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000FE93 File Offset: 0x0000E093
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000FEA2 File Offset: 0x0000E0A2
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

		// Token: 0x060004CF RID: 1231 RVA: 0x0000FEE2 File Offset: 0x0000E0E2
		private static Delegate GetGetOnJoinHandler()
		{
			if (IParentJobInvoker.cb_getOnJoin == null)
			{
				IParentJobInvoker.cb_getOnJoin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParentJobInvoker.n_GetOnJoin));
			}
			return IParentJobInvoker.cb_getOnJoin;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000FF06 File Offset: 0x0000E106
		private static IntPtr n_GetOnJoin(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnJoin);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0000FF1C File Offset: 0x0000E11C
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

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000FF6D File Offset: 0x0000E16D
		private static Delegate GetGetParentHandler()
		{
			if (IParentJobInvoker.cb_getParent == null)
			{
				IParentJobInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParentJobInvoker.n_GetParent));
			}
			return IParentJobInvoker.cb_getParent;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000FF91 File Offset: 0x0000E191
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
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

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000FFF9 File Offset: 0x0000E1F9
		private static Delegate GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler()
		{
			if (IParentJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ == null)
			{
				IParentJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_AttachChild_Lkotlinx_coroutines_ChildJob_));
			}
			return IParentJobInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00010020 File Offset: 0x0000E220
		private static IntPtr n_AttachChild_Lkotlinx_coroutines_ChildJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IJob @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IChildJob object2 = Java.Lang.Object.GetObject<IChildJob>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachChild(object2));
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00010048 File Offset: 0x0000E248
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

		// Token: 0x060004D8 RID: 1240 RVA: 0x000100C6 File Offset: 0x0000E2C6
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IParentJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IParentJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IParentJobInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IParentJobInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000100EC File Offset: 0x0000E2EC
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IJob @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00010110 File Offset: 0x0000E310
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

		// Token: 0x060004DB RID: 1243 RVA: 0x00010183 File Offset: 0x0000E383
		private static Delegate GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler()
		{
			if (IParentJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == null)
			{
				IParentJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZL_L(IParentJobInvoker.n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_));
			}
			return IParentJobInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000101A8 File Offset: 0x0000E3A8
		private static IntPtr n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, bool onCancelling, bool invokeImmediately, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(onCancelling, invokeImmediately, object2));
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000101D4 File Offset: 0x0000E3D4
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

		// Token: 0x060004DE RID: 1246 RVA: 0x0001027B File Offset: 0x0000E47B
		private static Delegate GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IParentJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == null)
			{
				IParentJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_));
			}
			return IParentJobInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000102A0 File Offset: 0x0000E4A0
		private static IntPtr n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(object2));
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000102C8 File Offset: 0x0000E4C8
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

		// Token: 0x060004E1 RID: 1249 RVA: 0x00010346 File Offset: 0x0000E546
		private static Delegate GetJoin_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IParentJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ == null)
			{
				IParentJobInvoker.cb_join_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_Join_Lkotlin_coroutines_Continuation_));
			}
			return IParentJobInvoker.cb_join_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001036C File Offset: 0x0000E56C
		private static IntPtr n_Join_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJob @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Join(object2));
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00010394 File Offset: 0x0000E594
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

		// Token: 0x060004E4 RID: 1252 RVA: 0x00010412 File Offset: 0x0000E612
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (IParentJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				IParentJobInvoker.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return IParentJobInvoker.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00010438 File Offset: 0x0000E638
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IJob @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00010460 File Offset: 0x0000E660
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

		// Token: 0x060004E7 RID: 1255 RVA: 0x000104DE File Offset: 0x0000E6DE
		private static Delegate GetStartHandler()
		{
			if (IParentJobInvoker.cb_start == null)
			{
				IParentJobInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IParentJobInvoker.n_Start));
			}
			return IParentJobInvoker.cb_start;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00010502 File Offset: 0x0000E702
		private static bool n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00010511 File Offset: 0x0000E711
		public bool Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_start);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00010551 File Offset: 0x0000E751
		private static Delegate GetGetKeyHandler()
		{
			if (IParentJobInvoker.cb_getKey == null)
			{
				IParentJobInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IParentJobInvoker.n_GetKey));
			}
			return IParentJobInvoker.cb_getKey;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00010575 File Offset: 0x0000E775
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0001058C File Offset: 0x0000E78C
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

		// Token: 0x060004ED RID: 1261 RVA: 0x000105DD File Offset: 0x0000E7DD
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IParentJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				IParentJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IParentJobInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return IParentJobInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00010604 File Offset: 0x0000E804
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00010638 File Offset: 0x0000E838
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

		// Token: 0x060004F0 RID: 1264 RVA: 0x000106D8 File Offset: 0x0000E8D8
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IParentJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IParentJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IParentJobInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000106FC File Offset: 0x0000E8FC
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00010724 File Offset: 0x0000E924
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

		// Token: 0x060004F3 RID: 1267 RVA: 0x000107A2 File Offset: 0x0000E9A2
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IParentJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IParentJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IParentJobInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000107C8 File Offset: 0x0000E9C8
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000107F0 File Offset: 0x0000E9F0
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

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001086E File Offset: 0x0000EA6E
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IParentJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IParentJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParentJobInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return IParentJobInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00010894 File Offset: 0x0000EA94
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<IParentJob>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000108BC File Offset: 0x0000EABC
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

		// Token: 0x040001B3 RID: 435
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ParentJob", typeof(IParentJobInvoker));

		// Token: 0x040001B4 RID: 436
		private IntPtr class_ref;

		// Token: 0x040001B5 RID: 437
		[Nullable(2)]
		private static Delegate cb_getChildJobCancellationCause;

		// Token: 0x040001B6 RID: 438
		private IntPtr id_getChildJobCancellationCause;

		// Token: 0x040001B7 RID: 439
		[Nullable(2)]
		private static Delegate cb_getCancellationException;

		// Token: 0x040001B8 RID: 440
		private IntPtr id_getCancellationException;

		// Token: 0x040001B9 RID: 441
		[Nullable(2)]
		private static Delegate cb_getChildren;

		// Token: 0x040001BA RID: 442
		private IntPtr id_getChildren;

		// Token: 0x040001BB RID: 443
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x040001BC RID: 444
		private IntPtr id_isActive;

		// Token: 0x040001BD RID: 445
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x040001BE RID: 446
		private IntPtr id_isCancelled;

		// Token: 0x040001BF RID: 447
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x040001C0 RID: 448
		private IntPtr id_isCompleted;

		// Token: 0x040001C1 RID: 449
		[Nullable(2)]
		private static Delegate cb_getOnJoin;

		// Token: 0x040001C2 RID: 450
		private IntPtr id_getOnJoin;

		// Token: 0x040001C3 RID: 451
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x040001C4 RID: 452
		private IntPtr id_getParent;

		// Token: 0x040001C5 RID: 453
		[Nullable(2)]
		private static Delegate cb_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x040001C6 RID: 454
		private IntPtr id_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x040001C7 RID: 455
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040001C8 RID: 456
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x040001C9 RID: 457
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x040001CA RID: 458
		private IntPtr id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x040001CB RID: 459
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040001CC RID: 460
		private IntPtr id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x040001CD RID: 461
		[Nullable(2)]
		private static Delegate cb_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x040001CE RID: 462
		private IntPtr id_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x040001CF RID: 463
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x040001D0 RID: 464
		private IntPtr id_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x040001D1 RID: 465
		[Nullable(2)]
		private static Delegate cb_start;

		// Token: 0x040001D2 RID: 466
		private IntPtr id_start;

		// Token: 0x040001D3 RID: 467
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x040001D4 RID: 468
		private IntPtr id_getKey;

		// Token: 0x040001D5 RID: 469
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001D6 RID: 470
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x040001D7 RID: 471
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001D8 RID: 472
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001D9 RID: 473
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001DA RID: 474
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x040001DB RID: 475
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x040001DC RID: 476
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
