using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x02000110 RID: 272
	[Register("android/view/ActionMode", DoNotGenerateAcw = true)]
	internal class ActionModeInvoker : ActionMode
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x00010025 File Offset: 0x0000E225
		public ActionModeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0001002F File Offset: 0x0000E22F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionModeInvoker._members;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00010036 File Offset: 0x0000E236
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionModeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040001D1 RID: 465
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ActionMode", typeof(ActionModeInvoker));
	}
}
