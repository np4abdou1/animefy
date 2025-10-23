using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001A3 RID: 419
	[Register("com/unity3d/services/banners/IUnityBannerListener", "", "Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker")]
	public interface IUnityBannerListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001325 RID: 4901
		[Register("onUnityBannerClick", "(Ljava/lang/String;)V", "GetOnUnityBannerClick_Ljava_lang_String_Handler:Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker, UnityAds")]
		void OnUnityBannerClick(string p0);

		// Token: 0x06001326 RID: 4902
		[Register("onUnityBannerError", "(Ljava/lang/String;)V", "GetOnUnityBannerError_Ljava_lang_String_Handler:Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker, UnityAds")]
		void OnUnityBannerError(string p0);

		// Token: 0x06001327 RID: 4903
		[Register("onUnityBannerHide", "(Ljava/lang/String;)V", "GetOnUnityBannerHide_Ljava_lang_String_Handler:Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker, UnityAds")]
		void OnUnityBannerHide(string p0);

		// Token: 0x06001328 RID: 4904
		[Register("onUnityBannerLoaded", "(Ljava/lang/String;Landroid/view/View;)V", "GetOnUnityBannerLoaded_Ljava_lang_String_Landroid_view_View_Handler:Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker, UnityAds")]
		void OnUnityBannerLoaded(string p0, View p1);

		// Token: 0x06001329 RID: 4905
		[Register("onUnityBannerShow", "(Ljava/lang/String;)V", "GetOnUnityBannerShow_Ljava_lang_String_Handler:Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker, UnityAds")]
		void OnUnityBannerShow(string p0);

		// Token: 0x0600132A RID: 4906
		[Register("onUnityBannerUnloaded", "(Ljava/lang/String;)V", "GetOnUnityBannerUnloaded_Ljava_lang_String_Handler:Com.Unity3d.Services.Banners.IUnityBannerListenerInvoker, UnityAds")]
		void OnUnityBannerUnloaded(string p0);
	}
}
