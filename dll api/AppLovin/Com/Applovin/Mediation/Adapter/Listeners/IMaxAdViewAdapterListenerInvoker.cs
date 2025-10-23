using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x0200011B RID: 283
	[Register("com/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener", DoNotGenerateAcw = true)]
	internal class IMaxAdViewAdapterListenerInvoker : Java.Lang.Object, IMaxAdViewAdapterListener, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00020A48 File Offset: 0x0001EC48
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdViewAdapterListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00020A6C File Offset: 0x0001EC6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdViewAdapterListenerInvoker._members;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00020A73 File Offset: 0x0001EC73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00020A7B File Offset: 0x0001EC7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdViewAdapterListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00020A87 File Offset: 0x0001EC87
		public static IMaxAdViewAdapterListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(handle, transfer);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00020A90 File Offset: 0x0001EC90
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdViewAdapterListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxAdViewAdapterListener'.");
			}
			return handle;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00020ABB File Offset: 0x0001ECBB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00020AEC File Offset: 0x0001ECEC
		public IMaxAdViewAdapterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdViewAdapterListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00020B24 File Offset: 0x0001ED24
		private static Delegate GetOnAdViewAdClickedHandler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdClicked == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdClicked));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdClicked;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00020B48 File Offset: 0x0001ED48
		private static void n_OnAdViewAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdViewAdClicked();
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00020B57 File Offset: 0x0001ED57
		public void OnAdViewAdClicked()
		{
			if (this.id_onAdViewAdClicked == IntPtr.Zero)
			{
				this.id_onAdViewAdClicked = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdClicked);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00020B97 File Offset: 0x0001ED97
		private static Delegate GetOnAdViewAdClicked_Landroid_os_Bundle_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdClicked_Landroid_os_Bundle_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdClicked_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdClicked_Landroid_os_Bundle_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdClicked_Landroid_os_Bundle_;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00020BBC File Offset: 0x0001EDBC
		private static void n_OnAdViewAdClicked_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdClicked(object2);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		public unsafe void OnAdViewAdClicked(Bundle p0)
		{
			if (this.id_onAdViewAdClicked_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onAdViewAdClicked_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdClicked", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdClicked_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00020C53 File Offset: 0x0001EE53
		private static Delegate GetOnAdViewAdCollapsedHandler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdCollapsed == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdCollapsed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdCollapsed));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdCollapsed;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00020C77 File Offset: 0x0001EE77
		private static void n_OnAdViewAdCollapsed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdViewAdCollapsed();
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00020C86 File Offset: 0x0001EE86
		public void OnAdViewAdCollapsed()
		{
			if (this.id_onAdViewAdCollapsed == IntPtr.Zero)
			{
				this.id_onAdViewAdCollapsed = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdCollapsed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdCollapsed);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00020CC6 File Offset: 0x0001EEC6
		private static Delegate GetOnAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00020CEC File Offset: 0x0001EEEC
		private static void n_OnAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdDisplayFailed(object2);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00020D10 File Offset: 0x0001EF10
		public unsafe void OnAdViewAdDisplayFailed(MaxAdapterError p0)
		{
			if (this.id_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdDisplayFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00020D83 File Offset: 0x0001EF83
		private static Delegate GetOnAdViewAdDisplayedHandler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayed == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdDisplayed));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayed;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00020DA7 File Offset: 0x0001EFA7
		private static void n_OnAdViewAdDisplayed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdViewAdDisplayed();
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00020DB6 File Offset: 0x0001EFB6
		public void OnAdViewAdDisplayed()
		{
			if (this.id_onAdViewAdDisplayed == IntPtr.Zero)
			{
				this.id_onAdViewAdDisplayed = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdDisplayed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdDisplayed);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00020DF6 File Offset: 0x0001EFF6
		private static Delegate GetOnAdViewAdDisplayed_Landroid_os_Bundle_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayed_Landroid_os_Bundle_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayed_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdDisplayed_Landroid_os_Bundle_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdDisplayed_Landroid_os_Bundle_;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00020E1C File Offset: 0x0001F01C
		private static void n_OnAdViewAdDisplayed_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdDisplayed(object2);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00020E40 File Offset: 0x0001F040
		public unsafe void OnAdViewAdDisplayed(Bundle p0)
		{
			if (this.id_onAdViewAdDisplayed_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onAdViewAdDisplayed_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdDisplayed", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdDisplayed_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00020EB3 File Offset: 0x0001F0B3
		private static Delegate GetOnAdViewAdExpandedHandler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdExpanded == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdExpanded));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdExpanded;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00020ED7 File Offset: 0x0001F0D7
		private static void n_OnAdViewAdExpanded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdViewAdExpanded();
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00020EE6 File Offset: 0x0001F0E6
		public void OnAdViewAdExpanded()
		{
			if (this.id_onAdViewAdExpanded == IntPtr.Zero)
			{
				this.id_onAdViewAdExpanded = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdExpanded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdExpanded);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00020F26 File Offset: 0x0001F126
		private static Delegate GetOnAdViewAdHiddenHandler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdHidden == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdHidden = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdHidden));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdHidden;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00020F4A File Offset: 0x0001F14A
		private static void n_OnAdViewAdHidden(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdViewAdHidden();
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00020F59 File Offset: 0x0001F159
		public void OnAdViewAdHidden()
		{
			if (this.id_onAdViewAdHidden == IntPtr.Zero)
			{
				this.id_onAdViewAdHidden = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdHidden", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdHidden);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00020F99 File Offset: 0x0001F199
		private static Delegate GetOnAdViewAdHidden_Landroid_os_Bundle_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdHidden_Landroid_os_Bundle_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdHidden_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdHidden_Landroid_os_Bundle_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdHidden_Landroid_os_Bundle_;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00020FC0 File Offset: 0x0001F1C0
		private static void n_OnAdViewAdHidden_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdHidden(object2);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00020FE4 File Offset: 0x0001F1E4
		public unsafe void OnAdViewAdHidden(Bundle p0)
		{
			if (this.id_onAdViewAdHidden_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onAdViewAdHidden_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdHidden", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdHidden_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00021057 File Offset: 0x0001F257
		private static Delegate GetOnAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0002107C File Offset: 0x0001F27C
		private static void n_OnAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterError object2 = Java.Lang.Object.GetObject<MaxAdapterError>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdLoadFailed(object2);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000210A0 File Offset: 0x0001F2A0
		public unsafe void OnAdViewAdLoadFailed(MaxAdapterError p0)
		{
			if (this.id_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ == IntPtr.Zero)
			{
				this.id_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdLoadFailed", "(Lcom/applovin/mediation/adapter/MaxAdapterError;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_, ptr);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00021113 File Offset: 0x0001F313
		private static Delegate GetOnAdViewAdLoaded_Landroid_view_View_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoaded_Landroid_view_View_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoaded_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdLoaded_Landroid_view_View_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoaded_Landroid_view_View_;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00021138 File Offset: 0x0001F338
		private static void n_OnAdViewAdLoaded_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdLoaded(object2);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0002115C File Offset: 0x0001F35C
		public unsafe void OnAdViewAdLoaded(View p0)
		{
			if (this.id_onAdViewAdLoaded_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onAdViewAdLoaded_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdLoaded", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdLoaded_Landroid_view_View_, ptr);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000211CF File Offset: 0x0001F3CF
		private static Delegate GetOnAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_Handler()
		{
			if (IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_ == null)
			{
				IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdViewAdapterListenerInvoker.n_OnAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_));
			}
			return IMaxAdViewAdapterListenerInvoker.cb_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000211F4 File Offset: 0x0001F3F4
		private static void n_OnAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdViewAdapterListener @object = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdViewAdLoaded(object2, object3);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00021220 File Offset: 0x0001F420
		public unsafe void OnAdViewAdLoaded(View p0, Bundle p1)
		{
			if (this.id_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onAdViewAdLoaded", "(Landroid/view/View;Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x0400041B RID: 1051
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener", typeof(IMaxAdViewAdapterListenerInvoker));

		// Token: 0x0400041C RID: 1052
		private IntPtr class_ref;

		// Token: 0x0400041D RID: 1053
		private static Delegate cb_onAdViewAdClicked;

		// Token: 0x0400041E RID: 1054
		private IntPtr id_onAdViewAdClicked;

		// Token: 0x0400041F RID: 1055
		private static Delegate cb_onAdViewAdClicked_Landroid_os_Bundle_;

		// Token: 0x04000420 RID: 1056
		private IntPtr id_onAdViewAdClicked_Landroid_os_Bundle_;

		// Token: 0x04000421 RID: 1057
		private static Delegate cb_onAdViewAdCollapsed;

		// Token: 0x04000422 RID: 1058
		private IntPtr id_onAdViewAdCollapsed;

		// Token: 0x04000423 RID: 1059
		private static Delegate cb_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000424 RID: 1060
		private IntPtr id_onAdViewAdDisplayFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000425 RID: 1061
		private static Delegate cb_onAdViewAdDisplayed;

		// Token: 0x04000426 RID: 1062
		private IntPtr id_onAdViewAdDisplayed;

		// Token: 0x04000427 RID: 1063
		private static Delegate cb_onAdViewAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000428 RID: 1064
		private IntPtr id_onAdViewAdDisplayed_Landroid_os_Bundle_;

		// Token: 0x04000429 RID: 1065
		private static Delegate cb_onAdViewAdExpanded;

		// Token: 0x0400042A RID: 1066
		private IntPtr id_onAdViewAdExpanded;

		// Token: 0x0400042B RID: 1067
		private static Delegate cb_onAdViewAdHidden;

		// Token: 0x0400042C RID: 1068
		private IntPtr id_onAdViewAdHidden;

		// Token: 0x0400042D RID: 1069
		private static Delegate cb_onAdViewAdHidden_Landroid_os_Bundle_;

		// Token: 0x0400042E RID: 1070
		private IntPtr id_onAdViewAdHidden_Landroid_os_Bundle_;

		// Token: 0x0400042F RID: 1071
		private static Delegate cb_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000430 RID: 1072
		private IntPtr id_onAdViewAdLoadFailed_Lcom_applovin_mediation_adapter_MaxAdapterError_;

		// Token: 0x04000431 RID: 1073
		private static Delegate cb_onAdViewAdLoaded_Landroid_view_View_;

		// Token: 0x04000432 RID: 1074
		private IntPtr id_onAdViewAdLoaded_Landroid_view_View_;

		// Token: 0x04000433 RID: 1075
		private static Delegate cb_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_;

		// Token: 0x04000434 RID: 1076
		private IntPtr id_onAdViewAdLoaded_Landroid_view_View_Landroid_os_Bundle_;
	}
}
