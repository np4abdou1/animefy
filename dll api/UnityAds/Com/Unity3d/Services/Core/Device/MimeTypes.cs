using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x0200011F RID: 287
	[Register("com/unity3d/services/core/device/MimeTypes", DoNotGenerateAcw = true)]
	public class MimeTypes : Java.Lang.Object
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0002035C File Offset: 0x0001E55C
		internal static IntPtr class_ref
		{
			get
			{
				return MimeTypes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00020380 File Offset: 0x0001E580
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MimeTypes._members;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00020388 File Offset: 0x0001E588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MimeTypes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000203AC File Offset: 0x0001E5AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MimeTypes._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MimeTypes(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[Register(".ctor", "()V", "")]
		public MimeTypes() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MimeTypes._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MimeTypes._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000298 RID: 664
		[Register("BASE_TYPE_AUDIO")]
		public const string BaseTypeAudio = "audio";

		// Token: 0x04000299 RID: 665
		[Register("BASE_TYPE_VIDEO")]
		public const string BaseTypeVideo = "video";

		// Token: 0x0400029A RID: 666
		[Register("VIDEO_H264")]
		public const string VideoH264 = "video/avc";

		// Token: 0x0400029B RID: 667
		[Register("VIDEO_H265")]
		public const string VideoH265 = "video/hevc";

		// Token: 0x0400029C RID: 668
		[Register("VIDEO_WEBM")]
		public const string VideoWebm = "video/webm";

		// Token: 0x0400029D RID: 669
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/MimeTypes", typeof(MimeTypes));
	}
}
