using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001D0 RID: 464
	[Register("com/unity3d/services/ads/webplayer/WebPlayerEvent", DoNotGenerateAcw = true)]
	public sealed class WebPlayerEvent : Java.Lang.Enum
	{
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0003BB74 File Offset: 0x00039D74
		[Register("CLIENT_CERT_REQUEST")]
		public static WebPlayerEvent ClientCertRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("CLIENT_CERT_REQUEST.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0003BBA4 File Offset: 0x00039DA4
		[Register("CLOSE_WINDOW")]
		public static WebPlayerEvent CloseWindow
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("CLOSE_WINDOW.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0003BBD4 File Offset: 0x00039DD4
		[Register("CONSOLE_MESSAGE")]
		public static WebPlayerEvent ConsoleMessage
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("CONSOLE_MESSAGE.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0003BC04 File Offset: 0x00039E04
		[Register("CREATE_WINDOW")]
		public static WebPlayerEvent CreateWindow
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("CREATE_WINDOW.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0003BC34 File Offset: 0x00039E34
		[Register("DOWNLOAD_START")]
		public static WebPlayerEvent DownloadStart
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("DOWNLOAD_START.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0003BC64 File Offset: 0x00039E64
		[Register("ERROR")]
		public static WebPlayerEvent Error
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("ERROR.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0003BC94 File Offset: 0x00039E94
		[Register("FORM_RESUBMISSION")]
		public static WebPlayerEvent FormResubmission
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("FORM_RESUBMISSION.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0003BCC4 File Offset: 0x00039EC4
		[Register("FRAME_UPDATE")]
		public static WebPlayerEvent FrameUpdate
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("FRAME_UPDATE.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0003BCF4 File Offset: 0x00039EF4
		[Register("GEOLOCATION_PERMISSIONS_SHOW")]
		public static WebPlayerEvent GeolocationPermissionsShow
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("GEOLOCATION_PERMISSIONS_SHOW.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0003BD24 File Offset: 0x00039F24
		[Register("GET_FRAME_RESPONSE")]
		public static WebPlayerEvent GetFrameResponse
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("GET_FRAME_RESPONSE.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0003BD54 File Offset: 0x00039F54
		[Register("HIDE_CUSTOM_VIEW")]
		public static WebPlayerEvent HideCustomView
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("HIDE_CUSTOM_VIEW.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0003BD84 File Offset: 0x00039F84
		[Register("HTTP_AUTH_REQUEST")]
		public static WebPlayerEvent HttpAuthRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("HTTP_AUTH_REQUEST.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0003BDB4 File Offset: 0x00039FB4
		[Register("HTTP_ERROR")]
		public static WebPlayerEvent HttpError
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("HTTP_ERROR.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0003BDE4 File Offset: 0x00039FE4
		[Register("JS_ALERT")]
		public static WebPlayerEvent JsAlert
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("JS_ALERT.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0003BE14 File Offset: 0x0003A014
		[Register("JS_CONFIRM")]
		public static WebPlayerEvent JsConfirm
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("JS_CONFIRM.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0003BE44 File Offset: 0x0003A044
		[Register("JS_PROMPT")]
		public static WebPlayerEvent JsPrompt
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("JS_PROMPT.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0003BE74 File Offset: 0x0003A074
		[Register("LOAD_RESOUCE")]
		public static WebPlayerEvent LoadResouce
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("LOAD_RESOUCE.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x0003BEA4 File Offset: 0x0003A0A4
		[Register("LOGIN_REQUEST")]
		public static WebPlayerEvent LoginRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("LOGIN_REQUEST.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x0003BED4 File Offset: 0x0003A0D4
		[Register("PAGE_COMMIT_VISIBLE")]
		public static WebPlayerEvent PageCommitVisible
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("PAGE_COMMIT_VISIBLE.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0003BF04 File Offset: 0x0003A104
		[Register("PAGE_FINISHED")]
		public static WebPlayerEvent PageFinished
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("PAGE_FINISHED.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0003BF34 File Offset: 0x0003A134
		[Register("PAGE_STARTED")]
		public static WebPlayerEvent PageStarted
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("PAGE_STARTED.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0003BF64 File Offset: 0x0003A164
		[Register("PERMISSION_REQUEST")]
		public static WebPlayerEvent PermissionRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("PERMISSION_REQUEST.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0003BF94 File Offset: 0x0003A194
		[Register("PROGRESS_CHANGED")]
		public static WebPlayerEvent ProgressChanged
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("PROGRESS_CHANGED.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		[Register("RECEIVED_ICON")]
		public static WebPlayerEvent ReceivedIcon
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("RECEIVED_ICON.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		[Register("RECEIVED_TITLE")]
		public static WebPlayerEvent ReceivedTitle
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("RECEIVED_TITLE.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0003C024 File Offset: 0x0003A224
		[Register("RECEIVED_TOUCH_ICON_URL")]
		public static WebPlayerEvent ReceivedTouchIconUrl
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("RECEIVED_TOUCH_ICON_URL.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0003C054 File Offset: 0x0003A254
		[Register("REQUEST_FOCUS")]
		public static WebPlayerEvent RequestFocus
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("REQUEST_FOCUS.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0003C084 File Offset: 0x0003A284
		[Register("SCALE_CHANGED")]
		public static WebPlayerEvent ScaleChanged
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SCALE_CHANGED.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		[Register("SHOULD_INTERCEPT_REQUEST")]
		public static WebPlayerEvent ShouldInterceptRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SHOULD_INTERCEPT_REQUEST.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		[Register("SHOULD_OVERRIDE_KEY_EVENT")]
		public static WebPlayerEvent ShouldOverrideKeyEvent
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SHOULD_OVERRIDE_KEY_EVENT.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0003C114 File Offset: 0x0003A314
		[Register("SHOULD_OVERRIDE_URL_LOADING")]
		public static WebPlayerEvent ShouldOverrideUrlLoading
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SHOULD_OVERRIDE_URL_LOADING.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0003C144 File Offset: 0x0003A344
		[Register("SHOW_CUSTOM_VIEW")]
		public static WebPlayerEvent ShowCustomView
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SHOW_CUSTOM_VIEW.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0003C174 File Offset: 0x0003A374
		[Register("SHOW_FILE_CHOOSER")]
		public static WebPlayerEvent ShowFileChooser
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SHOW_FILE_CHOOSER.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
		[Register("SSL_ERROR")]
		public static WebPlayerEvent SslError
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("SSL_ERROR.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0003C1D4 File Offset: 0x0003A3D4
		[Register("UNHANDLED_KEY_EVENT")]
		public static WebPlayerEvent UnhandledKeyEvent
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("UNHANDLED_KEY_EVENT.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0003C204 File Offset: 0x0003A404
		[Register("WEBPLAYER_EVENT")]
		public static WebPlayerEvent WebplayerEvent
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticFields.GetObjectValue("WEBPLAYER_EVENT.Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0003C234 File Offset: 0x0003A434
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0003C258 File Offset: 0x0003A458
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerEvent._members;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0003C260 File Offset: 0x0003A460
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0003C284 File Offset: 0x0003A484
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0000256C File Offset: 0x0000076C
		internal WebPlayerEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0003C290 File Offset: 0x0003A490
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;", "")]
		public unsafe static WebPlayerEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			WebPlayerEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebPlayerEvent>(WebPlayerEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		[Register("values", "()[Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;", "")]
		public static WebPlayerEvent[] Values()
		{
			return (WebPlayerEvent[])JNIEnv.GetArray(WebPlayerEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/webplayer/WebPlayerEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebPlayerEvent));
		}

		// Token: 0x040004FC RID: 1276
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerEvent", typeof(WebPlayerEvent));
	}
}
