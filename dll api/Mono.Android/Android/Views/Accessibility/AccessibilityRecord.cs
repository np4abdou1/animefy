using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Accessibility
{
	// Token: 0x0200018A RID: 394
	[Register("android/view/accessibility/AccessibilityRecord", DoNotGenerateAcw = true)]
	public class AccessibilityRecord : Java.Lang.Object
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0002328F File Offset: 0x0002148F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityRecord._members;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00023298 File Offset: 0x00021498
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityRecord._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x000232BC File Offset: 0x000214BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityRecord._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AccessibilityRecord(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400062B RID: 1579
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/accessibility/AccessibilityRecord", typeof(AccessibilityRecord));
	}
}
