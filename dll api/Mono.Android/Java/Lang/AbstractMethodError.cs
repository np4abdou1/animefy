using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003BA RID: 954
	[Register("java/lang/AbstractMethodError", DoNotGenerateAcw = true)]
	public class AbstractMethodError : IncompatibleClassChangeError
	{
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x00075E87 File Offset: 0x00074087
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMethodError._members;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x00075E90 File Offset: 0x00074090
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMethodError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x00075EB4 File Offset: 0x000740B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMethodError._members.ManagedPeerType;
			}
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00075EC0 File Offset: 0x000740C0
		protected AbstractMethodError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00075ECC File Offset: 0x000740CC
		public AbstractMethodError() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractMethodError._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractMethodError._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00075F3C File Offset: 0x0007413C
		public unsafe AbstractMethodError(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(AbstractMethodError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbstractMethodError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400111E RID: 4382
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/AbstractMethodError", typeof(AbstractMethodError));
	}
}
