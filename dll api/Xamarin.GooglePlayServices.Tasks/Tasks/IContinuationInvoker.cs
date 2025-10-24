using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x0200000E RID: 14
	[Register("com/google/android/gms/tasks/Continuation", DoNotGenerateAcw = true)]
	internal class IContinuationInvoker : Java.Lang.Object, IContinuation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003650 File Offset: 0x00001850
		private static IntPtr java_class_ref
		{
			get
			{
				return IContinuationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003674 File Offset: 0x00001874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContinuationInvoker._members;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000367B File Offset: 0x0000187B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003683 File Offset: 0x00001883
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContinuationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000368F File Offset: 0x0000188F
		public static IContinuation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContinuation>(handle, transfer);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003698 File Offset: 0x00001898
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContinuationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.Continuation'.");
			}
			return handle;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000036C3 File Offset: 0x000018C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000036F4 File Offset: 0x000018F4
		public IContinuationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContinuationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000372C File Offset: 0x0000192C
		private static Delegate GetThen_Lcom_google_android_gms_tasks_Task_Handler()
		{
			if (IContinuationInvoker.cb_then_Lcom_google_android_gms_tasks_Task_ == null)
			{
				IContinuationInvoker.cb_then_Lcom_google_android_gms_tasks_Task_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContinuationInvoker.n_Then_Lcom_google_android_gms_tasks_Task_));
			}
			return IContinuationInvoker.cb_then_Lcom_google_android_gms_tasks_Task_;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003750 File Offset: 0x00001950
		private static IntPtr n_Then_Lcom_google_android_gms_tasks_Task_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			IContinuation @object = Java.Lang.Object.GetObject<IContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Task object2 = Java.Lang.Object.GetObject<Task>(native_task, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Then(object2));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003778 File Offset: 0x00001978
		public unsafe Java.Lang.Object Then(Task task)
		{
			if (this.id_then_Lcom_google_android_gms_tasks_Task_ == IntPtr.Zero)
			{
				this.id_then_Lcom_google_android_gms_tasks_Task_ = JNIEnv.GetMethodID(this.class_ref, "then", "(Lcom/google/android/gms/tasks/Task;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((task == null) ? IntPtr.Zero : task.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_then_Lcom_google_android_gms_tasks_Task_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000024 RID: 36
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/Continuation", typeof(IContinuationInvoker));

		// Token: 0x04000025 RID: 37
		private IntPtr class_ref;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_then_Lcom_google_android_gms_tasks_Task_;

		// Token: 0x04000027 RID: 39
		private IntPtr id_then_Lcom_google_android_gms_tasks_Task_;
	}
}
