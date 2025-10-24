using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Iab.Omid.Library.Applovin.Publisher
{
	// Token: 0x02000037 RID: 55
	[Register("com/iab/omid/library/applovin/publisher/AdSessionStatePublisher", DoNotGenerateAcw = true)]
	internal class AdSessionStatePublisherInvoker : AdSessionStatePublisher
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00003641 File Offset: 0x00001841
		public AdSessionStatePublisherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000364B File Offset: 0x0000184B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSessionStatePublisherInvoker._members;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00003652 File Offset: 0x00001852
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionStatePublisherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400002E RID: 46
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/publisher/AdSessionStatePublisher", typeof(AdSessionStatePublisherInvoker));
	}
}
