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
	// Token: 0x020001F7 RID: 503
	[Register("com/unity3d/services/ads/operation/load/ILoadModule", DoNotGenerateAcw = true)]
	internal class ILoadModuleInvoker : Java.Lang.Object, ILoadModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00042FFC File Offset: 0x000411FC
		private static IntPtr java_class_ref
		{
			get
			{
				return ILoadModuleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00043020 File Offset: 0x00041220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILoadModuleInvoker._members;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00043027 File Offset: 0x00041227
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0004302F File Offset: 0x0004122F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILoadModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0004303B File Offset: 0x0004123B
		public static ILoadModule GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILoadModule>(handle, transfer);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00043044 File Offset: 0x00041244
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILoadModuleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.operation.load.ILoadModule'.");
			}
			return handle;
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0004306F File Offset: 0x0004126F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000430A0 File Offset: 0x000412A0
		public ILoadModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILoadModuleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000430D8 File Offset: 0x000412D8
		private static Delegate GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler()
		{
			if (ILoadModuleInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_ == null)
			{
				ILoadModuleInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILoadModuleInvoker.n_OnUnityAdsAdLoaded_Ljava_lang_String_));
			}
			return ILoadModuleInvoker.cb_onUnityAdsAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000430FC File Offset: 0x000412FC
		private static void n_OnUnityAdsAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILoadModule @object = Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsAdLoaded(@string);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00043120 File Offset: 0x00041320
		public unsafe void OnUnityAdsAdLoaded(string p0)
		{
			if (this.id_onUnityAdsAdLoaded_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsAdLoaded_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsAdLoaded", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsAdLoaded_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00043191 File Offset: 0x00041391
		private static Delegate GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (ILoadModuleInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				ILoadModuleInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ILoadModuleInvoker.n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return ILoadModuleInvoker.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000431B8 File Offset: 0x000413B8
		private static void n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ILoadModule @object = Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(@string, object2, string2);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000431F0 File Offset: 0x000413F0
		public unsafe void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2)
		{
			if (this.id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsFailedToLoad", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000432A6 File Offset: 0x000414A6
		private static Delegate GetGetMetricSenderHandler()
		{
			if (ILoadModuleInvoker.cb_getMetricSender == null)
			{
				ILoadModuleInvoker.cb_getMetricSender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILoadModuleInvoker.n_GetMetricSender));
			}
			return ILoadModuleInvoker.cb_getMetricSender;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x000432CA File Offset: 0x000414CA
		private static IntPtr n_GetMetricSender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSender);
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000432E0 File Offset: 0x000414E0
		public ISDKMetrics MetricSender
		{
			get
			{
				if (this.id_getMetricSender == IntPtr.Zero)
				{
					this.id_getMetricSender = JNIEnv.GetMethodID(this.class_ref, "getMetricSender", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;");
				}
				return Java.Lang.Object.GetObject<ISDKMetrics>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMetricSender), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00043331 File Offset: 0x00041531
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_Handler()
		{
			if (ILoadModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ == null)
			{
				ILoadModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ILoadModuleInvoker.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_));
			}
			return ILoadModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00043358 File Offset: 0x00041558
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAdModule @object = Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00043384 File Offset: 0x00041584
		public unsafe void ExecuteAdOperation(IWebViewBridgeInvoker p0, Java.Lang.Object p1)
		{
			if (this.id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0004341C File Offset: 0x0004161C
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (ILoadModuleInvoker.cb_get_Ljava_lang_String_ == null)
			{
				ILoadModuleInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ILoadModuleInvoker.n_Get_Ljava_lang_String_));
			}
			return ILoadModuleInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00043440 File Offset: 0x00041640
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00043468 File Offset: 0x00041668
		public unsafe Java.Lang.Object Get(string p0)
		{
			if (this.id_get_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000434DF File Offset: 0x000416DF
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (ILoadModuleInvoker.cb_remove_Ljava_lang_String_ == null)
			{
				ILoadModuleInvoker.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILoadModuleInvoker.n_Remove_Ljava_lang_String_));
			}
			return ILoadModuleInvoker.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00043504 File Offset: 0x00041704
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00043528 File Offset: 0x00041728
		public unsafe void Remove(string p0)
		{
			if (this.id_remove_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_remove_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00043599 File Offset: 0x00041799
		private static Delegate GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler()
		{
			if (ILoadModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == null)
			{
				ILoadModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILoadModuleInvoker.n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_));
			}
			return ILoadModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000435C0 File Offset: 0x000417C0
		private static void n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<ILoadModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000435E4 File Offset: 0x000417E4
		public unsafe void Set(Java.Lang.Object p0)
		{
			if (this.id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == IntPtr.Zero)
			{
				this.id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400059A RID: 1434
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/ILoadModule", typeof(ILoadModuleInvoker));

		// Token: 0x0400059B RID: 1435
		private IntPtr class_ref;

		// Token: 0x0400059C RID: 1436
		private static Delegate cb_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x0400059D RID: 1437
		private IntPtr id_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x0400059E RID: 1438
		private static Delegate cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;

		// Token: 0x0400059F RID: 1439
		private IntPtr id_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;

		// Token: 0x040005A0 RID: 1440
		private static Delegate cb_getMetricSender;

		// Token: 0x040005A1 RID: 1441
		private IntPtr id_getMetricSender;

		// Token: 0x040005A2 RID: 1442
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;

		// Token: 0x040005A3 RID: 1443
		private IntPtr id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;

		// Token: 0x040005A4 RID: 1444
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x040005A5 RID: 1445
		private IntPtr id_get_Ljava_lang_String_;

		// Token: 0x040005A6 RID: 1446
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x040005A7 RID: 1447
		private IntPtr id_remove_Ljava_lang_String_;

		// Token: 0x040005A8 RID: 1448
		private static Delegate cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;

		// Token: 0x040005A9 RID: 1449
		private IntPtr id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
	}
}
