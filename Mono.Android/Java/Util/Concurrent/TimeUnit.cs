using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x0200035B RID: 859
	[Register("java/util/concurrent/TimeUnit", DoNotGenerateAcw = true)]
	public sealed class TimeUnit : Java.Lang.Enum
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x0006DA7D File Offset: 0x0006BC7D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeUnit._members;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x0006DA84 File Offset: 0x0006BC84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeUnit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x0006DAA8 File Offset: 0x0006BCA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeUnit._members.ManagedPeerType;
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00008BD0 File Offset: 0x00006DD0
		internal TimeUnit(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000FC9 RID: 4041
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/TimeUnit", typeof(TimeUnit));
	}
}
