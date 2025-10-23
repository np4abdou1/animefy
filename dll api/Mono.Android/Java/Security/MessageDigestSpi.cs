using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Security
{
	// Token: 0x02000368 RID: 872
	[Register("java/security/MessageDigestSpi", DoNotGenerateAcw = true)]
	public abstract class MessageDigestSpi : Java.Lang.Object
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0006E8A9 File Offset: 0x0006CAA9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MessageDigestSpi._members;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x0006E8B0 File Offset: 0x0006CAB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MessageDigestSpi._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x0006E8D4 File Offset: 0x0006CAD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MessageDigestSpi._members.ManagedPeerType;
			}
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000021E0 File Offset: 0x000003E0
		protected MessageDigestSpi(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000FF2 RID: 4082
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/MessageDigestSpi", typeof(MessageDigestSpi));
	}
}
