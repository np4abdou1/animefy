using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200019A RID: 410
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/FloatSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class FloatSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00041890 File Offset: 0x0003FA90
		internal new static IntPtr class_ref
		{
			get
			{
				return FloatSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000418B4 File Offset: 0x0003FAB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FloatSpreadBuilder._members;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x000418BC File Offset: 0x0003FABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FloatSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x000418E0 File Offset: 0x0003FAE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FloatSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000418EC File Offset: 0x0003FAEC
		internal FloatSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000418F8 File Offset: 0x0003FAF8
		[Register(".ctor", "(I)V", "")]
		public unsafe FloatSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(FloatSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			FloatSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0004197C File Offset: 0x0003FB7C
		[Register("add", "(F)V", "")]
		public unsafe void Add(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			FloatSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(F)V", this, ptr);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000419B8 File Offset: 0x0003FBB8
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = FloatSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00041A20 File Offset: 0x0003FC20
		[Register("toArray", "()[F", "")]
		public float[] ToArray()
		{
			return (float[])JNIEnv.GetArray(FloatSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[F", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(float));
		}

		// Token: 0x04000697 RID: 1687
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/FloatSpreadBuilder", typeof(FloatSpreadBuilder));
	}
}
