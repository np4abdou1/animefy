using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds
{
	// Token: 0x020000D3 RID: 211
	[Register("com/applovin/mediation/nativeAds/MaxNativeAdViewBinder", DoNotGenerateAcw = true)]
	public class MaxNativeAdViewBinder : Java.Lang.Object
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0001496D File Offset: 0x00012B6D
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00014984 File Offset: 0x00012B84
		[Register("advertiserTextViewId")]
		protected int AdvertiserTextViewId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("advertiserTextViewId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("advertiserTextViewId.I", this, value);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001499C File Offset: 0x00012B9C
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x000149B3 File Offset: 0x00012BB3
		[Register("bodyTextViewId")]
		protected int BodyTextViewId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("bodyTextViewId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("bodyTextViewId.I", this, value);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000149CB File Offset: 0x00012BCB
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x000149E2 File Offset: 0x00012BE2
		[Register("callToActionButtonId")]
		protected int CallToActionButtonId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("callToActionButtonId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("callToActionButtonId.I", this, value);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000149FA File Offset: 0x00012BFA
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00014A11 File Offset: 0x00012C11
		[Register("iconContentViewId")]
		protected int IconContentViewId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("iconContentViewId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("iconContentViewId.I", this, value);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00014A29 File Offset: 0x00012C29
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00014A40 File Offset: 0x00012C40
		[Register("iconImageViewId")]
		protected int IconImageViewId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("iconImageViewId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("iconImageViewId.I", this, value);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00014A58 File Offset: 0x00012C58
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00014A6F File Offset: 0x00012C6F
		[Register("layoutResourceId")]
		protected int LayoutResourceId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("layoutResourceId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("layoutResourceId.I", this, value);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00014A88 File Offset: 0x00012C88
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00014AB8 File Offset: 0x00012CB8
		[Register("mainView")]
		protected View MainView
		{
			get
			{
				return Java.Lang.Object.GetObject<View>(MaxNativeAdViewBinder._members.InstanceFields.GetObjectValue("mainView.Landroid/view/View;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					MaxNativeAdViewBinder._members.InstanceFields.SetValue("mainView.Landroid/view/View;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00014B04 File Offset: 0x00012D04
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00014B1B File Offset: 0x00012D1B
		[Register("mediaContentFrameLayoutId")]
		protected int MediaContentFrameLayoutId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("mediaContentFrameLayoutId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("mediaContentFrameLayoutId.I", this, value);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00014B33 File Offset: 0x00012D33
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00014B4A File Offset: 0x00012D4A
		[Register("mediaContentViewGroupId")]
		protected int MediaContentViewGroupId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("mediaContentViewGroupId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("mediaContentViewGroupId.I", this, value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00014B62 File Offset: 0x00012D62
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00014B79 File Offset: 0x00012D79
		[Register("optionsContentFrameLayoutId")]
		protected int OptionsContentFrameLayoutId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("optionsContentFrameLayoutId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("optionsContentFrameLayoutId.I", this, value);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00014B91 File Offset: 0x00012D91
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00014BA8 File Offset: 0x00012DA8
		[Register("optionsContentViewGroupId")]
		protected int OptionsContentViewGroupId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("optionsContentViewGroupId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("optionsContentViewGroupId.I", this, value);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00014BC0 File Offset: 0x00012DC0
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00014BF0 File Offset: 0x00012DF0
		[Register("templateType")]
		protected string TemplateType
		{
			get
			{
				return JNIEnv.GetString(MaxNativeAdViewBinder._members.InstanceFields.GetObjectValue("templateType.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					MaxNativeAdViewBinder._members.InstanceFields.SetValue("templateType.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00014C3C File Offset: 0x00012E3C
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00014C53 File Offset: 0x00012E53
		[Register("titleTextViewId")]
		protected int TitleTextViewId
		{
			get
			{
				return MaxNativeAdViewBinder._members.InstanceFields.GetInt32Value("titleTextViewId.I", this);
			}
			set
			{
				MaxNativeAdViewBinder._members.InstanceFields.SetValue("titleTextViewId.I", this, value);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00014C6C File Offset: 0x00012E6C
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNativeAdViewBinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00014C90 File Offset: 0x00012E90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNativeAdViewBinder._members;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00014C98 File Offset: 0x00012E98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNativeAdViewBinder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00014CBC File Offset: 0x00012EBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNativeAdViewBinder._members.ManagedPeerType;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxNativeAdViewBinder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400029D RID: 669
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAdViewBinder", typeof(MaxNativeAdViewBinder));

		// Token: 0x020000D4 RID: 212
		[Register("com/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x1700027F RID: 639
			// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00014CE4 File Offset: 0x00012EE4
			internal static IntPtr class_ref
			{
				get
				{
					return MaxNativeAdViewBinder.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00014D08 File Offset: 0x00012F08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MaxNativeAdViewBinder.Builder._members;
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00014D10 File Offset: 0x00012F10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MaxNativeAdViewBinder.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x060007FA RID: 2042 RVA: 0x00014D34 File Offset: 0x00012F34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MaxNativeAdViewBinder.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060007FB RID: 2043 RVA: 0x000021F0 File Offset: 0x000003F0
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060007FC RID: 2044 RVA: 0x00014D40 File Offset: 0x00012F40
			[Register(".ctor", "(Landroid/view/View;)V", "")]
			public unsafe Builder(View p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					base.SetHandle(MaxNativeAdViewBinder.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MaxNativeAdViewBinder.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x060007FD RID: 2045 RVA: 0x00014DF0 File Offset: 0x00012FF0
			[Register(".ctor", "(I)V", "")]
			public unsafe Builder(int p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				base.SetHandle(MaxNativeAdViewBinder.Builder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdViewBinder.Builder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
			}

			// Token: 0x060007FE RID: 2046 RVA: 0x00014E74 File Offset: 0x00013074
			private static Delegate GetBuildHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_build == null)
				{
					MaxNativeAdViewBinder.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdViewBinder.Builder.n_Build));
				}
				return MaxNativeAdViewBinder.Builder.cb_build;
			}

			// Token: 0x060007FF RID: 2047 RVA: 0x00014E98 File Offset: 0x00013098
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000800 RID: 2048 RVA: 0x00014EAC File Offset: 0x000130AC
			[Register("build", "()Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;", "GetBuildHandler")]
			public virtual MaxNativeAdViewBinder Build()
			{
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000801 RID: 2049 RVA: 0x00014EDE File Offset: 0x000130DE
			private static Delegate GetSetAdvertiserTextViewId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setAdvertiserTextViewId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setAdvertiserTextViewId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetAdvertiserTextViewId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setAdvertiserTextViewId_I;
			}

			// Token: 0x06000802 RID: 2050 RVA: 0x00014F02 File Offset: 0x00013102
			private static IntPtr n_SetAdvertiserTextViewId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAdvertiserTextViewId(p0));
			}

			// Token: 0x06000803 RID: 2051 RVA: 0x00014F18 File Offset: 0x00013118
			[Register("setAdvertiserTextViewId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetAdvertiserTextViewId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetAdvertiserTextViewId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAdvertiserTextViewId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000804 RID: 2052 RVA: 0x00014F61 File Offset: 0x00013161
			private static Delegate GetSetBodyTextViewId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setBodyTextViewId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setBodyTextViewId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetBodyTextViewId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setBodyTextViewId_I;
			}

			// Token: 0x06000805 RID: 2053 RVA: 0x00014F85 File Offset: 0x00013185
			private static IntPtr n_SetBodyTextViewId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBodyTextViewId(p0));
			}

			// Token: 0x06000806 RID: 2054 RVA: 0x00014F9C File Offset: 0x0001319C
			[Register("setBodyTextViewId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetBodyTextViewId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetBodyTextViewId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setBodyTextViewId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000807 RID: 2055 RVA: 0x00014FE5 File Offset: 0x000131E5
			private static Delegate GetSetCallToActionButtonId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setCallToActionButtonId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setCallToActionButtonId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetCallToActionButtonId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setCallToActionButtonId_I;
			}

			// Token: 0x06000808 RID: 2056 RVA: 0x00015009 File Offset: 0x00013209
			private static IntPtr n_SetCallToActionButtonId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCallToActionButtonId(p0));
			}

			// Token: 0x06000809 RID: 2057 RVA: 0x00015020 File Offset: 0x00013220
			[Register("setCallToActionButtonId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetCallToActionButtonId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetCallToActionButtonId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCallToActionButtonId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600080A RID: 2058 RVA: 0x00015069 File Offset: 0x00013269
			private static Delegate GetSetIconContentViewId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setIconContentViewId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setIconContentViewId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetIconContentViewId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setIconContentViewId_I;
			}

			// Token: 0x0600080B RID: 2059 RVA: 0x0001508D File Offset: 0x0001328D
			private static IntPtr n_SetIconContentViewId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIconContentViewId(p0));
			}

			// Token: 0x0600080C RID: 2060 RVA: 0x000150A4 File Offset: 0x000132A4
			[Register("setIconContentViewId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetIconContentViewId_IHandler")]
			protected unsafe virtual MaxNativeAdViewBinder.Builder SetIconContentViewId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIconContentViewId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600080D RID: 2061 RVA: 0x000150ED File Offset: 0x000132ED
			private static Delegate GetSetIconImageViewId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setIconImageViewId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setIconImageViewId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetIconImageViewId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setIconImageViewId_I;
			}

			// Token: 0x0600080E RID: 2062 RVA: 0x00015111 File Offset: 0x00013311
			private static IntPtr n_SetIconImageViewId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIconImageViewId(p0));
			}

			// Token: 0x0600080F RID: 2063 RVA: 0x00015128 File Offset: 0x00013328
			[Register("setIconImageViewId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetIconImageViewId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetIconImageViewId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIconImageViewId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000810 RID: 2064 RVA: 0x00015171 File Offset: 0x00013371
			private static Delegate GetSetMediaContentFrameLayoutId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setMediaContentFrameLayoutId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setMediaContentFrameLayoutId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetMediaContentFrameLayoutId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setMediaContentFrameLayoutId_I;
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x00015195 File Offset: 0x00013395
			private static IntPtr n_SetMediaContentFrameLayoutId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMediaContentFrameLayoutId(p0));
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x000151AC File Offset: 0x000133AC
			[Register("setMediaContentFrameLayoutId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetMediaContentFrameLayoutId_IHandler")]
			protected unsafe virtual MaxNativeAdViewBinder.Builder SetMediaContentFrameLayoutId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMediaContentFrameLayoutId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x000151F5 File Offset: 0x000133F5
			private static Delegate GetSetMediaContentViewGroupId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setMediaContentViewGroupId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setMediaContentViewGroupId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetMediaContentViewGroupId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setMediaContentViewGroupId_I;
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x00015219 File Offset: 0x00013419
			private static IntPtr n_SetMediaContentViewGroupId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMediaContentViewGroupId(p0));
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x00015230 File Offset: 0x00013430
			[Register("setMediaContentViewGroupId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetMediaContentViewGroupId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetMediaContentViewGroupId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMediaContentViewGroupId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x00015279 File Offset: 0x00013479
			private static Delegate GetSetOptionsContentFrameLayoutId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setOptionsContentFrameLayoutId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setOptionsContentFrameLayoutId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetOptionsContentFrameLayoutId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setOptionsContentFrameLayoutId_I;
			}

			// Token: 0x06000817 RID: 2071 RVA: 0x0001529D File Offset: 0x0001349D
			private static IntPtr n_SetOptionsContentFrameLayoutId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOptionsContentFrameLayoutId(p0));
			}

			// Token: 0x06000818 RID: 2072 RVA: 0x000152B4 File Offset: 0x000134B4
			[Register("setOptionsContentFrameLayoutId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetOptionsContentFrameLayoutId_IHandler")]
			protected unsafe virtual MaxNativeAdViewBinder.Builder SetOptionsContentFrameLayoutId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOptionsContentFrameLayoutId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x000152FD File Offset: 0x000134FD
			private static Delegate GetSetOptionsContentViewGroupId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setOptionsContentViewGroupId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setOptionsContentViewGroupId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetOptionsContentViewGroupId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setOptionsContentViewGroupId_I;
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x00015321 File Offset: 0x00013521
			private static IntPtr n_SetOptionsContentViewGroupId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOptionsContentViewGroupId(p0));
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x00015338 File Offset: 0x00013538
			[Register("setOptionsContentViewGroupId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetOptionsContentViewGroupId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetOptionsContentViewGroupId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOptionsContentViewGroupId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x00015381 File Offset: 0x00013581
			private static Delegate GetSetTemplateType_Ljava_lang_String_Handler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setTemplateType_Ljava_lang_String_ == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setTemplateType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxNativeAdViewBinder.Builder.n_SetTemplateType_Ljava_lang_String_));
				}
				return MaxNativeAdViewBinder.Builder.cb_setTemplateType_Ljava_lang_String_;
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x000153A8 File Offset: 0x000135A8
			private static IntPtr n_SetTemplateType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxNativeAdViewBinder.Builder @object = Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTemplateType(@string));
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x000153D0 File Offset: 0x000135D0
			[Register("setTemplateType", "(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetTemplateType_Ljava_lang_String_Handler")]
			protected unsafe virtual MaxNativeAdViewBinder.Builder SetTemplateType(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				MaxNativeAdViewBinder.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTemplateType.(Ljava/lang/String;)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x0001543C File Offset: 0x0001363C
			private static Delegate GetSetTitleTextViewId_IHandler()
			{
				if (MaxNativeAdViewBinder.Builder.cb_setTitleTextViewId_I == null)
				{
					MaxNativeAdViewBinder.Builder.cb_setTitleTextViewId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MaxNativeAdViewBinder.Builder.n_SetTitleTextViewId_I));
				}
				return MaxNativeAdViewBinder.Builder.cb_setTitleTextViewId_I;
			}

			// Token: 0x06000820 RID: 2080 RVA: 0x00015460 File Offset: 0x00013660
			private static IntPtr n_SetTitleTextViewId_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitleTextViewId(p0));
			}

			// Token: 0x06000821 RID: 2081 RVA: 0x00015478 File Offset: 0x00013678
			[Register("setTitleTextViewId", "(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", "GetSetTitleTextViewId_IHandler")]
			public unsafe virtual MaxNativeAdViewBinder.Builder SetTitleTextViewId(int p0)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				return Java.Lang.Object.GetObject<MaxNativeAdViewBinder.Builder>(MaxNativeAdViewBinder.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTitleTextViewId.(I)Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400029E RID: 670
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAdViewBinder$Builder", typeof(MaxNativeAdViewBinder.Builder));

			// Token: 0x0400029F RID: 671
			private static Delegate cb_build;

			// Token: 0x040002A0 RID: 672
			private static Delegate cb_setAdvertiserTextViewId_I;

			// Token: 0x040002A1 RID: 673
			private static Delegate cb_setBodyTextViewId_I;

			// Token: 0x040002A2 RID: 674
			private static Delegate cb_setCallToActionButtonId_I;

			// Token: 0x040002A3 RID: 675
			private static Delegate cb_setIconContentViewId_I;

			// Token: 0x040002A4 RID: 676
			private static Delegate cb_setIconImageViewId_I;

			// Token: 0x040002A5 RID: 677
			private static Delegate cb_setMediaContentFrameLayoutId_I;

			// Token: 0x040002A6 RID: 678
			private static Delegate cb_setMediaContentViewGroupId_I;

			// Token: 0x040002A7 RID: 679
			private static Delegate cb_setOptionsContentFrameLayoutId_I;

			// Token: 0x040002A8 RID: 680
			private static Delegate cb_setOptionsContentViewGroupId_I;

			// Token: 0x040002A9 RID: 681
			private static Delegate cb_setTemplateType_Ljava_lang_String_;

			// Token: 0x040002AA RID: 682
			private static Delegate cb_setTitleTextViewId_I;
		}
	}
}
