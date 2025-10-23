using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x0200029F RID: 671
	[Register("com/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper", "", "Com.Unity3d.Scar.Adapter.Common.IScarInterstitialAdListenerWrapperInvoker")]
	public interface IScarInterstitialAdListenerWrapper : IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600265D RID: 9821
		[Register("onAdFailedToShow", "(ILjava/lang/String;)V", "GetOnAdFailedToShow_ILjava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.IScarInterstitialAdListenerWrapperInvoker, UnityAds")]
		void OnAdFailedToShow(int p0, string p1);

		// Token: 0x0600265E RID: 9822
		[Register("onAdImpression", "()V", "GetOnAdImpressionHandler:Com.Unity3d.Scar.Adapter.Common.IScarInterstitialAdListenerWrapperInvoker, UnityAds")]
		void OnAdImpression();

		// Token: 0x0600265F RID: 9823
		[Register("onAdLeftApplication", "()V", "GetOnAdLeftApplicationHandler:Com.Unity3d.Scar.Adapter.Common.IScarInterstitialAdListenerWrapperInvoker, UnityAds")]
		void OnAdLeftApplication();
	}
}
