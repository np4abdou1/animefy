using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002DE RID: 734
	[Register("com/unity3d/ads/UnityAdsShowOptions", DoNotGenerateAcw = true)]
	public class UnityAdsShowOptions : UnityAdsBaseOptions
	{
		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x00069488 File Offset: 0x00067688
		internal new static IntPtr class_ref
		{
			get
			{
				return UnityAdsShowOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x000694AC File Offset: 0x000676AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAdsShowOptions._members;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000694B4 File Offset: 0x000676B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAdsShowOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000694D8 File Offset: 0x000676D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAdsShowOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0006934C File Offset: 0x0006754C
		protected UnityAdsShowOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000694E4 File Offset: 0x000676E4
		[Register(".ctor", "()V", "")]
		public UnityAdsShowOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityAdsShowOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityAdsShowOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000845 RID: 2117
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAdsShowOptions", typeof(UnityAdsShowOptions));
	}
}
