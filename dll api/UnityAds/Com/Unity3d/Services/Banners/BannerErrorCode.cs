using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x02000196 RID: 406
	[Register("com/unity3d/services/banners/BannerErrorCode", DoNotGenerateAcw = true)]
	public sealed class BannerErrorCode : Java.Lang.Enum
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00034E10 File Offset: 0x00033010
		[Register("NATIVE_ERROR")]
		public static BannerErrorCode NativeError
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerErrorCode>(BannerErrorCode._members.StaticFields.GetObjectValue("NATIVE_ERROR.Lcom/unity3d/services/banners/BannerErrorCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00034E40 File Offset: 0x00033040
		[Register("NO_FILL")]
		public static BannerErrorCode NoFill
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerErrorCode>(BannerErrorCode._members.StaticFields.GetObjectValue("NO_FILL.Lcom/unity3d/services/banners/BannerErrorCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00034E70 File Offset: 0x00033070
		[Register("UNKNOWN")]
		public static BannerErrorCode Unknown
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerErrorCode>(BannerErrorCode._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/unity3d/services/banners/BannerErrorCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00034EA0 File Offset: 0x000330A0
		[Register("WEBVIEW_ERROR")]
		public static BannerErrorCode WebviewError
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerErrorCode>(BannerErrorCode._members.StaticFields.GetObjectValue("WEBVIEW_ERROR.Lcom/unity3d/services/banners/BannerErrorCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00034ED0 File Offset: 0x000330D0
		internal static IntPtr class_ref
		{
			get
			{
				return BannerErrorCode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00034EF4 File Offset: 0x000330F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerErrorCode._members;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00034EFC File Offset: 0x000330FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerErrorCode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00034F20 File Offset: 0x00033120
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerErrorCode._members.ManagedPeerType;
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0000256C File Offset: 0x0000076C
		internal BannerErrorCode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00034F2C File Offset: 0x0003312C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/banners/BannerErrorCode;", "")]
		public unsafe static BannerErrorCode ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			BannerErrorCode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BannerErrorCode>(BannerErrorCode._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/banners/BannerErrorCode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00034F98 File Offset: 0x00033198
		[Register("values", "()[Lcom/unity3d/services/banners/BannerErrorCode;", "")]
		public static BannerErrorCode[] Values()
		{
			return (BannerErrorCode[])JNIEnv.GetArray(BannerErrorCode._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/banners/BannerErrorCode;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BannerErrorCode));
		}

		// Token: 0x04000459 RID: 1113
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerErrorCode", typeof(BannerErrorCode));
	}
}
