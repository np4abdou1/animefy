using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Handlers
{
	// Token: 0x0200020B RID: 523
	[Register("com/unity3d/services/ads/gmascar/handlers/WebViewErrorHandler", DoNotGenerateAcw = true)]
	public class WebViewErrorHandler : Java.Lang.Object, IAdsErrorHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000466CC File Offset: 0x000448CC
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewErrorHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x000466F0 File Offset: 0x000448F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewErrorHandler._members;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x000466F8 File Offset: 0x000448F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewErrorHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x0004671C File Offset: 0x0004491C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewErrorHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewErrorHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00046728 File Offset: 0x00044928
		[Register(".ctor", "()V", "")]
		public WebViewErrorHandler() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewErrorHandler._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewErrorHandler._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00046796 File Offset: 0x00044996
		private static Delegate GetHandleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_Handler()
		{
			if (WebViewErrorHandler.cb_handleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_ == null)
			{
				WebViewErrorHandler.cb_handleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebViewErrorHandler.n_HandleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_));
			}
			return WebViewErrorHandler.cb_handleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000467BC File Offset: 0x000449BC
		private static void n_HandleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_(IntPtr jnienv, IntPtr native__this, IntPtr native_webViewAdsError)
		{
			WebViewErrorHandler @object = Java.Lang.Object.GetObject<WebViewErrorHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebViewAdsError object2 = Java.Lang.Object.GetObject<WebViewAdsError>(native_webViewAdsError, JniHandleOwnership.DoNotTransfer);
			@object.HandleError(object2);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000467E0 File Offset: 0x000449E0
		[Register("handleError", "(Lcom/unity3d/scar/adapter/common/WebViewAdsError;)V", "GetHandleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_Handler")]
		public unsafe virtual void HandleError(WebViewAdsError webViewAdsError)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewAdsError == null) ? IntPtr.Zero : webViewAdsError.Handle);
				WebViewErrorHandler._members.InstanceMethods.InvokeVirtualVoidMethod("handleError.(Lcom/unity3d/scar/adapter/common/WebViewAdsError;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webViewAdsError);
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00046844 File Offset: 0x00044A44
		void IAdsErrorHandler.HandleError(Java.Lang.Object p0)
		{
			this.HandleError(p0.JavaCast<WebViewAdsError>());
		}

		// Token: 0x040005F1 RID: 1521
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/handlers/WebViewErrorHandler", typeof(WebViewErrorHandler));

		// Token: 0x040005F2 RID: 1522
		private static Delegate cb_handleError_Lcom_unity3d_scar_adapter_common_WebViewAdsError_;
	}
}
