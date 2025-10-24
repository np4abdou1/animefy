using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.Interstitial
{
	// Token: 0x02000037 RID: 55
	[Register("com/google/android/gms/ads/interstitial/InterstitialAdLoadCallback", DoNotGenerateAcw = true)]
	internal class InterstitialAdLoadCallbackInvoker : InterstitialAdLoadCallback
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00007039 File Offset: 0x00005239
		public InterstitialAdLoadCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00007043 File Offset: 0x00005243
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InterstitialAdLoadCallbackInvoker._members;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000704A File Offset: 0x0000524A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InterstitialAdLoadCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/interstitial/InterstitialAdLoadCallback", typeof(InterstitialAdLoadCallbackInvoker));
	}
}
