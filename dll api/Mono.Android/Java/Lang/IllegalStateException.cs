using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003DA RID: 986
	[Register("java/lang/IllegalStateException", DoNotGenerateAcw = true)]
	public class IllegalStateException : RuntimeException
	{
		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000789C7 File Offset: 0x00076BC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IllegalStateException._members;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000789D0 File Offset: 0x00076BD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IllegalStateException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000789F4 File Offset: 0x00076BF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IllegalStateException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00060884 File Offset: 0x0005EA84
		protected IllegalStateException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00078A00 File Offset: 0x00076C00
		public unsafe IllegalStateException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(IllegalStateException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IllegalStateException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001166 RID: 4454
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/IllegalStateException", typeof(IllegalStateException));
	}
}
