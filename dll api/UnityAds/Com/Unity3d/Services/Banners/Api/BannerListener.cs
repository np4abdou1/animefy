using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners.Api
{
	// Token: 0x020001C2 RID: 450
	[Register("com/unity3d/services/banners/api/BannerListener", DoNotGenerateAcw = true)]
	public class BannerListener : Java.Lang.Object
	{
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0003928C File Offset: 0x0003748C
		internal static IntPtr class_ref
		{
			get
			{
				return BannerListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x000392B0 File Offset: 0x000374B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerListener._members;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000392B8 File Offset: 0x000374B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000392DC File Offset: 0x000374DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BannerListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000392E8 File Offset: 0x000374E8
		[Register(".ctor", "()V", "")]
		public BannerListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BannerListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BannerListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00039358 File Offset: 0x00037558
		[Register("sendClickEvent", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendClickEvent(string bannerAdId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BannerListener._members.StaticMethods.InvokeVoidMethod("sendClickEvent.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000393DC File Offset: 0x000375DC
		[Register("sendErrorEvent", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendErrorEvent(string bannerAdId, Integer errorCode, string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((errorCode == null) ? IntPtr.Zero : errorCode.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BannerListener._members.StaticMethods.InvokeVoidMethod("sendErrorEvent.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(errorCode);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000394AC File Offset: 0x000376AC
		[Register("sendLeaveApplicationEvent", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendLeaveApplicationEvent(string bannerAdId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BannerListener._members.StaticMethods.InvokeVoidMethod("sendLeaveApplicationEvent.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00039530 File Offset: 0x00037730
		[Register("sendLoadEvent", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendLoadEvent(string bannerAdId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BannerListener._members.StaticMethods.InvokeVoidMethod("sendLoadEvent.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x040004D2 RID: 1234
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/api/BannerListener", typeof(BannerListener));
	}
}
