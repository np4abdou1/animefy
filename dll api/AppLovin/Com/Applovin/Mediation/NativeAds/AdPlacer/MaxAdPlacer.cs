using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds.AdPlacer
{
	// Token: 0x020000D5 RID: 213
	[Register("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer", DoNotGenerateAcw = true)]
	public class MaxAdPlacer : Java.Lang.Object
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000154DC File Offset: 0x000136DC
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdPlacer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00015500 File Offset: 0x00013700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdPlacer._members;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00015508 File Offset: 0x00013708
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdPlacer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0001552C File Offset: 0x0001372C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdPlacer._members.ManagedPeerType;
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxAdPlacer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00015538 File Offset: 0x00013738
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings;Landroid/content/Context;)V", "")]
		public unsafe MaxAdPlacer(MaxAdPlacerSettings p0, Context p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxAdPlacer._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdPlacer._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00015610 File Offset: 0x00013810
		[Register(".ctor", "(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", "")]
		public unsafe MaxAdPlacer(MaxAdPlacerSettings p0, AppLovinSdk p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxAdPlacer._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdPlacer._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacerSettings;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00015710 File Offset: 0x00013910
		private static Delegate GetClearAdsHandler()
		{
			if (MaxAdPlacer.cb_clearAds == null)
			{
				MaxAdPlacer.cb_clearAds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdPlacer.n_ClearAds));
			}
			return MaxAdPlacer.cb_clearAds;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00015734 File Offset: 0x00013934
		private static void n_ClearAds(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearAds();
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00015743 File Offset: 0x00013943
		[Register("clearAds", "()V", "GetClearAdsHandler")]
		public virtual void ClearAds()
		{
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("clearAds.()V", this, null);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0001575C File Offset: 0x0001395C
		private static Delegate GetDestroyHandler()
		{
			if (MaxAdPlacer.cb_destroy == null)
			{
				MaxAdPlacer.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdPlacer.n_Destroy));
			}
			return MaxAdPlacer.cb_destroy;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00015780 File Offset: 0x00013980
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001578F File Offset: 0x0001398F
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000157A8 File Offset: 0x000139A8
		private static Delegate GetGetAdItemId_IHandler()
		{
			if (MaxAdPlacer.cb_getAdItemId_I == null)
			{
				MaxAdPlacer.cb_getAdItemId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(MaxAdPlacer.n_GetAdItemId_I));
			}
			return MaxAdPlacer.cb_getAdItemId_I;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000157CC File Offset: 0x000139CC
		private static long n_GetAdItemId_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdItemId(p0);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000157DC File Offset: 0x000139DC
		[Register("getAdItemId", "(I)J", "GetGetAdItemId_IHandler")]
		public unsafe virtual long GetAdItemId(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return MaxAdPlacer._members.InstanceMethods.InvokeVirtualInt64Method("getAdItemId.(I)J", this, ptr);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00015817 File Offset: 0x00013A17
		private static Delegate GetGetAdSize_IIHandler()
		{
			if (MaxAdPlacer.cb_getAdSize_II == null)
			{
				MaxAdPlacer.cb_getAdSize_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(MaxAdPlacer.n_GetAdSize_II));
			}
			return MaxAdPlacer.cb_getAdSize_II;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0001583B File Offset: 0x00013A3B
		private static IntPtr n_GetAdSize_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdSize(p0, p1));
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00015854 File Offset: 0x00013A54
		[Register("getAdSize", "(II)Lcom/applovin/sdk/AppLovinSdkUtils$Size;", "GetGetAdSize_IIHandler")]
		public unsafe virtual AppLovinSdkUtils.Size GetAdSize(int p0, int p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			return Java.Lang.Object.GetObject<AppLovinSdkUtils.Size>(MaxAdPlacer._members.InstanceMethods.InvokeVirtualObjectMethod("getAdSize.(II)Lcom/applovin/sdk/AppLovinSdkUtils$Size;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000158B0 File Offset: 0x00013AB0
		private static Delegate GetGetAdjustedCount_IHandler()
		{
			if (MaxAdPlacer.cb_getAdjustedCount_I == null)
			{
				MaxAdPlacer.cb_getAdjustedCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(MaxAdPlacer.n_GetAdjustedCount_I));
			}
			return MaxAdPlacer.cb_getAdjustedCount_I;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000158D4 File Offset: 0x00013AD4
		private static int n_GetAdjustedCount_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdjustedCount(p0);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000158E4 File Offset: 0x00013AE4
		[Register("getAdjustedCount", "(I)I", "GetGetAdjustedCount_IHandler")]
		public unsafe virtual int GetAdjustedCount(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return MaxAdPlacer._members.InstanceMethods.InvokeVirtualInt32Method("getAdjustedCount.(I)I", this, ptr);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001591F File Offset: 0x00013B1F
		private static Delegate GetGetAdjustedPosition_IHandler()
		{
			if (MaxAdPlacer.cb_getAdjustedPosition_I == null)
			{
				MaxAdPlacer.cb_getAdjustedPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(MaxAdPlacer.n_GetAdjustedPosition_I));
			}
			return MaxAdPlacer.cb_getAdjustedPosition_I;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00015943 File Offset: 0x00013B43
		private static int n_GetAdjustedPosition_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdjustedPosition(p0);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00015954 File Offset: 0x00013B54
		[Register("getAdjustedPosition", "(I)I", "GetGetAdjustedPosition_IHandler")]
		public unsafe virtual int GetAdjustedPosition(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return MaxAdPlacer._members.InstanceMethods.InvokeVirtualInt32Method("getAdjustedPosition.(I)I", this, ptr);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0001598F File Offset: 0x00013B8F
		private static Delegate GetGetOriginalPosition_IHandler()
		{
			if (MaxAdPlacer.cb_getOriginalPosition_I == null)
			{
				MaxAdPlacer.cb_getOriginalPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(MaxAdPlacer.n_GetOriginalPosition_I));
			}
			return MaxAdPlacer.cb_getOriginalPosition_I;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000159B3 File Offset: 0x00013BB3
		private static int n_GetOriginalPosition_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetOriginalPosition(p0);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000159C4 File Offset: 0x00013BC4
		[Register("getOriginalPosition", "(I)I", "GetGetOriginalPosition_IHandler")]
		public unsafe virtual int GetOriginalPosition(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return MaxAdPlacer._members.InstanceMethods.InvokeVirtualInt32Method("getOriginalPosition.(I)I", this, ptr);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000159FF File Offset: 0x00013BFF
		private static Delegate GetInsertItem_IHandler()
		{
			if (MaxAdPlacer.cb_insertItem_I == null)
			{
				MaxAdPlacer.cb_insertItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacer.n_InsertItem_I));
			}
			return MaxAdPlacer.cb_insertItem_I;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00015A23 File Offset: 0x00013C23
		private static void n_InsertItem_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InsertItem(p0);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00015A34 File Offset: 0x00013C34
		[Register("insertItem", "(I)V", "GetInsertItem_IHandler")]
		public unsafe virtual void InsertItem(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("insertItem.(I)V", this, ptr);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00015A6F File Offset: 0x00013C6F
		private static Delegate GetIsAdPosition_IHandler()
		{
			if (MaxAdPlacer.cb_isAdPosition_I == null)
			{
				MaxAdPlacer.cb_isAdPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(MaxAdPlacer.n_IsAdPosition_I));
			}
			return MaxAdPlacer.cb_isAdPosition_I;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00015A93 File Offset: 0x00013C93
		private static bool n_IsAdPosition_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAdPosition(p0);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00015AA4 File Offset: 0x00013CA4
		[Register("isAdPosition", "(I)Z", "GetIsAdPosition_IHandler")]
		public unsafe virtual bool IsAdPosition(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return MaxAdPlacer._members.InstanceMethods.InvokeVirtualBooleanMethod("isAdPosition.(I)Z", this, ptr);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00015ADF File Offset: 0x00013CDF
		private static Delegate GetIsFilledPosition_IHandler()
		{
			if (MaxAdPlacer.cb_isFilledPosition_I == null)
			{
				MaxAdPlacer.cb_isFilledPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(MaxAdPlacer.n_IsFilledPosition_I));
			}
			return MaxAdPlacer.cb_isFilledPosition_I;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00015B03 File Offset: 0x00013D03
		private static bool n_IsFilledPosition_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFilledPosition(p0);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00015B14 File Offset: 0x00013D14
		[Register("isFilledPosition", "(I)Z", "GetIsFilledPosition_IHandler")]
		public unsafe virtual bool IsFilledPosition(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return MaxAdPlacer._members.InstanceMethods.InvokeVirtualBooleanMethod("isFilledPosition.(I)Z", this, ptr);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00015B4F File Offset: 0x00013D4F
		private static Delegate GetLoadAdsHandler()
		{
			if (MaxAdPlacer.cb_loadAds == null)
			{
				MaxAdPlacer.cb_loadAds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdPlacer.n_LoadAds));
			}
			return MaxAdPlacer.cb_loadAds;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00015B73 File Offset: 0x00013D73
		private static void n_LoadAds(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadAds();
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00015B82 File Offset: 0x00013D82
		[Register("loadAds", "()V", "GetLoadAdsHandler")]
		public virtual void LoadAds()
		{
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("loadAds.()V", this, null);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00015B9B File Offset: 0x00013D9B
		private static Delegate GetMoveItem_IIHandler()
		{
			if (MaxAdPlacer.cb_moveItem_II == null)
			{
				MaxAdPlacer.cb_moveItem_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(MaxAdPlacer.n_MoveItem_II));
			}
			return MaxAdPlacer.cb_moveItem_II;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00015BBF File Offset: 0x00013DBF
		private static void n_MoveItem_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveItem(p0, p1);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[Register("moveItem", "(II)V", "GetMoveItem_IIHandler")]
		public unsafe virtual void MoveItem(int p0, int p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("moveItem.(II)V", this, ptr);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00015C1E File Offset: 0x00013E1E
		private static Delegate GetOnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MaxAdPlacer.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MaxAdPlacer.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdPlacer.n_OnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_));
			}
			return MaxAdPlacer.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00015C44 File Offset: 0x00013E44
		private static void n_OnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdPlacer @object = Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdRevenuePaid(object2);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00015C68 File Offset: 0x00013E68
		[Register("onAdRevenuePaid", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual void OnAdRevenuePaid(IMaxAd p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("onAdRevenuePaid.(Lcom/applovin/mediation/MaxAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00015CD0 File Offset: 0x00013ED0
		private static Delegate GetOnNativeAdClicked_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MaxAdPlacer.cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MaxAdPlacer.cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdPlacer.n_OnNativeAdClicked_Lcom_applovin_mediation_MaxAd_));
			}
			return MaxAdPlacer.cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00015CF4 File Offset: 0x00013EF4
		private static void n_OnNativeAdClicked_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdPlacer @object = Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdClicked(object2);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00015D18 File Offset: 0x00013F18
		[Register("onNativeAdClicked", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnNativeAdClicked_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual void OnNativeAdClicked(IMaxAd p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("onNativeAdClicked.(Lcom/applovin/mediation/MaxAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00015D80 File Offset: 0x00013F80
		private static Delegate GetOnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler()
		{
			if (MaxAdPlacer.cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ == null)
			{
				MaxAdPlacer.cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxAdPlacer.n_OnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_));
			}
			return MaxAdPlacer.cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00015DA4 File Offset: 0x00013FA4
		private static void n_OnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxAdPlacer @object = Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxError object2 = Java.Lang.Object.GetObject<IMaxError>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnNativeAdLoadFailed(@string, object2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00015DD0 File Offset: 0x00013FD0
		[Register("onNativeAdLoadFailed", "(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V", "GetOnNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_Handler")]
		public unsafe virtual void OnNativeAdLoadFailed(string p0, IMaxError p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("onNativeAdLoadFailed.(Ljava/lang/String;Lcom/applovin/mediation/MaxError;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00015E58 File Offset: 0x00014058
		private static Delegate GetOnNativeAdLoadedHandler()
		{
			if (MaxAdPlacer.cb_onNativeAdLoaded == null)
			{
				MaxAdPlacer.cb_onNativeAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdPlacer.n_OnNativeAdLoaded));
			}
			return MaxAdPlacer.cb_onNativeAdLoaded;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00015E7C File Offset: 0x0001407C
		private static void n_OnNativeAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNativeAdLoaded();
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00015E8B File Offset: 0x0001408B
		[Register("onNativeAdLoaded", "()V", "GetOnNativeAdLoadedHandler")]
		public virtual void OnNativeAdLoaded()
		{
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("onNativeAdLoaded.()V", this, null);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00015EA4 File Offset: 0x000140A4
		private static Delegate GetRemoveItem_IHandler()
		{
			if (MaxAdPlacer.cb_removeItem_I == null)
			{
				MaxAdPlacer.cb_removeItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacer.n_RemoveItem_I));
			}
			return MaxAdPlacer.cb_removeItem_I;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00015EC8 File Offset: 0x000140C8
		private static void n_RemoveItem_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveItem(p0);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00015ED8 File Offset: 0x000140D8
		[Register("removeItem", "(I)V", "GetRemoveItem_IHandler")]
		public unsafe virtual void RemoveItem(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("removeItem.(I)V", this, ptr);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00015F13 File Offset: 0x00014113
		private static Delegate GetRenderAd_ILandroid_view_ViewGroup_Handler()
		{
			if (MaxAdPlacer.cb_renderAd_ILandroid_view_ViewGroup_ == null)
			{
				MaxAdPlacer.cb_renderAd_ILandroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(MaxAdPlacer.n_RenderAd_ILandroid_view_ViewGroup_));
			}
			return MaxAdPlacer.cb_renderAd_ILandroid_view_ViewGroup_;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00015F38 File Offset: 0x00014138
		private static void n_RenderAd_ILandroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			MaxAdPlacer @object = Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.RenderAd(p0, object2);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00015F5C File Offset: 0x0001415C
		[Register("renderAd", "(ILandroid/view/ViewGroup;)V", "GetRenderAd_ILandroid_view_ViewGroup_Handler")]
		public unsafe virtual void RenderAd(int p0, ViewGroup p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("renderAd.(ILandroid/view/ViewGroup;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00015FD4 File Offset: 0x000141D4
		private static Delegate GetSetAdSize_IIHandler()
		{
			if (MaxAdPlacer.cb_setAdSize_II == null)
			{
				MaxAdPlacer.cb_setAdSize_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(MaxAdPlacer.n_SetAdSize_II));
			}
			return MaxAdPlacer.cb_setAdSize_II;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00015FF8 File Offset: 0x000141F8
		private static void n_SetAdSize_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAdSize(p0, p1);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001600C File Offset: 0x0001420C
		[Register("setAdSize", "(II)V", "GetSetAdSize_IIHandler")]
		public unsafe virtual void SetAdSize(int p0, int p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("setAdSize.(II)V", this, ptr);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001605A File Offset: 0x0001425A
		private static Delegate GetSetListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_Handler()
		{
			if (MaxAdPlacer.cb_setListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_ == null)
			{
				MaxAdPlacer.cb_setListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdPlacer.n_SetListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_));
			}
			return MaxAdPlacer.cb_setListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00016080 File Offset: 0x00014280
		private static void n_SetListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdPlacer @object = Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdPlacer.IListener object2 = Java.Lang.Object.GetObject<MaxAdPlacer.IListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetListener(object2);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000160A4 File Offset: 0x000142A4
		[Register("setListener", "(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer$Listener;)V", "GetSetListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_Handler")]
		public unsafe virtual void SetListener(MaxAdPlacer.IListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer$Listener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0001610C File Offset: 0x0001430C
		private static Delegate GetSetNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_Handler()
		{
			if (MaxAdPlacer.cb_setNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_ == null)
			{
				MaxAdPlacer.cb_setNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdPlacer.n_SetNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_));
			}
			return MaxAdPlacer.cb_setNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00016130 File Offset: 0x00014330
		private static void n_SetNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdPlacer @object = Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdViewBinder object2 = Java.Lang.Object.GetObject<MaxNativeAdViewBinder>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetNativeAdViewBinder(object2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00016154 File Offset: 0x00014354
		[Register("setNativeAdViewBinder", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;)V", "GetSetNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_Handler")]
		public unsafe virtual void SetNativeAdViewBinder(MaxNativeAdViewBinder p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("setNativeAdViewBinder.(Lcom/applovin/mediation/nativeAds/MaxNativeAdViewBinder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000161B8 File Offset: 0x000143B8
		private static Delegate GetUpdateFillablePositions_IIHandler()
		{
			if (MaxAdPlacer.cb_updateFillablePositions_II == null)
			{
				MaxAdPlacer.cb_updateFillablePositions_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(MaxAdPlacer.n_UpdateFillablePositions_II));
			}
			return MaxAdPlacer.cb_updateFillablePositions_II;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000161DC File Offset: 0x000143DC
		private static void n_UpdateFillablePositions_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<MaxAdPlacer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UpdateFillablePositions(p0, p1);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000161F0 File Offset: 0x000143F0
		[Register("updateFillablePositions", "(II)V", "GetUpdateFillablePositions_IIHandler")]
		public unsafe virtual void UpdateFillablePositions(int p0, int p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			MaxAdPlacer._members.InstanceMethods.InvokeVirtualVoidMethod("updateFillablePositions.(II)V", this, ptr);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0001623E File Offset: 0x0001443E
		private MaxAdPlacer.IListenerImplementor __CreateIListenerImplementor()
		{
			return new MaxAdPlacer.IListenerImplementor(this);
		}

		// Token: 0x040002AB RID: 683
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer", typeof(MaxAdPlacer));

		// Token: 0x040002AC RID: 684
		private static Delegate cb_clearAds;

		// Token: 0x040002AD RID: 685
		private static Delegate cb_destroy;

		// Token: 0x040002AE RID: 686
		private static Delegate cb_getAdItemId_I;

		// Token: 0x040002AF RID: 687
		private static Delegate cb_getAdSize_II;

		// Token: 0x040002B0 RID: 688
		private static Delegate cb_getAdjustedCount_I;

		// Token: 0x040002B1 RID: 689
		private static Delegate cb_getAdjustedPosition_I;

		// Token: 0x040002B2 RID: 690
		private static Delegate cb_getOriginalPosition_I;

		// Token: 0x040002B3 RID: 691
		private static Delegate cb_insertItem_I;

		// Token: 0x040002B4 RID: 692
		private static Delegate cb_isAdPosition_I;

		// Token: 0x040002B5 RID: 693
		private static Delegate cb_isFilledPosition_I;

		// Token: 0x040002B6 RID: 694
		private static Delegate cb_loadAds;

		// Token: 0x040002B7 RID: 695
		private static Delegate cb_moveItem_II;

		// Token: 0x040002B8 RID: 696
		private static Delegate cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040002B9 RID: 697
		private static Delegate cb_onNativeAdClicked_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040002BA RID: 698
		private static Delegate cb_onNativeAdLoadFailed_Ljava_lang_String_Lcom_applovin_mediation_MaxError_;

		// Token: 0x040002BB RID: 699
		private static Delegate cb_onNativeAdLoaded;

		// Token: 0x040002BC RID: 700
		private static Delegate cb_removeItem_I;

		// Token: 0x040002BD RID: 701
		private static Delegate cb_renderAd_ILandroid_view_ViewGroup_;

		// Token: 0x040002BE RID: 702
		private static Delegate cb_setAdSize_II;

		// Token: 0x040002BF RID: 703
		private static Delegate cb_setListener_Lcom_applovin_mediation_nativeAds_adPlacer_MaxAdPlacer_Listener_;

		// Token: 0x040002C0 RID: 704
		private static Delegate cb_setNativeAdViewBinder_Lcom_applovin_mediation_nativeAds_MaxNativeAdViewBinder_;

		// Token: 0x040002C1 RID: 705
		private static Delegate cb_updateFillablePositions_II;

		// Token: 0x020000D6 RID: 214
		[Register("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer$Listener", "", "Com.Applovin.Mediation.NativeAds.AdPlacer.MaxAdPlacer/IListenerInvoker")]
		public interface IListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600086E RID: 2158
			[Register("onAdClicked", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdClicked_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.NativeAds.AdPlacer.MaxAdPlacer/IListenerInvoker, AppLovin")]
			void OnAdClicked(IMaxAd p0);

			// Token: 0x0600086F RID: 2159
			[Register("onAdLoaded", "(I)V", "GetOnAdLoaded_IHandler:Com.Applovin.Mediation.NativeAds.AdPlacer.MaxAdPlacer/IListenerInvoker, AppLovin")]
			void OnAdLoaded(int p0);

			// Token: 0x06000870 RID: 2160
			[Register("onAdRemoved", "(I)V", "GetOnAdRemoved_IHandler:Com.Applovin.Mediation.NativeAds.AdPlacer.MaxAdPlacer/IListenerInvoker, AppLovin")]
			void OnAdRemoved(int p0);

			// Token: 0x06000871 RID: 2161
			[Register("onAdRevenuePaid", "(Lcom/applovin/mediation/MaxAd;)V", "GetOnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_Handler:Com.Applovin.Mediation.NativeAds.AdPlacer.MaxAdPlacer/IListenerInvoker, AppLovin")]
			void OnAdRevenuePaid(IMaxAd p0);
		}

		// Token: 0x020000D7 RID: 215
		[Register("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer$Listener", DoNotGenerateAcw = true)]
		internal class IListenerInvoker : Java.Lang.Object, MaxAdPlacer.IListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000872 RID: 2162 RVA: 0x00016264 File Offset: 0x00014464
			private static IntPtr java_class_ref
			{
				get
				{
					return MaxAdPlacer.IListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000873 RID: 2163 RVA: 0x00016288 File Offset: 0x00014488
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MaxAdPlacer.IListenerInvoker._members;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000874 RID: 2164 RVA: 0x0001628F File Offset: 0x0001448F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000875 RID: 2165 RVA: 0x00016297 File Offset: 0x00014497
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MaxAdPlacer.IListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x000162A3 File Offset: 0x000144A3
			public static MaxAdPlacer.IListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<MaxAdPlacer.IListener>(handle, transfer);
			}

			// Token: 0x06000877 RID: 2167 RVA: 0x000162AC File Offset: 0x000144AC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, MaxAdPlacer.IListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.nativeAds.adPlacer.MaxAdPlacer.Listener'.");
				}
				return handle;
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x000162D7 File Offset: 0x000144D7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x00016308 File Offset: 0x00014508
			public IListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(MaxAdPlacer.IListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x00016340 File Offset: 0x00014540
			private static Delegate GetOnAdClicked_Lcom_applovin_mediation_MaxAd_Handler()
			{
				if (MaxAdPlacer.IListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ == null)
				{
					MaxAdPlacer.IListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdPlacer.IListenerInvoker.n_OnAdClicked_Lcom_applovin_mediation_MaxAd_));
				}
				return MaxAdPlacer.IListenerInvoker.cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x00016364 File Offset: 0x00014564
			private static void n_OnAdClicked_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxAdPlacer.IListener @object = Java.Lang.Object.GetObject<MaxAdPlacer.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnAdClicked(object2);
			}

			// Token: 0x0600087C RID: 2172 RVA: 0x00016388 File Offset: 0x00014588
			public unsafe void OnAdClicked(IMaxAd p0)
			{
				if (this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
				{
					this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdClicked", "(Lcom/applovin/mediation/MaxAd;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClicked_Lcom_applovin_mediation_MaxAd_, ptr);
			}

			// Token: 0x0600087D RID: 2173 RVA: 0x00016400 File Offset: 0x00014600
			private static Delegate GetOnAdLoaded_IHandler()
			{
				if (MaxAdPlacer.IListenerInvoker.cb_onAdLoaded_I == null)
				{
					MaxAdPlacer.IListenerInvoker.cb_onAdLoaded_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacer.IListenerInvoker.n_OnAdLoaded_I));
				}
				return MaxAdPlacer.IListenerInvoker.cb_onAdLoaded_I;
			}

			// Token: 0x0600087E RID: 2174 RVA: 0x00016424 File Offset: 0x00014624
			private static void n_OnAdLoaded_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				Java.Lang.Object.GetObject<MaxAdPlacer.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLoaded(p0);
			}

			// Token: 0x0600087F RID: 2175 RVA: 0x00016434 File Offset: 0x00014634
			public unsafe void OnAdLoaded(int p0)
			{
				if (this.id_onAdLoaded_I == IntPtr.Zero)
				{
					this.id_onAdLoaded_I = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded_I, ptr);
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x00016498 File Offset: 0x00014698
			private static Delegate GetOnAdRemoved_IHandler()
			{
				if (MaxAdPlacer.IListenerInvoker.cb_onAdRemoved_I == null)
				{
					MaxAdPlacer.IListenerInvoker.cb_onAdRemoved_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaxAdPlacer.IListenerInvoker.n_OnAdRemoved_I));
				}
				return MaxAdPlacer.IListenerInvoker.cb_onAdRemoved_I;
			}

			// Token: 0x06000881 RID: 2177 RVA: 0x000164BC File Offset: 0x000146BC
			private static void n_OnAdRemoved_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				Java.Lang.Object.GetObject<MaxAdPlacer.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdRemoved(p0);
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x000164CC File Offset: 0x000146CC
			public unsafe void OnAdRemoved(int p0)
			{
				if (this.id_onAdRemoved_I == IntPtr.Zero)
				{
					this.id_onAdRemoved_I = JNIEnv.GetMethodID(this.class_ref, "onAdRemoved", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAdRemoved_I, ptr);
			}

			// Token: 0x06000883 RID: 2179 RVA: 0x00016530 File Offset: 0x00014730
			private static Delegate GetOnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_Handler()
			{
				if (MaxAdPlacer.IListenerInvoker.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ == null)
				{
					MaxAdPlacer.IListenerInvoker.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdPlacer.IListenerInvoker.n_OnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_));
				}
				return MaxAdPlacer.IListenerInvoker.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;
			}

			// Token: 0x06000884 RID: 2180 RVA: 0x00016554 File Offset: 0x00014754
			private static void n_OnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MaxAdPlacer.IListener @object = Java.Lang.Object.GetObject<MaxAdPlacer.IListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnAdRevenuePaid(object2);
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x00016578 File Offset: 0x00014778
			public unsafe void OnAdRevenuePaid(IMaxAd p0)
			{
				if (this.id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
				{
					this.id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdRevenuePaid", "(Lcom/applovin/mediation/MaxAd;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_, ptr);
			}

			// Token: 0x040002C2 RID: 706
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer$Listener", typeof(MaxAdPlacer.IListenerInvoker));

			// Token: 0x040002C3 RID: 707
			private IntPtr class_ref;

			// Token: 0x040002C4 RID: 708
			private static Delegate cb_onAdClicked_Lcom_applovin_mediation_MaxAd_;

			// Token: 0x040002C5 RID: 709
			private IntPtr id_onAdClicked_Lcom_applovin_mediation_MaxAd_;

			// Token: 0x040002C6 RID: 710
			private static Delegate cb_onAdLoaded_I;

			// Token: 0x040002C7 RID: 711
			private IntPtr id_onAdLoaded_I;

			// Token: 0x040002C8 RID: 712
			private static Delegate cb_onAdRemoved_I;

			// Token: 0x040002C9 RID: 713
			private IntPtr id_onAdRemoved_I;

			// Token: 0x040002CA RID: 714
			private static Delegate cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;

			// Token: 0x040002CB RID: 715
			private IntPtr id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x020000D8 RID: 216
		public class AdClickedEventArgs : EventArgs
		{
			// Token: 0x06000887 RID: 2183 RVA: 0x0001660B File Offset: 0x0001480B
			public AdClickedEventArgs(IMaxAd p0)
			{
				this.p0 = p0;
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000888 RID: 2184 RVA: 0x0001661A File Offset: 0x0001481A
			public IMaxAd P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x040002CC RID: 716
			private IMaxAd p0;
		}

		// Token: 0x020000D9 RID: 217
		public class AdLoadedEventArgs : EventArgs
		{
			// Token: 0x06000889 RID: 2185 RVA: 0x00016622 File Offset: 0x00014822
			public AdLoadedEventArgs(int p0)
			{
				this.p0 = p0;
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x0600088A RID: 2186 RVA: 0x00016631 File Offset: 0x00014831
			public int P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x040002CD RID: 717
			private int p0;
		}

		// Token: 0x020000DA RID: 218
		public class AdRemovedEventArgs : EventArgs
		{
			// Token: 0x0600088B RID: 2187 RVA: 0x00016639 File Offset: 0x00014839
			public AdRemovedEventArgs(int p0)
			{
				this.p0 = p0;
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x00016648 File Offset: 0x00014848
			public int P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x040002CE RID: 718
			private int p0;
		}

		// Token: 0x020000DB RID: 219
		public class AdRevenuePaidEventArgs : EventArgs
		{
			// Token: 0x0600088D RID: 2189 RVA: 0x00016650 File Offset: 0x00014850
			public AdRevenuePaidEventArgs(IMaxAd p0)
			{
				this.p0 = p0;
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x0600088E RID: 2190 RVA: 0x0001665F File Offset: 0x0001485F
			public IMaxAd P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x040002CF RID: 719
			private IMaxAd p0;
		}

		// Token: 0x020000DC RID: 220
		[Register("mono/com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer_ListenerImplementor")]
		internal sealed class IListenerImplementor : Java.Lang.Object, MaxAdPlacer.IListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600088F RID: 2191 RVA: 0x00016667 File Offset: 0x00014867
			public IListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/nativeAds/adPlacer/MaxAdPlacer_ListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000890 RID: 2192 RVA: 0x000166A0 File Offset: 0x000148A0
			public void OnAdClicked(IMaxAd p0)
			{
				EventHandler<MaxAdPlacer.AdClickedEventArgs> onAdClickedHandler = this.OnAdClickedHandler;
				if (onAdClickedHandler != null)
				{
					onAdClickedHandler(this.sender, new MaxAdPlacer.AdClickedEventArgs(p0));
				}
			}

			// Token: 0x06000891 RID: 2193 RVA: 0x000166CC File Offset: 0x000148CC
			public void OnAdLoaded(int p0)
			{
				EventHandler<MaxAdPlacer.AdLoadedEventArgs> onAdLoadedHandler = this.OnAdLoadedHandler;
				if (onAdLoadedHandler != null)
				{
					onAdLoadedHandler(this.sender, new MaxAdPlacer.AdLoadedEventArgs(p0));
				}
			}

			// Token: 0x06000892 RID: 2194 RVA: 0x000166F8 File Offset: 0x000148F8
			public void OnAdRemoved(int p0)
			{
				EventHandler<MaxAdPlacer.AdRemovedEventArgs> onAdRemovedHandler = this.OnAdRemovedHandler;
				if (onAdRemovedHandler != null)
				{
					onAdRemovedHandler(this.sender, new MaxAdPlacer.AdRemovedEventArgs(p0));
				}
			}

			// Token: 0x06000893 RID: 2195 RVA: 0x00016724 File Offset: 0x00014924
			public void OnAdRevenuePaid(IMaxAd p0)
			{
				EventHandler<MaxAdPlacer.AdRevenuePaidEventArgs> onAdRevenuePaidHandler = this.OnAdRevenuePaidHandler;
				if (onAdRevenuePaidHandler != null)
				{
					onAdRevenuePaidHandler(this.sender, new MaxAdPlacer.AdRevenuePaidEventArgs(p0));
				}
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x0001674D File Offset: 0x0001494D
			internal static bool __IsEmpty(MaxAdPlacer.IListenerImplementor value)
			{
				return value.OnAdClickedHandler == null && value.OnAdLoadedHandler == null && value.OnAdRemovedHandler == null && value.OnAdRevenuePaidHandler == null;
			}

			// Token: 0x040002D0 RID: 720
			private object sender;

			// Token: 0x040002D1 RID: 721
			public EventHandler<MaxAdPlacer.AdClickedEventArgs> OnAdClickedHandler;

			// Token: 0x040002D2 RID: 722
			public EventHandler<MaxAdPlacer.AdLoadedEventArgs> OnAdLoadedHandler;

			// Token: 0x040002D3 RID: 723
			public EventHandler<MaxAdPlacer.AdRemovedEventArgs> OnAdRemovedHandler;

			// Token: 0x040002D4 RID: 724
			public EventHandler<MaxAdPlacer.AdRevenuePaidEventArgs> OnAdRevenuePaidHandler;
		}
	}
}
