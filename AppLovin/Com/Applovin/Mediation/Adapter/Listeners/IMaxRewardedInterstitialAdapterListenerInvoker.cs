using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000123 RID: 291
	[Register("com/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener", DoNotGenerateAcw = true)]
	internal class IMaxRewardedInterstitialAdapterListenerInvoker : Java.Lang.Object, IMaxRewardedInterstitialAdapterListener, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000226A0 File Offset: 0x000208A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardedInterstitialAdapterListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x000226C4 File Offset: 0x000208C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardedInterstitialAdapterListenerInvoker._members;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000226CB File Offset: 0x000208CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000226D3 File Offset: 0x000208D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardedInterstitialAdapterListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000226DF File Offset: 0x000208DF
		public static IMaxRewardedInterstitialAdapterListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(handle, transfer);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000226E8 File Offset: 0x000208E8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardedInterstitialAdapterListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxRewardedInterstitialAdapterListener'.");
			}
			return handle;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00022713 File Offset: 0x00020913
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00022744 File Offset: 0x00020944
		public IMaxRewardedInterstitialAdapterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardedInterstitialAdapterListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0002277C File Offset: 0x0002097C
		private static Delegate GetOnRewardedInterstitialAdClickedHandler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdClicked == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdClicked));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdClicked;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000227A0 File Offset: 0x000209A0
		private static void n_OnRewardedInterstitialAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedInterstitialAdClicked();
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000227AF File Offset: 0x000209AF
		public void OnRewardedInterstitialAdClicked()
		{
			if (this.id_onRewardedInterstitialAdClicked == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdClicked = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdClicked);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000227EF File Offset: 0x000209EF
		private static Delegate GetOnRewardedInterstitialAdClicked_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdClicked_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdClicked_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdClicked_Landroid_os_Bundle_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdClicked_Landroid_os_Bundle_;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00022814 File Offset: 0x00020A14
		private static void n_OnRewardedInterstitialAdClicked_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedInterstitialAdClicked(object2);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00022838 File Offset: 0x00020A38
		public unsafe void OnRewardedInterstitialAdClicked(Bundle p0)
		{
			if (this.id_onRewardedInterstitialAdClicked_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdClicked_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdClicked", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdClicked_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000228AB File Offset: 0x00020AAB
		private static Delegate GetOnRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000228D0 File Offset: 0x00020AD0
		private static void n_OnRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedInterstitialAdDisplayFailed(object2);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000228F4 File Offset: 0x00020AF4
		public unsafe void OnRewardedInterstitialAdDisplayFailed(MaxAdapterError p0)
		{
			if (this.id_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00022967 File Offset: 0x00020B67
		private static Delegate GetOnRewardedInterstitialAdDisplayedHandler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayed == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdDisplayed));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayed;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0002298B File Offset: 0x00020B8B
		private static void n_OnRewardedInterstitialAdDisplayed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedInterstitialAdDisplayed();
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0002299A File Offset: 0x00020B9A
		public void OnRewardedInterstitialAdDisplayed()
		{
			if (this.id_onRewardedInterstitialAdDisplayed == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdDisplayed = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdDisplayed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdDisplayed);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000229DA File Offset: 0x00020BDA
		private static Delegate GetOnRewardedInterstitialAdDisplayed_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdDisplayed_Landroid_os_Bundle_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00022A00 File Offset: 0x00020C00
		private static void n_OnRewardedInterstitialAdDisplayed_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedInterstitialAdDisplayed(object2);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00022A24 File Offset: 0x00020C24
		public unsafe void OnRewardedInterstitialAdDisplayed(Bundle p0)
		{
			if (this.id_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdDisplayed", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00022A97 File Offset: 0x00020C97
		private static Delegate GetOnRewardedInterstitialAdHiddenHandler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdHidden == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdHidden = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdHidden));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdHidden;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00022ABB File Offset: 0x00020CBB
		private static void n_OnRewardedInterstitialAdHidden(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedInterstitialAdHidden();
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00022ACA File Offset: 0x00020CCA
		public void OnRewardedInterstitialAdHidden()
		{
			if (this.id_onRewardedInterstitialAdHidden == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdHidden = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdHidden", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdHidden);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00022B0A File Offset: 0x00020D0A
		private static Delegate GetOnRewardedInterstitialAdHidden_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdHidden_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdHidden_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdHidden_Landroid_os_Bundle_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdHidden_Landroid_os_Bundle_;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00022B30 File Offset: 0x00020D30
		private static void n_OnRewardedInterstitialAdHidden_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedInterstitialAdHidden(object2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00022B54 File Offset: 0x00020D54
		public unsafe void OnRewardedInterstitialAdHidden(Bundle p0)
		{
			if (this.id_onRewardedInterstitialAdHidden_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdHidden_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdHidden", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdHidden_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00022BC7 File Offset: 0x00020DC7
		private static Delegate GetOnRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00022BEC File Offset: 0x00020DEC
		private static void n_OnRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedInterstitialAdLoadFailed(object2);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00022C10 File Offset: 0x00020E10
		public unsafe void OnRewardedInterstitialAdLoadFailed(MaxAdapterError p0)
		{
			if (this.id_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00022C83 File Offset: 0x00020E83
		private static Delegate GetOnRewardedInterstitialAdLoadedHandler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoaded == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdLoaded));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoaded;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00022CA7 File Offset: 0x00020EA7
		private static void n_OnRewardedInterstitialAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedInterstitialAdLoaded();
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00022CB6 File Offset: 0x00020EB6
		public void OnRewardedInterstitialAdLoaded()
		{
			if (this.id_onRewardedInterstitialAdLoaded == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdLoaded);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00022CF6 File Offset: 0x00020EF6
		private static Delegate GetOnRewardedInterstitialAdLoaded_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdLoaded_Landroid_os_Bundle_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00022D1C File Offset: 0x00020F1C
		private static void n_OnRewardedInterstitialAdLoaded_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedInterstitialAdLoaded(object2);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00022D40 File Offset: 0x00020F40
		public unsafe void OnRewardedInterstitialAdLoaded(Bundle p0)
		{
			if (this.id_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdLoaded", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00022DB3 File Offset: 0x00020FB3
		private static Delegate GetOnRewardedInterstitialAdVideoCompletedHandler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdVideoCompleted == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdVideoCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdVideoCompleted));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdVideoCompleted;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00022DD7 File Offset: 0x00020FD7
		private static void n_OnRewardedInterstitialAdVideoCompleted(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedInterstitialAdVideoCompleted();
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00022DE6 File Offset: 0x00020FE6
		public void OnRewardedInterstitialAdVideoCompleted()
		{
			if (this.id_onRewardedInterstitialAdVideoCompleted == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdVideoCompleted = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdVideoCompleted", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdVideoCompleted);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00022E26 File Offset: 0x00021026
		private static Delegate GetOnRewardedInterstitialAdVideoStartedHandler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdVideoStarted == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdVideoStarted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnRewardedInterstitialAdVideoStarted));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onRewardedInterstitialAdVideoStarted;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00022E4A File Offset: 0x0002104A
		private static void n_OnRewardedInterstitialAdVideoStarted(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedInterstitialAdVideoStarted();
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00022E59 File Offset: 0x00021059
		public void OnRewardedInterstitialAdVideoStarted()
		{
			if (this.id_onRewardedInterstitialAdVideoStarted == IntPtr.Zero)
			{
				this.id_onRewardedInterstitialAdVideoStarted = JNIEnv.GetMethodID(this.class_ref, "onRewardedInterstitialAdVideoStarted", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedInterstitialAdVideoStarted);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00022E99 File Offset: 0x00021099
		private static Delegate GetOnUserRewarded_Lcom_applovin_mediation_MaxReward_Handler()
		{
			if (IMaxRewardedInterstitialAdapterListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_ == null)
			{
				IMaxRewardedInterstitialAdapterListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedInterstitialAdapterListenerInvoker.n_OnUserRewarded_Lcom_applovin_mediation_MaxReward_));
			}
			return IMaxRewardedInterstitialAdapterListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00022EC0 File Offset: 0x000210C0
		private static void n_OnUserRewarded_Lcom_applovin_mediation_MaxReward_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxReward object2 = Java.Lang.Object.GetObject<IMaxReward>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUserRewarded(object2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00022EE4 File Offset: 0x000210E4
		public unsafe void OnUserRewarded(IMaxReward p0)
		{
			if (this.id_onUserRewarded_Lcom_applovin_mediation_MaxReward_ == IntPtr.Zero)
			{
				this.id_onUserRewarded_Lcom_applovin_mediation_MaxReward_ = JNIEnv.GetMethodID(this.class_ref, "onUserRewarded", "(Lcom/applovin/mediation/MaxReward;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUserRewarded_Lcom_applovin_mediation_MaxReward_, ptr);
		}

		// Token: 0x04000471 RID: 1137
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener", typeof(IMaxRewardedInterstitialAdapterListenerInvoker));

		// Token: 0x04000472 RID: 1138
		private IntPtr class_ref;

		// Token: 0x04000473 RID: 1139
		private static Delegate cb_onRewardedInterstitialAdClicked;

		// Token: 0x04000474 RID: 1140
		private IntPtr id_onRewardedInterstitialAdClicked;

		// Token: 0x04000475 RID: 1141
		private static Delegate cb_onRewardedInterstitialAdClicked_Landroid_os_Bundle_;

		// Token: 0x04000476 RID: 1142
		private IntPtr id_onRewardedInterstitialAdClicked_Landroid_os_Bundle_;

		// Token: 0x04000477 RID: 1143
		private static Delegate cb_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000478 RID: 1144
		private IntPtr id_onRewardedInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000479 RID: 1145
		private static Delegate cb_onRewardedInterstitialAdDisplayed;

		// Token: 0x0400047A RID: 1146
		private IntPtr id_onRewardedInterstitialAdDisplayed;

		// Token: 0x0400047B RID: 1147
		private static Delegate cb_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x0400047C RID: 1148
		private IntPtr id_onRewardedInterstitialAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x0400047D RID: 1149
		private static Delegate cb_onRewardedInterstitialAdHidden;

		// Token: 0x0400047E RID: 1150
		private IntPtr id_onRewardedInterstitialAdHidden;

		// Token: 0x0400047F RID: 1151
		private static Delegate cb_onRewardedInterstitialAdHidden_Landroid_os_Bundle_;

		// Token: 0x04000480 RID: 1152
		private IntPtr id_onRewardedInterstitialAdHidden_Landroid_os_Bundle_;

		// Token: 0x04000481 RID: 1153
		private static Delegate cb_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000482 RID: 1154
		private IntPtr id_onRewardedInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000483 RID: 1155
		private static Delegate cb_onRewardedInterstitialAdLoaded;

		// Token: 0x04000484 RID: 1156
		private IntPtr id_onRewardedInterstitialAdLoaded;

		// Token: 0x04000485 RID: 1157
		private static Delegate cb_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_;

		// Token: 0x04000486 RID: 1158
		private IntPtr id_onRewardedInterstitialAdLoaded_Landroid_os_Bundle_;

		// Token: 0x04000487 RID: 1159
		private static Delegate cb_onRewardedInterstitialAdVideoCompleted;

		// Token: 0x04000488 RID: 1160
		private IntPtr id_onRewardedInterstitialAdVideoCompleted;

		// Token: 0x04000489 RID: 1161
		private static Delegate cb_onRewardedInterstitialAdVideoStarted;

		// Token: 0x0400048A RID: 1162
		private IntPtr id_onRewardedInterstitialAdVideoStarted;

		// Token: 0x0400048B RID: 1163
		private static Delegate cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_;

		// Token: 0x0400048C RID: 1164
		private IntPtr id_onUserRewarded_Lcom_applovin_mediation_MaxReward_;
	}
}
