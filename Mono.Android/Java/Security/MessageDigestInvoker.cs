using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Security
{
	// Token: 0x02000367 RID: 871
	[Register("java/security/MessageDigest", DoNotGenerateAcw = true)]
	internal class MessageDigestInvoker : MessageDigest
	{
		// Token: 0x06002697 RID: 9879 RVA: 0x0006E871 File Offset: 0x0006CA71
		public MessageDigestInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x0006E87B File Offset: 0x0006CA7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MessageDigestInvoker._members;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0006E882 File Offset: 0x0006CA82
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MessageDigestInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000FF1 RID: 4081
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/MessageDigest", typeof(MessageDigestInvoker));
	}
}
