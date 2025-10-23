using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000082 RID: 130
	[Register("com/unity3d/services/core/webview/bridge/WebViewBridgeSharedObjectStore", DoNotGenerateAcw = true)]
	internal class WebViewBridgeSharedObjectStoreInvoker : WebViewBridgeSharedObjectStore, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x0000D69F File Offset: 0x0000B89F
		public WebViewBridgeSharedObjectStoreInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0000D6A9 File Offset: 0x0000B8A9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeSharedObjectStoreInvoker._members;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeSharedObjectStoreInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewBridgeSharedObjectStore", typeof(WebViewBridgeSharedObjectStoreInvoker));
	}
}
