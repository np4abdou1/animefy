using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x02000421 RID: 1057
	[Register("java/io/OutputStream", DoNotGenerateAcw = true)]
	internal class OutputStreamInvoker : OutputStream
	{
		// Token: 0x06002E36 RID: 11830 RVA: 0x0007E767 File Offset: 0x0007C967
		public OutputStreamInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x0007E771 File Offset: 0x0007C971
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OutputStreamInvoker._members;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x0007E778 File Offset: 0x0007C978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OutputStreamInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x0007E784 File Offset: 0x0007C984
		public unsafe override void Write(int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(b);
			OutputStreamInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("write.(I)V", this, ptr);
		}

		// Token: 0x04001225 RID: 4645
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/OutputStream", typeof(OutputStreamInvoker));
	}
}
