using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003EB RID: 1003
	[Register("java/lang/ReflectiveOperationException", DoNotGenerateAcw = true)]
	public class ReflectiveOperationException : Exception
	{
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x0007A10C File Offset: 0x0007830C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ReflectiveOperationException._members;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x0007A114 File Offset: 0x00078314
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ReflectiveOperationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x0007A138 File Offset: 0x00078338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ReflectiveOperationException._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0007A144 File Offset: 0x00078344
		protected ReflectiveOperationException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x0007A150 File Offset: 0x00078350
		public unsafe ReflectiveOperationException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ReflectiveOperationException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ReflectiveOperationException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400118B RID: 4491
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ReflectiveOperationException", typeof(ReflectiveOperationException));
	}
}
