using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/TypeCastException", DoNotGenerateAcw = true)]
	public class TypeCastException : ClassCastException
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0000AB38 File Offset: 0x00008D38
		internal static IntPtr class_ref
		{
			get
			{
				return TypeCastException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000AB5C File Offset: 0x00008D5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeCastException._members;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0000AB64 File Offset: 0x00008D64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeCastException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000AB88 File Offset: 0x00008D88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeCastException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000AB94 File Offset: 0x00008D94
		protected TypeCastException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		[Register(".ctor", "()V", "")]
		public TypeCastException() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TypeCastException._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TypeCastException._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000AC10 File Offset: 0x00008E10
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TypeCastException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(TypeCastException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TypeCastException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/TypeCastException", typeof(TypeCastException));
	}
}
