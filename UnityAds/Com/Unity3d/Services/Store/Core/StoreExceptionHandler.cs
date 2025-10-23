using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Handlers;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Core
{
	// Token: 0x02000068 RID: 104
	[Register("com/unity3d/services/store/core/StoreExceptionHandler", DoNotGenerateAcw = true)]
	public class StoreExceptionHandler : Java.Lang.Object
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00008954 File Offset: 0x00006B54
		internal static IntPtr class_ref
		{
			get
			{
				return StoreExceptionHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00008978 File Offset: 0x00006B78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreExceptionHandler._members;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00008980 File Offset: 0x00006B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreExceptionHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000089A4 File Offset: 0x00006BA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreExceptionHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000021E8 File Offset: 0x000003E8
		protected StoreExceptionHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000089B0 File Offset: 0x00006BB0
		[Register(".ctor", "(Lcom/unity3d/services/ads/gmascar/handlers/WebViewErrorHandler;)V", "")]
		public unsafe StoreExceptionHandler(WebViewErrorHandler webViewErrorHandler) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewErrorHandler == null) ? IntPtr.Zero : webViewErrorHandler.Handle);
				base.SetHandle(StoreExceptionHandler._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/gmascar/handlers/WebViewErrorHandler;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StoreExceptionHandler._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/gmascar/handlers/WebViewErrorHandler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webViewErrorHandler);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00008A60 File Offset: 0x00006C60
		private static Delegate GetHandleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_Handler()
		{
			if (StoreExceptionHandler.cb_handleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_ == null)
			{
				StoreExceptionHandler.cb_handleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(StoreExceptionHandler.n_HandleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_));
			}
			return StoreExceptionHandler.cb_handleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00008A84 File Offset: 0x00006C84
		private static void n_HandleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_storeEvent, int operationId, IntPtr native_exception)
		{
			StoreExceptionHandler @object = Java.Lang.Object.GetObject<StoreExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			StoreEvent object2 = Java.Lang.Object.GetObject<StoreEvent>(native_storeEvent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object3 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_exception, JniHandleOwnership.DoNotTransfer);
			@object.HandleStoreException(object2, operationId, object3);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00008AB4 File Offset: 0x00006CB4
		[Register("handleStoreException", "(Lcom/unity3d/services/store/StoreEvent;ILjava/lang/Exception;)V", "GetHandleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_Handler")]
		public unsafe virtual void HandleStoreException(StoreEvent storeEvent, int operationId, Java.Lang.Exception exception)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((storeEvent == null) ? IntPtr.Zero : storeEvent.Handle);
				ptr[1] = new JniArgumentValue(operationId);
				ptr[2] = new JniArgumentValue((exception == null) ? IntPtr.Zero : exception.Handle);
				StoreExceptionHandler._members.InstanceMethods.InvokeVirtualVoidMethod("handleStoreException.(Lcom/unity3d/services/store/StoreEvent;ILjava/lang/Exception;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(storeEvent);
				GC.KeepAlive(exception);
			}
		}

		// Token: 0x0400009A RID: 154
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/core/StoreExceptionHandler", typeof(StoreExceptionHandler));

		// Token: 0x0400009B RID: 155
		private static Delegate cb_handleStoreException_Lcom_unity3d_services_store_StoreEvent_ILjava_lang_Exception_;
	}
}
