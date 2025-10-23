using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Com.Unity3d.Services.Core.Webview.Bridge.Invocation;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001FE RID: 510
	[Register("com/unity3d/services/ads/operation/load/LoadOperation", DoNotGenerateAcw = true)]
	public class LoadOperation : AdOperation, ILoadOperation, IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable, IAdOperation, IWebViewSharedObject
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00044948 File Offset: 0x00042B48
		internal new static IntPtr class_ref
		{
			get
			{
				return LoadOperation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0004496C File Offset: 0x00042B6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadOperation._members;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00044974 File Offset: 0x00042B74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadOperation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00044998 File Offset: 0x00042B98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadOperation._members.ManagedPeerType;
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0003FA1B File Offset: 0x0003DC1B
		protected LoadOperation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000449A4 File Offset: 0x00042BA4
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/load/LoadOperationState;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;)V", "")]
		public unsafe LoadOperation(LoadOperationState loadOperationState, IWebViewBridgeInvocation webViewBridgeInvocation) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadOperationState == null) ? IntPtr.Zero : loadOperationState.Handle);
				ptr[1] = new JniArgumentValue((webViewBridgeInvocation == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvocation).Handle);
				base.SetHandle(LoadOperation._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/load/LoadOperationState;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadOperation._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/load/LoadOperationState;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadOperationState);
				GC.KeepAlive(webViewBridgeInvocation);
			}
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00044A80 File Offset: 0x00042C80
		private static Delegate GetGetIdHandler()
		{
			if (LoadOperation.cb_getId == null)
			{
				LoadOperation.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LoadOperation.n_GetId));
			}
			return LoadOperation.cb_getId;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00044AA4 File Offset: 0x00042CA4
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<LoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00044AB8 File Offset: 0x00042CB8
		public override string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(LoadOperation._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00044AEA File Offset: 0x00042CEA
		private static Delegate GetGetLoadOperationStateHandler()
		{
			if (LoadOperation.cb_getLoadOperationState == null)
			{
				LoadOperation.cb_getLoadOperationState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LoadOperation.n_GetLoadOperationState));
			}
			return LoadOperation.cb_getLoadOperationState;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00044B0E File Offset: 0x00042D0E
		private static IntPtr n_GetLoadOperationState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadOperationState);
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00044B24 File Offset: 0x00042D24
		public virtual LoadOperationState LoadOperationState
		{
			[Register("getLoadOperationState", "()Lcom/unity3d/services/ads/operation/load/LoadOperationState;", "GetGetLoadOperationStateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LoadOperationState>(LoadOperation._members.InstanceMethods.InvokeVirtualObjectMethod("getLoadOperationState.()Lcom/unity3d/services/ads/operation/load/LoadOperationState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00044B56 File Offset: 0x00042D56
		private static Delegate GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler()
		{
			if (LoadOperation.cb_onUnityAdsAdLoaded_Ljava_lang_String_ == null)
			{
				LoadOperation.cb_onUnityAdsAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LoadOperation.n_OnUnityAdsAdLoaded_Ljava_lang_String_));
			}
			return LoadOperation.cb_onUnityAdsAdLoaded_Ljava_lang_String_;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00044B7C File Offset: 0x00042D7C
		private static void n_OnUnityAdsAdLoaded_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			LoadOperation @object = Java.Lang.Object.GetObject<LoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsAdLoaded(@string);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00044BA0 File Offset: 0x00042DA0
		[Register("onUnityAdsAdLoaded", "(Ljava/lang/String;)V", "GetOnUnityAdsAdLoaded_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsAdLoaded(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LoadOperation._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsAdLoaded.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00044BFC File Offset: 0x00042DFC
		private static Delegate GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (LoadOperation.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				LoadOperation.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(LoadOperation.n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return LoadOperation.cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00044C20 File Offset: 0x00042E20
		private static void n_OnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_error, IntPtr native_message)
		{
			LoadOperation @object = Java.Lang.Object.GetObject<LoadOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_error, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(@string, object2, string2);
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00044C58 File Offset: 0x00042E58
		[Register("onUnityAdsFailedToLoad", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", "GetOnUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsFailedToLoad(string placementId, UnityAds.UnityAdsLoadError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				LoadOperation._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsFailedToLoad.(Ljava/lang/String;Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x040005C6 RID: 1478
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/LoadOperation", typeof(LoadOperation));

		// Token: 0x040005C7 RID: 1479
		private static Delegate cb_getId;

		// Token: 0x040005C8 RID: 1480
		private static Delegate cb_getLoadOperationState;

		// Token: 0x040005C9 RID: 1481
		private static Delegate cb_onUnityAdsAdLoaded_Ljava_lang_String_;

		// Token: 0x040005CA RID: 1482
		private static Delegate cb_onUnityAdsFailedToLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
	}
}
