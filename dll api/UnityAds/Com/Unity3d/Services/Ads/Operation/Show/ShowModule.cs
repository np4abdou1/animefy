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
	// Token: 0x020001F1 RID: 497
	[Register("com/unity3d/services/ads/operation/show/ShowModule", DoNotGenerateAcw = true)]
	public class ShowModule : AdModule, IShowModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x000414CC File Offset: 0x0003F6CC
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x000414FC File Offset: 0x0003F6FC
		[Register("errorMsgPlacementIdNull")]
		public static string ErrorMsgPlacementIdNull
		{
			get
			{
				return JNIEnv.GetString(ShowModule._members.StaticFields.GetObjectValue("errorMsgPlacementIdNull.Ljava/lang/String;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					ShowModule._members.StaticFields.SetValue("errorMsgPlacementIdNull.Ljava/lang/String;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00041544 File Offset: 0x0003F744
		internal new static IntPtr class_ref
		{
			get
			{
				return ShowModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x00041568 File Offset: 0x0003F768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShowModule._members;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00041570 File Offset: 0x0003F770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShowModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00041594 File Offset: 0x0003F794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShowModule._members.ManagedPeerType;
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0003F779 File Offset: 0x0003D979
		protected ShowModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000415A0 File Offset: 0x0003F7A0
		[Register(".ctor", "(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", "")]
		public unsafe ShowModule(ISDKMetrics sdkMetrics) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sdkMetrics == null) ? IntPtr.Zero : ((Java.Lang.Object)sdkMetrics).Handle);
				base.SetHandle(ShowModule._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ShowModule._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sdkMetrics);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x00041654 File Offset: 0x0003F854
		public static IShowModule Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/ads/operation/show/IShowModule;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IShowModule>(ShowModule._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/ads/operation/show/IShowModule;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00041685 File Offset: 0x0003F885
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_Handler()
		{
			if (ShowModule.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_ == null)
			{
				ShowModule.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShowModule.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_));
			}
			return ShowModule.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000416AC File Offset: 0x0003F8AC
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_(IntPtr jnienv, IntPtr native__this, IntPtr native_webViewBridgeInvoker, IntPtr native_state)
		{
			ShowModule @object = Java.Lang.Object.GetObject<ShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_webViewBridgeInvoker, JniHandleOwnership.DoNotTransfer);
			ShowOperationState object3 = Java.Lang.Object.GetObject<ShowOperationState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000416D8 File Offset: 0x0003F8D8
		[Register("executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/show/ShowOperationState;)V", "GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_Handler")]
		public unsafe virtual void ExecuteAdOperation(IWebViewBridgeInvoker webViewBridgeInvoker, ShowOperationState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewBridgeInvoker == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvoker).Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ShowModule._members.InstanceMethods.InvokeVirtualVoidMethod("executeAdOperation.(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/show/ShowOperationState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webViewBridgeInvoker);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00041768 File Offset: 0x0003F968
		private static Delegate GetOnUnityAdsShowClick_Ljava_lang_String_Handler()
		{
			if (ShowModule.cb_onUnityAdsShowClick_Ljava_lang_String_ == null)
			{
				ShowModule.cb_onUnityAdsShowClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModule.n_OnUnityAdsShowClick_Ljava_lang_String_));
			}
			return ShowModule.cb_onUnityAdsShowClick_Ljava_lang_String_;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0004178C File Offset: 0x0003F98C
		private static void n_OnUnityAdsShowClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModule @object = Java.Lang.Object.GetObject<ShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowClick(@string);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000417B0 File Offset: 0x0003F9B0
		[Register("onUnityAdsShowClick", "(Ljava/lang/String;)V", "GetOnUnityAdsShowClick_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowClick(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowClick.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0004180C File Offset: 0x0003FA0C
		private static Delegate GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (ShowModule.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				ShowModule.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShowModule.n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return ShowModule.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00041830 File Offset: 0x0003FA30
		private static void n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_state)
		{
			ShowModule @object = Java.Lang.Object.GetObject<ShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(@string, object2);
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0004185C File Offset: 0x0003FA5C
		[Register("onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", "GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler")]
		public unsafe virtual void OnUnityAdsShowComplete(string id, UnityAds.UnityAdsShowCompletionState state)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ShowModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowComplete.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000418E0 File Offset: 0x0003FAE0
		private static Delegate GetOnUnityAdsShowConsent_Ljava_lang_String_Handler()
		{
			if (ShowModule.cb_onUnityAdsShowConsent_Ljava_lang_String_ == null)
			{
				ShowModule.cb_onUnityAdsShowConsent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModule.n_OnUnityAdsShowConsent_Ljava_lang_String_));
			}
			return ShowModule.cb_onUnityAdsShowConsent_Ljava_lang_String_;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00041904 File Offset: 0x0003FB04
		private static void n_OnUnityAdsShowConsent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModule @object = Java.Lang.Object.GetObject<ShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowConsent(@string);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00041928 File Offset: 0x0003FB28
		[Register("onUnityAdsShowConsent", "(Ljava/lang/String;)V", "GetOnUnityAdsShowConsent_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowConsent(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowConsent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00041984 File Offset: 0x0003FB84
		private static Delegate GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (ShowModule.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				ShowModule.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ShowModule.n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return ShowModule.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000419A8 File Offset: 0x0003FBA8
		private static void n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_error, IntPtr native_message)
		{
			ShowModule @object = Java.Lang.Object.GetObject<ShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_error, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(@string, object2, string2);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000419E0 File Offset: 0x0003FBE0
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
				ShowModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowFailure.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00041A88 File Offset: 0x0003FC88
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (ShowModule.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				ShowModule.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowModule.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return ShowModule.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00041AAC File Offset: 0x0003FCAC
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			ShowModule @object = Java.Lang.Object.GetObject<ShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00041AD0 File Offset: 0x0003FCD0
		[Register("onUnityAdsShowStart", "(Ljava/lang/String;)V", "GetOnUnityAdsShowStart_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowStart(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowStart.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400057B RID: 1403
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/ShowModule", typeof(ShowModule));

		// Token: 0x0400057C RID: 1404
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_show_ShowOperationState_;

		// Token: 0x0400057D RID: 1405
		private static Delegate cb_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x0400057E RID: 1406
		private static Delegate cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x0400057F RID: 1407
		private static Delegate cb_onUnityAdsShowConsent_Ljava_lang_String_;

		// Token: 0x04000580 RID: 1408
		private static Delegate cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000581 RID: 1409
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;
	}
}
