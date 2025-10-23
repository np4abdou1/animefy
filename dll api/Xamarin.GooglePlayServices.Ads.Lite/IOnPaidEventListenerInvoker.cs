using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x02000019 RID: 25
	[Register("com/google/android/gms/ads/OnPaidEventListener", DoNotGenerateAcw = true)]
	internal class IOnPaidEventListenerInvoker : Java.Lang.Object, IOnPaidEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003FE0 File Offset: 0x000021E0
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnPaidEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004004 File Offset: 0x00002204
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnPaidEventListenerInvoker._members;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000400B File Offset: 0x0000220B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00004013 File Offset: 0x00002213
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnPaidEventListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000401F File Offset: 0x0000221F
		public static IOnPaidEventListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnPaidEventListener>(handle, transfer);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004028 File Offset: 0x00002228
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnPaidEventListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.OnPaidEventListener'.");
			}
			return handle;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004053 File Offset: 0x00002253
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004084 File Offset: 0x00002284
		public IOnPaidEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnPaidEventListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000040BC File Offset: 0x000022BC
		private static Delegate GetOnPaidEvent_Lcom_google_android_gms_ads_AdValue_Handler()
		{
			if (IOnPaidEventListenerInvoker.cb_onPaidEvent_Lcom_google_android_gms_ads_AdValue_ == null)
			{
				IOnPaidEventListenerInvoker.cb_onPaidEvent_Lcom_google_android_gms_ads_AdValue_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnPaidEventListenerInvoker.n_OnPaidEvent_Lcom_google_android_gms_ads_AdValue_));
			}
			return IOnPaidEventListenerInvoker.cb_onPaidEvent_Lcom_google_android_gms_ads_AdValue_;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000040E0 File Offset: 0x000022E0
		private static void n_OnPaidEvent_Lcom_google_android_gms_ads_AdValue_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnPaidEventListener @object = Java.Lang.Object.GetObject<IOnPaidEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdValue object2 = Java.Lang.Object.GetObject<AdValue>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnPaidEvent(object2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004104 File Offset: 0x00002304
		public unsafe void OnPaidEvent(AdValue p0)
		{
			if (this.id_onPaidEvent_Lcom_google_android_gms_ads_AdValue_ == IntPtr.Zero)
			{
				this.id_onPaidEvent_Lcom_google_android_gms_ads_AdValue_ = JNIEnv.GetMethodID(this.class_ref, "onPaidEvent", "(Lcom/google/android/gms/ads/AdValue;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPaidEvent_Lcom_google_android_gms_ads_AdValue_, ptr);
		}

		// Token: 0x0400002D RID: 45
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/OnPaidEventListener", typeof(IOnPaidEventListenerInvoker));

		// Token: 0x0400002E RID: 46
		private IntPtr class_ref;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_onPaidEvent_Lcom_google_android_gms_ads_AdValue_;

		// Token: 0x04000030 RID: 48
		private IntPtr id_onPaidEvent_Lcom_google_android_gms_ads_AdValue_;
	}
}
