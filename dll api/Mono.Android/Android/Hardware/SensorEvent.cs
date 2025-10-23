using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Hardware
{
	// Token: 0x02000210 RID: 528
	[Register("android/hardware/SensorEvent", DoNotGenerateAcw = true)]
	public class SensorEvent : Java.Lang.Object
	{
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00031C27 File Offset: 0x0002FE27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SensorEvent._members;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00031C30 File Offset: 0x0002FE30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SensorEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00031C54 File Offset: 0x0002FE54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SensorEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SensorEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400087C RID: 2172
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/hardware/SensorEvent", typeof(SensorEvent));
	}
}
