using System;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001F8 RID: 504
	[Register("com/unity3d/services/ads/operation/load/ILoadOperation", "", "Com.Unity3d.Services.Ads.Operation.Load.ILoadOperationInvoker")]
	public interface ILoadOperation : IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable, IAdOperation, IWebViewSharedObject
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600175E RID: 5982
		LoadOperationState LoadOperationState { [Register("getLoadOperationState", "()Lcom/unity3d/services/ads/operation/load/LoadOperationState;", "GetGetLoadOperationStateHandler:Com.Unity3d.Services.Ads.Operation.Load.ILoadOperationInvoker, UnityAds")] get; }
	}
}
