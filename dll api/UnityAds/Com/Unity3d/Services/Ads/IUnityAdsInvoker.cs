using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Ads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads
{
	// Token: 0x020001CC RID: 460
	[Register("com/unity3d/services/ads/IUnityAds", DoNotGenerateAcw = true)]
	internal class IUnityAdsInvoker : Java.Lang.Object, IUnityAds, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0003A994 File Offset: 0x00038B94
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityAdsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0003A9B8 File Offset: 0x00038BB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityAdsInvoker._members;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0003A9BF File Offset: 0x00038BBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0003A9C7 File Offset: 0x00038BC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityAdsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0003A9D3 File Offset: 0x00038BD3
		public static IUnityAds GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityAds>(handle, transfer);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0003A9DC File Offset: 0x00038BDC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityAdsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.IUnityAds'.");
			}
			return handle;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0003AA07 File Offset: 0x00038C07
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0003AA38 File Offset: 0x00038C38
		public IUnityAdsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityAdsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0003AA70 File Offset: 0x00038C70
		private static Delegate GetGetDebugModeHandler()
		{
			if (IUnityAdsInvoker.cb_getDebugMode == null)
			{
				IUnityAdsInvoker.cb_getDebugMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IUnityAdsInvoker.n_GetDebugMode));
			}
			return IUnityAdsInvoker.cb_getDebugMode;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0003AA94 File Offset: 0x00038C94
		private static bool n_GetDebugMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DebugMode;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0003AAA3 File Offset: 0x00038CA3
		private static Delegate GetSetDebugMode_ZHandler()
		{
			if (IUnityAdsInvoker.cb_setDebugMode_Z == null)
			{
				IUnityAdsInvoker.cb_setDebugMode_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IUnityAdsInvoker.n_SetDebugMode_Z));
			}
			return IUnityAdsInvoker.cb_setDebugMode_Z;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0003AAC7 File Offset: 0x00038CC7
		private static void n_SetDebugMode_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DebugMode = p0;
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0003AAD7 File Offset: 0x00038CD7
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0003AB18 File Offset: 0x00038D18
		public unsafe bool DebugMode
		{
			get
			{
				if (this.id_getDebugMode == IntPtr.Zero)
				{
					this.id_getDebugMode = JNIEnv.GetMethodID(this.class_ref, "getDebugMode", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_getDebugMode);
			}
			set
			{
				if (this.id_setDebugMode_Z == IntPtr.Zero)
				{
					this.id_setDebugMode_Z = JNIEnv.GetMethodID(this.class_ref, "setDebugMode", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setDebugMode_Z, ptr);
			}
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0003AB7C File Offset: 0x00038D7C
		private static Delegate GetIsInitializedHandler()
		{
			if (IUnityAdsInvoker.cb_isInitialized == null)
			{
				IUnityAdsInvoker.cb_isInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IUnityAdsInvoker.n_IsInitialized));
			}
			return IUnityAdsInvoker.cb_isInitialized;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0003ABA0 File Offset: 0x00038DA0
		private static bool n_IsInitialized(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInitialized;
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0003ABAF File Offset: 0x00038DAF
		public bool IsInitialized
		{
			get
			{
				if (this.id_isInitialized == IntPtr.Zero)
				{
					this.id_isInitialized = JNIEnv.GetMethodID(this.class_ref, "isInitialized", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isInitialized);
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0003ABEF File Offset: 0x00038DEF
		private static Delegate GetIsSupportedHandler()
		{
			if (IUnityAdsInvoker.cb_isSupported == null)
			{
				IUnityAdsInvoker.cb_isSupported = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IUnityAdsInvoker.n_IsSupported));
			}
			return IUnityAdsInvoker.cb_isSupported;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0003AC13 File Offset: 0x00038E13
		private static bool n_IsSupported(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSupported;
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0003AC22 File Offset: 0x00038E22
		public bool IsSupported
		{
			get
			{
				if (this.id_isSupported == IntPtr.Zero)
				{
					this.id_isSupported = JNIEnv.GetMethodID(this.class_ref, "isSupported", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isSupported);
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0003AC62 File Offset: 0x00038E62
		private static Delegate GetGetTokenHandler()
		{
			if (IUnityAdsInvoker.cb_getToken == null)
			{
				IUnityAdsInvoker.cb_getToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnityAdsInvoker.n_GetToken));
			}
			return IUnityAdsInvoker.cb_getToken;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0003AC86 File Offset: 0x00038E86
		private static IntPtr n_GetToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Token);
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0003AC9C File Offset: 0x00038E9C
		public string Token
		{
			get
			{
				if (this.id_getToken == IntPtr.Zero)
				{
					this.id_getToken = JNIEnv.GetMethodID(this.class_ref, "getToken", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0003ACED File Offset: 0x00038EED
		private static Delegate GetGetVersionHandler()
		{
			if (IUnityAdsInvoker.cb_getVersion == null)
			{
				IUnityAdsInvoker.cb_getVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnityAdsInvoker.n_GetVersion));
			}
			return IUnityAdsInvoker.cb_getVersion;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0003AD11 File Offset: 0x00038F11
		private static IntPtr n_GetVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Version);
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0003AD28 File Offset: 0x00038F28
		public string Version
		{
			get
			{
				if (this.id_getVersion == IntPtr.Zero)
				{
					this.id_getVersion = JNIEnv.GetMethodID(this.class_ref, "getVersion", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0003AD79 File Offset: 0x00038F79
		private static Delegate GetGetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_Handler()
		{
			if (IUnityAdsInvoker.cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_ == null)
			{
				IUnityAdsInvoker.cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityAdsInvoker.n_GetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_));
			}
			return IUnityAdsInvoker.cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		private static void n_GetToken_Lcom_unity3d_ads_IUnityAdsTokenListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAds @object = Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IUnityAdsTokenListener object2 = Java.Lang.Object.GetObject<IUnityAdsTokenListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.GetToken(object2);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0003ADC4 File Offset: 0x00038FC4
		public unsafe void GetToken(IUnityAdsTokenListener p0)
		{
			if (this.id_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_ == IntPtr.Zero)
			{
				this.id_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_ = JNIEnv.GetMethodID(this.class_ref, "getToken", "(Lcom/unity3d/ads/IUnityAdsTokenListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_, ptr);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0003AE3C File Offset: 0x0003903C
		private static Delegate GetInitialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_Handler()
		{
			if (IUnityAdsInvoker.cb_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_ == null)
			{
				IUnityAdsInvoker.cb_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZL_V(IUnityAdsInvoker.n_Initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_));
			}
			return IUnityAdsInvoker.cb_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_;
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0003AE60 File Offset: 0x00039060
		private static void n_Initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3)
		{
			IUnityAds @object = Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			IUnityAdsInitializationListener object3 = Java.Lang.Object.GetObject<IUnityAdsInitializationListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, @string, p2, object3);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0003AE98 File Offset: 0x00039098
		public unsafe void Initialize(Context p0, string p1, bool p2, IUnityAdsInitializationListener p3)
		{
			if (this.id_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_ == IntPtr.Zero)
			{
				this.id_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_ = JNIEnv.GetMethodID(this.class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0003AF6D File Offset: 0x0003916D
		private static Delegate GetLoad_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_Handler()
		{
			if (IUnityAdsInvoker.cb_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_ == null)
			{
				IUnityAdsInvoker.cb_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IUnityAdsInvoker.n_Load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_));
			}
			return IUnityAdsInvoker.cb_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_;
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0003AF94 File Offset: 0x00039194
		private static void n_Load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IUnityAds @object = Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			UnityAdsLoadOptions object2 = Java.Lang.Object.GetObject<UnityAdsLoadOptions>(native_p1, JniHandleOwnership.DoNotTransfer);
			IUnityAdsLoadListener object3 = Java.Lang.Object.GetObject<IUnityAdsLoadListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Load(@string, object2, object3);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0003AFCC File Offset: 0x000391CC
		public unsafe void Load(string p0, UnityAdsLoadOptions p1, IUnityAdsLoadListener p2)
		{
			if (this.id_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_ == IntPtr.Zero)
			{
				this.id_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "load", "(Ljava/lang/String;Lcom/unity3d/ads/UnityAdsLoadOptions;Lcom/unity3d/ads/IUnityAdsLoadListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0003B089 File Offset: 0x00039289
		private static Delegate GetShow_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_Handler()
		{
			if (IUnityAdsInvoker.cb_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_ == null)
			{
				IUnityAdsInvoker.cb_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(IUnityAdsInvoker.n_Show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_));
			}
			return IUnityAdsInvoker.cb_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003B0B0 File Offset: 0x000392B0
		private static void n_Show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			IUnityAds @object = Java.Lang.Object.GetObject<IUnityAds>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			UnityAdsShowOptions object3 = Java.Lang.Object.GetObject<UnityAdsShowOptions>(native_p2, JniHandleOwnership.DoNotTransfer);
			IUnityAdsShowListener object4 = Java.Lang.Object.GetObject<IUnityAdsShowListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, @string, object3, object4);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0003B0F0 File Offset: 0x000392F0
		public unsafe void Show(Activity p0, string p1, UnityAdsShowOptions p2, IUnityAdsShowListener p3)
		{
			if (this.id_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_ == IntPtr.Zero)
			{
				this.id_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_ = JNIEnv.GetMethodID(this.class_ref, "show", "(Landroid/app/Activity;Ljava/lang/String;Lcom/unity3d/ads/UnityAdsShowOptions;Lcom/unity3d/ads/IUnityAdsShowListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040004E2 RID: 1250
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/IUnityAds", typeof(IUnityAdsInvoker));

		// Token: 0x040004E3 RID: 1251
		private IntPtr class_ref;

		// Token: 0x040004E4 RID: 1252
		private static Delegate cb_getDebugMode;

		// Token: 0x040004E5 RID: 1253
		private static Delegate cb_setDebugMode_Z;

		// Token: 0x040004E6 RID: 1254
		private IntPtr id_getDebugMode;

		// Token: 0x040004E7 RID: 1255
		private IntPtr id_setDebugMode_Z;

		// Token: 0x040004E8 RID: 1256
		private static Delegate cb_isInitialized;

		// Token: 0x040004E9 RID: 1257
		private IntPtr id_isInitialized;

		// Token: 0x040004EA RID: 1258
		private static Delegate cb_isSupported;

		// Token: 0x040004EB RID: 1259
		private IntPtr id_isSupported;

		// Token: 0x040004EC RID: 1260
		private static Delegate cb_getToken;

		// Token: 0x040004ED RID: 1261
		private IntPtr id_getToken;

		// Token: 0x040004EE RID: 1262
		private static Delegate cb_getVersion;

		// Token: 0x040004EF RID: 1263
		private IntPtr id_getVersion;

		// Token: 0x040004F0 RID: 1264
		private static Delegate cb_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_;

		// Token: 0x040004F1 RID: 1265
		private IntPtr id_getToken_Lcom_unity3d_ads_IUnityAdsTokenListener_;

		// Token: 0x040004F2 RID: 1266
		private static Delegate cb_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_;

		// Token: 0x040004F3 RID: 1267
		private IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_ads_IUnityAdsInitializationListener_;

		// Token: 0x040004F4 RID: 1268
		private static Delegate cb_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_;

		// Token: 0x040004F5 RID: 1269
		private IntPtr id_load_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsLoadOptions_Lcom_unity3d_ads_IUnityAdsLoadListener_;

		// Token: 0x040004F6 RID: 1270
		private static Delegate cb_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_;

		// Token: 0x040004F7 RID: 1271
		private IntPtr id_show_Landroid_app_Activity_Ljava_lang_String_Lcom_unity3d_ads_UnityAdsShowOptions_Lcom_unity3d_ads_IUnityAdsShowListener_;
	}
}
