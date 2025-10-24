using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003EC RID: 1004
	[Register("java/lang/RuntimeException", DoNotGenerateAcw = true)]
	public class RuntimeException : Exception
	{
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x0007A20F File Offset: 0x0007840F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RuntimeException._members;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x0007A218 File Offset: 0x00078418
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RuntimeException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x0007A23C File Offset: 0x0007843C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RuntimeException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x0007A144 File Offset: 0x00078344
		protected RuntimeException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x0007A248 File Offset: 0x00078448
		public unsafe RuntimeException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(RuntimeException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RuntimeException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400118C RID: 4492
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/RuntimeException", typeof(RuntimeException));
	}
}
