using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Interstitial
{
	// Token: 0x02000032 RID: 50
	[Register("com/google/android/gms/ads/interstitial/InterstitialAd", DoNotGenerateAcw = true)]
	public abstract class InterstitialAd : Java.Lang.Object
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000683C File Offset: 0x00004A3C
		internal static IntPtr class_ref
		{
			get
			{
				return InterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00006860 File Offset: 0x00004A60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InterstitialAd._members;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00006868 File Offset: 0x00004A68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000688C File Offset: 0x00004A8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000020AC File Offset: 0x000002AC
		protected InterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00006898 File Offset: 0x00004A98
		[Register(".ctor", "()V", "")]
		public InterstitialAd() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InterstitialAd._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InterstitialAd._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006906 File Offset: 0x00004B06
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (InterstitialAd.cb_getAdUnitId == null)
			{
				InterstitialAd.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InterstitialAd.n_GetAdUnitId));
			}
			return InterstitialAd.cb_getAdUnitId;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000692A File Offset: 0x00004B2A
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001FF RID: 511
		public abstract string AdUnitId { [Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")] get; }

		// Token: 0x06000200 RID: 512 RVA: 0x0000693E File Offset: 0x00004B3E
		private static Delegate GetGetFullScreenContentCallbackHandler()
		{
			if (InterstitialAd.cb_getFullScreenContentCallback == null)
			{
				InterstitialAd.cb_getFullScreenContentCallback = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InterstitialAd.n_GetFullScreenContentCallback));
			}
			return InterstitialAd.cb_getFullScreenContentCallback;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006962 File Offset: 0x00004B62
		private static IntPtr n_GetFullScreenContentCallback(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FullScreenContentCallback);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00006976 File Offset: 0x00004B76
		private static Delegate GetSetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_Handler()
		{
			if (InterstitialAd.cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_ == null)
			{
				InterstitialAd.cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InterstitialAd.n_SetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_));
			}
			return InterstitialAd.cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000699C File Offset: 0x00004B9C
		private static void n_SetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			InterstitialAd @object = Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FullScreenContentCallback object2 = Java.Lang.Object.GetObject<FullScreenContentCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.FullScreenContentCallback = object2;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000204 RID: 516
		// (set) Token: 0x06000205 RID: 517
		public abstract FullScreenContentCallback FullScreenContentCallback { [Register("getFullScreenContentCallback", "()Lcom/google/android/gms/ads/FullScreenContentCallback;", "GetGetFullScreenContentCallbackHandler")] get; [Register("setFullScreenContentCallback", "(Lcom/google/android/gms/ads/FullScreenContentCallback;)V", "GetSetFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_Handler")] set; }

		// Token: 0x06000206 RID: 518 RVA: 0x000069BF File Offset: 0x00004BBF
		private static Delegate GetGetOnPaidEventListenerHandler()
		{
			if (InterstitialAd.cb_getOnPaidEventListener == null)
			{
				InterstitialAd.cb_getOnPaidEventListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InterstitialAd.n_GetOnPaidEventListener));
			}
			return InterstitialAd.cb_getOnPaidEventListener;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000069E3 File Offset: 0x00004BE3
		private static IntPtr n_GetOnPaidEventListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPaidEventListener);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000069F7 File Offset: 0x00004BF7
		private static Delegate GetSetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_Handler()
		{
			if (InterstitialAd.cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_ == null)
			{
				InterstitialAd.cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InterstitialAd.n_SetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_));
			}
			return InterstitialAd.cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006A1C File Offset: 0x00004C1C
		private static void n_SetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			InterstitialAd @object = Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnPaidEventListener object2 = Java.Lang.Object.GetObject<IOnPaidEventListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnPaidEventListener = object2;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600020A RID: 522
		// (set) Token: 0x0600020B RID: 523
		public abstract IOnPaidEventListener OnPaidEventListener { [Register("getOnPaidEventListener", "()Lcom/google/android/gms/ads/OnPaidEventListener;", "GetGetOnPaidEventListenerHandler")] get; [Register("setOnPaidEventListener", "(Lcom/google/android/gms/ads/OnPaidEventListener;)V", "GetSetOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_Handler")] set; }

		// Token: 0x0600020C RID: 524 RVA: 0x00006A3F File Offset: 0x00004C3F
		private static Delegate GetGetResponseInfoHandler()
		{
			if (InterstitialAd.cb_getResponseInfo == null)
			{
				InterstitialAd.cb_getResponseInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InterstitialAd.n_GetResponseInfo));
			}
			return InterstitialAd.cb_getResponseInfo;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006A63 File Offset: 0x00004C63
		private static IntPtr n_GetResponseInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResponseInfo);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600020E RID: 526
		public abstract ResponseInfo ResponseInfo { [Register("getResponseInfo", "()Lcom/google/android/gms/ads/ResponseInfo;", "GetGetResponseInfoHandler")] get; }

		// Token: 0x0600020F RID: 527 RVA: 0x00006A78 File Offset: 0x00004C78
		[Register("load", "(Landroid/content/Context;Ljava/lang/String;Lcom/google/android/gms/ads/AdRequest;Lcom/google/android/gms/ads/interstitial/InterstitialAdLoadCallback;)V", "")]
		public unsafe static void Load(Context context, string adUnitId, AdRequest adRequest, InterstitialAdLoadCallback loadCallback)
		{
			IntPtr intPtr = JNIEnv.NewString(adUnitId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((adRequest == null) ? IntPtr.Zero : adRequest.Handle);
				ptr[3] = new JniArgumentValue((loadCallback == null) ? IntPtr.Zero : loadCallback.Handle);
				InterstitialAd._members.StaticMethods.InvokeVoidMethod("load.(Landroid/content/Context;Ljava/lang/String;Lcom/google/android/gms/ads/AdRequest;Lcom/google/android/gms/ads/interstitial/InterstitialAdLoadCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(adRequest);
				GC.KeepAlive(loadCallback);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006B50 File Offset: 0x00004D50
		private static Delegate GetSetImmersiveMode_ZHandler()
		{
			if (InterstitialAd.cb_setImmersiveMode_Z == null)
			{
				InterstitialAd.cb_setImmersiveMode_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(InterstitialAd.n_SetImmersiveMode_Z));
			}
			return InterstitialAd.cb_setImmersiveMode_Z;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00006B74 File Offset: 0x00004D74
		private static void n_SetImmersiveMode_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetImmersiveMode(p0);
		}

		// Token: 0x06000212 RID: 530
		[Register("setImmersiveMode", "(Z)V", "GetSetImmersiveMode_ZHandler")]
		public abstract void SetImmersiveMode(bool p0);

		// Token: 0x06000213 RID: 531 RVA: 0x00006B84 File Offset: 0x00004D84
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (InterstitialAd.cb_show_Landroid_app_Activity_ == null)
			{
				InterstitialAd.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InterstitialAd.n_Show_Landroid_app_Activity_));
			}
			return InterstitialAd.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006BA8 File Offset: 0x00004DA8
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			InterstitialAd @object = Java.Lang.Object.GetObject<InterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x06000215 RID: 533
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public abstract void Show(Activity p0);

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000216 RID: 534 RVA: 0x00006BCC File Offset: 0x00004DCC
		// (remove) Token: 0x06000217 RID: 535 RVA: 0x00006C1C File Offset: 0x00004E1C
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

		// Token: 0x06000218 RID: 536 RVA: 0x000060E8 File Offset: 0x000042E8
		private IOnPaidEventListenerImplementor __CreateIOnPaidEventListenerImplementor()
		{
			return new IOnPaidEventListenerImplementor(this);
		}

		// Token: 0x04000076 RID: 118
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/interstitial/InterstitialAd", typeof(InterstitialAd));

		// Token: 0x04000077 RID: 119
		private static Delegate cb_getAdUnitId;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_getFullScreenContentCallback;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_setFullScreenContentCallback_Lcom_google_android_gms_ads_FullScreenContentCallback_;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_getOnPaidEventListener;

		// Token: 0x0400007B RID: 123
		private static Delegate cb_setOnPaidEventListener_Lcom_google_android_gms_ads_OnPaidEventListener_;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_getResponseInfo;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_setImmersiveMode_Z;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_show_Landroid_app_Activity_;

		// Token: 0x0400007F RID: 127
		private WeakReference weak_implementor___SetOnPaidEventListener;
	}
}
