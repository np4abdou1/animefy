using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds
{
	// Token: 0x020000CD RID: 205
	[Register("com/applovin/mediation/nativeAds/MaxNativeAdListener", DoNotGenerateAcw = true)]
	public abstract class MaxNativeAdListener : Java.Lang.Object
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00012FE8 File Offset: 0x000111E8
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNativeAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0001300C File Offset: 0x0001120C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNativeAdListener._members;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00013014 File Offset: 0x00011214
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNativeAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00013038 File Offset: 0x00011238
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNativeAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxNativeAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00013044 File Offset: 0x00011244
		[Register(".ctor", "()V", "")]
		public MaxNativeAdListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MaxNativeAdListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MaxNativeAdListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000130B2 File Offset: 0x000112B2
		private static Delegate GetOnNativeAdClicked_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MaxNativeAdListener.cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MaxNativeAdListener.cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdListener.n_OnNativeAdClicked_Lcom_applovin_mediation_MaxAd_));
			}
			return MaxNativeAdListener.cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000130D8 File Offset: 0x000112D8
		private static void n_OnNativeAdClicked_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdListener @object = Java.Lang.Object.GetObject<MaxNativeAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdClicked(object2);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000130FC File Offset: 0x000112FC
		[Register("onNativeAdClicked", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnNativeAdClicked_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual void OnNativeAdClicked(IMaxAd p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxNativeAdListener._members.InstanceMethods.InvokeVirtualVoidMethod("onNativeAdClicked.(Lcom/applovin/mediation/MaxAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00013164 File Offset: 0x00011364
		private static Delegate GetOnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (MaxNativeAdListener.cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == null)
			{
				MaxNativeAdListener.cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxNativeAdListener.n_OnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_));
			}
			return MaxNativeAdListener.cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00013188 File Offset: 0x00011388
		private static void n_OnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxNativeAdListener @object = Java.Lang.Object.GetObject<MaxNativeAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object2 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdLoadFailed(@string, object2);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000131B4 File Offset: 0x000113B4
		[Register("onNativeAdLoadFailed", "(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V", "GetOnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler")]
		public unsafe virtual void OnNativeAdLoadFailed(string p0, IMaxError p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				MaxNativeAdListener._members.InstanceMethods.InvokeVirtualVoidMethod("onNativeAdLoadFailed.(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0001323C File Offset: 0x0001143C
		private static Delegate GetOnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MaxNativeAdListener.cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MaxNativeAdListener.cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxNativeAdListener.n_OnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_));
			}
			return MaxNativeAdListener.cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00013260 File Offset: 0x00011460
		private static void n_OnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxNativeAdListener @object = Java.Lang.Object.GetObject<MaxNativeAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdView object2 = Java.Lang.Object.GetObject<MaxNativeAdView>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxAd object3 = Java.Lang.Object.GetObject<IMaxAd>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdLoaded(object2, object3);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001328C File Offset: 0x0001148C
		[Register("onNativeAdLoaded", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;Lcom/applovin/mediation/MaxAd;)V", "GetOnNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual void OnNativeAdLoaded(MaxNativeAdView p0, IMaxAd p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				MaxNativeAdListener._members.InstanceMethods.InvokeVirtualVoidMethod("onNativeAdLoaded.(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;Lcom/applovin/mediation/MaxAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x04000279 RID: 633
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAdListener", typeof(MaxNativeAdListener));

		// Token: 0x0400027A RID: 634
		private static Delegate cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x0400027B RID: 635
		private static Delegate cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x0400027C RID: 636
		private static Delegate cb_onNativeAdLoaded_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_;
	}
}
