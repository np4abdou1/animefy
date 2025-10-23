using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Synchronization
{
	// Token: 0x02000043 RID: 67
	[Register("com/google/android/datatransport/runtime/synchronization/SynchronizationGuard", DoNotGenerateAcw = true)]
	internal class ISynchronizationGuardInvoker : Java.Lang.Object, ISynchronizationGuard, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00006480 File Offset: 0x00004680
		private static IntPtr java_class_ref
		{
			get
			{
				return ISynchronizationGuardInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000064A4 File Offset: 0x000046A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISynchronizationGuardInvoker._members;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000064AB File Offset: 0x000046AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000064B3 File Offset: 0x000046B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISynchronizationGuardInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000064BF File Offset: 0x000046BF
		public static ISynchronizationGuard GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISynchronizationGuard>(handle, transfer);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000064C8 File Offset: 0x000046C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISynchronizationGuardInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.synchronization.SynchronizationGuard'.");
			}
			return handle;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000064F3 File Offset: 0x000046F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006524 File Offset: 0x00004724
		public ISynchronizationGuardInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISynchronizationGuardInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000655C File Offset: 0x0000475C
		private static Delegate GetRunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_Handler()
		{
			if (ISynchronizationGuardInvoker.cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_ == null)
			{
				ISynchronizationGuardInvoker.cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISynchronizationGuardInvoker.n_RunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_));
			}
			return ISynchronizationGuardInvoker.cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00006580 File Offset: 0x00004780
		private static IntPtr n_RunCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISynchronizationGuard @object = Java.Lang.Object.GetObject<ISynchronizationGuard>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISynchronizationGuardCriticalSection object2 = Java.Lang.Object.GetObject<ISynchronizationGuardCriticalSection>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunCriticalSection(object2));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000065A8 File Offset: 0x000047A8
		public unsafe Java.Lang.Object RunCriticalSection(ISynchronizationGuardCriticalSection p0)
		{
			if (this.id_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_ == IntPtr.Zero)
			{
				this.id_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_ = JNIEnv.GetMethodID(this.class_ref, "runCriticalSection", "(Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000078 RID: 120
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/synchronization/SynchronizationGuard", typeof(ISynchronizationGuardInvoker));

		// Token: 0x04000079 RID: 121
		private IntPtr class_ref;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_;

		// Token: 0x0400007B RID: 123
		private IntPtr id_runCriticalSection_Lcom_google_android_datatransport_runtime_synchronization_SynchronizationGuard_CriticalSection_;
	}
}
