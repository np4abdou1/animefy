using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x02000017 RID: 23
	[Register("com/google/android/gms/ads/OnAdInspectorClosedListener", DoNotGenerateAcw = true)]
	internal class IOnAdInspectorClosedListenerInvoker : Java.Lang.Object, IOnAdInspectorClosedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003E2C File Offset: 0x0000202C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnAdInspectorClosedListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003E50 File Offset: 0x00002050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnAdInspectorClosedListenerInvoker._members;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003E57 File Offset: 0x00002057
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
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003E5F File Offset: 0x0000205F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnAdInspectorClosedListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003E6B File Offset: 0x0000206B
		public static IOnAdInspectorClosedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnAdInspectorClosedListener>(handle, transfer);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003E74 File Offset: 0x00002074
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnAdInspectorClosedListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.OnAdInspectorClosedListener'.");
			}
			return handle;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003E9F File Offset: 0x0000209F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003ED0 File Offset: 0x000020D0
		public IOnAdInspectorClosedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnAdInspectorClosedListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003F08 File Offset: 0x00002108
		private static Delegate GetOnAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_Handler()
		{
			if (IOnAdInspectorClosedListenerInvoker.cb_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_ == null)
			{
				IOnAdInspectorClosedListenerInvoker.cb_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnAdInspectorClosedListenerInvoker.n_OnAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_));
			}
			return IOnAdInspectorClosedListenerInvoker.cb_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003F2C File Offset: 0x0000212C
		private static void n_OnAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnAdInspectorClosedListener @object = Java.Lang.Object.GetObject<IOnAdInspectorClosedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdInspectorError object2 = Java.Lang.Object.GetObject<AdInspectorError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdInspectorClosed(object2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003F50 File Offset: 0x00002150
		public unsafe void OnAdInspectorClosed(AdInspectorError p0)
		{
			if (this.id_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_ == IntPtr.Zero)
			{
				this.id_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_ = JNIEnv.GetMethodID(this.class_ref, "onAdInspectorClosed", "(Lcom/google/android/gms/ads/AdInspectorError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_, ptr);
		}

		// Token: 0x04000029 RID: 41
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/OnAdInspectorClosedListener", typeof(IOnAdInspectorClosedListenerInvoker));

		// Token: 0x0400002A RID: 42
		private IntPtr class_ref;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_;

		// Token: 0x0400002C RID: 44
		private IntPtr id_onAdInspectorClosed_Lcom_google_android_gms_ads_AdInspectorError_;
	}
}
