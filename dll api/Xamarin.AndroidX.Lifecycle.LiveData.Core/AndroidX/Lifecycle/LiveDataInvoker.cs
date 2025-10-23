using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000D RID: 13
	[Register("androidx/lifecycle/LiveData", DoNotGenerateAcw = true)]
	internal class LiveDataInvoker : LiveData
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00002A07 File Offset: 0x00000C07
		public LiveDataInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002A11 File Offset: 0x00000C11
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LiveDataInvoker._members;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002A18 File Offset: 0x00000C18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LiveDataInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000014 RID: 20
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/LiveData", typeof(LiveDataInvoker));
	}
}
