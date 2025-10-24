using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Request.Metrics;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001F2 RID: 498
	[Register("com/unity3d/services/ads/operation/show/ShowModuleDecorator", DoNotGenerateAcw = true)]
	public class ShowModuleDecorator : Java.Lang.Object, IShowModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00041B48 File Offset: 0x0003FD48
		internal static IntPtr class_ref
		{
			get
			{
				return ShowModuleDecorator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00041B6C File Offset: 0x0003FD6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShowModuleDecorator._members;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00041B74 File Offset: 0x0003FD74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShowModuleDecorator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00041B98 File Offset: 0x0003FD98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShowModuleDecorator._members.ManagedPeerType;
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ShowModuleDecorator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00041BA4 File Offset: 0x0003FDA4
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/show/IShowModule;)V", "")]
		public unsafe ShowModuleDecorator(IShowModule showModule) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((showModule == null) ? IntPtr.Zero : ((Java.Lang.Object)showModule).Handle);
				base.SetHandle(ShowModuleDecorator._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/show/IShowModule;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ShowModuleDecorator._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/show/IShowModule;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(showModule);
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00041C58 File Offset: 0x0003FE58
		private static Delegate GetGetMetricSenderHandler()
		{
			if (ShowModuleDecorator.cb_getMetricSender == null)
			{
				ShowModuleDecorator.cb_getMetricSender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShowModuleDecorator.n_GetMetricSender));
			}
			return ShowModuleDecorator.cb_getMetricSender;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00041C7C File Offset: 0x0003FE7C
		private static IntPtr n_GetMetricSender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSender);
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00041C90 File Offset: 0x0003FE90
		public virtual ISDKMetrics MetricSender
		{
			[Register("getMetricSender", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", "GetGetMetricSenderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ISDKMetrics>(ShowModuleDecorator._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricSender.()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00041CC2 File Offset: 0x0003FEC2
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_Handler()
		{
			if (ShowModuleDecorator.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_ == null)
			{
				ShowModuleDecorator.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShowModuleDecorator.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_));
			}
			return ShowModuleDecorator.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_(IntPtr jnienv, IntPtr native__this, IntPtr native_webViewBridgeInvoker, IntPtr native_state)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_webViewBridgeInvoker, JniHandleOwnership.DoNotTransfer);
			ShowOperationState object3 = Java.Lang.Object.GetObject<ShowOperationState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00041D14 File Offset: 0x0003FF14
		[Register("executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/show/ShowOperationState;)V", "GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_Handler")]
		public unsafe virtual void ExecuteAdOperation(IWebViewBridgeInvoker webViewBridgeInvoker, ShowOperationState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewBridgeInvoker == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvoker).Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("executeAdOperation.(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/show/ShowOperationState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webViewBridgeInvoker);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00041DA4 File Offset: 0x0003FFA4
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (ShowModuleDecorator.cb_get_Ljava_lang_String_ == null)
			{
				ShowModuleDecorator.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ShowModuleDecorator.n_Get_Ljava_lang_String_));
			}
			return ShowModuleDecorator.cb_get_Ljava_lang_String_;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00041DC8 File Offset: 0x0003FFC8
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		[Register("get", "(Ljava/lang/String;)Lcom/unity3d/services/ads/operation/show/IShowOperation;", "GetGet_Ljava_lang_String_Handler")]
		public unsafe virtual IShowOperation Get(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			IShowOperation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IShowOperation>(ShowModuleDecorator._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/String;)Lcom/unity3d/services/ads/operation/show/IShowOperation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00041E5C File Offset: 0x0004005C
		private static Delegate GetOnUnityAdsShowClick_Ljava_lang_String_Handler()
		{
			if (ShowModuleDecorator.cb_onUnityAdsShowClick_Ljava_lang_String_ == null)
			{
				ShowModuleDecorator.cb_onUnityAdsShowClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModuleDecorator.n_OnUnityAdsShowClick_Ljava_lang_String_));
			}
			return ShowModuleDecorator.cb_onUnityAdsShowClick_Ljava_lang_String_;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00041E80 File Offset: 0x00040080
		private static void n_OnUnityAdsShowClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowClick(@string);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00041EA4 File Offset: 0x000400A4
		[Register("onUnityAdsShowClick", "(Ljava/lang/String;)V", "GetOnUnityAdsShowClick_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowClick(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowClick.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00041F00 File Offset: 0x00040100
		private static Delegate GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (ShowModuleDecorator.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				ShowModuleDecorator.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShowModuleDecorator.n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return ShowModuleDecorator.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00041F24 File Offset: 0x00040124
		private static void n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_state)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(@string, object2);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00041F50 File Offset: 0x00040150
		[Register("onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", "GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler")]
		public unsafe virtual void OnUnityAdsShowComplete(string id, UnityAds.UnityAdsShowCompletionState state)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowComplete.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00041FD4 File Offset: 0x000401D4
		private static Delegate GetOnUnityAdsShowConsent_Ljava_lang_String_Handler()
		{
			if (ShowModuleDecorator.cb_onUnityAdsShowConsent_Ljava_lang_String_ == null)
			{
				ShowModuleDecorator.cb_onUnityAdsShowConsent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModuleDecorator.n_OnUnityAdsShowConsent_Ljava_lang_String_));
			}
			return ShowModuleDecorator.cb_onUnityAdsShowConsent_Ljava_lang_String_;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00041FF8 File Offset: 0x000401F8
		private static void n_OnUnityAdsShowConsent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowConsent(@string);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0004201C File Offset: 0x0004021C
		[Register("onUnityAdsShowConsent", "(Ljava/lang/String;)V", "GetOnUnityAdsShowConsent_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowConsent(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowConsent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00042078 File Offset: 0x00040278
		private static Delegate GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (ShowModuleDecorator.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				ShowModuleDecorator.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ShowModuleDecorator.n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return ShowModuleDecorator.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0004209C File Offset: 0x0004029C
		private static void n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_error, IntPtr native_message)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_error, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(@string, object2, string2);
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000420D4 File Offset: 0x000402D4
		[Register("onUnityAdsShowFailure", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", "GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowFailure(string id, UnityAds.UnityAdsShowError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowFailure.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0004217C File Offset: 0x0004037C
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (ShowModuleDecorator.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				ShowModuleDecorator.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModuleDecorator.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return ShowModuleDecorator.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x000421A0 File Offset: 0x000403A0
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000421C4 File Offset: 0x000403C4
		[Register("onUnityAdsShowStart", "(Ljava/lang/String;)V", "GetOnUnityAdsShowStart_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowStart(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowStart.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00042220 File Offset: 0x00040420
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (ShowModuleDecorator.cb_remove_Ljava_lang_String_ == null)
			{
				ShowModuleDecorator.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModuleDecorator.n_Remove_Ljava_lang_String_));
			}
			return ShowModuleDecorator.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00042244 File Offset: 0x00040444
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00042268 File Offset: 0x00040468
		[Register("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public unsafe virtual void Remove(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x000422C4 File Offset: 0x000404C4
		private static Delegate GetSet_Lcom_unity3d_services_ads_operation_show_IShowOperation_Handler()
		{
			if (ShowModuleDecorator.cb_set_Lcom_unity3d_services_ads_operation_show_IShowOperation_ == null)
			{
				ShowModuleDecorator.cb_set_Lcom_unity3d_services_ads_operation_show_IShowOperation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModuleDecorator.n_Set_Lcom_unity3d_services_ads_operation_show_IShowOperation_));
			}
			return ShowModuleDecorator.cb_set_Lcom_unity3d_services_ads_operation_show_IShowOperation_;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x000422E8 File Offset: 0x000404E8
		private static void n_Set_Lcom_unity3d_services_ads_operation_show_IShowOperation_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedObject)
		{
			ShowModuleDecorator @object = Java.Lang.Object.GetObject<ShowModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IShowOperation object2 = Java.Lang.Object.GetObject<IShowOperation>(native_sharedObject, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0004230C File Offset: 0x0004050C
		[Register("set", "(Lcom/unity3d/services/ads/operation/show/IShowOperation;)V", "GetSet_Lcom_unity3d_services_ads_operation_show_IShowOperation_Handler")]
		public unsafe virtual void Set(IShowOperation sharedObject)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sharedObject == null) ? IntPtr.Zero : ((Java.Lang.Object)sharedObject).Handle);
				ShowModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Lcom/unity3d/services/ads/operation/show/IShowOperation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sharedObject);
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00002226 File Offset: 0x00000426
		public void ExecuteAdOperation(IWebViewBridgeInvoker p0, Java.Lang.Object p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00002226 File Offset: 0x00000426
		Java.Lang.Object IWebViewBridgeSharedObjectStore.Get(string p0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00002226 File Offset: 0x00000426
		public void Set(Java.Lang.Object p0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000582 RID: 1410
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/ShowModuleDecorator", typeof(ShowModuleDecorator));

		// Token: 0x04000583 RID: 1411
		private static Delegate cb_getMetricSender;

		// Token: 0x04000584 RID: 1412
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_;

		// Token: 0x04000585 RID: 1413
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x04000586 RID: 1414
		private static Delegate cb_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000587 RID: 1415
		private static Delegate cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000588 RID: 1416
		private static Delegate cb_onUnityAdsShowConsent_Ljava_lang_String_;

		// Token: 0x04000589 RID: 1417
		private static Delegate cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x0400058A RID: 1418
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;

		// Token: 0x0400058B RID: 1419
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x0400058C RID: 1420
		private static Delegate cb_set_Lcom_unity3d_services_ads_operation_show_IShowOperation_;
	}
}
