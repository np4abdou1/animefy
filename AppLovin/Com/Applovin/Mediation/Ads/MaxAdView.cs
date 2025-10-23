using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Ads
{
	// Token: 0x020000DE RID: 222
	[Register("com/applovin/mediation/ads/MaxAdView", DoNotGenerateAcw = true)]
	public class MaxAdView : RelativeLayout
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00016CF0 File Offset: 0x00014EF0
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00016D14 File Offset: 0x00014F14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdView._members;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00016D1C File Offset: 0x00014F1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00016D40 File Offset: 0x00014F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdView._members.ManagedPeerType;
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00016D4C File Offset: 0x00014F4C
		protected MaxAdView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00016D58 File Offset: 0x00014F58
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MaxAdView(Context p0, IAttributeSet p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				base.SetHandle(MaxAdView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00016E34 File Offset: 0x00015034
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MaxAdView(Context p0, IAttributeSet p1, int p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue(p2);
				base.SetHandle(MaxAdView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00016F24 File Offset: 0x00015124
		[Register(".ctor", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe MaxAdView(string p0, Context p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxAdView._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdView._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00016FF0 File Offset: 0x000151F0
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/mediation/MaxAdFormat;Landroid/content/Context;)V", "")]
		public unsafe MaxAdView(string p0, MaxAdFormat p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxAdView._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/mediation/MaxAdFormat;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdView._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/mediation/MaxAdFormat;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000170E8 File Offset: 0x000152E8
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/mediation/MaxAdFormat;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", "")]
		public unsafe MaxAdView(string p0, MaxAdFormat p1, AppLovinSdk p2, Context p3) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				base.SetHandle(MaxAdView._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/mediation/MaxAdFormat;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdView._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/mediation/MaxAdFormat;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00017210 File Offset: 0x00015410
		[Register(".ctor", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", "")]
		public unsafe MaxAdView(string p0, AppLovinSdk p1, Context p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MaxAdView._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxAdView._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00017308 File Offset: 0x00015508
		private static Delegate GetGetAdFormatHandler()
		{
			if (MaxAdView.cb_getAdFormat == null)
			{
				MaxAdView.cb_getAdFormat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdView.n_GetAdFormat));
			}
			return MaxAdView.cb_getAdFormat;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001732C File Offset: 0x0001552C
		private static IntPtr n_GetAdFormat(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdFormat);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00017340 File Offset: 0x00015540
		public virtual MaxAdFormat AdFormat
		{
			[Register("getAdFormat", "()Lcom/applovin/mediation/MaxAdFormat;", "GetGetAdFormatHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(MaxAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getAdFormat.()Lcom/applovin/mediation/MaxAdFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00017372 File Offset: 0x00015572
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (MaxAdView.cb_getAdUnitId == null)
			{
				MaxAdView.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdView.n_GetAdUnitId));
			}
			return MaxAdView.cb_getAdUnitId;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00017396 File Offset: 0x00015596
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000173AC File Offset: 0x000155AC
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000173DE File Offset: 0x000155DE
		private static Delegate GetGetPlacementHandler()
		{
			if (MaxAdView.cb_getPlacement == null)
			{
				MaxAdView.cb_getPlacement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdView.n_GetPlacement));
			}
			return MaxAdView.cb_getPlacement;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00017402 File Offset: 0x00015602
		private static IntPtr n_GetPlacement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Placement);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00017416 File Offset: 0x00015616
		private static Delegate GetSetPlacement_Ljava_lang_String_Handler()
		{
			if (MaxAdView.cb_setPlacement_Ljava_lang_String_ == null)
			{
				MaxAdView.cb_setPlacement_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdView.n_SetPlacement_Ljava_lang_String_));
			}
			return MaxAdView.cb_setPlacement_Ljava_lang_String_;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001743C File Offset: 0x0001563C
		private static void n_SetPlacement_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Placement = @string;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00017460 File Offset: 0x00015660
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00017494 File Offset: 0x00015694
		public unsafe virtual string Placement
		{
			[Register("getPlacement", "()Ljava/lang/String;", "GetGetPlacementHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdView._members.InstanceMethods.InvokeVirtualObjectMethod("getPlacement.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPlacement", "(Ljava/lang/String;)V", "GetSetPlacement_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setPlacement.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000174F0 File Offset: 0x000156F0
		private static Delegate GetDestroyHandler()
		{
			if (MaxAdView.cb_destroy == null)
			{
				MaxAdView.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdView.n_Destroy));
			}
			return MaxAdView.cb_destroy;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00017514 File Offset: 0x00015714
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00017523 File Offset: 0x00015723
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0001753C File Offset: 0x0001573C
		private static Delegate GetLoadAdHandler()
		{
			if (MaxAdView.cb_loadAd == null)
			{
				MaxAdView.cb_loadAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdView.n_LoadAd));
			}
			return MaxAdView.cb_loadAd;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00017560 File Offset: 0x00015760
		private static void n_LoadAd(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadAd();
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0001756F File Offset: 0x0001576F
		[Register("loadAd", "()V", "GetLoadAdHandler")]
		public virtual void LoadAd()
		{
			MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("loadAd.()V", this, null);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00017588 File Offset: 0x00015788
		private static Delegate GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler()
		{
			if (MaxAdView.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ == null)
			{
				MaxAdView.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdView.n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_));
			}
			return MaxAdView.cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000175AC File Offset: 0x000157AC
		private static void n_SetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdReviewListener object2 = Java.Lang.Object.GetObject<IMaxAdReviewListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdReviewListener(object2);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000175D0 File Offset: 0x000157D0
		[Register("setAdReviewListener", "(Lcom/applovin/mediation/MaxAdReviewListener;)V", "GetSetAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_Handler")]
		public unsafe virtual void SetAdReviewListener(IMaxAdReviewListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdReviewListener.(Lcom/applovin/mediation/MaxAdReviewListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00017638 File Offset: 0x00015838
		private static Delegate GetSetCustomData_Ljava_lang_String_Handler()
		{
			if (MaxAdView.cb_setCustomData_Ljava_lang_String_ == null)
			{
				MaxAdView.cb_setCustomData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdView.n_SetCustomData_Ljava_lang_String_));
			}
			return MaxAdView.cb_setCustomData_Ljava_lang_String_;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001765C File Offset: 0x0001585C
		private static void n_SetCustomData_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetCustomData(@string);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00017680 File Offset: 0x00015880
		[Register("setCustomData", "(Ljava/lang/String;)V", "GetSetCustomData_Ljava_lang_String_Handler")]
		public unsafe virtual void SetCustomData(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setCustomData.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000176DC File Offset: 0x000158DC
		private static Delegate GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (MaxAdView.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				MaxAdView.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxAdView.n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_));
			}
			return MaxAdView.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00017700 File Offset: 0x00015900
		private static void n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetExtraParameter(@string, string2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001772C File Offset: 0x0001592C
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
				MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraParameter.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000177A8 File Offset: 0x000159A8
		private static Delegate GetSetListener_Lcom_applovin_mediation_MaxAdViewAdListener_Handler()
		{
			if (MaxAdView.cb_setListener_Lcom_applovin_mediation_MaxAdViewAdListener_ == null)
			{
				MaxAdView.cb_setListener_Lcom_applovin_mediation_MaxAdViewAdListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdView.n_SetListener_Lcom_applovin_mediation_MaxAdViewAdListener_));
			}
			return MaxAdView.cb_setListener_Lcom_applovin_mediation_MaxAdViewAdListener_;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000177CC File Offset: 0x000159CC
		private static void n_SetListener_Lcom_applovin_mediation_MaxAdViewAdListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdViewAdListener object2 = Java.Lang.Object.GetObject<IMaxAdViewAdListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetListener(object2);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000177F0 File Offset: 0x000159F0
		[Register("setListener", "(Lcom/applovin/mediation/MaxAdViewAdListener;)V", "GetSetListener_Lcom_applovin_mediation_MaxAdViewAdListener_Handler")]
		public unsafe virtual void SetListener(IMaxAdViewAdListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/applovin/mediation/MaxAdViewAdListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00017858 File Offset: 0x00015A58
		private static Delegate GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (MaxAdView.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				MaxAdView.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MaxAdView.n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_));
			}
			return MaxAdView.cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001787C File Offset: 0x00015A7C
		private static void n_SetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetLocalExtraParameter(@string, object2);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000178A8 File Offset: 0x00015AA8
		[Register("setLocalExtraParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetLocalExtraParameter(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setLocalExtraParameter.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0001792C File Offset: 0x00015B2C
		private static Delegate GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler()
		{
			if (MaxAdView.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ == null)
			{
				MaxAdView.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxAdView.n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_));
			}
			return MaxAdView.cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00017950 File Offset: 0x00015B50
		private static void n_SetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxAdView @object = Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdRevenueListener object2 = Java.Lang.Object.GetObject<IMaxAdRevenueListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetRevenueListener(object2);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00017974 File Offset: 0x00015B74
		[Register("setRevenueListener", "(Lcom/applovin/mediation/MaxAdRevenueListener;)V", "GetSetRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_Handler")]
		public unsafe virtual void SetRevenueListener(IMaxAdRevenueListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("setRevenueListener.(Lcom/applovin/mediation/MaxAdRevenueListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000179DC File Offset: 0x00015BDC
		private static Delegate GetStartAutoRefreshHandler()
		{
			if (MaxAdView.cb_startAutoRefresh == null)
			{
				MaxAdView.cb_startAutoRefresh = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdView.n_StartAutoRefresh));
			}
			return MaxAdView.cb_startAutoRefresh;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00017A00 File Offset: 0x00015C00
		private static void n_StartAutoRefresh(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartAutoRefresh();
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00017A0F File Offset: 0x00015C0F
		[Register("startAutoRefresh", "()V", "GetStartAutoRefreshHandler")]
		public virtual void StartAutoRefresh()
		{
			MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("startAutoRefresh.()V", this, null);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00017A28 File Offset: 0x00015C28
		private static Delegate GetStopAutoRefreshHandler()
		{
			if (MaxAdView.cb_stopAutoRefresh == null)
			{
				MaxAdView.cb_stopAutoRefresh = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaxAdView.n_StopAutoRefresh));
			}
			return MaxAdView.cb_stopAutoRefresh;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00017A4C File Offset: 0x00015C4C
		private static void n_StopAutoRefresh(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaxAdView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopAutoRefresh();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00017A5B File Offset: 0x00015C5B
		[Register("stopAutoRefresh", "()V", "GetStopAutoRefreshHandler")]
		public virtual void StopAutoRefresh()
		{
			MaxAdView._members.InstanceMethods.InvokeVirtualVoidMethod("stopAutoRefresh.()V", this, null);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060008F5 RID: 2293 RVA: 0x00017A74 File Offset: 0x00015C74
		// (remove) Token: 0x060008F6 RID: 2294 RVA: 0x00017AC0 File Offset: 0x00015CC0
		public event EventHandler<MaxAdReviewEventArgs> AdReview
		{
			add
			{
				EventHelper.AddEventHandler<IMaxAdReviewListener, IMaxAdReviewListenerImplementor>(ref this.weak_implementor_SetAdReviewListener, new Func<IMaxAdReviewListenerImplementor>(this.__CreateIMaxAdReviewListenerImplementor), new Action<IMaxAdReviewListener>(this.SetAdReviewListener), delegate(IMaxAdReviewListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdReviewEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IMaxAdReviewListener, IMaxAdReviewListenerImplementor>(ref this.weak_implementor_SetAdReviewListener, new Func<IMaxAdReviewListenerImplementor, bool>(IMaxAdReviewListenerImplementor.__IsEmpty), delegate(IMaxAdReviewListener __v)
				{
					this.SetAdReviewListener(null);
				}, delegate(IMaxAdReviewListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaxAdReviewEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00017B10 File Offset: 0x00015D10
		private IMaxAdReviewListenerImplementor __CreateIMaxAdReviewListenerImplementor()
		{
			return new IMaxAdReviewListenerImplementor(this);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060008F8 RID: 2296 RVA: 0x00017B18 File Offset: 0x00015D18
		// (remove) Token: 0x060008F9 RID: 2297 RVA: 0x00017B64 File Offset: 0x00015D64
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

		// Token: 0x060008FA RID: 2298 RVA: 0x00013E20 File Offset: 0x00012020
		private IMaxAdRevenueListenerImplementor __CreateIMaxAdRevenueListenerImplementor()
		{
			return new IMaxAdRevenueListenerImplementor(this);
		}

		// Token: 0x040002E3 RID: 739
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/ads/MaxAdView", typeof(MaxAdView));

		// Token: 0x040002E4 RID: 740
		private static Delegate cb_getAdFormat;

		// Token: 0x040002E5 RID: 741
		private static Delegate cb_getAdUnitId;

		// Token: 0x040002E6 RID: 742
		private static Delegate cb_getPlacement;

		// Token: 0x040002E7 RID: 743
		private static Delegate cb_setPlacement_Ljava_lang_String_;

		// Token: 0x040002E8 RID: 744
		private static Delegate cb_destroy;

		// Token: 0x040002E9 RID: 745
		private static Delegate cb_loadAd;

		// Token: 0x040002EA RID: 746
		private static Delegate cb_setAdReviewListener_Lcom_applovin_mediation_MaxAdReviewListener_;

		// Token: 0x040002EB RID: 747
		private static Delegate cb_setCustomData_Ljava_lang_String_;

		// Token: 0x040002EC RID: 748
		private static Delegate cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040002ED RID: 749
		private static Delegate cb_setListener_Lcom_applovin_mediation_MaxAdViewAdListener_;

		// Token: 0x040002EE RID: 750
		private static Delegate cb_setLocalExtraParameter_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x040002EF RID: 751
		private static Delegate cb_setRevenueListener_Lcom_applovin_mediation_MaxAdRevenueListener_;

		// Token: 0x040002F0 RID: 752
		private static Delegate cb_startAutoRefresh;

		// Token: 0x040002F1 RID: 753
		private static Delegate cb_stopAutoRefresh;

		// Token: 0x040002F2 RID: 754
		private WeakReference weak_implementor_SetAdReviewListener;

		// Token: 0x040002F3 RID: 755
		private WeakReference weak_implementor_SetRevenueListener;
	}
}
