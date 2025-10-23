using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001CD RID: 461
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ShortSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class ShortSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0004B0D0 File Offset: 0x000492D0
		internal new static IntPtr class_ref
		{
			get
			{
				return ShortSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0004B0F4 File Offset: 0x000492F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShortSpreadBuilder._members;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0004B0FC File Offset: 0x000492FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShortSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0004B120 File Offset: 0x00049320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShortSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0004B12C File Offset: 0x0004932C
		internal ShortSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0004B138 File Offset: 0x00049338
		[Register(".ctor", "(I)V", "")]
		public unsafe ShortSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(ShortSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ShortSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0004B1BC File Offset: 0x000493BC
		[Register("add", "(S)V", "")]
		public unsafe void Add(short value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			ShortSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(S)V", this, ptr);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0004B1F8 File Offset: 0x000493F8
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = ShortSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0004B260 File Offset: 0x00049460
		[Register("toArray", "()[S", "")]
		public short[] ToArray()
		{
			return (short[])JNIEnv.GetArray(ShortSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[S", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
		}

		// Token: 0x0400073E RID: 1854
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ShortSpreadBuilder", typeof(ShortSpreadBuilder));
	}
}
