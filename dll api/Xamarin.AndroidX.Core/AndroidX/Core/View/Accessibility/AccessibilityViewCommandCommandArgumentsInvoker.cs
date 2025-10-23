using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000C7 RID: 199
	[Register("androidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments", DoNotGenerateAcw = true)]
	internal class AccessibilityViewCommandCommandArgumentsInvoker : AccessibilityViewCommandCommandArguments
	{
		// Token: 0x06000E05 RID: 3589 RVA: 0x00029AFF File Offset: 0x00027CFF
		public AccessibilityViewCommandCommandArgumentsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00029B09 File Offset: 0x00027D09
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityViewCommandCommandArgumentsInvoker._members;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00029B10 File Offset: 0x00027D10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityViewCommandCommandArgumentsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400041E RID: 1054
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments", typeof(AccessibilityViewCommandCommandArgumentsInvoker));
	}
}
