using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/android/gms/common/api/internal/BasePendingResult", DoNotGenerateAcw = true)]
	internal class BasePendingResultInvoker : BasePendingResult
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00004024 File Offset: 0x00002224
		public BasePendingResultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00005063 File Offset: 0x00003263
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BasePendingResultInvoker._members;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000506A File Offset: 0x0000326A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BasePendingResultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/BasePendingResult", typeof(BasePendingResultInvoker));
	}
}
