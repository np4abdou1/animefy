using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000192 RID: 402
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ByteSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class ByteSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		internal new static IntPtr class_ref
		{
			get
			{
				return ByteSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteSpreadBuilder._members;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00040000 File Offset: 0x0003E200
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00040024 File Offset: 0x0003E224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00040030 File Offset: 0x0003E230
		internal ByteSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0004003C File Offset: 0x0003E23C
		[Register(".ctor", "(I)V", "")]
		public unsafe ByteSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(ByteSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ByteSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x000400C0 File Offset: 0x0003E2C0
		[Register("add", "(B)V", "")]
		public unsafe void Add(sbyte value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			ByteSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(B)V", this, ptr);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x000400FC File Offset: 0x0003E2FC
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = ByteSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00040164 File Offset: 0x0003E364
		[Register("toArray", "()[B", "")]
		public byte[] ToArray()
		{
			return (byte[])JNIEnv.GetArray(ByteSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0400067D RID: 1661
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ByteSpreadBuilder", typeof(ByteSpreadBuilder));
	}
}
