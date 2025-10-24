using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Webkit;
using Com.Iab.Omid.Library.Adcolony.Adsession;
using Com.Iab.Omid.Library.Adcolony.Adsession.Media;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Iab.Omid.Library.Adcolony.Publisher
{
	// Token: 0x02000021 RID: 33
	[Register("com/iab/omid/library/adcolony/publisher/AdSessionStatePublisher", DoNotGenerateAcw = true)]
	public abstract class AdSessionStatePublisher : Java.Lang.Object
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000029F0 File Offset: 0x00000BF0
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionStatePublisher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002A14 File Offset: 0x00000C14
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
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002A1C File Offset: 0x00000C1C
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
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002A40 File Offset: 0x00000C40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionStatePublisher._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002128 File Offset: 0x00000328
		protected AdSessionStatePublisher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002A4C File Offset: 0x00000C4C
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

		// Token: 0x0600009E RID: 158 RVA: 0x00002ABA File Offset: 0x00000CBA
		private static Delegate GetGetWebViewHandler()
		{
			if (AdSessionStatePublisher.cb_getWebView == null)
			{
				AdSessionStatePublisher.cb_getWebView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionStatePublisher.n_GetWebView));
			}
			return AdSessionStatePublisher.cb_getWebView;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002ADE File Offset: 0x00000CDE
		private static IntPtr n_GetWebView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebView);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public virtual WebView WebView
		{
			[Register("getWebView", "()Landroid/webkit/WebView;", "GetGetWebViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<WebView>(AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualObjectMethod("getWebView.()Landroid/webkit/WebView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002B26 File Offset: 0x00000D26
		private static Delegate GetAHandler()
		{
			if (AdSessionStatePublisher.cb_a == null)
			{
				AdSessionStatePublisher.cb_a = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_A));
			}
			return AdSessionStatePublisher.cb_a;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002B4A File Offset: 0x00000D4A
		private static void n_A(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002B59 File Offset: 0x00000D59
		[Register("a", "()V", "GetAHandler")]
		public virtual void A()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.()V", this, null);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002B72 File Offset: 0x00000D72
		private static Delegate GetA_ZHandler()
		{
			if (AdSessionStatePublisher.cb_a_Z == null)
			{
				AdSessionStatePublisher.cb_a_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AdSessionStatePublisher.n_A_Z));
			}
			return AdSessionStatePublisher.cb_a_Z;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002B96 File Offset: 0x00000D96
		private static void n_A_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A(p0);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002BA8 File Offset: 0x00000DA8
		[Register("a", "(Z)V", "GetA_ZHandler")]
		public unsafe virtual void A(bool p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Z)V", this, ptr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002BE3 File Offset: 0x00000DE3
		private static Delegate GetA_Lcom_iab_omid_library_adcolony_adsession_AdEvents_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_AdEvents_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_AdEvents_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_adcolony_adsession_AdEvents_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_AdEvents_;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002C08 File Offset: 0x00000E08
		private static void n_A_Lcom_iab_omid_library_adcolony_adsession_AdEvents_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdEvents object2 = Java.Lang.Object.GetObject<AdEvents>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002C2C File Offset: 0x00000E2C
		[Register("a", "(Lcom/iab/omid/library/adcolony/adsession/AdEvents;)V", "GetA_Lcom_iab_omid_library_adcolony_adsession_AdEvents_Handler")]
		public unsafe virtual void A(AdEvents p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/adcolony/adsession/AdEvents;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002C90 File Offset: 0x00000E90
		private static Delegate GetA_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002CB4 File Offset: 0x00000EB4
		private static void n_A_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdSessionConfiguration object2 = Java.Lang.Object.GetObject<AdSessionConfiguration>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002CD8 File Offset: 0x00000ED8
		[Register("a", "(Lcom/iab/omid/library/adcolony/adsession/AdSessionConfiguration;)V", "GetA_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_Handler")]
		public unsafe virtual void A(AdSessionConfiguration p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/adcolony/adsession/AdSessionConfiguration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002D3C File Offset: 0x00000F3C
		private static Delegate GetA_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002D60 File Offset: 0x00000F60
		private static void n_A_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ErrorType object2 = Java.Lang.Object.GetObject<ErrorType>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.A(object2, @string);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Register("a", "(Lcom/iab/omid/library/adcolony/adsession/ErrorType;Ljava/lang/String;)V", "GetA_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_Handler")]
		public unsafe virtual void A(ErrorType p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/adcolony/adsession/ErrorType;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002E10 File Offset: 0x00001010
		private static Delegate GetA_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_ == null)
			{
				AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_));
			}
			return AdSessionStatePublisher.cb_a_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002E34 File Offset: 0x00001034
		private static void n_A_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MediaEvents object2 = Java.Lang.Object.GetObject<MediaEvents>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002E58 File Offset: 0x00001058
		[Register("a", "(Lcom/iab/omid/library/adcolony/adsession/media/MediaEvents;)V", "GetA_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_Handler")]
		public unsafe virtual void A(MediaEvents p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(Lcom/iab/omid/library/adcolony/adsession/media/MediaEvents;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002EBC File Offset: 0x000010BC
		private static Delegate GetA_FHandler()
		{
			if (AdSessionStatePublisher.cb_a_F == null)
			{
				AdSessionStatePublisher.cb_a_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(AdSessionStatePublisher.n_A_F));
			}
			return AdSessionStatePublisher.cb_a_F;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002EE0 File Offset: 0x000010E0
		private static void n_A_F(IntPtr jnienv, IntPtr native__this, float p0)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A(p0);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002EF0 File Offset: 0x000010F0
		[Register("a", "(F)V", "GetA_FHandler")]
		public unsafe virtual void A(float p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("a.(F)V", this, ptr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002F2B File Offset: 0x0000112B
		private static Delegate GetA_Ljava_lang_String_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Ljava_lang_String_ == null)
			{
				AdSessionStatePublisher.cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Ljava_lang_String_));
			}
			return AdSessionStatePublisher.cb_a_Ljava_lang_String_;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002F50 File Offset: 0x00001150
		private static void n_A_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(@string);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002F74 File Offset: 0x00001174
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

		// Token: 0x060000B9 RID: 185 RVA: 0x00002FD0 File Offset: 0x000011D0
		private static Delegate GetA_Ljava_lang_String_JHandler()
		{
			if (AdSessionStatePublisher.cb_a_Ljava_lang_String_J == null)
			{
				AdSessionStatePublisher.cb_a_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_V(AdSessionStatePublisher.n_A_Ljava_lang_String_J));
			}
			return AdSessionStatePublisher.cb_a_Ljava_lang_String_J;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002FF4 File Offset: 0x000011F4
		private static void n_A_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(@string, p1);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003018 File Offset: 0x00001218
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

		// Token: 0x060000BC RID: 188 RVA: 0x00003088 File Offset: 0x00001288
		private static Delegate GetA_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				AdSessionStatePublisher.cb_a_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AdSessionStatePublisher.n_A_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return AdSessionStatePublisher.cb_a_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000030AC File Offset: 0x000012AC
		private static void n_A_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.A(@string, object2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000030D8 File Offset: 0x000012D8
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

		// Token: 0x060000BF RID: 191 RVA: 0x0000315C File Offset: 0x0000135C
		private static Delegate GetA_Lorg_json_JSONObject_Handler()
		{
			if (AdSessionStatePublisher.cb_a_Lorg_json_JSONObject_ == null)
			{
				AdSessionStatePublisher.cb_a_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdSessionStatePublisher.n_A_Lorg_json_JSONObject_));
			}
			return AdSessionStatePublisher.cb_a_Lorg_json_JSONObject_;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003180 File Offset: 0x00001380
		private static void n_A_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.A(object2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000031A4 File Offset: 0x000013A4
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00003208 File Offset: 0x00001408
		private static Delegate GetBHandler()
		{
			if (AdSessionStatePublisher.cb_b == null)
			{
				AdSessionStatePublisher.cb_b = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_B));
			}
			return AdSessionStatePublisher.cb_b;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000322C File Offset: 0x0000142C
		private static void n_B(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).B();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000323B File Offset: 0x0000143B
		[Register("b", "()V", "GetBHandler")]
		public virtual void B()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("b.()V", this, null);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003254 File Offset: 0x00001454
		private static Delegate GetB_Ljava_lang_String_JHandler()
		{
			if (AdSessionStatePublisher.cb_b_Ljava_lang_String_J == null)
			{
				AdSessionStatePublisher.cb_b_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_V(AdSessionStatePublisher.n_B_Ljava_lang_String_J));
			}
			return AdSessionStatePublisher.cb_b_Ljava_lang_String_J;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003278 File Offset: 0x00001478
		private static void n_B_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			AdSessionStatePublisher @object = Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.B(@string, p1);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000329C File Offset: 0x0000149C
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

		// Token: 0x060000C8 RID: 200 RVA: 0x0000330C File Offset: 0x0000150C
		private static Delegate GetCHandler()
		{
			if (AdSessionStatePublisher.cb_c == null)
			{
				AdSessionStatePublisher.cb_c = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionStatePublisher.n_C));
			}
			return AdSessionStatePublisher.cb_c;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003330 File Offset: 0x00001530
		private static IntPtr n_C(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).C());
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003344 File Offset: 0x00001544
		[Register("c", "()Lcom/iab/omid/library/adcolony/adsession/AdEvents;", "GetCHandler")]
		public virtual AdEvents C()
		{
			return Java.Lang.Object.GetObject<AdEvents>(AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualObjectMethod("c.()Lcom/iab/omid/library/adcolony/adsession/AdEvents;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003376 File Offset: 0x00001576
		private static Delegate GetDHandler()
		{
			if (AdSessionStatePublisher.cb_d == null)
			{
				AdSessionStatePublisher.cb_d = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionStatePublisher.n_D));
			}
			return AdSessionStatePublisher.cb_d;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000339A File Offset: 0x0000159A
		private static IntPtr n_D(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).D());
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000033B0 File Offset: 0x000015B0
		[Register("d", "()Lcom/iab/omid/library/adcolony/adsession/media/MediaEvents;", "GetDHandler")]
		public virtual MediaEvents D()
		{
			return Java.Lang.Object.GetObject<MediaEvents>(AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualObjectMethod("d.()Lcom/iab/omid/library/adcolony/adsession/media/MediaEvents;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000033E2 File Offset: 0x000015E2
		private static Delegate GetEHandler()
		{
			if (AdSessionStatePublisher.cb_e == null)
			{
				AdSessionStatePublisher.cb_e = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdSessionStatePublisher.n_E));
			}
			return AdSessionStatePublisher.cb_e;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003406 File Offset: 0x00001606
		private static bool n_E(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).E();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003415 File Offset: 0x00001615
		[Register("e", "()Z", "GetEHandler")]
		public virtual bool E()
		{
			return AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualBooleanMethod("e.()Z", this, null);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000342E File Offset: 0x0000162E
		private static Delegate GetFHandler()
		{
			if (AdSessionStatePublisher.cb_f == null)
			{
				AdSessionStatePublisher.cb_f = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_F));
			}
			return AdSessionStatePublisher.cb_f;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003452 File Offset: 0x00001652
		private static void n_F(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).F();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003461 File Offset: 0x00001661
		[Register("f", "()V", "GetFHandler")]
		public virtual void F()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("f.()V", this, null);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000347A File Offset: 0x0000167A
		private static Delegate GetGHandler()
		{
			if (AdSessionStatePublisher.cb_g == null)
			{
				AdSessionStatePublisher.cb_g = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_G));
			}
			return AdSessionStatePublisher.cb_g;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000349E File Offset: 0x0000169E
		private static void n_G(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).G();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000034AD File Offset: 0x000016AD
		[Register("g", "()V", "GetGHandler")]
		public virtual void G()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("g.()V", this, null);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000034C6 File Offset: 0x000016C6
		private static Delegate GetHHandler()
		{
			if (AdSessionStatePublisher.cb_h == null)
			{
				AdSessionStatePublisher.cb_h = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_H));
			}
			return AdSessionStatePublisher.cb_h;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000034EA File Offset: 0x000016EA
		private static void n_H(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).H();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000034F9 File Offset: 0x000016F9
		[Register("h", "()V", "GetHHandler")]
		public virtual void H()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("h.()V", this, null);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003512 File Offset: 0x00001712
		private static Delegate GetIHandler()
		{
			if (AdSessionStatePublisher.cb_i == null)
			{
				AdSessionStatePublisher.cb_i = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdSessionStatePublisher.n_I));
			}
			return AdSessionStatePublisher.cb_i;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003536 File Offset: 0x00001736
		private static void n_I(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdSessionStatePublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).I();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003545 File Offset: 0x00001745
		[Register("i", "()V", "GetIHandler")]
		public virtual void I()
		{
			AdSessionStatePublisher._members.InstanceMethods.InvokeVirtualVoidMethod("i.()V", this, null);
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/publisher/AdSessionStatePublisher", typeof(AdSessionStatePublisher));

		// Token: 0x04000016 RID: 22
		private static Delegate cb_getWebView;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_a;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_a_Z;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_a_Lcom_iab_omid_library_adcolony_adsession_AdEvents_;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_a_Lcom_iab_omid_library_adcolony_adsession_AdSessionConfiguration_;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_a_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_a_Lcom_iab_omid_library_adcolony_adsession_media_MediaEvents_;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_a_F;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_a_Ljava_lang_String_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_a_Ljava_lang_String_J;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_a_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_a_Lorg_json_JSONObject_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_b;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_b_Ljava_lang_String_J;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_c;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_d;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_e;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_f;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_g;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_h;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_i;
	}
}
