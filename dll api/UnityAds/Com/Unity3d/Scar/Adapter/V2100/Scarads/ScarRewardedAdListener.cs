using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V2100.Scarads
{
	// Token: 0x0200024C RID: 588
	[Register("com/unity3d/scar/adapter/v2100/scarads/ScarRewardedAdListener", DoNotGenerateAcw = true)]
	public class ScarRewardedAdListener : ScarAdListener
	{
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000554D0 File Offset: 0x000536D0
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x000554F4 File Offset: 0x000536F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAdListener._members;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x000554FC File Offset: 0x000536FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x00055520 File Offset: 0x00053720
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000554A8 File Offset: 0x000536A8
		protected ScarRewardedAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006E1 RID: 1761
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/scarads/ScarRewardedAdListener", typeof(ScarRewardedAdListener));
	}
}
