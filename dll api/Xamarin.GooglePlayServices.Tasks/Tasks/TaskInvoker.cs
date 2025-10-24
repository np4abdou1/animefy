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
	// Token: 0x0200001B RID: 27
	[Register("com/google/android/gms/tasks/Task", DoNotGenerateAcw = true)]
	internal class TaskInvoker : Task
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x000041B6 File Offset: 0x000023B6
		public TaskInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000041C0 File Offset: 0x000023C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TaskInvoker._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000041C7 File Offset: 0x000023C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TaskInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000041D4 File Offset: 0x000023D4
		public override Java.Lang.Exception Exception
		{
			[Register("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Exception>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getException.()Ljava/lang/Exception;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00004206 File Offset: 0x00002406
		public override bool IsCanceled
		{
			[Register("isCanceled", "()Z", "GetIsCanceledHandler")]
			get
			{
				return TaskInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isCanceled.()Z", this, null);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000421F File Offset: 0x0000241F
		public override bool IsComplete
		{
			[Register("isComplete", "()Z", "GetIsCompleteHandler")]
			get
			{
				return TaskInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isComplete.()Z", this, null);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00004238 File Offset: 0x00002438
		public override bool IsSuccessful
		{
			[Register("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get
			{
				return TaskInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isSuccessful.()Z", this, null);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004254 File Offset: 0x00002454
		protected override Java.Lang.Object RawResult
		{
			[Register("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getResult.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004288 File Offset: 0x00002488
		[Register("addOnFailureListener", "(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnFailureListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnFailureListener_Handler")]
		public unsafe override Task AddOnFailureListener(Activity p0, IOnFailureListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("addOnFailureListener.(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004328 File Offset: 0x00002528
		[Register("addOnFailureListener", "(Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnFailureListener_Lcom_google_android_gms_tasks_OnFailureListener_Handler")]
		public unsafe override Task AddOnFailureListener(IOnFailureListener p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("addOnFailureListener.(Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000043A0 File Offset: 0x000025A0
		[Register("addOnFailureListener", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnFailureListener_Handler")]
		public unsafe override Task AddOnFailureListener(IExecutor p0, IOnFailureListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("addOnFailureListener.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnFailureListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004448 File Offset: 0x00002648
		[Register("addOnSuccessListener", "(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnSuccessListener_Landroid_app_Activity_Lcom_google_android_gms_tasks_OnSuccessListener_Handler")]
		public unsafe override Task AddOnSuccessListener(Activity p0, IOnSuccessListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("addOnSuccessListener.(Landroid/app/Activity;Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000044E8 File Offset: 0x000026E8
		[Register("addOnSuccessListener", "(Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnSuccessListener_Lcom_google_android_gms_tasks_OnSuccessListener_Handler")]
		public unsafe override Task AddOnSuccessListener(IOnSuccessListener p0)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<Task>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("addOnSuccessListener.(Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004560 File Offset: 0x00002760
		[Register("addOnSuccessListener", "(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", "GetAddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_google_android_gms_tasks_OnSuccessListener_Handler")]
		public unsafe override Task AddOnSuccessListener(IExecutor p0, IOnSuccessListener p1)
		{
			Task @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Task>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("addOnSuccessListener.(Ljava/util/concurrent/Executor;Lcom/google/android/gms/tasks/OnSuccessListener;)Lcom/google/android/gms/tasks/Task;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004608 File Offset: 0x00002808
		[Register("getResult", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetResult_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"X extends java.lang.Throwable"
		})]
		public unsafe override Java.Lang.Object GetResult(Class p0)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TaskInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getResult.(Ljava/lang/Class;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000040 RID: 64
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/Task", typeof(TaskInvoker));
	}
}
