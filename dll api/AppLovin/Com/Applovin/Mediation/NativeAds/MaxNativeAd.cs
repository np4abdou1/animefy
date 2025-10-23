using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds
{
	// Token: 0x020000CA RID: 202
	[Register("com/applovin/mediation/nativeAds/MaxNativeAd", DoNotGenerateAcw = true)]
	public class MaxNativeAd : Java.Lang.Object
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00012038 File Offset: 0x00010238
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNativeAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0001205C File Offset: 0x0001025C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNativeAd._members;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00012064 File Offset: 0x00010264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNativeAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00012088 File Offset: 0x00010288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNativeAd._members.ManagedPeerType;
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxNativeAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00012094 File Offset: 0x00010294
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;)V", "")]
		public unsafe MaxNativeAd(MaxNativeAd.Builder p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(MaxNativeAd._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAd._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00012144 File Offset: 0x00010344
		public string Advertiser
		{
			[Register("getAdvertiser", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getAdvertiser.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00012178 File Offset: 0x00010378
		public string Body
		{
			[Register("getBody", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getBody.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000121AC File Offset: 0x000103AC
		public string CallToAction
		{
			[Register("getCallToAction", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getCallToAction.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x000121E0 File Offset: 0x000103E0
		public MaxAdFormat Format
		{
			[Register("getFormat", "()Lcom/applovin/mediation/MaxAdFormat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFormat.()Lcom/applovin/mediation/MaxAdFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00012214 File Offset: 0x00010414
		public MaxNativeAd.MaxNativeAdImage Icon
		{
			[Register("getIcon", "()Lcom/applovin/mediation/nativeAds/MaxNativeAd$MaxNativeAdImage;", "")]
			get
			{
				return Java.Lang.Object.GetObject<MaxNativeAd.MaxNativeAdImage>(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getIcon.()Lcom/applovin/mediation/nativeAds/MaxNativeAd$MaxNativeAdImage;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00012248 File Offset: 0x00010448
		public View IconView
		{
			[Register("getIconView", "()Landroid/view/View;", "")]
			get
			{
				return Java.Lang.Object.GetObject<View>(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getIconView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0001227A File Offset: 0x0001047A
		public float MediaContentAspectRatio
		{
			[Register("getMediaContentAspectRatio", "()F", "")]
			get
			{
				return MaxNativeAd._members.InstanceMethods.InvokeNonvirtualSingleMethod("getMediaContentAspectRatio.()F", this, null);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00012294 File Offset: 0x00010494
		public View MediaView
		{
			[Register("getMediaView", "()Landroid/view/View;", "")]
			get
			{
				return Java.Lang.Object.GetObject<View>(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getMediaView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000122C8 File Offset: 0x000104C8
		public View OptionsView
		{
			[Register("getOptionsView", "()Landroid/view/View;", "")]
			get
			{
				return Java.Lang.Object.GetObject<View>(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOptionsView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x000122FC File Offset: 0x000104FC
		public string Title
		{
			[Register("getTitle", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MaxNativeAd._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTitle.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001232E File Offset: 0x0001052E
		[Register("performClick", "()V", "")]
		public void PerformClick()
		{
			MaxNativeAd._members.InstanceMethods.InvokeNonvirtualVoidMethod("performClick.()V", this, null);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00012347 File Offset: 0x00010547
		private static Delegate GetPrepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Handler()
		{
			if (MaxNativeAd.cb_prepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_ == null)
			{
				MaxNativeAd.cb_prepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAd.n_PrepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_));
			}
			return MaxNativeAd.cb_prepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001236C File Offset: 0x0001056C
		private static void n_PrepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAd @object = Java.Lang.Object.GetObject<MaxNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdView object2 = Java.Lang.Object.GetObject<MaxNativeAdView>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.PrepareViewForInteraction(object2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00012390 File Offset: 0x00010590
		[Register("prepareViewForInteraction", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;)V", "GetPrepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Handler")]
		public unsafe virtual void PrepareViewForInteraction(MaxNativeAdView p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MaxNativeAd._members.InstanceMethods.InvokeVirtualVoidMethod("prepareViewForInteraction.(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000123F4 File Offset: 0x000105F4
		private static Delegate GetSetNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Handler()
		{
			if (MaxNativeAd.cb_setNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_ == null)
			{
				MaxNativeAd.cb_setNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAd.n_SetNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_));
			}
			return MaxNativeAd.cb_setNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00012418 File Offset: 0x00010618
		private static void n_SetNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAd @object = Java.Lang.Object.GetObject<MaxNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdView object2 = Java.Lang.Object.GetObject<MaxNativeAdView>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetNativeAdView(object2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001243C File Offset: 0x0001063C
		[Register("setNativeAdView", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;)V", "GetSetNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Handler")]
		public unsafe virtual void SetNativeAdView(MaxNativeAdView p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MaxNativeAd._members.InstanceMethods.InvokeVirtualVoidMethod("setNativeAdView.(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000267 RID: 615
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAd", typeof(MaxNativeAd));

		// Token: 0x04000268 RID: 616
		private static Delegate cb_prepareViewForInteraction_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_;

		// Token: 0x04000269 RID: 617
		private static Delegate cb_setNativeAdView_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_;

		// Token: 0x020000CB RID: 203
		[Register("com/applovin/mediation/nativeAds/MaxNativeAd$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000249 RID: 585
			// (get) Token: 0x06000726 RID: 1830 RVA: 0x000124BC File Offset: 0x000106BC
			internal static IntPtr class_ref
			{
				get
				{
					return MaxNativeAd.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x06000727 RID: 1831 RVA: 0x000124E0 File Offset: 0x000106E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MaxNativeAd.Builder._members;
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06000728 RID: 1832 RVA: 0x000124E8 File Offset: 0x000106E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MaxNativeAd.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001250C File Offset: 0x0001070C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MaxNativeAd.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x000021F0 File Offset: 0x000003F0
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x00012518 File Offset: 0x00010718
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(MaxNativeAd.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAd.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600072C RID: 1836 RVA: 0x00012586 File Offset: 0x00010786
			private static Delegate GetBuildHandler()
			{
				if (MaxNativeAd.Builder.cb_build == null)
				{
					MaxNativeAd.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAd.Builder.n_Build));
				}
				return MaxNativeAd.Builder.cb_build;
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x000125AA File Offset: 0x000107AA
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600072E RID: 1838 RVA: 0x000125C0 File Offset: 0x000107C0
			[Register("build", "()Lcom/applovin/mediation/nativeAds/MaxNativeAd;", "GetBuildHandler")]
			public virtual MaxNativeAd Build()
			{
				return Java.Lang.Object.GetObject<MaxNativeAd>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/applovin/mediation/nativeAds/MaxNativeAd;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600072F RID: 1839 RVA: 0x000125F2 File Offset: 0x000107F2
			private static Delegate GetSetAdFormat_Lcom_applovin_mediation_MaxAdFormat_Handler()
			{
				if (MaxNativeAd.Builder.cb_setAdFormat_Lcom_applovin_mediation_MaxAdFormat_ == null)
				{
					MaxNativeAd.Builder.cb_setAdFormat_Lcom_applovin_mediation_MaxAdFormat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetAdFormat_Lcom_applovin_mediation_MaxAdFormat_));
				}
				return MaxNativeAd.Builder.cb_setAdFormat_Lcom_applovin_mediation_MaxAdFormat_;
			}

			// Token: 0x06000730 RID: 1840 RVA: 0x00012618 File Offset: 0x00010818
			private static IntPtr n_SetAdFormat_Lcom_applovin_mediation_MaxAdFormat_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MaxAdFormat object2 = Java.Lang.Object.GetObject<MaxAdFormat>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAdFormat(object2));
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x00012640 File Offset: 0x00010840
			[Register("setAdFormat", "(Lcom/applovin/mediation/MaxAdFormat;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetAdFormat_Lcom_applovin_mediation_MaxAdFormat_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetAdFormat(MaxAdFormat p0)
			{
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAdFormat.(Lcom/applovin/mediation/MaxAdFormat;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x000126B4 File Offset: 0x000108B4
			private static Delegate GetSetAdvertiser_Ljava_lang_String_Handler()
			{
				if (MaxNativeAd.Builder.cb_setAdvertiser_Ljava_lang_String_ == null)
				{
					MaxNativeAd.Builder.cb_setAdvertiser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetAdvertiser_Ljava_lang_String_));
				}
				return MaxNativeAd.Builder.cb_setAdvertiser_Ljava_lang_String_;
			}

			// Token: 0x06000733 RID: 1843 RVA: 0x000126D8 File Offset: 0x000108D8
			private static IntPtr n_SetAdvertiser_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAdvertiser(@string));
			}

			// Token: 0x06000734 RID: 1844 RVA: 0x00012700 File Offset: 0x00010900
			[Register("setAdvertiser", "(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetAdvertiser_Ljava_lang_String_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetAdvertiser(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAdvertiser.(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000735 RID: 1845 RVA: 0x0001276C File Offset: 0x0001096C
			private static Delegate GetSetBody_Ljava_lang_String_Handler()
			{
				if (MaxNativeAd.Builder.cb_setBody_Ljava_lang_String_ == null)
				{
					MaxNativeAd.Builder.cb_setBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetBody_Ljava_lang_String_));
				}
				return MaxNativeAd.Builder.cb_setBody_Ljava_lang_String_;
			}

			// Token: 0x06000736 RID: 1846 RVA: 0x00012790 File Offset: 0x00010990
			private static IntPtr n_SetBody_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetBody(@string));
			}

			// Token: 0x06000737 RID: 1847 RVA: 0x000127B8 File Offset: 0x000109B8
			[Register("setBody", "(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetBody_Ljava_lang_String_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetBody(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setBody.(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000738 RID: 1848 RVA: 0x00012824 File Offset: 0x00010A24
			private static Delegate GetSetCallToAction_Ljava_lang_String_Handler()
			{
				if (MaxNativeAd.Builder.cb_setCallToAction_Ljava_lang_String_ == null)
				{
					MaxNativeAd.Builder.cb_setCallToAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetCallToAction_Ljava_lang_String_));
				}
				return MaxNativeAd.Builder.cb_setCallToAction_Ljava_lang_String_;
			}

			// Token: 0x06000739 RID: 1849 RVA: 0x00012848 File Offset: 0x00010A48
			private static IntPtr n_SetCallToAction_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCallToAction(@string));
			}

			// Token: 0x0600073A RID: 1850 RVA: 0x00012870 File Offset: 0x00010A70
			[Register("setCallToAction", "(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetCallToAction_Ljava_lang_String_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetCallToAction(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCallToAction.(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600073B RID: 1851 RVA: 0x000128DC File Offset: 0x00010ADC
			private static Delegate GetSetIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_Handler()
			{
				if (MaxNativeAd.Builder.cb_setIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_ == null)
				{
					MaxNativeAd.Builder.cb_setIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_));
				}
				return MaxNativeAd.Builder.cb_setIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_;
			}

			// Token: 0x0600073C RID: 1852 RVA: 0x00012900 File Offset: 0x00010B00
			private static IntPtr n_SetIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MaxNativeAd.MaxNativeAdImage object2 = Java.Lang.Object.GetObject<MaxNativeAd.MaxNativeAdImage>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
			}

			// Token: 0x0600073D RID: 1853 RVA: 0x00012928 File Offset: 0x00010B28
			[Register("setIcon", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd$MaxNativeAdImage;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetIcon(MaxNativeAd.MaxNativeAdImage p0)
			{
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(Lcom/applovin/mediation/nativeAds/MaxNativeAd$MaxNativeAdImage;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x0600073E RID: 1854 RVA: 0x0001299C File Offset: 0x00010B9C
			private static Delegate GetSetIconView_Landroid_view_View_Handler()
			{
				if (MaxNativeAd.Builder.cb_setIconView_Landroid_view_View_ == null)
				{
					MaxNativeAd.Builder.cb_setIconView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetIconView_Landroid_view_View_));
				}
				return MaxNativeAd.Builder.cb_setIconView_Landroid_view_View_;
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x000129C0 File Offset: 0x00010BC0
			private static IntPtr n_SetIconView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIconView(object2));
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x000129E8 File Offset: 0x00010BE8
			[Register("setIconView", "(Landroid/view/View;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetIconView_Landroid_view_View_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetIconView(View p0)
			{
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIconView.(Landroid/view/View;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x00012A5C File Offset: 0x00010C5C
			private static Delegate GetSetMediaContentAspectRatio_FHandler()
			{
				if (MaxNativeAd.Builder.cb_setMediaContentAspectRatio_F == null)
				{
					MaxNativeAd.Builder.cb_setMediaContentAspectRatio_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_L(MaxNativeAd.Builder.n_SetMediaContentAspectRatio_F));
				}
				return MaxNativeAd.Builder.cb_setMediaContentAspectRatio_F;
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x00012A80 File Offset: 0x00010C80
			private static IntPtr n_SetMediaContentAspectRatio_F(IntPtr jnienv, IntPtr native__this, float p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMediaContentAspectRatio(p0));
			}

			// Token: 0x06000743 RID: 1859 RVA: 0x00012A98 File Offset: 0x00010C98
			[Register("setMediaContentAspectRatio", "(F)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetMediaContentAspectRatio_FHandler")]
			public unsafe virtual MaxNativeAd.Builder SetMediaContentAspectRatio(float p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMediaContentAspectRatio.(F)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x00012AE1 File Offset: 0x00010CE1
			private static Delegate GetSetMediaView_Landroid_view_View_Handler()
			{
				if (MaxNativeAd.Builder.cb_setMediaView_Landroid_view_View_ == null)
				{
					MaxNativeAd.Builder.cb_setMediaView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetMediaView_Landroid_view_View_));
				}
				return MaxNativeAd.Builder.cb_setMediaView_Landroid_view_View_;
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x00012B08 File Offset: 0x00010D08
			private static IntPtr n_SetMediaView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMediaView(object2));
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x00012B30 File Offset: 0x00010D30
			[Register("setMediaView", "(Landroid/view/View;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetMediaView_Landroid_view_View_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetMediaView(View p0)
			{
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMediaView.(Landroid/view/View;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x06000747 RID: 1863 RVA: 0x00012BA4 File Offset: 0x00010DA4
			private static Delegate GetSetOptionsView_Landroid_view_View_Handler()
			{
				if (MaxNativeAd.Builder.cb_setOptionsView_Landroid_view_View_ == null)
				{
					MaxNativeAd.Builder.cb_setOptionsView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetOptionsView_Landroid_view_View_));
				}
				return MaxNativeAd.Builder.cb_setOptionsView_Landroid_view_View_;
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x00012BC8 File Offset: 0x00010DC8
			private static IntPtr n_SetOptionsView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetOptionsView(object2));
			}

			// Token: 0x06000749 RID: 1865 RVA: 0x00012BF0 File Offset: 0x00010DF0
			[Register("setOptionsView", "(Landroid/view/View;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetOptionsView_Landroid_view_View_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetOptionsView(View p0)
			{
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOptionsView.(Landroid/view/View;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x00012C64 File Offset: 0x00010E64
			private static Delegate GetSetTitle_Ljava_lang_String_Handler()
			{
				if (MaxNativeAd.Builder.cb_setTitle_Ljava_lang_String_ == null)
				{
					MaxNativeAd.Builder.cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAd.Builder.n_SetTitle_Ljava_lang_String_));
				}
				return MaxNativeAd.Builder.cb_setTitle_Ljava_lang_String_;
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x00012C88 File Offset: 0x00010E88
			private static IntPtr n_SetTitle_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAd.Builder @object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTitle(@string));
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x00012CB0 File Offset: 0x00010EB0
			[Register("setTitle", "(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", "GetSetTitle_Ljava_lang_String_Handler")]
			public unsafe virtual MaxNativeAd.Builder SetTitle(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				MaxNativeAd.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<MaxNativeAd.Builder>(MaxNativeAd.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTitle.(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAd$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0400026A RID: 618
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAd$Builder", typeof(MaxNativeAd.Builder));

			// Token: 0x0400026B RID: 619
			private static Delegate cb_build;

			// Token: 0x0400026C RID: 620
			private static Delegate cb_setAdFormat_Lcom_applovin_mediation_MaxAdFormat_;

			// Token: 0x0400026D RID: 621
			private static Delegate cb_setAdvertiser_Ljava_lang_String_;

			// Token: 0x0400026E RID: 622
			private static Delegate cb_setBody_Ljava_lang_String_;

			// Token: 0x0400026F RID: 623
			private static Delegate cb_setCallToAction_Ljava_lang_String_;

			// Token: 0x04000270 RID: 624
			private static Delegate cb_setIcon_Lcom_applovin_mediation_nativeAds_MaxNativeAd_MaxNativeAdImage_;

			// Token: 0x04000271 RID: 625
			private static Delegate cb_setIconView_Landroid_view_View_;

			// Token: 0x04000272 RID: 626
			private static Delegate cb_setMediaContentAspectRatio_F;

			// Token: 0x04000273 RID: 627
			private static Delegate cb_setMediaView_Landroid_view_View_;

			// Token: 0x04000274 RID: 628
			private static Delegate cb_setOptionsView_Landroid_view_View_;

			// Token: 0x04000275 RID: 629
			private static Delegate cb_setTitle_Ljava_lang_String_;
		}

		// Token: 0x020000CC RID: 204
		[Register("com/applovin/mediation/nativeAds/MaxNativeAd$MaxNativeAdImage", DoNotGenerateAcw = true)]
		public class MaxNativeAdImage : Java.Lang.Object
		{
			// Token: 0x1700024D RID: 589
			// (get) Token: 0x0600074E RID: 1870 RVA: 0x00012D38 File Offset: 0x00010F38
			internal static IntPtr class_ref
			{
				get
				{
					return MaxNativeAd.MaxNativeAdImage._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x0600074F RID: 1871 RVA: 0x00012D5C File Offset: 0x00010F5C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MaxNativeAd.MaxNativeAdImage._members;
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x06000750 RID: 1872 RVA: 0x00012D64 File Offset: 0x00010F64
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MaxNativeAd.MaxNativeAdImage._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x06000751 RID: 1873 RVA: 0x00012D88 File Offset: 0x00010F88
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MaxNativeAd.MaxNativeAdImage._members.ManagedPeerType;
				}
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x000021F0 File Offset: 0x000003F0
			protected MaxNativeAdImage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x00012D94 File Offset: 0x00010F94
			[Register(".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
			public unsafe MaxNativeAdImage(Drawable p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					base.SetHandle(MaxNativeAd.MaxNativeAdImage._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/drawable/Drawable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MaxNativeAd.MaxNativeAdImage._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x00012E44 File Offset: 0x00011044
			[Register(".ctor", "(Landroid/net/Uri;)V", "")]
			public unsafe MaxNativeAdImage(Android.Net.Uri p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					base.SetHandle(MaxNativeAd.MaxNativeAdImage._members.InstanceMethods.StartCreateInstance("(Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MaxNativeAd.MaxNativeAdImage._members.InstanceMethods.FinishCreateInstance("(Landroid/net/Uri;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x00012EF4 File Offset: 0x000110F4
			private static Delegate GetGetDrawableHandler()
			{
				if (MaxNativeAd.MaxNativeAdImage.cb_getDrawable == null)
				{
					MaxNativeAd.MaxNativeAdImage.cb_getDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAd.MaxNativeAdImage.n_GetDrawable));
				}
				return MaxNativeAd.MaxNativeAdImage.cb_getDrawable;
			}

			// Token: 0x06000756 RID: 1878 RVA: 0x00012F18 File Offset: 0x00011118
			private static IntPtr n_GetDrawable(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAd.MaxNativeAdImage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Drawable);
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x06000757 RID: 1879 RVA: 0x00012F2C File Offset: 0x0001112C
			public virtual Drawable Drawable
			{
				[Register("getDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDrawableHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Drawable>(MaxNativeAd.MaxNativeAdImage._members.InstanceMethods.InvokeVirtualObjectMethod("getDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x00012F5E File Offset: 0x0001115E
			private static Delegate GetGetUriHandler()
			{
				if (MaxNativeAd.MaxNativeAdImage.cb_getUri == null)
				{
					MaxNativeAd.MaxNativeAdImage.cb_getUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAd.MaxNativeAdImage.n_GetUri));
				}
				return MaxNativeAd.MaxNativeAdImage.cb_getUri;
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x00012F82 File Offset: 0x00011182
			private static IntPtr n_GetUri(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAd.MaxNativeAdImage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Uri);
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x00012F98 File Offset: 0x00011198
			public virtual Android.Net.Uri Uri
			{
				[Register("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Android.Net.Uri>(MaxNativeAd.MaxNativeAdImage._members.InstanceMethods.InvokeVirtualObjectMethod("getUri.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000276 RID: 630
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAd$MaxNativeAdImage", typeof(MaxNativeAd.MaxNativeAdImage));

			// Token: 0x04000277 RID: 631
			private static Delegate cb_getDrawable;

			// Token: 0x04000278 RID: 632
			private static Delegate cb_getUri;
		}
	}
}
