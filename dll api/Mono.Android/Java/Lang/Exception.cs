using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003CA RID: 970
	[Register("java/lang/Exception", DoNotGenerateAcw = true)]
	public class Exception : Throwable
	{
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0007775F File Offset: 0x0007595F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Exception._members;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x00077768 File Offset: 0x00075968
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Exception._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0007778C File Offset: 0x0007598C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Exception._members.ManagedPeerType;
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00077694 File Offset: 0x00075894
		protected Exception(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00077798 File Offset: 0x00075998
		public unsafe Exception(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Exception._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Exception._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400113C RID: 4412
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Exception", typeof(Exception));
	}
}
