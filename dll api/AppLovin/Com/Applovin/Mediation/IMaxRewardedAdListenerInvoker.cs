using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C7 RID: 199
	[Register("com/applovin/mediation/MaxRewardedAdListener", DoNotGenerateAcw = true)]
	internal class IMaxRewardedAdListenerInvoker : Java.Lang.Object, IMaxRewardedAdListener, IMaxAdListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00011138 File Offset: 0x0000F338
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardedAdListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001115C File Offset: 0x0000F35C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardedAdListenerInvoker._members;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00011163 File Offset: 0x0000F363
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0001116B File Offset: 0x0000F36B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardedAdListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00011177 File Offset: 0x0000F377
		public static IMaxRewardedAdListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxRewardedAdListener>(handle, transfer);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00011180 File Offset: 0x0000F380
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardedAdListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxRewardedAdListener'.");
			}
			return handle;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000111AB File Offset: 0x0000F3AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000111DC File Offset: 0x0000F3DC
		public IMaxRewardedAdListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardedAdListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00011214 File Offset: 0x0000F414
		private static Delegate GetOnRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdListenerInvoker.n_OnRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00011238 File Offset: 0x0000F438
		private static void n_OnRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedVideoCompleted(object2);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001125C File Offset: 0x0000F45C
		public unsafe void OnRewardedVideoCompleted(IMaxAd p0)
		{
			if (this.id_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedVideoCompleted", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000112D4 File Offset: 0x0000F4D4
		private static Delegate GetOnRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdListenerInvoker.n_OnRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000112F8 File Offset: 0x0000F4F8
		private static void n_OnRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedVideoStarted(object2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001131C File Offset: 0x0000F51C
		public unsafe void OnRewardedVideoStarted(IMaxAd p0)
		{
			if (this.id_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedVideoStarted", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00011394 File Offset: 0x0000F594
		private static Delegate GetOnUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxRewardedAdListenerInvoker.n_OnUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000113B8 File Offset: 0x0000F5B8
		private static void n_OnUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxRewardedAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxReward object3 = Java.Lang.Object.GetObject<IMaxReward>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnUserRewarded(object2, object3);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000113E4 File Offset: 0x0000F5E4
		public unsafe void OnUserRewarded(IMaxAd p0, IMaxReward p1)
		{
			if (this.id_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_ == IntPtr.Zero)
			{
				this.id_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_ = JNIEnv.GetMethodID(this.class_ref, "onUserRewarded", "(Lcom/applovin/mediation/MaxAd;Lcom/applovin/mediation/MaxReward;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_, ptr);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00011483 File Offset: 0x0000F683
		private static Delegate GetOnAdClicked_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdListenerInvoker.n_OnAdClicked_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000114A8 File Offset: 0x0000F6A8
		private static void n_OnAdClicked_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdClicked(object2);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000114CC File Offset: 0x0000F6CC
		public unsafe void OnAdClicked(IMaxAd p0)
		{
			if (this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdClicked", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00011544 File Offset: 0x0000F744
		private static Delegate GetOnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxRewardedAdListenerInvoker.n_OnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00011568 File Offset: 0x0000F768
		private static void n_OnAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object3 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayFailed(object2, object3);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00011594 File Offset: 0x0000F794
		public unsafe void OnAdDisplayFailed(IMaxAd p0, IMaxError p1)
		{
			if (this.id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ == IntPtr.Zero)
			{
				this.id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_ = JNIEnv.GetMethodID(this.class_ref, "onAdDisplayFailed", "(Lcom/applovin/mediation/MaxAd;Lcom/applovin/mediation/MaxError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_, ptr);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00011633 File Offset: 0x0000F833
		private static Delegate GetOnAdDisplayed_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdListenerInvoker.n_OnAdDisplayed_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00011658 File Offset: 0x0000F858
		private static void n_OnAdDisplayed_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdDisplayed(object2);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001167C File Offset: 0x0000F87C
		public unsafe void OnAdDisplayed(IMaxAd p0)
		{
			if (this.id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdDisplayed", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000116F4 File Offset: 0x0000F8F4
		private static Delegate GetOnAdHidden_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdListenerInvoker.n_OnAdHidden_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onAdHidden_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00011718 File Offset: 0x0000F918
		private static void n_OnAdHidden_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdHidden(object2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001173C File Offset: 0x0000F93C
		public unsafe void OnAdHidden(IMaxAd p0)
		{
			if (this.id_onAdHidden_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdHidden_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdHidden", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdHidden_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000117B4 File Offset: 0x0000F9B4
		private static Delegate GetOnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxRewardedAdListenerInvoker.n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000117D8 File Offset: 0x0000F9D8
		private static void n_OnAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object2 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoadFailed(@string, object2);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00011804 File Offset: 0x0000FA04
		public unsafe void OnAdLoadFailed(string p0, IMaxError p1)
		{
			if (this.id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == IntPtr.Zero)
			{
				this.id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNIEnv.GetMethodID(this.class_ref, "onAdLoadFailed", "(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001189C File Offset: 0x0000FA9C
		private static Delegate GetOnAdLoaded_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxRewardedAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxRewardedAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdListenerInvoker.n_OnAdLoaded_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxRewardedAdListenerInvoker.cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000118C0 File Offset: 0x0000FAC0
		private static void n_OnAdLoaded_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdLoaded(object2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000118E4 File Offset: 0x0000FAE4
		public unsafe void OnAdLoaded(IMaxAd p0)
		{
			if (this.id_onAdLoaded_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdLoaded_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x04000243 RID: 579
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxRewardedAdListener", typeof(IMaxRewardedAdListenerInvoker));

		// Token: 0x04000244 RID: 580
		private IntPtr class_ref;

		// Token: 0x04000245 RID: 581
		private static Delegate cb_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000246 RID: 582
		private IntPtr id_onRewardedVideoCompleted_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000247 RID: 583
		private static Delegate cb_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000248 RID: 584
		private IntPtr id_onRewardedVideoStarted_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000249 RID: 585
		private static Delegate cb_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_;

		// Token: 0x0400024A RID: 586
		private IntPtr id_onUserRewarded_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxReward_;

		// Token: 0x0400024B RID: 587
		private static Delegate cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x0400024C RID: 588
		private IntPtr id_onAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x0400024D RID: 589
		private static Delegate cb_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;

		// Token: 0x0400024E RID: 590
		private IntPtr id_onAdDisplayFailed_Lcom_applovin_mediation_MaxAd_Lcom_applovin_mediation_MaxError_;

		// Token: 0x0400024F RID: 591
		private static Delegate cb_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000250 RID: 592
		private IntPtr id_onAdDisplayed_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000251 RID: 593
		private static Delegate cb_onAdHidden_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000252 RID: 594
		private IntPtr id_onAdHidden_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000253 RID: 595
		private static Delegate cb_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x04000254 RID: 596
		private IntPtr id_onAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x04000255 RID: 597
		private static Delegate cb_onAdLoaded_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000256 RID: 598
		private IntPtr id_onAdLoaded_Lcom_applovin_mediation_MaxAd_;
	}
}
