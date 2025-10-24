using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x0200011D RID: 285
	[Register("com/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener", DoNotGenerateAcw = true)]
	internal class IMaxInterstitialAdapterListenerInvoker : Java.Lang.Object, IMaxInterstitialAdapterListener, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x000212D0 File Offset: 0x0001F4D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxInterstitialAdapterListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000212F4 File Offset: 0x0001F4F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxInterstitialAdapterListenerInvoker._members;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000212FB File Offset: 0x0001F4FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00021303 File Offset: 0x0001F503
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxInterstitialAdapterListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0002130F File Offset: 0x0001F50F
		public static IMaxInterstitialAdapterListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(handle, transfer);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00021318 File Offset: 0x0001F518
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxInterstitialAdapterListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxInterstitialAdapterListener'.");
			}
			return handle;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00021343 File Offset: 0x0001F543
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00021374 File Offset: 0x0001F574
		public IMaxInterstitialAdapterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxInterstitialAdapterListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000213AC File Offset: 0x0001F5AC
		private static Delegate GetOnInterstitialAdClickedHandler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdClicked == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdClicked));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdClicked;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000213D0 File Offset: 0x0001F5D0
		private static void n_OnInterstitialAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnInterstitialAdClicked();
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000213DF File Offset: 0x0001F5DF
		public void OnInterstitialAdClicked()
		{
			if (this.id_onInterstitialAdClicked == IntPtr.Zero)
			{
				this.id_onInterstitialAdClicked = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdClicked);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0002141F File Offset: 0x0001F61F
		private static Delegate GetOnInterstitialAdClicked_Landroid_os_Bundle_Handler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdClicked_Landroid_os_Bundle_ == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdClicked_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdClicked_Landroid_os_Bundle_));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdClicked_Landroid_os_Bundle_;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00021444 File Offset: 0x0001F644
		private static void n_OnInterstitialAdClicked_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInterstitialAdClicked(object2);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00021468 File Offset: 0x0001F668
		public unsafe void OnInterstitialAdClicked(Bundle p0)
		{
			if (this.id_onInterstitialAdClicked_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onInterstitialAdClicked_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdClicked", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdClicked_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000214DB File Offset: 0x0001F6DB
		private static Delegate GetOnInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00021500 File Offset: 0x0001F700
		private static void n_OnInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInterstitialAdDisplayFailed(object2);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00021524 File Offset: 0x0001F724
		public unsafe void OnInterstitialAdDisplayFailed(MaxAdapterError p0)
		{
			if (this.id_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00021597 File Offset: 0x0001F797
		private static Delegate GetOnInterstitialAdDisplayedHandler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayed == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdDisplayed));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayed;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000215BB File Offset: 0x0001F7BB
		private static void n_OnInterstitialAdDisplayed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnInterstitialAdDisplayed();
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000215CA File Offset: 0x0001F7CA
		public void OnInterstitialAdDisplayed()
		{
			if (this.id_onInterstitialAdDisplayed == IntPtr.Zero)
			{
				this.id_onInterstitialAdDisplayed = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdDisplayed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdDisplayed);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002160A File Offset: 0x0001F80A
		private static Delegate GetOnInterstitialAdDisplayed_Landroid_os_Bundle_Handler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayed_Landroid_os_Bundle_ == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayed_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdDisplayed_Landroid_os_Bundle_));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdDisplayed_Landroid_os_Bundle_;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00021630 File Offset: 0x0001F830
		private static void n_OnInterstitialAdDisplayed_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInterstitialAdDisplayed(object2);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00021654 File Offset: 0x0001F854
		public unsafe void OnInterstitialAdDisplayed(Bundle p0)
		{
			if (this.id_onInterstitialAdDisplayed_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onInterstitialAdDisplayed_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdDisplayed", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdDisplayed_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000216C7 File Offset: 0x0001F8C7
		private static Delegate GetOnInterstitialAdHiddenHandler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdHidden == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdHidden = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdHidden));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdHidden;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000216EB File Offset: 0x0001F8EB
		private static void n_OnInterstitialAdHidden(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnInterstitialAdHidden();
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000216FA File Offset: 0x0001F8FA
		public void OnInterstitialAdHidden()
		{
			if (this.id_onInterstitialAdHidden == IntPtr.Zero)
			{
				this.id_onInterstitialAdHidden = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdHidden", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdHidden);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0002173A File Offset: 0x0001F93A
		private static Delegate GetOnInterstitialAdHidden_Landroid_os_Bundle_Handler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdHidden_Landroid_os_Bundle_ == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdHidden_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdHidden_Landroid_os_Bundle_));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdHidden_Landroid_os_Bundle_;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00021760 File Offset: 0x0001F960
		private static void n_OnInterstitialAdHidden_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInterstitialAdHidden(object2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00021784 File Offset: 0x0001F984
		public unsafe void OnInterstitialAdHidden(Bundle p0)
		{
			if (this.id_onInterstitialAdHidden_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onInterstitialAdHidden_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdHidden", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdHidden_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000217F7 File Offset: 0x0001F9F7
		private static Delegate GetOnInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0002181C File Offset: 0x0001FA1C
		private static void n_OnInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInterstitialAdLoadFailed(object2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00021840 File Offset: 0x0001FA40
		public unsafe void OnInterstitialAdLoadFailed(MaxAdapterError p0)
		{
			if (this.id_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000218B3 File Offset: 0x0001FAB3
		private static Delegate GetOnInterstitialAdLoadedHandler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoaded == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdLoaded));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoaded;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000218D7 File Offset: 0x0001FAD7
		private static void n_OnInterstitialAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnInterstitialAdLoaded();
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000218E6 File Offset: 0x0001FAE6
		public void OnInterstitialAdLoaded()
		{
			if (this.id_onInterstitialAdLoaded == IntPtr.Zero)
			{
				this.id_onInterstitialAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdLoaded);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00021926 File Offset: 0x0001FB26
		private static Delegate GetOnInterstitialAdLoaded_Landroid_os_Bundle_Handler()
		{
			if (IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoaded_Landroid_os_Bundle_ == null)
			{
				IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoaded_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxInterstitialAdapterListenerInvoker.n_OnInterstitialAdLoaded_Landroid_os_Bundle_));
			}
			return IMaxInterstitialAdapterListenerInvoker.cb_onInterstitialAdLoaded_Landroid_os_Bundle_;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0002194C File Offset: 0x0001FB4C
		private static void n_OnInterstitialAdLoaded_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxInterstitialAdapterListener @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInterstitialAdLoaded(object2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00021970 File Offset: 0x0001FB70
		public unsafe void OnInterstitialAdLoaded(Bundle p0)
		{
			if (this.id_onInterstitialAdLoaded_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onInterstitialAdLoaded_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onInterstitialAdLoaded", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInterstitialAdLoaded_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x04000435 RID: 1077
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener", typeof(IMaxInterstitialAdapterListenerInvoker));

		// Token: 0x04000436 RID: 1078
		private IntPtr class_ref;

		// Token: 0x04000437 RID: 1079
		private static Delegate cb_onInterstitialAdClicked;

		// Token: 0x04000438 RID: 1080
		private IntPtr id_onInterstitialAdClicked;

		// Token: 0x04000439 RID: 1081
		private static Delegate cb_onInterstitialAdClicked_Landroid_os_Bundle_;

		// Token: 0x0400043A RID: 1082
		private IntPtr id_onInterstitialAdClicked_Landroid_os_Bundle_;

		// Token: 0x0400043B RID: 1083
		private static Delegate cb_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x0400043C RID: 1084
		private IntPtr id_onInterstitialAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x0400043D RID: 1085
		private static Delegate cb_onInterstitialAdDisplayed;

		// Token: 0x0400043E RID: 1086
		private IntPtr id_onInterstitialAdDisplayed;

		// Token: 0x0400043F RID: 1087
		private static Delegate cb_onInterstitialAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000440 RID: 1088
		private IntPtr id_onInterstitialAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000441 RID: 1089
		private static Delegate cb_onInterstitialAdHidden;

		// Token: 0x04000442 RID: 1090
		private IntPtr id_onInterstitialAdHidden;

		// Token: 0x04000443 RID: 1091
		private static Delegate cb_onInterstitialAdHidden_Landroid_os_Bundle_;

		// Token: 0x04000444 RID: 1092
		private IntPtr id_onInterstitialAdHidden_Landroid_os_Bundle_;

		// Token: 0x04000445 RID: 1093
		private static Delegate cb_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000446 RID: 1094
		private IntPtr id_onInterstitialAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000447 RID: 1095
		private static Delegate cb_onInterstitialAdLoaded;

		// Token: 0x04000448 RID: 1096
		private IntPtr id_onInterstitialAdLoaded;

		// Token: 0x04000449 RID: 1097
		private static Delegate cb_onInterstitialAdLoaded_Landroid_os_Bundle_;

		// Token: 0x0400044A RID: 1098
		private IntPtr id_onInterstitialAdLoaded_Landroid_os_Bundle_;
	}
}
