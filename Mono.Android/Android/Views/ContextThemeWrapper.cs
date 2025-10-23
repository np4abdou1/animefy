using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x02000113 RID: 275
	[Register("android/view/ContextThemeWrapper", DoNotGenerateAcw = true)]
	public class ContextThemeWrapper : ContextWrapper
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x000100E7 File Offset: 0x0000E2E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContextThemeWrapper._members;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000100F0 File Offset: 0x0000E2F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContextThemeWrapper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00010114 File Offset: 0x0000E314
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContextThemeWrapper._members.ManagedPeerType;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00010120 File Offset: 0x0000E320
		protected ContextThemeWrapper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001D4 RID: 468
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ContextThemeWrapper", typeof(ContextThemeWrapper));
	}
}
