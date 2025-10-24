using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000075 RID: 117
	[Register("com/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker", DoNotGenerateAcw = true)]
	internal class IWebViewBridgeInvokerInvoker : Java.Lang.Object, IWebViewBridgeInvoker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000BB78 File Offset: 0x00009D78
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebViewBridgeInvokerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000BB9C File Offset: 0x00009D9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebViewBridgeInvokerInvoker._members;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0000BBA3 File Offset: 0x00009DA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000BBAB File Offset: 0x00009DAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebViewBridgeInvokerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000BBB7 File Offset: 0x00009DB7
		public static IWebViewBridgeInvoker GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(handle, transfer);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebViewBridgeInvokerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.webview.bridge.IWebViewBridgeInvoker'.");
			}
			return handle;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000BBEB File Offset: 0x00009DEB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000BC1C File Offset: 0x00009E1C
		public IWebViewBridgeInvokerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebViewBridgeInvokerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000BC54 File Offset: 0x00009E54
		private static Delegate GetInvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler()
		{
			if (IWebViewBridgeInvokerInvoker.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
			{
				IWebViewBridgeInvokerInvoker.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_Z(IWebViewBridgeInvokerInvoker.n_InvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_));
			}
			return IWebViewBridgeInvokerInvoker.cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000BC78 File Offset: 0x00009E78
		private static bool n_InvokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			IWebViewBridgeInvoker @object = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			Method object2 = Java.Lang.Object.GetObject<Method>(native_p2, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			bool result = @object.InvokeMethod(@string, string2, object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_p3);
			}
			return result;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		public unsafe bool InvokeMethod(string p0, string p1, Method p2, params Java.Lang.Object[] p3)
		{
			if (this.id_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invokeMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(p3);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			ptr[3] = new JValue(intPtr3);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			if (p3 != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, p3);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return result;
		}

		// Token: 0x040000CF RID: 207
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker", typeof(IWebViewBridgeInvokerInvoker));

		// Token: 0x040000D0 RID: 208
		private IntPtr class_ref;

		// Token: 0x040000D1 RID: 209
		private static Delegate cb_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;

		// Token: 0x040000D2 RID: 210
		private IntPtr id_invokeMethod_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
	}
}
