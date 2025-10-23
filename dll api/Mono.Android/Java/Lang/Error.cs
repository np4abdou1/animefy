using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C9 RID: 969
	[Register("java/lang/Error", DoNotGenerateAcw = true)]
	public class Error : Throwable
	{
		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0007765A File Offset: 0x0007585A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Error._members;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x00077664 File Offset: 0x00075864
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Error._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x00077688 File Offset: 0x00075888
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Error._members.ManagedPeerType;
			}
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00077694 File Offset: 0x00075894
		protected Error(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000776A0 File Offset: 0x000758A0
		public unsafe Error(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Error._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Error._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400113B RID: 4411
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Error", typeof(Error));
	}
}
