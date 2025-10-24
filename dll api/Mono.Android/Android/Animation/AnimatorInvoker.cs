using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Animation
{
	// Token: 0x0200024E RID: 590
	[Register("android/animation/Animator", DoNotGenerateAcw = true)]
	internal class AnimatorInvoker : Animator
	{
		// Token: 0x0600156A RID: 5482 RVA: 0x00036C6A File Offset: 0x00034E6A
		public AnimatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00036C74 File Offset: 0x00034E74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimatorInvoker._members;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00036C7B File Offset: 0x00034E7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400095C RID: 2396
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/Animator", typeof(AnimatorInvoker));
	}
}
