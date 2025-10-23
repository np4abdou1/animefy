using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x0200008B RID: 139
	[Register("com/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocationSingleThreadedExecutor", DoNotGenerateAcw = true)]
	public class WebViewBridgeInvocationSingleThreadedExecutor : Java.Lang.Object
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeInvocationSingleThreadedExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0000E70C File Offset: 0x0000C90C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeInvocationSingleThreadedExecutor._members;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0000E714 File Offset: 0x0000C914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeInvocationSingleThreadedExecutor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000E738 File Offset: 0x0000C938
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeInvocationSingleThreadedExecutor._members.ManagedPeerType;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridgeInvocationSingleThreadedExecutor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000E744 File Offset: 0x0000C944
		private static Delegate GetGetExecutorServiceHandler()
		{
			if (WebViewBridgeInvocationSingleThreadedExecutor.cb_getExecutorService == null)
			{
				WebViewBridgeInvocationSingleThreadedExecutor.cb_getExecutorService = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewBridgeInvocationSingleThreadedExecutor.n_GetExecutorService));
			}
			return WebViewBridgeInvocationSingleThreadedExecutor.cb_getExecutorService;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000E768 File Offset: 0x0000C968
		private static IntPtr n_GetExecutorService(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebViewBridgeInvocationSingleThreadedExecutor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExecutorService);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000E77C File Offset: 0x0000C97C
		public virtual IExecutorService ExecutorService
		{
			[Register("getExecutorService", "()Ljava/util/concurrent/ExecutorService;", "GetGetExecutorServiceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IExecutorService>(WebViewBridgeInvocationSingleThreadedExecutor._members.InstanceMethods.InvokeVirtualObjectMethod("getExecutorService.()Ljava/util/concurrent/ExecutorService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public static WebViewBridgeInvocationSingleThreadedExecutor Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocationSingleThreadedExecutor;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeInvocationSingleThreadedExecutor>(WebViewBridgeInvocationSingleThreadedExecutor._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocationSingleThreadedExecutor;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocationSingleThreadedExecutor", typeof(WebViewBridgeInvocationSingleThreadedExecutor));

		// Token: 0x04000111 RID: 273
		private static Delegate cb_getExecutorService;
	}
}
