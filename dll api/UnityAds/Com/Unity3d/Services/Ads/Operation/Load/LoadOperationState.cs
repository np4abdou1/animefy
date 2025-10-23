using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001FF RID: 511
	[Register("com/unity3d/services/ads/operation/load/LoadOperationState", DoNotGenerateAcw = true)]
	public class LoadOperationState : OperationState
	{
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00044D1C File Offset: 0x00042F1C
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x00044D4C File Offset: 0x00042F4C
		[Register("listener")]
		public IUnityAdsLoadListener Listener
		{
			get
			{
				return Java.Lang.Object.GetObject<IUnityAdsLoadListener>(LoadOperationState._members.InstanceFields.GetObjectValue("listener.Lcom/unity3d/ads/IUnityAdsLoadListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					LoadOperationState._members.InstanceFields.SetValue("listener.Lcom/unity3d/ads/IUnityAdsLoadListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00044D98 File Offset: 0x00042F98
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00044DC8 File Offset: 0x00042FC8
		[Register("loadOptions")]
		public UnityAdsLoadOptions LoadOptions
		{
			get
			{
				return Java.Lang.Object.GetObject<UnityAdsLoadOptions>(LoadOperationState._members.InstanceFields.GetObjectValue("loadOptions.Lcom/unity3d/ads/UnityAdsLoadOptions;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					LoadOperationState._members.InstanceFields.SetValue("loadOptions.Lcom/unity3d/ads/UnityAdsLoadOptions;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00044E14 File Offset: 0x00043014
		internal new static IntPtr class_ref
		{
			get
			{
				return LoadOperationState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00044E38 File Offset: 0x00043038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadOperationState._members;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00044E40 File Offset: 0x00043040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadOperationState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00044E64 File Offset: 0x00043064
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadOperationState._members.ManagedPeerType;
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00042C0C File Offset: 0x00040E0C
		protected LoadOperationState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00044E70 File Offset: 0x00043070
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsLoadListener;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe LoadOperationState(string placementId, IUnityAdsLoadListener listener, UnityAdsLoadOptions loadOptions, Configuration configuration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ptr[2] = new JniArgumentValue((loadOptions == null) ? IntPtr.Zero : loadOptions.Handle);
				ptr[3] = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				base.SetHandle(LoadOperationState._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsLoadListener;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/services/core/configuration/Configuration;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadOperationState._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsLoadListener;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
				GC.KeepAlive(loadOptions);
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00044F9C File Offset: 0x0004319C
		private static Delegate GetOnUnityAdsAdLoadedHandler()
		{
			if (LoadOperationState.cb_onUnityAdsAdLoaded == null)
			{
				LoadOperationState.cb_onUnityAdsAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LoadOperationState.n_OnUnityAdsAdLoaded));
			}
			return LoadOperationState.cb_onUnityAdsAdLoaded;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00044FC0 File Offset: 0x000431C0
		private static void n_OnUnityAdsAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LoadOperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnUnityAdsAdLoaded();
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00044FCF File Offset: 0x000431CF
		[Register("onUnityAdsAdLoaded", "()V", "GetOnUnityAdsAdLoadedHandler")]
		public virtual void OnUnityAdsAdLoaded()
		{
			LoadOperationState._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsAdLoaded.()V", this, null);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00044FE8 File Offset: 0x000431E8
		private static Delegate GetOnUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler()
		{
			if (LoadOperationState.cb_onUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ == null)
			{
				LoadOperationState.cb_onUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LoadOperationState.n_OnUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_));
			}
			return LoadOperationState.cb_onUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0004500C File Offset: 0x0004320C
		private static void n_OnUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_error, IntPtr native_message)
		{
			LoadOperationState @object = Java.Lang.Object.GetObject<LoadOperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsLoadError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsLoadError>(native_error, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsFailedToLoad(object2, @string);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00045038 File Offset: 0x00043238
		[Register("onUnityAdsFailedToLoad", "(Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", "GetOnUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsFailedToLoad(UnityAds.UnityAdsLoadError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				LoadOperationState._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsFailedToLoad.(Lcom/unity3d/ads/UnityAds$UnityAdsLoadError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x040005CB RID: 1483
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/LoadOperationState", typeof(LoadOperationState));

		// Token: 0x040005CC RID: 1484
		private static Delegate cb_onUnityAdsAdLoaded;

		// Token: 0x040005CD RID: 1485
		private static Delegate cb_onUnityAdsFailedToLoad_Lcom_unity3d_ads_UnityAds_UnityAdsLoadError_Ljava_lang_String_;
	}
}
