using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A7 RID: 423
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/IntSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class IntSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x00043BB4 File Offset: 0x00041DB4
		internal new static IntPtr class_ref
		{
			get
			{
				return IntSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00043BD8 File Offset: 0x00041DD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntSpreadBuilder._members;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00043BE0 File Offset: 0x00041DE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00043C04 File Offset: 0x00041E04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00043C10 File Offset: 0x00041E10
		internal IntSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00043C1C File Offset: 0x00041E1C
		[Register(".ctor", "(I)V", "")]
		public unsafe IntSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(IntSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IntSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00043CA0 File Offset: 0x00041EA0
		[Register("add", "(I)V", "")]
		public unsafe void Add(int value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			IntSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(I)V", this, ptr);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00043CDC File Offset: 0x00041EDC
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = IntSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00043D44 File Offset: 0x00041F44
		[Register("toArray", "()[I", "")]
		public int[] ToArray()
		{
			return (int[])JNIEnv.GetArray(IntSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[I", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x040006BC RID: 1724
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/IntSpreadBuilder", typeof(IntSpreadBuilder));
	}
}
