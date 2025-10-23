using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Webkit;
using Com.Iab.Omid.Library.Applovin.Adsession;
using Com.Iab.Omid.Library.Applovin.Adsession.Media;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Iab.Omid.Library.Applovin.Publisher
{
	// Token: 0x02000036 RID: 54
	[Register("com/iab/omid/library/applovin/publisher/AdSessionStatePublisher", DoNotGenerateAcw = true)]
	public abstract class AdSessionStatePublisher : Java.Lang.Object
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002AB8 File Offset: 0x00000CB8
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionStatePublisher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002ADC File Offset: 0x00000CDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSessionStatePublisher._members;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002AE4 File Offset: 0x00000CE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdSessionStatePublisher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002B08 File Offset: 0x00000D08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionStatePublisher._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AdSessionStatePublisher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002B14 File Offset: 0x00000D14
		[Register(".ctor", "()V", "")]
		public AdSessionStatePublisher() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdSessionStatePublisher._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdSessionStatePublisher._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002B82 File Offset: 0x00000D82
		private static Delegate GetGetWebViewHandler()
		{
			if (AdSessionStatePublisher.cb_getWebView == null)
			{
				AdSessionStatePublisher.cb_getWebView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionStatePublisher.n_GetWebView));
			}
			return AdSessionStatePublisher.cb_getWebView;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002BA6 File Offset: 0x00000DA6
		private static IntPtr n_GetWebView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebView);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002BBC File Offset: 0x00000DBC
		public virtual WebView WebView
		{
			[Register("getWebView", "()Landroid/webkit/WebView;", "GetGetWebViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<WebView>(AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualObjectMethod("getWebView.()Landroid/webkit/WebView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002BEE File Offset: 0x00000DEE
		private static Delegate GetAHandler()
		{
			if (AdSessionStatePublisher.cb_a == null)
			{
				AdSessionStatePublisher.cb_a = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_A));
			}
			return AdSessionStatePublisher.cb_a;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002C12 File Offset: 0x00000E12
		private static void n_A(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002C21 File Offset: 0x00000E21
		[Register("a", "()V", "GetAHandler")]
		public virtual void A()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.()V", this, null);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002C3A File Offset: 0x00000E3A
		private static Delegate GetA_ZHandler()
		{
			if (AdSessionStatePublisher.cb_a_Z == null)
			{
				AdSessionStatePublisher.cb_a_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AdSessionStatePublisher.n_A_Z));
			}
			return AdSessionStatePublisher.cb_a_Z;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002C5E File Offset: 0x00000E5E
		private static void n_A_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A(p0);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002C70 File Offset: 0x00000E70
		[Register("a", "(Z)V", "GetA_ZHandler")]
		public unsafe virtual void A(bool p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Z)V", this, ptr);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002CAB File Offset: 0x00000EAB
		private static Delegate GetA_Lcom_iab_omid_library_applovin_adsession_AdEvents_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_AdEvents_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_AdEvents_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_applovin_adsession_AdEvents_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_AdEvents_;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002CD0 File Offset: 0x00000ED0
		private static void n_A_Lcom_iab_omid_library_applovin_adsession_AdEvents_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdEvents object2 = Java.Lang.Object.GetObject<AdEvents>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002CF4 File Offset: 0x00000EF4
		[Register("a", "(Lcom/iab/omid/library/applovin/adsession/AdEvents;)V", "GetA_Lcom_iab_omid_library_applovin_adsession_AdEvents_Handler")]
		public unsafe virtual void A(AdEvents p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/applovin/adsession/AdEvents;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002D58 File Offset: 0x00000F58
		private static Delegate GetA_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002D7C File Offset: 0x00000F7C
		private static void n_A_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdSessionConfiguration object2 = Java.Lang.Object.GetObject<AdSessionConfiguration>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002DA0 File Offset: 0x00000FA0
		[Register("a", "(Lcom/iab/omid/library/applovin/adsession/AdSessionConfiguration;)V", "GetA_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_Handler")]
		public unsafe virtual void A(AdSessionConfiguration p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/applovin/adsession/AdSessionConfiguration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002E04 File Offset: 0x00001004
		private static Delegate GetA_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002E28 File Offset: 0x00001028
		private static void n_A_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ErrorType object2 = Java.Lang.Object.GetObject<ErrorType>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.A(object2, @string);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002E54 File Offset: 0x00001054
		[Register("a", "(Lcom/iab/omid/library/applovin/adsession/ErrorType;Ljava/lang/String;)V", "GetA_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_Handler")]
		public unsafe virtual void A(ErrorType p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/applovin/adsession/ErrorType;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002ED8 File Offset: 0x000010D8
		private static Delegate GetA_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002EFC File Offset: 0x000010FC
		private static void n_A_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MediaEvents object2 = Java.Lang.Object.GetObject<MediaEvents>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002F20 File Offset: 0x00001120
		[Register("a", "(Lcom/iab/omid/library/applovin/adsession/media/MediaEvents;)V", "GetA_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_Handler")]
		public unsafe virtual void A(MediaEvents p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/applovin/adsession/media/MediaEvents;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002F84 File Offset: 0x00001184
		private static Delegate GetA_FHandler()
		{
			if (AdSessionStatePublisher.cb_a_F == null)
			{
				AdSessionStatePublisher.cb_a_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(AdSessionStatePublisher.n_A_F));
			}
			return AdSessionStatePublisher.cb_a_F;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002FA8 File Offset: 0x000011A8
		private static void n_A_F(IntPtr jnienv, IntPtr native__this, float p0)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A(p0);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Register("a", "(F)V", "GetA_FHandler")]
		public unsafe virtual void A(float p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(F)V", this, ptr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002FF3 File Offset: 0x000011F3
		private static Delegate GetA_Ljava_lang_String_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Ljava_lang_String_ == null)
			{
				AdSessionStatePublisher.cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Ljava_lang_String_));
			}
			return AdSessionStatePublisher.cb_a_Ljava_lang_String_;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003018 File Offset: 0x00001218
		private static void n_A_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(@string);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000303C File Offset: 0x0000123C
		[Register("a", "(Ljava/lang/String;)V", "GetA_Ljava_lang_String_Handler")]
		public unsafe virtual void A(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003098 File Offset: 0x00001298
		private static Delegate GetA_Ljava_lang_String_JHandler()
		{
			if (AdSessionStatePublisher.cb_a_Ljava_lang_String_J == null)
			{
				AdSessionStatePublisher.cb_a_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_V(AdSessionStatePublisher.n_A_Ljava_lang_String_J));
			}
			return AdSessionStatePublisher.cb_a_Ljava_lang_String_J;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000030BC File Offset: 0x000012BC
		private static void n_A_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(@string, p1);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000030E0 File Offset: 0x000012E0
		[Register("a", "(Ljava/lang/String;J)V", "GetA_Ljava_lang_String_JHandler")]
		public unsafe virtual void A(string p0, long p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003150 File Offset: 0x00001350
		private static Delegate GetA_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				AdSessionStatePublisher.cb_a_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AdSessionStatePublisher.n_A_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return AdSessionStatePublisher.cb_a_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003174 File Offset: 0x00001374
		private static void n_A_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.A(@string, object2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000031A0 File Offset: 0x000013A0
		[Register("a", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetA_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void A(string p0, JSONObject p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Ljava/lang/String;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003224 File Offset: 0x00001424
		private static Delegate GetA_Lorg_json_JSONObject_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lorg_json_JSONObject_ == null)
			{
				AdSessionStatePublisher.cb_a_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lorg_json_JSONObject_));
			}
			return AdSessionStatePublisher.cb_a_Lorg_json_JSONObject_;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003248 File Offset: 0x00001448
		private static void n_A_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000326C File Offset: 0x0000146C
		[Register("a", "(Lorg/json/JSONObject;)V", "GetA_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void A(JSONObject p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000032D0 File Offset: 0x000014D0
		private static Delegate GetBHandler()
		{
			if (AdSessionStatePublisher.cb_b == null)
			{
				AdSessionStatePublisher.cb_b = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_B));
			}
			return AdSessionStatePublisher.cb_b;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000032F4 File Offset: 0x000014F4
		private static void n_B(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).B();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003303 File Offset: 0x00001503
		[Register("b", "()V", "GetBHandler")]
		public virtual void B()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("b.()V", this, null);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000331C File Offset: 0x0000151C
		private static Delegate GetB_Ljava_lang_String_JHandler()
		{
			if (AdSessionStatePublisher.cb_b_Ljava_lang_String_J == null)
			{
				AdSessionStatePublisher.cb_b_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_V(AdSessionStatePublisher.n_B_Ljava_lang_String_J));
			}
			return AdSessionStatePublisher.cb_b_Ljava_lang_String_J;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003340 File Offset: 0x00001540
		private static void n_B_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.B(@string, p1);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003364 File Offset: 0x00001564
		[Register("b", "(Ljava/lang/String;J)V", "GetB_Ljava_lang_String_JHandler")]
		public unsafe virtual void B(string p0, long p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("b.(Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000033D4 File Offset: 0x000015D4
		private static Delegate GetCHandler()
		{
			if (AdSessionStatePublisher.cb_c == null)
			{
				AdSessionStatePublisher.cb_c = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionStatePublisher.n_C));
			}
			return AdSessionStatePublisher.cb_c;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000033F8 File Offset: 0x000015F8
		private static IntPtr n_C(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).C());
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000340C File Offset: 0x0000160C
		[Register("c", "()Lcom/iab/omid/library/applovin/adsession/AdEvents;", "GetCHandler")]
		public virtual AdEvents C()
		{
			return Java.Lang.Object.GetObject<AdEvents>(AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualObjectMethod("c.()Lcom/iab/omid/library/applovin/adsession/AdEvents;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000343E File Offset: 0x0000163E
		private static Delegate GetDHandler()
		{
			if (AdSessionStatePublisher.cb_d == null)
			{
				AdSessionStatePublisher.cb_d = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionStatePublisher.n_D));
			}
			return AdSessionStatePublisher.cb_d;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003462 File Offset: 0x00001662
		private static IntPtr n_D(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).D());
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003478 File Offset: 0x00001678
		[Register("d", "()Lcom/iab/omid/library/applovin/adsession/media/MediaEvents;", "GetDHandler")]
		public virtual MediaEvents D()
		{
			return Java.Lang.Object.GetObject<MediaEvents>(AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualObjectMethod("d.()Lcom/iab/omid/library/applovin/adsession/media/MediaEvents;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000034AA File Offset: 0x000016AA
		private static Delegate GetEHandler()
		{
			if (AdSessionStatePublisher.cb_e == null)
			{
				AdSessionStatePublisher.cb_e = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdSessionStatePublisher.n_E));
			}
			return AdSessionStatePublisher.cb_e;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000034CE File Offset: 0x000016CE
		private static bool n_E(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).E();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000034DD File Offset: 0x000016DD
		[Register("e", "()Z", "GetEHandler")]
		public virtual bool E()
		{
			return AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualBooleanMethod("e.()Z", this, null);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000034F6 File Offset: 0x000016F6
		private static Delegate GetFHandler()
		{
			if (AdSessionStatePublisher.cb_f == null)
			{
				AdSessionStatePublisher.cb_f = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_F));
			}
			return AdSessionStatePublisher.cb_f;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000351A File Offset: 0x0000171A
		private static void n_F(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).F();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003529 File Offset: 0x00001729
		[Register("f", "()V", "GetFHandler")]
		public virtual void F()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("f.()V", this, null);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003542 File Offset: 0x00001742
		private static Delegate GetGHandler()
		{
			if (AdSessionStatePublisher.cb_g == null)
			{
				AdSessionStatePublisher.cb_g = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_G));
			}
			return AdSessionStatePublisher.cb_g;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003566 File Offset: 0x00001766
		private static void n_G(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).G();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003575 File Offset: 0x00001775
		[Register("g", "()V", "GetGHandler")]
		public virtual void G()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("g.()V", this, null);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000358E File Offset: 0x0000178E
		private static Delegate GetHHandler()
		{
			if (AdSessionStatePublisher.cb_h == null)
			{
				AdSessionStatePublisher.cb_h = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_H));
			}
			return AdSessionStatePublisher.cb_h;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000035B2 File Offset: 0x000017B2
		private static void n_H(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).H();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000035C1 File Offset: 0x000017C1
		[Register("h", "()V", "GetHHandler")]
		public virtual void H()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("h.()V", this, null);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000035DA File Offset: 0x000017DA
		private static Delegate GetIHandler()
		{
			if (AdSessionStatePublisher.cb_i == null)
			{
				AdSessionStatePublisher.cb_i = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_I));
			}
			return AdSessionStatePublisher.cb_i;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000035FE File Offset: 0x000017FE
		private static void n_I(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).I();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000360D File Offset: 0x0000180D
		[Register("i", "()V", "GetIHandler")]
		public virtual void I()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("i.()V", this, null);
		}

		// Token: 0x04000018 RID: 24
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/publisher/AdSessionStatePublisher", typeof(AdSessionStatePublisher));

		// Token: 0x04000019 RID: 25
		private static Delegate cb_getWebView;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_a;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_a_Z;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_a_Lcom_iab_omid_library_applovin_adsession_AdEvents_;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_a_Lcom_iab_omid_library_applovin_adsession_AdSessionConfiguration_;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_a_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_a_Lcom_iab_omid_library_applovin_adsession_media_MediaEvents_;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_a_F;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_a_Ljava_lang_String_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_a_Ljava_lang_String_J;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_a_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_a_Lorg_json_JSONObject_;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_b;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_b_Ljava_lang_String_J;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_c;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_d;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_e;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_f;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_g;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_h;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_i;
	}
}
