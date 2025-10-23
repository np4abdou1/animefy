using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Iab.Omid.Library.Adcolony.Publisher
{
	// Token: 0x02000022 RID: 34
	[Register("com/iab/omid/library/adcolony/publisher/AdSessionStatePublisher", DoNotGenerateAcw = true)]
	internal class AdSessionStatePublisherInvoker : AdSessionStatePublisher
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00003579 File Offset: 0x00001779
		public AdSessionStatePublisherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003583 File Offset: 0x00001783
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
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000358A File Offset: 0x0000178A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionStatePublisherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/publisher/AdSessionStatePublisher", typeof(AdSessionStatePublisherInvoker));
	}
}
