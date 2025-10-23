using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide
{
	// Token: 0x02000043 RID: 67
	[Register("com/bumptech/glide/TransitionOptions", DoNotGenerateAcw = true)]
	internal class TransitionOptionsInvoker : TransitionOptions
	{
		// Token: 0x060002FB RID: 763 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public TransitionOptionsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000A4DE File Offset: 0x000086DE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransitionOptionsInvoker._members;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000A4E5 File Offset: 0x000086E5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransitionOptionsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000A3 RID: 163
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/TransitionOptions", typeof(TransitionOptionsInvoker));
	}
}
