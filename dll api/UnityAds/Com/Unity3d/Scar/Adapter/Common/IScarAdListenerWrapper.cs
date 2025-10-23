using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x0200029D RID: 669
	[Register("com/unity3d/scar/adapter/common/IScarAdListenerWrapper", "", "Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker")]
	public interface IScarAdListenerWrapper : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600263C RID: 9788
		[Register("onAdClicked", "()V", "GetOnAdClickedHandler:Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker, UnityAds")]
		void OnAdClicked();

		// Token: 0x0600263D RID: 9789
		[Register("onAdClosed", "()V", "GetOnAdClosedHandler:Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker, UnityAds")]
		void OnAdClosed();

		// Token: 0x0600263E RID: 9790
		[Register("onAdFailedToLoad", "(ILjava/lang/String;)V", "GetOnAdFailedToLoad_ILjava_lang_String_Handler:Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker, UnityAds")]
		void OnAdFailedToLoad(int p0, string p1);

		// Token: 0x0600263F RID: 9791
		[Register("onAdLoaded", "()V", "GetOnAdLoadedHandler:Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker, UnityAds")]
		void OnAdLoaded();

		// Token: 0x06002640 RID: 9792
		[Register("onAdOpened", "()V", "GetOnAdOpenedHandler:Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker, UnityAds")]
		void OnAdOpened();

		// Token: 0x06002641 RID: 9793
		[Register("onAdSkipped", "()V", "GetOnAdSkippedHandler:Com.Unity3d.Scar.Adapter.Common.IScarAdListenerWrapperInvoker, UnityAds")]
		void OnAdSkipped();
	}
}
