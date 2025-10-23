using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200014D RID: 333
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListener", DoNotGenerateAcw = true)]
	internal class IAppLovinNativeAdLoadListenerInvoker : Java.Lang.Object, IAppLovinNativeAdLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinNativeAdLoadListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0002F114 File Offset: 0x0002D314
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinNativeAdLoadListenerInvoker._members;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0002F11B File Offset: 0x0002D31B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0002F123 File Offset: 0x0002D323
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinNativeAdLoadListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0002F12F File Offset: 0x0002D32F
		public static IAppLovinNativeAdLoadListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinNativeAdLoadListener>(handle, transfer);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0002F138 File Offset: 0x0002D338
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinNativeAdLoadListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.impl.sdk.nativeAd.AppLovinNativeAdLoadListener'.");
			}
			return handle;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002F163 File Offset: 0x0002D363
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002F194 File Offset: 0x0002D394
		public IAppLovinNativeAdLoadListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinNativeAdLoadListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		private static Delegate GetOnNativeAdLoadFailed_IHandler()
		{
			if (IAppLovinNativeAdLoadListenerInvoker.cb_onNativeAdLoadFailed_I == null)
			{
				IAppLovinNativeAdLoadListenerInvoker.cb_onNativeAdLoadFailed_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IAppLovinNativeAdLoadListenerInvoker.n_OnNativeAdLoadFailed_I));
			}
			return IAppLovinNativeAdLoadListenerInvoker.cb_onNativeAdLoadFailed_I;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		private static void n_OnNativeAdLoadFailed_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IAppLovinNativeAdLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNativeAdLoadFailed(p0);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0002F200 File Offset: 0x0002D400
		public unsafe void OnNativeAdLoadFailed(int p0)
		{
			if (this.id_onNativeAdLoadFailed_I == IntPtr.Zero)
			{
				this.id_onNativeAdLoadFailed_I = JNIEnv.GetMethodID(this.class_ref, "onNativeAdLoadFailed", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdLoadFailed_I, ptr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0002F264 File Offset: 0x0002D464
		private static Delegate GetOnNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_Handler()
		{
			if (IAppLovinNativeAdLoadListenerInvoker.cb_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ == null)
			{
				IAppLovinNativeAdLoadListenerInvoker.cb_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinNativeAdLoadListenerInvoker.n_OnNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_));
			}
			return IAppLovinNativeAdLoadListenerInvoker.cb_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0002F288 File Offset: 0x0002D488
		private static void n_OnNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinNativeAdLoadListener @object = Java.Lang.Object.GetObject<IAppLovinNativeAdLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinNativeAd object2 = Java.Lang.Object.GetObject<IAppLovinNativeAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdLoaded(object2);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0002F2AC File Offset: 0x0002D4AC
		public unsafe void OnNativeAdLoaded(IAppLovinNativeAd p0)
		{
			if (this.id_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ == IntPtr.Zero)
			{
				this.id_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_ = JNIEnv.GetMethodID(this.class_ref, "onNativeAdLoaded", "(Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_, ptr);
		}

		// Token: 0x04000554 RID: 1364
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdLoadListener", typeof(IAppLovinNativeAdLoadListenerInvoker));

		// Token: 0x04000555 RID: 1365
		private IntPtr class_ref;

		// Token: 0x04000556 RID: 1366
		private static Delegate cb_onNativeAdLoadFailed_I;

		// Token: 0x04000557 RID: 1367
		private IntPtr id_onNativeAdLoadFailed_I;

		// Token: 0x04000558 RID: 1368
		private static Delegate cb_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_;

		// Token: 0x04000559 RID: 1369
		private IntPtr id_onNativeAdLoaded_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAd_;
	}
}
