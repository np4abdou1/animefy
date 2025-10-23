using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000045 RID: 69
	[Register("com/adcolony/sdk/AdColonyInterstitialListener", DoNotGenerateAcw = true)]
	public abstract class AdColonyInterstitialListener : Java.Lang.Object
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000AA30 File Offset: 0x00008C30
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyInterstitialListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000AA54 File Offset: 0x00008C54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyInterstitialListener._members;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000AA5C File Offset: 0x00008C5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyInterstitialListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000AA80 File Offset: 0x00008C80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyInterstitialListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyInterstitialListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000AA8C File Offset: 0x00008C8C
		[Register(".ctor", "()V", "")]
		public AdColonyInterstitialListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonyInterstitialListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyInterstitialListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000AAFA File Offset: 0x00008CFA
		[Obsolete]
		private static Delegate GetOnAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000AB20 File Offset: 0x00008D20
		[Obsolete]
		private static void n_OnAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnAudioStarted(object2);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000AB44 File Offset: 0x00008D44
		[Obsolete("deprecated")]
		[Register("onAudioStarted", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnAudioStarted(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onAudioStarted.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Obsolete]
		private static Delegate GetOnAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000ABCC File Offset: 0x00008DCC
		[Obsolete]
		private static void n_OnAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnAudioStopped(object2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Obsolete("deprecated")]
		[Register("onAudioStopped", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnAudioStopped(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onAudioStopped.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000AC54 File Offset: 0x00008E54
		private static Delegate GetOnClicked_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onClicked_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onClicked_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnClicked_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onClicked_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000AC78 File Offset: 0x00008E78
		private static void n_OnClicked_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnClicked(object2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000AC9C File Offset: 0x00008E9C
		[Register("onClicked", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnClicked_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnClicked(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onClicked.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000AD00 File Offset: 0x00008F00
		private static Delegate GetOnClosed_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onClosed_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onClosed_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnClosed_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onClosed_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000AD24 File Offset: 0x00008F24
		private static void n_OnClosed_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnClosed(object2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000AD48 File Offset: 0x00008F48
		[Register("onClosed", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnClosed_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnClosed(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onClosed.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000ADAC File Offset: 0x00008FAC
		private static Delegate GetOnExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		private static void n_OnExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnExpiring(object2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		[Register("onExpiring", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnExpiring(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onExpiring.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000AE58 File Offset: 0x00009058
		private static Delegate GetOnIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_IHandler()
		{
			if (AdColonyInterstitialListener.cb_onIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_I == null)
			{
				AdColonyInterstitialListener.cb_onIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(AdColonyInterstitialListener.n_OnIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_I));
			}
			return AdColonyInterstitialListener.cb_onIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_I;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000AE7C File Offset: 0x0000907C
		private static void n_OnIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_ad, IntPtr native_product_id, int engagement_type)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_product_id, JniHandleOwnership.DoNotTransfer);
			@object.OnIAPEvent(object2, @string, engagement_type);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000AEAC File Offset: 0x000090AC
		[Register("onIAPEvent", "(Lcom/adcolony/sdk/AdColonyInterstitial;Ljava/lang/String;I)V", "GetOnIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_IHandler")]
		public unsafe virtual void OnIAPEvent(AdColonyInterstitial ad, string product_id, int engagement_type)
		{
			IntPtr intPtr = JNIEnv.NewString(product_id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(engagement_type);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onIAPEvent.(Lcom/adcolony/sdk/AdColonyInterstitial;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000AF48 File Offset: 0x00009148
		private static Delegate GetOnLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000AF6C File Offset: 0x0000916C
		private static void n_OnLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnLeftApplication(object2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000AF90 File Offset: 0x00009190
		[Register("onLeftApplication", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnLeftApplication(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onLeftApplication.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000AFF4 File Offset: 0x000091F4
		private static Delegate GetOnOpened_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onOpened_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onOpened_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnOpened_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onOpened_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000B018 File Offset: 0x00009218
		private static void n_OnOpened_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_ad)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_ad, JniHandleOwnership.DoNotTransfer);
			@object.OnOpened(object2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000B03C File Offset: 0x0000923C
		[Register("onOpened", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnOpened_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe virtual void OnOpened(AdColonyInterstitial ad)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ad == null) ? IntPtr.Zero : ad.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onOpened.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ad);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000B0A0 File Offset: 0x000092A0
		private static Delegate GetOnRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_Handler()
		{
			if (AdColonyInterstitialListener.cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_ == null)
			{
				AdColonyInterstitialListener.cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_));
			}
			return AdColonyInterstitialListener.cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000B0C4 File Offset: 0x000092C4
		private static void n_OnRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyInterstitial object2 = Java.Lang.Object.GetObject<AdColonyInterstitial>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestFilled(object2);
		}

		// Token: 0x06000370 RID: 880
		[Register("onRequestFilled", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public abstract void OnRequestFilled(AdColonyInterstitial p0);

		// Token: 0x06000371 RID: 881 RVA: 0x0000B0E7 File Offset: 0x000092E7
		private static Delegate GetOnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_Handler()
		{
			if (AdColonyInterstitialListener.cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_ == null)
			{
				AdColonyInterstitialListener.cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonyInterstitialListener.n_OnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_));
			}
			return AdColonyInterstitialListener.cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000B10C File Offset: 0x0000930C
		private static void n_OnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_(IntPtr jnienv, IntPtr native__this, IntPtr native_zone)
		{
			AdColonyInterstitialListener @object = Java.Lang.Object.GetObject<AdColonyInterstitialListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyZone object2 = Java.Lang.Object.GetObject<AdColonyZone>(native_zone, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestNotFilled(object2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000B130 File Offset: 0x00009330
		[Register("onRequestNotFilled", "(Lcom/adcolony/sdk/AdColonyZone;)V", "GetOnRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_Handler")]
		public unsafe virtual void OnRequestNotFilled(AdColonyZone zone)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((zone == null) ? IntPtr.Zero : zone.Handle);
				AdColonyInterstitialListener._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestNotFilled.(Lcom/adcolony/sdk/AdColonyZone;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(zone);
			}
		}

		// Token: 0x040000DF RID: 223
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyInterstitialListener", typeof(AdColonyInterstitialListener));

		// Token: 0x040000E0 RID: 224
		private static Delegate cb_onAudioStarted_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E1 RID: 225
		private static Delegate cb_onAudioStopped_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E2 RID: 226
		private static Delegate cb_onClicked_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_onClosed_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_onExpiring_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_onIAPEvent_Lcom_adcolony_sdk_AdColonyInterstitial_Ljava_lang_String_I;

		// Token: 0x040000E6 RID: 230
		private static Delegate cb_onLeftApplication_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E7 RID: 231
		private static Delegate cb_onOpened_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E8 RID: 232
		private static Delegate cb_onRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_;

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_onRequestNotFilled_Lcom_adcolony_sdk_AdColonyZone_;
	}
}
