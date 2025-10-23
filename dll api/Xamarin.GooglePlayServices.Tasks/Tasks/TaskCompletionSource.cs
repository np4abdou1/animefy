using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x0200000A RID: 10
	[Register("com/google/android/gms/tasks/TaskCompletionSource", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"TResult"
	})]
	public class TaskCompletionSource : Java.Lang.Object
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002F5B File Offset: 0x0000115B
		public virtual Task Task
		{
			get
			{
				return this.GetTask();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002F64 File Offset: 0x00001164
		internal static IntPtr class_ref
		{
			get
			{
				return TaskCompletionSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002F88 File Offset: 0x00001188
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TaskCompletionSource._members;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002F90 File Offset: 0x00001190
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TaskCompletionSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002FB4 File Offset: 0x000011B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TaskCompletionSource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000020B4 File Offset: 0x000002B4
		protected TaskCompletionSource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002FC0 File Offset: 0x000011C0
		[Register(".ctor", "()V", "")]
		public TaskCompletionSource() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TaskCompletionSource._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TaskCompletionSource._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003030 File Offset: 0x00001230
		[Register(".ctor", "(Lcom/google/android/gms/tasks/CancellationToken;)V", "")]
		public unsafe TaskCompletionSource(CancellationToken cancellationToken) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cancellationToken == null) ? IntPtr.Zero : cancellationToken.Handle);
				base.SetHandle(TaskCompletionSource._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/tasks/CancellationToken;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TaskCompletionSource._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/tasks/CancellationToken;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cancellationToken);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000030E0 File Offset: 0x000012E0
		private static Delegate GetGetTaskHandler()
		{
			if (TaskCompletionSource.cb_getTask == null)
			{
				TaskCompletionSource.cb_getTask = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TaskCompletionSource.n_GetTask));
			}
			return TaskCompletionSource.cb_getTask;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003104 File Offset: 0x00001304
		private static IntPtr n_GetTask(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TaskCompletionSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetTask());
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003118 File Offset: 0x00001318
		[Register("getTask", "()Lcom/google/android/gms/tasks/Task;", "GetGetTaskHandler")]
		public virtual Task GetTask()
		{
			return Java.Lang.Object.GetObject<Task>(TaskCompletionSource._members.InstanceMethods.InvokeVirtualObjectMethod("getTask.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000314A File Offset: 0x0000134A
		private static Delegate GetSetException_Ljava_lang_Exception_Handler()
		{
			if (TaskCompletionSource.cb_setException_Ljava_lang_Exception_ == null)
			{
				TaskCompletionSource.cb_setException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TaskCompletionSource.n_SetException_Ljava_lang_Exception_));
			}
			return TaskCompletionSource.cb_setException_Ljava_lang_Exception_;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003170 File Offset: 0x00001370
		private static void n_SetException_Ljava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			TaskCompletionSource @object = Java.Lang.Object.GetObject<TaskCompletionSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object2 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.SetException(object2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003194 File Offset: 0x00001394
		[Register("setException", "(Ljava/lang/Exception;)V", "GetSetException_Ljava_lang_Exception_Handler")]
		public unsafe virtual void SetException(Java.Lang.Exception e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				TaskCompletionSource._members.InstanceMethods.InvokeVirtualVoidMethod("setException.(Ljava/lang/Exception;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000031F8 File Offset: 0x000013F8
		private static Delegate GetSetResult_Ljava_lang_Object_Handler()
		{
			if (TaskCompletionSource.cb_setResult_Ljava_lang_Object_ == null)
			{
				TaskCompletionSource.cb_setResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TaskCompletionSource.n_SetResult_Ljava_lang_Object_));
			}
			return TaskCompletionSource.cb_setResult_Ljava_lang_Object_;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000321C File Offset: 0x0000141C
		private static void n_SetResult_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			TaskCompletionSource @object = Java.Lang.Object.GetObject<TaskCompletionSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			@object.SetResult(object2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003240 File Offset: 0x00001440
		[Register("setResult", "(Ljava/lang/Object;)V", "GetSetResult_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetResult(Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				TaskCompletionSource._members.InstanceMethods.InvokeVirtualVoidMethod("setResult.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(result);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000032A4 File Offset: 0x000014A4
		private static Delegate GetTrySetException_Ljava_lang_Exception_Handler()
		{
			if (TaskCompletionSource.cb_trySetException_Ljava_lang_Exception_ == null)
			{
				TaskCompletionSource.cb_trySetException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(TaskCompletionSource.n_TrySetException_Ljava_lang_Exception_));
			}
			return TaskCompletionSource.cb_trySetException_Ljava_lang_Exception_;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000032C8 File Offset: 0x000014C8
		private static bool n_TrySetException_Ljava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			TaskCompletionSource @object = Java.Lang.Object.GetObject<TaskCompletionSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object2 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.TrySetException(object2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000032EC File Offset: 0x000014EC
		[Register("trySetException", "(Ljava/lang/Exception;)Z", "GetTrySetException_Ljava_lang_Exception_Handler")]
		public unsafe virtual bool TrySetException(Java.Lang.Exception e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = TaskCompletionSource._members.InstanceMethods.InvokeVirtualBooleanMethod("trySetException.(Ljava/lang/Exception;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003354 File Offset: 0x00001554
		private static Delegate GetTrySetResult_Ljava_lang_Object_Handler()
		{
			if (TaskCompletionSource.cb_trySetResult_Ljava_lang_Object_ == null)
			{
				TaskCompletionSource.cb_trySetResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(TaskCompletionSource.n_TrySetResult_Ljava_lang_Object_));
			}
			return TaskCompletionSource.cb_trySetResult_Ljava_lang_Object_;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003378 File Offset: 0x00001578
		private static bool n_TrySetResult_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			TaskCompletionSource @object = Java.Lang.Object.GetObject<TaskCompletionSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			return @object.TrySetResult(object2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000339C File Offset: 0x0000159C
		[Register("trySetResult", "(Ljava/lang/Object;)Z", "GetTrySetResult_Ljava_lang_Object_Handler")]
		public unsafe virtual bool TrySetResult(Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			bool result2;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result2 = TaskCompletionSource._members.InstanceMethods.InvokeVirtualBooleanMethod("trySetResult.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(result);
			}
			return result2;
		}

		// Token: 0x0400001A RID: 26
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/TaskCompletionSource", typeof(TaskCompletionSource));

		// Token: 0x0400001B RID: 27
		private static Delegate cb_getTask;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_setException_Ljava_lang_Exception_;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_setResult_Ljava_lang_Object_;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_trySetException_Ljava_lang_Exception_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_trySetResult_Ljava_lang_Object_;
	}
}
