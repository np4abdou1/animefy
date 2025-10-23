using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Unity3d.Services.Core.Webview
{
	// Token: 0x0200006E RID: 110
	[Register("com/unity3d/services/core/webview/WebViewApp", DoNotGenerateAcw = true)]
	public class WebViewApp : Java.Lang.Object, IWebViewBridgeInvoker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00009F0C File Offset: 0x0000810C
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewApp._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00009F30 File Offset: 0x00008130
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewApp._members;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00009F38 File Offset: 0x00008138
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewApp._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00009F5C File Offset: 0x0000815C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewApp._members.ManagedPeerType;
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewApp(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00009F68 File Offset: 0x00008168
		[Register(".ctor", "()V", "")]
		public WebViewApp() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewApp._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewApp._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00009FD6 File Offset: 0x000081D6
		private static Delegate GetGetConfigurationHandler()
		{
			if (WebViewApp.cb_getConfiguration == null)
			{
				WebViewApp.cb_getConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewApp.n_GetConfiguration));
			}
			return WebViewApp.cb_getConfiguration;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00009FFA File Offset: 0x000081FA
		private static IntPtr n_GetConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Configuration);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000A00E File Offset: 0x0000820E
		private static Delegate GetSetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (WebViewApp.cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				WebViewApp.cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewApp.n_SetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return WebViewApp.cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000A034 File Offset: 0x00008234
		private static void n_SetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			@object.Configuration = object2;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000A058 File Offset: 0x00008258
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0000A08C File Offset: 0x0000828C
		public unsafe virtual Configuration Configuration
		{
			[Register("getConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;", "GetGetConfigurationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(WebViewApp._members.InstanceMethods.InvokeVirtualObjectMethod("getConfiguration.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setConfiguration", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "GetSetConfiguration_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("setConfiguration.(Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000A0F0 File Offset: 0x000082F0
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0000A124 File Offset: 0x00008324
		public unsafe static WebViewApp CurrentApp
		{
			[Register("getCurrentApp", "()Lcom/unity3d/services/core/webview/WebViewApp;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WebViewApp>(WebViewApp._members.StaticMethods.InvokeObjectMethod("getCurrentApp.()Lcom/unity3d/services/core/webview/WebViewApp;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCurrentApp", "(Lcom/unity3d/services/core/webview/WebViewApp;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					WebViewApp._members.StaticMethods.InvokeVoidMethod("setCurrentApp.(Lcom/unity3d/services/core/webview/WebViewApp;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000A188 File Offset: 0x00008388
		private static Delegate GetGetErrorStateFromWebAppCodeHandler()
		{
			if (WebViewApp.cb_getErrorStateFromWebAppCode == null)
			{
				WebViewApp.cb_getErrorStateFromWebAppCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewApp.n_GetErrorStateFromWebAppCode));
			}
			return WebViewApp.cb_getErrorStateFromWebAppCode;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000A1AC File Offset: 0x000083AC
		private static IntPtr n_GetErrorStateFromWebAppCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorStateFromWebAppCode);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public virtual ErrorState ErrorStateFromWebAppCode
		{
			[Register("getErrorStateFromWebAppCode", "()Lcom/unity3d/services/core/configuration/ErrorState;", "GetGetErrorStateFromWebAppCodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(WebViewApp._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorStateFromWebAppCode.()Lcom/unity3d/services/core/configuration/ErrorState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000A1F2 File Offset: 0x000083F2
		private static Delegate GetGetWebAppFailureCodeHandler()
		{
			if (WebViewApp.cb_getWebAppFailureCode == null)
			{
				WebViewApp.cb_getWebAppFailureCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebViewApp.n_GetWebAppFailureCode));
			}
			return WebViewApp.cb_getWebAppFailureCode;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000A216 File Offset: 0x00008416
		private static int n_GetWebAppFailureCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppFailureCode;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000A225 File Offset: 0x00008425
		private static Delegate GetSetWebAppFailureCode_IHandler()
		{
			if (WebViewApp.cb_setWebAppFailureCode_I == null)
			{
				WebViewApp.cb_setWebAppFailureCode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(WebViewApp.n_SetWebAppFailureCode_I));
			}
			return WebViewApp.cb_setWebAppFailureCode_I;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000A249 File Offset: 0x00008449
		private static void n_SetWebAppFailureCode_I(IntPtr jnienv, IntPtr native__this, int code)
		{
			Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppFailureCode = code;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000A259 File Offset: 0x00008459
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0000A274 File Offset: 0x00008474
		public unsafe virtual int WebAppFailureCode
		{
			[Register("getWebAppFailureCode", "()I", "GetGetWebAppFailureCodeHandler")]
			get
			{
				return WebViewApp._members.InstanceMethods.InvokeVirtualInt32Method("getWebAppFailureCode.()I", this, null);
			}
			[Register("setWebAppFailureCode", "(I)V", "GetSetWebAppFailureCode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("setWebAppFailureCode.(I)V", this, ptr);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000A2AF File Offset: 0x000084AF
		private static Delegate GetGetWebAppFailureMessageHandler()
		{
			if (WebViewApp.cb_getWebAppFailureMessage == null)
			{
				WebViewApp.cb_getWebAppFailureMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewApp.n_GetWebAppFailureMessage));
			}
			return WebViewApp.cb_getWebAppFailureMessage;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000A2D3 File Offset: 0x000084D3
		private static IntPtr n_GetWebAppFailureMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppFailureMessage);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000A2E7 File Offset: 0x000084E7
		private static Delegate GetSetWebAppFailureMessage_Ljava_lang_String_Handler()
		{
			if (WebViewApp.cb_setWebAppFailureMessage_Ljava_lang_String_ == null)
			{
				WebViewApp.cb_setWebAppFailureMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewApp.n_SetWebAppFailureMessage_Ljava_lang_String_));
			}
			return WebViewApp.cb_setWebAppFailureMessage_Ljava_lang_String_;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000A30C File Offset: 0x0000850C
		private static void n_SetWebAppFailureMessage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.WebAppFailureMessage = @string;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000A330 File Offset: 0x00008530
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0000A364 File Offset: 0x00008564
		public unsafe virtual string WebAppFailureMessage
		{
			[Register("getWebAppFailureMessage", "()Ljava/lang/String;", "GetGetWebAppFailureMessageHandler")]
			get
			{
				return JNIEnv.GetString(WebViewApp._members.InstanceMethods.InvokeVirtualObjectMethod("getWebAppFailureMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setWebAppFailureMessage", "(Ljava/lang/String;)V", "GetSetWebAppFailureMessage_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("setWebAppFailureMessage.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000A3C0 File Offset: 0x000085C0
		private static Delegate GetIsWebAppInitializedHandler()
		{
			if (WebViewApp.cb_isWebAppInitialized == null)
			{
				WebViewApp.cb_isWebAppInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WebViewApp.n_IsWebAppInitialized));
			}
			return WebViewApp.cb_isWebAppInitialized;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000A3E4 File Offset: 0x000085E4
		private static bool n_IsWebAppInitialized(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppInitialized;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000A3F3 File Offset: 0x000085F3
		private static Delegate GetSetWebAppInitialized_ZHandler()
		{
			if (WebViewApp.cb_setWebAppInitialized_Z == null)
			{
				WebViewApp.cb_setWebAppInitialized_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebViewApp.n_SetWebAppInitialized_Z));
			}
			return WebViewApp.cb_setWebAppInitialized_Z;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000A417 File Offset: 0x00008617
		private static void n_SetWebAppInitialized_Z(IntPtr jnienv, IntPtr native__this, bool initialized)
		{
			Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppInitialized = initialized;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000A427 File Offset: 0x00008627
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000A440 File Offset: 0x00008640
		public unsafe virtual bool WebAppInitialized
		{
			[Register("isWebAppInitialized", "()Z", "GetIsWebAppInitializedHandler")]
			get
			{
				return WebViewApp._members.InstanceMethods.InvokeVirtualBooleanMethod("isWebAppInitialized.()Z", this, null);
			}
			[Register("setWebAppInitialized", "(Z)V", "GetSetWebAppInitialized_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("setWebAppInitialized.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000A47B File Offset: 0x0000867B
		private static Delegate GetIsWebAppLoadedHandler()
		{
			if (WebViewApp.cb_isWebAppLoaded == null)
			{
				WebViewApp.cb_isWebAppLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WebViewApp.n_IsWebAppLoaded));
			}
			return WebViewApp.cb_isWebAppLoaded;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000A49F File Offset: 0x0000869F
		private static bool n_IsWebAppLoaded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppLoaded;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000A4AE File Offset: 0x000086AE
		private static Delegate GetSetWebAppLoaded_ZHandler()
		{
			if (WebViewApp.cb_setWebAppLoaded_Z == null)
			{
				WebViewApp.cb_setWebAppLoaded_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebViewApp.n_SetWebAppLoaded_Z));
			}
			return WebViewApp.cb_setWebAppLoaded_Z;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000A4D2 File Offset: 0x000086D2
		private static void n_SetWebAppLoaded_Z(IntPtr jnienv, IntPtr native__this, bool loaded)
		{
			Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebAppLoaded = loaded;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000A4E2 File Offset: 0x000086E2
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000A4FC File Offset: 0x000086FC
		public unsafe virtual bool WebAppLoaded
		{
			[Register("isWebAppLoaded", "()Z", "GetIsWebAppLoadedHandler")]
			get
			{
				return WebViewApp._members.InstanceMethods.InvokeVirtualBooleanMethod("isWebAppLoaded.()Z", this, null);
			}
			[Register("setWebAppLoaded", "(Z)V", "GetSetWebAppLoaded_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("setWebAppLoaded.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000A537 File Offset: 0x00008737
		private static Delegate GetGetWebViewHandler()
		{
			if (WebViewApp.cb_getWebView == null)
			{
				WebViewApp.cb_getWebView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewApp.n_GetWebView));
			}
			return WebViewApp.cb_getWebView;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000A55B File Offset: 0x0000875B
		private static IntPtr n_GetWebView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebView);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000A56F File Offset: 0x0000876F
		private static Delegate GetSetWebView_Lcom_unity3d_services_core_webview_WebView_Handler()
		{
			if (WebViewApp.cb_setWebView_Lcom_unity3d_services_core_webview_WebView_ == null)
			{
				WebViewApp.cb_setWebView_Lcom_unity3d_services_core_webview_WebView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewApp.n_SetWebView_Lcom_unity3d_services_core_webview_WebView_));
			}
			return WebViewApp.cb_setWebView_Lcom_unity3d_services_core_webview_WebView_;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000A594 File Offset: 0x00008794
		private static void n_SetWebView_Lcom_unity3d_services_core_webview_WebView_(IntPtr jnienv, IntPtr native__this, IntPtr native_webView)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebView object2 = Java.Lang.Object.GetObject<WebView>(native_webView, JniHandleOwnership.DoNotTransfer);
			@object.WebView = object2;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000A5B8 File Offset: 0x000087B8
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0000A5EC File Offset: 0x000087EC
		public unsafe virtual WebView WebView
		{
			[Register("getWebView", "()Lcom/unity3d/services/core/webview/WebView;", "GetGetWebViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<WebView>(WebViewApp._members.InstanceMethods.InvokeVirtualObjectMethod("getWebView.()Lcom/unity3d/services/core/webview/WebView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setWebView", "(Lcom/unity3d/services/core/webview/WebView;)V", "GetSetWebView_Lcom_unity3d_services_core_webview_WebView_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("setWebView.(Lcom/unity3d/services/core/webview/WebView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A650 File Offset: 0x00008850
		private static Delegate GetAddCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_Handler()
		{
			if (WebViewApp.cb_addCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_ == null)
			{
				WebViewApp.cb_addCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewApp.n_AddCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_));
			}
			return WebViewApp.cb_addCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A674 File Offset: 0x00008874
		private static void n_AddCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			NativeCallback object2 = Java.Lang.Object.GetObject<NativeCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.AddCallback(object2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A698 File Offset: 0x00008898
		[Register("addCallback", "(Lcom/unity3d/services/core/webview/bridge/NativeCallback;)V", "GetAddCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_Handler")]
		public unsafe virtual void AddCallback(NativeCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("addCallback.(Lcom/unity3d/services/core/webview/bridge/NativeCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A6FC File Offset: 0x000088FC
		[Register("create", "(Lcom/unity3d/services/core/configuration/Configuration;)Lcom/unity3d/services/core/configuration/ErrorState;", "")]
		public unsafe static ErrorState Create(Configuration configuration)
		{
			ErrorState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				@object = Java.Lang.Object.GetObject<ErrorState>(WebViewApp._members.StaticMethods.InvokeObjectMethod("create.(Lcom/unity3d/services/core/configuration/Configuration;)Lcom/unity3d/services/core/configuration/ErrorState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return @object;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A770 File Offset: 0x00008970
		[Register("create", "(Lcom/unity3d/services/core/configuration/Configuration;Z)Lcom/unity3d/services/core/configuration/ErrorState;", "")]
		public unsafe static ErrorState Create(Configuration configuration, bool useRemoteUrl)
		{
			ErrorState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				ptr[1] = new JniArgumentValue(useRemoteUrl);
				@object = Java.Lang.Object.GetObject<ErrorState>(WebViewApp._members.StaticMethods.InvokeObjectMethod("create.(Lcom/unity3d/services/core/configuration/Configuration;Z)Lcom/unity3d/services/core/configuration/ErrorState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
			return @object;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000A7F8 File Offset: 0x000089F8
		private static Delegate GetGetCallback_Ljava_lang_String_Handler()
		{
			if (WebViewApp.cb_getCallback_Ljava_lang_String_ == null)
			{
				WebViewApp.cb_getCallback_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebViewApp.n_GetCallback_Ljava_lang_String_));
			}
			return WebViewApp.cb_getCallback_Ljava_lang_String_;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000A81C File Offset: 0x00008A1C
		private static IntPtr n_GetCallback_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_callbackId)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_callbackId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetCallback(@string));
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000A844 File Offset: 0x00008A44
		[Register("getCallback", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/NativeCallback;", "GetGetCallback_Ljava_lang_String_Handler")]
		public unsafe virtual NativeCallback GetCallback(string callbackId)
		{
			IntPtr intPtr = JNIEnv.NewString(callbackId);
			NativeCallback @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<NativeCallback>(WebViewApp._members.InstanceMethods.InvokeVirtualObjectMethod("getCallback.(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/NativeCallback;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		private static Delegate GetInvokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_Handler()
		{
			if (WebViewApp.cb_invokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_ == null)
			{
				WebViewApp.cb_invokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(WebViewApp.n_InvokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_));
			}
			return WebViewApp.cb_invokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		private static bool n_InvokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_(IntPtr jnienv, IntPtr native__this, IntPtr native_invocation)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Invocation2 object2 = Java.Lang.Object.GetObject<Invocation2>(native_invocation, JniHandleOwnership.DoNotTransfer);
			return @object.InvokeCallback(object2);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		[Register("invokeCallback", "(Lcom/unity3d/services/core/webview/bridge/Invocation;)Z", "GetInvokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_Handler")]
		public unsafe virtual bool InvokeCallback(Invocation2 invocation)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((invocation == null) ? IntPtr.Zero : invocation.Handle);
				result = WebViewApp._members.InstanceMethods.InvokeVirtualBooleanMethod("invokeCallback.(Lcom/unity3d/services/core/webview/bridge/Invocation;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(invocation);
			}
			return result;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000A960 File Offset: 0x00008B60
		private static Delegate GetInvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler()
		{
			if (WebViewApp.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
			{
				WebViewApp.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_Z(WebViewApp.n_InvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_));
			}
			return WebViewApp.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000A984 File Offset: 0x00008B84
		private static bool n_InvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_className, IntPtr native_methodName, IntPtr native__callback, IntPtr native__params)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_className, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_methodName, JniHandleOwnership.DoNotTransfer);
			Method object2 = Java.Lang.Object.GetObject<Method>(native__callback, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			bool result = @object.InvokeMethod(@string, string2, object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
			return result;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Register("invokeMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", "GetInvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public unsafe virtual bool InvokeMethod(string className, string methodName, Method callback, params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(@params);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				ptr[3] = new JniArgumentValue(intPtr3);
				result = WebViewApp._members.InstanceMethods.InvokeVirtualBooleanMethod("invokeMethod.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, @params);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(callback);
				GC.KeepAlive(@params);
			}
			return result;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		private static Delegate GetRemoveCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_Handler()
		{
			if (WebViewApp.cb_removeCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_ == null)
			{
				WebViewApp.cb_removeCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewApp.n_RemoveCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_));
			}
			return WebViewApp.cb_removeCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		private static void n_RemoveCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			NativeCallback object2 = Java.Lang.Object.GetObject<NativeCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000AB0C File Offset: 0x00008D0C
		[Register("removeCallback", "(Lcom/unity3d/services/core/webview/bridge/NativeCallback;)V", "GetRemoveCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_Handler")]
		public unsafe virtual void RemoveCallback(NativeCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("removeCallback.(Lcom/unity3d/services/core/webview/bridge/NativeCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000AB70 File Offset: 0x00008D70
		private static Delegate GetResetWebViewAppInitializationHandler()
		{
			if (WebViewApp.cb_resetWebViewAppInitialization == null)
			{
				WebViewApp.cb_resetWebViewAppInitialization = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebViewApp.n_ResetWebViewAppInitialization));
			}
			return WebViewApp.cb_resetWebViewAppInitialization;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000AB94 File Offset: 0x00008D94
		private static void n_ResetWebViewAppInitialization(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetWebViewAppInitialization();
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000ABA3 File Offset: 0x00008DA3
		[Register("resetWebViewAppInitialization", "()V", "GetResetWebViewAppInitializationHandler")]
		public virtual void ResetWebViewAppInitialization()
		{
			WebViewApp._members.InstanceMethods.InvokeVirtualVoidMethod("resetWebViewAppInitialization.()V", this, null);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000ABBC File Offset: 0x00008DBC
		private static Delegate GetSendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_Handler()
		{
			if (WebViewApp.cb_sendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_ == null)
			{
				WebViewApp.cb_sendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(WebViewApp.n_SendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_));
			}
			return WebViewApp.cb_sendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		private static bool n_SendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_eventCategory, IntPtr native_eventId, IntPtr native__params)
		{
			WebViewApp @object = Java.Lang.Object.GetObject<WebViewApp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Enum object2 = Java.Lang.Object.GetObject<Java.Lang.Enum>(native_eventCategory, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Enum object3 = Java.Lang.Object.GetObject<Java.Lang.Enum>(native_eventId, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			bool result = @object.SendEvent(object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
			return result;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000AC30 File Offset: 0x00008E30
		[Register("sendEvent", "(Ljava/lang/Enum;Ljava/lang/Enum;[Ljava/lang/Object;)Z", "GetSendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_Handler")]
		public unsafe virtual bool SendEvent(Java.Lang.Enum eventCategory, Java.Lang.Enum eventId, params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(@params);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventCategory == null) ? IntPtr.Zero : eventCategory.Handle);
				ptr[1] = new JniArgumentValue((eventId == null) ? IntPtr.Zero : eventId.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				result = WebViewApp._members.InstanceMethods.InvokeVirtualBooleanMethod("sendEvent.(Ljava/lang/Enum;Ljava/lang/Enum;[Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, @params);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(eventCategory);
				GC.KeepAlive(eventId);
				GC.KeepAlive(@params);
			}
			return result;
		}

		// Token: 0x040000AE RID: 174
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/WebViewApp", typeof(WebViewApp));

		// Token: 0x040000AF RID: 175
		private static Delegate cb_getConfiguration;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_setConfiguration_Lcom_unity3d_services_core_configuration_Configuration_;

		// Token: 0x040000B1 RID: 177
		private static Delegate cb_getErrorStateFromWebAppCode;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_getWebAppFailureCode;

		// Token: 0x040000B3 RID: 179
		private static Delegate cb_setWebAppFailureCode_I;

		// Token: 0x040000B4 RID: 180
		private static Delegate cb_getWebAppFailureMessage;

		// Token: 0x040000B5 RID: 181
		private static Delegate cb_setWebAppFailureMessage_Ljava_lang_String_;

		// Token: 0x040000B6 RID: 182
		private static Delegate cb_isWebAppInitialized;

		// Token: 0x040000B7 RID: 183
		private static Delegate cb_setWebAppInitialized_Z;

		// Token: 0x040000B8 RID: 184
		private static Delegate cb_isWebAppLoaded;

		// Token: 0x040000B9 RID: 185
		private static Delegate cb_setWebAppLoaded_Z;

		// Token: 0x040000BA RID: 186
		private static Delegate cb_getWebView;

		// Token: 0x040000BB RID: 187
		private static Delegate cb_setWebView_Lcom_unity3d_services_core_webview_WebView_;

		// Token: 0x040000BC RID: 188
		private static Delegate cb_addCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_getCallback_Ljava_lang_String_;

		// Token: 0x040000BE RID: 190
		private static Delegate cb_invokeCallback_Lcom_unity3d_services_core_webview_bridge_Invocation_;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;

		// Token: 0x040000C0 RID: 192
		private static Delegate cb_removeCallback_Lcom_unity3d_services_core_webview_bridge_NativeCallback_;

		// Token: 0x040000C1 RID: 193
		private static Delegate cb_resetWebViewAppInitialization;

		// Token: 0x040000C2 RID: 194
		private static Delegate cb_sendEvent_Ljava_lang_Enum_Ljava_lang_Enum_arrayLjava_lang_Object_;
	}
}
