using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200002A RID: 42
	[Register("com/google/android/gms/common/api/internal/OnConnectionFailedListener", DoNotGenerateAcw = true)]
	internal class IOnConnectionFailedListenerInvoker : Java.Lang.Object, IOnConnectionFailedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00005A3C File Offset: 0x00003C3C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnConnectionFailedListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00005A60 File Offset: 0x00003C60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnConnectionFailedListenerInvoker._members;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00005A67 File Offset: 0x00003C67
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00005A6F File Offset: 0x00003C6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnConnectionFailedListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005A7B File Offset: 0x00003C7B
		public static IOnConnectionFailedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnConnectionFailedListener>(handle, transfer);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005A84 File Offset: 0x00003C84
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnConnectionFailedListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.OnConnectionFailedListener'.");
			}
			return handle;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005AAF File Offset: 0x00003CAF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public IOnConnectionFailedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnConnectionFailedListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005B18 File Offset: 0x00003D18
		private static Delegate GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler()
		{
			if (IOnConnectionFailedListenerInvoker.cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == null)
			{
				IOnConnectionFailedListenerInvoker.cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnConnectionFailedListenerInvoker.n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_));
			}
			return IOnConnectionFailedListenerInvoker.cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00005B3C File Offset: 0x00003D3C
		private static void n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnConnectionFailedListener @object = Java.Lang.Object.GetObject<IOnConnectionFailedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ConnectionResult object2 = Java.Lang.Object.GetObject<ConnectionResult>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnConnectionFailed(object2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00005B60 File Offset: 0x00003D60
		public unsafe void OnConnectionFailed(ConnectionResult p0)
		{
			if (this.id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == IntPtr.Zero)
			{
				this.id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNIEnv.GetMethodID(this.class_ref, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_, ptr);
		}

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/OnConnectionFailedListener", typeof(IOnConnectionFailedListenerInvoker));

		// Token: 0x04000045 RID: 69
		private IntPtr class_ref;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;

		// Token: 0x04000047 RID: 71
		private IntPtr id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
	}
}
