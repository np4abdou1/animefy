using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C8 RID: 200
	[Register("com/applovin/mediation/MaxAdFormat", DoNotGenerateAcw = true)]
	public class MaxAdFormat : Java.Lang.Object
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00011978 File Offset: 0x0000FB78
		[Register("BANNER")]
		public static MaxAdFormat Banner
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("BANNER.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000119A8 File Offset: 0x0000FBA8
		[Register("CROSS_PROMO")]
		public static MaxAdFormat CrossPromo
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("CROSS_PROMO.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000119D8 File Offset: 0x0000FBD8
		[Register("INTERSTITIAL")]
		public static MaxAdFormat Interstitial
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("INTERSTITIAL.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00011A08 File Offset: 0x0000FC08
		[Register("LEADER")]
		public static MaxAdFormat Leader
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("LEADER.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00011A38 File Offset: 0x0000FC38
		[Register("MREC")]
		public static MaxAdFormat Mrec
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("MREC.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00011A68 File Offset: 0x0000FC68
		[Register("NATIVE")]
		public static MaxAdFormat Native
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("NATIVE.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00011A98 File Offset: 0x0000FC98
		[Register("REWARDED")]
		public static MaxAdFormat Rewarded
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("REWARDED.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		[Register("REWARDED_INTERSTITIAL")]
		public static MaxAdFormat RewardedInterstitial
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticFields.GetObjectValue("REWARDED_INTERSTITIAL.Lcom/applovin/mediation/MaxAdFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00011AF8 File Offset: 0x0000FCF8
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdFormat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00011B1C File Offset: 0x0000FD1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdFormat._members;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00011B24 File Offset: 0x0000FD24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdFormat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00011B48 File Offset: 0x0000FD48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdFormat._members.ManagedPeerType;
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxAdFormat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00011B54 File Offset: 0x0000FD54
		private static Delegate GetGetDisplayNameHandler()
		{
			if (MaxAdFormat.cb_getDisplayName == null)
			{
				MaxAdFormat.cb_getDisplayName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdFormat.n_GetDisplayName));
			}
			return MaxAdFormat.cb_getDisplayName;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00011B78 File Offset: 0x0000FD78
		private static IntPtr n_GetDisplayName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayName);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public virtual string DisplayName
		{
			[Register("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdFormat._members.InstanceMethods.InvokeVirtualObjectMethod("getDisplayName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00011BBE File Offset: 0x0000FDBE
		private static Delegate GetIsAdViewAdHandler()
		{
			if (MaxAdFormat.cb_isAdViewAd == null)
			{
				MaxAdFormat.cb_isAdViewAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxAdFormat.n_IsAdViewAd));
			}
			return MaxAdFormat.cb_isAdViewAd;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00011BE2 File Offset: 0x0000FDE2
		private static bool n_IsAdViewAd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAdViewAd;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00011BF1 File Offset: 0x0000FDF1
		public virtual bool IsAdViewAd
		{
			[Register("isAdViewAd", "()Z", "GetIsAdViewAdHandler")]
			get
			{
				return MaxAdFormat._members.InstanceMethods.InvokeVirtualBooleanMethod("isAdViewAd.()Z", this, null);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00011C0A File Offset: 0x0000FE0A
		private static Delegate GetIsFullscreenAdHandler()
		{
			if (MaxAdFormat.cb_isFullscreenAd == null)
			{
				MaxAdFormat.cb_isFullscreenAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaxAdFormat.n_IsFullscreenAd));
			}
			return MaxAdFormat.cb_isFullscreenAd;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00011C2E File Offset: 0x0000FE2E
		private static bool n_IsFullscreenAd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFullscreenAd;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00011C3D File Offset: 0x0000FE3D
		public virtual bool IsFullscreenAd
		{
			[Register("isFullscreenAd", "()Z", "GetIsFullscreenAdHandler")]
			get
			{
				return MaxAdFormat._members.InstanceMethods.InvokeVirtualBooleanMethod("isFullscreenAd.()Z", this, null);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00011C56 File Offset: 0x0000FE56
		private static Delegate GetGetLabelHandler()
		{
			if (MaxAdFormat.cb_getLabel == null)
			{
				MaxAdFormat.cb_getLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdFormat.n_GetLabel));
			}
			return MaxAdFormat.cb_getLabel;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00011C7A File Offset: 0x0000FE7A
		private static IntPtr n_GetLabel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Label);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00011C90 File Offset: 0x0000FE90
		public virtual string Label
		{
			[Register("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdFormat._members.InstanceMethods.InvokeVirtualObjectMethod("getLabel.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00011CC2 File Offset: 0x0000FEC2
		private static Delegate GetGetSizeHandler()
		{
			if (MaxAdFormat.cb_getSize == null)
			{
				MaxAdFormat.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdFormat.n_GetSize));
			}
			return MaxAdFormat.cb_getSize;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00011CE6 File Offset: 0x0000FEE6
		private static IntPtr n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00011CFC File Offset: 0x0000FEFC
		public virtual AppLovinSdkUtils.Size Size
		{
			[Register("getSize", "()Lcom/applovin/sdk/AppLovinSdkUtils$Size;", "GetGetSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdkUtils.Size>(MaxAdFormat._members.InstanceMethods.InvokeVirtualObjectMethod("getSize.()Lcom/applovin/sdk/AppLovinSdkUtils$Size;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00011D30 File Offset: 0x0000FF30
		[Register("formatFromString", "(Ljava/lang/String;)Lcom/applovin/mediation/MaxAdFormat;", "")]
		public unsafe static MaxAdFormat FormatFromString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			MaxAdFormat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdFormat._members.StaticMethods.InvokeObjectMethod("formatFromString.(Ljava/lang/String;)Lcom/applovin/mediation/MaxAdFormat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00011D9C File Offset: 0x0000FF9C
		private static Delegate GetGetAdaptiveSize_Landroid_app_Activity_Handler()
		{
			if (MaxAdFormat.cb_getAdaptiveSize_Landroid_app_Activity_ == null)
			{
				MaxAdFormat.cb_getAdaptiveSize_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MaxAdFormat.n_GetAdaptiveSize_Landroid_app_Activity_));
			}
			return MaxAdFormat.cb_getAdaptiveSize_Landroid_app_Activity_;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		private static IntPtr n_GetAdaptiveSize_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdFormat @object = Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetAdaptiveSize(object2));
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00011DE8 File Offset: 0x0000FFE8
		[Register("getAdaptiveSize", "(Landroid/app/Activity;)Lcom/applovin/sdk/AppLovinSdkUtils$Size;", "GetGetAdaptiveSize_Landroid_app_Activity_Handler")]
		public unsafe virtual AppLovinSdkUtils.Size GetAdaptiveSize(Activity p0)
		{
			AppLovinSdkUtils.Size @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinSdkUtils.Size>(MaxAdFormat._members.InstanceMethods.InvokeVirtualObjectMethod("getAdaptiveSize.(Landroid/app/Activity;)Lcom/applovin/sdk/AppLovinSdkUtils$Size;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00011E5C File Offset: 0x0001005C
		private static Delegate GetGetAdaptiveSize_ILandroid_content_Context_Handler()
		{
			if (MaxAdFormat.cb_getAdaptiveSize_ILandroid_content_Context_ == null)
			{
				MaxAdFormat.cb_getAdaptiveSize_ILandroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(MaxAdFormat.n_GetAdaptiveSize_ILandroid_content_Context_));
			}
			return MaxAdFormat.cb_getAdaptiveSize_ILandroid_content_Context_;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00011E80 File Offset: 0x00010080
		private static IntPtr n_GetAdaptiveSize_ILandroid_content_Context_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			MaxAdFormat @object = Java.Lang.Object.GetObject<MaxAdFormat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetAdaptiveSize(p0, object2));
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00011EAC File Offset: 0x000100AC
		[Register("getAdaptiveSize", "(ILandroid/content/Context;)Lcom/applovin/sdk/AppLovinSdkUtils$Size;", "GetGetAdaptiveSize_ILandroid_content_Context_Handler")]
		public unsafe virtual AppLovinSdkUtils.Size GetAdaptiveSize(int p0, Context p1)
		{
			AppLovinSdkUtils.Size @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinSdkUtils.Size>(MaxAdFormat._members.InstanceMethods.InvokeVirtualObjectMethod("getAdaptiveSize.(ILandroid/content/Context;)Lcom/applovin/sdk/AppLovinSdkUtils$Size;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000257 RID: 599
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAdFormat", typeof(MaxAdFormat));

		// Token: 0x04000258 RID: 600
		private static Delegate cb_getDisplayName;

		// Token: 0x04000259 RID: 601
		private static Delegate cb_isAdViewAd;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_isFullscreenAd;

		// Token: 0x0400025B RID: 603
		private static Delegate cb_getLabel;

		// Token: 0x0400025C RID: 604
		private static Delegate cb_getSize;

		// Token: 0x0400025D RID: 605
		private static Delegate cb_getAdaptiveSize_Landroid_app_Activity_;

		// Token: 0x0400025E RID: 606
		private static Delegate cb_getAdaptiveSize_ILandroid_content_Context_;
	}
}
