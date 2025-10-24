using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000C5 RID: 197
	[Register("android/widget/Filter", DoNotGenerateAcw = true)]
	internal class FilterInvoker : Filter
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x00006B13 File Offset: 0x00004D13
		public FilterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00006B1D File Offset: 0x00004D1D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FilterInvoker._members;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00006B24 File Offset: 0x00004D24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FilterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Filter", typeof(FilterInvoker));
	}
}
