using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UninitializedPropertyAccessException", DoNotGenerateAcw = true)]
	public sealed class UninitializedPropertyAccessException : RuntimeException
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0000C608 File Offset: 0x0000A808
		internal static IntPtr class_ref
		{
			get
			{
				return UninitializedPropertyAccessException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000C62C File Offset: 0x0000A82C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UninitializedPropertyAccessException._members;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000C634 File Offset: 0x0000A834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UninitializedPropertyAccessException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000C658 File Offset: 0x0000A858
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UninitializedPropertyAccessException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000C664 File Offset: 0x0000A864
		internal UninitializedPropertyAccessException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000C670 File Offset: 0x0000A870
		[Register(".ctor", "()V", "")]
		public UninitializedPropertyAccessException() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UninitializedPropertyAccessException._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UninitializedPropertyAccessException._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UninitializedPropertyAccessException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(UninitializedPropertyAccessException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UninitializedPropertyAccessException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000C784 File Offset: 0x0000A984
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe UninitializedPropertyAccessException(string message, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(UninitializedPropertyAccessException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UninitializedPropertyAccessException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000C850 File Offset: 0x0000AA50
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe UninitializedPropertyAccessException(Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(UninitializedPropertyAccessException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UninitializedPropertyAccessException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x04000173 RID: 371
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UninitializedPropertyAccessException", typeof(UninitializedPropertyAccessException));
	}
}
