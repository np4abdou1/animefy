using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.NativeAds
{
	// Token: 0x020000CF RID: 207
	[Register("com/applovin/mediation/nativeAds/MaxNativeAdLoader", DoNotGenerateAcw = true)]
	public class MaxNativeAdLoader : Java.Lang.Object
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00013370 File Offset: 0x00011570
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNativeAdLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00013394 File Offset: 0x00011594
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNativeAdLoader._members;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001339C File Offset: 0x0001159C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNativeAdLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x000133C0 File Offset: 0x000115C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNativeAdLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxNativeAdLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000133CC File Offset: 0x000115CC
		[Register(".ctor", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe MaxNativeAdLoader(string p0, Context p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxNativeAdLoader._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdLoader._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00013498 File Offset: 0x00011698
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", "")]
		public unsafe MaxNativeAdLoader(string p0, AppLovinSdk p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				base.SetHandle(MaxNativeAdLoader._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNativeAdLoader._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00013590 File Offset: 0x00011790
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (MaxNativeAdLoader.cb_getAdUnitId == null)
			{
				MaxNativeAdLoader.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdLoader.n_GetAdUnitId));
			}
			return MaxNativeAdLoader.cb_getAdUnitId;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000135B4 File Offset: 0x000117B4
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000135C8 File Offset: 0x000117C8
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000135FA File Offset: 0x000117FA
		private static Delegate GetGetPlacementHandler()
		{
			if (MaxNativeAdLoader.cb_getPlacement == null)
			{
				MaxNativeAdLoader.cb_getPlacement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNativeAdLoader.n_GetPlacement));
			}
			return MaxNativeAdLoader.cb_getPlacement;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001361E File Offset: 0x0001181E
		private static IntPtr n_GetPlacement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Placement);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00013632 File Offset: 0x00011832
		private static Delegate GetSetPlacement_Ljava_lang_String_Handler()
		{
			if (MaxNativeAdLoader.cb_setPlacement_Ljava_lang_String_ == null)
			{
				MaxNativeAdLoader.cb_setPlacement_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdLoader.n_SetPlacement_Ljava_lang_String_));
			}
			return MaxNativeAdLoader.cb_setPlacement_Ljava_lang_String_;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00013658 File Offset: 0x00011858
		private static void n_SetPlacement_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Placement = @string;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0001367C File Offset: 0x0001187C
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x000136B0 File Offset: 0x000118B0
		public unsafe virtual string Placement
		{
			[Register("getPlacement", "()Ljava/lang/String;", "GetGetPlacementHandler")]
			get
			{
				return JNIEnv.GetString(MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualObjectMethod("getPlacement.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPlacement", "(Ljava/lang/String;)V", "GetSetPlacement_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("setPlacement.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001370C File Offset: 0x0001190C
		private static Delegate GetDestroyHandler()
		{
			if (MaxNativeAdLoader.cb_destroy == null)
			{
				MaxNativeAdLoader.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxNativeAdLoader.n_Destroy));
			}
			return MaxNativeAdLoader.cb_destroy;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00013730 File Offset: 0x00011930
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001373F File Offset: 0x0001193F
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00013758 File Offset: 0x00011958
		private static Delegate GetDestroy_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MaxNativeAdLoader.cb_destroy_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MaxNativeAdLoader.cb_destroy_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdLoader.n_Destroy_Lcom_applovin_mediation_MaxAd_));
			}
			return MaxNativeAdLoader.cb_destroy_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001377C File Offset: 0x0001197C
		private static void n_Destroy_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Destroy(object2);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000137A0 File Offset: 0x000119A0
		[Register("destroy", "(Lcom/applovin/mediation/MaxAd;)V", "GetDestroy_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual void Destroy(IMaxAd p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.(Lcom/applovin/mediation/MaxAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00013808 File Offset: 0x00011A08
		private static Delegate GetLoadAdHandler()
		{
			if (MaxNativeAdLoader.cb_loadAd == null)
			{
				MaxNativeAdLoader.cb_loadAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxNativeAdLoader.n_LoadAd));
			}
			return MaxNativeAdLoader.cb_loadAd;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001382C File Offset: 0x00011A2C
		private static void n_LoadAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadAd();
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001383B File Offset: 0x00011A3B
		[Register("loadAd", "()V", "GetLoadAdHandler")]
		public virtual void LoadAd()
		{
			MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.()V", this, null);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00013854 File Offset: 0x00011A54
		private static Delegate GetLoadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Handler()
		{
			if (MaxNativeAdLoader.cb_loadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_ == null)
			{
				MaxNativeAdLoader.cb_loadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdLoader.n_LoadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_));
			}
			return MaxNativeAdLoader.cb_loadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00013878 File Offset: 0x00011A78
		private static void n_LoadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdView object2 = Java.Lang.Object.GetObject<MaxNativeAdView>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.LoadAd(object2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001389C File Offset: 0x00011A9C
		[Register("loadAd", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;)V", "GetLoadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Handler")]
		public unsafe virtual void LoadAd(MaxNativeAdView p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00013900 File Offset: 0x00011B00
		private static Delegate GetRender_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MaxNativeAdLoader.cb_render_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MaxNativeAdLoader.cb_render_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(MaxNativeAdLoader.n_Render_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_));
			}
			return MaxNativeAdLoader.cb_render_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00013924 File Offset: 0x00011B24
		private static bool n_Render_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdView object2 = Java.Lang.Object.GetObject<MaxNativeAdView>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMaxAd object3 = Java.Lang.Object.GetObject<IMaxAd>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.Render(object2, object3);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00013950 File Offset: 0x00011B50
		[Register("render", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;Lcom/applovin/mediation/MaxAd;)Z", "GetRender_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual bool Render(MaxNativeAdView p0, IMaxAd p1)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				result = MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("render.(Lcom/applovin/mediation/nativeAds/MaxNativeAdView;Lcom/applovin/mediation/MaxAd;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000139E4 File Offset: 0x00011BE4
		private static Delegate GetSetCustomData_Ljava_lang_String_Handler()
		{
			if (MaxNativeAdLoader.cb_setCustomData_Ljava_lang_String_ == null)
			{
				MaxNativeAdLoader.cb_setCustomData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdLoader.n_SetCustomData_Ljava_lang_String_));
			}
			return MaxNativeAdLoader.cb_setCustomData_Ljava_lang_String_;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00013A08 File Offset: 0x00011C08
		private static void n_SetCustomData_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetCustomData(@string);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00013A2C File Offset: 0x00011C2C
		[Register("setCustomData", "(Ljava/lang/String;)V", "GetSetCustomData_Ljava_lang_String_Handler")]
		public unsafe virtual void SetCustomData(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("setCustomData.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00013A88 File Offset: 0x00011C88
		private static Delegate GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxNativeAdLoader.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxNativeAdLoader.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxNativeAdLoader.n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxNativeAdLoader.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00013AAC File Offset: 0x00011CAC
		private static void n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetExtraParameter(@string, string2);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00013AD8 File Offset: 0x00011CD8
		[Register("setExtraParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void SetExtraParameter(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraParameter.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00013B54 File Offset: 0x00011D54
		private static Delegate GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (MaxNativeAdLoader.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				MaxNativeAdLoader.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxNativeAdLoader.n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_));
			}
			return MaxNativeAdLoader.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00013B78 File Offset: 0x00011D78
		private static void n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetLocalExtraParameter(@string, object2);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00013BA4 File Offset: 0x00011DA4
		[Register("setLocalExtraParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetLocalExtraParameter(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("setLocalExtraParameter.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00013C28 File Offset: 0x00011E28
		private static Delegate GetSetNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_Handler()
		{
			if (MaxNativeAdLoader.cb_setNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_ == null)
			{
				MaxNativeAdLoader.cb_setNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdLoader.n_SetNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_));
			}
			return MaxNativeAdLoader.cb_setNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00013C4C File Offset: 0x00011E4C
		private static void n_SetNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxNativeAdListener object2 = Java.Lang.Object.GetObject<MaxNativeAdListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetNativeAdListener(object2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00013C70 File Offset: 0x00011E70
		[Register("setNativeAdListener", "(Lcom/applovin/mediation/nativeAds/MaxNativeAdListener;)V", "GetSetNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_Handler")]
		public unsafe virtual void SetNativeAdListener(MaxNativeAdListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("setNativeAdListener.(Lcom/applovin/mediation/nativeAds/MaxNativeAdListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00013CD4 File Offset: 0x00011ED4
		private static Delegate GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler()
		{
			if (MaxNativeAdLoader.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ == null)
			{
				MaxNativeAdLoader.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxNativeAdLoader.n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_));
			}
			return MaxNativeAdLoader.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00013CF8 File Offset: 0x00011EF8
		private static void n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxNativeAdLoader @object = Java.Lang.Object.GetObject<MaxNativeAdLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdRevenueListener object2 = Java.Lang.Object.GetObject<IMaxAdRevenueListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetRevenueListener(object2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00013D1C File Offset: 0x00011F1C
		[Register("setRevenueListener", "(Lcom/applovin/mediation/MaxAdRevenueListener;)V", "GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler")]
		public unsafe virtual void SetRevenueListener(IMaxAdRevenueListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxNativeAdLoader._members.InstanceMethods.InvokeVirtualVoidMethod("setRevenueListener.(Lcom/applovin/mediation/MaxAdRevenueListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600079E RID: 1950 RVA: 0x00013D84 File Offset: 0x00011F84
		// (remove) Token: 0x0600079F RID: 1951 RVA: 0x00013DD0 File Offset: 0x00011FD0
		public event EventHandler<MaxAdRevenueEventArgs> Revenue
		{
			add
			{
				EventHelper.AddEventHandler<IMaxAdRevenueListener, IMaxAdRevenueListenerImplementor>(ref this.weak_implementor_SetRevenueListener, new Func<IMaxAdRevenueListenerImplementor>(this.__CreateIMaxAdRevenueListenerImplementor), new Action<IMaxAdRevenueListener>(this.SetRevenueListener), delegate(IMaxAdRevenueListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdRevenueEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IMaxAdRevenueListener, IMaxAdRevenueListenerImplementor>(ref this.weak_implementor_SetRevenueListener, new Func<IMaxAdRevenueListenerImplementor, bool>(IMaxAdRevenueListenerImplementor.__IsEmpty), delegate(IMaxAdRevenueListener __v)
				{
					this.SetRevenueListener(null);
				}, delegate(IMaxAdRevenueListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdRevenueEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00013E20 File Offset: 0x00012020
		private IMaxAdRevenueListenerImplementor __CreateIMaxAdRevenueListenerImplementor()
		{
			return new IMaxAdRevenueListenerImplementor(this);
		}

		// Token: 0x0400027E RID: 638
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAdLoader", typeof(MaxNativeAdLoader));

		// Token: 0x0400027F RID: 639
		private static Delegate cb_getAdUnitId;

		// Token: 0x04000280 RID: 640
		private static Delegate cb_getPlacement;

		// Token: 0x04000281 RID: 641
		private static Delegate cb_setPlacement_Ljava_lang_String_;

		// Token: 0x04000282 RID: 642
		private static Delegate cb_destroy;

		// Token: 0x04000283 RID: 643
		private static Delegate cb_destroy_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000284 RID: 644
		private static Delegate cb_loadAd;

		// Token: 0x04000285 RID: 645
		private static Delegate cb_loadAd_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_;

		// Token: 0x04000286 RID: 646
		private static Delegate cb_render_Lcom_applovin_mediation_nativeAds_MaxNativeAdView_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x04000287 RID: 647
		private static Delegate cb_setCustomData_Ljava_lang_String_;

		// Token: 0x04000288 RID: 648
		private static Delegate cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000289 RID: 649
		private static Delegate cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x0400028A RID: 650
		private static Delegate cb_setNativeAdListener_Lcom_applovin_mediation_nativeAds_MaxNativeAdListener_;

		// Token: 0x0400028B RID: 651
		private static Delegate cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;

		// Token: 0x0400028C RID: 652
		private WeakReference weak_implementor_SetRevenueListener;
	}
}
