using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003DC RID: 988
	[Register("java/lang/IndexOutOfBoundsException", DoNotGenerateAcw = true)]
	public class IndexOutOfBoundsException : RuntimeException
	{
		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x00078BC3 File Offset: 0x00076DC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IndexOutOfBoundsException._members;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x00078BCC File Offset: 0x00076DCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IndexOutOfBoundsException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x00078BF0 File Offset: 0x00076DF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IndexOutOfBoundsException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00060884 File Offset: 0x0005EA84
		protected IndexOutOfBoundsException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00078BFC File Offset: 0x00076DFC
		public unsafe IndexOutOfBoundsException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(IndexOutOfBoundsException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IndexOutOfBoundsException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001168 RID: 4456
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/IndexOutOfBoundsException", typeof(IndexOutOfBoundsException));
	}
}
