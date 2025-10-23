using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200016C RID: 364
	[Register("android/view/WindowInsets", DoNotGenerateAcw = true)]
	public sealed class WindowInsets : Java.Lang.Object
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00022869 File Offset: 0x00020A69
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WindowInsets._members;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00022870 File Offset: 0x00020A70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WindowInsets._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00022894 File Offset: 0x00020A94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WindowInsets._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000021E0 File Offset: 0x000003E0
		internal WindowInsets(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400046E RID: 1134
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/WindowInsets", typeof(WindowInsets));
	}
}
