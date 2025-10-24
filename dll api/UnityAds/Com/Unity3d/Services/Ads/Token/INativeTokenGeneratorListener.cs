using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001DB RID: 475
	[Register("com/unity3d/services/ads/token/INativeTokenGeneratorListener", "", "Com.Unity3d.Services.Ads.Token.INativeTokenGeneratorListenerInvoker")]
	public interface INativeTokenGeneratorListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060015C6 RID: 5574
		[Register("onReady", "(Ljava/lang/String;)V", "GetOnReady_Ljava_lang_String_Handler:Com.Unity3d.Services.Ads.Token.INativeTokenGeneratorListenerInvoker, UnityAds")]
		void OnReady(string p0);
	}
}
