using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000343 RID: 835
	[Register("java/util/concurrent/CancellationException", DoNotGenerateAcw = true)]
	public class CancellationException : IllegalStateException
	{
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x00064043 File Offset: 0x00062243
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellationException._members;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x0006404C File Offset: 0x0006224C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x00064070 File Offset: 0x00062270
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellationException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0006407C File Offset: 0x0006227C
		protected CancellationException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00064088 File Offset: 0x00062288
		public unsafe CancellationException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(CancellationException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CancellationException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000E9B RID: 3739
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/CancellationException", typeof(CancellationException));
	}
}
