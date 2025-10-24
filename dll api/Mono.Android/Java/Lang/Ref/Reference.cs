using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Ref
{
	// Token: 0x0200040C RID: 1036
	[Register("java/lang/ref/Reference", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class Reference : Object
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x0007D470 File Offset: 0x0007B670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Reference._members;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x0007D478 File Offset: 0x0007B678
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Reference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x0007D49C File Offset: 0x0007B69C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Reference._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Reference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040011F5 RID: 4597
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ref/Reference", typeof(Reference));
	}
}
