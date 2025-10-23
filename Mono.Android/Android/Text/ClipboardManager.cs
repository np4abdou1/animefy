using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x02000198 RID: 408
	[Register("android/text/ClipboardManager", DoNotGenerateAcw = true)]
	public abstract class ClipboardManager : Java.Lang.Object
	{
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00024AAF File Offset: 0x00022CAF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClipboardManager._members;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00024AB8 File Offset: 0x00022CB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClipboardManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00024ADC File Offset: 0x00022CDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClipboardManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ClipboardManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006A7 RID: 1703
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/ClipboardManager", typeof(ClipboardManager));
	}
}
