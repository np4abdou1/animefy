using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Security
{
	// Token: 0x02000369 RID: 873
	[Register("java/security/MessageDigestSpi", DoNotGenerateAcw = true)]
	internal class MessageDigestSpiInvoker : MessageDigestSpi
	{
		// Token: 0x060026A0 RID: 9888 RVA: 0x0006E84C File Offset: 0x0006CA4C
		public MessageDigestSpiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x0006E8FB File Offset: 0x0006CAFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MessageDigestSpiInvoker._members;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0006E902 File Offset: 0x0006CB02
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MessageDigestSpiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000FF3 RID: 4083
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/MessageDigestSpi", typeof(MessageDigestSpiInvoker));
	}
}
