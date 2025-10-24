using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Gms.Ads.AdManager;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000029 RID: 41
	[Register("com/google/android/gms/ads/rewarded/RewardedAd", DoNotGenerateAcw = true)]
	public abstract class RewardedAd : Java.Lang.Object
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000059F8 File Offset: 0x00003BF8
		internal static IntPtr class_ref
		{
			get
			{
				return RewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00005A1C File Offset: 0x00003C1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RewardedAd._members;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005A24 File Offset: 0x00003C24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00005A48 File Offset: 0x00003C48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RewardedAd._members.ManagedPeerType;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000020AC File Offset: 0x000002AC
		protected RewardedAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005A54 File Offset: 0x00003C54
		[Register(".ctor", "()V", "")]
		public RewardedAd() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(RewardedAd._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			RewardedAd._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005AC2 File Offset: 0x00003CC2
		private static Delegate GetGetAdMetadataHandler()
		{
			if (RewardedAd.cb_getAdMetadata == null)
			{
				RewardedAd.cb_getAdMetadata = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetAdMetadata));
			}
			return RewardedAd.cb_getAdMetadata;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005AE6 File Offset: 0x00003CE6
		private static IntPtr n_GetAdMetadata(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdMetadata);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000195 RID: 405
		public abstract Bundle AdMetadata { [Register("getAdMetadata", "()Landroid/os/Bundle;", "GetGetAdMetadataHandler")] get; }

		// Token: 0x06000196 RID: 406 RVA: 0x00005AFA File Offset: 0x00003CFA
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (RewardedAd.cb_getAdUnitId == null)
			{
				RewardedAd.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetAdUnitId));
			}
			return RewardedAd.cb_getAdUnitId;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005B1E File Offset: 0x00003D1E
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000198 RID: 408
		public abstract string AdUnitId { [Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")] get; }

		// Token: 0x06000199 RID: 409 RVA: 0x00005B32 File Offset: 0x00003D32
		private static Delegate GetGetFullScreenContentCallbackHandler()
		{
			if (RewardedAd.cb_getFullScreenContentCallback == null)
			{
				RewardedAd.cb_getFullScreenContentCallback = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetFullScreenContentCallback));
			}
			return RewardedAd.cb_getFullScreenContentCallback;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00005B56 File Offset: 0x00003D56
		private static IntPtr n_GetFullScreenContentCallback(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FullScreenContentCallback);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005B6A File Offset: 0x00003D6A
		private static Delegate GetSetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_Handler()
		{
			if (RewardedAd.cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_ == null)
			{
				RewardedAd.cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RewardedAd.n_SetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_));
			}
			return RewardedAd.cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00005B90 File Offset: 0x00003D90
		private static void n_SetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RewardedAd @object = Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FullScreenContentCallback object2 = Java.Lang.Object.GetObject<FullScreenContentCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.FullScreenContentCallback = object2;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600019D RID: 413
		// (set) Token: 0x0600019E RID: 414
		public abstract FullScreenContentCallback FullScreenContentCallback { [Register("getFullScreenContentCallback", "()Lcom/google/android/gms/ads/FullScreenContentCallback;", "GetGetFullScreenContentCallbackHandler")] get; [Register("setFullScreenContentCallback", "(Lcom/google/android/gms/ads/FullScreenContentCallback;)V", "GetSetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_Handler")] set; }

		// Token: 0x0600019F RID: 415 RVA: 0x00005BB3 File Offset: 0x00003DB3
		private static Delegate GetGetOnAdMetadataChangedListenerHandler()
		{
			if (RewardedAd.cb_getOnAdMetadataChangedListener == null)
			{
				RewardedAd.cb_getOnAdMetadataChangedListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetOnAdMetadataChangedListener));
			}
			return RewardedAd.cb_getOnAdMetadataChangedListener;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005BD7 File Offset: 0x00003DD7
		private static IntPtr n_GetOnAdMetadataChangedListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdMetadataChangedListener);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00005BEB File Offset: 0x00003DEB
		private static Delegate GetSetOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_Handler()
		{
			if (RewardedAd.cb_setOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_ == null)
			{
				RewardedAd.cb_setOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RewardedAd.n_SetOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_));
			}
			return RewardedAd.cb_setOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005C10 File Offset: 0x00003E10
		private static void n_SetOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RewardedAd @object = Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnAdMetadataChangedListener object2 = Java.Lang.Object.GetObject<IOnAdMetadataChangedListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdMetadataChangedListener = object2;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001A3 RID: 419
		// (set) Token: 0x060001A4 RID: 420
		public abstract IOnAdMetadataChangedListener OnAdMetadataChangedListener { [Register("getOnAdMetadataChangedListener", "()Lcom/google/android/gms/ads/rewarded/OnAdMetadataChangedListener;", "GetGetOnAdMetadataChangedListenerHandler")] get; [Register("setOnAdMetadataChangedListener", "(Lcom/google/android/gms/ads/rewarded/OnAdMetadataChangedListener;)V", "GetSetOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_Handler")] set; }

		// Token: 0x060001A5 RID: 421 RVA: 0x00005C33 File Offset: 0x00003E33
		private static Delegate GetGetOnPaidEventListenerHandler()
		{
			if (RewardedAd.cb_getOnPaidEventListener == null)
			{
				RewardedAd.cb_getOnPaidEventListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetOnPaidEventListener));
			}
			return RewardedAd.cb_getOnPaidEventListener;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00005C57 File Offset: 0x00003E57
		private static IntPtr n_GetOnPaidEventListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPaidEventListener);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00005C6B File Offset: 0x00003E6B
		private static Delegate GetSetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_Handler()
		{
			if (RewardedAd.cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_ == null)
			{
				RewardedAd.cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RewardedAd.n_SetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_));
			}
			return RewardedAd.cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00005C90 File Offset: 0x00003E90
		private static void n_SetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RewardedAd @object = Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnPaidEventListener object2 = Java.Lang.Object.GetObject<IOnPaidEventListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnPaidEventListener = object2;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001A9 RID: 425
		// (set) Token: 0x060001AA RID: 426
		public abstract IOnPaidEventListener OnPaidEventListener { [Register("getOnPaidEventListener", "()Lcom/google/android/gms/ads/OnPaidEventListener;", "GetGetOnPaidEventListenerHandler")] get; [Register("setOnPaidEventListener", "(Lcom/google/android/gms/ads/OnPaidEventListener;)V", "GetSetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_Handler")] set; }

		// Token: 0x060001AB RID: 427 RVA: 0x00005CB3 File Offset: 0x00003EB3
		private static Delegate GetGetResponseInfoHandler()
		{
			if (RewardedAd.cb_getResponseInfo == null)
			{
				RewardedAd.cb_getResponseInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetResponseInfo));
			}
			return RewardedAd.cb_getResponseInfo;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005CD7 File Offset: 0x00003ED7
		private static IntPtr n_GetResponseInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResponseInfo);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001AD RID: 429
		public abstract ResponseInfo ResponseInfo { [Register("getResponseInfo", "()Lcom/google/android/gms/ads/ResponseInfo;", "GetGetResponseInfoHandler")] get; }

		// Token: 0x060001AE RID: 430 RVA: 0x00005CEB File Offset: 0x00003EEB
		private static Delegate GetGetRewardItemHandler()
		{
			if (RewardedAd.cb_getRewardItem == null)
			{
				RewardedAd.cb_getRewardItem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RewardedAd.n_GetRewardItem));
			}
			return RewardedAd.cb_getRewardItem;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005D0F File Offset: 0x00003F0F
		private static IntPtr n_GetRewardItem(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewardItem);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B0 RID: 432
		public abstract IRewardItem RewardItem { [Register("getRewardItem", "()Lcom/google/android/gms/ads/rewarded/RewardItem;", "GetGetRewardItemHandler")] get; }

		// Token: 0x060001B1 RID: 433 RVA: 0x00005D24 File Offset: 0x00003F24
		[Register("load", "(Landroid/content/Context;Ljava/lang/String;Lcom/google/android/gms/ads/admanager/AdManagerAdRequest;Lcom/google/android/gms/ads/rewarded/RewardedAdLoadCallback;)V", "")]
		public unsafe static void Load(Context context, string adUnitId, AdManagerAdRequest adManagerAdRequest, RewardedAdLoadCallback loadCallback)
		{
			IntPtr intPtr = JNIEnv.NewString(adUnitId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((adManagerAdRequest == null) ? IntPtr.Zero : adManagerAdRequest.Handle);
				ptr[3] = new JniArgumentValue((loadCallback == null) ? IntPtr.Zero : loadCallback.Handle);
				RewardedAd._members.StaticMethods.InvokeVoidMethod("load.(Landroid/content/Context;Ljava/lang/String;Lcom/google/android/gms/ads/admanager/AdManagerAdRequest;Lcom/google/android/gms/ads/rewarded/RewardedAdLoadCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(adManagerAdRequest);
				GC.KeepAlive(loadCallback);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00005DFC File Offset: 0x00003FFC
		[Register("load", "(Landroid/content/Context;Ljava/lang/String;Lcom/google/android/gms/ads/AdRequest;Lcom/google/android/gms/ads/rewarded/RewardedAdLoadCallback;)V", "")]
		public unsafe static void Load(Context context, string adUnitId, AdRequest adRequest, RewardedAdLoadCallback loadCallback)
		{
			IntPtr intPtr = JNIEnv.NewString(adUnitId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((adRequest == null) ? IntPtr.Zero : adRequest.Handle);
				ptr[3] = new JniArgumentValue((loadCallback == null) ? IntPtr.Zero : loadCallback.Handle);
				RewardedAd._members.StaticMethods.InvokeVoidMethod("load.(Landroid/content/Context;Ljava/lang/String;Lcom/google/android/gms/ads/AdRequest;Lcom/google/android/gms/ads/rewarded/RewardedAdLoadCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(adRequest);
				GC.KeepAlive(loadCallback);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00005ED4 File Offset: 0x000040D4
		private static Delegate GetSetImmersiveMode_ZHandler()
		{
			if (RewardedAd.cb_setImmersiveMode_Z == null)
			{
				RewardedAd.cb_setImmersiveMode_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RewardedAd.n_SetImmersiveMode_Z));
			}
			return RewardedAd.cb_setImmersiveMode_Z;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00005EF8 File Offset: 0x000040F8
		private static void n_SetImmersiveMode_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetImmersiveMode(p0);
		}

		// Token: 0x060001B5 RID: 437
		[Register("setImmersiveMode", "(Z)V", "GetSetImmersiveMode_ZHandler")]
		public abstract void SetImmersiveMode(bool p0);

		// Token: 0x060001B6 RID: 438 RVA: 0x00005F08 File Offset: 0x00004108
		private static Delegate GetSetServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_Handler()
		{
			if (RewardedAd.cb_setServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_ == null)
			{
				RewardedAd.cb_setServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RewardedAd.n_SetServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_));
			}
			return RewardedAd.cb_setServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00005F2C File Offset: 0x0000412C
		private static void n_SetServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			RewardedAd @object = Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ServerSideVerificationOptions object2 = Java.Lang.Object.GetObject<ServerSideVerificationOptions>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetServerSideVerificationOptions(object2);
		}

		// Token: 0x060001B8 RID: 440
		[Register("setServerSideVerificationOptions", "(Lcom/google/android/gms/ads/rewarded/ServerSideVerificationOptions;)V", "GetSetServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_Handler")]
		public abstract void SetServerSideVerificationOptions(ServerSideVerificationOptions p0);

		// Token: 0x060001B9 RID: 441 RVA: 0x00005F4F File Offset: 0x0000414F
		private static Delegate GetShow_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_Handler()
		{
			if (RewardedAd.cb_show_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_ == null)
			{
				RewardedAd.cb_show_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RewardedAd.n_Show_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_));
			}
			return RewardedAd.cb_show_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005F74 File Offset: 0x00004174
		private static void n_Show_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			RewardedAd @object = Java.Lang.Object.GetObject<RewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			IOnUserEarnedRewardListener object3 = Java.Lang.Object.GetObject<IOnUserEarnedRewardListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3);
		}

		// Token: 0x060001BB RID: 443
		[Register("show", "(Landroid/app/Activity;Lcom/google/android/gms/ads/OnUserEarnedRewardListener;)V", "GetShow_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_Handler")]
		public abstract void Show(Activity p0, IOnUserEarnedRewardListener p1);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001BC RID: 444 RVA: 0x00005FA0 File Offset: 0x000041A0
		// (remove) Token: 0x060001BD RID: 445 RVA: 0x00005FF0 File Offset: 0x000041F0
		public event EventHandler AdMetadataChanged
		{
			add
			{
				EventHelper.AddEventHandler<IOnAdMetadataChangedListener, IOnAdMetadataChangedListenerImplementor>(ref this.weak_implementor___SetOnAdMetadataChangedListener, new Func<IOnAdMetadataChangedListenerImplementor>(this.__CreateIOnAdMetadataChangedListenerImplementor), delegate(IOnAdMetadataChangedListener __v)
				{
					this.OnAdMetadataChangedListener = __v;
				}, delegate(IOnAdMetadataChangedListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IOnAdMetadataChangedListener, IOnAdMetadataChangedListenerImplementor>(ref this.weak_implementor___SetOnAdMetadataChangedListener, new Func<IOnAdMetadataChangedListenerImplementor, bool>(IOnAdMetadataChangedListenerImplementor.__IsEmpty), delegate(IOnAdMetadataChangedListener __v)
				{
					this.OnAdMetadataChangedListener = null;
				}, delegate(IOnAdMetadataChangedListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00006040 File Offset: 0x00004240
		private IOnAdMetadataChangedListenerImplementor __CreateIOnAdMetadataChangedListenerImplementor()
		{
			return new IOnAdMetadataChangedListenerImplementor(this);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001BF RID: 447 RVA: 0x00006048 File Offset: 0x00004248
		// (remove) Token: 0x060001C0 RID: 448 RVA: 0x00006098 File Offset: 0x00004298
		public event EventHandler<PaidEventEventArgs> PaidEvent
		{
			add
			{
				EventHelper.AddEventHandler<IOnPaidEventListener, IOnPaidEventListenerImplementor>(ref this.weak_implementor___SetOnPaidEventListener, new Func<IOnPaidEventListenerImplementor>(this.__CreateIOnPaidEventListenerImplementor), delegate(IOnPaidEventListener __v)
				{
					this.OnPaidEventListener = __v;
				}, delegate(IOnPaidEventListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PaidEventEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IOnPaidEventListener, IOnPaidEventListenerImplementor>(ref this.weak_implementor___SetOnPaidEventListener, new Func<IOnPaidEventListenerImplementor, bool>(IOnPaidEventListenerImplementor.__IsEmpty), delegate(IOnPaidEventListener __v)
				{
					this.OnPaidEventListener = null;
				}, delegate(IOnPaidEventListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PaidEventEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000060E8 File Offset: 0x000042E8
		private IOnPaidEventListenerImplementor __CreateIOnPaidEventListenerImplementor()
		{
			return new IOnPaidEventListenerImplementor(this);
		}

		// Token: 0x04000058 RID: 88
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/RewardedAd", typeof(RewardedAd));

		// Token: 0x04000059 RID: 89
		private static Delegate cb_getAdMetadata;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_getAdUnitId;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_getFullScreenContentCallback;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_getOnAdMetadataChangedListener;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_setOnAdMetadataChangedListener_Lcom_google_android_gms_ads_rewarded_OnAdMetadataChangedListener_;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_getOnPaidEventListener;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_getResponseInfo;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_getRewardItem;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_setImmersiveMode_Z;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_setServerSideVerificationOptions_Lcom_google_android_gms_ads_rewarded_ServerSideVerificationOptions_;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_show_Landroid_app_Activity_Lcom_google_android_gms_ads_OnUserEarnedRewardListener_;

		// Token: 0x04000066 RID: 102
		private WeakReference weak_implementor___SetOnAdMetadataChangedListener;

		// Token: 0x04000067 RID: 103
		private WeakReference weak_implementor___SetOnPaidEventListener;
	}
}
