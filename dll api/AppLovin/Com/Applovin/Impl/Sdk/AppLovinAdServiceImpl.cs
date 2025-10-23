using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x0200012B RID: 299
	[Register("com/applovin/impl/sdk/AppLovinAdServiceImpl", DoNotGenerateAcw = true)]
	public class AppLovinAdServiceImpl : Java.Lang.Object, IAppLovinAdService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00024478 File Offset: 0x00022678
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0002449C File Offset: 0x0002269C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdServiceImpl._members;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000244A4 File Offset: 0x000226A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000244C8 File Offset: 0x000226C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinAdServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000244D4 File Offset: 0x000226D4
		private static Delegate GetGetAndResetCustomPostBodyHandler()
		{
			if (AppLovinAdServiceImpl.cb_getAndResetCustomPostBody == null)
			{
				AppLovinAdServiceImpl.cb_getAndResetCustomPostBody = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdServiceImpl.n_GetAndResetCustomPostBody));
			}
			return AppLovinAdServiceImpl.cb_getAndResetCustomPostBody;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000244F8 File Offset: 0x000226F8
		private static IntPtr n_GetAndResetCustomPostBody(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AndResetCustomPostBody);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0002450C File Offset: 0x0002270C
		public virtual JSONObject AndResetCustomPostBody
		{
			[Register("getAndResetCustomPostBody", "()Lorg/json/JSONObject;", "GetGetAndResetCustomPostBodyHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAndResetCustomPostBody.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002453E File Offset: 0x0002273E
		private static Delegate GetGetAndResetCustomQueryParamsHandler()
		{
			if (AppLovinAdServiceImpl.cb_getAndResetCustomQueryParams == null)
			{
				AppLovinAdServiceImpl.cb_getAndResetCustomQueryParams = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdServiceImpl.n_GetAndResetCustomQueryParams));
			}
			return AppLovinAdServiceImpl.cb_getAndResetCustomQueryParams;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00024562 File Offset: 0x00022762
		private static IntPtr n_GetAndResetCustomQueryParams(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AndResetCustomQueryParams);
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00024578 File Offset: 0x00022778
		public virtual IDictionary<string, string> AndResetCustomQueryParams
		{
			[Register("getAndResetCustomQueryParams", "()Ljava/util/Map;", "GetGetAndResetCustomQueryParamsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAndResetCustomQueryParams.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000245AA File Offset: 0x000227AA
		private static Delegate GetGetBidTokenHandler()
		{
			if (AppLovinAdServiceImpl.cb_getBidToken == null)
			{
				AppLovinAdServiceImpl.cb_getBidToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdServiceImpl.n_GetBidToken));
			}
			return AppLovinAdServiceImpl.cb_getBidToken;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000245CE File Offset: 0x000227CE
		private static IntPtr n_GetBidToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BidToken);
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x000245E4 File Offset: 0x000227E4
		public virtual string BidToken
		{
			[Register("getBidToken", "()Ljava/lang/String;", "GetGetBidTokenHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getBidToken.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00024616 File Offset: 0x00022816
		private static Delegate GetAddCustomQueryParams_Ljava_util_Map_Handler()
		{
			if (AppLovinAdServiceImpl.cb_addCustomQueryParams_Ljava_util_Map_ == null)
			{
				AppLovinAdServiceImpl.cb_addCustomQueryParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdServiceImpl.n_AddCustomQueryParams_Ljava_util_Map_));
			}
			return AppLovinAdServiceImpl.cb_addCustomQueryParams_Ljava_util_Map_;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002463C File Offset: 0x0002283C
		private static void n_AddCustomQueryParams_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddCustomQueryParams(p);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00024660 File Offset: 0x00022860
		[Register("addCustomQueryParams", "(Ljava/util/Map;)V", "GetAddCustomQueryParams_Ljava_util_Map_Handler")]
		public unsafe virtual void AddCustomQueryParams(IDictionary<string, string> p0)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("addCustomQueryParams.(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000246C4 File Offset: 0x000228C4
		private static Delegate GetLoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdServiceImpl.cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdServiceImpl.cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinAdServiceImpl.n_LoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdServiceImpl.cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000246E8 File Offset: 0x000228E8
		private static void n_LoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinAdSize object2 = Java.Lang.Object.GetObject<AppLovinAdSize>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object3 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAd(object2, object3);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00024714 File Offset: 0x00022914
		[Register("loadNextAd", "(Lcom/applovin/sdk/AppLovinAdSize;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void LoadNextAd(AppLovinAdSize p0, IAppLovinAdLoadListener p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAd.(Lcom/applovin/sdk/AppLovinAdSize;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000247A4 File Offset: 0x000229A4
		private static Delegate GetLoadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdServiceImpl.cb_loadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdServiceImpl.cb_loadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinAdServiceImpl.n_LoadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdServiceImpl.cb_loadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000247C8 File Offset: 0x000229C8
		private static void n_LoadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			AppLovinAdSize object2 = Java.Lang.Object.GetObject<AppLovinAdSize>(native_p1, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object3 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAd(@string, object2, object3);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00024800 File Offset: 0x00022A00
		[Register("loadNextAd", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdSize;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void LoadNextAd(string p0, AppLovinAdSize p1, IAppLovinAdLoadListener p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAd.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdSize;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000248B4 File Offset: 0x00022AB4
		private static Delegate GetLoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdServiceImpl.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdServiceImpl.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinAdServiceImpl.n_LoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdServiceImpl.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000248D8 File Offset: 0x00022AD8
		private static void n_LoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForAdToken(@string, object2);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00024904 File Offset: 0x00022B04
		[Register("loadNextAdForAdToken", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void LoadNextAdForAdToken(string p0, IAppLovinAdLoadListener p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAdForAdToken.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0002498C File Offset: 0x00022B8C
		private static Delegate GetLoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdServiceImpl.cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdServiceImpl.cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinAdServiceImpl.n_LoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdServiceImpl.cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000249B0 File Offset: 0x00022BB0
		private static void n_LoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForZoneId(@string, object2);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000249DC File Offset: 0x00022BDC
		[Register("loadNextAdForZoneId", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void LoadNextAdForZoneId(string p0, IAppLovinAdLoadListener p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAdForZoneId.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00024A64 File Offset: 0x00022C64
		private static Delegate GetLoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdServiceImpl.cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdServiceImpl.cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinAdServiceImpl.n_LoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdServiceImpl.cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00024A88 File Offset: 0x00022C88
		private static void n_LoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> p = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForZoneIds(p, object2);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00024AB4 File Offset: 0x00022CB4
		[Register("loadNextAdForZoneIds", "(Ljava/util/List;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void LoadNextAdForZoneIds(IList<string> p0, IAppLovinAdLoadListener p1)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextAdForZoneIds.(Ljava/util/List;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00024B44 File Offset: 0x00022D44
		private static Delegate GetLoadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (AppLovinAdServiceImpl.cb_loadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				AppLovinAdServiceImpl.cb_loadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinAdServiceImpl.n_LoadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return AppLovinAdServiceImpl.cb_loadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00024B68 File Offset: 0x00022D68
		private static void n_LoadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextIncentivizedAd(@string, object2);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00024B94 File Offset: 0x00022D94
		[Register("loadNextIncentivizedAd", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", "GetLoadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler")]
		public unsafe virtual void LoadNextIncentivizedAd(string p0, IAppLovinAdLoadListener p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadNextIncentivizedAd.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00024C1C File Offset: 0x00022E1C
		private static Delegate GetSetCustomPostBody_Lorg_json_JSONObject_Handler()
		{
			if (AppLovinAdServiceImpl.cb_setCustomPostBody_Lorg_json_JSONObject_ == null)
			{
				AppLovinAdServiceImpl.cb_setCustomPostBody_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinAdServiceImpl.n_SetCustomPostBody_Lorg_json_JSONObject_));
			}
			return AppLovinAdServiceImpl.cb_setCustomPostBody_Lorg_json_JSONObject_;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00024C40 File Offset: 0x00022E40
		private static void n_SetCustomPostBody_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdServiceImpl @object = Java.Lang.Object.GetObject<AppLovinAdServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetCustomPostBody(object2);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00024C64 File Offset: 0x00022E64
		[Register("setCustomPostBody", "(Lorg/json/JSONObject;)V", "GetSetCustomPostBody_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void SetCustomPostBody(JSONObject p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AppLovinAdServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setCustomPostBody.(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040004B2 RID: 1202
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinAdServiceImpl", typeof(AppLovinAdServiceImpl));

		// Token: 0x040004B3 RID: 1203
		private static Delegate cb_getAndResetCustomPostBody;

		// Token: 0x040004B4 RID: 1204
		private static Delegate cb_getAndResetCustomQueryParams;

		// Token: 0x040004B5 RID: 1205
		private static Delegate cb_getBidToken;

		// Token: 0x040004B6 RID: 1206
		private static Delegate cb_addCustomQueryParams_Ljava_util_Map_;

		// Token: 0x040004B7 RID: 1207
		private static Delegate cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040004B8 RID: 1208
		private static Delegate cb_loadNextAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040004B9 RID: 1209
		private static Delegate cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040004BA RID: 1210
		private static Delegate cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040004BB RID: 1211
		private static Delegate cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040004BC RID: 1212
		private static Delegate cb_loadNextIncentivizedAd_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x040004BD RID: 1213
		private static Delegate cb_setCustomPostBody_Lorg_json_JSONObject_;
	}
}
