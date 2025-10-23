using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Google.Common.Util.Concurrent
{
	// Token: 0x0200000E RID: 14
	[NullableContext(1)]
	[Nullable(0)]
	[Register("com/google/common/util/concurrent/ListenableFuture", DoNotGenerateAcw = true)]
	internal class IListenableFutureInvoker : Java.Lang.Object, IListenableFuture, IFuture, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000020E0 File Offset: 0x000002E0
		private static IntPtr java_class_ref
		{
			get
			{
				return IListenableFutureInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002104 File Offset: 0x00000304
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IListenableFutureInvoker._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000210B File Offset: 0x0000030B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002113 File Offset: 0x00000313
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IListenableFutureInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000211F File Offset: 0x0000031F
		[NullableContext(2)]
		public static IListenableFuture GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IListenableFuture>(handle, transfer);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002128 File Offset: 0x00000328
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IListenableFutureInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.common.util.concurrent.ListenableFuture'.");
			}
			return handle;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002153 File Offset: 0x00000353
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002184 File Offset: 0x00000384
		public IListenableFutureInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IListenableFutureInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021BC File Offset: 0x000003BC
		private static Delegate GetAddListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_Handler()
		{
			if (IListenableFutureInvoker.cb_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == null)
			{
				IListenableFutureInvoker.cb_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IListenableFutureInvoker.n_AddListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_));
			}
			return IListenableFutureInvoker.cb_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000021E0 File Offset: 0x000003E0
		private static void n_AddListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IListenableFuture @object = Java.Lang.Object.GetObject<IListenableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_p0, JniHandleOwnership.DoNotTransfer);
			IExecutor object3 = Java.Lang.Object.GetObject<IExecutor>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AddListener(object2, object3);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000220C File Offset: 0x0000040C
		[NullableContext(2)]
		public unsafe void AddListener(IRunnable p0, IExecutor p1)
		{
			if (this.id_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
			{
				this.id_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID(this.class_ref, "addListener", "(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_, ptr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000022AB File Offset: 0x000004AB
		private static Delegate GetIsCancelledHandler()
		{
			if (IListenableFutureInvoker.cb_isCancelled == null)
			{
				IListenableFutureInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IListenableFutureInvoker.n_IsCancelled));
			}
			return IListenableFutureInvoker.cb_isCancelled;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000022CF File Offset: 0x000004CF
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListenableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022DE File Offset: 0x000004DE
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

		// Token: 0x0600002D RID: 45 RVA: 0x0000231E File Offset: 0x0000051E
		private static Delegate GetIsDoneHandler()
		{
			if (IListenableFutureInvoker.cb_isDone == null)
			{
				IListenableFutureInvoker.cb_isDone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IListenableFutureInvoker.n_IsDone));
			}
			return IListenableFutureInvoker.cb_isDone;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002342 File Offset: 0x00000542
		private static bool n_IsDone(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListenableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDone;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002351 File Offset: 0x00000551
		public bool IsDone
		{
			get
			{
				if (this.id_isDone == IntPtr.Zero)
				{
					this.id_isDone = JNIEnv.GetMethodID(this.class_ref, "isDone", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isDone);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002391 File Offset: 0x00000591
		private static Delegate GetCancel_ZHandler()
		{
			if (IListenableFutureInvoker.cb_cancel_Z == null)
			{
				IListenableFutureInvoker.cb_cancel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(IListenableFutureInvoker.n_Cancel_Z));
			}
			return IListenableFutureInvoker.cb_cancel_Z;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000023B5 File Offset: 0x000005B5
		private static bool n_Cancel_Z(IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			return Java.Lang.Object.GetObject<IListenableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel(mayInterruptIfRunning);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000023C8 File Offset: 0x000005C8
		public unsafe bool Cancel(bool mayInterruptIfRunning)
		{
			if (this.id_cancel_Z == IntPtr.Zero)
			{
				this.id_cancel_Z = JNIEnv.GetMethodID(this.class_ref, "cancel", "(Z)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(mayInterruptIfRunning);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_cancel_Z, ptr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000242C File Offset: 0x0000062C
		private static Delegate GetGetHandler()
		{
			if (IListenableFutureInvoker.cb_get == null)
			{
				IListenableFutureInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IListenableFutureInvoker.n_Get));
			}
			return IListenableFutureInvoker.cb_get;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002450 File Offset: 0x00000650
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IListenableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002464 File Offset: 0x00000664
		[NullableContext(2)]
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000024B5 File Offset: 0x000006B5
		private static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IListenableFutureInvoker.cb_get_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IListenableFutureInvoker.cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(IListenableFutureInvoker.n_Get_JLjava_util_concurrent_TimeUnit_));
			}
			return IListenableFutureInvoker.cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000024DC File Offset: 0x000006DC
		private static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			IFuture @object = Java.Lang.Object.GetObject<IListenableFuture>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(timeout, object2));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002508 File Offset: 0x00000708
		[NullableContext(2)]
		public unsafe Java.Lang.Object Get(long timeout, TimeUnit unit)
		{
			if (this.id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeout);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/common/util/concurrent/ListenableFuture", typeof(IListenableFutureInvoker));

		// Token: 0x04000005 RID: 5
		private IntPtr class_ref;

		// Token: 0x04000006 RID: 6
		[Nullable(2)]
		private static Delegate cb_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000007 RID: 7
		private IntPtr id_addListener_Ljava_lang_Runnable_Ljava_util_concurrent_Executor_;

		// Token: 0x04000008 RID: 8
		[Nullable(2)]
		private static Delegate cb_isCancelled;

		// Token: 0x04000009 RID: 9
		private IntPtr id_isCancelled;

		// Token: 0x0400000A RID: 10
		[Nullable(2)]
		private static Delegate cb_isDone;

		// Token: 0x0400000B RID: 11
		private IntPtr id_isDone;

		// Token: 0x0400000C RID: 12
		[Nullable(2)]
		private static Delegate cb_cancel_Z;

		// Token: 0x0400000D RID: 13
		private IntPtr id_cancel_Z;

		// Token: 0x0400000E RID: 14
		[Nullable(2)]
		private static Delegate cb_get;

		// Token: 0x0400000F RID: 15
		private IntPtr id_get;

		// Token: 0x04000010 RID: 16
		[Nullable(2)]
		private static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000011 RID: 17
		private IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
	}
}
