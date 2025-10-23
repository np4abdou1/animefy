using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000BF RID: 191
	[Register("android/widget/CompoundButton", DoNotGenerateAcw = true)]
	internal class CompoundButtonInvoker : CompoundButton
	{
		// Token: 0x060003AE RID: 942 RVA: 0x00005C3C File Offset: 0x00003E3C
		public CompoundButtonInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00006549 File Offset: 0x00004749
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompoundButtonInvoker._members;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00006550 File Offset: 0x00004750
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompoundButtonInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400009C RID: 156
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/CompoundButton", typeof(CompoundButtonInvoker));
	}
}
