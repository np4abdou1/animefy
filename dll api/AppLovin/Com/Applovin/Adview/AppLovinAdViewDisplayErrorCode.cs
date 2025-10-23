using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x0200018F RID: 399
	[Register("com/applovin/adview/AppLovinAdViewDisplayErrorCode", DoNotGenerateAcw = true)]
	public sealed class AppLovinAdViewDisplayErrorCode : Java.Lang.Enum
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00035640 File Offset: 0x00033840
		[Register("UNSPECIFIED")]
		public static AppLovinAdViewDisplayErrorCode Unspecified
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdViewDisplayErrorCode>(AppLovinAdViewDisplayErrorCode._members.StaticFields.GetObjectValue("UNSPECIFIED.Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00035670 File Offset: 0x00033870
		[Register("WEBVIEW_NOT_FOUND")]
		public static AppLovinAdViewDisplayErrorCode WebviewNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdViewDisplayErrorCode>(AppLovinAdViewDisplayErrorCode._members.StaticFields.GetObjectValue("WEBVIEW_NOT_FOUND.Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x000356A0 File Offset: 0x000338A0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdViewDisplayErrorCode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x000356C4 File Offset: 0x000338C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdViewDisplayErrorCode._members;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000356CC File Offset: 0x000338CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdViewDisplayErrorCode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x000356F0 File Offset: 0x000338F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdViewDisplayErrorCode._members.ManagedPeerType;
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal AppLovinAdViewDisplayErrorCode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000356FC File Offset: 0x000338FC
		[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;", "")]
		public unsafe static AppLovinAdViewDisplayErrorCode ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinAdViewDisplayErrorCode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AppLovinAdViewDisplayErrorCode>(AppLovinAdViewDisplayErrorCode._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00035768 File Offset: 0x00033968
		[Register("values", "()[Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;", "")]
		public static AppLovinAdViewDisplayErrorCode[] Values()
		{
			return (AppLovinAdViewDisplayErrorCode[])JNIEnv.GetArray(AppLovinAdViewDisplayErrorCode._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AppLovinAdViewDisplayErrorCode));
		}

		// Token: 0x04000618 RID: 1560
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinAdViewDisplayErrorCode", typeof(AppLovinAdViewDisplayErrorCode));
	}
}
