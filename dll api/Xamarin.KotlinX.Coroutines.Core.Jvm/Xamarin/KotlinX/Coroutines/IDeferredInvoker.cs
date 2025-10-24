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
	// Token: 0x02000059 RID: 89
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Deferred", DoNotGenerateAcw = true)]
	internal class IDeferredInvoker : Java.Lang.Object, IDeferred, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000BBBC File Offset: 0x00009DBC
		private static IntPtr java_class_ref
		{
			get
			{
				return IDeferredInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDeferredInvoker._members;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000BBE7 File Offset: 0x00009DE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000BBEF File Offset: 0x00009DEF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDeferredInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000BBFB File Offset: 0x00009DFB
		[NullableContext(2)]
		public static IDeferred GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDeferred>(handle, transfer);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000BC04 File Offset: 0x00009E04
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDeferredInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.Deferred'.");
			}
			return handle;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000BC2F File Offset: 0x00009E2F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000BC60 File Offset: 0x00009E60
		public IDeferredInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDeferredInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000BC98 File Offset: 0x00009E98
		private static Delegate GetGetCompletedHandler()
		{
			if (IDeferredInvoker.cb_getCompleted == null)
			{
				IDeferredInvoker.cb_getCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetCompleted));
			}
			return IDeferredInvoker.cb_getCompleted;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000BCBC File Offset: 0x00009EBC
		private static IntPtr n_GetCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Completed);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Nullable(2)]
		public Java.Lang.Object Completed
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getCompleted == IntPtr.Zero)
				{
					this.id_getCompleted = JNIEnv.GetMethodID(this.class_ref, "getCompleted", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCompleted), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000BD21 File Offset: 0x00009F21
		private static Delegate GetGetCompletionExceptionOrNullHandler()
		{
			if (IDeferredInvoker.cb_getCompletionExceptionOrNull == null)
			{
				IDeferredInvoker.cb_getCompletionExceptionOrNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetCompletionExceptionOrNull));
			}
			return IDeferredInvoker.cb_getCompletionExceptionOrNull;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000BD45 File Offset: 0x00009F45
		private static IntPtr n_GetCompletionExceptionOrNull(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompletionExceptionOrNull);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000BD5C File Offset: 0x00009F5C
		[Nullable(2)]
		public Throwable CompletionExceptionOrNull
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getCompletionExceptionOrNull == IntPtr.Zero)
				{
					this.id_getCompletionExceptionOrNull = JNIEnv.GetMethodID(this.class_ref, "getCompletionExceptionOrNull", "()Ljava/lang/Throwable;");
				}
				return Java.Lang.Object.GetObject<Throwable>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCompletionExceptionOrNull), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000BDAD File Offset: 0x00009FAD
		private static Delegate GetGetOnAwaitHandler()
		{
			if (IDeferredInvoker.cb_getOnAwait == null)
			{
				IDeferredInvoker.cb_getOnAwait = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetOnAwait));
			}
			return IDeferredInvoker.cb_getOnAwait;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000BDD1 File Offset: 0x00009FD1
		private static IntPtr n_GetOnAwait(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAwait);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public ISelectClause1 OnAwait
		{
			get
			{
				if (this.id_getOnAwait == IntPtr.Zero)
				{
					this.id_getOnAwait = JNIEnv.GetMethodID(this.class_ref, "getOnAwait", "()Lkotlinx/coroutines/selects/SelectClause1;");
				}
				return Java.Lang.Object.GetObject<ISelectClause1>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnAwait), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000BE39 File Offset: 0x0000A039
		private static Delegate GetAwait_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IDeferredInvoker.cb_await_Lkotlin_coroutines_Continuation_ == null)
			{
				IDeferredInvoker.cb_await_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_Await_Lkotlin_coroutines_Continuation_));
			}
			return IDeferredInvoker.cb_await_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000BE60 File Offset: 0x0000A060
		private static IntPtr n_Await_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDeferred @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Await(object2));
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000BE88 File Offset: 0x0000A088
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Await(IContinuation p0)
		{
			if (this.id_await_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_await_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "await", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_await_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000BF06 File Offset: 0x0000A106
		private static Delegate GetGetCancellationExceptionHandler()
		{
			if (IDeferredInvoker.cb_getCancellationException == null)
			{
				IDeferredInvoker.cb_getCancellationException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetCancellationException));
			}
			return IDeferredInvoker.cb_getCancellationException;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000BF2A File Offset: 0x0000A12A
		private static IntPtr n_GetCancellationException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancellationException);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000BF40 File Offset: 0x0000A140
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

		// Token: 0x06000373 RID: 883 RVA: 0x0000BF91 File Offset: 0x0000A191
		private static Delegate GetGetChildrenHandler()
		{
			if (IDeferredInvoker.cb_getChildren == null)
			{
				IDeferredInvoker.cb_getChildren = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetChildren));
			}
			return IDeferredInvoker.cb_getChildren;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000BFB5 File Offset: 0x0000A1B5
		private static IntPtr n_GetChildren(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Children);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000BFCC File Offset: 0x0000A1CC
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

		// Token: 0x06000376 RID: 886 RVA: 0x0000C01D File Offset: 0x0000A21D
		private static Delegate GetIsActiveHandler()
		{
			if (IDeferredInvoker.cb_isActive == null)
			{
				IDeferredInvoker.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDeferredInvoker.n_IsActive));
			}
			return IDeferredInvoker.cb_isActive;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000C041 File Offset: 0x0000A241
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0000C050 File Offset: 0x0000A250
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

		// Token: 0x06000379 RID: 889 RVA: 0x0000C090 File Offset: 0x0000A290
		private static Delegate GetIsCancelledHandler()
		{
			if (IDeferredInvoker.cb_isCancelled == null)
			{
				IDeferredInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDeferredInvoker.n_IsCancelled));
			}
			return IDeferredInvoker.cb_isCancelled;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000C0C3 File Offset: 0x0000A2C3
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

		// Token: 0x0600037C RID: 892 RVA: 0x0000C103 File Offset: 0x0000A303
		private static Delegate GetIsCompletedHandler()
		{
			if (IDeferredInvoker.cb_isCompleted == null)
			{
				IDeferredInvoker.cb_isCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDeferredInvoker.n_IsCompleted));
			}
			return IDeferredInvoker.cb_isCompleted;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000C127 File Offset: 0x0000A327
		private static bool n_IsCompleted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCompleted;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000C136 File Offset: 0x0000A336
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

		// Token: 0x0600037F RID: 895 RVA: 0x0000C176 File Offset: 0x0000A376
		private static Delegate GetGetOnJoinHandler()
		{
			if (IDeferredInvoker.cb_getOnJoin == null)
			{
				IDeferredInvoker.cb_getOnJoin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetOnJoin));
			}
			return IDeferredInvoker.cb_getOnJoin;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000C19A File Offset: 0x0000A39A
		private static IntPtr n_GetOnJoin(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnJoin);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
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

		// Token: 0x06000382 RID: 898 RVA: 0x0000C201 File Offset: 0x0000A401
		private static Delegate GetGetParentHandler()
		{
			if (IDeferredInvoker.cb_getParent == null)
			{
				IDeferredInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetParent));
			}
			return IDeferredInvoker.cb_getParent;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000C225 File Offset: 0x0000A425
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000C23C File Offset: 0x0000A43C
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

		// Token: 0x06000385 RID: 901 RVA: 0x0000C28D File Offset: 0x0000A48D
		private static Delegate GetAttachChild_Lkotlinx_coroutines_ChildJob_Handler()
		{
			if (IDeferredInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ == null)
			{
				IDeferredInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_AttachChild_Lkotlinx_coroutines_ChildJob_));
			}
			return IDeferredInvoker.cb_attachChild_Lkotlinx_coroutines_ChildJob_;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		private static IntPtr n_AttachChild_Lkotlinx_coroutines_ChildJob_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IJob @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IChildJob object2 = Java.Lang.Object.GetObject<IChildJob>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AttachChild(object2));
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000C2DC File Offset: 0x0000A4DC
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

		// Token: 0x06000388 RID: 904 RVA: 0x0000C35A File Offset: 0x0000A55A
		private static Delegate GetCancel_Ljava_util_concurrent_CancellationException_Handler()
		{
			if (IDeferredInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ == null)
			{
				IDeferredInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDeferredInvoker.n_Cancel_Ljava_util_concurrent_CancellationException_));
			}
			return IDeferredInvoker.cb_cancel_Ljava_util_concurrent_CancellationException_;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000C380 File Offset: 0x0000A580
		private static void n_Cancel_Ljava_util_concurrent_CancellationException_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IJob @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CancellationException object2 = Java.Lang.Object.GetObject<CancellationException>(native_cause, JniHandleOwnership.DoNotTransfer);
			@object.Cancel(object2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
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

		// Token: 0x0600038B RID: 907 RVA: 0x0000C417 File Offset: 0x0000A617
		private static Delegate GetInvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_Handler()
		{
			if (IDeferredInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ == null)
			{
				IDeferredInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZL_L(IDeferredInvoker.n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_));
			}
			return IDeferredInvoker.cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000C43C File Offset: 0x0000A63C
		private static IntPtr n_InvokeOnCompletion_ZZLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, bool onCancelling, bool invokeImmediately, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(onCancelling, invokeImmediately, object2));
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000C468 File Offset: 0x0000A668
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

		// Token: 0x0600038E RID: 910 RVA: 0x0000C50F File Offset: 0x0000A70F
		private static Delegate GetInvokeOnCompletion_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (IDeferredInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ == null)
			{
				IDeferredInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_));
			}
			return IDeferredInvoker.cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000C534 File Offset: 0x0000A734
		private static IntPtr n_InvokeOnCompletion_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			IJob @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_handler, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InvokeOnCompletion(object2));
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000C55C File Offset: 0x0000A75C
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

		// Token: 0x06000391 RID: 913 RVA: 0x0000C5DA File Offset: 0x0000A7DA
		private static Delegate GetJoin_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IDeferredInvoker.cb_join_Lkotlin_coroutines_Continuation_ == null)
			{
				IDeferredInvoker.cb_join_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_Join_Lkotlin_coroutines_Continuation_));
			}
			return IDeferredInvoker.cb_join_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000C600 File Offset: 0x0000A800
		private static IntPtr n_Join_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IJob @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Join(object2));
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000C628 File Offset: 0x0000A828
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

		// Token: 0x06000394 RID: 916 RVA: 0x0000C6A6 File Offset: 0x0000A8A6
		[Obsolete]
		private static Delegate GetPlus_Lkotlinx_coroutines_Job_Handler()
		{
			if (IDeferredInvoker.cb_plus_Lkotlinx_coroutines_Job_ == null)
			{
				IDeferredInvoker.cb_plus_Lkotlinx_coroutines_Job_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_Plus_Lkotlinx_coroutines_Job_));
			}
			return IDeferredInvoker.cb_plus_Lkotlinx_coroutines_Job_;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		[Obsolete]
		private static IntPtr n_Plus_Lkotlinx_coroutines_Job_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IJob @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IJob object2 = Java.Lang.Object.GetObject<IJob>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
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

		// Token: 0x06000397 RID: 919 RVA: 0x0000C772 File Offset: 0x0000A972
		private static Delegate GetStartHandler()
		{
			if (IDeferredInvoker.cb_start == null)
			{
				IDeferredInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDeferredInvoker.n_Start));
			}
			return IDeferredInvoker.cb_start;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000C796 File Offset: 0x0000A996
		private static bool n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000C7A5 File Offset: 0x0000A9A5
		public bool Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000C7E5 File Offset: 0x0000A9E5
		private static Delegate GetGetKeyHandler()
		{
			if (IDeferredInvoker.cb_getKey == null)
			{
				IDeferredInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeferredInvoker.n_GetKey));
			}
			return IDeferredInvoker.cb_getKey;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000C809 File Offset: 0x0000AA09
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000C820 File Offset: 0x0000AA20
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

		// Token: 0x0600039D RID: 925 RVA: 0x0000C871 File Offset: 0x0000AA71
		private static Delegate GetFold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (IDeferredInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				IDeferredInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IDeferredInvoker.n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return IDeferredInvoker.cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000C898 File Offset: 0x0000AA98
		private static IntPtr n_Fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_initial, IntPtr native_operation)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initial, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_operation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fold(object2, object3));
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000C8CC File Offset: 0x0000AACC
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

		// Token: 0x060003A0 RID: 928 RVA: 0x0000C96C File Offset: 0x0000AB6C
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IDeferredInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IDeferredInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IDeferredInvoker.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000C990 File Offset: 0x0000AB90
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
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

		// Token: 0x060003A3 RID: 931 RVA: 0x0000CA36 File Offset: 0x0000AC36
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (IDeferredInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				IDeferredInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return IDeferredInvoker.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			ICoroutineContextElement @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000CA84 File Offset: 0x0000AC84
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

		// Token: 0x060003A6 RID: 934 RVA: 0x0000CB02 File Offset: 0x0000AD02
		private static Delegate GetPlus_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (IDeferredInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				IDeferredInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeferredInvoker.n_Plus_Lkotlin_coroutines_CoroutineContext_));
			}
			return IDeferredInvoker.cb_plus_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000CB28 File Offset: 0x0000AD28
		private static IntPtr n_Plus_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			ICoroutineContext @object = Java.Lang.Object.GetObject<IDeferred>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Plus(object2));
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000CB50 File Offset: 0x0000AD50
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

		// Token: 0x04000117 RID: 279
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Deferred", typeof(IDeferredInvoker));

		// Token: 0x04000118 RID: 280
		private IntPtr class_ref;

		// Token: 0x04000119 RID: 281
		[Nullable(2)]
		private static Delegate cb_getCompleted;

		// Token: 0x0400011A RID: 282
		private IntPtr id_getCompleted;

		// Token: 0x0400011B RID: 283
		[Nullable(2)]
		private static Delegate cb_getCompletionExceptionOrNull;

		// Token: 0x0400011C RID: 284
		private IntPtr id_getCompletionExceptionOrNull;

		// Token: 0x0400011D RID: 285
		[Nullable(2)]
		private static Delegate cb_getOnAwait;

		// Token: 0x0400011E RID: 286
		private IntPtr id_getOnAwait;

		// Token: 0x0400011F RID: 287
		[Nullable(2)]
		private static Delegate cb_await_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000120 RID: 288
		private IntPtr id_await_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000121 RID: 289
		[Nullable(2)]
		private static Delegate cb_getCancellationException;

		// Token: 0x04000122 RID: 290
		private IntPtr id_getCancellationException;

		// Token: 0x04000123 RID: 291
		[Nullable(2)]
		private static Delegate cb_getChildren;

		// Token: 0x04000124 RID: 292
		private IntPtr id_getChildren;

		// Token: 0x04000125 RID: 293
		[Nullable(2)]
		private static Delegate cb_isActive;

		// Token: 0x04000126 RID: 294
		private IntPtr id_isActive;

		// Token: 0x04000127 RID: 295
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x04000128 RID: 296
		private IntPtr id_isCancelled;

		// Token: 0x04000129 RID: 297
		[Nullable(2)]
		private static Delegate cb_isCompleted;

		// Token: 0x0400012A RID: 298
		private IntPtr id_isCompleted;

		// Token: 0x0400012B RID: 299
		[Nullable(2)]
		private static Delegate cb_getOnJoin;

		// Token: 0x0400012C RID: 300
		private IntPtr id_getOnJoin;

		// Token: 0x0400012D RID: 301
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x0400012E RID: 302
		private IntPtr id_getParent;

		// Token: 0x0400012F RID: 303
		[Nullable(2)]
		private static Delegate cb_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x04000130 RID: 304
		private IntPtr id_attachChild_Lkotlinx_coroutines_ChildJob_;

		// Token: 0x04000131 RID: 305
		[Nullable(2)]
		private static Delegate cb_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000132 RID: 306
		private IntPtr id_cancel_Ljava_util_concurrent_CancellationException_;

		// Token: 0x04000133 RID: 307
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x04000134 RID: 308
		private IntPtr id_invokeOnCompletion_ZZLkotlin_jvm_functions_Function1_;

		// Token: 0x04000135 RID: 309
		[Nullable(2)]
		private static Delegate cb_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000136 RID: 310
		private IntPtr id_invokeOnCompletion_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000137 RID: 311
		[Nullable(2)]
		private static Delegate cb_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000138 RID: 312
		private IntPtr id_join_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000139 RID: 313
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x0400013A RID: 314
		private IntPtr id_plus_Lkotlinx_coroutines_Job_;

		// Token: 0x0400013B RID: 315
		[Nullable(2)]
		private static Delegate cb_start;

		// Token: 0x0400013C RID: 316
		private IntPtr id_start;

		// Token: 0x0400013D RID: 317
		[Nullable(2)]
		private static Delegate cb_getKey;

		// Token: 0x0400013E RID: 318
		private IntPtr id_getKey;

		// Token: 0x0400013F RID: 319
		[Nullable(2)]
		private static Delegate cb_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000140 RID: 320
		private IntPtr id_fold_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000141 RID: 321
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000142 RID: 322
		private IntPtr id_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000143 RID: 323
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000144 RID: 324
		private IntPtr id_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000145 RID: 325
		[Nullable(2)]
		private static Delegate cb_plus_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000146 RID: 326
		private IntPtr id_plus_Lkotlin_coroutines_CoroutineContext_;
	}
}
