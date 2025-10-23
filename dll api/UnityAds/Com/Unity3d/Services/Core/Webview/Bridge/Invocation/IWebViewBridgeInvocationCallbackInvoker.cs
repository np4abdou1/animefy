using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x02000088 RID: 136
	[Register("com/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback", DoNotGenerateAcw = true)]
	internal class IWebViewBridgeInvocationCallbackInvoker : Java.Lang.Object, IWebViewBridgeInvocationCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebViewBridgeInvocationCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebViewBridgeInvocationCallbackInvoker._members;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000DEEF File Offset: 0x0000C0EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000DEF7 File Offset: 0x0000C0F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebViewBridgeInvocationCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000DF03 File Offset: 0x0000C103
		public static IWebViewBridgeInvocationCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebViewBridgeInvocationCallback>(handle, transfer);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000DF0C File Offset: 0x0000C10C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebViewBridgeInvocationCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.webview.bridge.invocation.IWebViewBridgeInvocationCallback'.");
			}
			return handle;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000DF37 File Offset: 0x0000C137
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000DF68 File Offset: 0x0000C168
		public IWebViewBridgeInvocationCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebViewBridgeInvocationCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
		private static Delegate GetOnFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Handler()
		{
			if (IWebViewBridgeInvocationCallbackInvoker.cb_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_ == null)
			{
				IWebViewBridgeInvocationCallbackInvoker.cb_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IWebViewBridgeInvocationCallbackInvoker.n_OnFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_));
			}
			return IWebViewBridgeInvocationCallbackInvoker.cb_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
		private static void n_OnFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IWebViewBridgeInvocationCallback @object = Java.Lang.Object.GetObject<IWebViewBridgeInvocationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			CallbackStatus object2 = Java.Lang.Object.GetObject<CallbackStatus>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnFailure(@string, object2);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		public unsafe void OnFailure(string p0, CallbackStatus p1)
		{
			if (this.id_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_ == IntPtr.Zero)
			{
				this.id_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_ = JNIEnv.GetMethodID(this.class_ref, "onFailure", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/CallbackStatus;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000E083 File Offset: 0x0000C283
		private static Delegate GetOnSuccessHandler()
		{
			if (IWebViewBridgeInvocationCallbackInvoker.cb_onSuccess == null)
			{
				IWebViewBridgeInvocationCallbackInvoker.cb_onSuccess = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IWebViewBridgeInvocationCallbackInvoker.n_OnSuccess));
			}
			return IWebViewBridgeInvocationCallbackInvoker.cb_onSuccess;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000E0A7 File Offset: 0x0000C2A7
		private static void n_OnSuccess(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IWebViewBridgeInvocationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSuccess();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000E0B6 File Offset: 0x0000C2B6
		public void OnSuccess()
		{
			if (this.id_onSuccess == IntPtr.Zero)
			{
				this.id_onSuccess = JNIEnv.GetMethodID(this.class_ref, "onSuccess", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSuccess);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		private static Delegate GetOnTimeoutHandler()
		{
			if (IWebViewBridgeInvocationCallbackInvoker.cb_onTimeout == null)
			{
				IWebViewBridgeInvocationCallbackInvoker.cb_onTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IWebViewBridgeInvocationCallbackInvoker.n_OnTimeout));
			}
			return IWebViewBridgeInvocationCallbackInvoker.cb_onTimeout;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000E11A File Offset: 0x0000C31A
		private static void n_OnTimeout(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IWebViewBridgeInvocationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTimeout();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000E129 File Offset: 0x0000C329
		public void OnTimeout()
		{
			if (this.id_onTimeout == IntPtr.Zero)
			{
				this.id_onTimeout = JNIEnv.GetMethodID(this.class_ref, "onTimeout", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTimeout);
		}

		// Token: 0x04000104 RID: 260
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback", typeof(IWebViewBridgeInvocationCallbackInvoker));

		// Token: 0x04000105 RID: 261
		private IntPtr class_ref;

		// Token: 0x04000106 RID: 262
		private static Delegate cb_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_;

		// Token: 0x04000107 RID: 263
		private IntPtr id_onFailure_Ljava_lang_String_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_onSuccess;

		// Token: 0x04000109 RID: 265
		private IntPtr id_onSuccess;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_onTimeout;

		// Token: 0x0400010B RID: 267
		private IntPtr id_onTimeout;
	}
}
