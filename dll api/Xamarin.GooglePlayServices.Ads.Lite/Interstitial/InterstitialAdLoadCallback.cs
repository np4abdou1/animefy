using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Interstitial
{
	// Token: 0x02000036 RID: 54
	[Register("com/google/android/gms/ads/interstitial/InterstitialAdLoadCallback", DoNotGenerateAcw = true)]
	public abstract class InterstitialAdLoadCallback : AdLoadCallback
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00006F54 File Offset: 0x00005154
		internal new static IntPtr class_ref
		{
			get
			{
				return InterstitialAdLoadCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00006F78 File Offset: 0x00005178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InterstitialAdLoadCallback._members;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00006F80 File Offset: 0x00005180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InterstitialAdLoadCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00006FA4 File Offset: 0x000051A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InterstitialAdLoadCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002A83 File Offset: 0x00000C83
		protected InterstitialAdLoadCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00006FB0 File Offset: 0x000051B0
		[Register(".ctor", "()V", "")]
		public InterstitialAdLoadCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InterstitialAdLoadCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InterstitialAdLoadCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000085 RID: 133
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/interstitial/InterstitialAdLoadCallback", typeof(InterstitialAdLoadCallback));
	}
}
