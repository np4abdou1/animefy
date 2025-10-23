using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text
{
	// Token: 0x020001AF RID: 431
	[Register("android/text/Layout", DoNotGenerateAcw = true)]
	internal class LayoutInvoker : Layout
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x0002791E File Offset: 0x00025B1E
		public LayoutInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00027928 File Offset: 0x00025B28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LayoutInvoker._members;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0002792F File Offset: 0x00025B2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LayoutInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400071C RID: 1820
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/Layout", typeof(LayoutInvoker));
	}
}
