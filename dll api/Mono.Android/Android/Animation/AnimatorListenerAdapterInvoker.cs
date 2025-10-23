using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Animation
{
	// Token: 0x02000250 RID: 592
	[Register("android/animation/AnimatorListenerAdapter", DoNotGenerateAcw = true)]
	internal class AnimatorListenerAdapterInvoker : AnimatorListenerAdapter
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x000370FF File Offset: 0x000352FF
		public AnimatorListenerAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00037109 File Offset: 0x00035309
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimatorListenerAdapterInvoker._members;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00037110 File Offset: 0x00035310
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimatorListenerAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000964 RID: 2404
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/AnimatorListenerAdapter", typeof(AnimatorListenerAdapterInvoker));
	}
}
