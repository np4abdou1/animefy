using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm
{
	// Token: 0x02000185 RID: 389
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/KotlinReflectionNotSupportedError", DoNotGenerateAcw = true)]
	public class KotlinReflectionNotSupportedError : Error
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0003EC50 File Offset: 0x0003CE50
		internal static IntPtr class_ref
		{
			get
			{
				return KotlinReflectionNotSupportedError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0003EC74 File Offset: 0x0003CE74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KotlinReflectionNotSupportedError._members;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0003EC7C File Offset: 0x0003CE7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KotlinReflectionNotSupportedError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0003ECA0 File Offset: 0x0003CEA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KotlinReflectionNotSupportedError._members.ManagedPeerType;
			}
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0003ECAC File Offset: 0x0003CEAC
		protected KotlinReflectionNotSupportedError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0003ECB8 File Offset: 0x0003CEB8
		[Register(".ctor", "()V", "")]
		public KotlinReflectionNotSupportedError() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(KotlinReflectionNotSupportedError._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			KotlinReflectionNotSupportedError._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0003ED28 File Offset: 0x0003CF28
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe KotlinReflectionNotSupportedError(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(KotlinReflectionNotSupportedError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				KotlinReflectionNotSupportedError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0003EDCC File Offset: 0x0003CFCC
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe KotlinReflectionNotSupportedError(string message, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(KotlinReflectionNotSupportedError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				KotlinReflectionNotSupportedError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0003EE98 File Offset: 0x0003D098
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe KotlinReflectionNotSupportedError(Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(KotlinReflectionNotSupportedError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				KotlinReflectionNotSupportedError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x04000672 RID: 1650
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/KotlinReflectionNotSupportedError", typeof(KotlinReflectionNotSupportedError));
	}
}
