using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001CF RID: 463
	[Register("com/unity3d/services/ads/webplayer/WebPlayerError", DoNotGenerateAcw = true)]
	public sealed class WebPlayerError : Java.Lang.Enum
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0003BA20 File Offset: 0x00039C20
		[Register("WEBPLAYER_NULL")]
		public static WebPlayerError WebplayerNull
		{
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerError>(WebPlayerError._members.StaticFields.GetObjectValue("WEBPLAYER_NULL.Lcom/unity3d/services/ads/webplayer/WebPlayerError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0003BA50 File Offset: 0x00039C50
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0003BA74 File Offset: 0x00039C74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerError._members;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0003BA7C File Offset: 0x00039C7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0003BAA0 File Offset: 0x00039CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerError._members.ManagedPeerType;
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0000256C File Offset: 0x0000076C
		internal WebPlayerError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0003BAAC File Offset: 0x00039CAC
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/webplayer/WebPlayerError;", "")]
		public unsafe static WebPlayerError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			WebPlayerError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebPlayerError>(WebPlayerError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/webplayer/WebPlayerError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0003BB18 File Offset: 0x00039D18
		[Register("values", "()[Lcom/unity3d/services/ads/webplayer/WebPlayerError;", "")]
		public static WebPlayerError[] Values()
		{
			return (WebPlayerError[])JNIEnv.GetArray(WebPlayerError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/webplayer/WebPlayerError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebPlayerError));
		}

		// Token: 0x040004FB RID: 1275
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerError", typeof(WebPlayerError));
	}
}
