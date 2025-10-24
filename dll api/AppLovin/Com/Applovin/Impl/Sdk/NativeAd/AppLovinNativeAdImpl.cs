using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Com.Iab.Omid.Library.Applovin.Adsession;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000140 RID: 320
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl", DoNotGenerateAcw = true)]
	public class AppLovinNativeAdImpl : AppLovinAdBase, IAppLovinNativeAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0002CDEC File Offset: 0x0002AFEC
		internal new static IntPtr class_ref
		{
			get
			{
				return AppLovinNativeAdImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0002CE10 File Offset: 0x0002B010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinNativeAdImpl._members;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x0002CE18 File Offset: 0x0002B018
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinNativeAdImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0002CE3C File Offset: 0x0002B03C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinNativeAdImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00024427 File Offset: 0x00022627
		protected AppLovinNativeAdImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0002CE48 File Offset: 0x0002B048
		private static Delegate GetGetAdIdNumberHandler()
		{
			if (AppLovinNativeAdImpl.cb_getAdIdNumber == null)
			{
				AppLovinNativeAdImpl.cb_getAdIdNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AppLovinNativeAdImpl.n_GetAdIdNumber));
			}
			return AppLovinNativeAdImpl.cb_getAdIdNumber;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0002CE6C File Offset: 0x0002B06C
		private static long n_GetAdIdNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdIdNumber;
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0002CE7B File Offset: 0x0002B07B
		public override long AdIdNumber
		{
			[Register("getAdIdNumber", "()J", "GetGetAdIdNumberHandler")]
			get
			{
				return AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualInt64Method("getAdIdNumber.()J", this, null);
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0002CE94 File Offset: 0x0002B094
		private static Delegate GetGetAdvertiserHandler()
		{
			if (AppLovinNativeAdImpl.cb_getAdvertiser == null)
			{
				AppLovinNativeAdImpl.cb_getAdvertiser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetAdvertiser));
			}
			return AppLovinNativeAdImpl.cb_getAdvertiser;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		private static IntPtr n_GetAdvertiser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Advertiser);
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0002CECC File Offset: 0x0002B0CC
		public virtual string Advertiser
		{
			[Register("getAdvertiser", "()Ljava/lang/String;", "GetGetAdvertiserHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdvertiser.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0002CEFE File Offset: 0x0002B0FE
		private static Delegate GetGetBodyHandler()
		{
			if (AppLovinNativeAdImpl.cb_getBody == null)
			{
				AppLovinNativeAdImpl.cb_getBody = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetBody));
			}
			return AppLovinNativeAdImpl.cb_getBody;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0002CF22 File Offset: 0x0002B122
		private static IntPtr n_GetBody(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Body);
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0002CF38 File Offset: 0x0002B138
		public virtual string Body
		{
			[Register("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getBody.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0002CF6A File Offset: 0x0002B16A
		private static Delegate GetGetCachePrefixHandler()
		{
			if (AppLovinNativeAdImpl.cb_getCachePrefix == null)
			{
				AppLovinNativeAdImpl.cb_getCachePrefix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetCachePrefix));
			}
			return AppLovinNativeAdImpl.cb_getCachePrefix;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0002CF8E File Offset: 0x0002B18E
		private static IntPtr n_GetCachePrefix(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CachePrefix);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		public virtual string CachePrefix
		{
			[Register("getCachePrefix", "()Ljava/lang/String;", "GetGetCachePrefixHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getCachePrefix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0002CFD6 File Offset: 0x0002B1D6
		private static Delegate GetGetCallToActionHandler()
		{
			if (AppLovinNativeAdImpl.cb_getCallToAction == null)
			{
				AppLovinNativeAdImpl.cb_getCallToAction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetCallToAction));
			}
			return AppLovinNativeAdImpl.cb_getCallToAction;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0002CFFA File Offset: 0x0002B1FA
		private static IntPtr n_GetCallToAction(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CallToAction);
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0002D010 File Offset: 0x0002B210
		public virtual string CallToAction
		{
			[Register("getCallToAction", "()Ljava/lang/String;", "GetGetCallToActionHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getCallToAction.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0002D042 File Offset: 0x0002B242
		private static Delegate GetGetClickHandlerHandler()
		{
			if (AppLovinNativeAdImpl.cb_getClickHandler == null)
			{
				AppLovinNativeAdImpl.cb_getClickHandler = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetClickHandler));
			}
			return AppLovinNativeAdImpl.cb_getClickHandler;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0002D066 File Offset: 0x0002B266
		private static IntPtr n_GetClickHandler(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClickHandler);
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0002D07C File Offset: 0x0002B27C
		public virtual Java.Lang.Object ClickHandler
		{
			[Register("getClickHandler", "()Ljava/lang/Object;", "GetGetClickHandlerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getClickHandler.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0002D0AE File Offset: 0x0002B2AE
		private static Delegate GetGetIconUriHandler()
		{
			if (AppLovinNativeAdImpl.cb_getIconUri == null)
			{
				AppLovinNativeAdImpl.cb_getIconUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetIconUri));
			}
			return AppLovinNativeAdImpl.cb_getIconUri;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0002D0D2 File Offset: 0x0002B2D2
		private static IntPtr n_GetIconUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconUri);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0002D0E6 File Offset: 0x0002B2E6
		private static Delegate GetSetIconUri_Landroid_net_Uri_Handler()
		{
			if (AppLovinNativeAdImpl.cb_setIconUri_Landroid_net_Uri_ == null)
			{
				AppLovinNativeAdImpl.cb_setIconUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinNativeAdImpl.n_SetIconUri_Landroid_net_Uri_));
			}
			return AppLovinNativeAdImpl.cb_setIconUri_Landroid_net_Uri_;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0002D10C File Offset: 0x0002B30C
		private static void n_SetIconUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinNativeAdImpl @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.IconUri = object2;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0002D130 File Offset: 0x0002B330
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x0002D164 File Offset: 0x0002B364
		public unsafe virtual Android.Net.Uri IconUri
		{
			[Register("getIconUri", "()Landroid/net/Uri;", "GetGetIconUriHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getIconUri.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setIconUri", "(Landroid/net/Uri;)V", "GetSetIconUri_Landroid_net_Uri_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setIconUri.(Landroid/net/Uri;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		private static Delegate GetIsOpenMeasurementEnabledHandler()
		{
			if (AppLovinNativeAdImpl.cb_isOpenMeasurementEnabled == null)
			{
				AppLovinNativeAdImpl.cb_isOpenMeasurementEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinNativeAdImpl.n_IsOpenMeasurementEnabled));
			}
			return AppLovinNativeAdImpl.cb_isOpenMeasurementEnabled;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0002D1EC File Offset: 0x0002B3EC
		private static bool n_IsOpenMeasurementEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpenMeasurementEnabled;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0002D1FB File Offset: 0x0002B3FB
		public virtual bool IsOpenMeasurementEnabled
		{
			[Register("isOpenMeasurementEnabled", "()Z", "GetIsOpenMeasurementEnabledHandler")]
			get
			{
				return AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("isOpenMeasurementEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0002D214 File Offset: 0x0002B414
		private static Delegate GetGetJsTrackerHandler()
		{
			if (AppLovinNativeAdImpl.cb_getJsTracker == null)
			{
				AppLovinNativeAdImpl.cb_getJsTracker = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetJsTracker));
			}
			return AppLovinNativeAdImpl.cb_getJsTracker;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0002D238 File Offset: 0x0002B438
		private static IntPtr n_GetJsTracker(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).JsTracker);
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0002D24C File Offset: 0x0002B44C
		public virtual string JsTracker
		{
			[Register("getJsTracker", "()Ljava/lang/String;", "GetGetJsTrackerHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getJsTracker.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0002D27E File Offset: 0x0002B47E
		private static Delegate GetGetMainImageUriHandler()
		{
			if (AppLovinNativeAdImpl.cb_getMainImageUri == null)
			{
				AppLovinNativeAdImpl.cb_getMainImageUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetMainImageUri));
			}
			return AppLovinNativeAdImpl.cb_getMainImageUri;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0002D2A2 File Offset: 0x0002B4A2
		private static IntPtr n_GetMainImageUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MainImageUri);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0002D2B6 File Offset: 0x0002B4B6
		private static Delegate GetSetMainImageUri_Landroid_net_Uri_Handler()
		{
			if (AppLovinNativeAdImpl.cb_setMainImageUri_Landroid_net_Uri_ == null)
			{
				AppLovinNativeAdImpl.cb_setMainImageUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinNativeAdImpl.n_SetMainImageUri_Landroid_net_Uri_));
			}
			return AppLovinNativeAdImpl.cb_setMainImageUri_Landroid_net_Uri_;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0002D2DC File Offset: 0x0002B4DC
		private static void n_SetMainImageUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinNativeAdImpl @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.MainImageUri = object2;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0002D300 File Offset: 0x0002B500
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x0002D334 File Offset: 0x0002B534
		public unsafe virtual Android.Net.Uri MainImageUri
		{
			[Register("getMainImageUri", "()Landroid/net/Uri;", "GetGetMainImageUriHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getMainImageUri.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setMainImageUri", "(Landroid/net/Uri;)V", "GetSetMainImageUri_Landroid_net_Uri_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setMainImageUri.(Landroid/net/Uri;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0002D398 File Offset: 0x0002B598
		private static Delegate GetGetMediaViewHandler()
		{
			if (AppLovinNativeAdImpl.cb_getMediaView == null)
			{
				AppLovinNativeAdImpl.cb_getMediaView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetMediaView));
			}
			return AppLovinNativeAdImpl.cb_getMediaView;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0002D3BC File Offset: 0x0002B5BC
		private static IntPtr n_GetMediaView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediaView);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		public virtual AppLovinMediaView MediaView
		{
			[Register("getMediaView", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinMediaView;", "GetGetMediaViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinMediaView>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getMediaView.()Lcom/applovin/impl/sdk/nativeAd/AppLovinMediaView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0002D402 File Offset: 0x0002B602
		private static Delegate GetGetOpenMeasurementContentUrlHandler()
		{
			if (AppLovinNativeAdImpl.cb_getOpenMeasurementContentUrl == null)
			{
				AppLovinNativeAdImpl.cb_getOpenMeasurementContentUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetOpenMeasurementContentUrl));
			}
			return AppLovinNativeAdImpl.cb_getOpenMeasurementContentUrl;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0002D426 File Offset: 0x0002B626
		private static IntPtr n_GetOpenMeasurementContentUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenMeasurementContentUrl);
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0002D43C File Offset: 0x0002B63C
		public virtual string OpenMeasurementContentUrl
		{
			[Register("getOpenMeasurementContentUrl", "()Ljava/lang/String;", "GetGetOpenMeasurementContentUrlHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getOpenMeasurementContentUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0002D46E File Offset: 0x0002B66E
		private static Delegate GetGetOpenMeasurementCustomReferenceDataHandler()
		{
			if (AppLovinNativeAdImpl.cb_getOpenMeasurementCustomReferenceData == null)
			{
				AppLovinNativeAdImpl.cb_getOpenMeasurementCustomReferenceData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetOpenMeasurementCustomReferenceData));
			}
			return AppLovinNativeAdImpl.cb_getOpenMeasurementCustomReferenceData;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0002D492 File Offset: 0x0002B692
		private static IntPtr n_GetOpenMeasurementCustomReferenceData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenMeasurementCustomReferenceData);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
		public virtual string OpenMeasurementCustomReferenceData
		{
			[Register("getOpenMeasurementCustomReferenceData", "()Ljava/lang/String;", "GetGetOpenMeasurementCustomReferenceDataHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getOpenMeasurementCustomReferenceData.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0002D4DA File Offset: 0x0002B6DA
		private static Delegate GetGetOpenMeasurementVerificationScriptResourcesHandler()
		{
			if (AppLovinNativeAdImpl.cb_getOpenMeasurementVerificationScriptResources == null)
			{
				AppLovinNativeAdImpl.cb_getOpenMeasurementVerificationScriptResources = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetOpenMeasurementVerificationScriptResources));
			}
			return AppLovinNativeAdImpl.cb_getOpenMeasurementVerificationScriptResources;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0002D4FE File Offset: 0x0002B6FE
		private static IntPtr n_GetOpenMeasurementVerificationScriptResources(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<VerificationScriptResource>.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenMeasurementVerificationScriptResources);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0002D514 File Offset: 0x0002B714
		public virtual IList<VerificationScriptResource> OpenMeasurementVerificationScriptResources
		{
			[Register("getOpenMeasurementVerificationScriptResources", "()Ljava/util/List;", "GetGetOpenMeasurementVerificationScriptResourcesHandler")]
			get
			{
				return JavaList<VerificationScriptResource>.FromJniHandle(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getOpenMeasurementVerificationScriptResources.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0002D546 File Offset: 0x0002B746
		private static Delegate GetGetOptionsViewHandler()
		{
			if (AppLovinNativeAdImpl.cb_getOptionsView == null)
			{
				AppLovinNativeAdImpl.cb_getOptionsView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetOptionsView));
			}
			return AppLovinNativeAdImpl.cb_getOptionsView;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0002D56A File Offset: 0x0002B76A
		private static IntPtr n_GetOptionsView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionsView);
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0002D580 File Offset: 0x0002B780
		public virtual AppLovinOptionsView OptionsView
		{
			[Register("getOptionsView", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinOptionsView;", "GetGetOptionsViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinOptionsView>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getOptionsView.()Lcom/applovin/impl/sdk/nativeAd/AppLovinOptionsView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0002D5B2 File Offset: 0x0002B7B2
		private static Delegate GetGetPrivacyDestinationUriHandler()
		{
			if (AppLovinNativeAdImpl.cb_getPrivacyDestinationUri == null)
			{
				AppLovinNativeAdImpl.cb_getPrivacyDestinationUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetPrivacyDestinationUri));
			}
			return AppLovinNativeAdImpl.cb_getPrivacyDestinationUri;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0002D5D6 File Offset: 0x0002B7D6
		private static IntPtr n_GetPrivacyDestinationUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyDestinationUri);
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0002D5EC File Offset: 0x0002B7EC
		public virtual Android.Net.Uri PrivacyDestinationUri
		{
			[Register("getPrivacyDestinationUri", "()Landroid/net/Uri;", "GetGetPrivacyDestinationUriHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivacyDestinationUri.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0002D61E File Offset: 0x0002B81E
		private static Delegate GetGetPrivacyIconUriHandler()
		{
			if (AppLovinNativeAdImpl.cb_getPrivacyIconUri == null)
			{
				AppLovinNativeAdImpl.cb_getPrivacyIconUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetPrivacyIconUri));
			}
			return AppLovinNativeAdImpl.cb_getPrivacyIconUri;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0002D642 File Offset: 0x0002B842
		private static IntPtr n_GetPrivacyIconUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyIconUri);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0002D656 File Offset: 0x0002B856
		private static Delegate GetSetPrivacyIconUri_Landroid_net_Uri_Handler()
		{
			if (AppLovinNativeAdImpl.cb_setPrivacyIconUri_Landroid_net_Uri_ == null)
			{
				AppLovinNativeAdImpl.cb_setPrivacyIconUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinNativeAdImpl.n_SetPrivacyIconUri_Landroid_net_Uri_));
			}
			return AppLovinNativeAdImpl.cb_setPrivacyIconUri_Landroid_net_Uri_;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0002D67C File Offset: 0x0002B87C
		private static void n_SetPrivacyIconUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinNativeAdImpl @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.PrivacyIconUri = object2;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0002D6A0 File Offset: 0x0002B8A0
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
		public unsafe virtual Android.Net.Uri PrivacyIconUri
		{
			[Register("getPrivacyIconUri", "()Landroid/net/Uri;", "GetGetPrivacyIconUriHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getPrivacyIconUri.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPrivacyIconUri", "(Landroid/net/Uri;)V", "GetSetPrivacyIconUri_Landroid_net_Uri_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setPrivacyIconUri.(Landroid/net/Uri;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0002D738 File Offset: 0x0002B938
		private static Delegate GetGetTitleHandler()
		{
			if (AppLovinNativeAdImpl.cb_getTitle == null)
			{
				AppLovinNativeAdImpl.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetTitle));
			}
			return AppLovinNativeAdImpl.cb_getTitle;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0002D75C File Offset: 0x0002B95C
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Title);
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x0002D770 File Offset: 0x0002B970
		public virtual string Title
		{
			[Register("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getTitle.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0002D7A2 File Offset: 0x0002B9A2
		private static Delegate GetGetTypeHandler()
		{
			if (AppLovinNativeAdImpl.cb_getType == null)
			{
				AppLovinNativeAdImpl.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.n_GetType));
			}
			return AppLovinNativeAdImpl.cb_getType;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0002D7C6 File Offset: 0x0002B9C6
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0002D7DC File Offset: 0x0002B9DC
		public virtual string Type
		{
			[Register("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0002D80E File Offset: 0x0002BA0E
		private static Delegate GetDestroyHandler()
		{
			if (AppLovinNativeAdImpl.cb_destroy == null)
			{
				AppLovinNativeAdImpl.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinNativeAdImpl.n_Destroy));
			}
			return AppLovinNativeAdImpl.cb_destroy;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0002D832 File Offset: 0x0002BA32
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0002D85A File Offset: 0x0002BA5A
		private static Delegate GetRegisterViewsForInteraction_Ljava_util_List_Handler()
		{
			if (AppLovinNativeAdImpl.cb_registerViewsForInteraction_Ljava_util_List_ == null)
			{
				AppLovinNativeAdImpl.cb_registerViewsForInteraction_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinNativeAdImpl.n_RegisterViewsForInteraction_Ljava_util_List_));
			}
			return AppLovinNativeAdImpl.cb_registerViewsForInteraction_Ljava_util_List_;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0002D880 File Offset: 0x0002BA80
		private static void n_RegisterViewsForInteraction_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinNativeAdImpl @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> p = JavaList<View>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RegisterViewsForInteraction(p);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0002D8A4 File Offset: 0x0002BAA4
		[Register("registerViewsForInteraction", "(Ljava/util/List;)V", "GetRegisterViewsForInteraction_Ljava_util_List_Handler")]
		public unsafe virtual void RegisterViewsForInteraction(IList<View> p0)
		{
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("registerViewsForInteraction.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0002D908 File Offset: 0x0002BB08
		private static Delegate GetSetEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_Handler()
		{
			if (AppLovinNativeAdImpl.cb_setEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_ == null)
			{
				AppLovinNativeAdImpl.cb_setEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinNativeAdImpl.n_SetEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_));
			}
			return AppLovinNativeAdImpl.cb_setEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0002D92C File Offset: 0x0002BB2C
		private static void n_SetEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinNativeAdImpl @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinNativeAdEventListener object2 = Java.Lang.Object.GetObject<IAppLovinNativeAdEventListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetEventListener(object2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0002D950 File Offset: 0x0002BB50
		[Register("setEventListener", "(Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListener;)V", "GetSetEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_Handler")]
		public unsafe virtual void SetEventListener(IAppLovinNativeAdEventListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setEventListener.(Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdEventListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		private static Delegate GetSetUpNativeAdViewComponentsHandler()
		{
			if (AppLovinNativeAdImpl.cb_setUpNativeAdViewComponents == null)
			{
				AppLovinNativeAdImpl.cb_setUpNativeAdViewComponents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinNativeAdImpl.n_SetUpNativeAdViewComponents));
			}
			return AppLovinNativeAdImpl.cb_setUpNativeAdViewComponents;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002D9DC File Offset: 0x0002BBDC
		private static void n_SetUpNativeAdViewComponents(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUpNativeAdViewComponents();
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0002D9EB File Offset: 0x0002BBEB
		[Register("setUpNativeAdViewComponents", "()V", "GetSetUpNativeAdViewComponentsHandler")]
		public virtual void SetUpNativeAdViewComponents()
		{
			AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setUpNativeAdViewComponents.()V", this, null);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0002DA04 File Offset: 0x0002BC04
		private static Delegate GetUnregisterViewsForInteractionHandler()
		{
			if (AppLovinNativeAdImpl.cb_unregisterViewsForInteraction == null)
			{
				AppLovinNativeAdImpl.cb_unregisterViewsForInteraction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinNativeAdImpl.n_UnregisterViewsForInteraction));
			}
			return AppLovinNativeAdImpl.cb_unregisterViewsForInteraction;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0002DA28 File Offset: 0x0002BC28
		private static void n_UnregisterViewsForInteraction(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UnregisterViewsForInteraction();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0002DA37 File Offset: 0x0002BC37
		[Register("unregisterViewsForInteraction", "()V", "GetUnregisterViewsForInteractionHandler")]
		public virtual void UnregisterViewsForInteraction()
		{
			AppLovinNativeAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterViewsForInteraction.()V", this, null);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000F90 RID: 3984 RVA: 0x0002DA50 File Offset: 0x0002BC50
		// (remove) Token: 0x06000F91 RID: 3985 RVA: 0x0002DA9C File Offset: 0x0002BC9C
		public event EventHandler<AppLovinNativeAdEventEventArgs> Event
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinNativeAdEventListener, IAppLovinNativeAdEventListenerImplementor>(ref this.weak_implementor_SetEventListener, new Func<IAppLovinNativeAdEventListenerImplementor>(this.__CreateIAppLovinNativeAdEventListenerImplementor), new Action<IAppLovinNativeAdEventListener>(this.SetEventListener), delegate(IAppLovinNativeAdEventListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinNativeAdEventEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinNativeAdEventListener, IAppLovinNativeAdEventListenerImplementor>(ref this.weak_implementor_SetEventListener, new Func<IAppLovinNativeAdEventListenerImplementor, bool>(IAppLovinNativeAdEventListenerImplementor.__IsEmpty), delegate(IAppLovinNativeAdEventListener __v)
				{
					this.SetEventListener(null);
				}, delegate(IAppLovinNativeAdEventListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinNativeAdEventEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0002DAEC File Offset: 0x0002BCEC
		private IAppLovinNativeAdEventListenerImplementor __CreateIAppLovinNativeAdEventListenerImplementor()
		{
			return new IAppLovinNativeAdEventListenerImplementor(this);
		}

		// Token: 0x04000502 RID: 1282
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl", typeof(AppLovinNativeAdImpl));

		// Token: 0x04000503 RID: 1283
		private static Delegate cb_getAdIdNumber;

		// Token: 0x04000504 RID: 1284
		private static Delegate cb_getAdvertiser;

		// Token: 0x04000505 RID: 1285
		private static Delegate cb_getBody;

		// Token: 0x04000506 RID: 1286
		private static Delegate cb_getCachePrefix;

		// Token: 0x04000507 RID: 1287
		private static Delegate cb_getCallToAction;

		// Token: 0x04000508 RID: 1288
		private static Delegate cb_getClickHandler;

		// Token: 0x04000509 RID: 1289
		private static Delegate cb_getIconUri;

		// Token: 0x0400050A RID: 1290
		private static Delegate cb_setIconUri_Landroid_net_Uri_;

		// Token: 0x0400050B RID: 1291
		private static Delegate cb_isOpenMeasurementEnabled;

		// Token: 0x0400050C RID: 1292
		private static Delegate cb_getJsTracker;

		// Token: 0x0400050D RID: 1293
		private static Delegate cb_getMainImageUri;

		// Token: 0x0400050E RID: 1294
		private static Delegate cb_setMainImageUri_Landroid_net_Uri_;

		// Token: 0x0400050F RID: 1295
		private static Delegate cb_getMediaView;

		// Token: 0x04000510 RID: 1296
		private static Delegate cb_getOpenMeasurementContentUrl;

		// Token: 0x04000511 RID: 1297
		private static Delegate cb_getOpenMeasurementCustomReferenceData;

		// Token: 0x04000512 RID: 1298
		private static Delegate cb_getOpenMeasurementVerificationScriptResources;

		// Token: 0x04000513 RID: 1299
		private static Delegate cb_getOptionsView;

		// Token: 0x04000514 RID: 1300
		private static Delegate cb_getPrivacyDestinationUri;

		// Token: 0x04000515 RID: 1301
		private static Delegate cb_getPrivacyIconUri;

		// Token: 0x04000516 RID: 1302
		private static Delegate cb_setPrivacyIconUri_Landroid_net_Uri_;

		// Token: 0x04000517 RID: 1303
		private static Delegate cb_getTitle;

		// Token: 0x04000518 RID: 1304
		private static Delegate cb_getType;

		// Token: 0x04000519 RID: 1305
		private static Delegate cb_destroy;

		// Token: 0x0400051A RID: 1306
		private static Delegate cb_registerViewsForInteraction_Ljava_util_List_;

		// Token: 0x0400051B RID: 1307
		private static Delegate cb_setEventListener_Lcom_applovin_impl_sdk_nativeAd_AppLovinNativeAdEventListener_;

		// Token: 0x0400051C RID: 1308
		private static Delegate cb_setUpNativeAdViewComponents;

		// Token: 0x0400051D RID: 1309
		private static Delegate cb_unregisterViewsForInteraction;

		// Token: 0x0400051E RID: 1310
		private WeakReference weak_implementor_SetEventListener;

		// Token: 0x02000141 RID: 321
		[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0002DB10 File Offset: 0x0002BD10
			internal static IntPtr class_ref
			{
				get
				{
					return AppLovinNativeAdImpl.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0002DB34 File Offset: 0x0002BD34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinNativeAdImpl.Builder._members;
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0002DB3C File Offset: 0x0002BD3C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AppLovinNativeAdImpl.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000F97 RID: 3991 RVA: 0x0002DB60 File Offset: 0x0002BD60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinNativeAdImpl.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000F98 RID: 3992 RVA: 0x000021F0 File Offset: 0x000003F0
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000F99 RID: 3993 RVA: 0x0002DB6C File Offset: 0x0002BD6C
			private static Delegate GetBuildHandler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_build == null)
				{
					AppLovinNativeAdImpl.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinNativeAdImpl.Builder.n_Build));
				}
				return AppLovinNativeAdImpl.Builder.cb_build;
			}

			// Token: 0x06000F9A RID: 3994 RVA: 0x0002DB90 File Offset: 0x0002BD90
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000F9B RID: 3995 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
			[Register("build", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl;", "GetBuildHandler")]
			public virtual AppLovinNativeAdImpl Build()
			{
				return Java.Lang.Object.GetObject<AppLovinNativeAdImpl>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000F9C RID: 3996 RVA: 0x0002DBD6 File Offset: 0x0002BDD6
			private static Delegate GetSetAdvertiser_Ljava_lang_String_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setAdvertiser_Ljava_lang_String_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setAdvertiser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetAdvertiser_Ljava_lang_String_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setAdvertiser_Ljava_lang_String_;
			}

			// Token: 0x06000F9D RID: 3997 RVA: 0x0002DBFC File Offset: 0x0002BDFC
			private static IntPtr n_SetAdvertiser_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAdvertiser(@string));
			}

			// Token: 0x06000F9E RID: 3998 RVA: 0x0002DC24 File Offset: 0x0002BE24
			[Register("setAdvertiser", "(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetAdvertiser_Ljava_lang_String_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetAdvertiser(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAdvertiser.(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000F9F RID: 3999 RVA: 0x0002DC90 File Offset: 0x0002BE90
			private static Delegate GetSetBody_Ljava_lang_String_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setBody_Ljava_lang_String_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetBody_Ljava_lang_String_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setBody_Ljava_lang_String_;
			}

			// Token: 0x06000FA0 RID: 4000 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
			private static IntPtr n_SetBody_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetBody(@string));
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x0002DCDC File Offset: 0x0002BEDC
			[Register("setBody", "(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetBody_Ljava_lang_String_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetBody(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setBody.(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000FA2 RID: 4002 RVA: 0x0002DD48 File Offset: 0x0002BF48
			private static Delegate GetSetCallToAction_Ljava_lang_String_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setCallToAction_Ljava_lang_String_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setCallToAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetCallToAction_Ljava_lang_String_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setCallToAction_Ljava_lang_String_;
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x0002DD6C File Offset: 0x0002BF6C
			private static IntPtr n_SetCallToAction_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCallToAction(@string));
			}

			// Token: 0x06000FA4 RID: 4004 RVA: 0x0002DD94 File Offset: 0x0002BF94
			[Register("setCallToAction", "(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetCallToAction_Ljava_lang_String_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetCallToAction(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCallToAction.(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x0002DE00 File Offset: 0x0002C000
			private static Delegate GetSetClickDestinationBackupUri_Landroid_net_Uri_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setClickDestinationBackupUri_Landroid_net_Uri_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setClickDestinationBackupUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetClickDestinationBackupUri_Landroid_net_Uri_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setClickDestinationBackupUri_Landroid_net_Uri_;
			}

			// Token: 0x06000FA6 RID: 4006 RVA: 0x0002DE24 File Offset: 0x0002C024
			private static IntPtr n_SetClickDestinationBackupUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetClickDestinationBackupUri(object2));
			}

			// Token: 0x06000FA7 RID: 4007 RVA: 0x0002DE4C File Offset: 0x0002C04C
			[Register("setClickDestinationBackupUri", "(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetClickDestinationBackupUri_Landroid_net_Uri_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetClickDestinationBackupUri(Android.Net.Uri p0)
			{
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setClickDestinationBackupUri.(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FA8 RID: 4008 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
			private static Delegate GetSetClickDestinationUri_Landroid_net_Uri_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setClickDestinationUri_Landroid_net_Uri_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setClickDestinationUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetClickDestinationUri_Landroid_net_Uri_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setClickDestinationUri_Landroid_net_Uri_;
			}

			// Token: 0x06000FA9 RID: 4009 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
			private static IntPtr n_SetClickDestinationUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetClickDestinationUri(object2));
			}

			// Token: 0x06000FAA RID: 4010 RVA: 0x0002DF0C File Offset: 0x0002C10C
			[Register("setClickDestinationUri", "(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetClickDestinationUri_Landroid_net_Uri_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetClickDestinationUri(Android.Net.Uri p0)
			{
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setClickDestinationUri.(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FAB RID: 4011 RVA: 0x0002DF80 File Offset: 0x0002C180
			private static Delegate GetSetClickTrackingUrls_Ljava_util_List_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setClickTrackingUrls_Ljava_util_List_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setClickTrackingUrls_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetClickTrackingUrls_Ljava_util_List_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setClickTrackingUrls_Ljava_util_List_;
			}

			// Token: 0x06000FAC RID: 4012 RVA: 0x0002DFA4 File Offset: 0x0002C1A4
			private static IntPtr n_SetClickTrackingUrls_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IList<string> clickTrackingUrls = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetClickTrackingUrls(clickTrackingUrls));
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x0002DFCC File Offset: 0x0002C1CC
			[Register("setClickTrackingUrls", "(Ljava/util/List;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetClickTrackingUrls_Ljava_util_List_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetClickTrackingUrls(IList<string> p0)
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p0);
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setClickTrackingUrls.(Ljava/util/List;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FAE RID: 4014 RVA: 0x0002E040 File Offset: 0x0002C240
			private static Delegate GetSetIconUri_Landroid_net_Uri_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setIconUri_Landroid_net_Uri_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setIconUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetIconUri_Landroid_net_Uri_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setIconUri_Landroid_net_Uri_;
			}

			// Token: 0x06000FAF RID: 4015 RVA: 0x0002E064 File Offset: 0x0002C264
			private static IntPtr n_SetIconUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIconUri(object2));
			}

			// Token: 0x06000FB0 RID: 4016 RVA: 0x0002E08C File Offset: 0x0002C28C
			[Register("setIconUri", "(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetIconUri_Landroid_net_Uri_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetIconUri(Android.Net.Uri p0)
			{
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIconUri.(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FB1 RID: 4017 RVA: 0x0002E100 File Offset: 0x0002C300
			private static Delegate GetSetJsTracker_Ljava_lang_String_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setJsTracker_Ljava_lang_String_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setJsTracker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetJsTracker_Ljava_lang_String_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setJsTracker_Ljava_lang_String_;
			}

			// Token: 0x06000FB2 RID: 4018 RVA: 0x0002E124 File Offset: 0x0002C324
			private static IntPtr n_SetJsTracker_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetJsTracker(@string));
			}

			// Token: 0x06000FB3 RID: 4019 RVA: 0x0002E14C File Offset: 0x0002C34C
			[Register("setJsTracker", "(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetJsTracker_Ljava_lang_String_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetJsTracker(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setJsTracker.(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000FB4 RID: 4020 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
			private static Delegate GetSetMainImageUri_Landroid_net_Uri_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setMainImageUri_Landroid_net_Uri_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setMainImageUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetMainImageUri_Landroid_net_Uri_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setMainImageUri_Landroid_net_Uri_;
			}

			// Token: 0x06000FB5 RID: 4021 RVA: 0x0002E1DC File Offset: 0x0002C3DC
			private static IntPtr n_SetMainImageUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMainImageUri(object2));
			}

			// Token: 0x06000FB6 RID: 4022 RVA: 0x0002E204 File Offset: 0x0002C404
			[Register("setMainImageUri", "(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetMainImageUri_Landroid_net_Uri_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetMainImageUri(Android.Net.Uri p0)
			{
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMainImageUri.(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FB7 RID: 4023 RVA: 0x0002E278 File Offset: 0x0002C478
			private static Delegate GetSetPrivacyDestinationUri_Landroid_net_Uri_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setPrivacyDestinationUri_Landroid_net_Uri_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setPrivacyDestinationUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetPrivacyDestinationUri_Landroid_net_Uri_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setPrivacyDestinationUri_Landroid_net_Uri_;
			}

			// Token: 0x06000FB8 RID: 4024 RVA: 0x0002E29C File Offset: 0x0002C49C
			private static IntPtr n_SetPrivacyDestinationUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPrivacyDestinationUri(object2));
			}

			// Token: 0x06000FB9 RID: 4025 RVA: 0x0002E2C4 File Offset: 0x0002C4C4
			[Register("setPrivacyDestinationUri", "(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetPrivacyDestinationUri_Landroid_net_Uri_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetPrivacyDestinationUri(Android.Net.Uri p0)
			{
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPrivacyDestinationUri.(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x0002E338 File Offset: 0x0002C538
			private static Delegate GetSetPrivacyIconUri_Landroid_net_Uri_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setPrivacyIconUri_Landroid_net_Uri_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setPrivacyIconUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetPrivacyIconUri_Landroid_net_Uri_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setPrivacyIconUri_Landroid_net_Uri_;
			}

			// Token: 0x06000FBB RID: 4027 RVA: 0x0002E35C File Offset: 0x0002C55C
			private static IntPtr n_SetPrivacyIconUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPrivacyIconUri(object2));
			}

			// Token: 0x06000FBC RID: 4028 RVA: 0x0002E384 File Offset: 0x0002C584
			[Register("setPrivacyIconUri", "(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetPrivacyIconUri_Landroid_net_Uri_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetPrivacyIconUri(Android.Net.Uri p0)
			{
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPrivacyIconUri.(Landroid/net/Uri;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000FBD RID: 4029 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
			private static Delegate GetSetTitle_Ljava_lang_String_Handler()
			{
				if (AppLovinNativeAdImpl.Builder.cb_setTitle_Ljava_lang_String_ == null)
				{
					AppLovinNativeAdImpl.Builder.cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinNativeAdImpl.Builder.n_SetTitle_Ljava_lang_String_));
				}
				return AppLovinNativeAdImpl.Builder.cb_setTitle_Ljava_lang_String_;
			}

			// Token: 0x06000FBE RID: 4030 RVA: 0x0002E41C File Offset: 0x0002C61C
			private static IntPtr n_SetTitle_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinNativeAdImpl.Builder @object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTitle(@string));
			}

			// Token: 0x06000FBF RID: 4031 RVA: 0x0002E444 File Offset: 0x0002C644
			[Register("setTitle", "(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", "GetSetTitle_Ljava_lang_String_Handler")]
			public unsafe virtual AppLovinNativeAdImpl.Builder SetTitle(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AppLovinNativeAdImpl.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinNativeAdImpl.Builder>(AppLovinNativeAdImpl.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTitle.(Ljava/lang/String;)Lcom/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0400051F RID: 1311
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinNativeAdImpl$Builder", typeof(AppLovinNativeAdImpl.Builder));

			// Token: 0x04000520 RID: 1312
			private static Delegate cb_build;

			// Token: 0x04000521 RID: 1313
			private static Delegate cb_setAdvertiser_Ljava_lang_String_;

			// Token: 0x04000522 RID: 1314
			private static Delegate cb_setBody_Ljava_lang_String_;

			// Token: 0x04000523 RID: 1315
			private static Delegate cb_setCallToAction_Ljava_lang_String_;

			// Token: 0x04000524 RID: 1316
			private static Delegate cb_setClickDestinationBackupUri_Landroid_net_Uri_;

			// Token: 0x04000525 RID: 1317
			private static Delegate cb_setClickDestinationUri_Landroid_net_Uri_;

			// Token: 0x04000526 RID: 1318
			private static Delegate cb_setClickTrackingUrls_Ljava_util_List_;

			// Token: 0x04000527 RID: 1319
			private static Delegate cb_setIconUri_Landroid_net_Uri_;

			// Token: 0x04000528 RID: 1320
			private static Delegate cb_setJsTracker_Ljava_lang_String_;

			// Token: 0x04000529 RID: 1321
			private static Delegate cb_setMainImageUri_Landroid_net_Uri_;

			// Token: 0x0400052A RID: 1322
			private static Delegate cb_setPrivacyDestinationUri_Landroid_net_Uri_;

			// Token: 0x0400052B RID: 1323
			private static Delegate cb_setPrivacyIconUri_Landroid_net_Uri_;

			// Token: 0x0400052C RID: 1324
			private static Delegate cb_setTitle_Ljava_lang_String_;
		}
	}
}
