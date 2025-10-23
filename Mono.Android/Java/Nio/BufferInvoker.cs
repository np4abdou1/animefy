using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Nio
{
	// Token: 0x02000372 RID: 882
	[Register("java/nio/Buffer", DoNotGenerateAcw = true)]
	internal class BufferInvoker : Buffer
	{
		// Token: 0x060026F4 RID: 9972 RVA: 0x0006F253 File Offset: 0x0006D453
		public BufferInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x0006F25D File Offset: 0x0006D45D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BufferInvoker._members;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0006F264 File Offset: 0x0006D464
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BufferInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400100A RID: 4106
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/Buffer", typeof(BufferInvoker));
	}
}
