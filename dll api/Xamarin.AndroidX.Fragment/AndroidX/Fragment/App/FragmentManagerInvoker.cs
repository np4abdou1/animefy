using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000043 RID: 67
	[Register("androidx/fragment/app/FragmentManager", DoNotGenerateAcw = true)]
	internal class FragmentManagerInvoker : FragmentManager
	{
		// Token: 0x06000390 RID: 912 RVA: 0x0000B981 File Offset: 0x00009B81
		public FragmentManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000B98B File Offset: 0x00009B8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentManagerInvoker._members;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000B992 File Offset: 0x00009B92
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000F0 RID: 240
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentManager", typeof(FragmentManagerInvoker));
	}
}
