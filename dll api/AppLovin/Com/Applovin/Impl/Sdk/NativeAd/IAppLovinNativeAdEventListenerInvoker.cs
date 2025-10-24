using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000149 RID: 329
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListener", DoNotGenerateAcw = true)]
	internal class IAppLovinNativeAdEventListenerInvoker : Java.Lang.Object, IAppLovinNativeAdEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinNativeAdEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0002EED8 File Offset: 0x0002D0D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinNativeAdEventListenerInvoker._members;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x0002EEDF File Offset: 0x0002D0DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0002EEE7 File Offset: 0x0002D0E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinNativeAdEventListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0002EEF3 File Offset: 0x0002D0F3
		public static IAppLovinNativeAdEventListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinNativeAdEventListener>(handle, transfer);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0002EEFC File Offset: 0x0002D0FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinNativeAdEventListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.impl.sdk.nativeAd.AppLovinNativeAdEventListener'.");
			}
			return handle;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0002EF27 File Offset: 0x0002D127
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0002EF58 File Offset: 0x0002D158
		public IAppLovinNativeAdEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinNativeAdEventListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0002EF90 File Offset: 0x0002D190
		private static Delegate GetOnNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_Handler()
		{
			if (IAppLovinNativeAdEventListenerInvoker.cb_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ == null)
			{
				IAppLovinNativeAdEventListenerInvoker.cb_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinNativeAdEventListenerInvoker.n_OnNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_));
			}
			return IAppLovinNativeAdEventListenerInvoker.cb_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		private static void n_OnNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinNativeAdEventListener @object = Java.Lang.Object.GetObject<IAppLovinNativeAdEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinNativeAd object2 = Java.Lang.Object.GetObject<IAppLovinNativeAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdClicked(object2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0002EFD8 File Offset: 0x0002D1D8
		public unsafe void OnNativeAdClicked(IAppLovinNativeAd p0)
		{
			if (this.id_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ == IntPtr.Zero)
			{
				this.id_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ = JNIEnv.GetMethodID(this.class_ref, "onNativeAdClicked", "(Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_, ptr);
		}

		// Token: 0x0400054D RID: 1357
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListener", typeof(IAppLovinNativeAdEventListenerInvoker));

		// Token: 0x0400054E RID: 1358
		private IntPtr class_ref;

		// Token: 0x0400054F RID: 1359
		private static Delegate cb_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_;

		// Token: 0x04000550 RID: 1360
		private IntPtr id_onNativeAdClicked_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_;
	}
}
