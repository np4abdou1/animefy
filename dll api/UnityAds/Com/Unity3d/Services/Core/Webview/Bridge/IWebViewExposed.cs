using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000078 RID: 120
	[Register("com/unity3d/services/core/webview/bridge/WebViewExposed", "", "Com.Unity3d.Services.Core.Webview.Bridge.IWebViewExposedInvoker")]
	public interface IWebViewExposed : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
