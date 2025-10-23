using System;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x02000216 RID: 534
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/IMobileAdsBridge", "", "Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker")]
	public interface IMobileAdsBridge : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060018EE RID: 6382
		Java.Lang.Object InitializationStatus { [Register("getInitializationStatus", "()Ljava/lang/Object;", "GetGetInitializationStatusHandler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")] get; }

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060018EF RID: 6383
		int VersionCodeIndex { [Register("getVersionCodeIndex", "()I", "GetGetVersionCodeIndexHandler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")] get; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060018F0 RID: 6384
		string VersionMethodName { [Register("getVersionMethodName", "()Ljava/lang/String;", "GetGetVersionMethodNameHandler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")] get; }

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060018F1 RID: 6385
		string VersionString { [Register("getVersionString", "()Ljava/lang/String;", "GetGetVersionStringHandler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")] get; }

		// Token: 0x060018F2 RID: 6386
		[Register("getAdapterVersion", "(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "GetGetAdapterVersion_IHandler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")]
		ScarAdapterVersion GetAdapterVersion(int p0);

		// Token: 0x060018F3 RID: 6387
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/Object;)V", "GetInitialize_Landroid_content_Context_Ljava_lang_Object_Handler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")]
		void Initialize(Context p0, Java.Lang.Object p1);

		// Token: 0x060018F4 RID: 6388
		[Register("shouldInitialize", "()Z", "GetShouldInitializeHandler:Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads.IMobileAdsBridgeInvoker, UnityAds")]
		bool ShouldInitialize();
	}
}
