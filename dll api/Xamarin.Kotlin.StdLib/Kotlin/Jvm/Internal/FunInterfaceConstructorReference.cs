using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200019C RID: 412
	[Register("kotlin/jvm/internal/FunInterfaceConstructorReference", DoNotGenerateAcw = true)]
	public class FunInterfaceConstructorReference : FunctionReference, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00041F78 File Offset: 0x00040178
		internal new static IntPtr class_ref
		{
			get
			{
				return FunInterfaceConstructorReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00041F9C File Offset: 0x0004019C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return FunInterfaceConstructorReference._members;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00041FA4 File Offset: 0x000401A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FunInterfaceConstructorReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00041FC8 File Offset: 0x000401C8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return FunInterfaceConstructorReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00041FD4 File Offset: 0x000401D4
		protected FunInterfaceConstructorReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00041FE0 File Offset: 0x000401E0
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe FunInterfaceConstructorReference(Class funInterface) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((funInterface == null) ? IntPtr.Zero : funInterface.Handle);
				base.SetHandle(FunInterfaceConstructorReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FunInterfaceConstructorReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(funInterface);
			}
		}

		// Token: 0x0400069F RID: 1695
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/FunInterfaceConstructorReference", typeof(FunInterfaceConstructorReference));
	}
}
