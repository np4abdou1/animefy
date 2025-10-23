using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000224 RID: 548
	[Register("com/unity3d/services/ads/api/Show", DoNotGenerateAcw = true)]
	public class Show : Java.Lang.Object
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0004B224 File Offset: 0x00049424
		internal static IntPtr class_ref
		{
			get
			{
				return Show._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0004B248 File Offset: 0x00049448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Show._members;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0004B250 File Offset: 0x00049450
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Show._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0004B274 File Offset: 0x00049474
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Show._members.ManagedPeerType;
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Show(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0004B280 File Offset: 0x00049480
		[Register(".ctor", "()V", "")]
		public Show() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Show._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Show._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0004B2F0 File Offset: 0x000494F0
		[Register("sendShowClickEvent", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendShowClickEvent(string placementId, string listenerId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Show._members.StaticMethods.InvokeVoidMethod("sendShowClickEvent.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0004B398 File Offset: 0x00049598
		[Register("sendShowCompleteEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendShowCompleteEvent(string placementId, string listenerId, string finishState, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			IntPtr intPtr3 = JNIEnv.NewString(finishState);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Show._members.StaticMethods.InvokeVoidMethod("sendShowCompleteEvent.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0004B460 File Offset: 0x00049660
		[Register("sendShowConsentEvent", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendShowConsentEvent(string placementId, string listenerId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Show._members.StaticMethods.InvokeVoidMethod("sendShowConsentEvent.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0004B508 File Offset: 0x00049708
		[Register("sendShowFailedEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendShowFailedEvent(string placementId, string listenerId, string error, string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			IntPtr intPtr3 = JNIEnv.NewString(error);
			IntPtr intPtr4 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Show._members.StaticMethods.InvokeVoidMethod("sendShowFailedEvent.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0004B600 File Offset: 0x00049800
		[Register("sendShowStartEvent", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendShowStartEvent(string placementId, string listenerId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Show._members.StaticMethods.InvokeVoidMethod("sendShowStartEvent.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400065B RID: 1627
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/Show", typeof(Show));
	}
}
