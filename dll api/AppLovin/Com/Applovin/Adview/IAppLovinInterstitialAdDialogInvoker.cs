using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x0200019B RID: 411
	[Register("com/applovin/adview/AppLovinInterstitialAdDialog", DoNotGenerateAcw = true)]
	internal class IAppLovinInterstitialAdDialogInvoker : Java.Lang.Object, IAppLovinInterstitialAdDialog, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00036E0C File Offset: 0x0003500C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinInterstitialAdDialogInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00036E30 File Offset: 0x00035030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinInterstitialAdDialogInvoker._members;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00036E37 File Offset: 0x00035037
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00036E3F File Offset: 0x0003503F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinInterstitialAdDialogInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00036E4B File Offset: 0x0003504B
		public static IAppLovinInterstitialAdDialog GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(handle, transfer);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00036E54 File Offset: 0x00035054
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinInterstitialAdDialogInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.adview.AppLovinInterstitialAdDialog'.");
			}
			return handle;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00036E7F File Offset: 0x0003507F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00036EB0 File Offset: 0x000350B0
		public IAppLovinInterstitialAdDialogInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinInterstitialAdDialogInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00036EE8 File Offset: 0x000350E8
		private static Delegate GetSetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler()
		{
			if (IAppLovinInterstitialAdDialogInvoker.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ == null)
			{
				IAppLovinInterstitialAdDialogInvoker.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinInterstitialAdDialogInvoker.n_SetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_));
			}
			return IAppLovinInterstitialAdDialogInvoker.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00036F0C File Offset: 0x0003510C
		private static void n_SetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinInterstitialAdDialog @object = Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdClickListener object2 = Java.Lang.Object.GetObject<IAppLovinAdClickListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdClickListener(object2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00036F30 File Offset: 0x00035130
		public unsafe void SetAdClickListener(IAppLovinAdClickListener p0)
		{
			if (this.id_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ == IntPtr.Zero)
			{
				this.id_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ = JNIEnv.GetMethodID(this.class_ref, "setAdClickListener", "(Lcom/applovin/sdk/AppLovinAdClickListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_, ptr);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00036FA8 File Offset: 0x000351A8
		private static Delegate GetSetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler()
		{
			if (IAppLovinInterstitialAdDialogInvoker.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ == null)
			{
				IAppLovinInterstitialAdDialogInvoker.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinInterstitialAdDialogInvoker.n_SetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_));
			}
			return IAppLovinInterstitialAdDialogInvoker.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00036FCC File Offset: 0x000351CC
		private static void n_SetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinInterstitialAdDialog @object = Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdDisplayListener object2 = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdDisplayListener(object2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00036FF0 File Offset: 0x000351F0
		public unsafe void SetAdDisplayListener(IAppLovinAdDisplayListener p0)
		{
			if (this.id_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ == IntPtr.Zero)
			{
				this.id_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ = JNIEnv.GetMethodID(this.class_ref, "setAdDisplayListener", "(Lcom/applovin/sdk/AppLovinAdDisplayListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_, ptr);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00037068 File Offset: 0x00035268
		private static Delegate GetSetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (IAppLovinInterstitialAdDialogInvoker.cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				IAppLovinInterstitialAdDialogInvoker.cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinInterstitialAdDialogInvoker.n_SetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return IAppLovinInterstitialAdDialogInvoker.cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003708C File Offset: 0x0003528C
		private static void n_SetAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinInterstitialAdDialog @object = Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdLoadListener(object2);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000370B0 File Offset: 0x000352B0
		public unsafe void SetAdLoadListener(IAppLovinAdLoadListener p0)
		{
			if (this.id_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_ == IntPtr.Zero)
			{
				this.id_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "setAdLoadListener", "(Lcom/applovin/sdk/AppLovinAdLoadListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_, ptr);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00037128 File Offset: 0x00035328
		private static Delegate GetSetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Handler()
		{
			if (IAppLovinInterstitialAdDialogInvoker.cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ == null)
			{
				IAppLovinInterstitialAdDialogInvoker.cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinInterstitialAdDialogInvoker.n_SetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_));
			}
			return IAppLovinInterstitialAdDialogInvoker.cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0003714C File Offset: 0x0003534C
		private static void n_SetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinInterstitialAdDialog @object = Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdVideoPlaybackListener object2 = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdVideoPlaybackListener(object2);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00037170 File Offset: 0x00035370
		public unsafe void SetAdVideoPlaybackListener(IAppLovinAdVideoPlaybackListener p0)
		{
			if (this.id_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ == IntPtr.Zero)
			{
				this.id_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ = JNIEnv.GetMethodID(this.class_ref, "setAdVideoPlaybackListener", "(Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_, ptr);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000371E8 File Offset: 0x000353E8
		private static Delegate GetShowHandler()
		{
			if (IAppLovinInterstitialAdDialogInvoker.cb_show == null)
			{
				IAppLovinInterstitialAdDialogInvoker.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinInterstitialAdDialogInvoker.n_Show));
			}
			return IAppLovinInterstitialAdDialogInvoker.cb_show;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0003720C File Offset: 0x0003540C
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0003721B File Offset: 0x0003541B
		public void Show()
		{
			if (this.id_show == IntPtr.Zero)
			{
				this.id_show = JNIEnv.GetMethodID(this.class_ref, "show", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_show);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0003725B File Offset: 0x0003545B
		private static Delegate GetShowAndRender_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (IAppLovinInterstitialAdDialogInvoker.cb_showAndRender_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				IAppLovinInterstitialAdDialogInvoker.cb_showAndRender_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinInterstitialAdDialogInvoker.n_ShowAndRender_Lcom_applovin_sdk_AppLovinAd_));
			}
			return IAppLovinInterstitialAdDialogInvoker.cb_showAndRender_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00037280 File Offset: 0x00035480
		private static void n_ShowAndRender_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinInterstitialAdDialog @object = Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ShowAndRender(object2);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000372A4 File Offset: 0x000354A4
		public unsafe void ShowAndRender(IAppLovinAd p0)
		{
			if (this.id_showAndRender_Lcom_applovin_sdk_AppLovinAd_ == IntPtr.Zero)
			{
				this.id_showAndRender_Lcom_applovin_sdk_AppLovinAd_ = JNIEnv.GetMethodID(this.class_ref, "showAndRender", "(Lcom/applovin/sdk/AppLovinAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_showAndRender_Lcom_applovin_sdk_AppLovinAd_, ptr);
		}

		// Token: 0x0400063E RID: 1598
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinInterstitialAdDialog", typeof(IAppLovinInterstitialAdDialogInvoker));

		// Token: 0x0400063F RID: 1599
		private IntPtr class_ref;

		// Token: 0x04000640 RID: 1600
		private static Delegate cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;

		// Token: 0x04000641 RID: 1601
		private IntPtr id_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;

		// Token: 0x04000642 RID: 1602
		private static Delegate cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;

		// Token: 0x04000643 RID: 1603
		private IntPtr id_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;

		// Token: 0x04000644 RID: 1604
		private static Delegate cb_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000645 RID: 1605
		private IntPtr id_setAdLoadListener_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000646 RID: 1606
		private static Delegate cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;

		// Token: 0x04000647 RID: 1607
		private IntPtr id_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;

		// Token: 0x04000648 RID: 1608
		private static Delegate cb_show;

		// Token: 0x04000649 RID: 1609
		private IntPtr id_show;

		// Token: 0x0400064A RID: 1610
		private static Delegate cb_showAndRender_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x0400064B RID: 1611
		private IntPtr id_showAndRender_Lcom_applovin_sdk_AppLovinAd_;
	}
}
