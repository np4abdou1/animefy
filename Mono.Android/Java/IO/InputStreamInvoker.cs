using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x0200041C RID: 1052
	[Register("java/io/InputStream", DoNotGenerateAcw = true)]
	internal class InputStreamInvoker : InputStream
	{
		// Token: 0x06002E0F RID: 11791 RVA: 0x0007DB70 File Offset: 0x0007BD70
		public InputStreamInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x0007E253 File Offset: 0x0007C453
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputStreamInvoker._members;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x0007E25A File Offset: 0x0007C45A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputStreamInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x0007E266 File Offset: 0x0007C466
		public override int Read()
		{
			return InputStreamInvoker._members.InstanceMethods.InvokeAbstractInt32Method("read.()I", this, null);
		}

		// Token: 0x0400121B RID: 4635
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/InputStream", typeof(InputStreamInvoker));
	}
}
