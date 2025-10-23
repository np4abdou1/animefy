using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x02000191 RID: 401
	[Register("com/applovin/adview/AppLovinIncentivizedInterstitial", DoNotGenerateAcw = true)]
	public class AppLovinIncentivizedInterstitial : Java.Lang.Object
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x000358F8 File Offset: 0x00033AF8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinIncentivizedInterstitial._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0003591C File Offset: 0x00033B1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinIncentivizedInterstitial._members;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00035924 File Offset: 0x00033B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinIncentivizedInterstitial._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00035948 File Offset: 0x00033B48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinIncentivizedInterstitial._members.ManagedPeerType;
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinIncentivizedInterstitial(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00035954 File Offset: 0x00033B54
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppLovinIncentivizedInterstitial(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AppLovinIncentivizedInterstitial._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00035A04 File Offset: 0x00033C04
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinSdk;)V", "")]
		public unsafe AppLovinIncentivizedInterstitial(AppLovinSdk p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AppLovinIncentivizedInterstitial._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00035AB4 File Offset: 0x00033CB4
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;)V", "")]
		public unsafe AppLovinIncentivizedInterstitial(string p0, AppLovinSdk p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				base.SetHandle(AppLovinIncentivizedInterstitial._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00035B80 File Offset: 0x00033D80
		private static Delegate GetIsAdReadyToDisplayHandler()
		{
			if (AppLovinIncentivizedInterstitial.cb_isAdReadyToDisplay == null)
			{
				AppLovinIncentivizedInterstitial.cb_isAdReadyToDisplay = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinIncentivizedInterstitial.n_IsAdReadyToDisplay));
			}
			return AppLovinIncentivizedInterstitial.cb_isAdReadyToDisplay;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00035BA4 File Offset: 0x00033DA4
		private static bool n_IsAdReadyToDisplay(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAdReadyToDisplay;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00035BB3 File Offset: 0x00033DB3
		public virtual bool IsAdReadyToDisplay
		{
			[Register("isAdReadyToDisplay", "()Z", "GetIsAdReadyToDisplayHandler")]
			get
			{
				return AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualBooleanMethod("isAdReadyToDisplay.()Z", this, null);
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00035BCC File Offset: 0x00033DCC
		private static Delegate GetGetZoneIdHandler()
		{
			if (AppLovinIncentivizedInterstitial.cb_getZoneId == null)
			{
				AppLovinIncentivizedInterstitial.cb_getZoneId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinIncentivizedInterstitial.n_GetZoneId));
			}
			return AppLovinIncentivizedInterstitial.cb_getZoneId;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00035BF0 File Offset: 0x00033DF0
		private static IntPtr n_GetZoneId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneId);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00035C04 File Offset: 0x00033E04
		public virtual string ZoneId
		{
			[Register("getZoneId", "()Ljava/lang/String;", "GetGetZoneIdHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00035C38 File Offset: 0x00033E38
		[Register("create", "(Landroid/content/Context;)Lcom/applovin/adview/AppLovinIncentivizedInterstitial;", "")]
		public unsafe static AppLovinIncentivizedInterstitial Create(Context p0)
		{
			AppLovinIncentivizedInterstitial @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(AppLovinIncentivizedInterstitial._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;)Lcom/applovin/adview/AppLovinIncentivizedInterstitial;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00035CAC File Offset: 0x00033EAC
		[Register("create", "(Lcom/applovin/sdk/AppLovinSdk;)Lcom/applovin/adview/AppLovinIncentivizedInterstitial;", "")]
		public unsafe static AppLovinIncentivizedInterstitial Create(AppLovinSdk p0)
		{
			AppLovinIncentivizedInterstitial @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(AppLovinIncentivizedInterstitial._members.StaticMethods.InvokeObjectMethod("create.(Lcom/applovin/sdk/AppLovinSdk;)Lcom/applovin/adview/AppLovinIncentivizedInterstitial;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00035D20 File Offset: 0x00033F20
		[Register("create", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;)Lcom/applovin/adview/AppLovinIncentivizedInterstitial;", "")]
		public unsafe static AppLovinIncentivizedInterstitial Create(string p0, AppLovinSdk p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinIncentivizedInterstitial @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(AppLovinIncentivizedInterstitial._members.StaticMethods.InvokeObjectMethod("create.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;)Lcom/applovin/adview/AppLovinIncentivizedInterstitial;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00035DB4 File Offset: 0x00033FB4
		private static Delegate GetPreload_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_preload_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_preload_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinIncentivizedInterstitial.n_Preload_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinIncentivizedInterstitial.cb_preload_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00035DD8 File Offset: 0x00033FD8
		private static void n_Preload_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Preload(object2);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00035DFC File Offset: 0x00033FFC
		[Register("preload", "(Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetPreload_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void Preload(IAppLovinAdLoadListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("preload.(Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00035E64 File Offset: 0x00034064
		private static Delegate GetShow_Landroid_content_Context_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinIncentivizedInterstitial.n_Show_Landroid_content_Context_));
			}
			return AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00035E88 File Offset: 0x00034088
		private static void n_Show_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00035EAC File Offset: 0x000340AC
		[Register("show", "(Landroid/content/Context;)V", "GetShow_Landroid_content_Context_Handler")]
		public unsafe virtual void Show(Context p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00035F10 File Offset: 0x00034110
		private static Delegate GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinIncentivizedInterstitial.n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_));
			}
			return AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00035F34 File Offset: 0x00034134
		private static void n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdRewardListener object3 = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00035F60 File Offset: 0x00034160
		[Register("show", "(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;)V", "GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Handler")]
		public unsafe virtual void Show(Context p0, IAppLovinAdRewardListener p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00035FF0 File Offset: 0x000341F0
		private static Delegate GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinIncentivizedInterstitial.n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_));
			}
			return AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00036014 File Offset: 0x00034214
		private static void n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdRewardListener object3 = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdVideoPlaybackListener object4 = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3, object4);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0003604C File Offset: 0x0003424C
		[Register("show", "(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;)V", "GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Handler")]
		public unsafe virtual void Show(Context p0, IAppLovinAdRewardListener p1, IAppLovinAdVideoPlaybackListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003610C File Offset: 0x0003430C
		private static Delegate GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(AppLovinIncentivizedInterstitial.n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_));
			}
			return AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00036130 File Offset: 0x00034330
		private static void n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdRewardListener object3 = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdVideoPlaybackListener object4 = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdDisplayListener object5 = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3, object4, object5);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00036170 File Offset: 0x00034370
		[Register("show", "(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", "GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler")]
		public unsafe virtual void Show(Context p0, IAppLovinAdRewardListener p1, IAppLovinAdVideoPlaybackListener p2, IAppLovinAdDisplayListener p3)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00036264 File Offset: 0x00034464
		private static Delegate GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLL_V(AppLovinIncentivizedInterstitial.n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_));
			}
			return AppLovinIncentivizedInterstitial.cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00036288 File Offset: 0x00034488
		private static void n_Show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdRewardListener object3 = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdVideoPlaybackListener object4 = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdDisplayListener object5 = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdClickListener object6 = Java.Lang.Object.GetObject<IAppLovinAdClickListener>(native_p4, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3, object4, object5, object6);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000362D4 File Offset: 0x000344D4
		[Register("show", "(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;Lcom/applovin/sdk/AppLovinAdDisplayListener;Lcom/applovin/sdk/AppLovinAdClickListener;)V", "GetShow_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler")]
		public unsafe virtual void Show(Context p0, IAppLovinAdRewardListener p1, IAppLovinAdVideoPlaybackListener p2, IAppLovinAdDisplayListener p3, IAppLovinAdClickListener p4)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
				ptr[4] = new JniArgumentValue((p4 == null) ? IntPtr.Zero : ((Java.Lang.Object)p4).Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;Lcom/applovin/sdk/AppLovinAdDisplayListener;Lcom/applovin/sdk/AppLovinAdClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
				GC.KeepAlive(p4);
			}
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000363FC File Offset: 0x000345FC
		private static Delegate GetShow_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler()
		{
			if (AppLovinIncentivizedInterstitial.cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_ == null)
			{
				AppLovinIncentivizedInterstitial.cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLLL_V(AppLovinIncentivizedInterstitial.n_Show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_));
			}
			return AppLovinIncentivizedInterstitial.cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00036420 File Offset: 0x00034620
		private static void n_Show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			AppLovinIncentivizedInterstitial @object = Java.Lang.Object.GetObject<AppLovinIncentivizedInterstitial>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_p1, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdRewardListener object4 = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdVideoPlaybackListener object5 = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdDisplayListener object6 = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(native_p4, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdClickListener object7 = Java.Lang.Object.GetObject<IAppLovinAdClickListener>(native_p5, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3, object4, object5, object6, object7);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00036478 File Offset: 0x00034678
		[Register("show", "(Lcom/applovin/sdk/AppLovinAd;Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;Lcom/applovin/sdk/AppLovinAdDisplayListener;Lcom/applovin/sdk/AppLovinAdClickListener;)V", "GetShow_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler")]
		public unsafe virtual void Show(IAppLovinAd p0, Context p1, IAppLovinAdRewardListener p2, IAppLovinAdVideoPlaybackListener p3, IAppLovinAdDisplayListener p4, IAppLovinAdClickListener p5)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
				ptr[4] = new JniArgumentValue((p4 == null) ? IntPtr.Zero : ((Java.Lang.Object)p4).Handle);
				ptr[5] = new JniArgumentValue((p5 == null) ? IntPtr.Zero : ((Java.Lang.Object)p5).Handle);
				AppLovinIncentivizedInterstitial._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Lcom/applovin/sdk/AppLovinAd;Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;Lcom/applovin/sdk/AppLovinAdDisplayListener;Lcom/applovin/sdk/AppLovinAdClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
				GC.KeepAlive(p4);
				GC.KeepAlive(p5);
			}
		}

		// Token: 0x0400061B RID: 1563
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinIncentivizedInterstitial", typeof(AppLovinIncentivizedInterstitial));

		// Token: 0x0400061C RID: 1564
		private static Delegate cb_isAdReadyToDisplay;

		// Token: 0x0400061D RID: 1565
		private static Delegate cb_getZoneId;

		// Token: 0x0400061E RID: 1566
		private static Delegate cb_preload_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x0400061F RID: 1567
		private static Delegate cb_show_Landroid_content_Context_;

		// Token: 0x04000620 RID: 1568
		private static Delegate cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_;

		// Token: 0x04000621 RID: 1569
		private static Delegate cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;

		// Token: 0x04000622 RID: 1570
		private static Delegate cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;

		// Token: 0x04000623 RID: 1571
		private static Delegate cb_show_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_;

		// Token: 0x04000624 RID: 1572
		private static Delegate cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Lcom_applovin_sdk_AppLovinAdClickListener_;
	}
}
