using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000227 RID: 551
	[Register("android/graphics/Path", DoNotGenerateAcw = true)]
	public class Path : Java.Lang.Object
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x00032AE6 File Offset: 0x00030CE6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Path._members;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00032AF0 File Offset: 0x00030CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Path._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00032B14 File Offset: 0x00030D14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Path._members.ManagedPeerType;
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Path(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008A1 RID: 2209
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Path", typeof(Path));
	}
}
