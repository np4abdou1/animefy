using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000323 RID: 803
	[Register("java/util/NoSuchElementException", DoNotGenerateAcw = true)]
	public class NoSuchElementException : RuntimeException
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x0006084D File Offset: 0x0005EA4D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NoSuchElementException._members;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x00060854 File Offset: 0x0005EA54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NoSuchElementException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x00060878 File Offset: 0x0005EA78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NoSuchElementException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00060884 File Offset: 0x0005EA84
		protected NoSuchElementException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00060890 File Offset: 0x0005EA90
		public unsafe NoSuchElementException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NoSuchElementException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NoSuchElementException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000E1A RID: 3610
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/NoSuchElementException", typeof(NoSuchElementException));
	}
}
