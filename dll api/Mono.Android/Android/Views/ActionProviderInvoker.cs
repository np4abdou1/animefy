using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x02000112 RID: 274
	[Register("android/view/ActionProvider", DoNotGenerateAcw = true)]
	internal class ActionProviderInvoker : ActionProvider
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x000100AF File Offset: 0x0000E2AF
		public ActionProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000100B9 File Offset: 0x0000E2B9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionProviderInvoker._members;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000100C0 File Offset: 0x0000E2C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040001D3 RID: 467
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ActionProvider", typeof(ActionProviderInvoker));
	}
}
