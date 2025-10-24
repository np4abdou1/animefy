using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Unity3d.Ads;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001F5 RID: 501
	[Register("com/unity3d/services/ads/operation/show/ShowOperationState", DoNotGenerateAcw = true)]
	public class ShowOperationState : OperationState
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00042A3C File Offset: 0x00040C3C
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00042A6C File Offset: 0x00040C6C
		[Register("activity")]
		public Activity Activity
		{
			get
			{
				return Java.Lang.Object.GetObject<Activity>(ShowOperationState._members.InstanceFields.GetObjectValue("activity.Landroid/app/Activity;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ShowOperationState._members.InstanceFields.SetValue("activity.Landroid/app/Activity;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00042AB8 File Offset: 0x00040CB8
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x00042AE8 File Offset: 0x00040CE8
		[Register("listener")]
		public IUnityAdsShowListener Listener
		{
			get
			{
				return Java.Lang.Object.GetObject<IUnityAdsShowListener>(ShowOperationState._members.InstanceFields.GetObjectValue("listener.Lcom/unity3d/ads/IUnityAdsShowListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ShowOperationState._members.InstanceFields.SetValue("listener.Lcom/unity3d/ads/IUnityAdsShowListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00042B34 File Offset: 0x00040D34
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x00042B64 File Offset: 0x00040D64
		[Register("showOptions")]
		public UnityAdsShowOptions ShowOptions
		{
			get
			{
				return Java.Lang.Object.GetObject<UnityAdsShowOptions>(ShowOperationState._members.InstanceFields.GetObjectValue("showOptions.Lcom/unity3d/ads/UnityAdsShowOptions;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ShowOperationState._members.InstanceFields.SetValue("showOptions.Lcom/unity3d/ads/UnityAdsShowOptions;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00042BB0 File Offset: 0x00040DB0
		internal new static IntPtr class_ref
		{
			get
			{
				return ShowOperationState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00042BD4 File Offset: 0x00040DD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShowOperationState._members;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00042BDC File Offset: 0x00040DDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShowOperationState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00042C00 File Offset: 0x00040E00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShowOperationState._members.ManagedPeerType;
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00042C0C File Offset: 0x00040E0C
		protected ShowOperationState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00042C18 File Offset: 0x00040E18
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;Landroid/app/Activity;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe ShowOperationState(string placementId, IUnityAdsShowListener listener, Activity activity, UnityAdsShowOptions showOptions, Configuration configuration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ptr[2] = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[3] = new JniArgumentValue((showOptions == null) ? IntPtr.Zero : showOptions.Handle);
				ptr[4] = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				base.SetHandle(ShowOperationState._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;Landroid/app/Activity;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/services/core/configuration/Configuration;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ShowOperationState._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/ads/IUnityAdsShowListener;Landroid/app/Activity;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
				GC.KeepAlive(activity);
				GC.KeepAlive(showOptions);
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00042D70 File Offset: 0x00040F70
		private static Delegate GetOnUnityAdsShowClickHandler()
		{
			if (ShowOperationState.cb_onUnityAdsShowClick == null)
			{
				ShowOperationState.cb_onUnityAdsShowClick = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ShowOperationState.n_OnUnityAdsShowClick));
			}
			return ShowOperationState.cb_onUnityAdsShowClick;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00042D94 File Offset: 0x00040F94
		private static void n_OnUnityAdsShowClick(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ShowOperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnUnityAdsShowClick();
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00042DA3 File Offset: 0x00040FA3
		[Register("onUnityAdsShowClick", "()V", "GetOnUnityAdsShowClickHandler")]
		public virtual void OnUnityAdsShowClick()
		{
			ShowOperationState._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowClick.()V", this, null);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00042DBC File Offset: 0x00040FBC
		private static Delegate GetOnUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler()
		{
			if (ShowOperationState.cb_onUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ == null)
			{
				ShowOperationState.cb_onUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowOperationState.n_OnUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_));
			}
			return ShowOperationState.cb_onUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00042DE0 File Offset: 0x00040FE0
		private static void n_OnUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			ShowOperationState @object = Java.Lang.Object.GetObject<ShowOperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowCompletionState object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowCompletionState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowComplete(object2);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00042E04 File Offset: 0x00041004
		[Register("onUnityAdsShowComplete", "(Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", "GetOnUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_Handler")]
		public unsafe virtual void OnUnityAdsShowComplete(UnityAds.UnityAdsShowCompletionState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ShowOperationState._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowComplete.(Lcom/unity3d/ads/UnityAds$UnityAdsShowCompletionState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00042E68 File Offset: 0x00041068
		private static Delegate GetOnUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler()
		{
			if (ShowOperationState.cb_onUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ == null)
			{
				ShowOperationState.cb_onUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShowOperationState.n_OnUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_));
			}
			return ShowOperationState.cb_onUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00042E8C File Offset: 0x0004108C
		private static void n_OnUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_error, IntPtr native_message)
		{
			ShowOperationState @object = Java.Lang.Object.GetObject<ShowOperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			UnityAds.UnityAdsShowError object2 = Java.Lang.Object.GetObject<UnityAds.UnityAdsShowError>(native_error, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowFailure(object2, @string);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00042EB8 File Offset: 0x000410B8
		[Register("onUnityAdsShowFailure", "(Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", "GetOnUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowFailure(UnityAds.UnityAdsShowError error, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ShowOperationState._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowFailure.(Lcom/unity3d/ads/UnityAds$UnityAdsShowError;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00042F3C File Offset: 0x0004113C
		private static Delegate GetOnUnityAdsShowStart_Ljava_lang_String_Handler()
		{
			if (ShowOperationState.cb_onUnityAdsShowStart_Ljava_lang_String_ == null)
			{
				ShowOperationState.cb_onUnityAdsShowStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ShowOperationState.n_OnUnityAdsShowStart_Ljava_lang_String_));
			}
			return ShowOperationState.cb_onUnityAdsShowStart_Ljava_lang_String_;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00042F60 File Offset: 0x00041160
		private static void n_OnUnityAdsShowStart_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			ShowOperationState @object = Java.Lang.Object.GetObject<ShowOperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsShowStart(@string);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00042F84 File Offset: 0x00041184
		[Register("onUnityAdsShowStart", "(Ljava/lang/String;)V", "GetOnUnityAdsShowStart_Ljava_lang_String_Handler")]
		public unsafe virtual void OnUnityAdsShowStart(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ShowOperationState._members.InstanceMethods.InvokeVirtualVoidMethod("onUnityAdsShowStart.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000595 RID: 1429
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/ShowOperationState", typeof(ShowOperationState));

		// Token: 0x04000596 RID: 1430
		private static Delegate cb_onUnityAdsShowClick;

		// Token: 0x04000597 RID: 1431
		private static Delegate cb_onUnityAdsShowComplete_Lcom_unity3d_ads_UnityAds_UnityAdsShowCompletionState_;

		// Token: 0x04000598 RID: 1432
		private static Delegate cb_onUnityAdsShowFailure_Lcom_unity3d_ads_UnityAds_UnityAdsShowError_Ljava_lang_String_;

		// Token: 0x04000599 RID: 1433
		private static Delegate cb_onUnityAdsShowStart_Ljava_lang_String_;
	}
}
