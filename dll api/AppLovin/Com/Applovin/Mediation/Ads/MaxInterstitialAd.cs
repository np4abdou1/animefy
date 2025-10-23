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
	// Token: 0x020000E3 RID: 227
	[Register("com/applovin/mediation/ads/MaxInterstitialAd", DoNotGenerateAcw = true)]
	public class MaxInterstitialAd : Java.Lang.Object
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00017C64 File Offset: 0x00015E64
		internal static IntPtr class_ref
		{
			get
			{
				return MaxInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x00017C88 File Offset: 0x00015E88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxInterstitialAd._members;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00017C90 File Offset: 0x00015E90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00017CB4 File Offset: 0x00015EB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxInterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxInterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00017CC0 File Offset: 0x00015EC0
		[Register(".ctor", "(Ljava/lang/String;Landroid/app/Activity;)V", "")]
		public unsafe MaxInterstitialAd(string p0, Activity p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxInterstitialAd._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxInterstitialAd._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00017D8C File Offset: 0x00015F8C
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)V", "")]
		public unsafe MaxInterstitialAd(string p0, AppLovinSdk p1, Activity p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxInterstitialAd._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxInterstitialAd._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00017E84 File Offset: 0x00016084
		private static Delegate GetGetActivityHandler()
		{
			if (MaxInterstitialAd.cb_getActivity == null)
			{
				MaxInterstitialAd.cb_getActivity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxInterstitialAd.n_GetActivity));
			}
			return MaxInterstitialAd.cb_getActivity;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00017EA8 File Offset: 0x000160A8
		private static IntPtr n_GetActivity(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Activity);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00017EBC File Offset: 0x000160BC
		public virtual Activity Activity
		{
			[Register("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Activity>(MaxInterstitialAd._members.InstanceMethods.InvokeVirtualObjectMethod("getActivity.()Landroid/app/Activity;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00017EEE File Offset: 0x000160EE
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (MaxInterstitialAd.cb_getAdUnitId == null)
			{
				MaxInterstitialAd.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxInterstitialAd.n_GetAdUnitId));
			}
			return MaxInterstitialAd.cb_getAdUnitId;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00017F12 File Offset: 0x00016112
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00017F28 File Offset: 0x00016128
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxInterstitialAd._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00017F5A File Offset: 0x0001615A
		private static Delegate GetIsReadyHandler()
		{
			if (MaxInterstitialAd.cb_isReady == null)
			{
				MaxInterstitialAd.cb_isReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxInterstitialAd.n_IsReady));
			}
			return MaxInterstitialAd.cb_isReady;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00017F7E File Offset: 0x0001617E
		private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReady;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00017F8D File Offset: 0x0001618D
		public virtual bool IsReady
		{
			[Register("isReady", "()Z", "GetIsReadyHandler")]
			get
			{
				return MaxInterstitialAd._members.InstanceMethods.InvokeVirtualBooleanMethod("isReady.()Z", this, null);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00017FA6 File Offset: 0x000161A6
		private static Delegate GetDestroyHandler()
		{
			if (MaxInterstitialAd.cb_destroy == null)
			{
				MaxInterstitialAd.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxInterstitialAd.n_Destroy));
			}
			return MaxInterstitialAd.cb_destroy;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00017FCA File Offset: 0x000161CA
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00017FD9 File Offset: 0x000161D9
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00017FF2 File Offset: 0x000161F2
		private static Delegate GetLoadAdHandler()
		{
			if (MaxInterstitialAd.cb_loadAd == null)
			{
				MaxInterstitialAd.cb_loadAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxInterstitialAd.n_LoadAd));
			}
			return MaxInterstitialAd.cb_loadAd;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00018016 File Offset: 0x00016216
		private static void n_LoadAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadAd();
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00018025 File Offset: 0x00016225
		[Register("loadAd", "()V", "GetLoadAdHandler")]
		public virtual void LoadAd()
		{
			MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.()V", this, null);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0001803E File Offset: 0x0001623E
		private static Delegate GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler()
		{
			if (MaxInterstitialAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ == null)
			{
				MaxInterstitialAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxInterstitialAd.n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_));
			}
			return MaxInterstitialAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00018064 File Offset: 0x00016264
		private static void n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdReviewListener object2 = Java.Lang.Object.GetObject<IMaxAdReviewListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdReviewListener(object2);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00018088 File Offset: 0x00016288
		[Register("setAdReviewListener", "(Lcom/applovin/mediation/MaxAdReviewListener;)V", "GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler")]
		public unsafe virtual void SetAdReviewListener(IMaxAdReviewListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setAdReviewListener.(Lcom/applovin/mediation/MaxAdReviewListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000180F0 File Offset: 0x000162F0
		private static Delegate GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxInterstitialAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxInterstitialAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxInterstitialAd.n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxInterstitialAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00018114 File Offset: 0x00016314
		private static void n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetExtraParameter(@string, string2);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00018140 File Offset: 0x00016340
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
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraParameter.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000181BC File Offset: 0x000163BC
		private static Delegate GetSetListener_Lcom_applovin_mediation_MaxAdListener_Handler()
		{
			if (MaxInterstitialAd.cb_setListener_Lcom_applovin_mediation_MaxAdListener_ == null)
			{
				MaxInterstitialAd.cb_setListener_Lcom_applovin_mediation_MaxAdListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxInterstitialAd.n_SetListener_Lcom_applovin_mediation_MaxAdListener_));
			}
			return MaxInterstitialAd.cb_setListener_Lcom_applovin_mediation_MaxAdListener_;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000181E0 File Offset: 0x000163E0
		private static void n_SetListener_Lcom_applovin_mediation_MaxAdListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdListener object2 = Java.Lang.Object.GetObject<IMaxAdListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetListener(object2);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00018204 File Offset: 0x00016404
		[Register("setListener", "(Lcom/applovin/mediation/MaxAdListener;)V", "GetSetListener_Lcom_applovin_mediation_MaxAdListener_Handler")]
		public unsafe virtual void SetListener(IMaxAdListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/applovin/mediation/MaxAdListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0001826C File Offset: 0x0001646C
		private static Delegate GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (MaxInterstitialAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				MaxInterstitialAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxInterstitialAd.n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_));
			}
			return MaxInterstitialAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00018290 File Offset: 0x00016490
		private static void n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetLocalExtraParameter(@string, object2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000182BC File Offset: 0x000164BC
		[Register("setLocalExtraParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetLocalExtraParameter(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setLocalExtraParameter.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00018340 File Offset: 0x00016540
		private static Delegate GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler()
		{
			if (MaxInterstitialAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ == null)
			{
				MaxInterstitialAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxInterstitialAd.n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_));
			}
			return MaxInterstitialAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00018364 File Offset: 0x00016564
		private static void n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdRevenueListener object2 = Java.Lang.Object.GetObject<IMaxAdRevenueListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetRevenueListener(object2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00018388 File Offset: 0x00016588
		[Register("setRevenueListener", "(Lcom/applovin/mediation/MaxAdRevenueListener;)V", "GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler")]
		public unsafe virtual void SetRevenueListener(IMaxAdRevenueListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setRevenueListener.(Lcom/applovin/mediation/MaxAdRevenueListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000183F0 File Offset: 0x000165F0
		private static Delegate GetShowAdHandler()
		{
			if (MaxInterstitialAd.cb_showAd == null)
			{
				MaxInterstitialAd.cb_showAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxInterstitialAd.n_ShowAd));
			}
			return MaxInterstitialAd.cb_showAd;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00018414 File Offset: 0x00016614
		private static void n_ShowAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowAd();
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00018423 File Offset: 0x00016623
		[Register("showAd", "()V", "GetShowAdHandler")]
		public virtual void ShowAd()
		{
			MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.()V", this, null);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001843C File Offset: 0x0001663C
		private static Delegate GetShowAd_Ljava_lang_String_Handler()
		{
			if (MaxInterstitialAd.cb_showAd_Ljava_lang_String_ == null)
			{
				MaxInterstitialAd.cb_showAd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxInterstitialAd.n_ShowAd_Ljava_lang_String_));
			}
			return MaxInterstitialAd.cb_showAd_Ljava_lang_String_;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00018460 File Offset: 0x00016660
		private static void n_ShowAd_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ShowAd(@string);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00018484 File Offset: 0x00016684
		[Register("showAd", "(Ljava/lang/String;)V", "GetShowAd_Ljava_lang_String_Handler")]
		public unsafe virtual void ShowAd(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000184E0 File Offset: 0x000166E0
		private static Delegate GetShowAd_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxInterstitialAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxInterstitialAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxInterstitialAd.n_ShowAd_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxInterstitialAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00018504 File Offset: 0x00016704
		private static void n_ShowAd_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxInterstitialAd @object = Java.Lang.Object.GetObject<MaxInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ShowAd(@string, string2);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00018530 File Offset: 0x00016730
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
				MaxInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000934 RID: 2356 RVA: 0x000185AC File Offset: 0x000167AC
		// (remove) Token: 0x06000935 RID: 2357 RVA: 0x000185F8 File Offset: 0x000167F8
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

		// Token: 0x06000936 RID: 2358 RVA: 0x00017B10 File Offset: 0x00015D10
		private IMaxAdReviewListenerImplementor __CreateIMaxAdReviewListenerImplementor()
		{
			return new IMaxAdReviewListenerImplementor(this);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00018648 File Offset: 0x00016848
		private IMaxAdListenerImplementor __CreateIMaxAdListenerImplementor()
		{
			return new IMaxAdListenerImplementor(this);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000938 RID: 2360 RVA: 0x00018650 File Offset: 0x00016850
		// (remove) Token: 0x06000939 RID: 2361 RVA: 0x0001869C File Offset: 0x0001689C
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

		// Token: 0x0600093A RID: 2362 RVA: 0x00013E20 File Offset: 0x00012020
		private IMaxAdRevenueListenerImplementor __CreateIMaxAdRevenueListenerImplementor()
		{
			return new IMaxAdRevenueListenerImplementor(this);
		}

		// Token: 0x040002FA RID: 762
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/ads/MaxInterstitialAd", typeof(MaxInterstitialAd));

		// Token: 0x040002FB RID: 763
		private static Delegate cb_getActivity;

		// Token: 0x040002FC RID: 764
		private static Delegate cb_getAdUnitId;

		// Token: 0x040002FD RID: 765
		private static Delegate cb_isReady;

		// Token: 0x040002FE RID: 766
		private static Delegate cb_destroy;

		// Token: 0x040002FF RID: 767
		private static Delegate cb_loadAd;

		// Token: 0x04000300 RID: 768
		private static Delegate cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;

		// Token: 0x04000301 RID: 769
		private static Delegate cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000302 RID: 770
		private static Delegate cb_setListener_Lcom_applovin_mediation_MaxAdListener_;

		// Token: 0x04000303 RID: 771
		private static Delegate cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x04000304 RID: 772
		private static Delegate cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;

		// Token: 0x04000305 RID: 773
		private static Delegate cb_showAd;

		// Token: 0x04000306 RID: 774
		private static Delegate cb_showAd_Ljava_lang_String_;

		// Token: 0x04000307 RID: 775
		private static Delegate cb_showAd_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000308 RID: 776
		private WeakReference weak_implementor_SetAdReviewListener;

		// Token: 0x04000309 RID: 777
		private WeakReference weak_implementor_SetRevenueListener;
	}
}
