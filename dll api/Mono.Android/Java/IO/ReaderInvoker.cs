using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x02000424 RID: 1060
	[Register("java/io/Reader", DoNotGenerateAcw = true)]
	internal class ReaderInvoker : Reader
	{
		// Token: 0x06002E52 RID: 11858 RVA: 0x0007D918 File Offset: 0x0007BB18
		public ReaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x0007EABB File Offset: 0x0007CCBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ReaderInvoker._members;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x0007EAC2 File Offset: 0x0007CCC2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ReaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x0007EACE File Offset: 0x0007CCCE
		public override void Close()
		{
			ReaderInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x0400122C RID: 4652
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Reader", typeof(ReaderInvoker));
	}
}
