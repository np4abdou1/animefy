using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x0200007F RID: 127
	[Register("com/unity3d/services/core/webview/bridge/WebViewBridgeInterface", DoNotGenerateAcw = true)]
	public class WebViewBridgeInterface : Java.Lang.Object
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0000CE30 File Offset: 0x0000B030
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeInterface._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000CE54 File Offset: 0x0000B054
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeInterface._members;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0000CE5C File Offset: 0x0000B05C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeInterface._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000CE80 File Offset: 0x0000B080
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeInterface._members.ManagedPeerType;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridgeInterface(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000CE8C File Offset: 0x0000B08C
		[Register(".ctor", "()V", "")]
		public WebViewBridgeInterface() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewBridgeInterface._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewBridgeInterface._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000CEFA File Offset: 0x0000B0FA
		private static Delegate GetHandleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (WebViewBridgeInterface.cb_handleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				WebViewBridgeInterface.cb_handleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(WebViewBridgeInterface.n_HandleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			}
			return WebViewBridgeInterface.cb_handleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000CF20 File Offset: 0x0000B120
		private static void n_HandleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_callbackId, IntPtr native_callbackStatus, IntPtr native_rawParameters)
		{
			WebViewBridgeInterface @object = Java.Lang.Object.GetObject<WebViewBridgeInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_callbackId, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_callbackStatus, JniHandleOwnership.DoNotTransfer);
			string string3 = JNIEnv.GetString(native_rawParameters, JniHandleOwnership.DoNotTransfer);
			@object.HandleCallback(@string, string2, string3);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000CF58 File Offset: 0x0000B158
		[Register("handleCallback", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetHandleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void HandleCallback(string callbackId, string callbackStatus, string rawParameters)
		{
			IntPtr intPtr = JNIEnv.NewString(callbackId);
			IntPtr intPtr2 = JNIEnv.NewString(callbackStatus);
			IntPtr intPtr3 = JNIEnv.NewString(rawParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				WebViewBridgeInterface._members.InstanceMethods.InvokeVirtualVoidMethod("handleCallback.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		private static Delegate GetHandleInvocation_Ljava_lang_String_Handler()
		{
			if (WebViewBridgeInterface.cb_handleInvocation_Ljava_lang_String_ == null)
			{
				WebViewBridgeInterface.cb_handleInvocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewBridgeInterface.n_HandleInvocation_Ljava_lang_String_));
			}
			return WebViewBridgeInterface.cb_handleInvocation_Ljava_lang_String_;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000D01C File Offset: 0x0000B21C
		private static void n_HandleInvocation_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			WebViewBridgeInterface @object = Java.Lang.Object.GetObject<WebViewBridgeInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_data, JniHandleOwnership.DoNotTransfer);
			@object.HandleInvocation(@string);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000D040 File Offset: 0x0000B240
		[Register("handleInvocation", "(Ljava/lang/String;)V", "GetHandleInvocation_Ljava_lang_String_Handler")]
		public unsafe virtual void HandleInvocation(string data)
		{
			IntPtr intPtr = JNIEnv.NewString(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebViewBridgeInterface._members.InstanceMethods.InvokeVirtualVoidMethod("handleInvocation.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040000EE RID: 238
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewBridgeInterface", typeof(WebViewBridgeInterface));

		// Token: 0x040000EF RID: 239
		private static Delegate cb_handleCallback_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000F0 RID: 240
		private static Delegate cb_handleInvocation_Ljava_lang_String_;
	}
}
