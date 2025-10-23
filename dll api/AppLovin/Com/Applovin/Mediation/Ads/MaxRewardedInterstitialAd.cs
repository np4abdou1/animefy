using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Ads
{
	// Token: 0x020000ED RID: 237
	[Register("com/applovin/mediation/ads/MaxRewardedInterstitialAd", DoNotGenerateAcw = true)]
	public class MaxRewardedInterstitialAd : Java.Lang.Object
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000192C0 File Offset: 0x000174C0
		internal static IntPtr class_ref
		{
			get
			{
				return MaxRewardedInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000192E4 File Offset: 0x000174E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxRewardedInterstitialAd._members;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x000192EC File Offset: 0x000174EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxRewardedInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00019310 File Offset: 0x00017510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxRewardedInterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxRewardedInterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0001931C File Offset: 0x0001751C
		[Register(".ctor", "(Ljava/lang/String;Landroid/app/Activity;)V", "")]
		public unsafe MaxRewardedInterstitialAd(string p0, Activity p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxRewardedInterstitialAd._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxRewardedInterstitialAd._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000193E8 File Offset: 0x000175E8
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)V", "")]
		public unsafe MaxRewardedInterstitialAd(string p0, AppLovinSdk p1, Activity p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(MaxRewardedInterstitialAd._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxRewardedInterstitialAd._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000194E0 File Offset: 0x000176E0
		private static Delegate GetGetActivityHandler()
		{
			if (MaxRewardedInterstitialAd.cb_getActivity == null)
			{
				MaxRewardedInterstitialAd.cb_getActivity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxRewardedInterstitialAd.n_GetActivity));
			}
			return MaxRewardedInterstitialAd.cb_getActivity;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00019504 File Offset: 0x00017704
		private static IntPtr n_GetActivity(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Activity);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00019518 File Offset: 0x00017718
		public virtual Activity Activity
		{
			[Register("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Activity>(MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualObjectMethod("getActivity.()Landroid/app/Activity;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001954A File Offset: 0x0001774A
		private static Delegate GetIsReadyHandler()
		{
			if (MaxRewardedInterstitialAd.cb_isReady == null)
			{
				MaxRewardedInterstitialAd.cb_isReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxRewardedInterstitialAd.n_IsReady));
			}
			return MaxRewardedInterstitialAd.cb_isReady;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001956E File Offset: 0x0001776E
		private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReady;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0001957D File Offset: 0x0001777D
		public virtual bool IsReady
		{
			[Register("isReady", "()Z", "GetIsReadyHandler")]
			get
			{
				return MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualBooleanMethod("isReady.()Z", this, null);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00019596 File Offset: 0x00017796
		private static Delegate GetDestroyHandler()
		{
			if (MaxRewardedInterstitialAd.cb_destroy == null)
			{
				MaxRewardedInterstitialAd.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxRewardedInterstitialAd.n_Destroy));
			}
			return MaxRewardedInterstitialAd.cb_destroy;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000195BA File Offset: 0x000177BA
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000195C9 File Offset: 0x000177C9
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000195E2 File Offset: 0x000177E2
		private static Delegate GetLoadAdHandler()
		{
			if (MaxRewardedInterstitialAd.cb_loadAd == null)
			{
				MaxRewardedInterstitialAd.cb_loadAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxRewardedInterstitialAd.n_LoadAd));
			}
			return MaxRewardedInterstitialAd.cb_loadAd;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00019606 File Offset: 0x00017806
		private static void n_LoadAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadAd();
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00019615 File Offset: 0x00017815
		[Register("loadAd", "()V", "GetLoadAdHandler")]
		public virtual void LoadAd()
		{
			MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.()V", this, null);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001962E File Offset: 0x0001782E
		private static Delegate GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ == null)
			{
				MaxRewardedInterstitialAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedInterstitialAd.n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_));
			}
			return MaxRewardedInterstitialAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00019654 File Offset: 0x00017854
		private static void n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdReviewListener object2 = Java.Lang.Object.GetObject<IMaxAdReviewListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdReviewListener(object2);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00019678 File Offset: 0x00017878
		[Register("setAdReviewListener", "(Lcom/applovin/mediation/MaxAdReviewListener;)V", "GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler")]
		public unsafe virtual void SetAdReviewListener(IMaxAdReviewListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setAdReviewListener.(Lcom/applovin/mediation/MaxAdReviewListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000196E0 File Offset: 0x000178E0
		private static Delegate GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxRewardedInterstitialAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxRewardedInterstitialAd.n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxRewardedInterstitialAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00019704 File Offset: 0x00017904
		private static void n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetExtraParameter(@string, string2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00019730 File Offset: 0x00017930
		[Register("setExtraParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void SetExtraParameter(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraParameter.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000197AC File Offset: 0x000179AC
		private static Delegate GetSetListener_Lcom_applovin_mediation_MaxRewardedAdListener_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_ == null)
			{
				MaxRewardedInterstitialAd.cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedInterstitialAd.n_SetListener_Lcom_applovin_mediation_MaxRewardedAdListener_));
			}
			return MaxRewardedInterstitialAd.cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000197D0 File Offset: 0x000179D0
		private static void n_SetListener_Lcom_applovin_mediation_MaxRewardedAdListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdListener object2 = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetListener(object2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000197F4 File Offset: 0x000179F4
		[Register("setListener", "(Lcom/applovin/mediation/MaxRewardedAdListener;)V", "GetSetListener_Lcom_applovin_mediation_MaxRewardedAdListener_Handler")]
		public unsafe virtual void SetListener(IMaxRewardedAdListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/applovin/mediation/MaxRewardedAdListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001985C File Offset: 0x00017A5C
		private static Delegate GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				MaxRewardedInterstitialAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxRewardedInterstitialAd.n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_));
			}
			return MaxRewardedInterstitialAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00019880 File Offset: 0x00017A80
		private static void n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetLocalExtraParameter(@string, object2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000198AC File Offset: 0x00017AAC
		[Register("setLocalExtraParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetLocalExtraParameter(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setLocalExtraParameter.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00019930 File Offset: 0x00017B30
		private static Delegate GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ == null)
			{
				MaxRewardedInterstitialAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedInterstitialAd.n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_));
			}
			return MaxRewardedInterstitialAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00019954 File Offset: 0x00017B54
		private static void n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdRevenueListener object2 = Java.Lang.Object.GetObject<IMaxAdRevenueListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetRevenueListener(object2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00019978 File Offset: 0x00017B78
		[Register("setRevenueListener", "(Lcom/applovin/mediation/MaxAdRevenueListener;)V", "GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler")]
		public unsafe virtual void SetRevenueListener(IMaxAdRevenueListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setRevenueListener.(Lcom/applovin/mediation/MaxAdRevenueListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000199E0 File Offset: 0x00017BE0
		private static Delegate GetShowAdHandler()
		{
			if (MaxRewardedInterstitialAd.cb_showAd == null)
			{
				MaxRewardedInterstitialAd.cb_showAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxRewardedInterstitialAd.n_ShowAd));
			}
			return MaxRewardedInterstitialAd.cb_showAd;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00019A04 File Offset: 0x00017C04
		private static void n_ShowAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowAd();
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00019A13 File Offset: 0x00017C13
		[Register("showAd", "()V", "GetShowAdHandler")]
		public virtual void ShowAd()
		{
			MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.()V", this, null);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00019A2C File Offset: 0x00017C2C
		private static Delegate GetShowAd_Ljava_lang_String_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_showAd_Ljava_lang_String_ == null)
			{
				MaxRewardedInterstitialAd.cb_showAd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedInterstitialAd.n_ShowAd_Ljava_lang_String_));
			}
			return MaxRewardedInterstitialAd.cb_showAd_Ljava_lang_String_;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00019A50 File Offset: 0x00017C50
		private static void n_ShowAd_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ShowAd(@string);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00019A74 File Offset: 0x00017C74
		[Register("showAd", "(Ljava/lang/String;)V", "GetShowAd_Ljava_lang_String_Handler")]
		public unsafe virtual void ShowAd(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00019AD0 File Offset: 0x00017CD0
		private static Delegate GetShowAd_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxRewardedInterstitialAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxRewardedInterstitialAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxRewardedInterstitialAd.n_ShowAd_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxRewardedInterstitialAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00019AF4 File Offset: 0x00017CF4
		private static void n_ShowAd_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxRewardedInterstitialAd @object = Java.Lang.Object.GetObject<MaxRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ShowAd(@string, string2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00019B20 File Offset: 0x00017D20
		[Register("showAd", "(Ljava/lang/String;Ljava/lang/String;)V", "GetShowAd_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void ShowAd(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				MaxRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060009B1 RID: 2481 RVA: 0x00019B9C File Offset: 0x00017D9C
		// (remove) Token: 0x060009B2 RID: 2482 RVA: 0x00019BE8 File Offset: 0x00017DE8
		public event EventHandler<MaxAdReviewEventArgs> AdReview
		{
			add
			{
				EventHelper.AddEventHandler<IMaxAdReviewListener, IMaxAdReviewListenerImplementor>(ref this.weak_implementor_SetAdReviewListener, new Func<IMaxAdReviewListenerImplementor>(this.__CreateIMaxAdReviewListenerImplementor), new Action<IMaxAdReviewListener>(this.SetAdReviewListener), delegate(IMaxAdReviewListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdReviewEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IMaxAdReviewListener, IMaxAdReviewListenerImplementor>(ref this.weak_implementor_SetAdReviewListener, new Func<IMaxAdReviewListenerImplementor, bool>(IMaxAdReviewListenerImplementor.__IsEmpty), delegate(IMaxAdReviewListener __v)
				{
					this.SetAdReviewListener(null);
				}, delegate(IMaxAdReviewListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdReviewEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00017B10 File Offset: 0x00015D10
		private IMaxAdReviewListenerImplementor __CreateIMaxAdReviewListenerImplementor()
		{
			return new IMaxAdReviewListenerImplementor(this);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060009B4 RID: 2484 RVA: 0x00019C38 File Offset: 0x00017E38
		// (remove) Token: 0x060009B5 RID: 2485 RVA: 0x00019C84 File Offset: 0x00017E84
		public event EventHandler<MaxAdRevenueEventArgs> Revenue
		{
			add
			{
				EventHelper.AddEventHandler<IMaxAdRevenueListener, IMaxAdRevenueListenerImplementor>(ref this.weak_implementor_SetRevenueListener, new Func<IMaxAdRevenueListenerImplementor>(this.__CreateIMaxAdRevenueListenerImplementor), new Action<IMaxAdRevenueListener>(this.SetRevenueListener), delegate(IMaxAdRevenueListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdRevenueEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IMaxAdRevenueListener, IMaxAdRevenueListenerImplementor>(ref this.weak_implementor_SetRevenueListener, new Func<IMaxAdRevenueListenerImplementor, bool>(IMaxAdRevenueListenerImplementor.__IsEmpty), delegate(IMaxAdRevenueListener __v)
				{
					this.SetRevenueListener(null);
				}, delegate(IMaxAdRevenueListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdRevenueEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00013E20 File Offset: 0x00012020
		private IMaxAdRevenueListenerImplementor __CreateIMaxAdRevenueListenerImplementor()
		{
			return new IMaxAdRevenueListenerImplementor(this);
		}

		// Token: 0x04000326 RID: 806
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/ads/MaxRewardedInterstitialAd", typeof(MaxRewardedInterstitialAd));

		// Token: 0x04000327 RID: 807
		private static Delegate cb_getActivity;

		// Token: 0x04000328 RID: 808
		private static Delegate cb_isReady;

		// Token: 0x04000329 RID: 809
		private static Delegate cb_destroy;

		// Token: 0x0400032A RID: 810
		private static Delegate cb_loadAd;

		// Token: 0x0400032B RID: 811
		private static Delegate cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;

		// Token: 0x0400032C RID: 812
		private static Delegate cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_;

		// Token: 0x0400032E RID: 814
		private static Delegate cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x0400032F RID: 815
		private static Delegate cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;

		// Token: 0x04000330 RID: 816
		private static Delegate cb_showAd;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_showAd_Ljava_lang_String_;

		// Token: 0x04000332 RID: 818
		private static Delegate cb_showAd_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000333 RID: 819
		private WeakReference weak_implementor_SetAdReviewListener;

		// Token: 0x04000334 RID: 820
		private WeakReference weak_implementor_SetRevenueListener;
	}
}
