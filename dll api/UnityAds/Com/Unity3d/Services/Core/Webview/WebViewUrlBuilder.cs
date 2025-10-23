using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview
{
	// Token: 0x02000070 RID: 112
	[Register("com/unity3d/services/core/webview/WebViewUrlBuilder", DoNotGenerateAcw = true)]
	public class WebViewUrlBuilder : Java.Lang.Object
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000B1F0 File Offset: 0x000093F0
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewUrlBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000B214 File Offset: 0x00009414
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewUrlBuilder._members;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000B21C File Offset: 0x0000941C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewUrlBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000B240 File Offset: 0x00009440
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewUrlBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewUrlBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000B24C File Offset: 0x0000944C
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe WebViewUrlBuilder(string baseUrl, Configuration configuration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(baseUrl);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				base.SetHandle(WebViewUrlBuilder._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/Configuration;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewUrlBuilder._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000B318 File Offset: 0x00009518
		private static Delegate GetGetUrlWithQueryStringHandler()
		{
			if (WebViewUrlBuilder.cb_getUrlWithQueryString == null)
			{
				WebViewUrlBuilder.cb_getUrlWithQueryString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewUrlBuilder.n_GetUrlWithQueryString));
			}
			return WebViewUrlBuilder.cb_getUrlWithQueryString;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000B33C File Offset: 0x0000953C
		private static IntPtr n_GetUrlWithQueryString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebViewUrlBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UrlWithQueryString);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000B350 File Offset: 0x00009550
		public virtual string UrlWithQueryString
		{
			[Register("getUrlWithQueryString", "()Ljava/lang/String;", "GetGetUrlWithQueryStringHandler")]
			get
			{
				return JNIEnv.GetString(WebViewUrlBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getUrlWithQueryString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040000C4 RID: 196
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/WebViewUrlBuilder", typeof(WebViewUrlBuilder));

		// Token: 0x040000C5 RID: 197
		private static Delegate cb_getUrlWithQueryString;
	}
}
