using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/android/gms/ads/FullScreenContentCallback", DoNotGenerateAcw = true)]
	internal class FullScreenContentCallbackInvoker : FullScreenContentCallback
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00003DF3 File Offset: 0x00001FF3
		public FullScreenContentCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003DFD File Offset: 0x00001FFD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FullScreenContentCallbackInvoker._members;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003E04 File Offset: 0x00002004
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FullScreenContentCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/FullScreenContentCallback", typeof(FullScreenContentCallbackInvoker));
	}
}
