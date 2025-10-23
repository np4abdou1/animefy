using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200007F RID: 127
	[Register("com/applovin/sdk/AppLovinAdService", DoNotGenerateAcw = true)]
	internal class IAppLovinAdServiceInvoker : Java.Lang.Object, IAppLovinAdService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000B100 File Offset: 0x00009300
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000B124 File Offset: 0x00009324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdServiceInvoker._members;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000B12B File Offset: 0x0000932B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000B133 File Offset: 0x00009333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000B13F File Offset: 0x0000933F
		public static IAppLovinAdService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdService>(handle, transfer);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000B148 File Offset: 0x00009348
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAdService'.");
			}
			return handle;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000B173 File Offset: 0x00009373
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public IAppLovinAdServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000B1DC File Offset: 0x000093DC
		private static Delegate GetGetBidTokenHandler()
		{
			if (IAppLovinAdServiceInvoker.cb_getBidToken == null)
			{
				IAppLovinAdServiceInvoker.cb_getBidToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinAdServiceInvoker.n_GetBidToken));
			}
			return IAppLovinAdServiceInvoker.cb_getBidToken;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000B200 File Offset: 0x00009400
		private static IntPtr n_GetBidToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BidToken);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000B214 File Offset: 0x00009414
		public string BidToken
		{
			get
			{
				if (this.id_getBidToken == IntPtr.Zero)
				{
					this.id_getBidToken = JNIEnv.GetMethodID(this.class_ref, "getBidToken", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getBidToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000B265 File Offset: 0x00009465
		private static Delegate GetLoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (IAppLovinAdServiceInvoker.cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				IAppLovinAdServiceInvoker.cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdServiceInvoker.n_LoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return IAppLovinAdServiceInvoker.cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000B28C File Offset: 0x0000948C
		private static void n_LoadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdService @object = Java.Lang.Object.GetObject<IAppLovinAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinAdSize object2 = Java.Lang.Object.GetObject<AppLovinAdSize>(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object3 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAd(object2, object3);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public unsafe void LoadNextAd(AppLovinAdSize p0, IAppLovinAdLoadListener p1)
		{
			if (this.id_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ == IntPtr.Zero)
			{
				this.id_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "loadNextAd", "(Lcom/applovin/sdk/AppLovinAdSize;Lcom/applovin/sdk/AppLovinAdLoadListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_, ptr);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000B352 File Offset: 0x00009552
		private static Delegate GetLoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (IAppLovinAdServiceInvoker.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				IAppLovinAdServiceInvoker.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdServiceInvoker.n_LoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return IAppLovinAdServiceInvoker.cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000B378 File Offset: 0x00009578
		private static void n_LoadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdService @object = Java.Lang.Object.GetObject<IAppLovinAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForAdToken(@string, object2);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public unsafe void LoadNextAdForAdToken(string p0, IAppLovinAdLoadListener p1)
		{
			if (this.id_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == IntPtr.Zero)
			{
				this.id_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "loadNextAdForAdToken", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000B43C File Offset: 0x0000963C
		private static Delegate GetLoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (IAppLovinAdServiceInvoker.cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				IAppLovinAdServiceInvoker.cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdServiceInvoker.n_LoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return IAppLovinAdServiceInvoker.cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000B460 File Offset: 0x00009660
		private static void n_LoadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdService @object = Java.Lang.Object.GetObject<IAppLovinAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForZoneId(@string, object2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000B48C File Offset: 0x0000968C
		public unsafe void LoadNextAdForZoneId(string p0, IAppLovinAdLoadListener p1)
		{
			if (this.id_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ == IntPtr.Zero)
			{
				this.id_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "loadNextAdForZoneId", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinAdLoadListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000B524 File Offset: 0x00009724
		private static Delegate GetLoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_Handler()
		{
			if (IAppLovinAdServiceInvoker.cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_ == null)
			{
				IAppLovinAdServiceInvoker.cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdServiceInvoker.n_LoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_));
			}
			return IAppLovinAdServiceInvoker.cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000B548 File Offset: 0x00009748
		private static void n_LoadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdService @object = Java.Lang.Object.GetObject<IAppLovinAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> p = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdLoadListener object2 = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadNextAdForZoneIds(p, object2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000B574 File Offset: 0x00009774
		public unsafe void LoadNextAdForZoneIds(IList<string> p0, IAppLovinAdLoadListener p1)
		{
			if (this.id_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_ == IntPtr.Zero)
			{
				this.id_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "loadNextAdForZoneIds", "(Ljava/util/List;Lcom/applovin/sdk/AppLovinAdLoadListener;)V");
			}
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400011D RID: 285
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdService", typeof(IAppLovinAdServiceInvoker));

		// Token: 0x0400011E RID: 286
		private IntPtr class_ref;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_getBidToken;

		// Token: 0x04000120 RID: 288
		private IntPtr id_getBidToken;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000122 RID: 290
		private IntPtr id_loadNextAd_Lcom_applovin_sdk_AppLovinAdSize_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000124 RID: 292
		private IntPtr id_loadNextAdForAdToken_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000125 RID: 293
		private static Delegate cb_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000126 RID: 294
		private IntPtr id_loadNextAdForZoneId_Ljava_lang_String_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_;

		// Token: 0x04000128 RID: 296
		private IntPtr id_loadNextAdForZoneIds_Ljava_util_List_Lcom_applovin_sdk_AppLovinAdLoadListener_;
	}
}
