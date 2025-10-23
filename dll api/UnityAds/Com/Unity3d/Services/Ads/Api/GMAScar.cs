using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000222 RID: 546
	[Register("com/unity3d/services/ads/api/GMAScar", DoNotGenerateAcw = true)]
	public class GMAScar : Java.Lang.Object
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0004AAAC File Offset: 0x00048CAC
		internal static IntPtr class_ref
		{
			get
			{
				return GMAScar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0004AAD0 File Offset: 0x00048CD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GMAScar._members;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0004AAD8 File Offset: 0x00048CD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GMAScar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0004AAFC File Offset: 0x00048CFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GMAScar._members.ManagedPeerType;
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GMAScar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0004AB08 File Offset: 0x00048D08
		[Register(".ctor", "()V", "")]
		public GMAScar() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GMAScar._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GMAScar._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0004AB78 File Offset: 0x00048D78
		[Register("getSCARSignals", "(Lorg/json/JSONArray;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSCARSignals(JSONArray interstitialList, JSONArray rewardedList, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((interstitialList == null) ? IntPtr.Zero : interstitialList.Handle);
				ptr[1] = new JniArgumentValue((rewardedList == null) ? IntPtr.Zero : rewardedList.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				GMAScar._members.StaticMethods.InvokeVoidMethod("getSCARSignals.(Lorg/json/JSONArray;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(interstitialList);
				GC.KeepAlive(rewardedList);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0004AC30 File Offset: 0x00048E30
		[Register("getVersion", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetVersion(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				GMAScar._members.StaticMethods.InvokeVoidMethod("getVersion.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0004AC94 File Offset: 0x00048E94
		[Register("initializeScar", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void InitializeScar(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				GMAScar._members.StaticMethods.InvokeVoidMethod("initializeScar.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0004ACF8 File Offset: 0x00048EF8
		[Register("isInitialized", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsInitialized(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				GMAScar._members.StaticMethods.InvokeVoidMethod("isInitialized.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0004AD5C File Offset: 0x00048F5C
		[Register("load", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Load(string placementId, string queryId, Java.Lang.Boolean canSkip, string adUnitId, string adString, Integer videoLengthMs, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			IntPtr intPtr3 = JNIEnv.NewString(adUnitId);
			IntPtr intPtr4 = JNIEnv.NewString(adString);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((canSkip == null) ? IntPtr.Zero : canSkip.Handle);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				ptr[5] = new JniArgumentValue((videoLengthMs == null) ? IntPtr.Zero : videoLengthMs.Handle);
				ptr[6] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				GMAScar._members.StaticMethods.InvokeVoidMethod("load.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(canSkip);
				GC.KeepAlive(videoLengthMs);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0004AEB0 File Offset: 0x000490B0
		[Register("show", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Show(string placementId, string queryId, Java.Lang.Boolean canSkip, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((canSkip == null) ? IntPtr.Zero : canSkip.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				GMAScar._members.StaticMethods.InvokeVoidMethod("show.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(canSkip);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000659 RID: 1625
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/GMAScar", typeof(GMAScar));
	}
}
