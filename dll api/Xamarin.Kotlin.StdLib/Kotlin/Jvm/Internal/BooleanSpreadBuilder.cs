using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000191 RID: 401
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/BooleanSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class BooleanSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		internal new static IntPtr class_ref
		{
			get
			{
				return BooleanSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0003FE0C File Offset: 0x0003E00C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BooleanSpreadBuilder._members;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0003FE14 File Offset: 0x0003E014
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BooleanSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0003FE38 File Offset: 0x0003E038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BooleanSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0003FE44 File Offset: 0x0003E044
		internal BooleanSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0003FE50 File Offset: 0x0003E050
		[Register(".ctor", "(I)V", "")]
		public unsafe BooleanSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(BooleanSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			BooleanSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0003FED4 File Offset: 0x0003E0D4
		[Register("add", "(Z)V", "")]
		public unsafe void Add(bool value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			BooleanSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(Z)V", this, ptr);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0003FF10 File Offset: 0x0003E110
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = BooleanSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0003FF78 File Offset: 0x0003E178
		[Register("toArray", "()[Z", "")]
		public bool[] ToArray()
		{
			return (bool[])JNIEnv.GetArray(BooleanSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[Z", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(bool));
		}

		// Token: 0x0400067C RID: 1660
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/BooleanSpreadBuilder", typeof(BooleanSpreadBuilder));
	}
}
