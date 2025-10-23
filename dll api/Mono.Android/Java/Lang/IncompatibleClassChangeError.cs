using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003DB RID: 987
	[Register("java/lang/IncompatibleClassChangeError", DoNotGenerateAcw = true)]
	public class IncompatibleClassChangeError : LinkageError
	{
		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x00078ABF File Offset: 0x00076CBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IncompatibleClassChangeError._members;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x00078AC8 File Offset: 0x00076CC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IncompatibleClassChangeError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x00078AEC File Offset: 0x00076CEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IncompatibleClassChangeError._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00078AF8 File Offset: 0x00076CF8
		protected IncompatibleClassChangeError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00078B04 File Offset: 0x00076D04
		public unsafe IncompatibleClassChangeError(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(IncompatibleClassChangeError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IncompatibleClassChangeError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001167 RID: 4455
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/IncompatibleClassChangeError", typeof(IncompatibleClassChangeError));
	}
}
