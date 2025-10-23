using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001F1 RID: 497
	[Register("android/os/Parcel", DoNotGenerateAcw = true)]
	public sealed class Parcel : Java.Lang.Object
	{
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x0002FDDB File Offset: 0x0002DFDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Parcel._members;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Parcel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x0002FE08 File Offset: 0x0002E008
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Parcel._members.ManagedPeerType;
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Parcel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400080A RID: 2058
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Parcel", typeof(Parcel));
	}
}
