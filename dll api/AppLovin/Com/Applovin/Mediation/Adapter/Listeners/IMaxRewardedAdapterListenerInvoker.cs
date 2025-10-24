using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000121 RID: 289
	[Register("com/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener", DoNotGenerateAcw = true)]
	internal class IMaxRewardedAdapterListenerInvoker : Java.Lang.Object, IMaxRewardedAdapterListener, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardedAdapterListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00021DEC File Offset: 0x0001FFEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardedAdapterListenerInvoker._members;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00021DF3 File Offset: 0x0001FFF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00021DFB File Offset: 0x0001FFFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardedAdapterListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00021E07 File Offset: 0x00020007
		public static IMaxRewardedAdapterListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(handle, transfer);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00021E10 File Offset: 0x00020010
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardedAdapterListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxRewardedAdapterListener'.");
			}
			return handle;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00021E3B File Offset: 0x0002003B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00021E6C File Offset: 0x0002006C
		public IMaxRewardedAdapterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardedAdapterListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00021EA4 File Offset: 0x000200A4
		private static Delegate GetOnRewardedAdClickedHandler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdClicked == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdClicked));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdClicked;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00021EC8 File Offset: 0x000200C8
		private static void n_OnRewardedAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedAdClicked();
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00021ED7 File Offset: 0x000200D7
		public void OnRewardedAdClicked()
		{
			if (this.id_onRewardedAdClicked == IntPtr.Zero)
			{
				this.id_onRewardedAdClicked = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdClicked);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00021F17 File Offset: 0x00020117
		private static Delegate GetOnRewardedAdClicked_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdClicked_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdClicked_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdClicked_Landroid_os_Bundle_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdClicked_Landroid_os_Bundle_;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00021F3C File Offset: 0x0002013C
		private static void n_OnRewardedAdClicked_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdClicked(object2);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00021F60 File Offset: 0x00020160
		public unsafe void OnRewardedAdClicked(Bundle p0)
		{
			if (this.id_onRewardedAdClicked_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedAdClicked_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdClicked", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdClicked_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00021FD3 File Offset: 0x000201D3
		private static Delegate GetOnRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00021FF8 File Offset: 0x000201F8
		private static void n_OnRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdDisplayFailed(object2);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0002201C File Offset: 0x0002021C
		public unsafe void OnRewardedAdDisplayFailed(MaxAdapterError p0)
		{
			if (this.id_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0002208F File Offset: 0x0002028F
		private static Delegate GetOnRewardedAdDisplayedHandler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayed == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdDisplayed));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayed;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000220B3 File Offset: 0x000202B3
		private static void n_OnRewardedAdDisplayed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedAdDisplayed();
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000220C2 File Offset: 0x000202C2
		public void OnRewardedAdDisplayed()
		{
			if (this.id_onRewardedAdDisplayed == IntPtr.Zero)
			{
				this.id_onRewardedAdDisplayed = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdDisplayed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdDisplayed);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00022102 File Offset: 0x00020302
		private static Delegate GetOnRewardedAdDisplayed_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayed_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayed_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdDisplayed_Landroid_os_Bundle_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdDisplayed_Landroid_os_Bundle_;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00022128 File Offset: 0x00020328
		private static void n_OnRewardedAdDisplayed_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdDisplayed(object2);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0002214C File Offset: 0x0002034C
		public unsafe void OnRewardedAdDisplayed(Bundle p0)
		{
			if (this.id_onRewardedAdDisplayed_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedAdDisplayed_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdDisplayed", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdDisplayed_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000221BF File Offset: 0x000203BF
		private static Delegate GetOnRewardedAdHiddenHandler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdHidden == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdHidden = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdHidden));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdHidden;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000221E3 File Offset: 0x000203E3
		private static void n_OnRewardedAdHidden(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedAdHidden();
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000221F2 File Offset: 0x000203F2
		public void OnRewardedAdHidden()
		{
			if (this.id_onRewardedAdHidden == IntPtr.Zero)
			{
				this.id_onRewardedAdHidden = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdHidden", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdHidden);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00022232 File Offset: 0x00020432
		private static Delegate GetOnRewardedAdHidden_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdHidden_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdHidden_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdHidden_Landroid_os_Bundle_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdHidden_Landroid_os_Bundle_;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00022258 File Offset: 0x00020458
		private static void n_OnRewardedAdHidden_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdHidden(object2);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0002227C File Offset: 0x0002047C
		public unsafe void OnRewardedAdHidden(Bundle p0)
		{
			if (this.id_onRewardedAdHidden_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedAdHidden_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdHidden", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdHidden_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000222EF File Offset: 0x000204EF
		private static Delegate GetOnRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00022314 File Offset: 0x00020514
		private static void n_OnRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdLoadFailed(object2);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00022338 File Offset: 0x00020538
		public unsafe void OnRewardedAdLoadFailed(MaxAdapterError p0)
		{
			if (this.id_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000223AB File Offset: 0x000205AB
		private static Delegate GetOnRewardedAdLoadedHandler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoaded == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdLoaded));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoaded;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x000223CF File Offset: 0x000205CF
		private static void n_OnRewardedAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedAdLoaded();
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000223DE File Offset: 0x000205DE
		public void OnRewardedAdLoaded()
		{
			if (this.id_onRewardedAdLoaded == IntPtr.Zero)
			{
				this.id_onRewardedAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdLoaded);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0002241E File Offset: 0x0002061E
		private static Delegate GetOnRewardedAdLoaded_Landroid_os_Bundle_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoaded_Landroid_os_Bundle_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoaded_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdLoaded_Landroid_os_Bundle_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdLoaded_Landroid_os_Bundle_;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00022444 File Offset: 0x00020644
		private static void n_OnRewardedAdLoaded_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRewardedAdLoaded(object2);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00022468 File Offset: 0x00020668
		public unsafe void OnRewardedAdLoaded(Bundle p0)
		{
			if (this.id_onRewardedAdLoaded_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onRewardedAdLoaded_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdLoaded", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdLoaded_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000224DB File Offset: 0x000206DB
		private static Delegate GetOnRewardedAdVideoCompletedHandler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdVideoCompleted == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdVideoCompleted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdVideoCompleted));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdVideoCompleted;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000224FF File Offset: 0x000206FF
		private static void n_OnRewardedAdVideoCompleted(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedAdVideoCompleted();
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0002250E File Offset: 0x0002070E
		public void OnRewardedAdVideoCompleted()
		{
			if (this.id_onRewardedAdVideoCompleted == IntPtr.Zero)
			{
				this.id_onRewardedAdVideoCompleted = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdVideoCompleted", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdVideoCompleted);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0002254E File Offset: 0x0002074E
		private static Delegate GetOnRewardedAdVideoStartedHandler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdVideoStarted == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdVideoStarted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxRewardedAdapterListenerInvoker.n_OnRewardedAdVideoStarted));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onRewardedAdVideoStarted;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00022572 File Offset: 0x00020772
		private static void n_OnRewardedAdVideoStarted(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRewardedAdVideoStarted();
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00022581 File Offset: 0x00020781
		public void OnRewardedAdVideoStarted()
		{
			if (this.id_onRewardedAdVideoStarted == IntPtr.Zero)
			{
				this.id_onRewardedAdVideoStarted = JNIEnv.GetMethodID(this.class_ref, "onRewardedAdVideoStarted", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRewardedAdVideoStarted);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000225C1 File Offset: 0x000207C1
		private static Delegate GetOnUserRewarded_Lcom_applovin_mediation_MaxReward_Handler()
		{
			if (IMaxRewardedAdapterListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_ == null)
			{
				IMaxRewardedAdapterListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxRewardedAdapterListenerInvoker.n_OnUserRewarded_Lcom_applovin_mediation_MaxReward_));
			}
			return IMaxRewardedAdapterListenerInvoker.cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000225E8 File Offset: 0x000207E8
		private static void n_OnUserRewarded_Lcom_applovin_mediation_MaxReward_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxRewardedAdapterListener @object = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxReward object2 = Java.Lang.Object.GetObject<IMaxReward>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUserRewarded(object2);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0002260C File Offset: 0x0002080C
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

		// Token: 0x04000455 RID: 1109
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener", typeof(IMaxRewardedAdapterListenerInvoker));

		// Token: 0x04000456 RID: 1110
		private IntPtr class_ref;

		// Token: 0x04000457 RID: 1111
		private static Delegate cb_onRewardedAdClicked;

		// Token: 0x04000458 RID: 1112
		private IntPtr id_onRewardedAdClicked;

		// Token: 0x04000459 RID: 1113
		private static Delegate cb_onRewardedAdClicked_Landroid_os_Bundle_;

		// Token: 0x0400045A RID: 1114
		private IntPtr id_onRewardedAdClicked_Landroid_os_Bundle_;

		// Token: 0x0400045B RID: 1115
		private static Delegate cb_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x0400045C RID: 1116
		private IntPtr id_onRewardedAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x0400045D RID: 1117
		private static Delegate cb_onRewardedAdDisplayed;

		// Token: 0x0400045E RID: 1118
		private IntPtr id_onRewardedAdDisplayed;

		// Token: 0x0400045F RID: 1119
		private static Delegate cb_onRewardedAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000460 RID: 1120
		private IntPtr id_onRewardedAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000461 RID: 1121
		private static Delegate cb_onRewardedAdHidden;

		// Token: 0x04000462 RID: 1122
		private IntPtr id_onRewardedAdHidden;

		// Token: 0x04000463 RID: 1123
		private static Delegate cb_onRewardedAdHidden_Landroid_os_Bundle_;

		// Token: 0x04000464 RID: 1124
		private IntPtr id_onRewardedAdHidden_Landroid_os_Bundle_;

		// Token: 0x04000465 RID: 1125
		private static Delegate cb_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000466 RID: 1126
		private IntPtr id_onRewardedAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000467 RID: 1127
		private static Delegate cb_onRewardedAdLoaded;

		// Token: 0x04000468 RID: 1128
		private IntPtr id_onRewardedAdLoaded;

		// Token: 0x04000469 RID: 1129
		private static Delegate cb_onRewardedAdLoaded_Landroid_os_Bundle_;

		// Token: 0x0400046A RID: 1130
		private IntPtr id_onRewardedAdLoaded_Landroid_os_Bundle_;

		// Token: 0x0400046B RID: 1131
		private static Delegate cb_onRewardedAdVideoCompleted;

		// Token: 0x0400046C RID: 1132
		private IntPtr id_onRewardedAdVideoCompleted;

		// Token: 0x0400046D RID: 1133
		private static Delegate cb_onRewardedAdVideoStarted;

		// Token: 0x0400046E RID: 1134
		private IntPtr id_onRewardedAdVideoStarted;

		// Token: 0x0400046F RID: 1135
		private static Delegate cb_onUserRewarded_Lcom_applovin_mediation_MaxReward_;

		// Token: 0x04000470 RID: 1136
		private IntPtr id_onUserRewarded_Lcom_applovin_mediation_MaxReward_;
	}
}
