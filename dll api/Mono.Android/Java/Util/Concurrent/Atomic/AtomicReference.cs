using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util.Concurrent.Atomic
{
	// Token: 0x02000360 RID: 864
	[Register("java/util/concurrent/atomic/AtomicReference", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"V"
	})]
	public class AtomicReference : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AtomicReference._members;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x0006E3CC File Offset: 0x0006C5CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AtomicReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AtomicReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AtomicReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000FE8 RID: 4072
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/atomic/AtomicReference", typeof(AtomicReference));
	}
}
