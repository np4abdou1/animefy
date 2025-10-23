using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Views.Animations
{
	// Token: 0x02000183 RID: 387
	[Register("android/view/animation/Animation", DoNotGenerateAcw = true)]
	internal class AnimationInvoker : Animation
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x00022A1C File Offset: 0x00020C1C
		public AnimationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00022D56 File Offset: 0x00020F56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimationInvoker._members;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00022D5D File Offset: 0x00020F5D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000620 RID: 1568
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/animation/Animation", typeof(AnimationInvoker));
	}
}
