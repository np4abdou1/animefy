using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000073 RID: 115
	[Register("com/unity3d/services/core/webview/bridge/Invocation", DoNotGenerateAcw = true)]
	public class Invocation2 : Java.Lang.Object
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000B668 File Offset: 0x00009868
		internal static IntPtr class_ref
		{
			get
			{
				return Invocation2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000B68C File Offset: 0x0000988C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Invocation2._members;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000B694 File Offset: 0x00009894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Invocation2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Invocation2._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Invocation2(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000B6C4 File Offset: 0x000098C4
		[Register(".ctor", "()V", "")]
		public Invocation2() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Invocation2._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Invocation2._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000B732 File Offset: 0x00009932
		private static Delegate GetGetIdHandler()
		{
			if (Invocation2.cb_getId == null)
			{
				Invocation2.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Invocation2.n_GetId));
			}
			return Invocation2.cb_getId;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000B756 File Offset: 0x00009956
		private static int n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Invocation2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000B765 File Offset: 0x00009965
		public virtual int Id
		{
			[Register("getId", "()I", "GetGetIdHandler")]
			get
			{
				return Invocation2._members.InstanceMethods.InvokeVirtualInt32Method("getId.()I", this, null);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000B77E File Offset: 0x0000997E
		private static Delegate GetGetResponsesHandler()
		{
			if (Invocation2.cb_getResponses == null)
			{
				Invocation2.cb_getResponses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Invocation2.n_GetResponses));
			}
			return Invocation2.cb_getResponses;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000B7A2 File Offset: 0x000099A2
		private static IntPtr n_GetResponses(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IList<Java.Lang.Object>>.ToLocalJniHandle(Java.Lang.Object.GetObject<Invocation2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Responses);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000B7B8 File Offset: 0x000099B8
		public virtual IList<IList<Java.Lang.Object>> Responses
		{
			[Register("getResponses", "()Ljava/util/ArrayList;", "GetGetResponsesHandler")]
			get
			{
				return JavaList<IList<Java.Lang.Object>>.FromJniHandle(Invocation2._members.InstanceMethods.InvokeVirtualObjectMethod("getResponses.()Ljava/util/ArrayList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000B7EA File Offset: 0x000099EA
		private static Delegate GetAddInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_Handler()
		{
			if (Invocation2.cb_addInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_ == null)
			{
				Invocation2.cb_addInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(Invocation2.n_AddInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_));
			}
			return Invocation2.cb_addInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000B810 File Offset: 0x00009A10
		private static void n_AddInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_className, IntPtr native_methodName, IntPtr native_parameters, IntPtr native__callback)
		{
			Invocation2 @object = Java.Lang.Object.GetObject<Invocation2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_className, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_methodName, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_parameters, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			WebViewCallback object2 = Java.Lang.Object.GetObject<WebViewCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.AddInvocation(@string, string2, array, object2);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_parameters);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000B86C File Offset: 0x00009A6C
		[Register("addInvocation", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "GetAddInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_Handler")]
		public unsafe virtual void AddInvocation(string className, string methodName, Java.Lang.Object[] parameters, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Invocation2._members.InstanceMethods.InvokeVirtualVoidMethod("addInvocation.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, parameters);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(parameters);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000B948 File Offset: 0x00009B48
		[Register("getInvocationById", "(I)Lcom/unity3d/services/core/webview/bridge/Invocation;", "")]
		public unsafe static Invocation2 GetInvocationById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<Invocation2>(Invocation2._members.StaticMethods.InvokeObjectMethod("getInvocationById.(I)Lcom/unity3d/services/core/webview/bridge/Invocation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000B990 File Offset: 0x00009B90
		private static Delegate GetNextInvocationHandler()
		{
			if (Invocation2.cb_nextInvocation == null)
			{
				Invocation2.cb_nextInvocation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Invocation2.n_NextInvocation));
			}
			return Invocation2.cb_nextInvocation;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		private static bool n_NextInvocation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Invocation2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextInvocation();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		[Register("nextInvocation", "()Z", "GetNextInvocationHandler")]
		public virtual bool NextInvocation()
		{
			return Invocation2._members.InstanceMethods.InvokeVirtualBooleanMethod("nextInvocation.()Z", this, null);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000B9DC File Offset: 0x00009BDC
		private static Delegate GetSendInvocationCallbackHandler()
		{
			if (Invocation2.cb_sendInvocationCallback == null)
			{
				Invocation2.cb_sendInvocationCallback = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Invocation2.n_SendInvocationCallback));
			}
			return Invocation2.cb_sendInvocationCallback;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000BA00 File Offset: 0x00009C00
		private static void n_SendInvocationCallback(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Invocation2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SendInvocationCallback();
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000BA0F File Offset: 0x00009C0F
		[Register("sendInvocationCallback", "()V", "GetSendInvocationCallbackHandler")]
		public virtual void SendInvocationCallback()
		{
			Invocation2._members.InstanceMethods.InvokeVirtualVoidMethod("sendInvocationCallback.()V", this, null);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000BA28 File Offset: 0x00009C28
		private static Delegate GetSetInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_Handler()
		{
			if (Invocation2.cb_setInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_ == null)
			{
				Invocation2.cb_setInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Invocation2.n_SetInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_));
			}
			return Invocation2.cb_setInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000BA4C File Offset: 0x00009C4C
		private static void n_SetInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_status, IntPtr native_error, IntPtr native__params)
		{
			Invocation2 @object = Java.Lang.Object.GetObject<Invocation2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CallbackStatus object2 = Java.Lang.Object.GetObject<CallbackStatus>(native_status, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Enum object3 = Java.Lang.Object.GetObject<Java.Lang.Enum>(native_error, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.SetInvocationResponse(object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000BA9C File Offset: 0x00009C9C
		[Register("setInvocationResponse", "(Lcom/unity3d/services/core/webview/bridge/CallbackStatus;Ljava/lang/Enum;[Ljava/lang/Object;)V", "GetSetInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_Handler")]
		public unsafe virtual void SetInvocationResponse(CallbackStatus status, Java.Lang.Enum error, params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(@params);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
				ptr[1] = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				Invocation2._members.InstanceMethods.InvokeVirtualVoidMethod("setInvocationResponse.(Lcom/unity3d/services/core/webview/bridge/CallbackStatus;Ljava/lang/Enum;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, @params);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(status);
				GC.KeepAlive(error);
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x040000C8 RID: 200
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/Invocation", typeof(Invocation2));

		// Token: 0x040000C9 RID: 201
		private static Delegate cb_getId;

		// Token: 0x040000CA RID: 202
		private static Delegate cb_getResponses;

		// Token: 0x040000CB RID: 203
		private static Delegate cb_addInvocation_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Lcom_unity3d_services_core_webview_bridge_WebViewCallback_;

		// Token: 0x040000CC RID: 204
		private static Delegate cb_nextInvocation;

		// Token: 0x040000CD RID: 205
		private static Delegate cb_sendInvocationCallback;

		// Token: 0x040000CE RID: 206
		private static Delegate cb_setInvocationResponse_Lcom_unity3d_services_core_webview_bridge_CallbackStatus_Ljava_lang_Enum_arrayLjava_lang_Object_;
	}
}
