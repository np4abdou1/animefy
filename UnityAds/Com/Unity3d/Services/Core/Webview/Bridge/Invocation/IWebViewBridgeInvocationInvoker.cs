using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge.Invocation
{
	// Token: 0x02000086 RID: 134
	[Register("com/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation", DoNotGenerateAcw = true)]
	internal class IWebViewBridgeInvocationInvoker : Java.Lang.Object, IWebViewBridgeInvocation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebViewBridgeInvocationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebViewBridgeInvocationInvoker._members;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000DCA7 File Offset: 0x0000BEA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000DCAF File Offset: 0x0000BEAF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebViewBridgeInvocationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000DCBB File Offset: 0x0000BEBB
		public static IWebViewBridgeInvocation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebViewBridgeInvocation>(handle, transfer);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebViewBridgeInvocationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.webview.bridge.invocation.IWebViewBridgeInvocation'.");
			}
			return handle;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000DCEF File Offset: 0x0000BEEF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000DD20 File Offset: 0x0000BF20
		public IWebViewBridgeInvocationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebViewBridgeInvocationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000DD58 File Offset: 0x0000BF58
		private static Delegate GetInvoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_Handler()
		{
			if (IWebViewBridgeInvocationInvoker.cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_ == null)
			{
				IWebViewBridgeInvocationInvoker.cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_V(IWebViewBridgeInvocationInvoker.n_Invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_));
			}
			return IWebViewBridgeInvocationInvoker.cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		private static void n_Invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			IWebViewBridgeInvocation @object = Java.Lang.Object.GetObject<IWebViewBridgeInvocation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(@string, string2, p2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_p3);
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		public unsafe void Invoke(string p0, string p1, int p2, params Java.Lang.Object[] p3)
		{
			if (this.id_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(p3);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue(intPtr3);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			if (p3 != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, p3);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
		}

		// Token: 0x04000100 RID: 256
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation", typeof(IWebViewBridgeInvocationInvoker));

		// Token: 0x04000101 RID: 257
		private IntPtr class_ref;

		// Token: 0x04000102 RID: 258
		private static Delegate cb_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_;

		// Token: 0x04000103 RID: 259
		private IntPtr id_invoke_Ljava_lang_String_Ljava_lang_String_IarrayLjava_lang_Object_;
	}
}
