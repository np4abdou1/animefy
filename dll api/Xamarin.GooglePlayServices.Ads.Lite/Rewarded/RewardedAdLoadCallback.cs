using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x0200002F RID: 47
	[Register("com/google/android/gms/ads/rewarded/RewardedAdLoadCallback", DoNotGenerateAcw = true)]
	public abstract class RewardedAdLoadCallback : AdLoadCallback
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000065CC File Offset: 0x000047CC
		internal new static IntPtr class_ref
		{
			get
			{
				return RewardedAdLoadCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000065F0 File Offset: 0x000047F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RewardedAdLoadCallback._members;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000065F8 File Offset: 0x000047F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RewardedAdLoadCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000661C File Offset: 0x0000481C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RewardedAdLoadCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002A83 File Offset: 0x00000C83
		protected RewardedAdLoadCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006628 File Offset: 0x00004828
		[Register(".ctor", "()V", "")]
		public RewardedAdLoadCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(RewardedAdLoadCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			RewardedAdLoadCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000071 RID: 113
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/RewardedAdLoadCallback", typeof(RewardedAdLoadCallback));
	}
}
