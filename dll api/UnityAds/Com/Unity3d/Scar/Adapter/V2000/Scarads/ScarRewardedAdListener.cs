using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V2000.Scarads
{
	// Token: 0x02000263 RID: 611
	[Register("com/unity3d/scar/adapter/v2000/scarads/ScarRewardedAdListener", DoNotGenerateAcw = true)]
	public class ScarRewardedAdListener : ScarAdListener
	{
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x00059734 File Offset: 0x00057934
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x00059758 File Offset: 0x00057958
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAdListener._members;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x00059760 File Offset: 0x00057960
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x00059784 File Offset: 0x00057984
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0005970C File Offset: 0x0005790C
		protected ScarRewardedAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000704 RID: 1796
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/scarads/ScarRewardedAdListener", typeof(ScarRewardedAdListener));
	}
}
