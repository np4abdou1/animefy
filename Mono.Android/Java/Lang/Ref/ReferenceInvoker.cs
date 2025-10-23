using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Ref
{
	// Token: 0x0200040D RID: 1037
	[Register("java/lang/ref/Reference", DoNotGenerateAcw = true)]
	internal class ReferenceInvoker : Reference
	{
		// Token: 0x06002D94 RID: 11668 RVA: 0x0007D4C3 File Offset: 0x0007B6C3
		public ReferenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x0007D4CD File Offset: 0x0007B6CD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ReferenceInvoker._members;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x0007D4D4 File Offset: 0x0007B6D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ReferenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040011F6 RID: 4598
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ref/Reference", typeof(ReferenceInvoker));
	}
}
