using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Webkit;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001D3 RID: 467
	[Register("com/unity3d/services/ads/webplayer/WebPlayerView", DoNotGenerateAcw = true)]
	public class WebPlayerView : WebView
	{
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x0003CE40 File Offset: 0x0003B040
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x0003CE64 File Offset: 0x0003B064
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerView._members;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0003CE6C File Offset: 0x0003B06C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0003CE90 File Offset: 0x0003B090
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerView._members.ManagedPeerType;
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00009D80 File Offset: 0x00007F80
		protected WebPlayerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0003CE9C File Offset: 0x0003B09C
		[Register(".ctor", "(Landroid/content/Context;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;)V", "")]
		public unsafe WebPlayerView(Context context, string viewId, JSONObject webSettings, JSONObject webPlayerSettings) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((webSettings == null) ? IntPtr.Zero : webSettings.Handle);
				ptr[3] = new JniArgumentValue((webPlayerSettings == null) ? IntPtr.Zero : webPlayerSettings.Handle);
				base.SetHandle(WebPlayerView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebPlayerView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(webSettings);
				GC.KeepAlive(webPlayerSettings);
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
		private static Delegate GetGetErroredSettingsHandler()
		{
			if (WebPlayerView.cb_getErroredSettings == null)
			{
				WebPlayerView.cb_getErroredSettings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebPlayerView.n_GetErroredSettings));
			}
			return WebPlayerView.cb_getErroredSettings;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
		private static IntPtr n_GetErroredSettings(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErroredSettings);
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0003CFFC File Offset: 0x0003B1FC
		public virtual IDictionary<string, string> ErroredSettings
		{
			[Register("getErroredSettings", "()Ljava/util/Map;", "GetGetErroredSettingsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(WebPlayerView._members.InstanceMethods.InvokeVirtualObjectMethod("getErroredSettings.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0003D02E File Offset: 0x0003B22E
		private static Delegate GetGetPrimitiveClass_Ljava_lang_Class_Handler()
		{
			if (WebPlayerView.cb_getPrimitiveClass_Ljava_lang_Class_ == null)
			{
				WebPlayerView.cb_getPrimitiveClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebPlayerView.n_GetPrimitiveClass_Ljava_lang_Class_));
			}
			return WebPlayerView.cb_getPrimitiveClass_Ljava_lang_Class_;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0003D054 File Offset: 0x0003B254
		private static IntPtr n_GetPrimitiveClass_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_className)
		{
			WebPlayerView @object = Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_className, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetPrimitiveClass(object2));
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0003D07C File Offset: 0x0003B27C
		[Register("getPrimitiveClass", "(Ljava/lang/Class;)Ljava/lang/Class;", "GetGetPrimitiveClass_Ljava_lang_Class_Handler")]
		public unsafe virtual Class GetPrimitiveClass(Class className)
		{
			Class @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((className == null) ? IntPtr.Zero : className.Handle);
				@object = Java.Lang.Object.GetObject<Class>(WebPlayerView._members.InstanceMethods.InvokeVirtualObjectMethod("getPrimitiveClass.(Ljava/lang/Class;)Ljava/lang/Class;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(className);
			}
			return @object;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0003D0F0 File Offset: 0x0003B2F0
		private static Delegate GetInvokeJavascript_Ljava_lang_String_Handler()
		{
			if (WebPlayerView.cb_invokeJavascript_Ljava_lang_String_ == null)
			{
				WebPlayerView.cb_invokeJavascript_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerView.n_InvokeJavascript_Ljava_lang_String_));
			}
			return WebPlayerView.cb_invokeJavascript_Ljava_lang_String_;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0003D114 File Offset: 0x0003B314
		private static void n_InvokeJavascript_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			WebPlayerView @object = Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_data, JniHandleOwnership.DoNotTransfer);
			@object.InvokeJavascript(@string);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0003D138 File Offset: 0x0003B338
		[Register("invokeJavascript", "(Ljava/lang/String;)V", "GetInvokeJavascript_Ljava_lang_String_Handler")]
		public unsafe virtual void InvokeJavascript(string data)
		{
			IntPtr intPtr = JNIEnv.NewString(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("invokeJavascript.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0003D194 File Offset: 0x0003B394
		private static Delegate GetOnLayoutChangeHandler()
		{
			if (WebPlayerView.cb_onLayoutChange == null)
			{
				WebPlayerView.cb_onLayoutChange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebPlayerView.n_OnLayoutChange));
			}
			return WebPlayerView.cb_onLayoutChange;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		private static void n_OnLayoutChange(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayoutChange();
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0003D1C7 File Offset: 0x0003B3C7
		[Register("onLayoutChange", "()V", "GetOnLayoutChangeHandler")]
		public virtual void OnLayoutChange()
		{
			WebPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("onLayoutChange.()V", this, null);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		private static Delegate GetSendEvent_Lorg_json_JSONArray_Handler()
		{
			if (WebPlayerView.cb_sendEvent_Lorg_json_JSONArray_ == null)
			{
				WebPlayerView.cb_sendEvent_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerView.n_SendEvent_Lorg_json_JSONArray_));
			}
			return WebPlayerView.cb_sendEvent_Lorg_json_JSONArray_;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0003D204 File Offset: 0x0003B404
		private static void n_SendEvent_Lorg_json_JSONArray_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			WebPlayerView @object = Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONArray object2 = Java.Lang.Object.GetObject<JSONArray>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.SendEvent(object2);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0003D228 File Offset: 0x0003B428
		[Register("sendEvent", "(Lorg/json/JSONArray;)V", "GetSendEvent_Lorg_json_JSONArray_Handler")]
		public unsafe virtual void SendEvent(JSONArray @params)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				WebPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("sendEvent.(Lorg/json/JSONArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0003D28C File Offset: 0x0003B48C
		private static Delegate GetSetEventSettings_Lorg_json_JSONObject_Handler()
		{
			if (WebPlayerView.cb_setEventSettings_Lorg_json_JSONObject_ == null)
			{
				WebPlayerView.cb_setEventSettings_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerView.n_SetEventSettings_Lorg_json_JSONObject_));
			}
			return WebPlayerView.cb_setEventSettings_Lorg_json_JSONObject_;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0003D2B0 File Offset: 0x0003B4B0
		private static void n_SetEventSettings_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_eventSettings)
		{
			WebPlayerView @object = Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_eventSettings, JniHandleOwnership.DoNotTransfer);
			@object.SetEventSettings(object2);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		[Register("setEventSettings", "(Lorg/json/JSONObject;)V", "GetSetEventSettings_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void SetEventSettings(JSONObject eventSettings)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventSettings == null) ? IntPtr.Zero : eventSettings.Handle);
				WebPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("setEventSettings.(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(eventSettings);
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0003D338 File Offset: 0x0003B538
		private static Delegate GetSetSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler()
		{
			if (WebPlayerView.cb_setSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_ == null)
			{
				WebPlayerView.cb_setSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebPlayerView.n_SetSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_));
			}
			return WebPlayerView.cb_setSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0003D35C File Offset: 0x0003B55C
		private static void n_SetSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_webSettings, IntPtr native_webPlayerSettings)
		{
			WebPlayerView @object = Java.Lang.Object.GetObject<WebPlayerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_webSettings, JniHandleOwnership.DoNotTransfer);
			JSONObject object3 = Java.Lang.Object.GetObject<JSONObject>(native_webPlayerSettings, JniHandleOwnership.DoNotTransfer);
			@object.SetSettings(object2, object3);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0003D388 File Offset: 0x0003B588
		[Register("setSettings", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)V", "GetSetSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void SetSettings(JSONObject webSettings, JSONObject webPlayerSettings)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webSettings == null) ? IntPtr.Zero : webSettings.Handle);
				ptr[1] = new JniArgumentValue((webPlayerSettings == null) ? IntPtr.Zero : webPlayerSettings.Handle);
				WebPlayerView._members.InstanceMethods.InvokeVirtualVoidMethod("setSettings.(Lorg/json/JSONObject;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webSettings);
				GC.KeepAlive(webPlayerSettings);
			}
		}

		// Token: 0x04000508 RID: 1288
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerView", typeof(WebPlayerView));

		// Token: 0x04000509 RID: 1289
		private static Delegate cb_getErroredSettings;

		// Token: 0x0400050A RID: 1290
		private static Delegate cb_getPrimitiveClass_Ljava_lang_Class_;

		// Token: 0x0400050B RID: 1291
		private static Delegate cb_invokeJavascript_Ljava_lang_String_;

		// Token: 0x0400050C RID: 1292
		private static Delegate cb_onLayoutChange;

		// Token: 0x0400050D RID: 1293
		private static Delegate cb_sendEvent_Lorg_json_JSONArray_;

		// Token: 0x0400050E RID: 1294
		private static Delegate cb_setEventSettings_Lorg_json_JSONObject_;

		// Token: 0x0400050F RID: 1295
		private static Delegate cb_setSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_;
	}
}
