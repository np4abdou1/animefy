using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000030 RID: 48
	[Register("com/google/android/gms/common/api/internal/zau", DoNotGenerateAcw = true)]
	internal class IZauInvoker : Java.Lang.Object, IZau, GoogleApiClient.IConnectionCallbacks, IConnectionCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00005F34 File Offset: 0x00004134
		private static IntPtr java_class_ref
		{
			get
			{
				return IZauInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005F58 File Offset: 0x00004158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IZauInvoker._members;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00005F5F File Offset: 0x0000415F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00005F67 File Offset: 0x00004167
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IZauInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005F73 File Offset: 0x00004173
		public static IZau GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IZau>(handle, transfer);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005F7C File Offset: 0x0000417C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IZauInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.zau'.");
			}
			return handle;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005FA7 File Offset: 0x000041A7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005FD8 File Offset: 0x000041D8
		public IZauInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IZauInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006010 File Offset: 0x00004210
		private static Delegate GetZaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_ZHandler()
		{
			if (IZauInvoker.cb_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z == null)
			{
				IZauInvoker.cb_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_V(IZauInvoker.n_Zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z));
			}
			return IZauInvoker.cb_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006034 File Offset: 0x00004234
		private static void n_Zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			IZau @object = Java.Lang.Object.GetObject<IZau>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ConnectionResult object2 = Java.Lang.Object.GetObject<ConnectionResult>(native_p0, JniHandleOwnership.DoNotTransfer);
			Api object3 = Java.Lang.Object.GetObject<Api>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Zaa(object2, object3, p2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006064 File Offset: 0x00004264
		public unsafe void Zaa(ConnectionResult p0, Api p1, bool p2)
		{
			if (this.id_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z == IntPtr.Zero)
			{
				this.id_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z = JNIEnv.GetMethodID(this.class_ref, "zaa", "(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/common/api/Api;Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z, ptr);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000610F File Offset: 0x0000430F
		private static Delegate GetOnConnected_Landroid_os_Bundle_Handler()
		{
			if (IZauInvoker.cb_onConnected_Landroid_os_Bundle_ == null)
			{
				IZauInvoker.cb_onConnected_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IZauInvoker.n_OnConnected_Landroid_os_Bundle_));
			}
			return IZauInvoker.cb_onConnected_Landroid_os_Bundle_;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006134 File Offset: 0x00004334
		private static void n_OnConnected_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConnectionCallbacks @object = Java.Lang.Object.GetObject<IZau>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnConnected(object2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006158 File Offset: 0x00004358
		public unsafe void OnConnected(Bundle p0)
		{
			if (this.id_onConnected_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onConnected_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onConnected", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnected_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000061CB File Offset: 0x000043CB
		private static Delegate GetOnConnectionSuspended_IHandler()
		{
			if (IZauInvoker.cb_onConnectionSuspended_I == null)
			{
				IZauInvoker.cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IZauInvoker.n_OnConnectionSuspended_I));
			}
			return IZauInvoker.cb_onConnectionSuspended_I;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000061EF File Offset: 0x000043EF
		private static void n_OnConnectionSuspended_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IZau>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnConnectionSuspended(p0);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006200 File Offset: 0x00004400
		public unsafe void OnConnectionSuspended(int p0)
		{
			if (this.id_onConnectionSuspended_I == IntPtr.Zero)
			{
				this.id_onConnectionSuspended_I = JNIEnv.GetMethodID(this.class_ref, "onConnectionSuspended", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnectionSuspended_I, ptr);
		}

		// Token: 0x04000050 RID: 80
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zau", typeof(IZauInvoker));

		// Token: 0x04000051 RID: 81
		private IntPtr class_ref;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z;

		// Token: 0x04000053 RID: 83
		private IntPtr id_zaa_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_common_api_Api_Z;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_onConnected_Landroid_os_Bundle_;

		// Token: 0x04000055 RID: 85
		private IntPtr id_onConnected_Landroid_os_Bundle_;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_onConnectionSuspended_I;

		// Token: 0x04000057 RID: 87
		private IntPtr id_onConnectionSuspended_I;
	}
}
