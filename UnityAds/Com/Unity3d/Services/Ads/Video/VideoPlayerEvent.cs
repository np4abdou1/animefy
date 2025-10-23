using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Video
{
	// Token: 0x020001D6 RID: 470
	[Register("com/unity3d/services/ads/video/VideoPlayerEvent", DoNotGenerateAcw = true)]
	public sealed class VideoPlayerEvent : Java.Lang.Enum
	{
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0003D930 File Offset: 0x0003BB30
		[Register("COMPLETED")]
		public static VideoPlayerEvent Completed
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("COMPLETED.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x0003D960 File Offset: 0x0003BB60
		[Register("GENERIC_ERROR")]
		public static VideoPlayerEvent GenericError
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("GENERIC_ERROR.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x0003D990 File Offset: 0x0003BB90
		[Register("ILLEGAL_STATE")]
		public static VideoPlayerEvent IllegalState
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("ILLEGAL_STATE.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x0003D9C0 File Offset: 0x0003BBC0
		[Register("INFO")]
		public static VideoPlayerEvent Info
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("INFO.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
		[Register("PAUSE")]
		public static VideoPlayerEvent Pause
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PAUSE.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x0003DA20 File Offset: 0x0003BC20
		[Register("PAUSE_ERROR")]
		public static VideoPlayerEvent PauseError
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PAUSE_ERROR.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0003DA50 File Offset: 0x0003BC50
		[Register("PLAY")]
		public static VideoPlayerEvent Play
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PLAY.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0003DA80 File Offset: 0x0003BC80
		[Register("PREPARED")]
		public static VideoPlayerEvent Prepared
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PREPARED.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0003DAB0 File Offset: 0x0003BCB0
		[Register("PREPARE_ERROR")]
		public static VideoPlayerEvent PrepareError
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PREPARE_ERROR.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
		[Register("PREPARE_TIMEOUT")]
		public static VideoPlayerEvent PrepareTimeout
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PREPARE_TIMEOUT.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0003DB10 File Offset: 0x0003BD10
		[Register("PROGRESS")]
		public static VideoPlayerEvent Progress
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("PROGRESS.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0003DB40 File Offset: 0x0003BD40
		[Register("SEEKTO")]
		public static VideoPlayerEvent Seekto
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("SEEKTO.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0003DB70 File Offset: 0x0003BD70
		[Register("SEEKTO_ERROR")]
		public static VideoPlayerEvent SeektoError
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("SEEKTO_ERROR.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0003DBA0 File Offset: 0x0003BDA0
		[Register("STOP")]
		public static VideoPlayerEvent Stop
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticFields.GetObjectValue("STOP.Lcom/unity3d/services/ads/video/VideoPlayerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0003DBD0 File Offset: 0x0003BDD0
		internal static IntPtr class_ref
		{
			get
			{
				return VideoPlayerEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoPlayerEvent._members;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoPlayerEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0003DC20 File Offset: 0x0003BE20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoPlayerEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0000256C File Offset: 0x0000076C
		internal VideoPlayerEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0003DC2C File Offset: 0x0003BE2C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/video/VideoPlayerEvent;", "")]
		public unsafe static VideoPlayerEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			VideoPlayerEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<VideoPlayerEvent>(VideoPlayerEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/video/VideoPlayerEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0003DC98 File Offset: 0x0003BE98
		[Register("values", "()[Lcom/unity3d/services/ads/video/VideoPlayerEvent;", "")]
		public static VideoPlayerEvent[] Values()
		{
			return (VideoPlayerEvent[])JNIEnv.GetArray(VideoPlayerEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/video/VideoPlayerEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(VideoPlayerEvent));
		}

		// Token: 0x04000515 RID: 1301
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/video/VideoPlayerEvent", typeof(VideoPlayerEvent));
	}
}
