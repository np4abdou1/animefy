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
	// Token: 0x020001EE RID: 494
	[Register("com/unity3d/services/ads/operation/show/IShowModule", DoNotGenerateAcw = true)]
	internal class IShowModuleInvoker : Java.Lang.Object, IShowModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0004058C File Offset: 0x0003E78C
		private static IntPtr java_class_ref
		{
			get
			{
				return IShowModuleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000405B0 File Offset: 0x0003E7B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IShowModuleInvoker._members;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x000405B7 File Offset: 0x0003E7B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000405BF File Offset: 0x0003E7BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IShowModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000405CB File Offset: 0x0003E7CB
		public static IShowModule GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IShowModule>(handle, transfer);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x000405D4 File Offset: 0x0003E7D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IShowModuleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.operation.show.IShowModule'.");
			}
			return handle;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000405FF File Offset: 0x0003E7FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00040630 File Offset: 0x0003E830
		public IShowModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IShowModuleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00040668 File Offset: 0x0003E868
		private static Delegate GetOnUnityAdsShowClick_Ljava_lang_String_Handler()
		{
			if (IShowModuleInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_ == null)
			{
				IShowModuleInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowModuleInvoker.n_OnUnityAdsShowClick_Ljava_lang_String_));
			}
			return IShowModuleInvoker.cb_onUnityAdsShowClick_Ljava_lang_String_;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0004068C File Offset: 0x0003E88C
		private static void n_OnUnityAdsShowClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IShowModule @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowClick(@string);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000406B0 File Offset: 0x0003E8B0
		public unsafe void OnUnityAdsShowClick(string p0)
		{
			if (this.id_onUnityAdsShowClick_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowClick_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowClick", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowClick_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00040721 File Offset: 0x0003E921
		private static Delegate GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (IShowModuleInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				IShowModuleInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IShowModuleInvoker.n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return IShowModuleInvoker.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00040748 File Offset: 0x0003E948
		private static void n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IShowModule @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(@string, object2);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00040774 File Offset: 0x0003E974
		public unsafe void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1)
		{
			if (this.id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00040807 File Offset: 0x0003EA07
		private static Delegate GetOnUnityAdsShowConsent_Ljava_lang_String_Handler()
		{
			if (IShowModuleInvoker.cb_onUnityAdsShowConsent_Ljava_lang_String_ == null)
			{
				IShowModuleInvoker.cb_onUnityAdsShowConsent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowModuleInvoker.n_OnUnityAdsShowConsent_Ljava_lang_String_));
			}
			return IShowModuleInvoker.cb_onUnityAdsShowConsent_Ljava_lang_String_;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0004082C File Offset: 0x0003EA2C
		private static void n_OnUnityAdsShowConsent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IShowModule @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowConsent(@string);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00040850 File Offset: 0x0003EA50
		public unsafe void OnUnityAdsShowConsent(string p0)
		{
			if (this.id_onUnityAdsShowConsent_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowConsent_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowConsent", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowConsent_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000408C1 File Offset: 0x0003EAC1
		private static Delegate GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (IShowModuleInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				IShowModuleInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IShowModuleInvoker.n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return IShowModuleInvoker.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000408E8 File Offset: 0x0003EAE8
		private static void n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IShowModule @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(@string, object2, string2);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00040920 File Offset: 0x0003EB20
		public unsafe void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2)
		{
			if (this.id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowFailure", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000409D6 File Offset: 0x0003EBD6
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (IShowModuleInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				IShowModuleInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowModuleInvoker.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return IShowModuleInvoker.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000409FC File Offset: 0x0003EBFC
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IShowModule @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00040A20 File Offset: 0x0003EC20
		public unsafe void OnUnityAdsShowStart(string p0)
		{
			if (this.id_onUnityAdsShowStart_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsShowStart_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsShowStart", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsShowStart_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00040A91 File Offset: 0x0003EC91
		private static Delegate GetGetMetricSenderHandler()
		{
			if (IShowModuleInvoker.cb_getMetricSender == null)
			{
				IShowModuleInvoker.cb_getMetricSender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IShowModuleInvoker.n_GetMetricSender));
			}
			return IShowModuleInvoker.cb_getMetricSender;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00040AB5 File Offset: 0x0003ECB5
		private static IntPtr n_GetMetricSender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSender);
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00040ACC File Offset: 0x0003ECCC
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

		// Token: 0x06001695 RID: 5781 RVA: 0x00040B1D File Offset: 0x0003ED1D
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_Handler()
		{
			if (IShowModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ == null)
			{
				IShowModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IShowModuleInvoker.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_));
			}
			return IShowModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00040B44 File Offset: 0x0003ED44
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAdModule @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00040B70 File Offset: 0x0003ED70
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

		// Token: 0x06001698 RID: 5784 RVA: 0x00040C08 File Offset: 0x0003EE08
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (IShowModuleInvoker.cb_get_Ljava_lang_String_ == null)
			{
				IShowModuleInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IShowModuleInvoker.n_Get_Ljava_lang_String_));
			}
			return IShowModuleInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00040C2C File Offset: 0x0003EE2C
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00040C54 File Offset: 0x0003EE54
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

		// Token: 0x0600169B RID: 5787 RVA: 0x00040CCB File Offset: 0x0003EECB
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (IShowModuleInvoker.cb_remove_Ljava_lang_String_ == null)
			{
				IShowModuleInvoker.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowModuleInvoker.n_Remove_Ljava_lang_String_));
			}
			return IShowModuleInvoker.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00040CF0 File Offset: 0x0003EEF0
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00040D14 File Offset: 0x0003EF14
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

		// Token: 0x0600169E RID: 5790 RVA: 0x00040D85 File Offset: 0x0003EF85
		private static Delegate GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler()
		{
			if (IShowModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == null)
			{
				IShowModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShowModuleInvoker.n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_));
			}
			return IShowModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00040DAC File Offset: 0x0003EFAC
		private static void n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IShowModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00040DD0 File Offset: 0x0003EFD0
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

		// Token: 0x04000555 RID: 1365
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/IShowModule", typeof(IShowModuleInvoker));

		// Token: 0x04000556 RID: 1366
		private IntPtr class_ref;

		// Token: 0x04000557 RID: 1367
		private static Delegate cb_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000558 RID: 1368
		private IntPtr id_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000559 RID: 1369
		private static Delegate cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x0400055A RID: 1370
		private IntPtr id_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x0400055B RID: 1371
		private static Delegate cb_onUnityAdsShowConsent_Ljava_lang_String_;

		// Token: 0x0400055C RID: 1372
		private IntPtr id_onUnityAdsShowConsent_Ljava_lang_String_;

		// Token: 0x0400055D RID: 1373
		private static Delegate cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x0400055E RID: 1374
		private IntPtr id_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x0400055F RID: 1375
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;

		// Token: 0x04000560 RID: 1376
		private IntPtr id_onUnityAdsShowStart_Ljava_lang_String_;

		// Token: 0x04000561 RID: 1377
		private static Delegate cb_getMetricSender;

		// Token: 0x04000562 RID: 1378
		private IntPtr id_getMetricSender;

		// Token: 0x04000563 RID: 1379
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;

		// Token: 0x04000564 RID: 1380
		private IntPtr id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;

		// Token: 0x04000565 RID: 1381
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x04000566 RID: 1382
		private IntPtr id_get_Ljava_lang_String_;

		// Token: 0x04000567 RID: 1383
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x04000568 RID: 1384
		private IntPtr id_remove_Ljava_lang_String_;

		// Token: 0x04000569 RID: 1385
		private static Delegate cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;

		// Token: 0x0400056A RID: 1386
		private IntPtr id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
	}
}
