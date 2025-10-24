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
	// Token: 0x020001FB RID: 507
	[Register("com/unity3d/services/ads/operation/load/LoadModuleDecorator", DoNotGenerateAcw = true)]
	public class LoadModuleDecorator : Java.Lang.Object, ILoadModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00043F28 File Offset: 0x00042128
		internal static IntPtr class_ref
		{
			get
			{
				return LoadModuleDecorator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x00043F4C File Offset: 0x0004214C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadModuleDecorator._members;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00043F54 File Offset: 0x00042154
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadModuleDecorator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00043F78 File Offset: 0x00042178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadModuleDecorator._members.ManagedPeerType;
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000021E8 File Offset: 0x000003E8
		protected LoadModuleDecorator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00043F84 File Offset: 0x00042184
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/load/ILoadModule;)V", "")]
		public unsafe LoadModuleDecorator(ILoadModule loadModule) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadModule == null) ? IntPtr.Zero : ((Java.Lang.Object)loadModule).Handle);
				base.SetHandle(LoadModuleDecorator._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/load/ILoadModule;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadModuleDecorator._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/load/ILoadModule;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadModule);
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00044038 File Offset: 0x00042238
		private static Delegate GetGetMetricSenderHandler()
		{
			if (LoadModuleDecorator.cb_getMetricSender == null)
			{
				LoadModuleDecorator.cb_getMetricSender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LoadModuleDecorator.n_GetMetricSender));
			}
			return LoadModuleDecorator.cb_getMetricSender;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0004405C File Offset: 0x0004225C
		private static IntPtr n_GetMetricSender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSender);
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x00044070 File Offset: 0x00042270
		public virtual ISDKMetrics MetricSender
		{
			[Register("getMetricSender", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", "GetGetMetricSenderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ISDKMetrics>(LoadModuleDecorator._members.InstanceMethods.InvokeVirtualObjectMethod("getMetricSender.()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000440A2 File Offset: 0x000422A2
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_Handler()
		{
			if (LoadModuleDecorator.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_ == null)
			{
				LoadModuleDecorator.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LoadModuleDecorator.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_));
			}
			return LoadModuleDecorator.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000440C8 File Offset: 0x000422C8
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_(IntPtr jnienv, IntPtr native__this, IntPtr native_webViewBridgeInvoker, IntPtr native_state)
		{
			LoadModuleDecorator @object = Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_webViewBridgeInvoker, JniHandleOwnership.DoNotTransfer);
			LoadOperationState object3 = Java.Lang.Object.GetObject<LoadOperationState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000440F4 File Offset: 0x000422F4
		[Register("executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/load/LoadOperationState;)V", "GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_Handler")]
		public unsafe virtual void ExecuteAdOperation(IWebViewBridgeInvoker webViewBridgeInvoker, LoadOperationState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewBridgeInvoker == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvoker).Handle);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				LoadModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("executeAdOperation.(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/ads/operation/load/LoadOperationState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webViewBridgeInvoker);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00044184 File Offset: 0x00042384
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (LoadModuleDecorator.cb_get_Ljava_lang_String_ == null)
			{
				LoadModuleDecorator.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LoadModuleDecorator.n_Get_Ljava_lang_String_));
			}
			return LoadModuleDecorator.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x000441A8 File Offset: 0x000423A8
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			LoadModuleDecorator @object = Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000441D0 File Offset: 0x000423D0
		[Register("get", "(Ljava/lang/String;)Lcom/unity3d/services/ads/operation/load/ILoadOperation;", "GetGet_Ljava_lang_String_Handler")]
		public unsafe virtual ILoadOperation Get(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			ILoadOperation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ILoadOperation>(LoadModuleDecorator._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/String;)Lcom/unity3d/services/ads/operation/load/ILoadOperation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0004423C File Offset: 0x0004243C
		private static Delegate GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler()
		{
			if (LoadModuleDecorator.cb_onUnityAdsAdLoaded_Ljava_lang_String_ == null)
			{
				LoadModuleDecorator.cb_onUnityAdsAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LoadModuleDecorator.n_OnUnityAdsAdLoaded_Ljava_lang_String_));
			}
			return LoadModuleDecorator.cb_onUnityAdsAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00044260 File Offset: 0x00042460
		private static void n_OnUnityAdsAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_operationId)
		{
			LoadModuleDecorator @object = Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_operationId, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsAdLoaded(@string);
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00044284 File Offset: 0x00042484
		[Register("onUnityAdsAdLoaded", "(Ljava/lang/String;)V", "GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsAdLoaded(string operationId)
		{
			IntPtr intPtr = JNIEnv.NewString(operationId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LoadModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsAdLoaded.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000442E0 File Offset: 0x000424E0
		private static Delegate GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (LoadModuleDecorator.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				LoadModuleDecorator.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(LoadModuleDecorator.n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return LoadModuleDecorator.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00044304 File Offset: 0x00042504
		private static void n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_operationId, IntPtr native_error, IntPtr native_message)
		{
			LoadModuleDecorator @object = Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_operationId, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_error, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(@string, object2, string2);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0004433C File Offset: 0x0004253C
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
				LoadModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsFailedToLoad.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000443E4 File Offset: 0x000425E4
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (LoadModuleDecorator.cb_remove_Ljava_lang_String_ == null)
			{
				LoadModuleDecorator.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LoadModuleDecorator.n_Remove_Ljava_lang_String_));
			}
			return LoadModuleDecorator.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00044408 File Offset: 0x00042608
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			LoadModuleDecorator @object = Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0004442C File Offset: 0x0004262C
		[Register("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public unsafe virtual void Remove(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LoadModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00044488 File Offset: 0x00042688
		private static Delegate GetSet_Lcom_unity3d_services_ads_operation_load_ILoadOperation_Handler()
		{
			if (LoadModuleDecorator.cb_set_Lcom_unity3d_services_ads_operation_load_ILoadOperation_ == null)
			{
				LoadModuleDecorator.cb_set_Lcom_unity3d_services_ads_operation_load_ILoadOperation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LoadModuleDecorator.n_Set_Lcom_unity3d_services_ads_operation_load_ILoadOperation_));
			}
			return LoadModuleDecorator.cb_set_Lcom_unity3d_services_ads_operation_load_ILoadOperation_;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000444AC File Offset: 0x000426AC
		private static void n_Set_Lcom_unity3d_services_ads_operation_load_ILoadOperation_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedObject)
		{
			LoadModuleDecorator @object = Java.Lang.Object.GetObject<LoadModuleDecorator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILoadOperation object2 = Java.Lang.Object.GetObject<ILoadOperation>(native_sharedObject, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000444D0 File Offset: 0x000426D0
		[Register("set", "(Lcom/unity3d/services/ads/operation/load/ILoadOperation;)V", "GetSet_Lcom_unity3d_services_ads_operation_load_ILoadOperation_Handler")]
		public unsafe virtual void Set(ILoadOperation sharedObject)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sharedObject == null) ? IntPtr.Zero : ((Java.Lang.Object)sharedObject).Handle);
				LoadModuleDecorator._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Lcom/unity3d/services/ads/operation/load/ILoadOperation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sharedObject);
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00002226 File Offset: 0x00000426
		public void ExecuteAdOperation(IWebViewBridgeInvoker p0, Java.Lang.Object p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00002226 File Offset: 0x00000426
		Java.Lang.Object IWebViewBridgeSharedObjectStore.Get(string p0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00002226 File Offset: 0x00000426
		public void Set(Java.Lang.Object p0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x040005BA RID: 1466
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/LoadModuleDecorator", typeof(LoadModuleDecorator));

		// Token: 0x040005BB RID: 1467
		private static Delegate cb_getMetricSender;

		// Token: 0x040005BC RID: 1468
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Lcom_unity3d_services_ads_operation_load_LoadOperationState_;

		// Token: 0x040005BD RID: 1469
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x040005BE RID: 1470
		private static Delegate cb_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x040005BF RID: 1471
		private static Delegate cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;

		// Token: 0x040005C0 RID: 1472
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x040005C1 RID: 1473
		private static Delegate cb_set_Lcom_unity3d_services_ads_operation_load_ILoadOperation_;
	}
}
