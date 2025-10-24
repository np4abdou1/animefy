using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x020001FE RID: 510
	[Register("android/media/AudioDeviceInfo", DoNotGenerateAcw = true, ApiSince = 23)]
	public sealed class AudioDeviceInfo : Java.Lang.Object
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00030847 File Offset: 0x0002EA47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AudioDeviceInfo._members;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00030850 File Offset: 0x0002EA50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AudioDeviceInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00030874 File Offset: 0x0002EA74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AudioDeviceInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000021E0 File Offset: 0x000003E0
		internal AudioDeviceInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000846 RID: 2118
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/AudioDeviceInfo", typeof(AudioDeviceInfo));
	}
}
