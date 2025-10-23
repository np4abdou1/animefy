using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001D4 RID: 468
	[Register("com/unity3d/services/ads/webplayer/WebPlayerViewCache", DoNotGenerateAcw = true)]
	public class WebPlayerViewCache : Java.Lang.Object
	{
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0003D430 File Offset: 0x0003B630
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerViewCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0003D454 File Offset: 0x0003B654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerViewCache._members;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x0003D45C File Offset: 0x0003B65C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerViewCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0003D480 File Offset: 0x0003B680
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerViewCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebPlayerViewCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0003D48C File Offset: 0x0003B68C
		[Register(".ctor", "()V", "")]
		public WebPlayerViewCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebPlayerViewCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebPlayerViewCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x0003D4FC File Offset: 0x0003B6FC
		public static WebPlayerViewCache Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/ads/webplayer/WebPlayerViewCache;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerViewCache>(WebPlayerViewCache._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/ads/webplayer/WebPlayerViewCache;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0003D52D File Offset: 0x0003B72D
		private static Delegate GetAddWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_Handler()
		{
			if (WebPlayerViewCache.cb_addWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_ == null)
			{
				WebPlayerViewCache.cb_addWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(WebPlayerViewCache.n_AddWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_));
			}
			return WebPlayerViewCache.cb_addWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0003D554 File Offset: 0x0003B754
		private static void n_AddWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId, IntPtr native_webPlayerView)
		{
			WebPlayerViewCache @object = Java.Lang.Object.GetObject<WebPlayerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			WebPlayerView object2 = Java.Lang.Object.GetObject<WebPlayerView>(native_webPlayerView, JniHandleOwnership.DoNotTransfer);
			@object.AddWebPlayer(@string, object2);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0003D580 File Offset: 0x0003B780
		[Register("addWebPlayer", "(Ljava/lang/String;Lcom/unity3d/services/ads/webplayer/WebPlayerView;)V", "GetAddWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_Handler")]
		public unsafe virtual void AddWebPlayer(string viewId, WebPlayerView webPlayerView)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((webPlayerView == null) ? IntPtr.Zero : webPlayerView.Handle);
				WebPlayerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("addWebPlayer.(Ljava/lang/String;Lcom/unity3d/services/ads/webplayer/WebPlayerView;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(webPlayerView);
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0003D604 File Offset: 0x0003B804
		private static Delegate GetGetWebPlayer_Ljava_lang_String_Handler()
		{
			if (WebPlayerViewCache.cb_getWebPlayer_Ljava_lang_String_ == null)
			{
				WebPlayerViewCache.cb_getWebPlayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WebPlayerViewCache.n_GetWebPlayer_Ljava_lang_String_));
			}
			return WebPlayerViewCache.cb_getWebPlayer_Ljava_lang_String_;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0003D628 File Offset: 0x0003B828
		private static IntPtr n_GetWebPlayer_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerViewCache @object = Java.Lang.Object.GetObject<WebPlayerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetWebPlayer(@string));
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0003D650 File Offset: 0x0003B850
		[Register("getWebPlayer", "(Ljava/lang/String;)Lcom/unity3d/services/ads/webplayer/WebPlayerView;", "GetGetWebPlayer_Ljava_lang_String_Handler")]
		public unsafe virtual WebPlayerView GetWebPlayer(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			WebPlayerView @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebPlayerView>(WebPlayerViewCache._members.InstanceMethods.InvokeVirtualObjectMethod("getWebPlayer.(Ljava/lang/String;)Lcom/unity3d/services/ads/webplayer/WebPlayerView;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0003D6BC File Offset: 0x0003B8BC
		private static Delegate GetRemoveWebPlayer_Ljava_lang_String_Handler()
		{
			if (WebPlayerViewCache.cb_removeWebPlayer_Ljava_lang_String_ == null)
			{
				WebPlayerViewCache.cb_removeWebPlayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebPlayerViewCache.n_RemoveWebPlayer_Ljava_lang_String_));
			}
			return WebPlayerViewCache.cb_removeWebPlayer_Ljava_lang_String_;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
		private static void n_RemoveWebPlayer_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			WebPlayerViewCache @object = Java.Lang.Object.GetObject<WebPlayerViewCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			@object.RemoveWebPlayer(@string);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0003D704 File Offset: 0x0003B904
		[Register("removeWebPlayer", "(Ljava/lang/String;)V", "GetRemoveWebPlayer_Ljava_lang_String_Handler")]
		public unsafe virtual void RemoveWebPlayer(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebPlayerViewCache._members.InstanceMethods.InvokeVirtualVoidMethod("removeWebPlayer.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000510 RID: 1296
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerViewCache", typeof(WebPlayerViewCache));

		// Token: 0x04000511 RID: 1297
		private static Delegate cb_addWebPlayer_Ljava_lang_String_Lcom_unity3d_services_ads_webplayer_WebPlayerView_;

		// Token: 0x04000512 RID: 1298
		private static Delegate cb_getWebPlayer_Ljava_lang_String_;

		// Token: 0x04000513 RID: 1299
		private static Delegate cb_removeWebPlayer_Ljava_lang_String_;
	}
}
