using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x02000411 RID: 1041
	[Register("java/io/BufferedInputStream", DoNotGenerateAcw = true)]
	public class BufferedInputStream : FilterInputStream
	{
		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x0007D884 File Offset: 0x0007BA84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BufferedInputStream._members;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x0007D88C File Offset: 0x0007BA8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BufferedInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x0007D8B0 File Offset: 0x0007BAB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BufferedInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x0007D8BC File Offset: 0x0007BABC
		protected BufferedInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001202 RID: 4610
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/BufferedInputStream", typeof(BufferedInputStream));
	}
}
