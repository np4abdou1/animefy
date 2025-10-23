using System;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001EF RID: 495
	[Register("com/unity3d/services/ads/operation/show/IShowOperation", "", "Com.Unity3d.Services.Ads.Operation.Show.IShowOperationInvoker")]
	public interface IShowOperation : IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable, IAdOperation, IWebViewSharedObject
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060016A2 RID: 5794
		ShowOperationState ShowOperationState { [Register("getShowOperationState", "()Lcom/unity3d/services/ads/operation/show/ShowOperationState;", "GetGetShowOperationStateHandler:Com.Unity3d.Services.Ads.Operation.Show.IShowOperationInvoker, UnityAds")] get; }
	}
}
