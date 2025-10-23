using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000227 RID: 551
	[Register("com/unity3d/services/ads/api/WebPlayer", DoNotGenerateAcw = true)]
	public class WebPlayer : Java.Lang.Object
	{
		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0004C1F8 File Offset: 0x0004A3F8
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0004C21C File Offset: 0x0004A41C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayer._members;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x0004C224 File Offset: 0x0004A424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0004C248 File Offset: 0x0004A448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayer._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebPlayer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0004C254 File Offset: 0x0004A454
		[Register(".ctor", "()V", "")]
		public WebPlayer() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebPlayer._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebPlayer._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0004C2C4 File Offset: 0x0004A4C4
		[Register("clearSettings", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void ClearSettings(string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("clearSettings.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0004C348 File Offset: 0x0004A548
		[Register("getErroredSettings", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetErroredSettings(string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("getErroredSettings.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0004C3CC File Offset: 0x0004A5CC
		[Register("getFrame", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFrame(string callId, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(callId);
			IntPtr intPtr2 = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("getFrame.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0004C474 File Offset: 0x0004A674
		[Register("sendEvent", "(Lorg/json/JSONArray;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendEvent(JSONArray parameters, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parameters == null) ? IntPtr.Zero : parameters.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("sendEvent.(Lorg/json/JSONArray;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parameters);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0004C524 File Offset: 0x0004A724
		[Register("setData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetData(string data, string mimeType, string encoding, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(data);
			IntPtr intPtr2 = JNIEnv.NewString(mimeType);
			IntPtr intPtr3 = JNIEnv.NewString(encoding);
			IntPtr intPtr4 = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("setData.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0004C61C File Offset: 0x0004A81C
		[Register("setDataWithUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetDataWithUrl(string baseUrl, string data, string mimeType, string encoding, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(baseUrl);
			IntPtr intPtr2 = JNIEnv.NewString(data);
			IntPtr intPtr3 = JNIEnv.NewString(mimeType);
			IntPtr intPtr4 = JNIEnv.NewString(encoding);
			IntPtr intPtr5 = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("setDataWithUrl.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0004C73C File Offset: 0x0004A93C
		[Register("setEventSettings", "(Lorg/json/JSONObject;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetEventSettings(JSONObject eventSettings, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventSettings == null) ? IntPtr.Zero : eventSettings.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("setEventSettings.(Lorg/json/JSONObject;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(eventSettings);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0004C7EC File Offset: 0x0004A9EC
		[Register("setSettings", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetSettings(JSONObject webSettings, JSONObject webPlayerSettings, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webSettings == null) ? IntPtr.Zero : webSettings.Handle);
				ptr[1] = new JniArgumentValue((webPlayerSettings == null) ? IntPtr.Zero : webPlayerSettings.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("setSettings.(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(webSettings);
				GC.KeepAlive(webPlayerSettings);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0004C8C4 File Offset: 0x0004AAC4
		[Register("setUrl", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetUrl(string url, string viewId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebPlayer._members.StaticMethods.InvokeVoidMethod("setUrl.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400065E RID: 1630
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/WebPlayer", typeof(WebPlayer));
	}
}
