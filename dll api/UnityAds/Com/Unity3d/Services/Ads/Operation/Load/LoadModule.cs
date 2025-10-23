using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Request.Metrics;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001FA RID: 506
	[Register("com/unity3d/services/ads/operation/load/LoadModule", DoNotGenerateAcw = true)]
	public class LoadModule : AdModule, ILoadModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00043B40 File Offset: 0x00041D40
		internal new static IntPtr class_ref
		{
			get
			{
				return LoadModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00043B64 File Offset: 0x00041D64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadModule._members;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00043B6C File Offset: 0x00041D6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00043B90 File Offset: 0x00041D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadModule._members.ManagedPeerType;
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0003F779 File Offset: 0x0003D979
		protected LoadModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00043B9C File Offset: 0x00041D9C
		[Register(".ctor", "(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", "")]
		public unsafe LoadModule(ISDKMetrics sdkMetrics) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sdkMetrics == null) ? IntPtr.Zero : ((Java.Lang.Object)sdkMetrics).Handle);
				base.SetHandle(LoadModule._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadModule._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/request/metrics/ISDKMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sdkMetrics);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00043C50 File Offset: 0x00041E50
		public static ILoadModule Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/ads/operation/load/ILoadModule;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ILoadModule>(LoadModule._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/ads/operation/load/ILoadModule;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00043C81 File Offset: 0x00041E81
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_Handler()
		{
			if (LoadModule.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_ == null)
			{
				LoadModule.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LoadModule.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_));
			}
			return LoadModule.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00043CA8 File Offset: 0x00041EA8
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_(IntPtr jnienv, IntPtr native__this, IntPtr native_webViewBridgeInvoker, IntPtr native_state)
		{
			LoadModule @object = Java.Lang.Object.GetObject<LoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_webViewBridgeInvoker, JniHandleOwnership.DoNotTransfer);
			LoadOperationState object3 = Java.Lang.Object.GetObject<LoadOperationState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00043CD4 File Offset: 0x00041ED4
		[Register("executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/load/LoadOperationState;)V", "GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_Handler")]
		public unsafe virtual void ExecuteAdOperation(IWebViewBridgeInvoker webViewBridgeInvoker, LoadOperationState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewBridgeInvoker == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvoker).Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				LoadModule._members.InstanceMethods.InvokeVirtualVoidMethod("executeAdOperation.(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/load/LoadOperationState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webViewBridgeInvoker);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00043D64 File Offset: 0x00041F64
		private static Delegate GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler()
		{
			if (LoadModule.cb_onUnityAdsAdLoaded_Ljava_lang_String_ == null)
			{
				LoadModule.cb_onUnityAdsAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LoadModule.n_OnUnityAdsAdLoaded_Ljava_lang_String_));
			}
			return LoadModule.cb_onUnityAdsAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00043D88 File Offset: 0x00041F88
		private static void n_OnUnityAdsAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_operationId)
		{
			LoadModule @object = Java.Lang.Object.GetObject<LoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_operationId, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsAdLoaded(@string);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00043DAC File Offset: 0x00041FAC
		[Register("onUnityAdsAdLoaded", "(Ljava/lang/String;)V", "GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsAdLoaded(string operationId)
		{
			IntPtr intPtr = JNIEnv.NewString(operationId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LoadModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsAdLoaded.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00043E08 File Offset: 0x00042008
		private static Delegate GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (LoadModule.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				LoadModule.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(LoadModule.n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return LoadModule.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00043E2C File Offset: 0x0004202C
		private static void n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_operationId, IntPtr native_error, IntPtr native_message)
		{
			LoadModule @object = Java.Lang.Object.GetObject<LoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_operationId, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_error, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(@string, object2, string2);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00043E64 File Offset: 0x00042064
		[Register("onUnityAdsFailedToLoad", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", "GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsFailedToLoad(string operationId, UnityAds.UnityAdsLoadError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(operationId);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				LoadModule._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsFailedToLoad.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x040005B6 RID: 1462
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/LoadModule", typeof(LoadModule));

		// Token: 0x040005B7 RID: 1463
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_;

		// Token: 0x040005B8 RID: 1464
		private static Delegate cb_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x040005B9 RID: 1465
		private static Delegate cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
	}
}
