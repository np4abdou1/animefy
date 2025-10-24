using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C5 RID: 965
	[Register("java/lang/ClassNotFoundException", DoNotGenerateAcw = true)]
	public class ClassNotFoundException : ReflectiveOperationException
	{
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x00077163 File Offset: 0x00075363
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClassNotFoundException._members;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0007716C File Offset: 0x0007536C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClassNotFoundException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x00077190 File Offset: 0x00075390
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClassNotFoundException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0007719C File Offset: 0x0007539C
		protected ClassNotFoundException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000771A8 File Offset: 0x000753A8
		public unsafe ClassNotFoundException(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ClassNotFoundException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ClassNotFoundException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001137 RID: 4407
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ClassNotFoundException", typeof(ClassNotFoundException));
	}
}
