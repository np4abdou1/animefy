using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.VectorDrawable.Graphics.Drawable
{
	// Token: 0x0200000A RID: 10
	[Register("androidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback", DoNotGenerateAcw = true)]
	internal class Animatable2CompatAnimationCallbackInvoker : Animatable2CompatAnimationCallback
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000022CB File Offset: 0x000004CB
		public Animatable2CompatAnimationCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000022D5 File Offset: 0x000004D5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Animatable2CompatAnimationCallbackInvoker._members;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000022DC File Offset: 0x000004DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Animatable2CompatAnimationCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback", typeof(Animatable2CompatAnimationCallbackInvoker));
	}
}
