using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Security
{
	// Token: 0x02000366 RID: 870
	[Register("java/security/MessageDigest", DoNotGenerateAcw = true)]
	public abstract class MessageDigest : MessageDigestSpi
	{
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x0006E813 File Offset: 0x0006CA13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MessageDigest._members;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x0006E81C File Offset: 0x0006CA1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MessageDigest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0006E840 File Offset: 0x0006CA40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MessageDigest._members.ManagedPeerType;
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0006E84C File Offset: 0x0006CA4C
		protected MessageDigest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000FF0 RID: 4080
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/MessageDigest", typeof(MessageDigest));
	}
}
