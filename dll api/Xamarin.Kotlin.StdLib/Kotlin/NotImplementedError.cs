using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200008D RID: 141
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/NotImplementedError", DoNotGenerateAcw = true)]
	public sealed class NotImplementedError : Error
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00009798 File Offset: 0x00007998
		internal static IntPtr class_ref
		{
			get
			{
				return NotImplementedError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000097BC File Offset: 0x000079BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotImplementedError._members;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000097C4 File Offset: 0x000079C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotImplementedError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000097E8 File Offset: 0x000079E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotImplementedError._members.ManagedPeerType;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000097F4 File Offset: 0x000079F4
		internal NotImplementedError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00009800 File Offset: 0x00007A00
		[Register(".ctor", "()V", "")]
		public NotImplementedError() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(NotImplementedError._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			NotImplementedError._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00009870 File Offset: 0x00007A70
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe NotImplementedError(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NotImplementedError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NotImplementedError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000144 RID: 324
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/NotImplementedError", typeof(NotImplementedError));
	}
}
