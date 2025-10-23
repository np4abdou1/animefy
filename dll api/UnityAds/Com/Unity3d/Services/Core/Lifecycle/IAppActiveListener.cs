using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000EB RID: 235
	[Register("com/unity3d/services/core/lifecycle/IAppActiveListener", "", "Com.Unity3d.Services.Core.Lifecycle.IAppActiveListenerInvoker")]
	public interface IAppActiveListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000963 RID: 2403
		[Register("onAppStateChanged", "(Z)V", "GetOnAppStateChanged_ZHandler:Com.Unity3d.Services.Core.Lifecycle.IAppActiveListenerInvoker, UnityAds")]
		void OnAppStateChanged(bool p0);
	}
}
