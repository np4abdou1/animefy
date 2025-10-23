using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x0200007C RID: 124
	[Register("com/unity3d/services/core/webview/bridge/NativeCallback", DoNotGenerateAcw = true)]
	public class NativeCallback : Java.Lang.Object
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		internal static IntPtr class_ref
		{
			get
			{
				return NativeCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NativeCallback._members;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NativeCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000C614 File Offset: 0x0000A814
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NativeCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000021E8 File Offset: 0x000003E8
		protected NativeCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000C620 File Offset: 0x0000A820
		[Register(".ctor", "(Ljava/lang/reflect/Method;)V", "")]
		public unsafe NativeCallback(Method callback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				base.SetHandle(NativeCallback._members.InstanceMethods.StartCreateInstance("(Ljava/lang/reflect/Method;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NativeCallback._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/reflect/Method;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		private static Delegate GetGetIdHandler()
		{
			if (NativeCallback.cb_getId == null)
			{
				NativeCallback.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NativeCallback.n_GetId));
			}
			return NativeCallback.cb_getId;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NativeCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000C708 File Offset: 0x0000A908
		public virtual string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(NativeCallback._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000C73A File Offset: 0x0000A93A
		private static Delegate GetInvoke_Ljava_lang_String_arrayLjava_lang_Object_Handler()
		{
			if (NativeCallback.cb_invoke_Ljava_lang_String_arrayLjava_lang_Object_ == null)
			{
				NativeCallback.cb_invoke_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(NativeCallback.n_Invoke_Ljava_lang_String_arrayLjava_lang_Object_));
			}
			return NativeCallback.cb_invoke_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000C760 File Offset: 0x0000A960
		private static void n_Invoke_Ljava_lang_String_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_status, IntPtr native_values)
		{
			NativeCallback @object = Java.Lang.Object.GetObject<NativeCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_status, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_values, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(@string, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_values);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		[Register("invoke", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetInvoke_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public unsafe virtual void Invoke(string status, params Java.Lang.Object[] values)
		{
			IntPtr intPtr = JNIEnv.NewString(status);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(values);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				NativeCallback._members.InstanceMethods.InvokeVirtualVoidMethod("invoke.(Ljava/lang/String;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (values != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, values);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(values);
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/NativeCallback", typeof(NativeCallback));

		// Token: 0x040000EA RID: 234
		private static Delegate cb_getId;

		// Token: 0x040000EB RID: 235
		private static Delegate cb_invoke_Ljava_lang_String_arrayLjava_lang_Object_;
	}
}
