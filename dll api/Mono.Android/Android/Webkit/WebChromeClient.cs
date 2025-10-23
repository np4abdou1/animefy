using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Webkit
{
	// Token: 0x02000104 RID: 260
	[Register("android/webkit/WebChromeClient", DoNotGenerateAcw = true)]
	public class WebChromeClient : Java.Lang.Object
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0000E504 File Offset: 0x0000C704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebChromeClient._members;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0000E50C File Offset: 0x0000C70C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebChromeClient._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0000E530 File Offset: 0x0000C730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebChromeClient._members.ManagedPeerType;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000021E0 File Offset: 0x000003E0
		protected WebChromeClient(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000E53C File Offset: 0x0000C73C
		public WebChromeClient() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebChromeClient._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebChromeClient._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000E5AA File Offset: 0x0000C7AA
		private static Delegate GetGetVideoLoadingProgressViewHandler()
		{
			if (WebChromeClient.cb_getVideoLoadingProgressView == null)
			{
				WebChromeClient.cb_getVideoLoadingProgressView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebChromeClient.n_GetVideoLoadingProgressView));
			}
			return WebChromeClient.cb_getVideoLoadingProgressView;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0000E5CE File Offset: 0x0000C7CE
		private static IntPtr n_GetVideoLoadingProgressView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebChromeClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VideoLoadingProgressView);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		public virtual View VideoLoadingProgressView
		{
			get
			{
				return Java.Lang.Object.GetObject<View>(WebChromeClient._members.InstanceMethods.InvokeVirtualObjectMethod("getVideoLoadingProgressView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000E616 File Offset: 0x0000C816
		private static Delegate GetOnHideCustomViewHandler()
		{
			if (WebChromeClient.cb_onHideCustomView == null)
			{
				WebChromeClient.cb_onHideCustomView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebChromeClient.n_OnHideCustomView));
			}
			return WebChromeClient.cb_onHideCustomView;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000E63A File Offset: 0x0000C83A
		private static void n_OnHideCustomView(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebChromeClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnHideCustomView();
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000E649 File Offset: 0x0000C849
		public virtual void OnHideCustomView()
		{
			WebChromeClient._members.InstanceMethods.InvokeVirtualVoidMethod("onHideCustomView.()V", this, null);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000E662 File Offset: 0x0000C862
		private static Delegate GetOnShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_Handler()
		{
			if (WebChromeClient.cb_onShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ == null)
			{
				WebChromeClient.cb_onShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebChromeClient.n_OnShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_));
			}
			return WebChromeClient.cb_onShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0000E688 File Offset: 0x0000C888
		private static void n_OnShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__callback)
		{
			WebChromeClient @object = Java.Lang.Object.GetObject<WebChromeClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			WebChromeClient.ICustomViewCallback object3 = Java.Lang.Object.GetObject<WebChromeClient.ICustomViewCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.OnShowCustomView(object2, object3);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		public unsafe virtual void OnShowCustomView(View view, WebChromeClient.ICustomViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				WebChromeClient._members.InstanceMethods.InvokeVirtualVoidMethod("onShowCustomView.(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0000E744 File Offset: 0x0000C944
		private static Delegate GetOnShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_Handler()
		{
			if (WebChromeClient.cb_onShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_ == null)
			{
				WebChromeClient.cb_onShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(WebChromeClient.n_OnShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_));
			}
			return WebChromeClient.cb_onShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0000E768 File Offset: 0x0000C968
		private static void n_OnShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int native_requestedOrientation, IntPtr native__callback)
		{
			WebChromeClient @object = Java.Lang.Object.GetObject<WebChromeClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			WebChromeClient.ICustomViewCallback object3 = Java.Lang.Object.GetObject<WebChromeClient.ICustomViewCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.OnShowCustomView(object2, (ScreenOrientation)native_requestedOrientation, object3);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0000E798 File Offset: 0x0000C998
		public unsafe virtual void OnShowCustomView(View view, [GeneratedEnum] ScreenOrientation requestedOrientation, WebChromeClient.ICustomViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((int)requestedOrientation);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				WebChromeClient._members.InstanceMethods.InvokeVirtualVoidMethod("onShowCustomView.(Landroid/view/View;ILandroid/webkit/WebChromeClient$CustomViewCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400019D RID: 413
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebChromeClient", typeof(WebChromeClient));

		// Token: 0x0400019E RID: 414
		private static Delegate cb_getVideoLoadingProgressView;

		// Token: 0x0400019F RID: 415
		private static Delegate cb_onHideCustomView;

		// Token: 0x040001A0 RID: 416
		private static Delegate cb_onShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_;

		// Token: 0x040001A1 RID: 417
		private static Delegate cb_onShowCustomView_Landroid_view_View_ILandroid_webkit_WebChromeClient_CustomViewCallback_;

		// Token: 0x02000105 RID: 261
		[Register("android/webkit/WebChromeClient$CustomViewCallback", "", "Android.Webkit.WebChromeClient/ICustomViewCallbackInvoker")]
		public interface ICustomViewCallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000671 RID: 1649
			[Register("onCustomViewHidden", "()V", "GetOnCustomViewHiddenHandler:Android.Webkit.WebChromeClient/ICustomViewCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnCustomViewHidden();
		}

		// Token: 0x02000106 RID: 262
		[Register("android/webkit/WebChromeClient$CustomViewCallback", DoNotGenerateAcw = true)]
		internal class ICustomViewCallbackInvoker : Java.Lang.Object, WebChromeClient.ICustomViewCallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000672 RID: 1650 RVA: 0x0000E85C File Offset: 0x0000CA5C
			private static IntPtr java_class_ref
			{
				get
				{
					return WebChromeClient.ICustomViewCallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000673 RID: 1651 RVA: 0x0000E880 File Offset: 0x0000CA80
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return WebChromeClient.ICustomViewCallbackInvoker._members;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x0000E887 File Offset: 0x0000CA87
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000675 RID: 1653 RVA: 0x0000E88F File Offset: 0x0000CA8F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return WebChromeClient.ICustomViewCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x0000E89B File Offset: 0x0000CA9B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, WebChromeClient.ICustomViewCallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.webkit.WebChromeClient.CustomViewCallback'.");
				}
				return handle;
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x0000E8C6 File Offset: 0x0000CAC6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
			public ICustomViewCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(WebChromeClient.ICustomViewCallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x0000E930 File Offset: 0x0000CB30
			private static Delegate GetOnCustomViewHiddenHandler()
			{
				if (WebChromeClient.ICustomViewCallbackInvoker.cb_onCustomViewHidden == null)
				{
					WebChromeClient.ICustomViewCallbackInvoker.cb_onCustomViewHidden = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebChromeClient.ICustomViewCallbackInvoker.n_OnCustomViewHidden));
				}
				return WebChromeClient.ICustomViewCallbackInvoker.cb_onCustomViewHidden;
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x0000E954 File Offset: 0x0000CB54
			private static void n_OnCustomViewHidden(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<WebChromeClient.ICustomViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCustomViewHidden();
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x0000E963 File Offset: 0x0000CB63
			public void OnCustomViewHidden()
			{
				if (this.id_onCustomViewHidden == IntPtr.Zero)
				{
					this.id_onCustomViewHidden = JNIEnv.GetMethodID(this.class_ref, "onCustomViewHidden", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onCustomViewHidden);
			}

			// Token: 0x040001A2 RID: 418
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebChromeClient$CustomViewCallback", typeof(WebChromeClient.ICustomViewCallbackInvoker));

			// Token: 0x040001A3 RID: 419
			private IntPtr class_ref;

			// Token: 0x040001A4 RID: 420
			private static Delegate cb_onCustomViewHidden;

			// Token: 0x040001A5 RID: 421
			private IntPtr id_onCustomViewHidden;
		}
	}
}
