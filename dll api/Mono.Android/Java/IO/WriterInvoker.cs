using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x02000427 RID: 1063
	[Register("java/io/Writer", DoNotGenerateAcw = true)]
	internal class WriterInvoker : Writer
	{
		// Token: 0x06002E77 RID: 11895 RVA: 0x0007E814 File Offset: 0x0007CA14
		public WriterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x0007EF49 File Offset: 0x0007D149
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WriterInvoker._members;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x0007EF50 File Offset: 0x0007D150
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WriterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x0007EF5C File Offset: 0x0007D15C
		public override void Close()
		{
			WriterInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x0007EF75 File Offset: 0x0007D175
		public override void Flush()
		{
			WriterInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("flush.()V", this, null);
		}

		// Token: 0x04001236 RID: 4662
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Writer", typeof(WriterInvoker));
	}
}
