using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x0200007A RID: 122
	[Register("com/unity3d/services/core/webview/bridge/IWebViewSharedObject", "", "Com.Unity3d.Services.Core.Webview.Bridge.IWebViewSharedObjectInvoker")]
	public interface IWebViewSharedObject : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000444 RID: 1092
		string Id { [Register("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Unity3d.Services.Core.Webview.Bridge.IWebViewSharedObjectInvoker, UnityAds")] get; }
	}
}
