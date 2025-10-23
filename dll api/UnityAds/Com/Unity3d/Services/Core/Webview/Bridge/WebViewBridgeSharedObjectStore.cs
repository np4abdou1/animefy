using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000081 RID: 129
	[Register("com/unity3d/services/core/webview/bridge/WebViewBridgeSharedObjectStore", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends com.unity3d.services.core.webview.bridge.IWebViewSharedObject"
	})]
	public abstract class WebViewBridgeSharedObjectStore : Java.Lang.Object, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000D304 File Offset: 0x0000B504
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeSharedObjectStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000D328 File Offset: 0x0000B528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeSharedObjectStore._members;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000D330 File Offset: 0x0000B530
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeSharedObjectStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000D354 File Offset: 0x0000B554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeSharedObjectStore._members.ManagedPeerType;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridgeSharedObjectStore(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000D360 File Offset: 0x0000B560
		[Register(".ctor", "()V", "")]
		public WebViewBridgeSharedObjectStore() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewBridgeSharedObjectStore._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewBridgeSharedObjectStore._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000D3CE File Offset: 0x0000B5CE
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (WebViewBridgeSharedObjectStore.cb_get_Ljava_lang_String_ == null)
			{
				WebViewBridgeSharedObjectStore.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebViewBridgeSharedObjectStore.n_Get_Ljava_lang_String_));
			}
			return WebViewBridgeSharedObjectStore.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			WebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<WebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000D41C File Offset: 0x0000B61C
		[Register("get", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;", "GetGet_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object Get(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(WebViewBridgeSharedObjectStore._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000D488 File Offset: 0x0000B688
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (WebViewBridgeSharedObjectStore.cb_remove_Ljava_lang_String_ == null)
			{
				WebViewBridgeSharedObjectStore.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewBridgeSharedObjectStore.n_Remove_Ljava_lang_String_));
			}
			return WebViewBridgeSharedObjectStore.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			WebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<WebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_id, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Register("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public unsafe virtual void Remove(string id)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebViewBridgeSharedObjectStore._members.InstanceMethods.InvokeVirtualVoidMethod("remove.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000D52C File Offset: 0x0000B72C
		private static Delegate GetRemove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler()
		{
			if (WebViewBridgeSharedObjectStore.cb_remove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == null)
			{
				WebViewBridgeSharedObjectStore.cb_remove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewBridgeSharedObjectStore.n_Remove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_));
			}
			return WebViewBridgeSharedObjectStore.cb_remove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000D550 File Offset: 0x0000B750
		private static void n_Remove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedObject)
		{
			WebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<WebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_sharedObject, JniHandleOwnership.DoNotTransfer);
			@object.Remove(object2);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000D574 File Offset: 0x0000B774
		[Register("remove", "(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V", "GetRemove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler")]
		public unsafe virtual void Remove(Java.Lang.Object sharedObject)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(sharedObject);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebViewBridgeSharedObjectStore._members.InstanceMethods.InvokeVirtualVoidMethod("remove.(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(sharedObject);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		private static Delegate GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler()
		{
			if (WebViewBridgeSharedObjectStore.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == null)
			{
				WebViewBridgeSharedObjectStore.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewBridgeSharedObjectStore.n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_));
			}
			return WebViewBridgeSharedObjectStore.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		private static void n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedObject)
		{
			WebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<WebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_sharedObject, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000D620 File Offset: 0x0000B820
		[Register("set", "(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V", "GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler")]
		public unsafe virtual void Set(Java.Lang.Object sharedObject)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(sharedObject);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebViewBridgeSharedObjectStore._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(sharedObject);
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewBridgeSharedObjectStore", typeof(WebViewBridgeSharedObjectStore));

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_remove_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
	}
}
