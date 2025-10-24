using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003FA RID: 1018
	[Register("java/lang/Void", DoNotGenerateAcw = true)]
	public sealed class Void : Object
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x0007B5DB File Offset: 0x000797DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Void._members;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x0007B5E4 File Offset: 0x000797E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Void._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x0007B608 File Offset: 0x00079808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Void._members.ManagedPeerType;
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Void(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040011B2 RID: 4530
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Void", typeof(Void));
	}
}
