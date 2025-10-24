using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Gms.Ads.Initialization;
using Android.Runtime;
using Android.Webkit;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x0200001F RID: 31
	[Register("com/google/android/gms/ads/MobileAds", DoNotGenerateAcw = true)]
	public class MobileAds : Java.Lang.Object
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000045E0 File Offset: 0x000027E0
		internal static IntPtr class_ref
		{
			get
			{
				return MobileAds._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004604 File Offset: 0x00002804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MobileAds._members;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000460C File Offset: 0x0000280C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MobileAds._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004630 File Offset: 0x00002830
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MobileAds._members.ManagedPeerType;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000020AC File Offset: 0x000002AC
		protected MobileAds(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000463C File Offset: 0x0000283C
		public static IInitializationStatus InitializationStatus
		{
			[Register("getInitializationStatus", "()Lcom/google/android/gms/ads/initialization/InitializationStatus;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IInitializationStatus>(MobileAds._members.StaticMethods.InvokeObjectMethod("getInitializationStatus.()Lcom/google/android/gms/ads/initialization/InitializationStatus;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004670 File Offset: 0x00002870
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000046A4 File Offset: 0x000028A4
		public unsafe static RequestConfiguration RequestConfiguration
		{
			[Register("getRequestConfiguration", "()Lcom/google/android/gms/ads/RequestConfiguration;", "")]
			get
			{
				return Java.Lang.Object.GetObject<RequestConfiguration>(MobileAds._members.StaticMethods.InvokeObjectMethod("getRequestConfiguration.()Lcom/google/android/gms/ads/RequestConfiguration;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequestConfiguration", "(Lcom/google/android/gms/ads/RequestConfiguration;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					MobileAds._members.StaticMethods.InvokeVoidMethod("setRequestConfiguration.(Lcom/google/android/gms/ads/RequestConfiguration;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004708 File Offset: 0x00002908
		public static VersionInfo Version
		{
			[Register("getVersion", "()Lcom/google/android/gms/ads/VersionInfo;", "")]
			get
			{
				return Java.Lang.Object.GetObject<VersionInfo>(MobileAds._members.StaticMethods.InvokeObjectMethod("getVersion.()Lcom/google/android/gms/ads/VersionInfo;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000473C File Offset: 0x0000293C
		[Register("disableMediationAdapterInitialization", "(Landroid/content/Context;)V", "")]
		public unsafe static void DisableMediationAdapterInitialization(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				MobileAds._members.StaticMethods.InvokeVoidMethod("disableMediationAdapterInitialization.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000047A0 File Offset: 0x000029A0
		[Register("enableSameAppKey", "(Z)V", "")]
		public unsafe static void EnableSameAppKey(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			MobileAds._members.StaticMethods.InvokeVoidMethod("enableSameAppKey.(Z)V", ptr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000047DC File Offset: 0x000029DC
		[Register("initialize", "(Landroid/content/Context;)V", "")]
		public unsafe static void Initialize(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				MobileAds._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004840 File Offset: 0x00002A40
		[Register("initialize", "(Landroid/content/Context;Lcom/google/android/gms/ads/initialization/OnInitializationCompleteListener;)V", "")]
		public unsafe static void Initialize(Context context, IOnInitializationCompleteListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				MobileAds._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;Lcom/google/android/gms/ads/initialization/OnInitializationCompleteListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000048D0 File Offset: 0x00002AD0
		[Register("openAdInspector", "(Landroid/content/Context;Lcom/google/android/gms/ads/OnAdInspectorClosedListener;)V", "")]
		public unsafe static void OpenAdInspector(Context context, IOnAdInspectorClosedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				MobileAds._members.StaticMethods.InvokeVoidMethod("openAdInspector.(Landroid/content/Context;Lcom/google/android/gms/ads/OnAdInspectorClosedListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004960 File Offset: 0x00002B60
		[Register("openDebugMenu", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe static void OpenDebugMenu(Context context, string adUnitId)
		{
			IntPtr intPtr = JNIEnv.NewString(adUnitId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				MobileAds._members.StaticMethods.InvokeVoidMethod("openDebugMenu.(Landroid/content/Context;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000049E4 File Offset: 0x00002BE4
		[Register("registerRtbAdapter", "(Ljava/lang/Class;)V", "")]
		public unsafe static void RegisterRtbAdapter(Class adapterClass)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterClass == null) ? IntPtr.Zero : adapterClass.Handle);
				MobileAds._members.StaticMethods.InvokeVoidMethod("registerRtbAdapter.(Ljava/lang/Class;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(adapterClass);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004A48 File Offset: 0x00002C48
		[Register("registerWebView", "(Landroid/webkit/WebView;)V", "")]
		public unsafe static void RegisterWebView(WebView webview)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webview == null) ? IntPtr.Zero : webview.Handle);
				MobileAds._members.StaticMethods.InvokeVoidMethod("registerWebView.(Landroid/webkit/WebView;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(webview);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004AAC File Offset: 0x00002CAC
		[Register("setAppMuted", "(Z)V", "")]
		public unsafe static void SetAppMuted(bool muted)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(muted);
			MobileAds._members.StaticMethods.InvokeVoidMethod("setAppMuted.(Z)V", ptr);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Register("setAppVolume", "(F)V", "")]
		public unsafe static void SetAppVolume(float volume)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(volume);
			MobileAds._members.StaticMethods.InvokeVoidMethod("setAppVolume.(F)V", ptr);
		}

		// Token: 0x04000039 RID: 57
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/MobileAds", typeof(MobileAds));
	}
}
