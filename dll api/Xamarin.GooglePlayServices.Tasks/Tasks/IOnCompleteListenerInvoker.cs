using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000012 RID: 18
	[Register("com/google/android/gms/tasks/OnCompleteListener", DoNotGenerateAcw = true)]
	internal class IOnCompleteListenerInvoker : Java.Lang.Object, IOnCompleteListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003978 File Offset: 0x00001B78
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnCompleteListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000399C File Offset: 0x00001B9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnCompleteListenerInvoker._members;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000039A3 File Offset: 0x00001BA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000039AB File Offset: 0x00001BAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnCompleteListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000039B7 File Offset: 0x00001BB7
		public static IOnCompleteListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnCompleteListener>(handle, transfer);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000039C0 File Offset: 0x00001BC0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnCompleteListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.OnCompleteListener'.");
			}
			return handle;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000039EB File Offset: 0x00001BEB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003A1C File Offset: 0x00001C1C
		public IOnCompleteListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnCompleteListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003A54 File Offset: 0x00001C54
		private static Delegate GetOnComplete_Lcom_google_android_gms_tasks_Task_Handler()
		{
			if (IOnCompleteListenerInvoker.cb_onComplete_Lcom_google_android_gms_tasks_Task_ == null)
			{
				IOnCompleteListenerInvoker.cb_onComplete_Lcom_google_android_gms_tasks_Task_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnCompleteListenerInvoker.n_OnComplete_Lcom_google_android_gms_tasks_Task_));
			}
			return IOnCompleteListenerInvoker.cb_onComplete_Lcom_google_android_gms_tasks_Task_;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003A78 File Offset: 0x00001C78
		private static void n_OnComplete_Lcom_google_android_gms_tasks_Task_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			IOnCompleteListener @object = Java.Lang.Object.GetObject<IOnCompleteListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Task object2 = Java.Lang.Object.GetObject<Task>(native_task, JniHandleOwnership.DoNotTransfer);
			@object.OnComplete(object2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003A9C File Offset: 0x00001C9C
		public unsafe void OnComplete(Task task)
		{
			if (this.id_onComplete_Lcom_google_android_gms_tasks_Task_ == IntPtr.Zero)
			{
				this.id_onComplete_Lcom_google_android_gms_tasks_Task_ = JNIEnv.GetMethodID(this.class_ref, "onComplete", "(Lcom/google/android/gms/tasks/Task;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((task == null) ? IntPtr.Zero : task.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onComplete_Lcom_google_android_gms_tasks_Task_, ptr);
		}

		// Token: 0x0400002C RID: 44
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/OnCompleteListener", typeof(IOnCompleteListenerInvoker));

		// Token: 0x0400002D RID: 45
		private IntPtr class_ref;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_onComplete_Lcom_google_android_gms_tasks_Task_;

		// Token: 0x0400002F RID: 47
		private IntPtr id_onComplete_Lcom_google_android_gms_tasks_Task_;
	}
}
