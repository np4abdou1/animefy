using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x02000089 RID: 137
	[Register("com/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocation", DoNotGenerateAcw = true)]
	public class WebViewBridgeInvocation : Java.Lang.Object, IWebViewBridgeInvocation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0000E184 File Offset: 0x0000C384
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeInvocation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeInvocation._members;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeInvocation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeInvocation._members.ManagedPeerType;
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridgeInvocation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		[Register(".ctor", "(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback;)V", "")]
		public unsafe WebViewBridgeInvocation(IExecutorService _executorService, IWebViewBridgeInvoker webViewBridgeInvoker, IWebViewBridgeInvocationCallback invocationCallback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_executorService == null) ? IntPtr.Zero : ((Java.Lang.Object)_executorService).Handle);
				ptr[1] = new JniArgumentValue((webViewBridgeInvoker == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvoker).Handle);
				ptr[2] = new JniArgumentValue((invocationCallback == null) ? IntPtr.Zero : ((Java.Lang.Object)invocationCallback).Handle);
				base.SetHandle(WebViewBridgeInvocation._members.InstanceMethods.StartCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewBridgeInvocation._members.InstanceMethods.FinishCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocationCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_executorService);
				GC.KeepAlive(webViewBridgeInvoker);
				GC.KeepAlive(invocationCallback);
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		private static Delegate GetInvoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_Handler()
		{
			if (WebViewBridgeInvocation.cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_ == null)
			{
				WebViewBridgeInvocation.cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_V(WebViewBridgeInvocation.n_Invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_));
			}
			return WebViewBridgeInvocation.cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000E314 File Offset: 0x0000C514
		private static void n_Invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_className, IntPtr native_methodName, int timeoutLengthInMilliSeconds, IntPtr native_invocationParameters)
		{
			WebViewBridgeInvocation @object = Java.Lang.Object.GetObject<WebViewBridgeInvocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_className, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_methodName, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_invocationParameters, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(@string, string2, timeoutLengthInMilliSeconds, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_invocationParameters);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000E368 File Offset: 0x0000C568
		[Register("invoke", "(Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V", "GetInvoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_Handler")]
		public unsafe virtual void Invoke(string className, string methodName, int timeoutLengthInMilliSeconds, params Java.Lang.Object[] invocationParameters)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(invocationParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(timeoutLengthInMilliSeconds);
				ptr[3] = new JniArgumentValue(intPtr3);
				WebViewBridgeInvocation._members.InstanceMethods.InvokeVirtualVoidMethod("invoke.(Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (invocationParameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, invocationParameters);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(invocationParameters);
			}
		}

		// Token: 0x0400010C RID: 268
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/invocation/WebViewBridgeInvocation", typeof(WebViewBridgeInvocation));

		// Token: 0x0400010D RID: 269
		private static Delegate cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_;
	}
}
