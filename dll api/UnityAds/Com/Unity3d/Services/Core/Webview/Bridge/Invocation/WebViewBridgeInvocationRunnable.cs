using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x0200008A RID: 138
	[Register("com/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocationRunnable", DoNotGenerateAcw = true)]
	public class WebViewBridgeInvocationRunnable : Java.Lang.Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000E44C File Offset: 0x0000C64C
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeInvocationRunnable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000E470 File Offset: 0x0000C670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeInvocationRunnable._members;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0000E478 File Offset: 0x0000C678
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeInvocationRunnable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000E49C File Offset: 0x0000C69C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeInvocationRunnable._members.ManagedPeerType;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridgeInvocationRunnable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Register(".ctor", "(Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback;Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V", "")]
		public unsafe WebViewBridgeInvocationRunnable(IWebViewBridgeInvocationCallback invocationCallback, IWebViewBridgeInvoker webViewBridgeInvoker, string className, string methodName, int timeoutLengthInMilliSeconds, params Java.Lang.Object[] invocationParameters) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(invocationParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((invocationCallback == null) ? IntPtr.Zero : ((Java.Lang.Object)invocationCallback).Handle);
				ptr[1] = new JniArgumentValue((webViewBridgeInvoker == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvoker).Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue(timeoutLengthInMilliSeconds);
				ptr[5] = new JniArgumentValue(intPtr3);
				base.SetHandle(WebViewBridgeInvocationRunnable._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback;Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewBridgeInvocationRunnable._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback;Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (invocationParameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, invocationParameters);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(invocationCallback);
				GC.KeepAlive(webViewBridgeInvoker);
				GC.KeepAlive(invocationParameters);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000E61C File Offset: 0x0000C81C
		[Register("onInvocationComplete", "(Lcom/unity3d/services/core/webview/bridge/CallbackStatus;)V", "")]
		public unsafe static void OnInvocationComplete(CallbackStatus status)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
				WebViewBridgeInvocationRunnable._members.StaticMethods.InvokeVoidMethod("onInvocationComplete.(Lcom/unity3d/services/core/webview/bridge/CallbackStatus;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(status);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000E680 File Offset: 0x0000C880
		private static Delegate GetRunHandler()
		{
			if (WebViewBridgeInvocationRunnable.cb_run == null)
			{
				WebViewBridgeInvocationRunnable.cb_run = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebViewBridgeInvocationRunnable.n_Run));
			}
			return WebViewBridgeInvocationRunnable.cb_run;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000E6A4 File Offset: 0x0000C8A4
		private static void n_Run(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebViewBridgeInvocationRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Run();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000E6B3 File Offset: 0x0000C8B3
		[Register("run", "()V", "GetRunHandler")]
		public virtual void Run()
		{
			WebViewBridgeInvocationRunnable._members.InstanceMethods.InvokeVirtualVoidMethod("run.()V", this, null);
		}

		// Token: 0x0400010E RID: 270
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocationRunnable", typeof(WebViewBridgeInvocationRunnable));

		// Token: 0x0400010F RID: 271
		private static Delegate cb_run;
	}
}
