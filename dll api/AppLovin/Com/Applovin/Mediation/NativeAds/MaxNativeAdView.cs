using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds
{
	// Token: 0x020000D2 RID: 210
	[Register("com/applovin/mediation/nativeAds/MaxNativeAdView", DoNotGenerateAcw = true)]
	public class MaxNativeAdView : FrameLayout
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00013E90 File Offset: 0x00012090
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNativeAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00013EB4 File Offset: 0x000120B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNativeAdView._members;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00013EBC File Offset: 0x000120BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNativeAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00013EE0 File Offset: 0x000120E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNativeAdView._members.ManagedPeerType;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00013EEC File Offset: 0x000120EC
		protected MaxNativeAdView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00013EF8 File Offset: 0x000120F8
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Landroid/app/Activity;)V", "")]
		public unsafe MaxNativeAdView(MaxNativeAd p0, Activity p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				base.SetHandle(MaxNativeAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00013FD0 File Offset: 0x000121D0
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;Landroid/content/Context;)V", "")]
		public unsafe MaxNativeAdView(MaxNativeAd p0, MaxNativeAdViewBinder p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(MaxNativeAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000140D0 File Offset: 0x000122D0
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Ljava/lang/String;Landroid/app/Activity;)V", "")]
		public unsafe MaxNativeAdView(MaxNativeAd p0, string p1, Activity p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(MaxNativeAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Ljava/lang/String;Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Ljava/lang/String;Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000141C8 File Offset: 0x000123C8
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe MaxNativeAdView(MaxNativeAd p0, string p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(MaxNativeAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Ljava/lang/String;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAd;Ljava/lang/String;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000142C0 File Offset: 0x000124C0
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;Landroid/content/Context;)V", "")]
		public unsafe MaxNativeAdView(MaxNativeAdViewBinder p0, Context p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				base.SetHandle(MaxNativeAdView._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdView._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00014398 File Offset: 0x00012598
		[Register(".ctor", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe MaxNativeAdView(string p0, Context p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				base.SetHandle(MaxNativeAdView._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdView._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00014464 File Offset: 0x00012664
		private static Delegate GetGetAdvertiserTextViewHandler()
		{
			if (MaxNativeAdView.cb_getAdvertiserTextView == null)
			{
				MaxNativeAdView.cb_getAdvertiserTextView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetAdvertiserTextView));
			}
			return MaxNativeAdView.cb_getAdvertiserTextView;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00014488 File Offset: 0x00012688
		private static IntPtr n_GetAdvertiserTextView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdvertiserTextView);
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0001449C File Offset: 0x0001269C
		public virtual TextView AdvertiserTextView
		{
			[Register("getAdvertiserTextView", "()Landroid/widget/TextView;", "GetGetAdvertiserTextViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextView>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getAdvertiserTextView.()Landroid/widget/TextView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000144CE File Offset: 0x000126CE
		private static Delegate GetGetBodyTextViewHandler()
		{
			if (MaxNativeAdView.cb_getBodyTextView == null)
			{
				MaxNativeAdView.cb_getBodyTextView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetBodyTextView));
			}
			return MaxNativeAdView.cb_getBodyTextView;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000144F2 File Offset: 0x000126F2
		private static IntPtr n_GetBodyTextView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BodyTextView);
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00014508 File Offset: 0x00012708
		public virtual TextView BodyTextView
		{
			[Register("getBodyTextView", "()Landroid/widget/TextView;", "GetGetBodyTextViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextView>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getBodyTextView.()Landroid/widget/TextView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001453A File Offset: 0x0001273A
		private static Delegate GetGetCallToActionButtonHandler()
		{
			if (MaxNativeAdView.cb_getCallToActionButton == null)
			{
				MaxNativeAdView.cb_getCallToActionButton = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetCallToActionButton));
			}
			return MaxNativeAdView.cb_getCallToActionButton;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0001455E File Offset: 0x0001275E
		private static IntPtr n_GetCallToActionButton(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CallToActionButton);
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00014574 File Offset: 0x00012774
		public virtual Button CallToActionButton
		{
			[Register("getCallToActionButton", "()Landroid/widget/Button;", "GetGetCallToActionButtonHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Button>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getCallToActionButton.()Landroid/widget/Button;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000145A6 File Offset: 0x000127A6
		private static Delegate GetGetIconContentViewHandler()
		{
			if (MaxNativeAdView.cb_getIconContentView == null)
			{
				MaxNativeAdView.cb_getIconContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetIconContentView));
			}
			return MaxNativeAdView.cb_getIconContentView;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000145CA File Offset: 0x000127CA
		private static IntPtr n_GetIconContentView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconContentView);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000145E0 File Offset: 0x000127E0
		public virtual FrameLayout IconContentView
		{
			[Register("getIconContentView", "()Landroid/widget/FrameLayout;", "GetGetIconContentViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FrameLayout>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getIconContentView.()Landroid/widget/FrameLayout;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00014612 File Offset: 0x00012812
		private static Delegate GetGetIconImageViewHandler()
		{
			if (MaxNativeAdView.cb_getIconImageView == null)
			{
				MaxNativeAdView.cb_getIconImageView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetIconImageView));
			}
			return MaxNativeAdView.cb_getIconImageView;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00014636 File Offset: 0x00012836
		private static IntPtr n_GetIconImageView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconImageView);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0001464C File Offset: 0x0001284C
		public virtual ImageView IconImageView
		{
			[Register("getIconImageView", "()Landroid/widget/ImageView;", "GetGetIconImageViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ImageView>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getIconImageView.()Landroid/widget/ImageView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0001467E File Offset: 0x0001287E
		private static Delegate GetGetMainViewHandler()
		{
			if (MaxNativeAdView.cb_getMainView == null)
			{
				MaxNativeAdView.cb_getMainView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetMainView));
			}
			return MaxNativeAdView.cb_getMainView;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000146A2 File Offset: 0x000128A2
		private static IntPtr n_GetMainView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MainView);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x000146B8 File Offset: 0x000128B8
		public virtual View MainView
		{
			[Register("getMainView", "()Landroid/view/View;", "GetGetMainViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getMainView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000146EA File Offset: 0x000128EA
		private static Delegate GetGetMediaContentViewHandler()
		{
			if (MaxNativeAdView.cb_getMediaContentView == null)
			{
				MaxNativeAdView.cb_getMediaContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetMediaContentView));
			}
			return MaxNativeAdView.cb_getMediaContentView;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001470E File Offset: 0x0001290E
		private static IntPtr n_GetMediaContentView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediaContentView);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00014724 File Offset: 0x00012924
		public virtual FrameLayout MediaContentView
		{
			[Register("getMediaContentView", "()Landroid/widget/FrameLayout;", "GetGetMediaContentViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FrameLayout>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getMediaContentView.()Landroid/widget/FrameLayout;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00014756 File Offset: 0x00012956
		private static Delegate GetGetMediaContentViewGroupHandler()
		{
			if (MaxNativeAdView.cb_getMediaContentViewGroup == null)
			{
				MaxNativeAdView.cb_getMediaContentViewGroup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetMediaContentViewGroup));
			}
			return MaxNativeAdView.cb_getMediaContentViewGroup;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001477A File Offset: 0x0001297A
		private static IntPtr n_GetMediaContentViewGroup(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediaContentViewGroup);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00014790 File Offset: 0x00012990
		public virtual ViewGroup MediaContentViewGroup
		{
			[Register("getMediaContentViewGroup", "()Landroid/view/ViewGroup;", "GetGetMediaContentViewGroupHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ViewGroup>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getMediaContentViewGroup.()Landroid/view/ViewGroup;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000147C2 File Offset: 0x000129C2
		private static Delegate GetGetOptionsContentViewHandler()
		{
			if (MaxNativeAdView.cb_getOptionsContentView == null)
			{
				MaxNativeAdView.cb_getOptionsContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetOptionsContentView));
			}
			return MaxNativeAdView.cb_getOptionsContentView;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000147E6 File Offset: 0x000129E6
		private static IntPtr n_GetOptionsContentView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionsContentView);
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x000147FC File Offset: 0x000129FC
		public virtual FrameLayout OptionsContentView
		{
			[Register("getOptionsContentView", "()Landroid/widget/FrameLayout;", "GetGetOptionsContentViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FrameLayout>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getOptionsContentView.()Landroid/widget/FrameLayout;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001482E File Offset: 0x00012A2E
		private static Delegate GetGetOptionsContentViewGroupHandler()
		{
			if (MaxNativeAdView.cb_getOptionsContentViewGroup == null)
			{
				MaxNativeAdView.cb_getOptionsContentViewGroup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetOptionsContentViewGroup));
			}
			return MaxNativeAdView.cb_getOptionsContentViewGroup;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00014852 File Offset: 0x00012A52
		private static IntPtr n_GetOptionsContentViewGroup(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionsContentViewGroup);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00014868 File Offset: 0x00012A68
		public virtual ViewGroup OptionsContentViewGroup
		{
			[Register("getOptionsContentViewGroup", "()Landroid/view/ViewGroup;", "GetGetOptionsContentViewGroupHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ViewGroup>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getOptionsContentViewGroup.()Landroid/view/ViewGroup;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001489A File Offset: 0x00012A9A
		private static Delegate GetGetTitleTextViewHandler()
		{
			if (MaxNativeAdView.cb_getTitleTextView == null)
			{
				MaxNativeAdView.cb_getTitleTextView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdView.n_GetTitleTextView));
			}
			return MaxNativeAdView.cb_getTitleTextView;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000148BE File Offset: 0x00012ABE
		private static IntPtr n_GetTitleTextView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleTextView);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000148D4 File Offset: 0x00012AD4
		public virtual TextView TitleTextView
		{
			[Register("getTitleTextView", "()Landroid/widget/TextView;", "GetGetTitleTextViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextView>(MaxNativeAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getTitleTextView.()Landroid/widget/TextView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00014906 File Offset: 0x00012B06
		private static Delegate GetRecycleHandler()
		{
			if (MaxNativeAdView.cb_recycle == null)
			{
				MaxNativeAdView.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxNativeAdView.n_Recycle));
			}
			return MaxNativeAdView.cb_recycle;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001492A File Offset: 0x00012B2A
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxNativeAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00014939 File Offset: 0x00012B39
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			MaxNativeAdView._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x04000290 RID: 656
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAdView", typeof(MaxNativeAdView));

		// Token: 0x04000291 RID: 657
		private static Delegate cb_getAdvertiserTextView;

		// Token: 0x04000292 RID: 658
		private static Delegate cb_getBodyTextView;

		// Token: 0x04000293 RID: 659
		private static Delegate cb_getCallToActionButton;

		// Token: 0x04000294 RID: 660
		private static Delegate cb_getIconContentView;

		// Token: 0x04000295 RID: 661
		private static Delegate cb_getIconImageView;

		// Token: 0x04000296 RID: 662
		private static Delegate cb_getMainView;

		// Token: 0x04000297 RID: 663
		private static Delegate cb_getMediaContentView;

		// Token: 0x04000298 RID: 664
		private static Delegate cb_getMediaContentViewGroup;

		// Token: 0x04000299 RID: 665
		private static Delegate cb_getOptionsContentView;

		// Token: 0x0400029A RID: 666
		private static Delegate cb_getOptionsContentViewGroup;

		// Token: 0x0400029B RID: 667
		private static Delegate cb_getTitleTextView;

		// Token: 0x0400029C RID: 668
		private static Delegate cb_recycle;
	}
}
