using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Net
{
	// Token: 0x020003B2 RID: 946
	[Register("java/net/SocketAddress", DoNotGenerateAcw = true)]
	internal class SocketAddressInvoker : SocketAddress
	{
		// Token: 0x060029A6 RID: 10662 RVA: 0x00075030 File Offset: 0x00073230
		public SocketAddressInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x00075467 File Offset: 0x00073667
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SocketAddressInvoker._members;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0007546E File Offset: 0x0007366E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SocketAddressInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04001109 RID: 4361
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/SocketAddress", typeof(SocketAddressInvoker));
	}
}
