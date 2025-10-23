using System;
using System.Collections.Generic;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000146 RID: 326
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAd", "", "Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker")]
	public interface IAppLovinNativeAd : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000FDB RID: 4059
		long AdIdNumber { [Register("getAdIdNumber", "()J", "GetGetAdIdNumberHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000FDC RID: 4060
		string Advertiser { [Register("getAdvertiser", "()Ljava/lang/String;", "GetGetAdvertiserHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000FDD RID: 4061
		string Body { [Register("getBody", "()Ljava/lang/String;", "GetGetBodyHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000FDE RID: 4062
		string CallToAction { [Register("getCallToAction", "()Ljava/lang/String;", "GetGetCallToActionHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000FDF RID: 4063
		Android.Net.Uri IconUri { [Register("getIconUri", "()Landroid/net/Uri;", "GetGetIconUriHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000FE0 RID: 4064
		AppLovinMediaView MediaView { [Register("getMediaView", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinMediaView;", "GetGetMediaViewHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000FE1 RID: 4065
		AppLovinOptionsView OptionsView { [Register("getOptionsView", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinOptionsView;", "GetGetOptionsViewHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000FE2 RID: 4066
		string Title { [Register("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")] get; }

		// Token: 0x06000FE3 RID: 4067
		[Register("destroy", "()V", "GetDestroyHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")]
		void Destroy();

		// Token: 0x06000FE4 RID: 4068
		[Register("registerViewsForInteraction", "(Ljava/util/List;)V", "GetRegisterViewsForInteraction_Ljava_util_List_Handler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")]
		void RegisterViewsForInteraction(IList<View> p0);

		// Token: 0x06000FE5 RID: 4069
		[Register("unregisterViewsForInteraction", "()V", "GetUnregisterViewsForInteractionHandler:Com.Applovin.Impl.Sdk.NativeAd.IAppLovinNativeAdInvoker, AppLovin")]
		void UnregisterViewsForInteraction();
	}
}
