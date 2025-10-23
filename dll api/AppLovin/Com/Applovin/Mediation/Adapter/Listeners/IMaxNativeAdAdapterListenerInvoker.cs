using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Mediation.NativeAds;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x0200011F RID: 287
	[Register("com/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener", DoNotGenerateAcw = true)]
	internal class IMaxNativeAdAdapterListenerInvoker : Java.Lang.Object, IMaxNativeAdAdapterListener, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00021A00 File Offset: 0x0001FC00
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxNativeAdAdapterListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00021A24 File Offset: 0x0001FC24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxNativeAdAdapterListenerInvoker._members;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00021A2B File Offset: 0x0001FC2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00021A33 File Offset: 0x0001FC33
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxNativeAdAdapterListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00021A3F File Offset: 0x0001FC3F
		public static IMaxNativeAdAdapterListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(handle, transfer);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00021A48 File Offset: 0x0001FC48
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxNativeAdAdapterListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxNativeAdAdapterListener'.");
			}
			return handle;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00021A73 File Offset: 0x0001FC73
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		public IMaxNativeAdAdapterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxNativeAdAdapterListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00021ADC File Offset: 0x0001FCDC
		private static Delegate GetOnNativeAdClickedHandler()
		{
			if (IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdClicked == null)
			{
				IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxNativeAdAdapterListenerInvoker.n_OnNativeAdClicked));
			}
			return IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdClicked;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00021B00 File Offset: 0x0001FD00
		private static void n_OnNativeAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNativeAdClicked();
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00021B0F File Offset: 0x0001FD0F
		public void OnNativeAdClicked()
		{
			if (this.id_onNativeAdClicked == IntPtr.Zero)
			{
				this.id_onNativeAdClicked = JNIEnv.GetMethodID(this.class_ref, "onNativeAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdClicked);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00021B4F File Offset: 0x0001FD4F
		private static Delegate GetOnNativeAdDisplayed_Landroid_os_Bundle_Handler()
		{
			if (IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdDisplayed_Landroid_os_Bundle_ == null)
			{
				IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdDisplayed_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxNativeAdAdapterListenerInvoker.n_OnNativeAdDisplayed_Landroid_os_Bundle_));
			}
			return IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdDisplayed_Landroid_os_Bundle_;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00021B74 File Offset: 0x0001FD74
		private static void n_OnNativeAdDisplayed_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxNativeAdAdapterListener @object = Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdDisplayed(object2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00021B98 File Offset: 0x0001FD98
		public unsafe void OnNativeAdDisplayed(Bundle p0)
		{
			if (this.id_onNativeAdDisplayed_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onNativeAdDisplayed_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onNativeAdDisplayed", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdDisplayed_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00021C0B File Offset: 0x0001FE0B
		private static Delegate GetOnNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxNativeAdAdapterListenerInvoker.n_OnNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00021C30 File Offset: 0x0001FE30
		private static void n_OnNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxNativeAdAdapterListener @object = Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdLoadFailed(object2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00021C54 File Offset: 0x0001FE54
		public unsafe void OnNativeAdLoadFailed(MaxAdapterError p0)
		{
			if (this.id_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onNativeAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00021CC7 File Offset: 0x0001FEC7
		private static Delegate GetOnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_Handler()
		{
			if (IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_ == null)
			{
				IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxNativeAdAdapterListenerInvoker.n_OnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_));
			}
			return IMaxNativeAdAdapterListenerInvoker.cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00021CEC File Offset: 0x0001FEEC
		private static void n_OnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxNativeAdAdapterListener @object = Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAd object2 = Java.Lang.Object.GetObject<MaxNativeAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdLoaded(object2, object3);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00021D18 File Offset: 0x0001FF18
		public unsafe void OnNativeAdLoaded(MaxNativeAd p0, Bundle p1)
		{
			if (this.id_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onNativeAdLoaded", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x0400044B RID: 1099
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener", typeof(IMaxNativeAdAdapterListenerInvoker));

		// Token: 0x0400044C RID: 1100
		private IntPtr class_ref;

		// Token: 0x0400044D RID: 1101
		private static Delegate cb_onNativeAdClicked;

		// Token: 0x0400044E RID: 1102
		private IntPtr id_onNativeAdClicked;

		// Token: 0x0400044F RID: 1103
		private static Delegate cb_onNativeAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000450 RID: 1104
		private IntPtr id_onNativeAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000451 RID: 1105
		private static Delegate cb_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000452 RID: 1106
		private IntPtr id_onNativeAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000453 RID: 1107
		private static Delegate cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_;

		// Token: 0x04000454 RID: 1108
		private IntPtr id_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAd_Landroid_os_Bundle_;
	}
}
