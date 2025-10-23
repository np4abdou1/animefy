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
	// Token: 0x020000E8 RID: 232
	[Register("com/applovin/mediation/ads/MaxRewardedAd", DoNotGenerateAcw = true)]
	public class MaxRewardedAd : Java.Lang.Object
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0001879C File Offset: 0x0001699C
		internal static IntPtr class_ref
		{
			get
			{
				return MaxRewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000187C0 File Offset: 0x000169C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxRewardedAd._members;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x000187C8 File Offset: 0x000169C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxRewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000187EC File Offset: 0x000169EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxRewardedAd._members.ManagedPeerType;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxRewardedAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000187F8 File Offset: 0x000169F8
		private static Delegate GetGetActivityHandler()
		{
			if (MaxRewardedAd.cb_getActivity == null)
			{
				MaxRewardedAd.cb_getActivity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxRewardedAd.n_GetActivity));
			}
			return MaxRewardedAd.cb_getActivity;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001881C File Offset: 0x00016A1C
		private static IntPtr n_GetActivity(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Activity);
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00018830 File Offset: 0x00016A30
		public virtual Activity Activity
		{
			[Register("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Activity>(MaxRewardedAd._members.InstanceMethods.InvokeVirtualObjectMethod("getActivity.()Landroid/app/Activity;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00018862 File Offset: 0x00016A62
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (MaxRewardedAd.cb_getAdUnitId == null)
			{
				MaxRewardedAd.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxRewardedAd.n_GetAdUnitId));
			}
			return MaxRewardedAd.cb_getAdUnitId;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00018886 File Offset: 0x00016A86
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0001889C File Offset: 0x00016A9C
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxRewardedAd._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000188CE File Offset: 0x00016ACE
		private static Delegate GetIsReadyHandler()
		{
			if (MaxRewardedAd.cb_isReady == null)
			{
				MaxRewardedAd.cb_isReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxRewardedAd.n_IsReady));
			}
			return MaxRewardedAd.cb_isReady;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000188F2 File Offset: 0x00016AF2
		private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReady;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00018901 File Offset: 0x00016B01
		public virtual bool IsReady
		{
			[Register("isReady", "()Z", "GetIsReadyHandler")]
			get
			{
				return MaxRewardedAd._members.InstanceMethods.InvokeVirtualBooleanMethod("isReady.()Z", this, null);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001891A File Offset: 0x00016B1A
		private static Delegate GetDestroyHandler()
		{
			if (MaxRewardedAd.cb_destroy == null)
			{
				MaxRewardedAd.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxRewardedAd.n_Destroy));
			}
			return MaxRewardedAd.cb_destroy;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0001893E File Offset: 0x00016B3E
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0001894D File Offset: 0x00016B4D
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00018968 File Offset: 0x00016B68
		[Register("getInstance", "(Ljava/lang/String;Landroid/app/Activity;)Lcom/applovin/mediation/ads/MaxRewardedAd;", "")]
		public unsafe static MaxRewardedAd GetInstance(string p0, Activity p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			MaxRewardedAd @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<MaxRewardedAd>(MaxRewardedAd._members.StaticMethods.InvokeObjectMethod("getInstance.(Ljava/lang/String;Landroid/app/Activity;)Lcom/applovin/mediation/ads/MaxRewardedAd;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000189FC File Offset: 0x00016BFC
		[Register("getInstance", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)Lcom/applovin/mediation/ads/MaxRewardedAd;", "")]
		public unsafe static MaxRewardedAd GetInstance(string p0, AppLovinSdk p1, Activity p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			MaxRewardedAd @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<MaxRewardedAd>(MaxRewardedAd._members.StaticMethods.InvokeObjectMethod("getInstance.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/app/Activity;)Lcom/applovin/mediation/ads/MaxRewardedAd;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00018ABC File Offset: 0x00016CBC
		private static Delegate GetLoadAdHandler()
		{
			if (MaxRewardedAd.cb_loadAd == null)
			{
				MaxRewardedAd.cb_loadAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxRewardedAd.n_LoadAd));
			}
			return MaxRewardedAd.cb_loadAd;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00018AE0 File Offset: 0x00016CE0
		private static void n_LoadAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadAd();
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00018AEF File Offset: 0x00016CEF
		[Register("loadAd", "()V", "GetLoadAdHandler")]
		public virtual void LoadAd()
		{
			MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.()V", this, null);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00018B08 File Offset: 0x00016D08
		private static Delegate GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler()
		{
			if (MaxRewardedAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ == null)
			{
				MaxRewardedAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedAd.n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_));
			}
			return MaxRewardedAd.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00018B2C File Offset: 0x00016D2C
		private static void n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdReviewListener object2 = Java.Lang.Object.GetObject<IMaxAdReviewListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdReviewListener(object2);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00018B50 File Offset: 0x00016D50
		[Register("setAdReviewListener", "(Lcom/applovin/mediation/MaxAdReviewListener;)V", "GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler")]
		public unsafe virtual void SetAdReviewListener(IMaxAdReviewListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("setAdReviewListener.(Lcom/applovin/mediation/MaxAdReviewListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00018BB8 File Offset: 0x00016DB8
		private static Delegate GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxRewardedAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxRewardedAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxRewardedAd.n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxRewardedAd.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00018BDC File Offset: 0x00016DDC
		private static void n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetExtraParameter(@string, string2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00018C08 File Offset: 0x00016E08
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
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraParameter.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00018C84 File Offset: 0x00016E84
		private static Delegate GetSetListener_Lcom_applovin_mediation_MaxRewardedAdListener_Handler()
		{
			if (MaxRewardedAd.cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_ == null)
			{
				MaxRewardedAd.cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedAd.n_SetListener_Lcom_applovin_mediation_MaxRewardedAdListener_));
			}
			return MaxRewardedAd.cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00018CA8 File Offset: 0x00016EA8
		private static void n_SetListener_Lcom_applovin_mediation_MaxRewardedAdListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdListener object2 = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetListener(object2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00018CCC File Offset: 0x00016ECC
		[Register("setListener", "(Lcom/applovin/mediation/MaxRewardedAdListener;)V", "GetSetListener_Lcom_applovin_mediation_MaxRewardedAdListener_Handler")]
		public unsafe virtual void SetListener(IMaxRewardedAdListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/applovin/mediation/MaxRewardedAdListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00018D34 File Offset: 0x00016F34
		private static Delegate GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (MaxRewardedAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				MaxRewardedAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxRewardedAd.n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_));
			}
			return MaxRewardedAd.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00018D58 File Offset: 0x00016F58
		private static void n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetLocalExtraParameter(@string, object2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00018D84 File Offset: 0x00016F84
		[Register("setLocalExtraParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetLocalExtraParameter(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("setLocalExtraParameter.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00018E08 File Offset: 0x00017008
		private static Delegate GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler()
		{
			if (MaxRewardedAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ == null)
			{
				MaxRewardedAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedAd.n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_));
			}
			return MaxRewardedAd.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00018E2C File Offset: 0x0001702C
		private static void n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdRevenueListener object2 = Java.Lang.Object.GetObject<IMaxAdRevenueListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetRevenueListener(object2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00018E50 File Offset: 0x00017050
		[Register("setRevenueListener", "(Lcom/applovin/mediation/MaxAdRevenueListener;)V", "GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler")]
		public unsafe virtual void SetRevenueListener(IMaxAdRevenueListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("setRevenueListener.(Lcom/applovin/mediation/MaxAdRevenueListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00018EB8 File Offset: 0x000170B8
		private static Delegate GetShowAdHandler()
		{
			if (MaxRewardedAd.cb_showAd == null)
			{
				MaxRewardedAd.cb_showAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxRewardedAd.n_ShowAd));
			}
			return MaxRewardedAd.cb_showAd;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00018EDC File Offset: 0x000170DC
		private static void n_ShowAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowAd();
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00018EEB File Offset: 0x000170EB
		[Register("showAd", "()V", "GetShowAdHandler")]
		public virtual void ShowAd()
		{
			MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.()V", this, null);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00018F04 File Offset: 0x00017104
		private static Delegate GetShowAd_Ljava_lang_String_Handler()
		{
			if (MaxRewardedAd.cb_showAd_Ljava_lang_String_ == null)
			{
				MaxRewardedAd.cb_showAd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxRewardedAd.n_ShowAd_Ljava_lang_String_));
			}
			return MaxRewardedAd.cb_showAd_Ljava_lang_String_;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00018F28 File Offset: 0x00017128
		private static void n_ShowAd_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ShowAd(@string);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00018F4C File Offset: 0x0001714C
		[Register("showAd", "(Ljava/lang/String;)V", "GetShowAd_Ljava_lang_String_Handler")]
		public unsafe virtual void ShowAd(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00018FA8 File Offset: 0x000171A8
		private static Delegate GetShowAd_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxRewardedAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxRewardedAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxRewardedAd.n_ShowAd_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxRewardedAd.cb_showAd_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00018FCC File Offset: 0x000171CC
		private static void n_ShowAd_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxRewardedAd @object = Java.Lang.Object.GetObject<MaxRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ShowAd(@string, string2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00018FF8 File Offset: 0x000171F8
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
				MaxRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("showAd.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00019074 File Offset: 0x00017274
		[Register("updateActivity", "(Landroid/app/Activity;)V", "")]
		public unsafe static void UpdateActivity(Activity p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MaxRewardedAd._members.StaticMethods.InvokeVoidMethod("updateActivity.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000975 RID: 2421 RVA: 0x000190D8 File Offset: 0x000172D8
		// (remove) Token: 0x06000976 RID: 2422 RVA: 0x00019124 File Offset: 0x00017324
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

		// Token: 0x06000977 RID: 2423 RVA: 0x00017B10 File Offset: 0x00015D10
		private IMaxAdReviewListenerImplementor __CreateIMaxAdReviewListenerImplementor()
		{
			return new IMaxAdReviewListenerImplementor(this);
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000978 RID: 2424 RVA: 0x00019174 File Offset: 0x00017374
		// (remove) Token: 0x06000979 RID: 2425 RVA: 0x000191C0 File Offset: 0x000173C0
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

		// Token: 0x0600097A RID: 2426 RVA: 0x00013E20 File Offset: 0x00012020
		private IMaxAdRevenueListenerImplementor __CreateIMaxAdRevenueListenerImplementor()
		{
			return new IMaxAdRevenueListenerImplementor(this);
		}

		// Token: 0x04000310 RID: 784
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/ads/MaxRewardedAd", typeof(MaxRewardedAd));

		// Token: 0x04000311 RID: 785
		private static Delegate cb_getActivity;

		// Token: 0x04000312 RID: 786
		private static Delegate cb_getAdUnitId;

		// Token: 0x04000313 RID: 787
		private static Delegate cb_isReady;

		// Token: 0x04000314 RID: 788
		private static Delegate cb_destroy;

		// Token: 0x04000315 RID: 789
		private static Delegate cb_loadAd;

		// Token: 0x04000316 RID: 790
		private static Delegate cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;

		// Token: 0x04000317 RID: 791
		private static Delegate cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000318 RID: 792
		private static Delegate cb_setListener_Lcom_applovin_mediation_MaxRewardedAdListener_;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x0400031A RID: 794
		private static Delegate cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;

		// Token: 0x0400031B RID: 795
		private static Delegate cb_showAd;

		// Token: 0x0400031C RID: 796
		private static Delegate cb_showAd_Ljava_lang_String_;

		// Token: 0x0400031D RID: 797
		private static Delegate cb_showAd_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400031E RID: 798
		private WeakReference weak_implementor_SetAdReviewListener;

		// Token: 0x0400031F RID: 799
		private WeakReference weak_implementor_SetRevenueListener;
	}
}
