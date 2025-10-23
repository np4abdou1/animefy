using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x0200007E RID: 126
	[Register("com/unity3d/services/core/webview/bridge/WebViewBridgeError", DoNotGenerateAcw = true)]
	public sealed class WebViewBridgeError : Java.Lang.Enum
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		[Register("CLASS_NOT_EXPOSED")]
		public static WebViewBridgeError ClassNotExposed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("CLASS_NOT_EXPOSED.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		[Register("CLASS_NOT_FOUND")]
		public static WebViewBridgeError ClassNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("CLASS_NOT_FOUND.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		[Register("DATA_GET_PARAMETER_VALUE_FAILED")]
		public static WebViewBridgeError DataGetParameterValueFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("DATA_GET_PARAMETER_VALUE_FAILED.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		[Register("DATA_JSON_PARSE_FAILED")]
		public static WebViewBridgeError DataJsonParseFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("DATA_JSON_PARSE_FAILED.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		[Register("DATA_PARAMETER_NULL")]
		public static WebViewBridgeError DataParameterNull
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("DATA_PARAMETER_NULL.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		[Register("GETALLOWEDMETHODS_INVOCATION_FAILED")]
		public static WebViewBridgeError GetallowedmethodsInvocationFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("GETALLOWEDMETHODS_INVOCATION_FAILED.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		[Register("GETALLOWEDMETHODS_NOT_FOUND")]
		public static WebViewBridgeError GetallowedmethodsNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("GETALLOWEDMETHODS_NOT_FOUND.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000CC7C File Offset: 0x0000AE7C
		[Register("INVOCATION_FAILED")]
		public static WebViewBridgeError InvocationFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("INVOCATION_FAILED.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		[Register("METHOD_NOT_FOUND")]
		public static WebViewBridgeError MethodNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("METHOD_NOT_FOUND.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		[Register("METHOD_UNALLOWED")]
		public static WebViewBridgeError MethodUnallowed
		{
			get
			{
				return Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticFields.GetObjectValue("METHOD_UNALLOWED.Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000CD0C File Offset: 0x0000AF0C
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridgeError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000CD30 File Offset: 0x0000AF30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridgeError._members;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridgeError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridgeError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000256C File Offset: 0x0000076C
		internal WebViewBridgeError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;", "")]
		public unsafe static WebViewBridgeError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			WebViewBridgeError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebViewBridgeError>(WebViewBridgeError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
		[Register("values", "()[Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;", "")]
		public static WebViewBridgeError[] Values()
		{
			return (WebViewBridgeError[])JNIEnv.GetArray(WebViewBridgeError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/webview/bridge/WebViewBridgeError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebViewBridgeError));
		}

		// Token: 0x040000ED RID: 237
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewBridgeError", typeof(WebViewBridgeError));
	}
}
