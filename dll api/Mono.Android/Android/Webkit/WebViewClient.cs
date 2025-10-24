using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Webkit
{
	// Token: 0x0200010B RID: 267
	[Register("android/webkit/WebViewClient", DoNotGenerateAcw = true)]
	public class WebViewClient : Java.Lang.Object
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0000F73B File Offset: 0x0000D93B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewClient._members;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000F744 File Offset: 0x0000D944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewClient._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0000F768 File Offset: 0x0000D968
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewClient._members.ManagedPeerType;
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000021E0 File Offset: 0x000003E0
		protected WebViewClient(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000F774 File Offset: 0x0000D974
		public WebViewClient() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewClient._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewClient._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000F7E2 File Offset: 0x0000D9E2
		private static Delegate GetOnPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_Handler()
		{
			if (WebViewClient.cb_onPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_ == null)
			{
				WebViewClient.cb_onPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebViewClient.n_OnPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_));
			}
			return WebViewClient.cb_onPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000F808 File Offset: 0x0000DA08
		private static void n_OnPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url)
		{
			WebViewClient @object = Java.Lang.Object.GetObject<WebViewClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebView object2 = Java.Lang.Object.GetObject<WebView>(native_view, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_url, JniHandleOwnership.DoNotTransfer);
			@object.OnPageCommitVisible(object2, @string);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000F834 File Offset: 0x0000DA34
		public unsafe virtual void OnPageCommitVisible(WebView view, string url)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				WebViewClient._members.InstanceMethods.InvokeVirtualVoidMethod("onPageCommitVisible.(Landroid/webkit/WebView;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		private static Delegate GetOnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_Handler()
		{
			if (WebViewClient.cb_onPageFinished_Landroid_webkit_WebView_Ljava_lang_String_ == null)
			{
				WebViewClient.cb_onPageFinished_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebViewClient.n_OnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_));
			}
			return WebViewClient.cb_onPageFinished_Landroid_webkit_WebView_Ljava_lang_String_;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000F8DC File Offset: 0x0000DADC
		private static void n_OnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url)
		{
			WebViewClient @object = Java.Lang.Object.GetObject<WebViewClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebView object2 = Java.Lang.Object.GetObject<WebView>(native_view, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_url, JniHandleOwnership.DoNotTransfer);
			@object.OnPageFinished(object2, @string);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000F908 File Offset: 0x0000DB08
		public unsafe virtual void OnPageFinished(WebView view, string url)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				WebViewClient._members.InstanceMethods.InvokeVirtualVoidMethod("onPageFinished.(Landroid/webkit/WebView;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0000F98C File Offset: 0x0000DB8C
		private static Delegate GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Handler()
		{
			if (WebViewClient.cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_ == null)
			{
				WebViewClient.cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(WebViewClient.n_ShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_));
			}
			return WebViewClient.cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		private static bool n_ShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_request)
		{
			WebViewClient @object = Java.Lang.Object.GetObject<WebViewClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebView object2 = Java.Lang.Object.GetObject<WebView>(native_view, JniHandleOwnership.DoNotTransfer);
			IWebResourceRequest object3 = Java.Lang.Object.GetObject<IWebResourceRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			return @object.ShouldOverrideUrlLoading(object2, object3);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000F9DC File Offset: 0x0000DBDC
		public unsafe virtual bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = WebViewClient._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldOverrideUrlLoading.(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0000FA70 File Offset: 0x0000DC70
		private static Delegate GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler()
		{
			if (WebViewClient.cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ == null)
			{
				WebViewClient.cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(WebViewClient.n_ShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_));
			}
			return WebViewClient.cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000FA94 File Offset: 0x0000DC94
		private static bool n_ShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url)
		{
			WebViewClient @object = Java.Lang.Object.GetObject<WebViewClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebView object2 = Java.Lang.Object.GetObject<WebView>(native_view, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_url, JniHandleOwnership.DoNotTransfer);
			return @object.ShouldOverrideUrlLoading(object2, @string);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
		public unsafe virtual bool ShouldOverrideUrlLoading(WebView view, string url)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = WebViewClient._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldOverrideUrlLoading.(Landroid/webkit/WebView;Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
			return result;
		}

		// Token: 0x040001BB RID: 443
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebViewClient", typeof(WebViewClient));

		// Token: 0x040001BC RID: 444
		private static Delegate cb_onPageCommitVisible_Landroid_webkit_WebView_Ljava_lang_String_;

		// Token: 0x040001BD RID: 445
		private static Delegate cb_onPageFinished_Landroid_webkit_WebView_Ljava_lang_String_;

		// Token: 0x040001BE RID: 446
		private static Delegate cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_;

		// Token: 0x040001BF RID: 447
		private static Delegate cb_shouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
	}
}
