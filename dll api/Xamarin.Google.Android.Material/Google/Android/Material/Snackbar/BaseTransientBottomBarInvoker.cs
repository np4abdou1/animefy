using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Snackbar
{
	// Token: 0x02000090 RID: 144
	[Register("com/google/android/material/snackbar/BaseTransientBottomBar", DoNotGenerateAcw = true)]
	internal class BaseTransientBottomBarInvoker : BaseTransientBottomBar
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x00018E5C File Offset: 0x0001705C
		public BaseTransientBottomBarInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0001AFFB File Offset: 0x000191FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseTransientBottomBarInvoker._members;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0001B002 File Offset: 0x00019202
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseTransientBottomBarInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040002E0 RID: 736
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/BaseTransientBottomBar", typeof(BaseTransientBottomBarInvoker));
	}
}
