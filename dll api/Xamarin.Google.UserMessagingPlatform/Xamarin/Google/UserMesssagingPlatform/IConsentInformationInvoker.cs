using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200002D RID: 45
	[Register("com/google/android/ump/ConsentInformation", DoNotGenerateAcw = true)]
	internal class IConsentInformationInvoker : Java.Lang.Object, IConsentInformation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003C54 File Offset: 0x00001E54
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsentInformationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003C78 File Offset: 0x00001E78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsentInformationInvoker._members;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00003C7F File Offset: 0x00001E7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003C87 File Offset: 0x00001E87
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsentInformationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003C93 File Offset: 0x00001E93
		public static IConsentInformation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsentInformation>(handle, transfer);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003C9C File Offset: 0x00001E9C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsentInformationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentInformation'.");
			}
			return handle;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003CC7 File Offset: 0x00001EC7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public IConsentInformationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsentInformationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003D30 File Offset: 0x00001F30
		private static Delegate GetGetConsentStatusHandler()
		{
			if (IConsentInformationInvoker.cb_getConsentStatus == null)
			{
				IConsentInformationInvoker.cb_getConsentStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IConsentInformationInvoker.n_GetConsentStatus));
			}
			return IConsentInformationInvoker.cb_getConsentStatus;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003D54 File Offset: 0x00001F54
		private static int n_GetConsentStatus(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IConsentInformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsentStatus;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00003D63 File Offset: 0x00001F63
		public int ConsentStatus
		{
			get
			{
				if (this.id_getConsentStatus == IntPtr.Zero)
				{
					this.id_getConsentStatus = JNIEnv.GetMethodID(this.class_ref, "getConsentStatus", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getConsentStatus);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003DA3 File Offset: 0x00001FA3
		private static Delegate GetIsConsentFormAvailableHandler()
		{
			if (IConsentInformationInvoker.cb_isConsentFormAvailable == null)
			{
				IConsentInformationInvoker.cb_isConsentFormAvailable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IConsentInformationInvoker.n_IsConsentFormAvailable));
			}
			return IConsentInformationInvoker.cb_isConsentFormAvailable;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003DC7 File Offset: 0x00001FC7
		private static bool n_IsConsentFormAvailable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IConsentInformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConsentFormAvailable;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00003DD6 File Offset: 0x00001FD6
		public bool IsConsentFormAvailable
		{
			get
			{
				if (this.id_isConsentFormAvailable == IntPtr.Zero)
				{
					this.id_isConsentFormAvailable = JNIEnv.GetMethodID(this.class_ref, "isConsentFormAvailable", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isConsentFormAvailable);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003E16 File Offset: 0x00002016
		private static Delegate GetRequestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_Handler()
		{
			if (IConsentInformationInvoker.cb_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_ == null)
			{
				IConsentInformationInvoker.cb_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(IConsentInformationInvoker.n_RequestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_));
			}
			return IConsentInformationInvoker.cb_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003E3C File Offset: 0x0000203C
		private static void n_RequestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			IConsentInformation @object = Java.Lang.Object.GetObject<IConsentInformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			ConsentRequestParameters object3 = Java.Lang.Object.GetObject<ConsentRequestParameters>(native_p1, JniHandleOwnership.DoNotTransfer);
			IConsentInformationOnConsentInfoUpdateSuccessListener object4 = Java.Lang.Object.GetObject<IConsentInformationOnConsentInfoUpdateSuccessListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			IConsentInformationOnConsentInfoUpdateFailureListener object5 = Java.Lang.Object.GetObject<IConsentInformationOnConsentInfoUpdateFailureListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.RequestConsentInfoUpdate(object2, object3, object4, object5);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003E7C File Offset: 0x0000207C
		public unsafe void RequestConsentInfoUpdate(Activity p0, ConsentRequestParameters p1, IConsentInformationOnConsentInfoUpdateSuccessListener p2, IConsentInformationOnConsentInfoUpdateFailureListener p3)
		{
			if (this.id_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_ == IntPtr.Zero)
			{
				this.id_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_ = JNIEnv.GetMethodID(this.class_ref, "requestConsentInfoUpdate", "(Landroid/app/Activity;Lcom/google/android/ump/ConsentRequestParameters;Lcom/google/android/ump/ConsentInformation$OnConsentInfoUpdateSuccessListener;Lcom/google/android/ump/ConsentInformation$OnConsentInfoUpdateFailureListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_, ptr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003F67 File Offset: 0x00002167
		private static Delegate GetResetHandler()
		{
			if (IConsentInformationInvoker.cb_reset == null)
			{
				IConsentInformationInvoker.cb_reset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConsentInformationInvoker.n_Reset));
			}
			return IConsentInformationInvoker.cb_reset;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003F8B File Offset: 0x0000218B
		private static void n_Reset(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConsentInformation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reset();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00003F9A File Offset: 0x0000219A
		public void Reset()
		{
			if (this.id_reset == IntPtr.Zero)
			{
				this.id_reset = JNIEnv.GetMethodID(this.class_ref, "reset", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_reset);
		}

		// Token: 0x04000051 RID: 81
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentInformation", typeof(IConsentInformationInvoker));

		// Token: 0x04000052 RID: 82
		private IntPtr class_ref;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_getConsentStatus;

		// Token: 0x04000054 RID: 84
		private IntPtr id_getConsentStatus;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_isConsentFormAvailable;

		// Token: 0x04000056 RID: 86
		private IntPtr id_isConsentFormAvailable;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_;

		// Token: 0x04000058 RID: 88
		private IntPtr id_requestConsentInfoUpdate_Landroid_app_Activity_Lcom_google_android_ump_ConsentRequestParameters_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateSuccessListener_Lcom_google_android_ump_ConsentInformation_OnConsentInfoUpdateFailureListener_;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_reset;

		// Token: 0x0400005A RID: 90
		private IntPtr id_reset;
	}
}
