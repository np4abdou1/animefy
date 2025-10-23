using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000083 RID: 131
	[Register("com/unity3d/services/core/webview/bridge/WebViewCallback", DoNotGenerateAcw = true)]
	public class WebViewCallback : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(WebViewCallback._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000D708 File Offset: 0x0000B908
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000D72C File Offset: 0x0000B92C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewCallback._members;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000D734 File Offset: 0x0000B934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000D758 File Offset: 0x0000B958
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000D764 File Offset: 0x0000B964
		[Register(".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe WebViewCallback(Parcel @in) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@in == null) ? IntPtr.Zero : @in.Handle);
				base.SetHandle(WebViewCallback._members.InstanceMethods.StartCreateInstance("(Landroid/os/Parcel;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewCallback._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Parcel;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@in);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000D814 File Offset: 0x0000BA14
		[Register(".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe WebViewCallback(string callbackId, int invocationId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(callbackId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(invocationId);
				base.SetHandle(WebViewCallback._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewCallback._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000D8CC File Offset: 0x0000BACC
		private static Delegate GetGetCallbackIdHandler()
		{
			if (WebViewCallback.cb_getCallbackId == null)
			{
				WebViewCallback.cb_getCallbackId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewCallback.n_GetCallbackId));
			}
			return WebViewCallback.cb_getCallbackId;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		private static IntPtr n_GetCallbackId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CallbackId);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0000D904 File Offset: 0x0000BB04
		public virtual string CallbackId
		{
			[Register("getCallbackId", "()Ljava/lang/String;", "GetGetCallbackIdHandler")]
			get
			{
				return JNIEnv.GetString(WebViewCallback._members.InstanceMethods.InvokeVirtualObjectMethod("getCallbackId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000D936 File Offset: 0x0000BB36
		private static Delegate GetGetInvocationIdHandler()
		{
			if (WebViewCallback.cb_getInvocationId == null)
			{
				WebViewCallback.cb_getInvocationId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebViewCallback.n_GetInvocationId));
			}
			return WebViewCallback.cb_getInvocationId;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000D95A File Offset: 0x0000BB5A
		private static int n_GetInvocationId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvocationId;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000D969 File Offset: 0x0000BB69
		public virtual int InvocationId
		{
			[Register("getInvocationId", "()I", "GetGetInvocationIdHandler")]
			get
			{
				return WebViewCallback._members.InstanceMethods.InvokeVirtualInt32Method("getInvocationId.()I", this, null);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000D982 File Offset: 0x0000BB82
		private static Delegate GetDescribeContentsHandler()
		{
			if (WebViewCallback.cb_describeContents == null)
			{
				WebViewCallback.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebViewCallback.n_DescribeContents));
			}
			return WebViewCallback.cb_describeContents;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000D9A6 File Offset: 0x0000BBA6
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000D9B5 File Offset: 0x0000BBB5
		[Register("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents()
		{
			return WebViewCallback._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000D9CE File Offset: 0x0000BBCE
		private static Delegate GetError_Ljava_lang_Enum_arrayLjava_lang_Object_Handler()
		{
			if (WebViewCallback.cb_error_Ljava_lang_Enum_arrayLjava_lang_Object_ == null)
			{
				WebViewCallback.cb_error_Ljava_lang_Enum_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebViewCallback.n_Error_Ljava_lang_Enum_arrayLjava_lang_Object_));
			}
			return WebViewCallback.cb_error_Ljava_lang_Enum_arrayLjava_lang_Object_;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		private static void n_Error_Ljava_lang_Enum_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_error, IntPtr native__params)
		{
			WebViewCallback @object = Java.Lang.Object.GetObject<WebViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Enum object2 = Java.Lang.Object.GetObject<Java.Lang.Enum>(native_error, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Error(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		[Register("error", "(Ljava/lang/Enum;[Ljava/lang/Object;)V", "GetError_Ljava_lang_Enum_arrayLjava_lang_Object_Handler")]
		public unsafe virtual void Error(Java.Lang.Enum error, params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(@params);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((error == null) ? IntPtr.Zero : error.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				WebViewCallback._members.InstanceMethods.InvokeVirtualVoidMethod("error.(Ljava/lang/Enum;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, @params);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(error);
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		private static Delegate GetInvoke_arrayLjava_lang_Object_Handler()
		{
			if (WebViewCallback.cb_invoke_arrayLjava_lang_Object_ == null)
			{
				WebViewCallback.cb_invoke_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewCallback.n_Invoke_arrayLjava_lang_Object_));
			}
			return WebViewCallback.cb_invoke_arrayLjava_lang_Object_;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		private static void n_Invoke_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			WebViewCallback @object = Java.Lang.Object.GetObject<WebViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Register("invoke", "([Ljava/lang/Object;)V", "GetInvoke_arrayLjava_lang_Object_Handler")]
		public unsafe virtual void Invoke(params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(@params);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebViewCallback._members.InstanceMethods.InvokeVirtualVoidMethod("invoke.([Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, @params);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000DB9C File Offset: 0x0000BD9C
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (WebViewCallback.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				WebViewCallback.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(WebViewCallback.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return WebViewCallback.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			WebViewCallback @object = Java.Lang.Object.GetObject<WebViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				WebViewCallback._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewCallback", typeof(WebViewCallback));

		// Token: 0x040000FA RID: 250
		private static Delegate cb_getCallbackId;

		// Token: 0x040000FB RID: 251
		private static Delegate cb_getInvocationId;

		// Token: 0x040000FC RID: 252
		private static Delegate cb_describeContents;

		// Token: 0x040000FD RID: 253
		private static Delegate cb_error_Ljava_lang_Enum_arrayLjava_lang_Object_;

		// Token: 0x040000FE RID: 254
		private static Delegate cb_invoke_arrayLjava_lang_Object_;

		// Token: 0x040000FF RID: 255
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
