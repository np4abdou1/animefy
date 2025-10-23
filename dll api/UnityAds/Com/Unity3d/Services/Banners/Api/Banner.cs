using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners.Api
{
	// Token: 0x020001C1 RID: 449
	[Register("com/unity3d/services/banners/api/Banner", DoNotGenerateAcw = true)]
	public class Banner : Java.Lang.Object
	{
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00038FF4 File Offset: 0x000371F4
		internal static IntPtr class_ref
		{
			get
			{
				return Banner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00039018 File Offset: 0x00037218
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Banner._members;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00039020 File Offset: 0x00037220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Banner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00039044 File Offset: 0x00037244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Banner._members.ManagedPeerType;
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Banner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00039050 File Offset: 0x00037250
		[Register(".ctor", "()V", "")]
		public Banner() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Banner._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Banner._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000390C0 File Offset: 0x000372C0
		[Register("load", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Load(string bannerViewTypeString, Integer width, Integer height, string bannerAdId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerViewTypeString);
			IntPtr intPtr2 = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((width == null) ? IntPtr.Zero : width.Handle);
				ptr[2] = new JniArgumentValue((height == null) ? IntPtr.Zero : height.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Banner._members.StaticMethods.InvokeVoidMethod("load.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(width);
				GC.KeepAlive(height);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x000391C0 File Offset: 0x000373C0
		[Register("setRefreshRate", "(Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetRefreshRate(string placementId, Integer refreshRate, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((refreshRate == null) ? IntPtr.Zero : refreshRate.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Banner._members.StaticMethods.InvokeVoidMethod("setRefreshRate.(Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(refreshRate);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x040004D1 RID: 1233
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/api/Banner", typeof(Banner));
	}
}
