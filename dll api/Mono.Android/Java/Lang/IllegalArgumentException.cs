using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003D9 RID: 985
	[Register("java/lang/IllegalArgumentException", DoNotGenerateAcw = true)]
	public class IllegalArgumentException : RuntimeException
	{
		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000788D0 File Offset: 0x00076AD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IllegalArgumentException._members;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x000788D8 File Offset: 0x00076AD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IllegalArgumentException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000788FC File Offset: 0x00076AFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IllegalArgumentException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00060884 File Offset: 0x0005EA84
		protected IllegalArgumentException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00078908 File Offset: 0x00076B08
		public unsafe IllegalArgumentException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(s);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(IllegalArgumentException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IllegalArgumentException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001165 RID: 4453
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/IllegalArgumentException", typeof(IllegalArgumentException));
	}
}
