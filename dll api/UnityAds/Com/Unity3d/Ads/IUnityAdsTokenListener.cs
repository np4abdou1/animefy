using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D3 RID: 723
	[Register("com/unity3d/ads/IUnityAdsTokenListener", "", "Com.Unity3d.Ads.IUnityAdsTokenListenerInvoker")]
	public interface IUnityAdsTokenListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600283C RID: 10300
		[Register("onUnityAdsTokenReady", "(Ljava/lang/String;)V", "GetOnUnityAdsTokenReady_Ljava_lang_String_Handler:Com.Unity3d.Ads.IUnityAdsTokenListenerInvoker, UnityAds")]
		void OnUnityAdsTokenReady(string p0);
	}
}
