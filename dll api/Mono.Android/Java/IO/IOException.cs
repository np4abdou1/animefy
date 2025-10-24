using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x0200041D RID: 1053
	[Register("java/io/IOException", DoNotGenerateAcw = true)]
	public class IOException : Java.Lang.Exception
	{
		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x0007E29A File Offset: 0x0007C49A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOException._members;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x0007E2A4 File Offset: 0x0007C4A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IOException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x0007E2C8 File Offset: 0x0007C4C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x0007A144 File Offset: 0x00078344
		protected IOException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x0007E2D4 File Offset: 0x0007C4D4
		public unsafe IOException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(IOException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				IOException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400121C RID: 4636
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/IOException", typeof(IOException));
	}
}
