using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001D2 RID: 466
	[Register("com/unity3d/services/ads/webplayer/WebPlayerSettingsCache", DoNotGenerateAcw = true)]
	public class WebPlayerSettingsCache : Java.Lang.Object
	{
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0003C694 File Offset: 0x0003A894
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerSettingsCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0003C6B8 File Offset: 0x0003A8B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerSettingsCache._members;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0003C6C0 File Offset: 0x0003A8C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerSettingsCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0003C6E4 File Offset: 0x0003A8E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerSettingsCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebPlayerSettingsCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0003C6F0 File Offset: 0x0003A8F0
		[Register(".ctor", "()V", "")]
		public WebPlayerSettingsCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebPlayerSettingsCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebPlayerSettingsCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0003C760 File Offset: 0x0003A960
		public static WebPlayerSettingsCache Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/ads/webplayer/WebPlayerSettingsCache;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerSettingsCache>(WebPlayerSettingsCache._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/ads/webplayer/WebPlayerSettingsCache;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0003C791 File Offset: 0x0003A991
		private static Delegate GetAddWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (WebPlayerSettingsCache.cb_addWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				WebPlayerSettingsCache.cb_addWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebPlayerSettingsCache.n_AddWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return WebPlayerSettingsCache.cb_addWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		private static void n_AddWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId, IntPtr native_webPlayerEventSettings)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_webPlayerEventSettings, JniHandleOwnership.DoNotTransfer);
			@object.AddWebPlayerEventSettings(@string, object2);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0003C7E4 File Offset: 0x0003A9E4
		[Register("addWebPlayerEventSettings", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetAddWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void AddWebPlayerEventSettings(string viewId, JSONObject webPlayerEventSettings)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((webPlayerEventSettings == null) ? IntPtr.Zero : webPlayerEventSettings.Handle);
				WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualVoidMethod("addWebPlayerEventSettings.(Ljava/lang/String;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(webPlayerEventSettings);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0003C868 File Offset: 0x0003AA68
		private static Delegate GetAddWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (WebPlayerSettingsCache.cb_addWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				WebPlayerSettingsCache.cb_addWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebPlayerSettingsCache.n_AddWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return WebPlayerSettingsCache.cb_addWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0003C88C File Offset: 0x0003AA8C
		private static void n_AddWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId, IntPtr native_webPlayerSettings)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_webPlayerSettings, JniHandleOwnership.DoNotTransfer);
			@object.AddWebPlayerSettings(@string, object2);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0003C8B8 File Offset: 0x0003AAB8
		[Register("addWebPlayerSettings", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetAddWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void AddWebPlayerSettings(string viewId, JSONObject webPlayerSettings)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((webPlayerSettings == null) ? IntPtr.Zero : webPlayerSettings.Handle);
				WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualVoidMethod("addWebPlayerSettings.(Ljava/lang/String;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(webPlayerSettings);
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0003C93C File Offset: 0x0003AB3C
		private static Delegate GetAddWebSettings_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (WebPlayerSettingsCache.cb_addWebSettings_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				WebPlayerSettingsCache.cb_addWebSettings_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebPlayerSettingsCache.n_AddWebSettings_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return WebPlayerSettingsCache.cb_addWebSettings_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0003C960 File Offset: 0x0003AB60
		private static void n_AddWebSettings_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId, IntPtr native_webSettings)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_webSettings, JniHandleOwnership.DoNotTransfer);
			@object.AddWebSettings(@string, object2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0003C98C File Offset: 0x0003AB8C
		[Register("addWebSettings", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetAddWebSettings_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void AddWebSettings(string viewId, JSONObject webSettings)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((webSettings == null) ? IntPtr.Zero : webSettings.Handle);
				WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualVoidMethod("addWebSettings.(Ljava/lang/String;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(webSettings);
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0003CA10 File Offset: 0x0003AC10
		private static Delegate GetGetWebPlayerEventSettings_Ljava_lang_String_Handler()
		{
			if (WebPlayerSettingsCache.cb_getWebPlayerEventSettings_Ljava_lang_String_ == null)
			{
				WebPlayerSettingsCache.cb_getWebPlayerEventSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebPlayerSettingsCache.n_GetWebPlayerEventSettings_Ljava_lang_String_));
			}
			return WebPlayerSettingsCache.cb_getWebPlayerEventSettings_Ljava_lang_String_;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0003CA34 File Offset: 0x0003AC34
		private static IntPtr n_GetWebPlayerEventSettings_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetWebPlayerEventSettings(@string));
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		[Register("getWebPlayerEventSettings", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetWebPlayerEventSettings_Ljava_lang_String_Handler")]
		public unsafe virtual JSONObject GetWebPlayerEventSettings(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONObject>(WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualObjectMethod("getWebPlayerEventSettings.(Ljava/lang/String;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		private static Delegate GetGetWebPlayerSettings_Ljava_lang_String_Handler()
		{
			if (WebPlayerSettingsCache.cb_getWebPlayerSettings_Ljava_lang_String_ == null)
			{
				WebPlayerSettingsCache.cb_getWebPlayerSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebPlayerSettingsCache.n_GetWebPlayerSettings_Ljava_lang_String_));
			}
			return WebPlayerSettingsCache.cb_getWebPlayerSettings_Ljava_lang_String_;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		private static IntPtr n_GetWebPlayerSettings_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetWebPlayerSettings(@string));
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0003CB14 File Offset: 0x0003AD14
		[Register("getWebPlayerSettings", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetWebPlayerSettings_Ljava_lang_String_Handler")]
		public unsafe virtual JSONObject GetWebPlayerSettings(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONObject>(WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualObjectMethod("getWebPlayerSettings.(Ljava/lang/String;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0003CB80 File Offset: 0x0003AD80
		private static Delegate GetGetWebSettings_Ljava_lang_String_Handler()
		{
			if (WebPlayerSettingsCache.cb_getWebSettings_Ljava_lang_String_ == null)
			{
				WebPlayerSettingsCache.cb_getWebSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebPlayerSettingsCache.n_GetWebSettings_Ljava_lang_String_));
			}
			return WebPlayerSettingsCache.cb_getWebSettings_Ljava_lang_String_;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0003CBA4 File Offset: 0x0003ADA4
		private static IntPtr n_GetWebSettings_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetWebSettings(@string));
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0003CBCC File Offset: 0x0003ADCC
		[Register("getWebSettings", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetWebSettings_Ljava_lang_String_Handler")]
		public unsafe virtual JSONObject GetWebSettings(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONObject>(WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualObjectMethod("getWebSettings.(Ljava/lang/String;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0003CC38 File Offset: 0x0003AE38
		private static Delegate GetRemoveWebPlayerEventSettings_Ljava_lang_String_Handler()
		{
			if (WebPlayerSettingsCache.cb_removeWebPlayerEventSettings_Ljava_lang_String_ == null)
			{
				WebPlayerSettingsCache.cb_removeWebPlayerEventSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerSettingsCache.n_RemoveWebPlayerEventSettings_Ljava_lang_String_));
			}
			return WebPlayerSettingsCache.cb_removeWebPlayerEventSettings_Ljava_lang_String_;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0003CC5C File Offset: 0x0003AE5C
		private static void n_RemoveWebPlayerEventSettings_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			@object.RemoveWebPlayerEventSettings(@string);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0003CC80 File Offset: 0x0003AE80
		[Register("removeWebPlayerEventSettings", "(Ljava/lang/String;)V", "GetRemoveWebPlayerEventSettings_Ljava_lang_String_Handler")]
		public unsafe virtual void RemoveWebPlayerEventSettings(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeWebPlayerEventSettings.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0003CCDC File Offset: 0x0003AEDC
		private static Delegate GetRemoveWebPlayerSettings_Ljava_lang_String_Handler()
		{
			if (WebPlayerSettingsCache.cb_removeWebPlayerSettings_Ljava_lang_String_ == null)
			{
				WebPlayerSettingsCache.cb_removeWebPlayerSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerSettingsCache.n_RemoveWebPlayerSettings_Ljava_lang_String_));
			}
			return WebPlayerSettingsCache.cb_removeWebPlayerSettings_Ljava_lang_String_;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0003CD00 File Offset: 0x0003AF00
		private static void n_RemoveWebPlayerSettings_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			@object.RemoveWebPlayerSettings(@string);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0003CD24 File Offset: 0x0003AF24
		[Register("removeWebPlayerSettings", "(Ljava/lang/String;)V", "GetRemoveWebPlayerSettings_Ljava_lang_String_Handler")]
		public unsafe virtual void RemoveWebPlayerSettings(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeWebPlayerSettings.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0003CD80 File Offset: 0x0003AF80
		private static Delegate GetRemoveWebSettings_Ljava_lang_String_Handler()
		{
			if (WebPlayerSettingsCache.cb_removeWebSettings_Ljava_lang_String_ == null)
			{
				WebPlayerSettingsCache.cb_removeWebSettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerSettingsCache.n_RemoveWebSettings_Ljava_lang_String_));
			}
			return WebPlayerSettingsCache.cb_removeWebSettings_Ljava_lang_String_;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0003CDA4 File Offset: 0x0003AFA4
		private static void n_RemoveWebSettings_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerSettingsCache @object = Java.Lang.Object.GetObject<WebPlayerSettingsCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			@object.RemoveWebSettings(@string);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
		[Register("removeWebSettings", "(Ljava/lang/String;)V", "GetRemoveWebSettings_Ljava_lang_String_Handler")]
		public unsafe virtual void RemoveWebSettings(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebPlayerSettingsCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeWebSettings.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040004FE RID: 1278
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerSettingsCache", typeof(WebPlayerSettingsCache));

		// Token: 0x040004FF RID: 1279
		private static Delegate cb_addWebPlayerEventSettings_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x04000500 RID: 1280
		private static Delegate cb_addWebPlayerSettings_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x04000501 RID: 1281
		private static Delegate cb_addWebSettings_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x04000502 RID: 1282
		private static Delegate cb_getWebPlayerEventSettings_Ljava_lang_String_;

		// Token: 0x04000503 RID: 1283
		private static Delegate cb_getWebPlayerSettings_Ljava_lang_String_;

		// Token: 0x04000504 RID: 1284
		private static Delegate cb_getWebSettings_Ljava_lang_String_;

		// Token: 0x04000505 RID: 1285
		private static Delegate cb_removeWebPlayerEventSettings_Ljava_lang_String_;

		// Token: 0x04000506 RID: 1286
		private static Delegate cb_removeWebPlayerSettings_Ljava_lang_String_;

		// Token: 0x04000507 RID: 1287
		private static Delegate cb_removeWebSettings_Ljava_lang_String_;
	}
}
