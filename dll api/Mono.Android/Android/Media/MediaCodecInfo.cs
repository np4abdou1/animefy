using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x02000205 RID: 517
	[Register("android/media/MediaCodecInfo", DoNotGenerateAcw = true)]
	public sealed class MediaCodecInfo : Java.Lang.Object
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00031070 File Offset: 0x0002F270
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaCodecInfo._members;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00031078 File Offset: 0x0002F278
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaCodecInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0003109C File Offset: 0x0002F29C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaCodecInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000021E0 File Offset: 0x000003E0
		internal MediaCodecInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400085B RID: 2139
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/MediaCodecInfo", typeof(MediaCodecInfo));
	}
}
