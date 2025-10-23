using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C2 RID: 962
	[Register("java/lang/ClassCastException", DoNotGenerateAcw = true)]
	public class ClassCastException : RuntimeException
	{
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x00076FE0 File Offset: 0x000751E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClassCastException._members;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x00076FE8 File Offset: 0x000751E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClassCastException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x0007700C File Offset: 0x0007520C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClassCastException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00060884 File Offset: 0x0005EA84
		protected ClassCastException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x00077018 File Offset: 0x00075218
		public unsafe ClassCastException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ClassCastException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ClassCastException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001134 RID: 4404
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ClassCastException", typeof(ClassCastException));
	}
}
