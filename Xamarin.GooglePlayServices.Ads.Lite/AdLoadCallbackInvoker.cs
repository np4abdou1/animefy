using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads
{
	// Token: 0x02000010 RID: 16
	[Register("com/google/android/gms/ads/AdLoadCallback", DoNotGenerateAcw = true)]
	internal class AdLoadCallbackInvoker : AdLoadCallback
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002A83 File Offset: 0x00000C83
		public AdLoadCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002A8D File Offset: 0x00000C8D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdLoadCallbackInvoker._members;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002A94 File Offset: 0x00000C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdLoadCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdLoadCallback", typeof(AdLoadCallbackInvoker));
	}
}
