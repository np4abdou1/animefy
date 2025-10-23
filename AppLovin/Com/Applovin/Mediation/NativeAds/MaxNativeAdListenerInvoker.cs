using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.NativeAds
{
	// Token: 0x020000CE RID: 206
	[Register("com/applovin/mediation/nativeAds/MaxNativeAdListener", DoNotGenerateAcw = true)]
	internal class MaxNativeAdListenerInvoker : MaxNativeAdListener
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x00013337 File Offset: 0x00011537
		public MaxNativeAdListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00013341 File Offset: 0x00011541
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNativeAdListenerInvoker._members;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00013348 File Offset: 0x00011548
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNativeAdListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400027D RID: 637
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/nativeAds/MaxNativeAdListener", typeof(MaxNativeAdListenerInvoker));
	}
}
