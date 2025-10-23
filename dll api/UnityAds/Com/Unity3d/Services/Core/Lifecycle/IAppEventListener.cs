using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000EF RID: 239
	[Register("com/unity3d/services/core/lifecycle/IAppEventListener", "", "Com.Unity3d.Services.Core.Lifecycle.IAppEventListenerInvoker")]
	public interface IAppEventListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000975 RID: 2421
		[Register("onLifecycleEvent", "(Lcom/unity3d/services/core/lifecycle/LifecycleEvent;)V", "GetOnLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_Handler:Com.Unity3d.Services.Core.Lifecycle.IAppEventListenerInvoker, UnityAds")]
		void OnLifecycleEvent(LifecycleEvent p0);
	}
}
