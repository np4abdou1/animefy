using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V2100.Scarads
{
	// Token: 0x0200024B RID: 587
	[Register("com/unity3d/scar/adapter/v2100/scarads/ScarInterstitialAdListener", DoNotGenerateAcw = true)]
	public class ScarInterstitialAdListener : ScarAdListener
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0005544C File Offset: 0x0005364C
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00055470 File Offset: 0x00053670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAdListener._members;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00055478 File Offset: 0x00053678
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0005549C File Offset: 0x0005369C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000554A8 File Offset: 0x000536A8
		protected ScarInterstitialAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006E0 RID: 1760
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/scarads/ScarInterstitialAdListener", typeof(ScarInterstitialAdListener));
	}
}
