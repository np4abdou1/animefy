using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003F9 RID: 1017
	[Register("java/lang/UnsupportedOperationException", DoNotGenerateAcw = true)]
	public class UnsupportedOperationException : RuntimeException
	{
		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x0007B4E4 File Offset: 0x000796E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnsupportedOperationException._members;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x0007B4EC File Offset: 0x000796EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnsupportedOperationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x0007B510 File Offset: 0x00079710
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnsupportedOperationException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00060884 File Offset: 0x0005EA84
		protected UnsupportedOperationException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0007B51C File Offset: 0x0007971C
		public unsafe UnsupportedOperationException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(UnsupportedOperationException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UnsupportedOperationException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040011B1 RID: 4529
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/UnsupportedOperationException", typeof(UnsupportedOperationException));
	}
}
