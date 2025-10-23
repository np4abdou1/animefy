using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Listeners
{
	// Token: 0x02000202 RID: 514
	[Register("com/unity3d/services/ads/gmascar/listeners/IInitializationStatusListener", "", "Com.Unity3d.Services.Ads.Gmascar.Listeners.IInitializationStatusListenerInvoker")]
	public interface IInitializationStatusListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001802 RID: 6146
		[Register("onInitializationComplete", "(Ljava/lang/Object;)V", "GetOnInitializationComplete_Ljava_lang_Object_Handler:Com.Unity3d.Services.Ads.Gmascar.Listeners.IInitializationStatusListenerInvoker, UnityAds")]
		void OnInitializationComplete(Java.Lang.Object p0);
	}
}
