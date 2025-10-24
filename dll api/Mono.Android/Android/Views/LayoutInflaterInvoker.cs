using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x02000139 RID: 313
	[Register("android/view/LayoutInflater", DoNotGenerateAcw = true)]
	internal class LayoutInflaterInvoker : LayoutInflater
	{
		// Token: 0x06000A7D RID: 2685 RVA: 0x0001A4D2 File Offset: 0x000186D2
		public LayoutInflaterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0001A4DC File Offset: 0x000186DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LayoutInflaterInvoker._members;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0001A4E3 File Offset: 0x000186E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LayoutInflaterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000369 RID: 873
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/LayoutInflater", typeof(LayoutInflaterInvoker));
	}
}
