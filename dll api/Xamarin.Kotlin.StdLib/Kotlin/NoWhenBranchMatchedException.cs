using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200008E RID: 142
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/NoWhenBranchMatchedException", DoNotGenerateAcw = true)]
	public class NoWhenBranchMatchedException : RuntimeException
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00009930 File Offset: 0x00007B30
		internal static IntPtr class_ref
		{
			get
			{
				return NoWhenBranchMatchedException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00009954 File Offset: 0x00007B54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NoWhenBranchMatchedException._members;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000995C File Offset: 0x00007B5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NoWhenBranchMatchedException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00009980 File Offset: 0x00007B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NoWhenBranchMatchedException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000998C File Offset: 0x00007B8C
		protected NoWhenBranchMatchedException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00009998 File Offset: 0x00007B98
		[Register(".ctor", "()V", "")]
		public NoWhenBranchMatchedException() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(NoWhenBranchMatchedException._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			NoWhenBranchMatchedException._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00009A08 File Offset: 0x00007C08
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe NoWhenBranchMatchedException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NoWhenBranchMatchedException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NoWhenBranchMatchedException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00009AAC File Offset: 0x00007CAC
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe NoWhenBranchMatchedException(string message, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(NoWhenBranchMatchedException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NoWhenBranchMatchedException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00009B78 File Offset: 0x00007D78
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe NoWhenBranchMatchedException(Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(NoWhenBranchMatchedException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NoWhenBranchMatchedException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x04000145 RID: 325
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/NoWhenBranchMatchedException", typeof(NoWhenBranchMatchedException));
	}
}
