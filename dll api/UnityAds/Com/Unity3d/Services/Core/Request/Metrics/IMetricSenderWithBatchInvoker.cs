using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000BC RID: 188
	[Register("com/unity3d/services/core/request/metrics/IMetricSenderWithBatch", DoNotGenerateAcw = true)]
	internal class IMetricSenderWithBatchInvoker : IMetricSenderWithBatch
	{
		// Token: 0x060006EE RID: 1774 RVA: 0x00013977 File Offset: 0x00011B77
		public IMetricSenderWithBatchInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00013981 File Offset: 0x00011B81
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMetricSenderWithBatchInvoker._members;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00013988 File Offset: 0x00011B88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMetricSenderWithBatchInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040001A6 RID: 422
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/IMetricSenderWithBatch", typeof(IMetricSenderWithBatchInvoker));
	}
}
