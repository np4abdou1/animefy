using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview
{
	// Token: 0x0200006F RID: 111
	[Register("com/unity3d/services/core/webview/WebViewEventCategory", DoNotGenerateAcw = true)]
	public sealed class WebViewEventCategory : Java.Lang.Enum
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000AD0C File Offset: 0x00008F0C
		[Register("ADUNIT")]
		public static WebViewEventCategory Adunit
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("ADUNIT.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000AD3C File Offset: 0x00008F3C
		[Register("ANALYTICS")]
		public static WebViewEventCategory Analytics
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("ANALYTICS.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000AD6C File Offset: 0x00008F6C
		[Register("BANNER")]
		public static WebViewEventCategory Banner
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("BANNER.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000AD9C File Offset: 0x00008F9C
		[Register("BROADCAST")]
		public static WebViewEventCategory Broadcast
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("BROADCAST.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000ADCC File Offset: 0x00008FCC
		[Register("CACHE")]
		public static WebViewEventCategory Cache
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("CACHE.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000ADFC File Offset: 0x00008FFC
		[Register("CONNECTIVITY")]
		public static WebViewEventCategory Connectivity
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("CONNECTIVITY.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000AE2C File Offset: 0x0000902C
		[Register("DEVICEINFO")]
		public static WebViewEventCategory Deviceinfo
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("DEVICEINFO.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000AE5C File Offset: 0x0000905C
		[Register("GMA")]
		public static WebViewEventCategory Gma
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("GMA.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000AE8C File Offset: 0x0000908C
		[Register("INIT_GMA")]
		public static WebViewEventCategory InitGma
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("INIT_GMA.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000AEBC File Offset: 0x000090BC
		[Register("LIFECYCLE")]
		public static WebViewEventCategory Lifecycle
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("LIFECYCLE.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000AEEC File Offset: 0x000090EC
		[Register("LOAD_API")]
		public static WebViewEventCategory LoadApi
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("LOAD_API.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000AF1C File Offset: 0x0000911C
		[Register("PERMISSIONS")]
		public static WebViewEventCategory Permissions
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("PERMISSIONS.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000AF4C File Offset: 0x0000914C
		[Register("PURCHASING")]
		public static WebViewEventCategory Purchasing
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("PURCHASING.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000AF7C File Offset: 0x0000917C
		[Register("REQUEST")]
		public static WebViewEventCategory Request
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("REQUEST.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0000AFAC File Offset: 0x000091AC
		[Register("RESOLVE")]
		public static WebViewEventCategory Resolve
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("RESOLVE.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000AFDC File Offset: 0x000091DC
		[Register("STORAGE")]
		public static WebViewEventCategory Storage
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("STORAGE.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0000B00C File Offset: 0x0000920C
		[Register("STORE")]
		public static WebViewEventCategory Store
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("STORE.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000B03C File Offset: 0x0000923C
		[Register("TOKEN")]
		public static WebViewEventCategory Token
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("TOKEN.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000B06C File Offset: 0x0000926C
		[Register("VIDEOPLAYER")]
		public static WebViewEventCategory Videoplayer
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("VIDEOPLAYER.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000B09C File Offset: 0x0000929C
		[Register("WEBPLAYER")]
		public static WebViewEventCategory Webplayer
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticFields.GetObjectValue("WEBPLAYER.Lcom/unity3d/services/core/webview/WebViewEventCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000B0CC File Offset: 0x000092CC
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewEventCategory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000B0F0 File Offset: 0x000092F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewEventCategory._members;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000B0F8 File Offset: 0x000092F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewEventCategory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000B11C File Offset: 0x0000931C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewEventCategory._members.ManagedPeerType;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000256C File Offset: 0x0000076C
		internal WebViewEventCategory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000B128 File Offset: 0x00009328
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/WebViewEventCategory;", "")]
		public unsafe static WebViewEventCategory ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			WebViewEventCategory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebViewEventCategory>(WebViewEventCategory._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/webview/WebViewEventCategory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000B194 File Offset: 0x00009394
		[Register("values", "()[Lcom/unity3d/services/core/webview/WebViewEventCategory;", "")]
		public static WebViewEventCategory[] Values()
		{
			return (WebViewEventCategory[])JNIEnv.GetArray(WebViewEventCategory._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/webview/WebViewEventCategory;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebViewEventCategory));
		}

		// Token: 0x040000C3 RID: 195
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/WebViewEventCategory", typeof(WebViewEventCategory));
	}
}
