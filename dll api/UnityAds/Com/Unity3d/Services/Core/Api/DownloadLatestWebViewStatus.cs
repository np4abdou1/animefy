using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x0200018B RID: 395
	[Register("com/unity3d/services/core/api/DownloadLatestWebViewStatus", DoNotGenerateAcw = true)]
	public sealed class DownloadLatestWebViewStatus : Java.Lang.Enum
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x00031C14 File Offset: 0x0002FE14
		[Register("BACKGROUND_DOWNLOAD_STARTED")]
		public static DownloadLatestWebViewStatus BackgroundDownloadStarted
		{
			get
			{
				return Java.Lang.Object.GetObject<DownloadLatestWebViewStatus>(DownloadLatestWebViewStatus._members.StaticFields.GetObjectValue("BACKGROUND_DOWNLOAD_STARTED.Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x00031C44 File Offset: 0x0002FE44
		[Register("INIT_QUEUE_NOT_EMPTY")]
		public static DownloadLatestWebViewStatus InitQueueNotEmpty
		{
			get
			{
				return Java.Lang.Object.GetObject<DownloadLatestWebViewStatus>(DownloadLatestWebViewStatus._members.StaticFields.GetObjectValue("INIT_QUEUE_NOT_EMPTY.Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00031C74 File Offset: 0x0002FE74
		[Register("INIT_QUEUE_NULL")]
		public static DownloadLatestWebViewStatus InitQueueNull
		{
			get
			{
				return Java.Lang.Object.GetObject<DownloadLatestWebViewStatus>(DownloadLatestWebViewStatus._members.StaticFields.GetObjectValue("INIT_QUEUE_NULL.Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00031CA4 File Offset: 0x0002FEA4
		[Register("MISSING_LATEST_CONFIG")]
		public static DownloadLatestWebViewStatus MissingLatestConfig
		{
			get
			{
				return Java.Lang.Object.GetObject<DownloadLatestWebViewStatus>(DownloadLatestWebViewStatus._members.StaticFields.GetObjectValue("MISSING_LATEST_CONFIG.Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00031CD4 File Offset: 0x0002FED4
		internal static IntPtr class_ref
		{
			get
			{
				return DownloadLatestWebViewStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DownloadLatestWebViewStatus._members;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x00031D00 File Offset: 0x0002FF00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DownloadLatestWebViewStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00031D24 File Offset: 0x0002FF24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DownloadLatestWebViewStatus._members.ManagedPeerType;
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0000256C File Offset: 0x0000076C
		internal DownloadLatestWebViewStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00031D30 File Offset: 0x0002FF30
		public int Value
		{
			[Register("getValue", "()I", "")]
			get
			{
				return DownloadLatestWebViewStatus._members.InstanceMethods.InvokeAbstractInt32Method("getValue.()I", this, null);
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00031D4C File Offset: 0x0002FF4C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;", "")]
		public unsafe static DownloadLatestWebViewStatus ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			DownloadLatestWebViewStatus @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DownloadLatestWebViewStatus>(DownloadLatestWebViewStatus._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		[Register("values", "()[Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;", "")]
		public static DownloadLatestWebViewStatus[] Values()
		{
			return (DownloadLatestWebViewStatus[])JNIEnv.GetArray(DownloadLatestWebViewStatus._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DownloadLatestWebViewStatus));
		}

		// Token: 0x0400044E RID: 1102
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/DownloadLatestWebViewStatus", typeof(DownloadLatestWebViewStatus));
	}
}
