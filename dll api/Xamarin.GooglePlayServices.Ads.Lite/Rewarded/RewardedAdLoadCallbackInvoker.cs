using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000030 RID: 48
	[Register("com/google/android/gms/ads/rewarded/RewardedAdLoadCallback", DoNotGenerateAcw = true)]
	internal class RewardedAdLoadCallbackInvoker : RewardedAdLoadCallback
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x000066B1 File Offset: 0x000048B1
		public RewardedAdLoadCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000066BB File Offset: 0x000048BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RewardedAdLoadCallbackInvoker._members;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000066C2 File Offset: 0x000048C2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RewardedAdLoadCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/RewardedAdLoadCallback", typeof(RewardedAdLoadCallbackInvoker));
	}
}
