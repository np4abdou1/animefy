using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Com.Unity3d.Services.Core.Webview.Bridge.Invocation;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001F4 RID: 500
	[Register("com/unity3d/services/ads/operation/show/ShowOperation", DoNotGenerateAcw = true)]
	public class ShowOperation : AdOperation, IShowOperation, IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable, IAdOperation, IWebViewSharedObject
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x000424F0 File Offset: 0x000406F0
		internal new static IntPtr class_ref
		{
			get
			{
				return ShowOperation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00042514 File Offset: 0x00040714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShowOperation._members;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0004251C File Offset: 0x0004071C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShowOperation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x00042540 File Offset: 0x00040740
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShowOperation._members.ManagedPeerType;
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0003FA1B File Offset: 0x0003DC1B
		protected ShowOperation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0004254C File Offset: 0x0004074C
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/show/ShowOperationState;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;)V", "")]
		public unsafe ShowOperation(ShowOperationState showOperationState, IWebViewBridgeInvocation webViewBridgeInvocation) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((showOperationState == null) ? IntPtr.Zero : showOperationState.Handle);
				ptr[1] = new JniArgumentValue((webViewBridgeInvocation == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvocation).Handle);
				base.SetHandle(ShowOperation._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/show/ShowOperationState;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ShowOperation._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/show/ShowOperationState;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(showOperationState);
				GC.KeepAlive(webViewBridgeInvocation);
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00042628 File Offset: 0x00040828
		private static Delegate GetGetIdHandler()
		{
			if (ShowOperation.cb_getId == null)
			{
				ShowOperation.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShowOperation.n_GetId));
			}
			return ShowOperation.cb_getId;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0004264C File Offset: 0x0004084C
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00042660 File Offset: 0x00040860
		public override string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(ShowOperation._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00042692 File Offset: 0x00040892
		private static Delegate GetGetShowOperationStateHandler()
		{
			if (ShowOperation.cb_getShowOperationState == null)
			{
				ShowOperation.cb_getShowOperationState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShowOperation.n_GetShowOperationState));
			}
			return ShowOperation.cb_getShowOperationState;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000426B6 File Offset: 0x000408B6
		private static IntPtr n_GetShowOperationState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowOperationState);
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x000426CC File Offset: 0x000408CC
		public virtual ShowOperationState ShowOperationState
		{
			[Register("getShowOperationState", "()Lcom/unity3d/services/ads/operation/show/ShowOperationState;", "GetGetShowOperationStateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ShowOperationState>(ShowOperation._members.InstanceMethods.InvokeVirtualObjectMethod("getShowOperationState.()Lcom/unity3d/services/ads/operation/show/ShowOperationState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000426FE File Offset: 0x000408FE
		private static Delegate GetOnUnityAdsShowClick_Ljava_lang_String_Handler()
		{
			if (ShowOperation.cb_onUnityAdsShowClick_Ljava_lang_String_ == null)
			{
				ShowOperation.cb_onUnityAdsShowClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowOperation.n_OnUnityAdsShowClick_Ljava_lang_String_));
			}
			return ShowOperation.cb_onUnityAdsShowClick_Ljava_lang_String_;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00042724 File Offset: 0x00040924
		private static void n_OnUnityAdsShowClick_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			ShowOperation @object = Java.Lang.Object.GetObject<ShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowClick(@string);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00042748 File Offset: 0x00040948
		[Register("onUnityAdsShowClick", "(Ljava/lang/String;)V", "GetOnUnityAdsShowClick_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowClick(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowOperation._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowClick.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000427A4 File Offset: 0x000409A4
		private static Delegate GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (ShowOperation.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				ShowOperation.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShowOperation.n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return ShowOperation.cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x000427C8 File Offset: 0x000409C8
		private static void n_OnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_state)
		{
			ShowOperation @object = Java.Lang.Object.GetObject<ShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(@string, object2);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000427F4 File Offset: 0x000409F4
		[Register("onUnityAdsShowComplete", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", "GetOnUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler")]
		public unsafe virtual void OnUnityAdsShowComplete(string placementId, UnityAds.UnityAdsShowCompletionState state)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ShowOperation._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowComplete.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00042878 File Offset: 0x00040A78
		private static Delegate GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (ShowOperation.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				ShowOperation.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ShowOperation.n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return ShowOperation.cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0004289C File Offset: 0x00040A9C
		private static void n_OnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_error, IntPtr native_message)
		{
			ShowOperation @object = Java.Lang.Object.GetObject<ShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_error, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(@string, object2, string2);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000428D4 File Offset: 0x00040AD4
		[Register("onUnityAdsShowFailure", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", "GetOnUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowFailure(string placementId, UnityAds.UnityAdsShowError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ShowOperation._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowFailure.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0004297C File Offset: 0x00040B7C
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (ShowOperation.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				ShowOperation.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowOperation.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return ShowOperation.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000429A0 File Offset: 0x00040BA0
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			ShowOperation @object = Java.Lang.Object.GetObject<ShowOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000429C4 File Offset: 0x00040BC4
		[Register("onUnityAdsShowStart", "(Ljava/lang/String;)V", "GetOnUnityAdsShowStart_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowStart(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowOperation._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowStart.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400058E RID: 1422
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/ShowOperation", typeof(ShowOperation));

		// Token: 0x0400058F RID: 1423
		private static Delegate cb_getId;

		// Token: 0x04000590 RID: 1424
		private static Delegate cb_getShowOperationState;

		// Token: 0x04000591 RID: 1425
		private static Delegate cb_onUnityAdsShowClick_Ljava_lang_String_;

		// Token: 0x04000592 RID: 1426
		private static Delegate cb_onUnityAdsShowComplete_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000593 RID: 1427
		private static Delegate cb_onUnityAdsShowFailure_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000594 RID: 1428
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;
	}
}
