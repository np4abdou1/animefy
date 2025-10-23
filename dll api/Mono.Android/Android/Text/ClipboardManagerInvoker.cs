using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text
{
	// Token: 0x02000199 RID: 409
	[Register("android/text/ClipboardManager", DoNotGenerateAcw = true)]
	internal class ClipboardManagerInvoker : ClipboardManager
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x00024B03 File Offset: 0x00022D03
		public ClipboardManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00024B0D File Offset: 0x00022D0D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClipboardManagerInvoker._members;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00024B14 File Offset: 0x00022D14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClipboardManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040006A8 RID: 1704
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/ClipboardManager", typeof(ClipboardManagerInvoker));
	}
}
