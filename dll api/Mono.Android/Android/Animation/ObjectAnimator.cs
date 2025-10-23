using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Animation
{
	// Token: 0x02000253 RID: 595
	[Register("android/animation/ObjectAnimator", DoNotGenerateAcw = true)]
	public sealed class ObjectAnimator : ValueAnimator
	{
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000372BF File Offset: 0x000354BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ObjectAnimator._members;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x000372C8 File Offset: 0x000354C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ObjectAnimator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x000372EC File Offset: 0x000354EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ObjectAnimator._members.ManagedPeerType;
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000372F8 File Offset: 0x000354F8
		internal ObjectAnimator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000969 RID: 2409
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/ObjectAnimator", typeof(ObjectAnimator));
	}
}
