using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Android.Gms.Tasks
{
	// Token: 0x02000009 RID: 9
	[Register("com/google/android/gms/tasks/Task", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"TResult"
	})]
	public abstract class Task : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Java.Lang.Object Result
		{
			get
			{
				return this.RawResult;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002058 File Offset: 0x00000258
		internal static IntPtr class_ref
		{
			get
			{
				return Task._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000207C File Offset: 0x0000027C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Task._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002084 File Offset: 0x00000284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Task._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000020A8 File Offset: 0x000002A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Task._members.ManagedPeerType;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020B4 File Offset: 0x000002B4
		protected Task(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020C0 File Offset: 0x000002C0
		[Register(".ctor", "()V", "")]
		public Task() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Task._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Task._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000212E File Offset: 0x0000032E
		private static Delegate GetGetExceptionHandler()
		{
			if (Task.cb_getException == null)
			{
				Task.cb_getException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Task.n_GetException));
			}
			return Task.cb_getException;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002152 File Offset: 0x00000352
		private static IntPtr n_GetException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Exception);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38
		public abstract Java.Lang.Exception Exception { [Register("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")] get; }

		// Token: 0x06000027 RID: 39 RVA: 0x00002166 File Offset: 0x00000366
		private static Delegate GetIsCanceledHandler()
		{
			if (Task.cb_isCanceled == null)
			{
				Task.cb_isCanceled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Task.n_IsCanceled));
			}
			return Task.cb_isCanceled;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000218A File Offset: 0x0000038A
		private static bool n_IsCanceled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCanceled;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41
		public abstract bool IsCanceled { [Register("isCanceled", "()Z", "GetIsCanceledHandler")] get; }

		// Token: 0x0600002A RID: 42 RVA: 0x00002199 File Offset: 0x00000399
		private static Delegate GetIsCompleteHandler()
		{
			if (Task.cb_isComplete == null)
			{
				Task.cb_isComplete = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Task.n_IsComplete));
			}
			return Task.cb_isComplete;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021BD File Offset: 0x000003BD
		private static bool n_IsComplete(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsComplete;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44
		public abstract bool IsComplete { [Register("isComplete", "()Z", "GetIsCompleteHandler")] get; }

		// Token: 0x0600002D RID: 45 RVA: 0x000021CC File Offset: 0x000003CC
		private static Delegate GetIsSuccessfulHandler()
		{
			if (Task.cb_isSuccessful == null)
			{
				Task.cb_isSuccessful = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Task.n_IsSuccessful));
			}
			return Task.cb_isSuccessful;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021F0 File Offset: 0x000003F0
		private static bool n_IsSuccessful(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSuccessful;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47
		public abstract bool IsSuccessful { [Register("isSuccessful", "()Z", "GetIsSuccessfulHandler")] get; }

		// Token: 0x06000030 RID: 48 RVA: 0x000021FF File Offset: 0x000003FF
		private static Delegate GetGetResultHandler()
		{
			if (Task.cb_getResult == null)
			{
				Task.cb_getResult = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Task.n_GetResult));
			}
			return Task.cb_getResult;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002223 File Offset: 0x00000423
		private static IntPtr n_GetResult(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RawResult);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000032 RID: 50
		protected abstract Java.Lang.Object RawResult { [Register("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")] get; }

		// Token: 0x06000033 RID: 51 RVA: 0x00002237 File Offset: 0x00000437
		private static Delegate GetAddOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_Handler()
		{
			if (Task.cb_addOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_ == null)
			{
				Task.cb_addOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_));
			}
			return Task.cb_addOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000225C File Offset: 0x0000045C
		private static IntPtr n_AddOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnCanceledListener object3 = Java.Lang.Object.GetObject<IOnCanceledListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnCanceledListener(object2, object3));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002290 File Offset: 0x00000490
		[Register("addOnCanceledListener", "(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnCanceledListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_Handler")]
		public unsafe virtual Task AddOnCanceledListener(Activity p0, IOnCanceledListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("addOnCanceledListener.(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnCanceledListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002330 File Offset: 0x00000530
		private static Delegate GetAddOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_Handler()
		{
			if (Task.cb_addOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_ == null)
			{
				Task.cb_addOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_AddOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_));
			}
			return Task.cb_addOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002354 File Offset: 0x00000554
		private static IntPtr n_AddOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnCanceledListener object2 = Java.Lang.Object.GetObject<IOnCanceledListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnCanceledListener(object2));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000237C File Offset: 0x0000057C
		[Register("addOnCanceledListener", "(Lcom/google/android/gms/tasks/OnCanceledListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_Handler")]
		public unsafe virtual Task AddOnCanceledListener(IOnCanceledListener p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("addOnCanceledListener.(Lcom/google/android/gms/tasks/OnCanceledListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000023F4 File Offset: 0x000005F4
		private static Delegate GetAddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_Handler()
		{
			if (Task.cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_ == null)
			{
				Task.cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_));
			}
			return Task.cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002418 File Offset: 0x00000618
		private static IntPtr n_AddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnCanceledListener object3 = Java.Lang.Object.GetObject<IOnCanceledListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnCanceledListener(object2, object3));
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000244C File Offset: 0x0000064C
		[Register("addOnCanceledListener", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnCanceledListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_Handler")]
		public unsafe virtual Task AddOnCanceledListener(IExecutor p0, IOnCanceledListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("addOnCanceledListener.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnCanceledListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024F4 File Offset: 0x000006F4
		private static Delegate GetAddOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_Handler()
		{
			if (Task.cb_addOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_ == null)
			{
				Task.cb_addOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_));
			}
			return Task.cb_addOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002518 File Offset: 0x00000718
		private static IntPtr n_AddOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnCompleteListener object3 = Java.Lang.Object.GetObject<IOnCompleteListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnCompleteListener(object2, object3));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000254C File Offset: 0x0000074C
		[Register("addOnCompleteListener", "(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnCompleteListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_Handler")]
		public unsafe virtual Task AddOnCompleteListener(Activity p0, IOnCompleteListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("addOnCompleteListener.(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnCompleteListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000025EC File Offset: 0x000007EC
		private static Delegate GetAddOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_Handler()
		{
			if (Task.cb_addOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_ == null)
			{
				Task.cb_addOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_AddOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_));
			}
			return Task.cb_addOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002610 File Offset: 0x00000810
		private static IntPtr n_AddOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnCompleteListener object2 = Java.Lang.Object.GetObject<IOnCompleteListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnCompleteListener(object2));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002638 File Offset: 0x00000838
		[Register("addOnCompleteListener", "(Lcom/google/android/gms/tasks/OnCompleteListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_Handler")]
		public unsafe virtual Task AddOnCompleteListener(IOnCompleteListener p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("addOnCompleteListener.(Lcom/google/android/gms/tasks/OnCompleteListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000026B0 File Offset: 0x000008B0
		private static Delegate GetAddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_Handler()
		{
			if (Task.cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_ == null)
			{
				Task.cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_));
			}
			return Task.cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000026D4 File Offset: 0x000008D4
		private static IntPtr n_AddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnCompleteListener object3 = Java.Lang.Object.GetObject<IOnCompleteListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnCompleteListener(object2, object3));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002708 File Offset: 0x00000908
		[Register("addOnCompleteListener", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnCompleteListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_Handler")]
		public unsafe virtual Task AddOnCompleteListener(IExecutor p0, IOnCompleteListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("addOnCompleteListener.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnCompleteListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000027B0 File Offset: 0x000009B0
		private static Delegate GetAddOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_Handler()
		{
			if (Task.cb_addOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_ == null)
			{
				Task.cb_addOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_));
			}
			return Task.cb_addOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000027D4 File Offset: 0x000009D4
		private static IntPtr n_AddOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnFailureListener object3 = Java.Lang.Object.GetObject<IOnFailureListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnFailureListener(object2, object3));
		}

		// Token: 0x06000047 RID: 71
		[Register("addOnFailureListener", "(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_Handler")]
		public abstract Task AddOnFailureListener(Activity p0, IOnFailureListener p1);

		// Token: 0x06000048 RID: 72 RVA: 0x00002805 File Offset: 0x00000A05
		private static Delegate GetAddOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_Handler()
		{
			if (Task.cb_addOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_ == null)
			{
				Task.cb_addOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_AddOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_));
			}
			return Task.cb_addOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000282C File Offset: 0x00000A2C
		private static IntPtr n_AddOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnFailureListener object2 = Java.Lang.Object.GetObject<IOnFailureListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnFailureListener(object2));
		}

		// Token: 0x0600004A RID: 74
		[Register("addOnFailureListener", "(Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_Handler")]
		public abstract Task AddOnFailureListener(IOnFailureListener p0);

		// Token: 0x0600004B RID: 75 RVA: 0x00002854 File Offset: 0x00000A54
		private static Delegate GetAddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_Handler()
		{
			if (Task.cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_ == null)
			{
				Task.cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_));
			}
			return Task.cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002878 File Offset: 0x00000A78
		private static IntPtr n_AddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnFailureListener object3 = Java.Lang.Object.GetObject<IOnFailureListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnFailureListener(object2, object3));
		}

		// Token: 0x0600004D RID: 77
		[Register("addOnFailureListener", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_Handler")]
		public abstract Task AddOnFailureListener(IExecutor p0, IOnFailureListener p1);

		// Token: 0x0600004E RID: 78 RVA: 0x000028A9 File Offset: 0x00000AA9
		private static Delegate GetAddOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_Handler()
		{
			if (Task.cb_addOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_ == null)
			{
				Task.cb_addOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_));
			}
			return Task.cb_addOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000028D0 File Offset: 0x00000AD0
		private static IntPtr n_AddOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnSuccessListener object3 = Java.Lang.Object.GetObject<IOnSuccessListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnSuccessListener(object2, object3));
		}

		// Token: 0x06000050 RID: 80
		[Register("addOnSuccessListener", "(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_Handler")]
		public abstract Task AddOnSuccessListener(Activity p0, IOnSuccessListener p1);

		// Token: 0x06000051 RID: 81 RVA: 0x00002901 File Offset: 0x00000B01
		private static Delegate GetAddOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_Handler()
		{
			if (Task.cb_addOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_ == null)
			{
				Task.cb_addOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_AddOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_));
			}
			return Task.cb_addOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002928 File Offset: 0x00000B28
		private static IntPtr n_AddOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnSuccessListener object2 = Java.Lang.Object.GetObject<IOnSuccessListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnSuccessListener(object2));
		}

		// Token: 0x06000053 RID: 83
		[Register("addOnSuccessListener", "(Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_Handler")]
		public abstract Task AddOnSuccessListener(IOnSuccessListener p0);

		// Token: 0x06000054 RID: 84 RVA: 0x00002950 File Offset: 0x00000B50
		private static Delegate GetAddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_Handler()
		{
			if (Task.cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_ == null)
			{
				Task.cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_AddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_));
			}
			return Task.cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002974 File Offset: 0x00000B74
		private static IntPtr n_AddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnSuccessListener object3 = Java.Lang.Object.GetObject<IOnSuccessListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddOnSuccessListener(object2, object3));
		}

		// Token: 0x06000056 RID: 86
		[Register("addOnSuccessListener", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_Handler")]
		public abstract Task AddOnSuccessListener(IExecutor p0, IOnSuccessListener p1);

		// Token: 0x06000057 RID: 87 RVA: 0x000029A5 File Offset: 0x00000BA5
		private static Delegate GetContinueWith_Lcom_google_android_gms_tasks_Continuation_Handler()
		{
			if (Task.cb_continueWith_Lcom_google_android_gms_tasks_Continuation_ == null)
			{
				Task.cb_continueWith_Lcom_google_android_gms_tasks_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_ContinueWith_Lcom_google_android_gms_tasks_Continuation_));
			}
			return Task.cb_continueWith_Lcom_google_android_gms_tasks_Continuation_;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000029CC File Offset: 0x00000BCC
		private static IntPtr n_ContinueWith_Lcom_google_android_gms_tasks_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ContinueWith(object2));
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000029F4 File Offset: 0x00000BF4
		[Register("continueWith", "(Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", "GetContinueWith_Lcom_google_android_gms_tasks_Continuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TContinuationResult"
		})]
		public unsafe virtual Task ContinueWith(IContinuation p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("continueWith.(Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002A6C File Offset: 0x00000C6C
		private static Delegate GetContinueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_Handler()
		{
			if (Task.cb_continueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_ == null)
			{
				Task.cb_continueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_ContinueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_));
			}
			return Task.cb_continueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002A90 File Offset: 0x00000C90
		private static IntPtr n_ContinueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ContinueWith(object2, object3));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002AC4 File Offset: 0x00000CC4
		[Register("continueWith", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", "GetContinueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TContinuationResult"
		})]
		public unsafe virtual Task ContinueWith(IExecutor p0, IContinuation p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("continueWith.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002B6C File Offset: 0x00000D6C
		private static Delegate GetContinueWithTask_Lcom_google_android_gms_tasks_Continuation_Handler()
		{
			if (Task.cb_continueWithTask_Lcom_google_android_gms_tasks_Continuation_ == null)
			{
				Task.cb_continueWithTask_Lcom_google_android_gms_tasks_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_ContinueWithTask_Lcom_google_android_gms_tasks_Continuation_));
			}
			return Task.cb_continueWithTask_Lcom_google_android_gms_tasks_Continuation_;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002B90 File Offset: 0x00000D90
		private static IntPtr n_ContinueWithTask_Lcom_google_android_gms_tasks_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContinuation object2 = Java.Lang.Object.GetObject<IContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ContinueWithTask(object2));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[Register("continueWithTask", "(Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", "GetContinueWithTask_Lcom_google_android_gms_tasks_Continuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TContinuationResult"
		})]
		public unsafe virtual Task ContinueWithTask(IContinuation p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("continueWithTask.(Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002C30 File Offset: 0x00000E30
		private static Delegate GetContinueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_Handler()
		{
			if (Task.cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_ == null)
			{
				Task.cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_ContinueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_));
			}
			return Task.cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002C54 File Offset: 0x00000E54
		private static IntPtr n_ContinueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ContinueWithTask(object2, object3));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002C88 File Offset: 0x00000E88
		[Register("continueWithTask", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", "GetContinueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TContinuationResult"
		})]
		public unsafe virtual Task ContinueWithTask(IExecutor p0, IContinuation p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("continueWithTask.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/Continuation;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002D30 File Offset: 0x00000F30
		private static Delegate GetGetResult_Ljava_lang_Class_Handler()
		{
			if (Task.cb_getResult_Ljava_lang_Class_ == null)
			{
				Task.cb_getResult_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_GetResult_Ljava_lang_Class_));
			}
			return Task.cb_getResult_Ljava_lang_Class_;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002D54 File Offset: 0x00000F54
		private static IntPtr n_GetResult_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetResult(object2));
		}

		// Token: 0x06000065 RID: 101
		[Register("getResult", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetResult_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"X extends java.lang.Throwable"
		})]
		public abstract Java.Lang.Object GetResult(Class p0);

		// Token: 0x06000066 RID: 102 RVA: 0x00002D7C File Offset: 0x00000F7C
		private static Delegate GetOnSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_Handler()
		{
			if (Task.cb_onSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_ == null)
			{
				Task.cb_onSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Task.n_OnSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_));
			}
			return Task.cb_onSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002DA0 File Offset: 0x00000FA0
		private static IntPtr n_OnSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISuccessContinuation object2 = Java.Lang.Object.GetObject<ISuccessContinuation>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnSuccessTask(object2));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002DC8 File Offset: 0x00000FC8
		[Register("onSuccessTask", "(Lcom/google/android/gms/tasks/SuccessContinuation;)Lcom/google/android/gms/tasks/Task;", "GetOnSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TContinuationResult"
		})]
		public unsafe virtual Task OnSuccessTask(ISuccessContinuation p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("onSuccessTask.(Lcom/google/android/gms/tasks/SuccessContinuation;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002E40 File Offset: 0x00001040
		private static Delegate GetOnSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_Handler()
		{
			if (Task.cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_ == null)
			{
				Task.cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Task.n_OnSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_));
			}
			return Task.cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002E64 File Offset: 0x00001064
		private static IntPtr n_OnSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			Task @object = Java.Lang.Object.GetObject<Task>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_p0, JniHandleOwnership.DoNotTransfer);
			ISuccessContinuation object3 = Java.Lang.Object.GetObject<ISuccessContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnSuccessTask(object2, object3));
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002E98 File Offset: 0x00001098
		[Register("onSuccessTask", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/SuccessContinuation;)Lcom/google/android/gms/tasks/Task;", "GetOnSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TContinuationResult"
		})]
		public unsafe virtual Task OnSuccessTask(IExecutor p0, ISuccessContinuation p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(Task._members.InstanceMethods.InvokeVirtualObjectMethod("onSuccessTask.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/SuccessContinuation;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/Task", typeof(Task));

		// Token: 0x04000002 RID: 2
		private static Delegate cb_getException;

		// Token: 0x04000003 RID: 3
		private static Delegate cb_isCanceled;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_isComplete;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_isSuccessful;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getResult;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_addOnCanceledListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCanceledListener_;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_addOnCanceledListener_Lcom_google_android_gms_tasks_OnCanceledListener_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCanceledListener_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_addOnCompleteListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnCompleteListener_;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_addOnCompleteListener_Lcom_google_android_gms_tasks_OnCompleteListener_;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnCompleteListener_;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_addOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_addOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_addOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_addOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_continueWith_Lcom_google_android_gms_tasks_Continuation_;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_continueWith_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_continueWithTask_Lcom_google_android_gms_tasks_Continuation_;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_Continuation_;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getResult_Ljava_lang_Class_;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_onSuccessTask_Lcom_google_android_gms_tasks_SuccessContinuation_;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_SuccessContinuation_;
	}
}
