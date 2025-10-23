using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000193 RID: 403
	[Register("com/unity3d/services/core/api/Sdk", DoNotGenerateAcw = true)]
	public class Sdk : Java.Lang.Object
	{
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00033AA8 File Offset: 0x00031CA8
		internal static IntPtr class_ref
		{
			get
			{
				return Sdk._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00033ACC File Offset: 0x00031CCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Sdk._members;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00033AD4 File Offset: 0x00031CD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Sdk._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00033AF8 File Offset: 0x00031CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Sdk._members.ManagedPeerType;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Sdk(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00033B04 File Offset: 0x00031D04
		[Register(".ctor", "()V", "")]
		public Sdk() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Sdk._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Sdk._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00033B74 File Offset: 0x00031D74
		[Register("downloadLatestWebView", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void DownloadLatestWebView(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("downloadLatestWebView.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00033BD8 File Offset: 0x00031DD8
		[Register("getDebugMode", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetDebugMode(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("getDebugMode.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00033C3C File Offset: 0x00031E3C
		[Register("getTrrData", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTrrData(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("getTrrData.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00033CA0 File Offset: 0x00031EA0
		[Register("initComplete", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void InitComplete(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("initComplete.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00033D04 File Offset: 0x00031F04
		[Register("initError", "(Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void InitError(string message, Integer code, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((code == null) ? IntPtr.Zero : code.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("initError.(Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(code);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00033DB4 File Offset: 0x00031FB4
		[Register("loadComplete", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void LoadComplete(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("loadComplete.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00033E18 File Offset: 0x00032018
		[Register("logDebug", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void LogDebug(string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("logDebug.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00033E9C File Offset: 0x0003209C
		[Register("logError", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void LogError(string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("logError.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00033F20 File Offset: 0x00032120
		[Register("logInfo", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void LogInfo(string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("logInfo.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00033FA4 File Offset: 0x000321A4
		[Register("logWarning", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void LogWarning(string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("logWarning.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00034028 File Offset: 0x00032228
		[Register("reinitialize", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Reinitialize(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("reinitialize.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0003408C File Offset: 0x0003228C
		[Register("setDebugMode", "(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetDebugMode(Java.Lang.Boolean debugMode, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((debugMode == null) ? IntPtr.Zero : debugMode.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Sdk._members.StaticMethods.InvokeVoidMethod("setDebugMode.(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(debugMode);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000456 RID: 1110
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Sdk", typeof(Sdk));
	}
}
