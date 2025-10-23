using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Android.Webkit
{
	// Token: 0x0200010A RID: 266
	[Register("android/webkit/WebView", DoNotGenerateAcw = true)]
	public class WebView : AbsoluteLayout, ViewGroup.IOnHierarchyChangeListener, IJavaObject, IDisposable, IJavaPeerable, ViewTreeObserver.IOnGlobalFocusChangeListener
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0000EECB File Offset: 0x0000D0CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebView._members;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebView._members.ManagedPeerType;
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000EF04 File Offset: 0x0000D104
		protected WebView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000EF10 File Offset: 0x0000D110
		public unsafe WebView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(WebView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
		public unsafe WebView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(WebView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000F09C File Offset: 0x0000D29C
		public unsafe WebView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(WebView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000F18C File Offset: 0x0000D38C
		private static Delegate GetGetSettingsHandler()
		{
			if (WebView.cb_getSettings == null)
			{
				WebView.cb_getSettings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebView.n_GetSettings));
			}
			return WebView.cb_getSettings;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		private static IntPtr n_GetSettings(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Settings);
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		public virtual WebSettings Settings
		{
			get
			{
				return Java.Lang.Object.GetObject<WebSettings>(WebView._members.InstanceMethods.InvokeVirtualObjectMethod("getSettings.()Landroid/webkit/WebSettings;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000F1F6 File Offset: 0x0000D3F6
		private static Delegate GetLoadUrl_Ljava_lang_String_Handler()
		{
			if (WebView.cb_loadUrl_Ljava_lang_String_ == null)
			{
				WebView.cb_loadUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebView.n_LoadUrl_Ljava_lang_String_));
			}
			return WebView.cb_loadUrl_Ljava_lang_String_;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000F21C File Offset: 0x0000D41C
		private static void n_LoadUrl_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_url, JniHandleOwnership.DoNotTransfer);
			@object.LoadUrl(@string);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0000F240 File Offset: 0x0000D440
		public unsafe virtual void LoadUrl(string url)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("loadUrl.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000F29C File Offset: 0x0000D49C
		private static Delegate GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (WebView.cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ == null)
			{
				WebView.cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebView.n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_));
			}
			return WebView.cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
		private static void n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnChildViewAdded(object2, object3);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		public unsafe virtual void OnChildViewAdded(View parent, View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("onChildViewAdded.(Landroid/view/View;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000F378 File Offset: 0x0000D578
		private static Delegate GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (WebView.cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ == null)
			{
				WebView.cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebView.n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_));
			}
			return WebView.cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000F39C File Offset: 0x0000D59C
		private static void n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p, IntPtr native_child)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnChildViewRemoved(object2, object3);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public unsafe virtual void OnChildViewRemoved(View p, View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("onChildViewRemoved.(Landroid/view/View;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p);
				GC.KeepAlive(child);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000F454 File Offset: 0x0000D654
		private static Delegate GetOnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (WebView.cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_ == null)
			{
				WebView.cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebView.n_OnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_));
			}
			return WebView.cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0000F478 File Offset: 0x0000D678
		private static void n_OnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_oldFocus, IntPtr native_newFocus)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_oldFocus, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_newFocus, JniHandleOwnership.DoNotTransfer);
			@object.OnGlobalFocusChanged(object2, object3);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public unsafe virtual void OnGlobalFocusChanged(View oldFocus, View newFocus)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((oldFocus == null) ? IntPtr.Zero : oldFocus.Handle);
				ptr[1] = new JniArgumentValue((newFocus == null) ? IntPtr.Zero : newFocus.Handle);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("onGlobalFocusChanged.(Landroid/view/View;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(oldFocus);
				GC.KeepAlive(newFocus);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000F530 File Offset: 0x0000D730
		private static Delegate GetOnPauseHandler()
		{
			if (WebView.cb_onPause == null)
			{
				WebView.cb_onPause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebView.n_OnPause));
			}
			return WebView.cb_onPause;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000F554 File Offset: 0x0000D754
		private static void n_OnPause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPause();
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0000F563 File Offset: 0x0000D763
		public virtual void OnPause()
		{
			WebView._members.InstanceMethods.InvokeVirtualVoidMethod("onPause.()V", this, null);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000F57C File Offset: 0x0000D77C
		private static Delegate GetOnResumeHandler()
		{
			if (WebView.cb_onResume == null)
			{
				WebView.cb_onResume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebView.n_OnResume));
			}
			return WebView.cb_onResume;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		private static void n_OnResume(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnResume();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000F5AF File Offset: 0x0000D7AF
		public virtual void OnResume()
		{
			WebView._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.()V", this, null);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		private static Delegate GetSetWebChromeClient_Landroid_webkit_WebChromeClient_Handler()
		{
			if (WebView.cb_setWebChromeClient_Landroid_webkit_WebChromeClient_ == null)
			{
				WebView.cb_setWebChromeClient_Landroid_webkit_WebChromeClient_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebView.n_SetWebChromeClient_Landroid_webkit_WebChromeClient_));
			}
			return WebView.cb_setWebChromeClient_Landroid_webkit_WebChromeClient_;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		private static void n_SetWebChromeClient_Landroid_webkit_WebChromeClient_(IntPtr jnienv, IntPtr native__this, IntPtr native_client)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebChromeClient object2 = Java.Lang.Object.GetObject<WebChromeClient>(native_client, JniHandleOwnership.DoNotTransfer);
			@object.SetWebChromeClient(object2);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000F610 File Offset: 0x0000D810
		public unsafe virtual void SetWebChromeClient(WebChromeClient client)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((client == null) ? IntPtr.Zero : client.Handle);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("setWebChromeClient.(Landroid/webkit/WebChromeClient;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(client);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000F674 File Offset: 0x0000D874
		private static Delegate GetSetWebViewClient_Landroid_webkit_WebViewClient_Handler()
		{
			if (WebView.cb_setWebViewClient_Landroid_webkit_WebViewClient_ == null)
			{
				WebView.cb_setWebViewClient_Landroid_webkit_WebViewClient_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebView.n_SetWebViewClient_Landroid_webkit_WebViewClient_));
			}
			return WebView.cb_setWebViewClient_Landroid_webkit_WebViewClient_;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000F698 File Offset: 0x0000D898
		private static void n_SetWebViewClient_Landroid_webkit_WebViewClient_(IntPtr jnienv, IntPtr native__this, IntPtr native_client)
		{
			WebView @object = Java.Lang.Object.GetObject<WebView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebViewClient object2 = Java.Lang.Object.GetObject<WebViewClient>(native_client, JniHandleOwnership.DoNotTransfer);
			@object.SetWebViewClient(object2);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		public unsafe virtual void SetWebViewClient(WebViewClient client)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((client == null) ? IntPtr.Zero : client.Handle);
				WebView._members.InstanceMethods.InvokeVirtualVoidMethod("setWebViewClient.(Landroid/webkit/WebViewClient;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(client);
			}
		}

		// Token: 0x040001B1 RID: 433
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebView", typeof(WebView));

		// Token: 0x040001B2 RID: 434
		private static Delegate cb_getSettings;

		// Token: 0x040001B3 RID: 435
		private static Delegate cb_loadUrl_Ljava_lang_String_;

		// Token: 0x040001B4 RID: 436
		private static Delegate cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;

		// Token: 0x040001B5 RID: 437
		private static Delegate cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;

		// Token: 0x040001B6 RID: 438
		private static Delegate cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_;

		// Token: 0x040001B7 RID: 439
		private static Delegate cb_onPause;

		// Token: 0x040001B8 RID: 440
		private static Delegate cb_onResume;

		// Token: 0x040001B9 RID: 441
		private static Delegate cb_setWebChromeClient_Landroid_webkit_WebChromeClient_;

		// Token: 0x040001BA RID: 442
		private static Delegate cb_setWebViewClient_Landroid_webkit_WebViewClient_;
	}
}
