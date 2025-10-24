using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Adunit;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000221 RID: 545
	[Register("com/unity3d/services/ads/api/AdUnit", DoNotGenerateAcw = true)]
	public class AdUnit : Java.Lang.Object
	{
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00049908 File Offset: 0x00047B08
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0004992C File Offset: 0x00047B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnit._members;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00049934 File Offset: 0x00047B34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00049958 File Offset: 0x00047B58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnit._members.ManagedPeerType;
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdUnit(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00049964 File Offset: 0x00047B64
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x00049998 File Offset: 0x00047B98
		public unsafe static AdUnitActivity AdUnitActivity
		{
			[Register("getAdUnitActivity", "()Lcom/unity3d/services/ads/adunit/AdUnitActivity;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AdUnitActivity>(AdUnit._members.StaticMethods.InvokeObjectMethod("getAdUnitActivity.()Lcom/unity3d/services/ads/adunit/AdUnitActivity;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setAdUnitActivity", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AdUnit._members.StaticMethods.InvokeVoidMethod("setAdUnitActivity.(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x000499FC File Offset: 0x00047BFC
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x00049A14 File Offset: 0x00047C14
		public unsafe static int CurrentAdUnitActivityId
		{
			[Register("getCurrentAdUnitActivityId", "()I", "")]
			get
			{
				return AdUnit._members.StaticMethods.InvokeInt32Method("getCurrentAdUnitActivityId.()I", null);
			}
			[Register("setCurrentAdUnitActivityId", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setCurrentAdUnitActivityId.(I)V", ptr);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00049A50 File Offset: 0x00047C50
		[Register("clearMotionEventCapture", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void ClearMotionEventCapture(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("clearMotionEventCapture.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00049AB4 File Offset: 0x00047CB4
		[Register("close", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Close(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("close.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00049B18 File Offset: 0x00047D18
		[Register("endMotionEventCapture", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void EndMotionEventCapture(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("endMotionEventCapture.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00049B7C File Offset: 0x00047D7C
		[Register("getCurrentMotionEventCount", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetCurrentMotionEventCount(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getCurrentMotionEventCount.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00049BE0 File Offset: 0x00047DE0
		[Register("getMotionEventCount", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetMotionEventCount(JSONArray eventTypes, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventTypes == null) ? IntPtr.Zero : eventTypes.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getMotionEventCount.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(eventTypes);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00049C6C File Offset: 0x00047E6C
		[Register("getMotionEventData", "(Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetMotionEventData(JSONObject infoIndices, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((infoIndices == null) ? IntPtr.Zero : infoIndices.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getMotionEventData.(Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(infoIndices);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00049CF8 File Offset: 0x00047EF8
		[Register("getOrientation", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetOrientation(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getOrientation.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00049D5C File Offset: 0x00047F5C
		[Register("getSafeAreaInsets", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSafeAreaInsets(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getSafeAreaInsets.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00049DC0 File Offset: 0x00047FC0
		[Register("getViewFrame", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetViewFrame(string view, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(view);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getViewFrame.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00049E44 File Offset: 0x00048044
		[Register("getViews", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetViews(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("getViews.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00049EA8 File Offset: 0x000480A8
		[Register("open", "(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Open(Integer activityId, JSONArray views, Integer orientation, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activityId == null) ? IntPtr.Zero : activityId.Handle);
				ptr[1] = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
				ptr[2] = new JniArgumentValue((orientation == null) ? IntPtr.Zero : orientation.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("open.(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activityId);
				GC.KeepAlive(views);
				GC.KeepAlive(orientation);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00049F88 File Offset: 0x00048188
		[Register("open", "(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Open(Integer activityId, JSONArray views, Integer orientation, JSONArray keyevents, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activityId == null) ? IntPtr.Zero : activityId.Handle);
				ptr[1] = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
				ptr[2] = new JniArgumentValue((orientation == null) ? IntPtr.Zero : orientation.Handle);
				ptr[3] = new JniArgumentValue((keyevents == null) ? IntPtr.Zero : keyevents.Handle);
				ptr[4] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("open.(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activityId);
				GC.KeepAlive(views);
				GC.KeepAlive(orientation);
				GC.KeepAlive(keyevents);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0004A098 File Offset: 0x00048298
		[Register("open", "(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Open(Integer activityId, JSONArray views, Integer orientation, JSONArray keyevents, Integer systemUiVisibility, Java.Lang.Boolean hardwareAcceleration, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activityId == null) ? IntPtr.Zero : activityId.Handle);
				ptr[1] = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
				ptr[2] = new JniArgumentValue((orientation == null) ? IntPtr.Zero : orientation.Handle);
				ptr[3] = new JniArgumentValue((keyevents == null) ? IntPtr.Zero : keyevents.Handle);
				ptr[4] = new JniArgumentValue((systemUiVisibility == null) ? IntPtr.Zero : systemUiVisibility.Handle);
				ptr[5] = new JniArgumentValue((hardwareAcceleration == null) ? IntPtr.Zero : hardwareAcceleration.Handle);
				ptr[6] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("open.(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activityId);
				GC.KeepAlive(views);
				GC.KeepAlive(orientation);
				GC.KeepAlive(keyevents);
				GC.KeepAlive(systemUiVisibility);
				GC.KeepAlive(hardwareAcceleration);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0004A210 File Offset: 0x00048410
		[Register("open", "(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Boolean;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Open(Integer activityId, JSONArray views, Integer orientation, JSONArray keyevents, Integer systemUiVisibility, Java.Lang.Boolean hardwareAcceleration, Java.Lang.Boolean isTransparent, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activityId == null) ? IntPtr.Zero : activityId.Handle);
				ptr[1] = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
				ptr[2] = new JniArgumentValue((orientation == null) ? IntPtr.Zero : orientation.Handle);
				ptr[3] = new JniArgumentValue((keyevents == null) ? IntPtr.Zero : keyevents.Handle);
				ptr[4] = new JniArgumentValue((systemUiVisibility == null) ? IntPtr.Zero : systemUiVisibility.Handle);
				ptr[5] = new JniArgumentValue((hardwareAcceleration == null) ? IntPtr.Zero : hardwareAcceleration.Handle);
				ptr[6] = new JniArgumentValue((isTransparent == null) ? IntPtr.Zero : isTransparent.Handle);
				ptr[7] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("open.(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Boolean;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activityId);
				GC.KeepAlive(views);
				GC.KeepAlive(orientation);
				GC.KeepAlive(keyevents);
				GC.KeepAlive(systemUiVisibility);
				GC.KeepAlive(hardwareAcceleration);
				GC.KeepAlive(isTransparent);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0004A3B4 File Offset: 0x000485B4
		[Register("open", "(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Boolean;Ljava/lang/Boolean;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Open(Integer activityId, JSONArray views, Integer orientation, JSONArray keyevents, Integer systemUiVisibility, Java.Lang.Boolean hardwareAcceleration, Java.Lang.Boolean isTransparent, Integer displayCutoutMode, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activityId == null) ? IntPtr.Zero : activityId.Handle);
				ptr[1] = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
				ptr[2] = new JniArgumentValue((orientation == null) ? IntPtr.Zero : orientation.Handle);
				ptr[3] = new JniArgumentValue((keyevents == null) ? IntPtr.Zero : keyevents.Handle);
				ptr[4] = new JniArgumentValue((systemUiVisibility == null) ? IntPtr.Zero : systemUiVisibility.Handle);
				ptr[5] = new JniArgumentValue((hardwareAcceleration == null) ? IntPtr.Zero : hardwareAcceleration.Handle);
				ptr[6] = new JniArgumentValue((isTransparent == null) ? IntPtr.Zero : isTransparent.Handle);
				ptr[7] = new JniArgumentValue((displayCutoutMode == null) ? IntPtr.Zero : displayCutoutMode.Handle);
				ptr[8] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("open.(Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Boolean;Ljava/lang/Boolean;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activityId);
				GC.KeepAlive(views);
				GC.KeepAlive(orientation);
				GC.KeepAlive(keyevents);
				GC.KeepAlive(systemUiVisibility);
				GC.KeepAlive(hardwareAcceleration);
				GC.KeepAlive(isTransparent);
				GC.KeepAlive(displayCutoutMode);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0004A588 File Offset: 0x00048788
		[Register("setKeepScreenOn", "(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetKeepScreenOn(Java.Lang.Boolean screenOn, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((screenOn == null) ? IntPtr.Zero : screenOn.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setKeepScreenOn.(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(screenOn);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0004A614 File Offset: 0x00048814
		[Register("setKeyEventList", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetKeyEventList(JSONArray keyevents, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((keyevents == null) ? IntPtr.Zero : keyevents.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setKeyEventList.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(keyevents);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0004A6A0 File Offset: 0x000488A0
		[Register("setLayoutInDisplayCutoutMode", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetLayoutInDisplayCutoutMode(Integer displayCutoutMode, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((displayCutoutMode == null) ? IntPtr.Zero : displayCutoutMode.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setLayoutInDisplayCutoutMode.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(displayCutoutMode);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0004A72C File Offset: 0x0004892C
		[Register("setOrientation", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetOrientation(Integer orientation, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((orientation == null) ? IntPtr.Zero : orientation.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setOrientation.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(orientation);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0004A7B8 File Offset: 0x000489B8
		[Register("setSystemUiVisibility", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetSystemUiVisibility(Integer systemUiVisibility, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((systemUiVisibility == null) ? IntPtr.Zero : systemUiVisibility.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setSystemUiVisibility.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(systemUiVisibility);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0004A844 File Offset: 0x00048A44
		[Register("setViewFrame", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetViewFrame(string view, Integer x, Integer y, Integer width, Integer height, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(view);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((x == null) ? IntPtr.Zero : x.Handle);
				ptr[2] = new JniArgumentValue((y == null) ? IntPtr.Zero : y.Handle);
				ptr[3] = new JniArgumentValue((width == null) ? IntPtr.Zero : width.Handle);
				ptr[4] = new JniArgumentValue((height == null) ? IntPtr.Zero : height.Handle);
				ptr[5] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setViewFrame.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(x);
				GC.KeepAlive(y);
				GC.KeepAlive(width);
				GC.KeepAlive(height);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0004A978 File Offset: 0x00048B78
		[Register("setViews", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetViews(JSONArray views, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("setViews.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(views);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0004AA04 File Offset: 0x00048C04
		[Register("startMotionEventCapture", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void StartMotionEventCapture(Integer maxEvents, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((maxEvents == null) ? IntPtr.Zero : maxEvents.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				AdUnit._members.StaticMethods.InvokeVoidMethod("startMotionEventCapture.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(maxEvents);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000658 RID: 1624
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/AdUnit", typeof(AdUnit));
	}
}
