using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200016D RID: 365
	[Register("android/view/WindowMetrics", DoNotGenerateAcw = true, ApiSince = 30)]
	public sealed class WindowMetrics : Java.Lang.Object
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000228BB File Offset: 0x00020ABB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WindowMetrics._members;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000228C4 File Offset: 0x00020AC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WindowMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000228E8 File Offset: 0x00020AE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WindowMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000021E0 File Offset: 0x000003E0
		internal WindowMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400046F RID: 1135
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/WindowMetrics", typeof(WindowMetrics));
	}
}
