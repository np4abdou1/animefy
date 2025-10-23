using System;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001EA RID: 490
	[Register("com/unity3d/services/ads/operation/IAdOperation", "", "Com.Unity3d.Services.Ads.Operation.IAdOperationInvoker")]
	public interface IAdOperation : IWebViewSharedObject, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600164E RID: 5710
		[Register("invoke", "(I[Ljava/lang/Object;)V", "GetInvoke_IarrayLjava_lang_Object_Handler:Com.Unity3d.Services.Ads.Operation.IAdOperationInvoker, UnityAds")]
		void Invoke(int p0, params Java.Lang.Object[] p1);
	}
}
