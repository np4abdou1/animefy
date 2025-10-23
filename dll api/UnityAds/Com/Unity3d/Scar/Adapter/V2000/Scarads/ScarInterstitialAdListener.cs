using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V2000.Scarads
{
	// Token: 0x02000262 RID: 610
	[Register("com/unity3d/scar/adapter/v2000/scarads/ScarInterstitialAdListener", DoNotGenerateAcw = true)]
	public class ScarInterstitialAdListener : ScarAdListener
	{
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000596B0 File Offset: 0x000578B0
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000596D4 File Offset: 0x000578D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAdListener._members;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000596DC File Offset: 0x000578DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x00059700 File Offset: 0x00057900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0005970C File Offset: 0x0005790C
		protected ScarInterstitialAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000703 RID: 1795
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/scarads/ScarInterstitialAdListener", typeof(ScarInterstitialAdListener));
	}
}
