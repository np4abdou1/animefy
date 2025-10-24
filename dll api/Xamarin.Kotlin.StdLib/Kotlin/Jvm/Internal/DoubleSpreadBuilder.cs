using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000199 RID: 409
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/DoubleSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class DoubleSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x000416A4 File Offset: 0x0003F8A4
		internal new static IntPtr class_ref
		{
			get
			{
				return DoubleSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x000416C8 File Offset: 0x0003F8C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DoubleSpreadBuilder._members;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x000416D0 File Offset: 0x0003F8D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DoubleSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000416F4 File Offset: 0x0003F8F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DoubleSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00041700 File Offset: 0x0003F900
		internal DoubleSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0004170C File Offset: 0x0003F90C
		[Register(".ctor", "(I)V", "")]
		public unsafe DoubleSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(DoubleSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			DoubleSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00041790 File Offset: 0x0003F990
		[Register("add", "(D)V", "")]
		public unsafe void Add(double value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			DoubleSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(D)V", this, ptr);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000417CC File Offset: 0x0003F9CC
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = DoubleSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00041834 File Offset: 0x0003FA34
		[Register("toArray", "()[D", "")]
		public double[] ToArray()
		{
			return (double[])JNIEnv.GetArray(DoubleSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[D", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(double));
		}

		// Token: 0x04000696 RID: 1686
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/DoubleSpreadBuilder", typeof(DoubleSpreadBuilder));
	}
}
