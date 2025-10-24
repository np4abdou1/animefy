using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Video
{
	// Token: 0x020001D5 RID: 469
	[Register("com/unity3d/services/ads/video/VideoPlayerError", DoNotGenerateAcw = true)]
	public sealed class VideoPlayerError : Java.Lang.Enum
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0003D77C File Offset: 0x0003B97C
		[Register("API_LEVEL_ERROR")]
		public static VideoPlayerError ApiLevelError
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerError>(VideoPlayerError._members.StaticFields.GetObjectValue("API_LEVEL_ERROR.Lcom/unity3d/services/ads/video/VideoPlayerError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0003D7AC File Offset: 0x0003B9AC
		[Register("PREPARE")]
		public static VideoPlayerError Prepare
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerError>(VideoPlayerError._members.StaticFields.GetObjectValue("PREPARE.Lcom/unity3d/services/ads/video/VideoPlayerError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x0003D7DC File Offset: 0x0003B9DC
		[Register("VIDEOVIEW_NULL")]
		public static VideoPlayerError VideoviewNull
		{
			get
			{
				return Java.Lang.Object.GetObject<VideoPlayerError>(VideoPlayerError._members.StaticFields.GetObjectValue("VIDEOVIEW_NULL.Lcom/unity3d/services/ads/video/VideoPlayerError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0003D80C File Offset: 0x0003BA0C
		internal static IntPtr class_ref
		{
			get
			{
				return VideoPlayerError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x0003D830 File Offset: 0x0003BA30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoPlayerError._members;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0003D838 File Offset: 0x0003BA38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoPlayerError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0003D85C File Offset: 0x0003BA5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoPlayerError._members.ManagedPeerType;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0000256C File Offset: 0x0000076C
		internal VideoPlayerError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0003D868 File Offset: 0x0003BA68
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/video/VideoPlayerError;", "")]
		public unsafe static VideoPlayerError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			VideoPlayerError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<VideoPlayerError>(VideoPlayerError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/video/VideoPlayerError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0003D8D4 File Offset: 0x0003BAD4
		[Register("values", "()[Lcom/unity3d/services/ads/video/VideoPlayerError;", "")]
		public static VideoPlayerError[] Values()
		{
			return (VideoPlayerError[])JNIEnv.GetArray(VideoPlayerError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/video/VideoPlayerError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(VideoPlayerError));
		}

		// Token: 0x04000514 RID: 1300
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/video/VideoPlayerError", typeof(VideoPlayerError));
	}
}
