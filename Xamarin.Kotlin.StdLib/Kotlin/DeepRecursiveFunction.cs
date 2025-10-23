using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin
{
	// Token: 0x02000046 RID: 70
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/DeepRecursiveFunction", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"R"
	})]
	public sealed class DeepRecursiveFunction : Java.Lang.Object
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002770 File Offset: 0x00000970
		internal static IntPtr class_ref
		{
			get
			{
				return DeepRecursiveFunction._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002794 File Offset: 0x00000994
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeepRecursiveFunction._members;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000279C File Offset: 0x0000099C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeepRecursiveFunction._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000027C0 File Offset: 0x000009C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeepRecursiveFunction._members.ManagedPeerType;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000027CC File Offset: 0x000009CC
		internal DeepRecursiveFunction(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000027D8 File Offset: 0x000009D8
		[Register(".ctor", "(Lkotlin/jvm/functions/Function3;)V", "")]
		public unsafe DeepRecursiveFunction(IFunction3 block) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				base.SetHandle(DeepRecursiveFunction._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/functions/Function3;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeepRecursiveFunction._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/functions/Function3;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(block);
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DeepRecursiveFunction", typeof(DeepRecursiveFunction));
	}
}
