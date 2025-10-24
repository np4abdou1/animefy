using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Hardware
{
	// Token: 0x0200020F RID: 527
	[Register("android/hardware/Sensor", DoNotGenerateAcw = true)]
	public class Sensor : Java.Lang.Object
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00031BD2 File Offset: 0x0002FDD2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Sensor._members;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00031BDC File Offset: 0x0002FDDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Sensor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00031C00 File Offset: 0x0002FE00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Sensor._members.ManagedPeerType;
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Sensor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400087B RID: 2171
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/hardware/Sensor", typeof(Sensor));
	}
}
