using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000080 RID: 128
	[Register("com/unity3d/services/core/webview/bridge/WebViewBridgeInvoker", DoNotGenerateAcw = true)]
	public class WebViewBridgeInvoker : Java.Lang.Object, IWebViewBridgeInvoker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0000D0DC File Offset: 0x0000B2DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeInvoker._members;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0000D108 File Offset: 0x0000B308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridgeInvoker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000D114 File Offset: 0x0000B314
		[Register(".ctor", "()V", "")]
		public WebViewBridgeInvoker() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewBridgeInvoker._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewBridgeInvoker._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000D182 File Offset: 0x0000B382
		private static Delegate GetInvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler()
		{
			if (WebViewBridgeInvoker.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
			{
				WebViewBridgeInvoker.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_Z(WebViewBridgeInvoker.n_InvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_));
			}
			return WebViewBridgeInvoker.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		private static bool n_InvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_className, IntPtr native_methodName, IntPtr native_callbackMethod, IntPtr native_options)
		{
			WebViewBridgeInvoker @object = Java.Lang.Object.GetObject<WebViewBridgeInvoker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_className, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_methodName, JniHandleOwnership.DoNotTransfer);
			Method object2 = Java.Lang.Object.GetObject<Method>(native_callbackMethod, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_options, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			bool result = @object.InvokeMethod(@string, string2, object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_options);
			}
			return result;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000D204 File Offset: 0x0000B404
		[Register("invokeMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", "GetInvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public unsafe virtual bool InvokeMethod(string className, string methodName, Method callbackMethod, params Java.Lang.Object[] options)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(options);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callbackMethod == null) ? IntPtr.Zero : callbackMethod.Handle);
				ptr[3] = new JniArgumentValue(intPtr3);
				result = WebViewBridgeInvoker._members.InstanceMethods.InvokeVirtualBooleanMethod("invokeMethod.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (options != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, options);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(callbackMethod);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x040000F1 RID: 241
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewBridgeInvoker", typeof(WebViewBridgeInvoker));

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
	}
}
