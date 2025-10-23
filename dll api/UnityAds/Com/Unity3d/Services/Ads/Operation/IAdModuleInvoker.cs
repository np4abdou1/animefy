using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Request.Metrics;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001E9 RID: 489
	[Register("com/unity3d/services/ads/operation/IAdModule", DoNotGenerateAcw = true)]
	internal class IAdModuleInvoker : Java.Lang.Object, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x0003FA88 File Offset: 0x0003DC88
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdModuleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x0003FAAC File Offset: 0x0003DCAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdModuleInvoker._members;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x0003FAB3 File Offset: 0x0003DCB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0003FABB File Offset: 0x0003DCBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0003FAC7 File Offset: 0x0003DCC7
		public static IAdModule GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdModule>(handle, transfer);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0003FAD0 File Offset: 0x0003DCD0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdModuleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.operation.IAdModule'.");
			}
			return handle;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0003FAFB File Offset: 0x0003DCFB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0003FB2C File Offset: 0x0003DD2C
		public IAdModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdModuleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0003FB64 File Offset: 0x0003DD64
		private static Delegate GetGetMetricSenderHandler()
		{
			if (IAdModuleInvoker.cb_getMetricSender == null)
			{
				IAdModuleInvoker.cb_getMetricSender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdModuleInvoker.n_GetMetricSender));
			}
			return IAdModuleInvoker.cb_getMetricSender;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0003FB88 File Offset: 0x0003DD88
		private static IntPtr n_GetMetricSender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAdModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MetricSender);
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0003FB9C File Offset: 0x0003DD9C
		public ISDKMetrics MetricSender
		{
			get
			{
				if (this.id_getMetricSender == IntPtr.Zero)
				{
					this.id_getMetricSender = JNIEnv.GetMethodID(this.class_ref, "getMetricSender", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;");
				}
				return Java.Lang.Object.GetObject<ISDKMetrics>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMetricSender), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0003FBED File Offset: 0x0003DDED
		private static Delegate GetExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_Handler()
		{
			if (IAdModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ == null)
			{
				IAdModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAdModuleInvoker.n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_));
			}
			return IAdModuleInvoker.cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0003FC14 File Offset: 0x0003DE14
		private static void n_ExecuteAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAdModule @object = Java.Lang.Object.GetObject<IAdModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebViewBridgeInvoker object2 = Java.Lang.Object.GetObject<IWebViewBridgeInvoker>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.ExecuteAdOperation(object2, object3);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0003FC40 File Offset: 0x0003DE40
		public unsafe void ExecuteAdOperation(IWebViewBridgeInvoker p0, Java.Lang.Object p1)
		{
			if (this.id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "executeAdOperation", "(Lcom/unity3d/services/core/webview/bridge/IWebViewBridgeInvoker;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0003FCD8 File Offset: 0x0003DED8
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (IAdModuleInvoker.cb_get_Ljava_lang_String_ == null)
			{
				IAdModuleInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAdModuleInvoker.n_Get_Ljava_lang_String_));
			}
			return IAdModuleInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0003FCFC File Offset: 0x0003DEFC
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IAdModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0003FD24 File Offset: 0x0003DF24
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

		// Token: 0x06001647 RID: 5703 RVA: 0x0003FD9B File Offset: 0x0003DF9B
		private static Delegate GetRemove_Ljava_lang_String_Handler()
		{
			if (IAdModuleInvoker.cb_remove_Ljava_lang_String_ == null)
			{
				IAdModuleInvoker.cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdModuleInvoker.n_Remove_Ljava_lang_String_));
			}
			return IAdModuleInvoker.cb_remove_Ljava_lang_String_;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0003FDC0 File Offset: 0x0003DFC0
		private static void n_Remove_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IAdModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Remove(@string);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0003FDE4 File Offset: 0x0003DFE4
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

		// Token: 0x0600164A RID: 5706 RVA: 0x0003FE55 File Offset: 0x0003E055
		private static Delegate GetSet_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_Handler()
		{
			if (IAdModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ == null)
			{
				IAdModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdModuleInvoker.n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_));
			}
			return IAdModuleInvoker.cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0003FE7C File Offset: 0x0003E07C
		private static void n_Set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IWebViewBridgeSharedObjectStore @object = Java.Lang.Object.GetObject<IAdModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
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

		// Token: 0x0400053F RID: 1343
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/IAdModule", typeof(IAdModuleInvoker));

		// Token: 0x04000540 RID: 1344
		private IntPtr class_ref;

		// Token: 0x04000541 RID: 1345
		private static Delegate cb_getMetricSender;

		// Token: 0x04000542 RID: 1346
		private IntPtr id_getMetricSender;

		// Token: 0x04000543 RID: 1347
		private static Delegate cb_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;

		// Token: 0x04000544 RID: 1348
		private IntPtr id_executeAdOperation_Lcom_unity3d_services_core_webview_bridge_IWebViewBridgeInvoker_Ljava_lang_Object_;

		// Token: 0x04000545 RID: 1349
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x04000546 RID: 1350
		private IntPtr id_get_Ljava_lang_String_;

		// Token: 0x04000547 RID: 1351
		private static Delegate cb_remove_Ljava_lang_String_;

		// Token: 0x04000548 RID: 1352
		private IntPtr id_remove_Ljava_lang_String_;

		// Token: 0x04000549 RID: 1353
		private static Delegate cb_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;

		// Token: 0x0400054A RID: 1354
		private IntPtr id_set_Lcom_unity3d_services_core_webview_bridge_IWebViewSharedObject_;
	}
}
