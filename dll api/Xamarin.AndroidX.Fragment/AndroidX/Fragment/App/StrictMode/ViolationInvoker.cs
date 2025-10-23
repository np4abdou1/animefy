using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Fragment.App.StrictMode
{
	// Token: 0x02000053 RID: 83
	[Register("androidx/fragment/app/strictmode/Violation", DoNotGenerateAcw = true)]
	internal class ViolationInvoker : Violation
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x0000E805 File Offset: 0x0000CA05
		public ViolationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000E80F File Offset: 0x0000CA0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViolationInvoker._members;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0000E816 File Offset: 0x0000CA16
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViolationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000130 RID: 304
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/strictmode/Violation", typeof(ViolationInvoker));
	}
}
