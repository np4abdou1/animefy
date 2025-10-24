using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E6 RID: 998
	[Register("java/lang/NoClassDefFoundError", DoNotGenerateAcw = true)]
	public class NoClassDefFoundError : LinkageError
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x00079619 File Offset: 0x00077819
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NoClassDefFoundError._members;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x00079620 File Offset: 0x00077820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NoClassDefFoundError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x00079644 File Offset: 0x00077844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NoClassDefFoundError._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00078AF8 File Offset: 0x00076CF8
		protected NoClassDefFoundError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00079650 File Offset: 0x00077850
		public unsafe NoClassDefFoundError(string s) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NoClassDefFoundError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NoClassDefFoundError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04001176 RID: 4470
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/NoClassDefFoundError", typeof(NoClassDefFoundError));
	}
}
