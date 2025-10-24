using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/KotlinNullPointerException", DoNotGenerateAcw = true)]
	public class KotlinNullPointerException : NullPointerException
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00008CEC File Offset: 0x00006EEC
		internal static IntPtr class_ref
		{
			get
			{
				return KotlinNullPointerException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00008D10 File Offset: 0x00006F10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KotlinNullPointerException._members;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00008D18 File Offset: 0x00006F18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KotlinNullPointerException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00008D3C File Offset: 0x00006F3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KotlinNullPointerException._members.ManagedPeerType;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00008D48 File Offset: 0x00006F48
		protected KotlinNullPointerException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00008D54 File Offset: 0x00006F54
		[Register(".ctor", "()V", "")]
		public KotlinNullPointerException() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(KotlinNullPointerException._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			KotlinNullPointerException._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00008DC4 File Offset: 0x00006FC4
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe KotlinNullPointerException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(KotlinNullPointerException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				KotlinNullPointerException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000136 RID: 310
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/KotlinNullPointerException", typeof(KotlinNullPointerException));
	}
}
