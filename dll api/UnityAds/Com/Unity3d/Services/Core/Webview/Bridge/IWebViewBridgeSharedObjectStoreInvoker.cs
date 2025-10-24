using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000077 RID: 119
	[Register("com/unity3d/services/core/webview/bridge/IWebViewBridgeSharedObjectStore", DoNotGenerateAcw = true)]
	internal class IWebViewBridgeSharedObjectStoreInvoker : Java.Lang.Object, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebViewBridgeSharedObjectStoreInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000BDFC File Offset: 0x00009FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebViewBridgeSharedObjectStoreInvoker._members;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000BE03 File Offset: 0x0000A003
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000BE0B File Offset: 0x0000A00B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebViewBridgeSharedObjectStoreInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000BE17 File Offset: 0x0000A017
		public static IWebViewBridgeSharedObjectStore GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebViewBridgeSharedObjectStore>(handle, transfer);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000BE20 File Offset: 0x0000A020
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebViewBridgeSharedObjectStoreInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.webview.bridge.IWebViewBridgeSharedObjectStore'.");
			}
			return handle;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000BE4B File Offset: 0x0000A04B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000BE7C File Offset: 0x0000A07C
		public IWebViewBridgeSharedObjectStoreInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebViewBridgeSharedObjectStoreInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (IWebViewBridgeSharedObjectStoreInvoker.cb_get_Ljava_lang_String_ == null)
			{
				IWebViewBridgeSharedObjectStoreInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IWebViewBridgeSharedObjectStoreInvoker.n_Get_Ljava_lang_String_));
			}
			return IWebViewBridgeSharedObjectStoreInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000BED8 File Offset: 0x0000A0D8
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IWebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000BF00 File Offset: 0x0000A100
		public unsafe Java.Lang.Object Get(string p0)
		{
			if (this.id_get_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000BF77 File Offset: 0x0000A177
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (IWebViewBridgeSharedObjectStoreInvoker.cb_remove_Ljava_lang_String_ == null)
			{
				IWebViewBridgeSharedObjectStoreInvoker.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IWebViewBridgeSharedObjectStoreInvoker.n_Remove_Ljava_lang_String_));
			}
			return IWebViewBridgeSharedObjectStoreInvoker.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000BF9C File Offset: 0x0000A19C
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IWebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		public unsafe void Remove(string p0)
		{
			if (this.id_remove_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_remove_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000C031 File Offset: 0x0000A231
		private static Delegate GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler()
		{
			if (IWebViewBridgeSharedObjectStoreInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == null)
			{
				IWebViewBridgeSharedObjectStoreInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IWebViewBridgeSharedObjectStoreInvoker.n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_));
			}
			return IWebViewBridgeSharedObjectStoreInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000C058 File Offset: 0x0000A258
		private static void n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IWebViewBridgeSharedObjectStore>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000C07C File Offset: 0x0000A27C
		public unsafe void Set(Java.Lang.Object p0)
		{
			if (this.id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == IntPtr.Zero)
			{
				this.id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Lcom/unity3d/services/core/webview/bridge/IWebViewSharedObject;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040000D3 RID: 211
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/IWebViewBridgeSharedObjectStore", typeof(IWebViewBridgeSharedObjectStoreInvoker));

		// Token: 0x040000D4 RID: 212
		private IntPtr class_ref;

		// Token: 0x040000D5 RID: 213
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x040000D6 RID: 214
		private IntPtr id_get_Ljava_lang_String_;

		// Token: 0x040000D7 RID: 215
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x040000D8 RID: 216
		private IntPtr id_remove_Ljava_lang_String_;

		// Token: 0x040000D9 RID: 217
		private static Delegate cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;

		// Token: 0x040000DA RID: 218
		private IntPtr id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
	}
}
