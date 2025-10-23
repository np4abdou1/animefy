using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common.Scarads
{
	// Token: 0x020002BD RID: 701
	[Register("com/unity3d/scar/adapter/common/scarads/IScarLoadListener", "", "Com.Unity3d.Scar.Adapter.Common.Scarads.IScarLoadListenerInvoker")]
	public interface IScarLoadListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600279E RID: 10142
		[Register("onAdLoaded", "()V", "GetOnAdLoadedHandler:Com.Unity3d.Scar.Adapter.Common.Scarads.IScarLoadListenerInvoker, UnityAds")]
		void OnAdLoaded();
	}
}
