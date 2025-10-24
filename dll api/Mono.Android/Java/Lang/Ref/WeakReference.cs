using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Ref
{
	// Token: 0x0200040E RID: 1038
	[Register("java/lang/ref/WeakReference", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class WeakReference : Reference
	{
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x0007D4FB File Offset: 0x0007B6FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WeakReference._members;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x0007D504 File Offset: 0x0007B704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WeakReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x0007D528 File Offset: 0x0007B728
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WeakReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x0007D4C3 File Offset: 0x0007B6C3
		protected WeakReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040011F7 RID: 4599
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ref/WeakReference", typeof(WeakReference));
	}
}
